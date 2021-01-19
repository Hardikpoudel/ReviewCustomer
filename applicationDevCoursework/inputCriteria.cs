using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applicationDevCoursework
{
    public partial class Criteria : UserControl
    {
        public Criteria(string catName)
        {
            InitializeComponent();
            this.nameCat.Text = catName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Criteria_Load(object sender, EventArgs e)
        {

        }
    }
}
