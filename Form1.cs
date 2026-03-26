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
            txtOutputWindow.Text = btn.Text;  // 출력창에도 같이 표시
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
    }
}
