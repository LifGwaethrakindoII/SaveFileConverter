using System.Configuration;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace SaveFileConverter
{
    public partial class SaveFileConverter : Form
    {
        public static readonly string[] EXTENSIONS;

        private StringBuilder stringBuilder;
        private string sourceExtension;
        private string targetExtension;
        public Settings settings;
        public Settings previousSettings;

        static SaveFileConverter()
        {
            /* Common Save File Extensions:
                .sav – The most widely used save file format, compatible with many flash carts and emulators.
                .srm – Another format used by certain emulators and flash carts.
                .esv – Typically used by the EZ Flash series, such as EZ Flash Omega.
                .gsv – Commonly associated with older Gameshark and other cheat devices for Game Boy.
                .dat – Used by some backup devices and older flash carts.
                .eep – Employed by certain emulators and older flash carts.
                .fls – Sometimes used for flash memory-based save files.
                .ftf – Seen with specific versions of flash carts or emulators.
                .dsv – Commonly found in newer emulators like DeSmuME for DS games, but occasionally used for GBA/GB saves in certain settings.
             */
            EXTENSIONS = new[] { ".sav", ".srm", ".esv", ".gsv", ".dat", ".eep", ".fls", ".ftf", ".dsv" };
        }

        public SaveFileConverter()
        {
            InitializeComponent();
            stringBuilder = new StringBuilder();
            LoadSettings(ref settings);
            sourceExtension = settings.sourceFileExtension;
            targetExtension = settings.targetFileExtension;
            sourceFileTextBox.Text = settings.filePath;
            AssignDropdownContent(sourceExtensionDropdown);
            AssignDropdownContent(targetExtensionDropdown);
        }


        /// <returns>Search filter for current source file.</returns>
        private string GetSourceFileFilter()
        {
            /// SRM files (*.srm)|*.srm
            stringBuilder.Clear();
            stringBuilder.Append(sourceExtension.ToUpper());
            stringBuilder.Append(" files (*");
            stringBuilder.Append(sourceExtension);
            stringBuilder.Append(")|*");
            stringBuilder.Append(sourceExtension);

            return stringBuilder.ToString();
        }

        private void OnLoad(object sender, EventArgs e)
        {}

        private void SearchSaveFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = GetSourceFileFilter();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the file path to the textbox
                sourceFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void ConvertSaveFile()
        {

        }

        private void OnPreferencesClick(object sender, EventArgs e)
        {
            ShowPreferencesDialogueWindow();
        }

        private void ShowPreferencesDialogueWindow()
        {
            // Create an instance of the PreferencesForm
            PreferencesForm preferencesForm = new PreferencesForm(this);

            previousSettings = settings;

            // Open the form as a modal dialog
            preferencesForm.ShowDialog();
        }

        public static void AssignDropdownContent(ComboBox dropdown, int displayMemberIndex = 0)
        {
            int length = EXTENSIONS.Length;
            string[] extensions = new string[length];
            
            Array.Copy(EXTENSIONS, extensions, length);
            
            dropdown.DisplayMember = EXTENSIONS[displayMemberIndex];
            dropdown.DataSource = extensions;
        }

#region Callbacks:
        private void OnSearchButtonClick(object sender, EventArgs a)
        {
            SearchSaveFile();
        }

        private void OnConvertButtonClick(object sender, EventArgs a)
        {
            ConvertSaveFile();
        }

        private void OnLabelClick(object sender, EventArgs a)
        {

        }
#endregion

#region StaticFunctions:
        public static void SaveSettings(Settings _settings)
        {
            /// C:\Users\<Username>\AppData\Local\<YourAppName>
            // Get the AppData\Local folder path
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "Save File Converter");

            // Ensure the directory exists
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            // Path to the settings file
            string jsonFilePath = Path.Combine(appFolder, "settings.json");

            // Serialize the settings struct to JSON
            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true // Makes the JSON output formatted
            };

            string jsonData = JsonSerializer.Serialize(_settings, jsonOptions);

            Console.WriteLine("Saved Settings: " + _settings);
            // Write the JSON data to the file
            File.WriteAllText(jsonFilePath, jsonData);
        }

        public static void LoadSettings(ref Settings _settings)
        {
            // Get the AppData\Local folder path
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "Save File Converter");

            // Path to the settings file
            string jsonFilePath = Path.Combine(appFolder, "settings.json");

            // Ensure the directory exists
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
                _settings = Settings.Default();
                SaveSettings(_settings);
                return;
            }

            // Read the JSON data from the file
            string jsonData = File.ReadAllText(jsonFilePath);

            // Deserialize the JSON data into the Settings struct
            _settings = JsonSerializer.Deserialize<Settings>(jsonData);
        }
#endregion
    }
}