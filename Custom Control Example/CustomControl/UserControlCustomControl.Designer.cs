﻿namespace CustomControl
{
    partial class UserControlCustomControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSayHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSayHello.Location = new System.Drawing.Point(186, 137);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(118, 47);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "Say Hello ";
            this.buttonSayHello.UseVisualStyleBackColor = false;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Control Button Building .NET Components";
            // 
            // UserControlCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSayHello);
            this.Name = "UserControlCustomControl";
            this.Size = new System.Drawing.Size(492, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.Label label1;
    }
}
