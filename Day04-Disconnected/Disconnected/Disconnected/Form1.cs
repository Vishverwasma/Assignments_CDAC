using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (MySqlConnection CN = new MySqlConnection("Data Source=localhost;Port=3306;Database=vishwasdotnetdb;User Id=root;Password=root"))
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from employee", CN);
                DataSet DS = new DataSet();
                DA.Fill(DS, "employee");
                customerDataGridView.DataSource = DS.Tables[0];
            }
        }
    }
}
