namespace Paint
{
    partial class PluginSettingsForm
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
            pluginListView = new ListView();
            PluginName = new ColumnHeader();
            Status = new ColumnHeader();
            Author = new ColumnHeader();
            Version = new ColumnHeader();
            changeStatusBtn = new Button();
            deletePluginBtn = new Button();
            loadPluginBtn = new Button();
            SuspendLayout();
            // 
            // pluginListView
            // 
            pluginListView.Columns.AddRange(new ColumnHeader[] { PluginName, Status, Author, Version });
            pluginListView.Location = new Point(12, 12);
            pluginListView.Name = "pluginListView";
            pluginListView.Size = new Size(472, 127);
            pluginListView.TabIndex = 2;
            pluginListView.UseCompatibleStateImageBehavior = false;
            pluginListView.View = View.Details;
            pluginListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // PluginName
            // 
            PluginName.Text = "Название";
            // 
            // Status
            // 
            Status.Text = "Статус";
            // 
            // Author
            // 
            Author.Text = "Автор";
            // 
            // Version
            // 
            Version.Text = "Версия";
            // 
            // changeStatusBtn
            // 
            changeStatusBtn.Location = new Point(12, 159);
            changeStatusBtn.Name = "changeStatusBtn";
            changeStatusBtn.Size = new Size(133, 29);
            changeStatusBtn.TabIndex = 3;
            changeStatusBtn.Text = "Изменить статус";
            changeStatusBtn.UseVisualStyleBackColor = true;
            changeStatusBtn.Click += changeStatusBtn_Click;
            // 
            // deletePluginBtn
            // 
            deletePluginBtn.Location = new Point(151, 159);
            deletePluginBtn.Name = "deletePluginBtn";
            deletePluginBtn.Size = new Size(94, 29);
            deletePluginBtn.TabIndex = 4;
            deletePluginBtn.Text = "Удалить";
            deletePluginBtn.UseVisualStyleBackColor = true;
            deletePluginBtn.Click += deletePluginBtn_Click;
            // 
            // loadPluginBtn
            // 
            loadPluginBtn.Location = new Point(387, 159);
            loadPluginBtn.Name = "loadPluginBtn";
            loadPluginBtn.Size = new Size(94, 29);
            loadPluginBtn.TabIndex = 5;
            loadPluginBtn.Text = "Загрузить";
            loadPluginBtn.UseVisualStyleBackColor = true;
            loadPluginBtn.Click += loadPluginBtn_Click;
            // 
            // PluginSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 213);
            Controls.Add(loadPluginBtn);
            Controls.Add(deletePluginBtn);
            Controls.Add(changeStatusBtn);
            Controls.Add(pluginListView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PluginSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройка плагинов";
            ResumeLayout(false);
        }

        #endregion
        private ListView pluginListView;
        private ColumnHeader PluginName;
        private ColumnHeader Author;
        private ColumnHeader Version;
        private Button changeStatusBtn;
        private Button deletePluginBtn;
        private Button loadPluginBtn;
        private ColumnHeader Status;
    }
}