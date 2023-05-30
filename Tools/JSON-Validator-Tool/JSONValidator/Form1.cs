using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JSONValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string IndentJSON(string json)
        {
            int indentation = 0;
            int quoteCount = 0;

            var regex = new Regex(@".");
            return regex.Replace(json, (Match m) =>
            {
                char c = m.Value[0];
                if (quoteCount % 2 == 0)
                {
                    switch (c)
                    {
                        case '{':
                        case '[':
                            indentation++;
                            return m.Value + Environment.NewLine + new string(' ', indentation * 4);
                        case '}':
                        case ']':
                            indentation--;
                            return Environment.NewLine + new string(' ', indentation * 4) + m.Value;
                        case ',':
                            return m.Value + Environment.NewLine + new string(' ', indentation * 4);
                        default:
                            return m.Value;
                    }
                }
                else if (c == '"')
                {
                    quoteCount++;
                }

                return m.Value;
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { label1.Visible = true; label1.Text = "Empty Text"; }
            else
            {
                if ((textBox1.Text.StartsWith("{") && textBox1.Text.EndsWith("}")) || //For object
                    (textBox1.Text.StartsWith("[") && textBox1.Text.EndsWith("]"))) //For array

                {
                    try
                    {
                        string trimmedText = textBox1.Text.Trim();
                        bool endsWithComma = trimmedText.EndsWith(",");
                        string formattedText = endsWithComma ? trimmedText.Substring(0, trimmedText.Length - 1) : trimmedText;
                        string indentedText = IndentJSON(formattedText);
                        string outputText = endsWithComma ? indentedText + "," : indentedText;
                        textBox1.Text = outputText;
                        var obj = JToken.Parse(textBox1.Text);
                        JsonDocument.Parse(textBox1.Text);
                        label1.Visible = true;
                        label1.Text = "Json is valid";
                    }
                    catch (JsonReaderException jex)
                    {
                        //Exception in parsing json
                        Console.WriteLine(jex.Message);
                        label1.Visible = true;
                        label1.Text = jex.Message;
                    }
                    catch (Exception ex) //some other exception
                    {
                        Console.WriteLine(ex.ToString());
                        label1.Visible = true;
                        label1.Text = ex.ToString();
                    }
                }
                else
                {
                    label1.Text = "Json is not valid because doesn't end or start with { } or [ ]";
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(textBox1.Text);
            textBox1.Text = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AboutIt AboutIt = new AboutIt();

            // Show the form
            AboutIt.Show();
        }
    }
}
