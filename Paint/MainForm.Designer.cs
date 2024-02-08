namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveHowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            drawingToolStripMenuItem = new ToolStripMenuItem();
            brushSizeToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            referenceToolStripMenuItem = new ToolStripMenuItem();
            appInfoToolStripMenuItem = new ToolStripMenuItem();
            instrumentToolStrip = new ToolStrip();
            paletteToolStripDropDownButton = new ToolStripDropDownButton();
            selectRedColorToolStripMenuItem = new ToolStripMenuItem();
            selectBlueColorToolStripMenuItem = new ToolStripMenuItem();
            selectGreenColorToolStripMenuItem = new ToolStripMenuItem();
            selectAnotherColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            brushSizeTextBox = new ToolStripTextBox();
            toolStripSeparator4 = new ToolStripSeparator();
            penButton = new ToolStripButton();
            lineButton = new ToolStripButton();
            ellipseButton = new ToolStripButton();
            eraseButton = new ToolStripButton();
            starToolStripDropDownButton = new ToolStripDropDownButton();
            defaultStarToolStripMenuItem = new ToolStripMenuItem();
            starSettingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripSeparator();
            zoomInToolStripButton = new ToolStripButton();
            zoomOutToolStripButton = new ToolStripButton();
            resetZoomToolStripButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            instrumentToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, drawingToolStripMenuItem, windowToolStripMenuItem, referenceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = windowToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveHowToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(201, 26);
            createToolStripMenuItem.Text = "Новый";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(201, 26);
            openToolStripMenuItem.Text = "Открыть...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(198, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(201, 26);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveHowToolStripMenuItem
            // 
            saveHowToolStripMenuItem.Name = "saveHowToolStripMenuItem";
            saveHowToolStripMenuItem.Size = new Size(201, 26);
            saveHowToolStripMenuItem.Text = "Сохранить как...";
            saveHowToolStripMenuItem.Click += saveHowToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // drawingToolStripMenuItem
            // 
            drawingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { brushSizeToolStripMenuItem });
            drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            drawingToolStripMenuItem.Size = new Size(79, 24);
            drawingToolStripMenuItem.Text = "Рисунок";
            drawingToolStripMenuItem.Click += drawingToolStripMenuItem_Click;
            // 
            // brushSizeToolStripMenuItem
            // 
            brushSizeToolStripMenuItem.Name = "brushSizeToolStripMenuItem";
            brushSizeToolStripMenuItem.Size = new Size(201, 26);
            brushSizeToolStripMenuItem.Text = "Размер холста...";
            brushSizeToolStripMenuItem.Click += brushSizeToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(59, 24);
            windowToolStripMenuItem.Text = "Окно";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(236, 26);
            cascadeToolStripMenuItem.Text = "Каскадом";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(236, 26);
            tileVerticalToolStripMenuItem.Text = "Слева направо";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(236, 26);
            tileHorizontalToolStripMenuItem.Text = "Сверху вниз";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(236, 26);
            arrangeIconsToolStripMenuItem.Text = "Упорядочить значки";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // referenceToolStripMenuItem
            // 
            referenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { appInfoToolStripMenuItem });
            referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            referenceToolStripMenuItem.Size = new Size(81, 24);
            referenceToolStripMenuItem.Text = "Справка";
            // 
            // appInfoToolStripMenuItem
            // 
            appInfoToolStripMenuItem.Name = "appInfoToolStripMenuItem";
            appInfoToolStripMenuItem.Size = new Size(187, 26);
            appInfoToolStripMenuItem.Text = "О программе";
            appInfoToolStripMenuItem.Click += appInfoToolStripMenuItem_Click;
            // 
            // instrumentToolStrip
            // 
            instrumentToolStrip.ImageScalingSize = new Size(20, 20);
            instrumentToolStrip.Items.AddRange(new ToolStripItem[] { paletteToolStripDropDownButton, toolStripSeparator3, toolStripLabel1, brushSizeTextBox, toolStripSeparator4, penButton, lineButton, ellipseButton, eraseButton, starToolStripDropDownButton, toolStripButton1, zoomInToolStripButton, zoomOutToolStripButton, resetZoomToolStripButton });
            instrumentToolStrip.Location = new Point(0, 28);
            instrumentToolStrip.Name = "instrumentToolStrip";
            instrumentToolStrip.Size = new Size(800, 27);
            instrumentToolStrip.TabIndex = 2;
            instrumentToolStrip.Text = "toolStrip1";
            instrumentToolStrip.ItemClicked += instrumentToolStrip_ItemClicked;
            // 
            // paletteToolStripDropDownButton
            // 
            paletteToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            paletteToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { selectRedColorToolStripMenuItem, selectBlueColorToolStripMenuItem, selectGreenColorToolStripMenuItem, selectAnotherColorToolStripMenuItem });
            paletteToolStripDropDownButton.Image = (Image)resources.GetObject("paletteToolStripDropDownButton.Image");
            paletteToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            paletteToolStripDropDownButton.Name = "paletteToolStripDropDownButton";
            paletteToolStripDropDownButton.Size = new Size(34, 24);
            paletteToolStripDropDownButton.Text = "Палитра";
            // 
            // selectRedColorToolStripMenuItem
            // 
            selectRedColorToolStripMenuItem.Name = "selectRedColorToolStripMenuItem";
            selectRedColorToolStripMenuItem.Size = new Size(224, 26);
            selectRedColorToolStripMenuItem.Text = "Красный";
            selectRedColorToolStripMenuItem.Click += selectRedColorToolStripMenuItem_Click;
            // 
            // selectBlueColorToolStripMenuItem
            // 
            selectBlueColorToolStripMenuItem.Name = "selectBlueColorToolStripMenuItem";
            selectBlueColorToolStripMenuItem.Size = new Size(224, 26);
            selectBlueColorToolStripMenuItem.Text = "Синий";
            selectBlueColorToolStripMenuItem.Click += selectBlueColorToolStripMenuItem_Click;
            // 
            // selectGreenColorToolStripMenuItem
            // 
            selectGreenColorToolStripMenuItem.Name = "selectGreenColorToolStripMenuItem";
            selectGreenColorToolStripMenuItem.Size = new Size(224, 26);
            selectGreenColorToolStripMenuItem.Text = "Зеленый";
            selectGreenColorToolStripMenuItem.Click += selectGreenColorToolStripMenuItem_Click;
            // 
            // selectAnotherColorToolStripMenuItem
            // 
            selectAnotherColorToolStripMenuItem.Name = "selectAnotherColorToolStripMenuItem";
            selectAnotherColorToolStripMenuItem.Size = new Size(224, 26);
            selectAnotherColorToolStripMenuItem.Text = "Другой";
            selectAnotherColorToolStripMenuItem.Click += selectAnotherColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(51, 24);
            toolStripLabel1.Text = "Кисть:";
            // 
            // brushSizeTextBox
            // 
            brushSizeTextBox.MaxLength = 3;
            brushSizeTextBox.Name = "brushSizeTextBox";
            brushSizeTextBox.Size = new Size(30, 27);
            brushSizeTextBox.Text = "3";
            brushSizeTextBox.KeyPress += brushSizeTextBox_KeyPress;
            brushSizeTextBox.TextChanged += brushSizeTextBox_TextChanged;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // penButton
            // 
            penButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            penButton.Image = (Image)resources.GetObject("penButton.Image");
            penButton.ImageTransparentColor = Color.Magenta;
            penButton.Name = "penButton";
            penButton.Size = new Size(29, 24);
            penButton.Text = "Перо";
            penButton.Click += penButton_Click;
            // 
            // lineButton
            // 
            lineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            lineButton.Image = (Image)resources.GetObject("lineButton.Image");
            lineButton.ImageTransparentColor = Color.Magenta;
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(29, 24);
            lineButton.Text = "Линия";
            lineButton.Click += lineButton_Click;
            // 
            // ellipseButton
            // 
            ellipseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ellipseButton.Image = (Image)resources.GetObject("ellipseButton.Image");
            ellipseButton.ImageTransparentColor = Color.Magenta;
            ellipseButton.Name = "ellipseButton";
            ellipseButton.Size = new Size(29, 24);
            ellipseButton.Text = "Эллипс";
            ellipseButton.Click += ellipseButton_Click;
            // 
            // eraseButton
            // 
            eraseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            eraseButton.Image = (Image)resources.GetObject("eraseButton.Image");
            eraseButton.ImageTransparentColor = Color.Magenta;
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(29, 24);
            eraseButton.Text = "Ластик";
            eraseButton.Click += eraseButton_Click;
            // 
            // starToolStripDropDownButton
            // 
            starToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            starToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { defaultStarToolStripMenuItem, starSettingsToolStripMenuItem });
            starToolStripDropDownButton.Image = (Image)resources.GetObject("starToolStripDropDownButton.Image");
            starToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            starToolStripDropDownButton.Name = "starToolStripDropDownButton";
            starToolStripDropDownButton.Size = new Size(34, 24);
            starToolStripDropDownButton.Text = "Звезда";
            starToolStripDropDownButton.Click += starToolStripDropDownButton_Click;
            // 
            // defaultStarToolStripMenuItem
            // 
            defaultStarToolStripMenuItem.Name = "defaultStarToolStripMenuItem";
            defaultStarToolStripMenuItem.Size = new Size(246, 26);
            defaultStarToolStripMenuItem.Text = "Звезда по умолчанию";
            defaultStarToolStripMenuItem.Click += defaultStarToolStripMenuItem_Click;
            // 
            // starSettingsToolStripMenuItem
            // 
            starSettingsToolStripMenuItem.Name = "starSettingsToolStripMenuItem";
            starSettingsToolStripMenuItem.Size = new Size(246, 26);
            starSettingsToolStripMenuItem.Text = "Настроить";
            starSettingsToolStripMenuItem.Click += starSettingsToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(6, 27);
            // 
            // zoomInToolStripButton
            // 
            zoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomInToolStripButton.Image = (Image)resources.GetObject("zoomInToolStripButton.Image");
            zoomInToolStripButton.ImageTransparentColor = Color.Magenta;
            zoomInToolStripButton.Name = "zoomInToolStripButton";
            zoomInToolStripButton.Size = new Size(29, 24);
            zoomInToolStripButton.Text = "Масштаб+";
            zoomInToolStripButton.Click += zoomInToolStripButton_Click;
            // 
            // zoomOutToolStripButton
            // 
            zoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomOutToolStripButton.Image = (Image)resources.GetObject("zoomOutToolStripButton.Image");
            zoomOutToolStripButton.ImageTransparentColor = Color.Magenta;
            zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            zoomOutToolStripButton.Size = new Size(29, 24);
            zoomOutToolStripButton.Text = "Масштаб-";
            zoomOutToolStripButton.Click += zoomOutToolStripButton_Click;
            // 
            // resetZoomToolStripButton
            // 
            resetZoomToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resetZoomToolStripButton.Image = (Image)resources.GetObject("resetZoomToolStripButton.Image");
            resetZoomToolStripButton.ImageTransparentColor = Color.Magenta;
            resetZoomToolStripButton.Name = "resetZoomToolStripButton";
            resetZoomToolStripButton.Size = new Size(29, 24);
            resetZoomToolStripButton.Text = "Оригинальный масштаб";
            resetZoomToolStripButton.Click += resetZoomToolStripButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(instrumentToolStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "PaintMDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            instrumentToolStrip.ResumeLayout(false);
            instrumentToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveHowToolStripMenuItem;
        private ToolStripMenuItem drawingToolStripMenuItem;
        private ToolStripMenuItem brushSizeToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem referenceToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem appInfoToolStripMenuItem;
        private ToolStrip instrumentToolStrip;
        private ToolStripDropDownButton paletteToolStripDropDownButton;
        private ToolStripMenuItem selectRedColorToolStripMenuItem;
        private ToolStripMenuItem selectBlueColorToolStripMenuItem;
        private ToolStripMenuItem selectGreenColorToolStripMenuItem;
        private ToolStripMenuItem selectAnotherColorToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox brushSizeTextBox;
        private ToolStripButton penButton;
        private ToolStripButton lineButton;
        private ToolStripButton ellipseButton;
        private ToolStripButton eraseButton;
        private ToolStripButton zoomInToolStripButton;
        private ToolStripButton zoomOutToolStripButton;
        private ToolStripDropDownButton starToolStripDropDownButton;
        private ToolStripButton resetZoomToolStripButton;
        private ToolStripMenuItem starSettingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripButton1;
        private ToolStripMenuItem defaultStarToolStripMenuItem;
    }
}