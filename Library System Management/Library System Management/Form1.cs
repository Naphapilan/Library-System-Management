namespace Library_System_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxUsername.Text =="naphapilan")&&(textBoxPassword.Text=="123456"))
            {
                MessageBox.Show("ยินดีต้อนรับเข้าสู่ระบบ");
            }
        }

    }
}