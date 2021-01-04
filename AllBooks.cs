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
using System.Collections;

namespace Final_Assignment
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
            var connec = DataBase.ConnectionDB();
            connec.Open();
            string query = "select * from Books";
            SqlCommand cmd = new SqlCommand(query,connec);
            
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList books = new ArrayList();
            while(reader.Read())
            {
                Books b = new Books();
                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                b.Author = reader.GetString(reader.GetOrdinal("Author"));
                b.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(b);
                

            }
            
            connec.Close();
            dataGridViewBooks.DataSource = books;



            
        }
            
        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);
        }
        public void SearchData(string value)
        {
            string s_query = "Select * from Books where Name like '%"+value+"%'";
            var connec = DataBase.ConnectionDB();
            connec.Open();
            SqlCommand cmd = new SqlCommand(s_query, connec);

            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList books = new ArrayList();
            while (reader.Read())
            {
                Books b = new Books();
                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                b.Author = reader.GetString(reader.GetOrdinal("Author"));
                b.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(b);


            }

            connec.Close();
            dataGridViewBooks.DataSource = books;


        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Action(object sender, DataGridViewCellEventArgs e)
        {
            Books c = new Books();
            c.Id= Int32.Parse(this.dataGridViewBooks.CurrentRow.Cells[0].Value.ToString());
            c.Name = this.dataGridViewBooks.CurrentRow.Cells[1].Value.ToString();
            c.Author = this.dataGridViewBooks.CurrentRow.Cells[2].Value.ToString();
            c.Edition= this.dataGridViewBooks.CurrentRow.Cells[3].Value.ToString();
            int a = Int32.Parse(this.dataGridViewBooks.CurrentRow.Cells[0].Value.ToString());
            new Book_details(c,a).Show();

        }
    }
}
