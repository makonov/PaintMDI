namespace Paint
{
    partial class DocumentForm
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
            SuspendLayout();
            // 
            // DocumentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            Name = "DocumentForm";
            Text = "DocumentForm";
            FormClosing += DocumentForm_FormClosing;
            Load += DocumentForm_Load;
            SizeChanged += DocumentForm_SizeChanged;
            MouseDown += DocumentForm_MouseDown;
            MouseMove += DocumentForm_MouseMove;
            MouseUp += DocumentForm_MouseUp;
            ResumeLayout(false);
        }

        #endregion
    }
}