﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace IMS
{
    public partial class Form1 :Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.MdiParent = this;
            fLogin.Show();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmManagProduct fProduct = new frmManagProduct();
            fProduct.MdiParent = this;
            fProduct.Show();
        }
    }
}
