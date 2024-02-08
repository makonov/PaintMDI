namespace Paint
{
    partial class CanvasSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new Button();
            label1 = new Label();
            label2 = new Label();
            widthTextBox = new TextBox();
            heightTextBox = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(269, 111);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 32);
            btnOK.TabIndex = 0;
            btnOK.Text = "ОК";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Ширина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 37);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Высота:";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(100, 34);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 3;
            widthTextBox.KeyPress += widthTextBox_KeyPress;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(365, 34);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 4;
            heightTextBox.KeyPress += heightTextBox_KeyPress;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(385, 111);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CanvasSizeForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(511, 155);
            Controls.Add(btnCancel);
            Controls.Add(heightTextBox);
            Controls.Add(widthTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CanvasSizeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Размер холста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        public TextBox widthTextBox;
        public TextBox heightTextBox;
    }
}