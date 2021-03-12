using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd2Sql_Click(object sender, EventArgs e)
        {
            string str = "";
            if (secondlibrary.Checked) { str = secondlibrary.Text; }
            else { str = mainlibrary.Text; }

            ExqFunc($"INSERT INTO TBStudents(ID, UserName, Library, Date, Time) VALUES('{textBoxID.Text}', '{textUserName.Text}', '{str}', '{monthCalendar1.SelectionStart.Date.ToString()}', '{TimePicker.Text}')");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "";
            if (secondlibrary.Checked) { str = secondlibrary.Text; }
            else { str = mainlibrary.Text; }

            ExqFunc($"UPDATE TBStudents Set UserName = '{textUserName.Text}', Library = '{str}', Date = '{monthCalendar1.SelectionStart.Date.ToString()}', Time = '{TimePicker.Text}' WHERE ID = '{textBoxID.Text}'");
        }

        private void btnDeleteFSql_Click(object sender, EventArgs e)
        {
            ExqFunc($" DELETE TBStudents" +
                    $" Where ID='{textBoxID.Text}'");
        }

        private void btnReadFromSql_Click(object sender, EventArgs e)
        {
            string output = "";
            string conStr = @"Data Source=DESKTOP-JMBQO1C\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand comm = new SqlCommand("SELECT * FROM TBStudents order by ID", con);

            con.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                output += reader["ID"] + ", " + reader["UserName"] + ", " + reader["Library"] + ", " + reader["Date"] + ", " + reader["Time"] + "\n";
            }
            con.Close();

            labelRes.Text = output;
        }

        private void ExqFunc(string CommStr)
        {
            string conStr = @"Data Source=DESKTOP-JMBQO1C\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand comm = new SqlCommand(CommStr, con);

            con.Open();
            int result = comm.ExecuteNonQuery();
            con.Close();

            MessageBox.Show((result == 1 ? "" : "Not ") + "Succeeded");
        }

    }
}
