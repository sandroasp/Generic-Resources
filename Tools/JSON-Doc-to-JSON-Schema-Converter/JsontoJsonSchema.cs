using Newtonsoft.Json;
using NJsonSchema;

namespace JSONtoJSONSchemaConverter
{
    public partial class JsontoJsonSchema : Form
    {
        public JsontoJsonSchema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                string json = jsonTextBox.Text;
                JsonSchema schema = JsonSchema.FromSampleJson(json);
                string schemaString = schema.ToJson();
                schemaTextBox.Text = schemaString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting JSON to schema: " + ex.Message);
            }
        }

        private void CopyJsonButton_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(jsonTextBox.Text);
            MessageBox.Show("JSON copied to clipboard.");
        }

        private void SaveSchemaButton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Schema Files|*.json";
            saveFileDialog.Title = "Save JSON Schema";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string schema = schemaTextBox.Text;
                System.IO.File.WriteAllText(saveFileDialog.FileName, schema);
                MessageBox.Show("Schema saved successfully.");
            }
        }

        private void CopySchemaButton_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(schemaTextBox.Text);
            MessageBox.Show("Schema copied to clipboard.");
        }

        private void LoadJsonButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Load JSON";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = System.IO.File.ReadAllText(openFileDialog.FileName);
                    jsonTextBox.Text = json;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading JSON: " + ex.Message);
                }
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }
    }
}