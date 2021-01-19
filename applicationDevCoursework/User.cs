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
    public partial class User : Form
    {
        List<string> myCriterias = new List<string>();
        public User()
        {
            InitializeComponent();
            addingCriteria();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ReadCriterias()
        {
            if (File.Exists("addedData.txt"))
            {
                String data;
                using (StreamReader CriteriaReader = new StreamReader("addedData.txt"))
                {
                    data = CriteriaReader.ReadToEnd();
                }

                if (data != null)
                {
                    //data = data;
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                    myCriterias = data.Split(',').ToList();
                }
            }
        }
        private void addingCriteria()
        {
            ReadCriterias();
            foreach (string value in myCriterias)
            {
                Console.WriteLine(value);
                displayRating.Controls.Add(new Criteria(value));
            }
        }
    }
}