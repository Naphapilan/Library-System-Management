namespace Library_System_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text !="naphapilan")  
            {
                MessageBox.Show("Usename ไม่ถูกต้อง");
            }
            if (textBoxPassword.Text != "123456")
            {
                MessageBox.Show("Password ไม่ถูกต้อง");
            }
            
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void buttonStudentRegis_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonStaftRegis_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}