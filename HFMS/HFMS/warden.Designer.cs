namespace HFMS
{
    partial class warden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warden));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWarden = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnWarden);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnFine);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 134);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnWarden
            // 
            this.btnWarden.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWarden.Location = new System.Drawing.Point(591, 31);
            this.btnWarden.Name = "btnWarden";
            this.btnWarden.Size = new System.Drawing.Size(113, 68);
            this.btnWarden.TabIndex = 5;
            this.btnWarden.Text = "Wardens";
            this.btnWarden.UseVisualStyleBackColor = true;
            this.btnWarden.Click += new System.EventHandler(this.btnWarden_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(760, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 68);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Log Out";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFine
            // 
            this.btnFine.Image = ((System.Drawing.Image)(resources.GetObject("btnFine.Image")));
            this.btnFine.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFine.Location = new System.Drawing.Point(591, 31);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(113, 68);
            this.btnFine.TabIndex = 3;
            this.btnFine.Text = "Fine";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRoom.Location = new System.Drawing.Point(413, 31);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(113, 68);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStudent.Location = new System.Drawing.Point(238, 31);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(113, 68);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccount.Location = new System.Drawing.Point(67, 31);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(113, 68);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "My Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // warden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 576);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "warden";
            this.Text = "HFMS";
            this.Load += new System.EventHandler(this.warden_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnWarden;
    }
}