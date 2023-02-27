namespace ChatGPT_POC
{
    partial class Form1
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.BtnAsk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(6, 51);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(346, 177);
            this.txtQuestion.TabIndex = 0;
            // 
            // BtnAsk
            // 
            this.BtnAsk.Location = new System.Drawing.Point(103, 234);
            this.BtnAsk.Name = "BtnAsk";
            this.BtnAsk.Size = new System.Drawing.Size(126, 38);
            this.BtnAsk.TabIndex = 1;
            this.BtnAsk.Text = "ASK";
            this.BtnAsk.UseVisualStyleBackColor = true;
            this.BtnAsk.Click += new System.EventHandler(this.BtnAsk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ask to chat GPT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPT response";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(6, 307);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(346, 177);
            this.txtResponse.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResponse);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnAsk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 500);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 516);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtQuestion;
        private Button BtnAsk;
        private Label label1;
        private Label label2;
        private TextBox txtResponse;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}