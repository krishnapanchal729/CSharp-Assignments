
namespace Pract1SampleApp
{
    partial class SampleApp
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
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.buttonreadcontent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Location = new System.Drawing.Point(32, 23);
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.Size = new System.Drawing.Size(153, 20);
            this.TextBoxContent.TabIndex = 0;
            // 
            // buttonreadcontent
            // 
            this.buttonreadcontent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonreadcontent.Location = new System.Drawing.Point(33, 72);
            this.buttonreadcontent.Name = "buttonreadcontent";
            this.buttonreadcontent.Size = new System.Drawing.Size(151, 27);
            this.buttonreadcontent.TabIndex = 1;
            this.buttonreadcontent.Text = "Read Content";
            this.buttonreadcontent.UseVisualStyleBackColor = false;
            this.buttonreadcontent.Click += new System.EventHandler(this.buttonreadcontent_Click);
            // 
            // SampleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 175);
            this.Controls.Add(this.buttonreadcontent);
            this.Controls.Add(this.TextBoxContent);
            this.Name = "SampleApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.Button buttonreadcontent;
    }
}

