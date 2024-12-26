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
        // 계산기 상태를 관리하는 구조체
        public struct CalculationState
        {
            public string BeforeValue;
            public string CurrentValue;
            public string ResultValue;
            public string Operation;

            public CalculationState(string beforeValue, string currentValue, string resultValue, string operation)
            {
                BeforeValue = beforeValue;
                CurrentValue = currentValue;
                ResultValue = resultValue;
                Operation = operation;
            }
        }

        // 계산기 연산 기록을 관리하는 구조체
        public struct CalculationHistory
        {
            public string Operation;
            public string Operand1;
            public string Operand2;
            public string Result;

            public CalculationHistory(string operation, string operand1, string operand2, string result)
            {
                Operation = operation;
                Operand1 = operand1;
                Operand2 = operand2;
                Result = result;
            }
        }

        // 계산기 오류 상태를 관리하는 구조체
        public struct ErrorState
        {
            public bool HasError;
            public string ErrorMessage;

            public ErrorState(bool hasError, string errorMessage)
            {
                HasError = hasError;
                ErrorMessage = errorMessage;
            }
        }

        // 계산기 클래스 인스턴스 및 상태 변수
        private calculate cal = new calculate();
        private CalculationState calcState;
        private List<CalculationHistory> history = new List<CalculationHistory>();
        private ErrorState errorState = new ErrorState(false, "");

        public Form1()
        {
            InitializeComponent();
            calcState = new CalculationState("", "", "", "");
        }

        // 숫자 버튼 클릭 핸들러
        private void button_number1_Click(object sender, EventArgs e) => AddNumber("1");
        private void button_number2_Click(object sender, EventArgs e) => AddNumber("2");
        private void button_number3_Click(object sender, EventArgs e) => AddNumber("3");
        private void button_number4_Click(object sender, EventArgs e) => AddNumber("4");
        private void button_number5_Click(object sender, EventArgs e) => AddNumber("5");
        private void button_number6_Click(object sender, EventArgs e) => AddNumber("6");
        private void button_number7_Click(object sender, EventArgs e) => AddNumber("7");
        private void button_number8_Click(object sender, EventArgs e) => AddNumber("8");
        private void button_number9_Click(object sender, EventArgs e) => AddNumber("9");
        private void button_number0_Click(object sender, EventArgs e) => calcState.CurrentValue = calcState.CurrentValue != "0" ? calcState.CurrentValue + "0" : calcState.CurrentValue;

        // 연산 버튼 클릭 핸들러
        private void button_add_Click(object sender, EventArgs e) => SetOperation("+");
        private void button_subtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void button_multiple_Click(object sender, EventArgs e) => SetOperation("*");
        private void button_divide_Click(object sender, EventArgs e) => SetOperation("/");

        // 기타 기능 버튼 핸들러
        private void button_ce_Click(object sender, EventArgs e) => ClearCurrentValue();
        private void button_c_Click(object sender, EventArgs e) => ClearAllValues();
        private void button_backspace_Click(object sender, EventArgs e) => RemoveLastCharacter();
        private void button_covertsign_Click(object sender, EventArgs e) => ConvertSign();
        private void button_percent_Click(object sender, EventArgs e) => ApplyPercentage();
        private void button_invert_Click(object sender, EventArgs e) => ApplyInverse();
        private void button_spuare_Click(object sender, EventArgs e) => ApplySquare();
        private void button_squareroot_Click(object sender, EventArgs e) => ApplySquareRoot();
        private void button_float_Click(object sender, EventArgs e) => calcState.CurrentValue = calcState.CurrentValue.IndexOf(".") == -1 ? calcState.CurrentValue + "." : calcState.CurrentValue;
        private void button_equal_Click(object sender, EventArgs e) => CalculateResult();

        // 숫자 추가 함수
        private void AddNumber(string number)
        {
            calcState.CurrentValue += number;
            textBox_presentvalue.Text = calcState.CurrentValue;
        }

        // 현재 값 지우기
        private void ClearCurrentValue()
        {
            calcState.CurrentValue = "";
            textBox_presentvalue.Text = "";
            calcState.Operation = "";
        }

        // 모든 값 지우기
        private void ClearAllValues()
        {
            calcState.CurrentValue = "";
            calcState.ResultValue = "";
            calcState.BeforeValue = "";
            calcState.Operation = "";
            textBox_presentvalue.Text = "";
            textBox_prevalue.Text = "";
        }

        // 마지막 문자 지우기
        private void RemoveLastCharacter()
        {
            if (calcState.CurrentValue.Length > 0)
            {
                calcState.CurrentValue = calcState.CurrentValue.Substring(0, calcState.CurrentValue.Length - 1);
                textBox_presentvalue.Text = calcState.CurrentValue;
            }
        }

        // 연산 설정
        private void SetOperation(string op)
        {
            if (calcState.CurrentValue.Length != 0)
            {
                if (calcState.ResultValue == "")
                {
                    calcState.ResultValue = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = calcState.ResultValue + op;
                calcState.CurrentValue = "";
                textBox_presentvalue.Text = "";
                calcState.Operation = op;
            }
        }

        // 부호 변환
        private void ConvertSign()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                calcState.CurrentValue = textBox_presentvalue.Text;
                double resConvert = double.Parse(calcState.CurrentValue) * -1;
                calcState.CurrentValue = resConvert.ToString();
                textBox_presentvalue.Text = calcState.CurrentValue;
            }
        }

        // 백분율 적용
        private void ApplyPercentage()
        {
            if (calcState.CurrentValue.Length != 0)
            {
                if (calcState.ResultValue == "")
                {
                    calcState.ResultValue = "0";
                    calcState.CurrentValue = "";
                    textBox_prevalue.Text = calcState.ResultValue;
                    textBox_presentvalue.Text = "";
                }
                else if (calcState.ResultValue != "")
                {
                    calcState.ResultValue = (double.Parse(calcState.ResultValue) / 100).ToString();
                    calcState.CurrentValue = "";
                    textBox_prevalue.Text = calcState.ResultValue;
                    textBox_presentvalue.Text = "";
                }
            }
        }

        // 역수 계산
        private void ApplyInverse()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                calcState.ResultValue = cal.GetInverse_Value(textBox_presentvalue.Text);
                calcState.CurrentValue = "";
                textBox_prevalue.Text = "1/(" + textBox_presentvalue.Text + ")";
                textBox_presentvalue.Text = calcState.ResultValue;
            }
            else if (textBox_presentvalue.Text.Length == 0)
            {
                textBox_presentvalue.Text = "0으로 나누지 마세요!";
                textBox_prevalue.Text = "1/0";
            }
        }

        // 제곱 계산
        private void ApplySquare()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                calcState.ResultValue = cal.GetSquare_Value(textBox_presentvalue.Text);
                textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                calcState.CurrentValue = "";
                textBox_presentvalue.Text = calcState.ResultValue;
            }
        }

        // 제곱근 계산
        private void ApplySquareRoot()
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                calcState.ResultValue = cal.GetRoot_Value(textBox_presentvalue.Text);
                if (calcState.ResultValue == "입력이 잘못되었습니다.")
                {
                    textBox_presentvalue.Text = calcState.ResultValue;
                    calcState.ResultValue = "";
                    textBox_prevalue.Text = "";
                }
                else
                {
                    calcState.CurrentValue = "";
                    textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                    textBox_presentvalue.Text = calcState.ResultValue;
                }
            }
        }

        // 결과 계산
        private void CalculateResult()
        {
            switch (calcState.Operation)
            {
                case "+":
                    if (calcState.CurrentValue == "") break;
                    calcState.ResultValue = cal.addtion(calcState.ResultValue, calcState.CurrentValue);
                    history.Add(new CalculationHistory("+", calcState.ResultValue, calcState.CurrentValue, calcState.ResultValue)); // 히스토리 추가
                    textBox_prevalue.Text += calcState.CurrentValue;
                    textBox_presentvalue.Text = calcState.ResultValue;
                    break;
                case "-":
                    if (calcState.CurrentValue == "") break;
                    calcState.ResultValue = cal.subtraction(calcState.ResultValue, calcState.CurrentValue);
                    history.Add(new CalculationHistory("-", calcState.ResultValue, calcState.CurrentValue, calcState.ResultValue)); // 히스토리 추가
                    textBox_prevalue.Text += calcState.CurrentValue;
                    textBox_presentvalue.Text = calcState.ResultValue;
                    break;
                case "*":
                    if (calcState.CurrentValue == "") break;
                    calcState.ResultValue = cal.multiplication(calcState.ResultValue, calcState.CurrentValue);
                    history.Add(new CalculationHistory("*", calcState.ResultValue, calcState.CurrentValue, calcState.ResultValue)); // 히스토리 추가
                    textBox_prevalue.Text += calcState.CurrentValue;
                    textBox_presentvalue.Text = calcState.ResultValue;
                    break;
                case "/":
                    if (calcState.CurrentValue == "") break;
                    calcState.ResultValue = cal.division(calcState.ResultValue, calcState.CurrentValue);
                    if (calcState.ResultValue == "∞")
                    {
                        textBox_presentvalue.Text = "0으로 나눌 수 없습니다.";
                        calcState.Operation = "";
                        calcState.ResultValue = "";
                        textBox_prevalue.Text = "";
                        break;
                    }
                    textBox_presentvalue.Text = calcState.ResultValue;
                    break;
            }
            calcState.Operation = "";
        }
    }
}
