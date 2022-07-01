using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week14_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRENT_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string movie = listBox1.SelectedItem.ToString();
                if (!listBox2.Items.Contains(movie))
                {
                    listBox2.Items.Add(movie);
                    listBox1.Items.Remove(movie);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                string movie = listBox2.SelectedItem.ToString();
                if (!listBox1.Items.Contains(movie))
                {
                    listBox1.Items.Add(movie);
                    listBox2.Items.Remove(movie);
                }
            }
        }
    }
}
