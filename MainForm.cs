namespace Monks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            DisplayMonksNumber();
        }

        private void DisplayMonksNumber()
        {
            var monksNumber = MonksNumbers.GetMonksNumber(GetValidNumber(txtNumber.Text));
            txtMonksNumber.Text = "";

            for (int i = 0; i < monksNumber.GetLength(0); i++)
            {
                for (int j = 0; j < monksNumber.GetLength(1); j++)
                {
                    txtMonksNumber.AppendText(monksNumber[i, j] == 1 ? "o" : " ");
                }
                txtMonksNumber.AppendText(Environment.NewLine);
            }
        }

        static int GetValidNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] ^ '0') > 9)
                {
                    return 0;
                }
            }

            var number = Convert.ToInt32(s);

            return number > -1 && number < 10000 ? number : 0;
        }
    }
}
