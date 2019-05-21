using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Emad", "22 / 02 / 1950", true, "226778899", "21 / 04 / 2018", "9", "emad@gmail.com");
            dataGridView1.Rows.Add("Van Tan Hien", "22 / 04 / 1993", true, "5192324133", "21 / 04 / 2018", "7", "vantanhien@gmail.com");
            dataGridView1.Rows.Add("Tran Thien", "21 / 07/ 2000", true, "5192342341", "21 / 04 / 2018", "10", "thiennguyen@gmail.com");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
