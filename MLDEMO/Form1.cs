namespace MLDEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel2.ModelInput()
            {
                Col1 = richTextBoxInputEmail.Text,
                Col2 = @"",
                Col3 = @"",
                Col4 = @"",
            };

            //Load model and predict output
            var result = MLModel2.Predict(sampleData);
            textBoxReuslt.Text = result.PredictedLabel.ToString();

            // Detect Spam and Not Sapm Score
            labelSpamValue.Text = (result.Score[1]*100).ToString("#0.00");
            labelNotSpamValue.Text = (result.Score[0]*100).ToString("#0.00");
        }
    }
}