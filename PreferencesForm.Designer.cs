namespace SaveFileConverter
{
    partial class PreferencesForm
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
            defaultSourceLabel = new Label();
            defaultTargetLabel = new Label();
            defaultSearchPathLabel = new Label();
            defaultSourceDropdown = new ComboBox();
            textBox1 = new TextBox();
            applyButton = new Button();
            closeButton = new Button();
            searchPathButton = new Button();
            defaultButton = new Button();
            defaultTargetDropdown = new ComboBox();
            SuspendLayout();
            // 
            // defaultSourceLabel
            // 
            defaultSourceLabel.AutoSize = true;
            defaultSourceLabel.Location = new Point(26, 31);
            defaultSourceLabel.Name = "defaultSourceLabel";
            defaultSourceLabel.Size = new Size(84, 15);
            defaultSourceLabel.TabIndex = 0;
            defaultSourceLabel.Text = "Default Source";
            // 
            // defaultTargetLabel
            // 
            defaultTargetLabel.AutoSize = true;
            defaultTargetLabel.Location = new Point(26, 60);
            defaultTargetLabel.Name = "defaultTargetLabel";
            defaultTargetLabel.Size = new Size(80, 15);
            defaultTargetLabel.TabIndex = 1;
            defaultTargetLabel.Text = "Default Target";
            // 
            // defaultSearchPathLabel
            // 
            defaultSearchPathLabel.AutoSize = true;
            defaultSearchPathLabel.Location = new Point(26, 89);
            defaultSearchPathLabel.Name = "defaultSearchPathLabel";
            defaultSearchPathLabel.Size = new Size(110, 15);
            defaultSearchPathLabel.TabIndex = 2;
            defaultSearchPathLabel.Text = "Default Search Path";
            // 
            // defaultSourceDropdown
            // 
            defaultSourceDropdown.FormattingEnabled = true;
            defaultSourceDropdown.Location = new Point(157, 31);
            defaultSourceDropdown.Name = "defaultSourceDropdown";
            defaultSourceDropdown.Size = new Size(449, 23);
            defaultSourceDropdown.TabIndex = 3;
            defaultSourceDropdown.DisplayMemberChanged += OnDefaultSourceValueChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(157, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 5;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(713, 415);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 6;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(632, 415);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // searchPathButton
            // 
            searchPathButton.Location = new Point(531, 89);
            searchPathButton.Name = "searchPathButton";
            searchPathButton.Size = new Size(75, 23);
            searchPathButton.TabIndex = 8;
            searchPathButton.Text = "Browse";
            searchPathButton.UseVisualStyleBackColor = true;
            // 
            // defaultButton
            // 
            defaultButton.Location = new Point(551, 415);
            defaultButton.Name = "defaultButton";
            defaultButton.Size = new Size(75, 23);
            defaultButton.TabIndex = 9;
            defaultButton.Text = "Default";
            defaultButton.UseVisualStyleBackColor = true;
            // 
            // defaultTargetDropdown
            // 
            defaultTargetDropdown.FormattingEnabled = true;
            defaultTargetDropdown.Location = new Point(157, 60);
            defaultTargetDropdown.Name = "defaultTargetDropdown";
            defaultTargetDropdown.Size = new Size(449, 23);
            defaultTargetDropdown.TabIndex = 10;
            defaultTargetDropdown.DisplayMemberChanged += OnDefaultTargetValueChanged;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(defaultTargetDropdown);
            Controls.Add(defaultButton);
            Controls.Add(searchPathButton);
            Controls.Add(closeButton);
            Controls.Add(applyButton);
            Controls.Add(textBox1);
            Controls.Add(defaultSourceDropdown);
            Controls.Add(defaultSearchPathLabel);
            Controls.Add(defaultTargetLabel);
            Controls.Add(defaultSourceLabel);
            Name = "PreferencesForm";
            Text = "Preferences";
            Load += PreferencesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label defaultSourceLabel;
        private Label defaultTargetLabel;
        private Label defaultSearchPathLabel;
        private ComboBox defaultSourceDropdown;
        private TextBox textBox1;
        private Button applyButton;
        private Button closeButton;
        private Button searchPathButton;
        private Button defaultButton;
        private ComboBox defaultTargetDropdown;
    }
}