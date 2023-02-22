namespace ChatGPT_POC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAsk_Click(object sender, EventArgs e)
        {
            txtResponse.Text = requestHelper.RequestChatGPT(txtQuestion.Text).Result;
        }
    }
}