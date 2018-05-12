using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmStudentInfo : Form
    {
        Studentdb _stdDB = null;
        public frmStudentInfo()
        {
            InitializeComponent();
            _stdDB = new Studentdb();
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stdDB.GetStudentTable();
        }
    }
}
