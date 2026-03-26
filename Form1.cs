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
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtInputWindow.Text;

                var result = new System.Data.DataTable().Compute(expression, null);

                // Input에는 전체 식 표시
                txtInputWindow.Text = expression + "=" + result.ToString();

                // output에는 결과값 표시
                txtOutputWindow.Text = result.ToString();
            }
            catch
            {
                txtInputWindow.Text = "오류";
                txtOutputWindow.Text = "";
            }
        }
    }
}
