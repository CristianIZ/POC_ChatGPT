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
            try
            {
                txtResponse.Text = requestHelper.RequestChatGPT(txtQuestion.Text).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}