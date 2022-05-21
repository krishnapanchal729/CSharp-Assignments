
namespace CustomControlTestC1
{
    partial class CustomControlForm
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
            this.userControlCustomControl1 = new CustomControl.UserControlCustomControl();
            this.SuspendLayout();
            // 
            // userControlCustomControl1
            // 
            this.userControlCustomControl1.Location = new System.Drawing.Point(64, 29);
            this.userControlCustomControl1.Name = "userControlCustomControl1";
            this.userControlCustomControl1.Size = new System.Drawing.Size(492, 259);
            this.userControlCustomControl1.TabIndex = 0;
            // 
            // CustomControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 309);
            this.Controls.Add(this.userControlCustomControl1);
            this.Name = "CustomControlForm";
            this.Text = "Custom Control Test CSharp";
            this.Load += new System.EventHandler(this.CustomControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.UserControlCustomControl userControlCustomControl1;
    }
}

