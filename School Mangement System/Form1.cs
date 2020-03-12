using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace School_Mangement_System
{
    public partial class Form1 : Form
    {


        string connStr = "Server=INSTRUCTORIT; Database=IBTCollege; User Id=ProfileUser; Password=ProfileUser2019";


        public Form1()
        {
            InitializeComponent();
        }

        private void Save()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();

                string addRecord = String.Format("INSERT INTO Students " +
                    "(firstName, lastName, ID, emailAddress) " +
                    "VALUES ('{0}', '{1}', {2}, '{3}')", 
                    txtFirstName1.Text, txtLastName1.Text, txtId1.Text, txtEmail1.Text);

                SqlCommand cmd = new SqlCommand(addRecord, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show(String.Format("{0},{1}, Added into the database.", txtFirstName1, txtLastName1));

            }

            //
            txtFirstName1.Clear();
            txtLastName1.Clear();
            txtId1.Clear();
            txtEmail1.Clear();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string testConn = "SELECT COUNT (id) FROM Students";
                SqlCommand cmd = new SqlCommand(testConn, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int total = 0;

                while (reader.Read())
                {
                    total++;
                }

                
            }

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDateReal.Text = DateTime.Now.ToLongDateString();
        }

        private void SearchBox()
        {
            lstStudentSearch.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string SearchConn = String.Format("SELECT * FROM Students" +
                    " WHERE firstName='{0}' OR lastName='{1}' OR ID={2}",
                    txtFirstName2.Text, txtLastName2.Text, txtId2.Text);
                SqlCommand cmd = new SqlCommand(SearchConn, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int rowsAffected = 0;

                while (reader.Read())
                {
                    string fullName = reader["firstName"] + " " + reader["lastName"];
                    lstStudentSearch.Items.Add(fullName);
                    rowsAffected++;
                }
                
            }
        }

        

        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            SearchBox();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LblDateReal_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            txtFirstName1.Clear();
            txtLastName1.Clear();
            txtId1.Clear();
            txtEmail1.Clear();
            txtFirstName1.Focus();
        }

        private void TabSearchStudent_Click(object sender, EventArgs e)
        {

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"C:"))
            {
                foreach (String itemRow in lstExport.Items)
                {
                    sw.WriteLine(itemRow.ToString());
                }
            }
        }

        private void BtnCancel2_Click(object sender, EventArgs e)
        {
            txtFirstName2.Clear();
            txtLastName2.Clear();
            txtId2.Clear();
            txtEmail2.Clear();
            txtFirstName2.Focus();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
