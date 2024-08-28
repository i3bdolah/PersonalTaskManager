using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                listView1.Items.Add(textBox1.Text);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            //listView1.Items.Remove((Items[0]);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listViewTemp = sender as ListView;
            //listView1.Items.Remove(listViewTemp);            
            MessageBox.Show(sender.ToString());

        }
    }
}
