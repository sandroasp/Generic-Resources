namespace JSONtoJSONSchemaConverter
{
    partial class JsontoJsonSchema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsontoJsonSchema));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CopyJsonButton = new System.Windows.Forms.Button();
            this.SaveSchemaButton = new System.Windows.Forms.Button();
            this.CopySchemaButton = new System.Windows.Forms.Button();
            this.jsonTextBox = new System.Windows.Forms.RichTextBox();
            this.schemaTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadJsonButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertButton.Location = new System.Drawing.Point(139, 3);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(130, 65);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert JSON Document To JSON Schema";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click_2);
            // 
            // CopyJsonButton
            // 
            this.CopyJsonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyJsonButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CopyJsonButton.Location = new System.Drawing.Point(275, 3);
            this.CopyJsonButton.Name = "CopyJsonButton";
            this.CopyJsonButton.Size = new System.Drawing.Size(130, 65);
            this.CopyJsonButton.TabIndex = 1;
            this.CopyJsonButton.Text = "Copy JSON Document to Clipboard";
            this.CopyJsonButton.UseVisualStyleBackColor = false;
            this.CopyJsonButton.Click += new System.EventHandler(this.CopyJsonButton_Click_1);
            // 
            // SaveSchemaButton
            // 
            this.SaveSchemaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSchemaButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveSchemaButton.Location = new System.Drawing.Point(411, 3);
            this.SaveSchemaButton.Name = "SaveSchemaButton";
            this.SaveSchemaButton.Size = new System.Drawing.Size(130, 65);
            this.SaveSchemaButton.TabIndex = 2;
            this.SaveSchemaButton.Text = "Save JSON Schema";
            this.SaveSchemaButton.UseVisualStyleBackColor = false;
            this.SaveSchemaButton.Click += new System.EventHandler(this.SaveSchemaButton_Click_1);
            // 
            // CopySchemaButton
            // 
            this.CopySchemaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopySchemaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CopySchemaButton.Location = new System.Drawing.Point(547, 3);
            this.CopySchemaButton.Name = "CopySchemaButton";
            this.CopySchemaButton.Size = new System.Drawing.Size(134, 65);
            this.CopySchemaButton.TabIndex = 3;
            this.CopySchemaButton.Text = "Copy JSON Schema to Clipboard";
            this.CopySchemaButton.UseVisualStyleBackColor = false;
            this.CopySchemaButton.Click += new System.EventHandler(this.CopySchemaButton_Click_1);
            // 
            // jsonTextBox
            // 
            this.jsonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTextBox.Location = new System.Drawing.Point(3, 3);
            this.jsonTextBox.Name = "jsonTextBox";
            this.jsonTextBox.Size = new System.Drawing.Size(324, 466);
            this.jsonTextBox.TabIndex = 4;
            this.jsonTextBox.Text = "";
            // 
            // schemaTextBox
            // 
            this.schemaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaTextBox.Location = new System.Drawing.Point(333, 3);
            this.schemaTextBox.Name = "schemaTextBox";
            this.schemaTextBox.Size = new System.Drawing.Size(324, 466);
            this.schemaTextBox.TabIndex = 5;
            this.schemaTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.jsonTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.schemaTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 472);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CopySchemaButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveSchemaButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CopyJsonButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ConvertButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LoadJsonButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 71);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // LoadJsonButton
            // 
            this.LoadJsonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadJsonButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadJsonButton.Location = new System.Drawing.Point(3, 3);
            this.LoadJsonButton.Name = "LoadJsonButton";
            this.LoadJsonButton.Size = new System.Drawing.Size(130, 65);
            this.LoadJsonButton.TabIndex = 4;
            this.LoadJsonButton.Text = "Load JSON";
            this.LoadJsonButton.UseVisualStyleBackColor = false;
            this.LoadJsonButton.Click += new System.EventHandler(this.LoadJsonButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // JsontoJsonSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 585);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1083, 773);
            this.MinimumSize = new System.Drawing.Size(323, 249);
            this.Name = "JsontoJsonSchema";
            this.Text = "JSON Document to JSON Schema Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ConvertButton;
        private Button CopyJsonButton;
        private Button SaveSchemaButton;
        private Button CopySchemaButton;
        private RichTextBox jsonTextBox;
        private RichTextBox schemaTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button LoadJsonButton;
    }
}