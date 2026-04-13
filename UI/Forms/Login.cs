using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseRegistration.DAL.Data;

namespace CourseRegistration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bool isConnected = DbConnection.TestConnection();

            MessageBox.Show(
                isConnected ? "Kết nối database thành công." : "Kết nối database thất bại.",
                "Kiểm tra kết nối",
                MessageBoxButtons.OK,
                isConnected ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}
