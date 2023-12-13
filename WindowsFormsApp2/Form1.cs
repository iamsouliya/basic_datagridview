using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fullscreen
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // make panel center
            panel1.Location = new Point();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check when checkbox is checked
            if (rdMale.Checked)
            {
                MessageBox.Show("You pressed male");
            }
            else if (rdFemale.Checked)
            {
                MessageBox.Show("You pressed female");
            }
        }

        public void AddItemToDataGridView()
        {
            String gender = "";
            // add item to data grid view
            DataGridView dataGridView = dataGridView1;

            if (rdMale.Checked)
            {
                gender = rdMale.Text;
            }
            else if (rdFemale.Checked)
            {
                gender = rdFemale.Text;
            }

            dataGridView.Rows.Add(gender, txtFirstname.Text, txtLastname.Text, txtPhone.Text, txtEmail.Text, txtFacebook.Text, dtDob.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show time now when clicked
            MessageBox.Show(DateTime.Now.ToString());
        }
    }
}
