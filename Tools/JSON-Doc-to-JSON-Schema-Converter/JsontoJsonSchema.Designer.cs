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
            ConvertButton = new Button();
            CopyJsonButton = new Button();
            SaveSchemaButton = new Button();
            CopySchemaButton = new Button();
            jsonTextBox = new RichTextBox();
            schemaTextBox = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConvertButton.BackColor = SystemColors.GradientActiveCaption;
            ConvertButton.Location = new Point(3, 3);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(165, 65);
            ConvertButton.TabIndex = 0;
            ConvertButton.Text = "Convert JSON Document To JSON Schema";
            ConvertButton.UseVisualStyleBackColor = false;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // CopyJsonButton
            // 
            CopyJsonButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CopyJsonButton.BackColor = SystemColors.GradientInactiveCaption;
            CopyJsonButton.Location = new Point(174, 3);
            CopyJsonButton.Name = "CopyJsonButton";
            CopyJsonButton.Size = new Size(165, 65);
            CopyJsonButton.TabIndex = 1;
            CopyJsonButton.Text = "Copy JSON Document to Clipboard";
            CopyJsonButton.UseVisualStyleBackColor = false;
            CopyJsonButton.Click += CopyJsonButton_Click;
            // 
            // SaveSchemaButton
            // 
            SaveSchemaButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveSchemaButton.BackColor = SystemColors.GradientActiveCaption;
            SaveSchemaButton.Location = new Point(345, 3);
            SaveSchemaButton.Name = "SaveSchemaButton";
            SaveSchemaButton.Size = new Size(165, 65);
            SaveSchemaButton.TabIndex = 2;
            SaveSchemaButton.Text = "Save JSON Schema";
            SaveSchemaButton.UseVisualStyleBackColor = false;
            SaveSchemaButton.Click += SaveSchemaButton_Click;
            // 
            // CopySchemaButton
            // 
            CopySchemaButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CopySchemaButton.BackColor = SystemColors.GradientInactiveCaption;
            CopySchemaButton.Location = new Point(516, 3);
            CopySchemaButton.Name = "CopySchemaButton";
            CopySchemaButton.Size = new Size(165, 65);
            CopySchemaButton.TabIndex = 3;
            CopySchemaButton.Text = "Copy JSON Schema to Clipboard";
            CopySchemaButton.UseVisualStyleBackColor = false;
            CopySchemaButton.Click += CopySchemaButton_Click;
            // 
            // jsonTextBox
            // 
            jsonTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jsonTextBox.Location = new Point(3, 3);
            jsonTextBox.Name = "jsonTextBox";
            jsonTextBox.Size = new Size(324, 466);
            jsonTextBox.TabIndex = 4;
            jsonTextBox.Text = "";
            // 
            // schemaTextBox
            // 
            schemaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            schemaTextBox.Location = new Point(333, 3);
            schemaTextBox.Name = "schemaTextBox";
            schemaTextBox.Size = new Size(324, 466);
            schemaTextBox.TabIndex = 5;
            schemaTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(jsonTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(schemaTextBox, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(660, 472);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(ConvertButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CopyJsonButton, 1, 0);
            tableLayoutPanel2.Controls.Add(CopySchemaButton, 3, 0);
            tableLayoutPanel2.Controls.Add(SaveSchemaButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(684, 71);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(52, 20);
            toolStripMenuItem1.Text = "About";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // JsontoJsonSchema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(684, 585);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1083, 773);
            MinimumSize = new Size(323, 249);
            Name = "JsontoJsonSchema";
            Text = "JSON Document to JSON Schema Converter";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}