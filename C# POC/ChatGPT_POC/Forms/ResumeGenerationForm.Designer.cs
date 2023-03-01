namespace ChatGPT_POC
{
    partial class ResumeGenerationForm
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
            label4 = new Label();
            cmbTechnology = new ComboBox();
            cmbSeniority = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGenerate = new Button();
            label1 = new Label();
            cmbSection = new ComboBox();
            label2 = new Label();
            cmbSecondTechnology = new ComboBox();
            lstTechLearned = new ListBox();
            lstTechnologies = new ListBox();
            label3 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            txtQuestion = new TextBox();
            label9 = new Label();
            txtResponse = new RichTextBox();
            numYear = new NumericUpDown();
            numMonth = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            numStartTechYear = new NumericUpDown();
            chkHighlight = new CheckBox();
            label13 = new Label();
            label14 = new Label();
            numStartTechMonth = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartTechYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartTechMonth).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 255);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 15;
            label4.Text = "Response";
            // 
            // cmbTechnology
            // 
            cmbTechnology.FormattingEnabled = true;
            cmbTechnology.Location = new Point(569, 101);
            cmbTechnology.Margin = new Padding(4);
            cmbTechnology.Name = "cmbTechnology";
            cmbTechnology.Size = new Size(256, 29);
            cmbTechnology.TabIndex = 3;
            // 
            // cmbSeniority
            // 
            cmbSeniority.FormattingEnabled = true;
            cmbSeniority.Location = new Point(834, 40);
            cmbSeniority.Margin = new Padding(4);
            cmbSeniority.Name = "cmbSeniority";
            cmbSeniority.Size = new Size(256, 29);
            cmbSeniority.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 143);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 11;
            label5.Text = "Working since";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(569, 76);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 10;
            label6.Text = "Main Technology";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 9;
            label7.Text = "Seniority";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(569, 223);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(521, 49);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 18;
            label1.Text = "Section";
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(569, 40);
            cmbSection.Margin = new Padding(4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(256, 29);
            cmbSection.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(834, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 21);
            label2.TabIndex = 19;
            label2.Text = "Second best technology";
            // 
            // cmbSecondTechnology
            // 
            cmbSecondTechnology.FormattingEnabled = true;
            cmbSecondTechnology.Location = new Point(834, 101);
            cmbSecondTechnology.Margin = new Padding(4);
            cmbSecondTechnology.Name = "cmbSecondTechnology";
            cmbSecondTechnology.Size = new Size(256, 29);
            cmbSecondTechnology.TabIndex = 20;
            // 
            // lstTechLearned
            // 
            lstTechLearned.FormattingEnabled = true;
            lstTechLearned.ItemHeight = 21;
            lstTechLearned.Location = new Point(15, 40);
            lstTechLearned.Name = "lstTechLearned";
            lstTechLearned.Size = new Size(241, 193);
            lstTechLearned.TabIndex = 21;
            // 
            // lstTechnologies
            // 
            lstTechnologies.FormattingEnabled = true;
            lstTechnologies.ItemHeight = 21;
            lstTechnologies.Location = new Point(321, 40);
            lstTechnologies.Name = "lstTechnologies";
            lstTechnologies.Size = new Size(241, 130);
            lstTechnologies.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 23;
            label3.Text = "Technologies learned";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 15);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 24;
            label8.Text = "Technologies";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(262, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 33);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "<---";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(262, 138);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(53, 33);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "-->";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(12, 280);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ScrollBars = ScrollBars.Vertical;
            txtQuestion.Size = new Size(326, 295);
            txtQuestion.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 255);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 28;
            label9.Text = "Question";
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(345, 279);
            txtResponse.Name = "txtResponse";
            txtResponse.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtResponse.Size = new Size(745, 296);
            txtResponse.TabIndex = 29;
            txtResponse.Text = "";
            // 
            // numYear
            // 
            numYear.Location = new Point(786, 141);
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 29);
            numYear.TabIndex = 30;
            // 
            // numMonth
            // 
            numMonth.Location = new Point(974, 141);
            numMonth.Name = "numMonth";
            numMonth.Size = new Size(120, 29);
            numMonth.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(740, 143);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 32;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(912, 143);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 33;
            label11.Text = "Month";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(321, 180);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 34;
            label12.Text = "Working Since";
            // 
            // numStartTechYear
            // 
            numStartTechYear.Location = new Point(363, 204);
            numStartTechYear.Name = "numStartTechYear";
            numStartTechYear.Size = new Size(68, 29);
            numStartTechYear.TabIndex = 35;
            // 
            // chkHighlight
            // 
            chkHighlight.AutoSize = true;
            chkHighlight.Location = new Point(573, 179);
            chkHighlight.Name = "chkHighlight";
            chkHighlight.Size = new Size(140, 25);
            chkHighlight.TabIndex = 36;
            chkHighlight.Text = "Highlight words";
            chkHighlight.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(321, 206);
            label13.Name = "label13";
            label13.Size = new Size(40, 21);
            label13.TabIndex = 37;
            label13.Text = "Year";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(437, 206);
            label14.Name = "label14";
            label14.Size = new Size(56, 21);
            label14.TabIndex = 38;
            label14.Text = "Month";
            // 
            // numStartTechMonth
            // 
            numStartTechMonth.Location = new Point(499, 204);
            numStartTechMonth.Name = "numStartTechMonth";
            numStartTechMonth.Size = new Size(59, 29);
            numStartTechMonth.TabIndex = 39;
            // 
            // ResumeGenerationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 588);
            Controls.Add(numStartTechMonth);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(chkHighlight);
            Controls.Add(numStartTechYear);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(numMonth);
            Controls.Add(numYear);
            Controls.Add(txtResponse);
            Controls.Add(label9);
            Controls.Add(txtQuestion);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(lstTechnologies);
            Controls.Add(lstTechLearned);
            Controls.Add(cmbSecondTechnology);
            Controls.Add(label2);
            Controls.Add(cmbSection);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(label4);
            Controls.Add(cmbTechnology);
            Controls.Add(cmbSeniority);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ResumeGenerationForm";
            Text = "ResumeGeneration";
            Load += ResumeGeneration_Load;
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartTechYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartTechMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ComboBox cmbTechnology;
        private ComboBox cmbSeniority;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGenerate;
        private Label label1;
        private ComboBox cmbSection;
        private Label label2;
        private ComboBox cmbSecondTechnology;
        private ListBox lstTechLearned;
        private ListBox lstTechnologies;
        private Label label3;
        private Label label8;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox txtQuestion;
        private Label label9;
        private RichTextBox txtResponse;
        private NumericUpDown numYear;
        private NumericUpDown numMonth;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown numStartTechYear;
        private CheckBox chkHighlight;
        private Label label13;
        private Label label14;
        private NumericUpDown numStartTechMonth;
    }
}