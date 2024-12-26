using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculating_machine
{
    public partial class Form1 : Form
    {
        calculate cal = new calculate();
        string before_Value = "";
        string current_Value = "";
        string result_Value = "";
        string operation = "";

        bool isEqualPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 버튼 핸들러 (화살표 함수)
        private void button_number1_Click(object sender, EventArgs e) => AddNumber("1");
        private void button_number2_Click(object sender, EventArgs e) => AddNumber("2");
        private void button_number3_Click(object sender, EventArgs e) => AddNumber("3");
        private void button_number4_Click(object sender, EventArgs e) => AddNumber("4");
        private void button_number5_Click(object sender, EventArgs e) => AddNumber("5");
        private void button_number6_Click(object sender, EventArgs e) => AddNumber("6");
        private void button_number7_Click(object sender, EventArgs e) => AddNumber("7");
        private void button_number8_Click(object sender, EventArgs e) => AddNumber("8");
        private void button_number9_Click(object sender, EventArgs e) => AddNumber("9");
        private void button_number0_Click(object sender, EventArgs e)
            => current_Value = current_Value != "0" ? current_Value + "0" : current_Value;

        private void button_ce_Click(object sender, EventArgs e) => ClearCurrentValue();
        private void button_c_Click(object sender, EventArgs e) => ClearAllValues();
        private void button_backspace_Click(object sender, EventArgs e) => RemoveLastCharacter();

        private void button_add_Click(object sender, EventArgs e) => SetOperation("+");
        private void button_subtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void button_multiple_Click(object sender, EventArgs e) => SetOperation("*");
        private void button_divide_Click(object sender, EventArgs e) => SetOperation("/");

        private void button_covertsign_Click(object sender, EventArgs e) => ConvertSign();
        private void button_percent_Click(object sender, EventArgs e) => ApplyPercentage();
        private void button_invert_Click(object sender, EventArgs e) => ApplyInverse();
        private void button_spuare_Click(object sender, EventArgs e) => ApplySquare();
        private void button_squareroot_Click(object sender, EventArgs e) => ApplySquareRoot();
        private void button_float_Click(object sender, EventArgs e)
            => current_Value = current_Value.IndexOf(".") == -1 ? current_Value + "." : current_Value;

        private void button_equal_Click(object sender, EventArgs e) => CalculateResult();
       
        private void AddNumber(string number)
        {
            current_Value += number;
            textBox_presentvalue.Text = current_Value;
        }

        private void ClearCurrentValue()
        {
            current_Value = "";
            textBox_presentvalue.Text = "";
            operation = "";
        }

        private void ClearAllValues()
        {
            current_Value = "";
            result_Value = "";
            before_Value = "";
            operation = "";
            textBox_presentvalue.Text = "";
            textBox_prevalue.Text = "";
        }

        private void RemoveLastCharacter()
        {
            if (current_Value.Length > 0)
            {
                current_Value = current_Value.Substring(0, current_Value.Length - 1);
                textBox_presentvalue.Text = current_Value;
            }
        }

        private void SetOperation(string op)
        {
            if (current_Value.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = result_Value + op;
                current_Value = "";
                textBox_presentvalue.Text = "";
                operation = op;
            }
        }

        private void ConvertSign()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                current_Value = textBox_presentvalue.Text;
                double resConvert = double.Parse(current_Value) * -1;
                current_Value = resConvert.ToString();
                textBox_presentvalue.Text = current_Value;
            }
        }

        private void ApplyPercentage()
        {
            if (current_Value.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = "0";
                    current_Value = "";
                    textBox_prevalue.Text = result_Value;
                    textBox_presentvalue.Text = "";
                }
                else if (result_Value != "")
                {
                    result_Value = (double.Parse(result_Value) / 100).ToString();
                    current_Value = "";
                    textBox_prevalue.Text = result_Value;
                    textBox_presentvalue.Text = "";
                }
            }
        }

        private void ApplyInverse()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                result_Value = cal.GetInverse_Value(textBox_presentvalue.Text);
                current_Value = "";
                textBox_prevalue.Text = "1/(" + textBox_presentvalue.Text + ")";
                textBox_presentvalue.Text = result_Value;
            }
            else if (textBox_presentvalue.Text.Length == 0)
            {
                textBox_presentvalue.Text = "0으로 나누지 마세요!";
                textBox_prevalue.Text = "1/0";
            }
        }

        private void ApplySquare()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                result_Value = cal.GetSquare_Value(textBox_presentvalue.Text);
                textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                current_Value = "";
                textBox_presentvalue.Text = result_Value;
            }
        }

        private void ApplySquareRoot()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                result_Value = cal.GetRoot_Value(textBox_presentvalue.Text);
                if (result_Value == "입력이 잘못되었습니다.")
                {
                    textBox_presentvalue.Text = result_Value;
                    result_Value = "";
                    textBox_prevalue.Text = "";
                }
                else
                {
                    current_Value = "";
                    textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                    textBox_presentvalue.Text = result_Value;
                }
            }
        }

        private void CalculateResult()
        {
            switch (operation)
            {
                case "+":
                    if (current_Value == "") break;
                    result_Value = cal.addtion(result_Value, current_Value);
                    textBox_prevalue.Text += current_Value;
                    textBox_presentvalue.Text = result_Value;
                    break;
                case "-":
                    if (current_Value == "") break;
                    result_Value = cal.subtraction(result_Value, current_Value);
                    textBox_prevalue.Text += current_Value;
                    textBox_presentvalue.Text = result_Value;
                    break;
                case "*":
                    if (current_Value == "") break;
                    result_Value = cal.multiplication(result_Value, current_Value);
                    textBox_prevalue.Text += current_Value;
                    textBox_presentvalue.Text = result_Value;
                    break;
                case "/":
                    if (current_Value == "") break;
                    result_Value = cal.division(result_Value, current_Value);
                    if (result_Value == "∞")
                    {
                        textBox_presentvalue.Text = "0으로 나눌 수 없습니다.";
                        operation = "";
                        result_Value = "";
                        textBox_prevalue.Text = "";
                        break;
                    }
                    textBox_presentvalue.Text = result_Value;
                    break;
            }
            operation = "";
        }
    }
}
