using sqliteProjekt.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqliteProjekt.Forms
{
    public partial class ContactList : Form
    {
        private dBHelper dbHelper;

        public ContactList()
        {
            InitializeComponent();
            string connectionString = dBFunctions.ConnectionStringSQLite;
            dbHelper = new dBHelper(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Contact";
            dbHelper.Load(query, "contact_id");
            dataGridView1.DataSource = dbHelper.DataSet.Tables[0];
        }
    }
}
