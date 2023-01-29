namespace Calculator
{
    public partial class FrmClaculator : Form
    {
        public FrmClaculator()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "1");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "2");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "3");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "4");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "5");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "6");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "7");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "8");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "9");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            var number = double.Parse(TxtScreen.Text + "0");
            TxtScreen.Text = number.ToString();
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void TxtScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //var indexOfDot = (sender as TextBox).Text.IndexOf('.');

            //var hadDot = (sender as TextBox).Text.IndexOf('.') > -1);
            //var hadDot = (sender as TextBox).Text.Any(x => x == '.');

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if(!char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                if(e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    LblHistory.Text = TxtScreen.Text + " " + e.KeyChar;
                    TxtScreen.Text = "0";
                    e.Handled = true;
                }
                else
                {
                    var number = double.Parse(TxtScreen.Text + e.KeyChar);
                    TxtScreen.Text = number.ToString();
                    TxtScreen.SelectionStart = TxtScreen.Text.Length;
                    TxtScreen.SelectionLength = 0;
                    e.Handled = true;
                }

            }
        }
    }
}