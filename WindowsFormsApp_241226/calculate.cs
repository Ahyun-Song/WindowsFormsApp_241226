using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculating_machine
{
    class calculate
    {
        //더하기
        public string addtion(string x, string y)
        {
            double result = double.Parse(x) + double.Parse(y);
            return result.ToString();
        }

        //빼기
        public string subtraction(string x, string y)
        {
            double result = double.Parse(x) - double.Parse(y);
            return result.ToString();
        }

        //나누기
        public string division(string x, string y)
        {
            double result = double.Parse(x) / double.Parse(y);
            return result.ToString();
        }

        //곱하기
        public string multiplication(string x, string y)
        {
            double result = double.Parse(x) * double.Parse(y);
            return result.ToString();
        }

        // 제곱
        public string GetSquare_Value(string x)
        {
            double value = double.Parse(x);
            if (value < 0.0) // x가 음수이면
            {
                value = Math.Abs(value);
            }
            double result = value * value;
            return result.ToString();

        }

        // 제곱근
        public string GetRoot_Value(string x)
        {
            double value = double.Parse(x);

            if (value < 0.0) // 음수 입력 처리
            {
                return "입력이 잘못되었습니다.";
            }

            double result = Math.Pow(value, 0.5);
            return result.ToString(); // 결과를 문자열로 반환
        }

        // 역수
        public string GetInverse_Value(string x)
        {
            if (double.Parse(x) == 0)
            {
                return "0으로 나누지 마세요!";
            }

            double result = 1 / double.Parse(x);
            return result.ToString();

        }

        // 퍼센트(%)
        public string GetPercentage_Value(string x)
        {
            double result = double.Parse(x) / 100;
            return result.ToString();
        }

    }
}
