
namespace StudentDatabaseCSharpDB
{
    partial class StudentDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentPanelToolStripMenuItem
            // 
            this.studentPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAStudentToolStripMenuItem,
            this.deleteAStudentToolStripMenuItem,
            this.showAllStudentsToolStripMenuItem});
            this.studentPanelToolStripMenuItem.Name = "studentPanelToolStripMenuItem";
            this.studentPanelToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.studentPanelToolStripMenuItem.Text = "Student Panel";
            this.studentPanelToolStripMenuItem.Click += new System.EventHandler(this.studentPanelToolStripMenuItem_Click);
            // 
            // addAStudentToolStripMenuItem
            // 
            this.addAStudentToolStripMenuItem.Name = "addAStudentToolStripMenuItem";
            this.addAStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAStudentToolStripMenuItem.Text = "Add a Student";
            this.addAStudentToolStripMenuItem.Click += new System.EventHandler(this.addAStudentToolStripMenuItem_Click);
            // 
            // deleteAStudentToolStripMenuItem
            // 
            this.deleteAStudentToolStripMenuItem.Name = "deleteAStudentToolStripMenuItem";
            this.deleteAStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAStudentToolStripMenuItem.Text = "Delete a Student";
            this.deleteAStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteAStudentToolStripMenuItem_Click);
            // 
            // showAllStudentsToolStripMenuItem
            // 
            this.showAllStudentsToolStripMenuItem.Name = "showAllStudentsToolStripMenuItem";
            this.showAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllStudentsToolStripMenuItem.Text = "Show all Students";
            this.showAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.showAllStudentsToolStripMenuItem_Click);
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(50, 122);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(518, 238);
            this.dataGridViewStudentList.TabIndex = 1;
            this.dataGridViewStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 394);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentDatabase";
            this.Text = "Student Database Window";
            this.Load += new System.EventHandler(this.StudentDatabase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStudentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
    }
}

