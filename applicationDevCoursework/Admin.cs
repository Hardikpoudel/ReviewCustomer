using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace applicationDevCoursework
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter insertCategory = new StreamWriter("addedData.txt", true);
            insertCategory.Write(txtCriteria.Text + ",");
            txtCriteria.Text = "";
            insertCategory.Close();
        }
    }
}
