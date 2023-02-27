namespace ChatGPT_POC
{
    partial class ReStructureForm
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
            label1 = new Label();
            label2 = new Label();
            txtText = new RichTextBox();
            txtResponse = new RichTextBox();
            btnGenerate = new Button();
            cmbNewPosition = new ComboBox();
            label3 = new Label();
            chkHighlight = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 350);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Response";
            // 
            // txtText
            // 
            txtText.Location = new Point(12, 80);
            txtText.Name = "txtText";
            txtText.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtText.Size = new Size(523, 223);
            txtText.TabIndex = 2;
            txtText.Text = "";
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(12, 374);
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(523, 223);
            txtResponse.TabIndex = 3;
            txtResponse.Text = "";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(201, 309);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(148, 42);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbNewPosition
            // 
            cmbNewPosition.FormattingEnabled = true;
            cmbNewPosition.Location = new Point(121, 19);
            cmbNewPosition.Name = "cmbNewPosition";
            cmbNewPosition.Size = new Size(268, 29);
            cmbNewPosition.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 22);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 6;
            label3.Text = "New position";
            // 
            // chkHighlight
            // 
            chkHighlight.AutoSize = true;
            chkHighlight.Location = new Point(395, 21);
            chkHighlight.Name = "chkHighlight";
            chkHighlight.Size = new Size(140, 25);
            chkHighlight.TabIndex = 7;
            chkHighlight.Text = "Highlight words";
            chkHighlight.UseVisualStyleBackColor = true;
            // 
            // ReStructureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 610);
            Controls.Add(chkHighlight);
            Controls.Add(label3);
            Controls.Add(cmbNewPosition);
            Controls.Add(btnGenerate);
            Controls.Add(txtResponse);
            Controls.Add(txtText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ReStructureForm";
            Text = "ReStructureForm";
            Load += ReStructureForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox txtText;
        private RichTextBox txtResponse;
        private Button btnGenerate;
        private ComboBox cmbNewPosition;
        private Label label3;
        private CheckBox chkHighlight;
    }
}