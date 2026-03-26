using System.Linq.Expressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEqual.Click += btnEqual_Click;
        }

        private void button_Click(object sender, EventArgs e)
        {
            // 버튼 누르면 txtInputWindow에 버튼의 텍스트 추가
            Button btn = sender as Button;
            txtInputWindow.Text += btn.Text;

            if (char.IsDigit(btn.Text[0]))
            {
                txtOutputWindow.Text = txtOutputWindow.Text + btn.Text;
            }
            else
            {
                // 연산자 누르면 숫자 초기화
                txtOutputWindow.Clear();
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string displayExpression = txtInputWindow.Text; // 화면에 보이는 식
                string expression = displayExpression;          // 계산에 사용할 식

                // 계산용만 변환
                expression = expression.Replace("x", "*");
                expression = expression.Replace("÷", "/");

                var result = new System.Data.DataTable().Compute(expression, null);

                // 원래식과 결과를 함께 출력
                txtInputWindow.Text = displayExpression + "=" + result.ToString();

                // 결과만 출력
                txtOutputWindow.Text = result.ToString();
            }
            catch
            {
                txtInputWindow.Text = "오류";
                txtOutputWindow.Text = "";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtInputWindow.Clear();   // 입력창 초기화
            txtOutputWindow.Clear();  // 출력창 초기화
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string text = txtInputWindow.Text;

            if (string.IsNullOrEmpty(text))
                return;

            // 마지막 연산자 위치 찾기
            int lastOp = text.LastIndexOfAny(new char[] { '+', '-', 'x', '÷' });

            if (lastOp >= 0)
            {
                // 연산자까지만 남김
                txtInputWindow.Text = text.Substring(0, lastOp + 1);
            }
            else
            {
                // 연산자 없으면 전체 삭제
                txtInputWindow.Clear();
            }

            txtOutputWindow.Clear(); // txtOutputWindow도 초기화
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInputWindow.Text))
    {
                txtInputWindow.Text = txtInputWindow.Text.Substring(0, txtInputWindow.Text.Length - 1);
            }

            string text = txtInputWindow.Text;

            // 뒤에서부터 숫자만 추출
            string currentNumber = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(text[i]))
                {
                    currentNumber = text[i] + currentNumber;
                }
                else
                {
                    break; // 연산자 나오면 종료
                }
            }

            // 숫자 있을 때만 표시
            if (!string.IsNullOrEmpty(currentNumber))
            {
                txtOutputWindow.Text = currentNumber;
            }
            else
            {
                txtOutputWindow.Clear();
            }
        }
    }
}
