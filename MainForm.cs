using Monks_numbers;

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
            Bitmap bmp = new(80, 80);
            for (int y = 0; y < monksNumber.GetLength(0); y++)
            {
                for (int x = 0; x < monksNumber.GetLength(1); x++)
                {
                    txtMonksNumber.AppendText(monksNumber[y, x] == 1 ? "o" : " ");
                    if (monksNumber[y, x] == 1)
                    {
                        int currentX = (1 + x) * 10;
                        int currentY = (1 + y) * 10;
                        bmp.SetPixel(currentX, currentY, Color.Black);

                        // debug; draw horizontal and vertical lines
                        int xx = x;
                        int j = 0;
                        while (monksNumber[y, xx + j] == 1)
                        {
                            j++;
                            if (xx + j >= monksNumber.GetLength(1)) break;
                        }
                        if (j > 1)
                        {
                            bmp.DrawLine(currentX, currentY, ((xx+j)*10), currentY, Color.Black);
                        }

                        int yy = y;
                        int i = 0;
                        while (monksNumber[yy + i, x] == 1)
                        {
                            i++;
                            if (yy + i >= monksNumber.GetLength(0)) break;
                        }
                        if (i > 0)
                        {
                            if (y == 0 && i > 1 && x != 3) i = 2;
                            if (y == 1 && i > 1 && x != 3) i = 2;
                            if (y == 2 && i >= 1 && x != 3) i = 1;
                            if (i > 1 && x != 1 && x != 5)
                            {
                                bmp.DrawLine(currentX, currentY, currentX, ((yy + i) * 10), Color.Black);
                            }
                        }

                        //// debug; draw diagonal lines
                        //int xxx = x;
                        //int yyy = y;
                        //int jj = 0;
                        //int ii = 0;
                        //while (monksNumber[yyy + ii, xxx + jj] == 1)
                        //{
                        //    jj++;
                        //    ii++;
                        //    if (xxx + jj >= monksNumber.GetLength(1)) break;
                        //    if (yyy + ii >= monksNumber.GetLength(0)) break;
                        //}
                        //if (jj >= 3 && (y != 1) && !(y == 2 && x == 1))
                        //{
                        //    bmp.DrawLine(currentX, currentY, ((xxx + jj) * 10), ((yyy + ii) * 10), Color.Black);
                        //}


                        //// debug; draw diagonal lines
                        //xxx = x;
                        //yyy = y;
                        //jj = 1;
                        //ii = 1;
                        //do
                        //{
                        //    if (xxx + jj <= 0) break;
                        //    if (yyy + ii <= 0) break;
                        //    jj--;
                        //    ii--;
                        //}
                        //while (monksNumber[yyy + ii, xxx + jj] == 1);

                        //if (monksNumber[yyy + ii, xxx + jj] == 1)
                        //{
                        //    bmp.DrawLine(currentX, currentY, ((xxx + jj) * 10), ((yyy + ii) * 10), Color.Black);
                        //}


                    }
                }
                txtMonksNumber.AppendText(Environment.NewLine);
            }
            pictureBox.BackgroundImage = bmp;
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
