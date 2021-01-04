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
    public partial class Book_details : Form
    {
        public Book_details(Books c,int id)
        {
            InitializeComponent();
            textBoxBId.Text = c.Id.ToString();
            textBoxBName.Text = c.Name;
            textBoxAName.Text = c.Author;
            textBoxEdition.Text = c.Edition;
            Search(id);

            
        }
        public void Search(int value)
        {
            string s_query = "Select * from Books where Id= '" + value + "'";
            

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
            dataGridView1.DataSource = books;


        }

        private void Book_details4_Load(object sender, EventArgs e)
        {

        }

        private void labelBookDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
