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
            var key = new KeyPressEventArgs('1');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('2');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('3');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('4');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('5');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('6');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('7');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('8');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('9');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('0');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('.');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void TxtScreen_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !IsOperator(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                LblHistory.Text = TxtScreen.Text + " " + e.KeyChar;
                TxtScreen.Text = "0";
                e.Handled = true;
            }
            else if(!char.IsControl(e.KeyChar))
            {
                if (TxtScreen.Text == "0")
                {
                    TxtScreen.Text = "";
                }
                TxtScreen.Text = TxtScreen.Text + e.KeyChar;
                TxtScreen.SelectionStart = TxtScreen.Text.Length;
                TxtScreen.SelectionLength = 0;
                e.Handled = true;
                TxtScreen.Focus();
            }


        }

        private bool IsOperator(char keyChar)
        {
            return keyChar == '+' || keyChar == '-' || keyChar == '*' || keyChar == '/';
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('/');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('*');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('+');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            var key = new KeyPressEventArgs('-');
            TxtScreen_KeyPress(TxtScreen, key);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text.Substring(0, TxtScreen.Text.Length - 1);
            TxtScreen.SelectionStart = TxtScreen.Text.Length;
            TxtScreen.SelectionLength = 0;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = "0";
            LblHistory.Text = "--";
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            LblHistory.Text += " " + TxtScreen.Text + " =";
            var array = LblHistory.Text.Split(' ');
            var firstNumber = double.Parse(array[0]);
            var op = array[1];
            var secondNumber = double.Parse(array[2]);


            switch (op)
            {
                case "+":
                    TxtScreen.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    TxtScreen.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    TxtScreen.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    TxtScreen.Text = (firstNumber / secondNumber).ToString();
                    break;
                default:
                    throw new InvalidOperationException();
            }

        }
    }
}