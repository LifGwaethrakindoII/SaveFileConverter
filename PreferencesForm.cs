namespace SaveFileConverter
{
    public partial class PreferencesForm : Form
    {
        private SaveFileConverter saveFileConverter;
        private Settings settings;
        private Settings previousSettings;

        public PreferencesForm(SaveFileConverter _saveFileConverter)
        {
            InitializeComponent();

            saveFileConverter = _saveFileConverter;

            if(saveFileConverter == null) return;

            settings = saveFileConverter.settings;
            previousSettings = saveFileConverter.previousSettings;
            SaveFileConverter.AssignDropdownContent(defaultSourceDropdown);
            SaveFileConverter.AssignDropdownContent(defaultTargetDropdown);
            defaultSourceDropdown.DisplayMember = settings.sourceFileExtension;
            defaultTargetDropdown.DisplayMember = settings.targetFileExtension;
            defaultSearchPathLabel.Text = settings.filePath;
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            applyButton.Enabled = false;
        }

        private void EvaluateForApply()
        {
            applyButton.Enabled = saveFileConverter.previousSettings != saveFileConverter.settings;
        }

        private void OnDefaultSourceValueChanged(object sender, EventArgs e)
        {
            if(saveFileConverter == null) return;

            settings.sourceFileExtension = defaultSourceDropdown.DisplayMember;
            saveFileConverter.settings = settings;
            EvaluateForApply();
        }

        private void OnDefaultTargetValueChanged(object sender, EventArgs e)
        {
            if (saveFileConverter == null) return;

            previousSettings.sourceFileExtension = defaultTargetDropdown.DisplayMember;
            saveFileConverter.previousSettings = previousSettings;
            EvaluateForApply();
        }
    }
}