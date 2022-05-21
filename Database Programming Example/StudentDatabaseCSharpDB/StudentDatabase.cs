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
    public partial class StudentDatabase : Form
    {
        private DataTable GridStudentTableDisplay;
        private OleDbConnection StudentDBConnection;

        public StudentDatabase()
        {
            InitializeComponent();
        }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm AddStudent = new AddStudentForm();
            AddStudent.SetDBConnection(ref StudentDBConnection);
            AddStudent.ShowDialog();

        }

        private void deleteAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentForm DeleteStudent = new DeleteStudentForm();
            DeleteStudent.SetDBConnection(ref StudentDBConnection);
            DeleteStudent.ShowDialog();
        }

        private void showAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code to show all student details
            try
            {
                string mySelectQuery = "SELECT*FROM STUDENT_TB";
                OleDbCommand StudentCommand = new OleDbCommand(mySelectQuery, StudentDBConnection);
                OleDbDataAdapter StudentDataAdapter = new OleDbDataAdapter();
                StudentDataAdapter.SelectCommand = StudentCommand;
                DataSet StudentDataSet = new DataSet();
                StudentDataAdapter.Fill(StudentDataSet, "STUDENT_TB");
                dataGridViewStudentList.DataSource = StudentDataSet.Tables["STUDENT_TB"];
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void studentPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentDatabase_Load(object sender, EventArgs e)
        {
            GridStudentTableDisplay = new DataTable();
            GridStudentTableDisplay.Columns.Add("Student ID");
            GridStudentTableDisplay.Columns.Add("Student Name");
            GridStudentTableDisplay.Columns.Add("Student Age");
            dataGridViewStudentList.DataSource = GridStudentTableDisplay;

            //Opening Connection
            StudentDBConnection = new OleDbConnection();
            StudentDBConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data sources="; //Connection established
            StudentDBConnection.ConnectionString += "D:\\KTS Infotech\\C# Tutorials Assignment\\Database Programming Example\\StudentDatabaseCSharpDB\\StudentDatabase1.accdb";
            try
            {
                StudentDBConnection.Open();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
