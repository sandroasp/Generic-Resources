using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonSchema;

namespace JSONtoJSONSchemaConverter
{
    public partial class SchemaToJsonConverter : Form
    {
        public SchemaToJsonConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadSchemaButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Load JSON Schema";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string schema = System.IO.File.ReadAllText(openFileDialog.FileName);
                    schemaTextBox.Text = schema;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading schema: " + ex.Message);
                }
            }
        }

        private void ConvertButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string schemaString = schemaTextBox.Text;
                JsonSchema schema = JsonSchema.FromJsonAsync(schemaString).Result;
                JToken jsonToken = schema.ToSampleJson();
                string json = jsonToken.ToString();
                jsonTextBox.Text = json;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting schema to JSON: " + ex.Message);
            }
        }

        private void CopyJsonButton_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(schemaTextBox.Text);
            MessageBox.Show("Schema copied to clipboard.");
        }

        private void SaveSchemaButton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json";
            saveFileDialog.Title = "Save JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = jsonTextBox.Text;
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);
                MessageBox.Show("JSON saved successfully.");
            }
        }

        private void CopySchemaButton_Click_1(object sender, EventArgs e)
        {

            Clipboard.SetText(jsonTextBox.Text);
            MessageBox.Show("JSON copied to clipboard.");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }
    }
}