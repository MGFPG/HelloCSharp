namespace HelloCSharp
{
    public enum Operators { Add, Sub, Multi, Div } //열거형 데이터 타입

        public partial class Calculator : Form
        {
            public double Result = 0;
            public bool isNewNum = true;    //새로운 숫자의 시작
            public Operators Opt = Operators.Add;

            public Calculator()
            {
                InitializeComponent();
            }

            /*
            private void HelloLabel_Click(object sender, EventArgs e)
            {
                int number1 = 1;
                int number2 = 2;

                int sum = number1 + number2;

                HelloLabel.Text = sum.ToString();

            }

            private void button1_Click(object sender, EventArgs e)
            {
                int number1 = 0;
                int number2 = 0;

                if (String.IsNullOrWhiteSpace(sum1.Text))
                {
                    MessageBox.Show("sum1에 숫자를 입력해주세요.");
                    sum1.Focus();   //자동으로 커서가 감
                    return;
                }

                if (int.TryParse(sum1.Text, out number1) == false)
                {
                    MessageBox.Show("sum1에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                    sum1.SelectAll();   //입력한 모든게 선택됨][09ㅐ
                    sum1.Focus();
                    return;
                }

                if (String.IsNullOrWhiteSpace(sum2.Text))
                {
                    MessageBox.Show("sum2에 숫자를 입력해주세요.");
                    return;
                }

                if (int.TryParse(sum2.Text, out number2) == false)
                {
                    MessageBox.Show("sum2에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                    return;
                }

                int sum = Add(number1, number2);    //function(함수) 호출
                sumresult.Text = sum.ToString();
            }


            public int Add(int number1, int number2)    //더하기 fuction(int형)
            {
                int sum = number1 + number2;
                return sum;
            }

            public float Add(float number1, float number2)  //더하기 fuction(float형)
            {
                float sum = number1 + number2;
                return sum;
            }

            public int Sub(int number1, int number2)    //빼기 fuction
            {
                int sub = number1 - number2;
                return sub;
            }
            */


            //계산기 코딩해보자

            //변수 = 0;.

            //숫자 입력
            //더하기 버튼 - 숫자 완성, 변수와 숫자의 합, 결과를 변수에 다시 저장
            //숫자 입력
            //더하기 버튼 - 숫자 완성, 변수와 숫자의 합, 결과를 변수에 다시 저장
            //숫자 입력
            //더하기 버튼 - 숫자 완성, 변수와 숫자의 합, 결과를 변수에 다시 저장
            //....반복

            private void NumButton1_Click(object sender, EventArgs e)
            {
                Button numButton = (Button)sender;
                SetNum(numButton.Text);
            }

            public void SetNum(string num)
            {
                if (isNewNum)
                {
                    NumScreen.Text = num;
                    isNewNum = false;
                }
                else if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text = NumScreen.Text + num;
                }
            }

            private void NumPlus_Click(object sender, EventArgs e)
            {
                if (isNewNum == false)
                {
                    int num = int.Parse(NumScreen.Text);
                    if (Opt == Operators.Add)
                    {
                        Result = Result + num;  //현재 값 업데이트
                    }
                    else if (Opt == Operators.Sub)
                    {
                        Result = Result - num;
                    }
                    else if (Opt == Operators.Multi)
                    {
                        Result = Result * num;
                    }
                    else if (Opt == Operators.Div)
                    {
                        Result = Result / num;
                    }

                    NumScreen.Text = Result.ToString();
                    isNewNum = true;    //새로운 숫자를 입력받으라는 의미
                }

                Button optButton = (Button)sender;
                if (optButton.Text == "+")
                {
                    Opt = Operators.Add;
                }
                else if (optButton.Text == "-")
                {
                    Opt = Operators.Sub;
                }
                else if (optButton.Text == "*")
                {
                    Opt = Operators.Multi;
                }
                else if (optButton.Text == "/")
                {
                    Opt = Operators.Div;
                }
            }

            private void NumClear_Click(object sender, EventArgs e)
            {
                Result = 0;
                isNewNum = true;
                Opt = Operators.Add;

                NumScreen.Text = "0";
            }

            //변수 = 0
            //연산자 = +

            //숫자 입력
            //연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
            //숫자 입력
            //연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
            //....반복
        }
    }