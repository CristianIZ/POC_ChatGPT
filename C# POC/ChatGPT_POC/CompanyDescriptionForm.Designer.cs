namespace ChatGPT_POC
{
    partial class CompanyDescriptionForm
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
            cmbCompanyName = new ComboBox();
            label1 = new Label();
            txtResponse = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCompanyLocation = new ComboBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // cmbCompanyName
            // 
            cmbCompanyName.FormattingEnabled = true;
            cmbCompanyName.Location = new Point(85, 13);
            cmbCompanyName.Margin = new Padding(4);
            cmbCompanyName.Name = "cmbCompanyName";
            cmbCompanyName.Size = new Size(154, 29);
            cmbCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(22, 112);
            txtResponse.Margin = new Padding(4);
            txtResponse.Name = "txtResponse";
            txtResponse.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtResponse.Size = new Size(459, 278);
            txtResponse.TabIndex = 2;
            txtResponse.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "Response";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 4;
            label3.Text = "Location:";
            // 
            // cmbCompanyLocation
            // 
            cmbCompanyLocation.FormattingEnabled = true;
            cmbCompanyLocation.Location = new Point(327, 13);
            cmbCompanyLocation.Margin = new Padding(4);
            cmbCompanyLocation.Name = "cmbCompanyLocation";
            cmbCompanyLocation.Size = new Size(154, 29);
            cmbCompanyLocation.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(364, 69);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(117, 36);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // CompanyDescriptionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 411);
            Controls.Add(btnSend);
            Controls.Add(cmbCompanyLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResponse);
            Controls.Add(label1);
            Controls.Add(cmbCompanyName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CompanyDescriptionForm";
            Text = "CompanyDescriptionForm";
            Load += CompanyDescriptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCompanyName;
        private Label label1;
        private RichTextBox txtResponse;
        private Label label2;
        private Label label3;
        private ComboBox cmbCompanyLocation;
        private Button btnSend;
    }
}