using System;
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
    public partial class Giaodien : Form
    {
        public Giaodien()
        {
            InitializeComponent();
        }

        private void ShowLogin() //Viết 1 hàm không trả về giá trị và không đối số thực hiện việc hiển thị form 2

        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowLogin)); // Khởi tạo luồng mới
            thread.Start();
            this.Close();
        }

        private void btnBA_Click(object sender, EventArgs e)
        {

        }
    }
}
