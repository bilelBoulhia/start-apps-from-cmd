using System.Drawing;

namespace start_from_command
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNfile = new System.Windows.Forms.Button();
            this.LVapp = new System.Windows.Forms.ListBox();
            this.Lberr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNadd = new System.Windows.Forms.Button();
            this.TBshowFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNfile
            // 
            this.BTNfile.Location = new System.Drawing.Point(241, 315);
            this.BTNfile.Name = "BTNfile";
            this.BTNfile.Size = new System.Drawing.Size(61, 27);
            this.BTNfile.TabIndex = 2;
            this.BTNfile.Text = "•••";
            this.BTNfile.UseVisualStyleBackColor = true;
            this.BTNfile.Click += new System.EventHandler(this.BTNfile_Click);
            // 
            // LVapp
            // 
            this.LVapp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LVapp.FormattingEnabled = true;
            this.LVapp.ItemHeight = 16;
            this.LVapp.Location = new System.Drawing.Point(12, 1);
            this.LVapp.Name = "LVapp";
            this.LVapp.Size = new System.Drawing.Size(776, 276);
            this.LVapp.TabIndex = 3;
            this.LVapp.SelectedIndexChanged += new System.EventHandler(this.LVapp_SelectedIndexChanged);
            // 
            // Lberr
            // 
            this.Lberr.Location = new System.Drawing.Point(21, 33);
            this.Lberr.Name = "Lberr";
            this.Lberr.Size = new System.Drawing.Size(305, 23);
            this.Lberr.TabIndex = 4;
            this.Lberr.Text = "label1";
            this.Lberr.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "add the app to cmd :";
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(241, 357);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(61, 28);
            this.BTNadd.TabIndex = 7;
            this.BTNadd.Text = "add";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // TBshowFilePath
            // 
            this.TBshowFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TBshowFilePath.Location = new System.Drawing.Point(310, 317);
            this.TBshowFilePath.Name = "TBshowFilePath";
            this.TBshowFilePath.ReadOnly = true;
            this.TBshowFilePath.Size = new System.Drawing.Size(322, 22);
            this.TBshowFilePath.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "browse files";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(773, 61);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(807, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "note : after adding the app use use it by typing start %your app name% in cmd or " + "\" + \"powershell\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBshowFilePath);
            this.Controls.Add(this.BTNadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lberr);
            this.Controls.Add(this.LVapp);
            this.Controls.Add(this.BTNfile);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.TextBox TBshowFilePath;

        private System.Windows.Forms.Label Lberr;

        private System.Windows.Forms.ListBox LVapp;

        private System.Windows.Forms.Button BTNfile;

        #endregion
    }
}