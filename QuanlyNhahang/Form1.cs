﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyNhahang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void ShowGiaodien() //Viết 1 hàm không trả về giá trị và không đối số thực hiện việc hiển thị form 2

        {
            Giaodien gd = new Giaodien();
            gd.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string Username = "Admin";
            string Password = "admin";
            if (Username.Equals(txtUsername.Text) && Password.Equals(txtPassword.Text))
            {
                /*Giaodien gd = new Giaodien();
                gd.Show();
                this.Hide();*/
                Thread thread = new Thread(new ThreadStart(ShowGiaodien)); // Khởi tạo luồng mới
                thread.Start(); //Khởi chạy luôngf
                this.Close();   
            }           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng!", "Xác nhận đóng ứng dụng",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
