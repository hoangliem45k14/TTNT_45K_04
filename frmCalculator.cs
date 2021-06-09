﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //lay gia tri cua So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia tri cua So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //Cong
            decimal dKQ = dSo1 + dSo2;
            //Hien thi ket qua
            txtKetQua.Text = dKQ.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            //lay gia tri cua So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia tri cua So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //Tru
            decimal dKQ = dSo1 - dSo2;
            //Hien thi ket qua
            txtKetQua.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            //lay gia tri cua So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia tri cua So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //Nhan
            decimal dKQ = dSo1 * dSo2;
            //Hien thi ket qua
            txtKetQua.Text = dKQ.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            //lay gia tri cua So1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //lay gia tri cua So2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //Chia
            decimal dKQ = dSo1 / dSo2;
            //Hien thi ket qua
            txtKetQua.Text = dKQ.ToString();
        }
    }
}
