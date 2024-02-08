namespace Paint
{
    partial class StarSettingsForm
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
            label1 = new Label();
            verticeNumberTextBox = new TextBox();
            OkButton = new Button();
            label2 = new Label();
            radiusTextBox = new TextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Количество вершин:";
            // 
            // verticeNumberTextBox
            // 
            verticeNumberTextBox.Location = new Point(180, 29);
            verticeNumberTextBox.Name = "verticeNumberTextBox";
            verticeNumberTextBox.Size = new Size(125, 27);
            verticeNumberTextBox.TabIndex = 1;
            verticeNumberTextBox.KeyPress += verticeNumberTextBox_KeyPress;
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(102, 128);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 2;
            OkButton.Text = "ОК";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 74);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Радиус:";
            // 
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(180, 71);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(125, 27);
            radiusTextBox.TabIndex = 4;
            radiusTextBox.KeyPress += radiusTextBox_KeyPress;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(202, 128);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // StarSettingsForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelButton;
            ClientSize = new Size(397, 169);
            Controls.Add(CancelButton);
            Controls.Add(radiusTextBox);
            Controls.Add(label2);
            Controls.Add(OkButton);
            Controls.Add(verticeNumberTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StarSettingsForm";
            Text = "Настройка инструмента \"Звезда\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OkButton;
        private Label label2;
        private Button CancelButton;
        public TextBox verticeNumberTextBox;
        public TextBox radiusTextBox;
    }
}