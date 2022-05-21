using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentDatabaseCSharpDB
{
    public partial class DeleteStudentForm : Form
    {
        private OleDbConnection StudentDBConnection;
        public DeleteStudentForm()
        {
            InitializeComponent();
        }
        public void SetDBConnection(ref OleDbConnection DBConnection)
        {
            StudentDBConnection = DBConnection;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Code to delete a student record
            try
            {
                OleDbCommand DeleteCommand = new OleDbCommand();
                DeleteCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "DELETE * FROM STUDENT_TB WHERE StudentTD=" + listBoxStudentsList.SelectedItem + "";
                DeleteCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = DeleteCommand.ExecuteReader();
                DeleteReader.Close();
                LoadstudentInfo();
                MessageBox.Show("Student Information Deleted...", "Student Database");
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            LoadstudentInfo();
        }

        //code to load student information
        private void LoadstudentInfo()
        {
            try
            {
                OleDbCommand DeleteCommand = new OleDbCommand();
                DeleteCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "SELECT* FROM STUDENT_TB";
                DeleteCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = DeleteCommand.ExecuteReader();
                listBoxStudentsList.Items.Clear();
                while (DeleteReader.Read())
                {
                    listBoxStudentsList.Items.Add(DeleteReader.GetValue(0));
                }
                DeleteReader.Close();
            }
            catch( Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void listBoxStudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Code for loading the listbox
            try
            {
                OleDbCommand FindCommand = new OleDbCommand();
                FindCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "SELECT * FROM STUDENT_TB WHERE StudentID=" + listBoxStudentsList.SelectedItem + " ";
                FindCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = FindCommand.ExecuteReader();
                DeleteReader.Read();
                labelName.Text = DeleteReader.GetValue(1).ToString();
                DeleteReader.Close();
            }
            catch( Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
