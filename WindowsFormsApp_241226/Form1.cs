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
    public struct Calculator
    {
        public string ResultValue { get; private set; }
        public string CurrentValue { get; private set; }
        public string Operation { get; private set; }

        public Calculator(string resultValue, string currentValue, string operation)
        {
            ResultValue = resultValue;
            CurrentValue = currentValue;
            Operation = operation;
        }

        public void SetCurrentValue(string value) => CurrentValue = value;

        public void SetOperation(string operation)
        {
            if (!string.IsNullOrEmpty(CurrentValue))
            {
                ResultValue = string.IsNullOrEmpty(ResultValue) ? CurrentValue : ResultValue;
                CurrentValue = "";
                Operation = operation;
            }
        }

        public void ClearAll()
        {
            ResultValue = "";
            CurrentValue = "";
            Operation = "";
        }

        public void ClearCurrent() => CurrentValue = "";

        public string Calculate()
        {
            double result;
            double.TryParse(ResultValue, out double left);
            double.TryParse(CurrentValue, out double right);

            switch (Operation)
            {
                case "+":
                    result = left + right;
                    break;
                case "-":
                    result = left - right;
                    break;
                case "*":
                    result = left * right;
                    break;
                case "/":
                    if (right == 0) return "0으로 나눌 수 없습니다.";
                    result = left / right;
                    break;
                default:
                    return "오류";
            }

            ResultValue = result.ToString();
            CurrentValue = "";
            Operation = "";
            return ResultValue;
        }
    }

    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator("", "", "");
        }

        private void AddNumber(string number)
        {
            calculator.SetCurrentValue(calculator.CurrentValue + number);
            textBox_presentvalue.Text = calculator.CurrentValue;
        }

        private void button_number1_Click(object sender, EventArgs e) => AddNumber("1");
        private void button_number2_Click(object sender, EventArgs e) => AddNumber("2");
        private void button_number3_Click(object sender, EventArgs e) => AddNumber("3");
        private void button_number4_Click(object sender, EventArgs e) => AddNumber("4");
        private void button_number5_Click(object sender, EventArgs e) => AddNumber("5");
        private void button_number6_Click(object sender, EventArgs e) => AddNumber("6");
        private void button_number7_Click(object sender, EventArgs e) => AddNumber("7");
        private void button_number8_Click(object sender, EventArgs e) => AddNumber("8");
        private void button_number9_Click(object sender, EventArgs e) => AddNumber("9");
        private void button_number0_Click(object sender, EventArgs e) => AddNumber("0");

        private void button_add_Click(object sender, EventArgs e) => SetOperation("+");
        private void button_subtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void button_multiple_Click(object sender, EventArgs e) => SetOperation("*");
        private void button_divide_Click(object sender, EventArgs e) => SetOperation("/");

        private void SetOperation(string op)
        {
            calculator.SetOperation(op);
            textBox_prevalue.Text = calculator.ResultValue + op;
            textBox_presentvalue.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            string result = calculator.Calculate();
            textBox_presentvalue.Text = result;
            textBox_prevalue.Text = "";
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            calculator.ClearAll();
            textBox_presentvalue.Text = "";
            textBox_prevalue.Text = "";
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            calculator.ClearCurrent();
            textBox_presentvalue.Text = "";
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(calculator.CurrentValue))
            {
                calculator.SetCurrentValue(calculator.CurrentValue.Substring(0, calculator.CurrentValue.Length - 1));
                textBox_presentvalue.Text = calculator.CurrentValue;
            }
        }
    }
}
