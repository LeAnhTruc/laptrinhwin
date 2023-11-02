﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_2
{
    public partial class Form1 : Form
    {
        private string stt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (txtHoTen.Text.Length.Equals(0))
                    {
                        throw new Exception("Họ tên sinh viên không để rỗng");

                    }
                    //Lấy thông tin
                    string hoten = txtHoTen.Text;
                    string masv = txtMaSV.Text;
                    string ngaysinh = mtxtNgaySinh.Text;
                    string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                    string sothich = null;
                    if (chbDuLich.Checked)
                    {
                    }
                    sothich += "Du Lich";
                    if (chbTheThao.Checked)
                    {
                        sothich += "Thể Thao";
                    }
                    if (chbMuaSam.Checked)
                    {
                        sothich += "Mua Sắm";
                    }
                    if (sothich != null)
                    {
                        sothich = " Sở thích: " + sothich;

                    }
                    //Xuất thông tin ra TextBox txtDanhSach
                    txtDanhSach.Text += stt + "MaSV:" + masv + ". Họ tên: " + hoten + "Ngày sinh:" + ngaysinh + "Giới tính: " + gioitinh + sothich + "\r\n";

                }
                catch (Exception ex)
                {
                    lb1ThongBao.Text = ex.Message;
                }
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}