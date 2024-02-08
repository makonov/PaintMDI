using Paint.DrawingModes;
using System.Diagnostics.Contracts;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        public static Color Color { get; set; }
        public static int PenWidth { get; set; }
        public static DrawingMode DrawingMode { get; set; }
        private ToolStripButton currentSelectedItem = null;
        public static int NewDocumentCount { get; set; }
        public static int StarVertices { get; set; }
        public static double StarRadius { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Color = Color.Black;
            PenWidth = 3;
            NewDocumentCount = 0;
            StarVertices = 5;
            StarRadius = 2;
            DrawingMode = DrawingMode.Pen;
            brushSizeToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveHowToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbout = new AboutForm();
            formAbout.ShowDialog();

        }

        private void brushSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                var form = new CanvasSizeForm();
                form.widthTextBox.Text = activeDocumentForm.OriginalWidth.ToString();
                form.heightTextBox.Text = activeDocumentForm.OriginalHeight.ToString();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int canvasWidth, canvasHeight;

                    if (int.TryParse(form.widthTextBox.Text, out canvasWidth) && int.TryParse(form.heightTextBox.Text, out canvasHeight))
                    {
                        activeDocumentForm.ResetZoom();

                        activeDocumentForm.OriginalWidth = canvasWidth;
                        activeDocumentForm.OriginalHeight = canvasHeight;
                        activeDocumentForm.SetCanvasSize(canvasWidth, canvasHeight);

                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения ширины и высоты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void selectRedColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Red;
        }

        private void selectBlueColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Blue;
        }

        private void selectGreenColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color = Color.Green;
        }

        private void selectAnotherColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialog.Color;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocumentCount += 1;
            var form = new DocumentForm();
            form.ParentForm = this;
            form.MdiParent = this;
            form.Show();
        }

        private void drawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushSizeToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                SaveDocument(activeDocumentForm, false);
            }
        }

        private void saveHowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                SaveDocument(activeDocumentForm, true);
            }
        }

        public bool SaveDocument(DocumentForm document, bool saveAs)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = "Windows Bitmap (*.bmp) |*.bmp| Файлы JPEG (*.jpg) |*.jpg| GIF (*.gif) |*.gif| PNG (*.png) |*.png";
                ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg, ImageFormat.Gif, ImageFormat.Png };

                if (document != null)
                {
                    var bmp = document.Bitmap;

                    if (saveAs || document.Path == null || !File.Exists(document.Path))
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            if (bmp != null)
                            {
                                bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
                                document.Path = dlg.FileName;
                                document.Text = Path.GetFileName(dlg.FileName);
                                document.HasUnsavedChanges = false;

                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Изображение не определено. Выберите изображение перед сохранением.");
                            }
                        }
                    }
                    else
                    {
                        bmp.Save(document.Path, GetImageFormat(document.Path));
                        document.HasUnsavedChanges = false;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }


        private ImageFormat GetImageFormat(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                if (image.RawFormat.Equals(ImageFormat.Jpeg))
                {
                    return ImageFormat.Jpeg;
                }
                else if (image.RawFormat.Equals(ImageFormat.Png))
                {
                    return ImageFormat.Png;
                }
                else if (image.RawFormat.Equals(ImageFormat.Gif))
                {
                    return ImageFormat.Gif;
                }
                else if (image.RawFormat.Equals(ImageFormat.Bmp))
                {
                    return ImageFormat.Bmp;
                }
                else
                {
                    return null;
                }
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Windows Bitmap (*.bmp) |*.bmp| Файлы JPEG (*.jpg) |*.jpg| GIF (*.gif) |*.gif| PNG (*.png) |*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DocumentForm documentForm = new DocumentForm();
                documentForm.Text = dlg.SafeFileName;
                documentForm.Path = dlg.FileName;
                documentForm.LoadImage(dlg.FileName);
                documentForm.MdiParent = this;
                documentForm.ParentForm = this;
                documentForm.Show();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            saveHowToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            DrawingMode = DrawingMode.Ellipse;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            DrawingMode = DrawingMode.Line;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            DrawingMode = DrawingMode.Eraser;
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            DrawingMode = DrawingMode.Pen;
        }

        private void brushSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(brushSizeTextBox.Text))
            {
                PenWidth = 3;
            }
            else
            {
                PenWidth = int.Parse(brushSizeTextBox.Text);
            }
        }

        private void brushSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void instrumentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;

            if (clickedItem is ToolStripButton clickedButton)
            {
                if (clickedButton != currentSelectedItem)
                {
                    if (currentSelectedItem != null)
                    {
                        currentSelectedItem.Checked = false;
                    }

                    currentSelectedItem = clickedButton;
                    currentSelectedItem.Checked = true;
                }
            }
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                activeDocumentForm.ZoomIn();
            }
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                activeDocumentForm.ZoomOut();
            }
        }

        private void starToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            DrawingMode = DrawingMode.Star;
        }

        private void resetZoomToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var activeDocumentForm = (DocumentForm)ActiveMdiChild;
                activeDocumentForm.ResetZoom();
            }
        }

        private void starSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                var form = new StarSettingsForm();
                form.verticeNumberTextBox.Text = StarVertices.ToString();
                form.radiusTextBox.Text = StarRadius.ToString();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int vertices, radius;

                    if (int.TryParse(form.verticeNumberTextBox.Text, out vertices) && int.TryParse(form.radiusTextBox.Text, out radius))
                    {
                        StarVertices = vertices;
                        StarRadius = radius;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения количества вершин и радиуса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void defaultStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StarVertices = 5;
            StarRadius = 2;
        }
    }
}