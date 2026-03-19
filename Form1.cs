using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textLine.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string typed_msg;
            if (string.IsNullOrWhiteSpace(textLine.Text))
            {
                textLine.Focus();
                return;
            }
            typed_msg = textLine.Text.Trim();

            string result = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}";

            logBox.Items.Add(result);
            countBox.Text = $"현재 대화: {logBox.Items.Count}개";

            textLine.Clear();

            textLine.Focus();
        }

        private void textLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterButton.PerformClick();
            }
        }

        private void logBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (logBox.SelectedItem != null)
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (logBox.SelectedItem != null)
            {
                logBox.Items.Remove(logBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 메세지가 선택되지 않았습니다.");
            }
        }
    }
}
