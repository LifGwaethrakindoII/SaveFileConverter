namespace SaveFileConverter
{
    partial class SaveFileConverter
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
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

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            sourceFileTextBox = new TextBox();
            searchButton = new Button();
            targetExtensionDropdown = new ComboBox();
            convertButton = new Button();
            targetLabel = new Label();
            sourceExtensionDropdown = new ComboBox();
            sourceLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sourceFileTextBox
            // 
            sourceFileTextBox.Enabled = false;
            sourceFileTextBox.Location = new Point(139, 212);
            sourceFileTextBox.Name = "sourceFileTextBox";
            sourceFileTextBox.Size = new Size(360, 23);
            sourceFileTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.AccessibleName = "SearchButton";
            searchButton.Location = new Point(505, 212);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += OnSearchButtonClick;
            // 
            // targetExtensionDropdown
            // 
            targetExtensionDropdown.FormattingEnabled = true;
            targetExtensionDropdown.Location = new Point(586, 212);
            targetExtensionDropdown.Name = "targetExtensionDropdown";
            targetExtensionDropdown.Size = new Size(121, 23);
            targetExtensionDropdown.TabIndex = 2;
            // 
            // convertButton
            // 
            convertButton.AccessibleName = "ConvertButton";
            convertButton.Location = new Point(713, 212);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += OnConvertButtonClick;
            // 
            // targetLabel
            // 
            targetLabel.AutoSize = true;
            targetLabel.Location = new Point(586, 194);
            targetLabel.Name = "targetLabel";
            targetLabel.Size = new Size(39, 15);
            targetLabel.TabIndex = 4;
            targetLabel.Text = "Target";
            targetLabel.Click += OnLabelClick;
            // 
            // sourceExtensionDropdown
            // 
            sourceExtensionDropdown.AccessibleName = "SourceExtensionDropdown";
            sourceExtensionDropdown.FormattingEnabled = true;
            sourceExtensionDropdown.Location = new Point(12, 212);
            sourceExtensionDropdown.Name = "sourceExtensionDropdown";
            sourceExtensionDropdown.Size = new Size(121, 23);
            sourceExtensionDropdown.TabIndex = 5;
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Location = new Point(12, 194);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(43, 15);
            sourceLabel.TabIndex = 6;
            sourceLabel.Text = "Source";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(135, 22);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += OnPreferencesClick;
            // 
            // SaveFileConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sourceLabel);
            Controls.Add(sourceExtensionDropdown);
            Controls.Add(targetLabel);
            Controls.Add(convertButton);
            Controls.Add(targetExtensionDropdown);
            Controls.Add(searchButton);
            Controls.Add(sourceFileTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SaveFileConverter";
            Text = "Save File Converter";
            Load += OnLoad;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Button convertButton;
        private ComboBox targetExtensionDropdown;
        private ComboBox sourceExtensionDropdown;
        private Label targetLabel;
        private Label sourceLabel;
        private TextBox sourceFileTextBox;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
    }
}
