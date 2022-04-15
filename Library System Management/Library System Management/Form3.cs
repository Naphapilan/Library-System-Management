using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = tbName.Text;
            dataGridView1.Rows[n].Cells[1].Value = tbID.Text;

            if(rdStudent.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdStudent.Text;
                dataGridView1.Rows[n].Cells[3].Value = " ";
                dataGridView1.Rows[n].Cells[4].Value = " ";
            if(rdTeacher.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdTeacher.Text;
                dataGridView1.Rows[n].Cells[3].Value = " ";
                dataGridView1.Rows[n].Cells[4].Value = " ";
            if (rdStaft.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdStaft.Text;
                dataGridView1.Rows[n].Cells[3].Value = tbUsename.Text;
                dataGridView1.Rows[n].Cells[4].Value = tbPassword.Text;
        }
    }
}
