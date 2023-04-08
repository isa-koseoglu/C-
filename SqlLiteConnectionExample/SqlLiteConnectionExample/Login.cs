using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLiteConnectionExample
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=Db/WebBayiCompany.db;Verison=3");
            conn.Open();
            MessageBox.Show(conn.State.ToString());
        }
    }
}
