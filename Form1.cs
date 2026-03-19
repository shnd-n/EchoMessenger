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
            if(string.IsNullOrWhiteSpace(textLine.Text))
            {
                textLine.Focus();
                return;
            }

            typed_msg = textLine.Text;

            logBox.Items.Add(typed_msg);

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
    }
}
