namespace ChatGPT_POC
{
    partial class MainForm
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
            btnAskTo = new Button();
            btnCvGeneration = new Button();
            btnReStructure = new Button();
            SuspendLayout();
            // 
            // btnAskTo
            // 
            btnAskTo.Location = new Point(12, 12);
            btnAskTo.Name = "btnAskTo";
            btnAskTo.Size = new Size(123, 71);
            btnAskTo.TabIndex = 0;
            btnAskTo.Text = "ASK Chat GPT";
            btnAskTo.UseVisualStyleBackColor = true;
            btnAskTo.Click += btnAskTo_Click;
            // 
            // btnCvGeneration
            // 
            btnCvGeneration.Location = new Point(141, 12);
            btnCvGeneration.Name = "btnCvGeneration";
            btnCvGeneration.Size = new Size(123, 71);
            btnCvGeneration.TabIndex = 1;
            btnCvGeneration.Text = "CV Section generation";
            btnCvGeneration.UseVisualStyleBackColor = true;
            btnCvGeneration.Click += btnCvGeneration_Click;
            // 
            // btnReStructure
            // 
            btnReStructure.Location = new Point(270, 12);
            btnReStructure.Name = "btnReStructure";
            btnReStructure.Size = new Size(123, 71);
            btnReStructure.TabIndex = 2;
            btnReStructure.Text = "Re Structure data";
            btnReStructure.UseVisualStyleBackColor = true;
            btnReStructure.Click += btnReStructure_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 100);
            Controls.Add(btnReStructure);
            Controls.Add(btnCvGeneration);
            Controls.Add(btnAskTo);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAskTo;
        private Button btnCvGeneration;
        private Button btnReStructure;
    }
}