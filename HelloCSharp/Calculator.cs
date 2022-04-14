namespace HelloCSharp
{
    public enum Operators { Add, Sub, Multi, Div } //������ ������ Ÿ��

        public partial class Calculator : Form
        {
            public double Result = 0;
            public bool isNewNum = true;    //���ο� ������ ����
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
                    MessageBox.Show("sum1�� ���ڸ� �Է����ּ���.");
                    sum1.Focus();   //�ڵ����� Ŀ���� ��
                    return;
                }

                if (int.TryParse(sum1.Text, out number1) == false)
                {
                    MessageBox.Show("sum1�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
                    sum1.SelectAll();   //�Է��� ���� ���õ�][09��
                    sum1.Focus();
                    return;
                }

                if (String.IsNullOrWhiteSpace(sum2.Text))
                {
                    MessageBox.Show("sum2�� ���ڸ� �Է����ּ���.");
                    return;
                }

                if (int.TryParse(sum2.Text, out number2) == false)
                {
                    MessageBox.Show("sum2�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
                    return;
                }

                int sum = Add(number1, number2);    //function(�Լ�) ȣ��
                sumresult.Text = sum.ToString();
            }


            public int Add(int number1, int number2)    //���ϱ� fuction(int��)
            {
                int sum = number1 + number2;
                return sum;
            }

            public float Add(float number1, float number2)  //���ϱ� fuction(float��)
            {
                float sum = number1 + number2;
                return sum;
            }

            public int Sub(int number1, int number2)    //���� fuction
            {
                int sub = number1 - number2;
                return sub;
            }
            */


            //���� �ڵ��غ���

            //���� = 0;.

            //���� �Է�
            //���ϱ� ��ư - ���� �ϼ�, ������ ������ ��, ����� ������ �ٽ� ����
            //���� �Է�
            //���ϱ� ��ư - ���� �ϼ�, ������ ������ ��, ����� ������ �ٽ� ����
            //���� �Է�
            //���ϱ� ��ư - ���� �ϼ�, ������ ������ ��, ����� ������ �ٽ� ����
            //....�ݺ�

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
                        Result = Result + num;  //���� �� ������Ʈ
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
                    isNewNum = true;    //���ο� ���ڸ� �Է¹������ �ǹ�
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

            //���� = 0
            //������ = +

            //���� �Է�
            //������ ��ư - ���� �ϼ�, ������ ���ڸ� ����� �����ڷ� ����, ����� ������ ����, ���� �����ڸ� ����
            //���� �Է�
            //������ ��ư - ���� �ϼ�, ������ ���ڸ� ����� �����ڷ� ����, ����� ������ ����, ���� �����ڸ� ����
            //....�ݺ�
        }
    }