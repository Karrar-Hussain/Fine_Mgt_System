namespace HFMS
{
    partial class Rooms
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
            this.components = new System.ComponentModel.Container();
            this.roomTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Savebtn = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hFMS_dbDataSet = new HFMS.HFMS_dbDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.floorno = new System.Windows.Forms.Label();
            this.txtfloorno = new System.Windows.Forms.TextBox();
            this.vcancy = new System.Windows.Forms.Label();
            this.txtvcancy = new System.Windows.Forms.TextBox();
            this.beds = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtbed = new System.Windows.Forms.TextBox();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.txtFloorNumber = new System.Windows.Forms.TextBox();
            this.lblVacancy = new System.Windows.Forms.Label();
            this.txtVacancy = new System.Windows.Forms.TextBox();
            this.lblBeds = new System.Windows.Forms.Label();
            this.txtBeds = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlInsert.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hFMS_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // roomTblBindingSource
            // 
            this.roomTblBindingSource.DataMember = "RoomTbl";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Update/Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 448);
            this.panel2.TabIndex = 28;
            // 
            // pnlInsert
            // 
            this.pnlInsert.Controls.Add(this.panel1);
            this.pnlInsert.Location = new System.Drawing.Point(200, 0);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(748, 445);
            this.pnlInsert.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 445);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Savebtn);
            this.panel3.Controls.Add(this.pnlUpdate);
            this.panel3.Controls.Add(this.lblFloorNumber);
            this.panel3.Controls.Add(this.txtFloorNumber);
            this.panel3.Controls.Add(this.lblVacancy);
            this.panel3.Controls.Add(this.txtVacancy);
            this.panel3.Controls.Add(this.lblBeds);
            this.panel3.Controls.Add(this.txtBeds);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 445);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(388, 364);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(84, 28);
            this.Savebtn.TabIndex = 24;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.pnlView);
            this.pnlUpdate.Controls.Add(this.label7);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.floorno);
            this.pnlUpdate.Controls.Add(this.txtfloorno);
            this.pnlUpdate.Controls.Add(this.vcancy);
            this.pnlUpdate.Controls.Add(this.txtvcancy);
            this.pnlUpdate.Controls.Add(this.beds);
            this.pnlUpdate.Controls.Add(this.txtSearch);
            this.pnlUpdate.Controls.Add(this.btnSearch);
            this.pnlUpdate.Controls.Add(this.lblId);
            this.pnlUpdate.Controls.Add(this.txtbed);
            this.pnlUpdate.Location = new System.Drawing.Point(17, 54);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(547, 366);
            this.pnlUpdate.TabIndex = 1;
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.dataGridView1);
            this.pnlView.Location = new System.Drawing.Point(117, 225);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(645, 346);
            this.pnlView.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bedsDataGridViewTextBoxColumn,
            this.vacancyDataGridViewTextBoxColumn,
            this.floorNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomTblBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(120, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 92);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedsDataGridViewTextBoxColumn
            // 
            this.bedsDataGridViewTextBoxColumn.DataPropertyName = "Beds";
            this.bedsDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bedsDataGridViewTextBoxColumn.Name = "bedsDataGridViewTextBoxColumn";
            // 
            // vacancyDataGridViewTextBoxColumn
            // 
            this.vacancyDataGridViewTextBoxColumn.DataPropertyName = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.HeaderText = "Vacancy";
            this.vacancyDataGridViewTextBoxColumn.Name = "vacancyDataGridViewTextBoxColumn";
            // 
            // floorNumberDataGridViewTextBoxColumn
            // 
            this.floorNumberDataGridViewTextBoxColumn.DataPropertyName = "FloorNumber";
            this.floorNumberDataGridViewTextBoxColumn.HeaderText = "FloorNumber";
            this.floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
            // 
            // roomTblBindingSource1
            // 
            this.roomTblBindingSource1.DataMember = "RoomTbl";
            this.roomTblBindingSource1.DataSource = this.hFMS_dbDataSet;
            // 
            // hFMS_dbDataSet
            // 
            this.hFMS_dbDataSet.DataSetName = "HFMS_dbDataSet";
            this.hFMS_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(260, 17);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(1);
            this.label7.Size = new System.Drawing.Size(269, 68);
            this.label7.TabIndex = 42;
            this.label7.Text = "Update Room";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(371, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(461, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // floorno
            // 
            this.floorno.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorno.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.floorno.Location = new System.Drawing.Point(151, 299);
            this.floorno.Name = "floorno";
            this.floorno.Padding = new System.Windows.Forms.Padding(1);
            this.floorno.Size = new System.Drawing.Size(160, 28);
            this.floorno.TabIndex = 38;
            this.floorno.Text = "Floor Number";
            // 
            // txtfloorno
            // 
            this.txtfloorno.Location = new System.Drawing.Point(336, 299);
            this.txtfloorno.Multiline = true;
            this.txtfloorno.Name = "txtfloorno";
            this.txtfloorno.Size = new System.Drawing.Size(209, 28);
            this.txtfloorno.TabIndex = 39;
            // 
            // vcancy
            // 
            this.vcancy.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcancy.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.vcancy.Location = new System.Drawing.Point(151, 243);
            this.vcancy.Name = "vcancy";
            this.vcancy.Padding = new System.Windows.Forms.Padding(1);
            this.vcancy.Size = new System.Drawing.Size(160, 28);
            this.vcancy.TabIndex = 36;
            this.vcancy.Text = "Vacancy";
            // 
            // txtvcancy
            // 
            this.txtvcancy.Location = new System.Drawing.Point(336, 243);
            this.txtvcancy.Multiline = true;
            this.txtvcancy.Name = "txtvcancy";
            this.txtvcancy.Size = new System.Drawing.Size(209, 28);
            this.txtvcancy.TabIndex = 37;
            // 
            // beds
            // 
            this.beds.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beds.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.beds.Location = new System.Drawing.Point(151, 188);
            this.beds.Name = "beds";
            this.beds.Padding = new System.Windows.Forms.Padding(1);
            this.beds.Size = new System.Drawing.Size(160, 28);
            this.beds.TabIndex = 34;
            this.beds.Text = "Beds";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 103);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 28);
            this.txtSearch.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(508, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblId.Location = new System.Drawing.Point(151, 103);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(1);
            this.lblId.Size = new System.Drawing.Size(82, 28);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Room Id";
            // 
            // txtbed
            // 
            this.txtbed.Location = new System.Drawing.Point(336, 191);
            this.txtbed.Multiline = true;
            this.txtbed.Name = "txtbed";
            this.txtbed.Size = new System.Drawing.Size(209, 28);
            this.txtbed.TabIndex = 27;
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNumber.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFloorNumber.Location = new System.Drawing.Point(181, 305);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Padding = new System.Windows.Forms.Padding(1);
            this.lblFloorNumber.Size = new System.Drawing.Size(160, 28);
            this.lblFloorNumber.TabIndex = 22;
            this.lblFloorNumber.Text = "Floor Number";
            // 
            // txtFloorNumber
            // 
            this.txtFloorNumber.Location = new System.Drawing.Point(366, 305);
            this.txtFloorNumber.Multiline = true;
            this.txtFloorNumber.Name = "txtFloorNumber";
            this.txtFloorNumber.Size = new System.Drawing.Size(209, 28);
            this.txtFloorNumber.TabIndex = 23;
            // 
            // lblVacancy
            // 
            this.lblVacancy.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacancy.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVacancy.Location = new System.Drawing.Point(181, 249);
            this.lblVacancy.Name = "lblVacancy";
            this.lblVacancy.Padding = new System.Windows.Forms.Padding(1);
            this.lblVacancy.Size = new System.Drawing.Size(160, 28);
            this.lblVacancy.TabIndex = 20;
            this.lblVacancy.Text = "Vacancy";
            // 
            // txtVacancy
            // 
            this.txtVacancy.Location = new System.Drawing.Point(366, 249);
            this.txtVacancy.Multiline = true;
            this.txtVacancy.Name = "txtVacancy";
            this.txtVacancy.Size = new System.Drawing.Size(209, 28);
            this.txtVacancy.TabIndex = 21;
            // 
            // lblBeds
            // 
            this.lblBeds.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeds.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBeds.Location = new System.Drawing.Point(181, 194);
            this.lblBeds.Name = "lblBeds";
            this.lblBeds.Padding = new System.Windows.Forms.Padding(1);
            this.lblBeds.Size = new System.Drawing.Size(160, 28);
            this.lblBeds.TabIndex = 18;
            this.lblBeds.Text = "Beds";
            // 
            // txtBeds
            // 
            this.txtBeds.Location = new System.Drawing.Point(366, 194);
            this.txtBeds.Multiline = true;
            this.txtBeds.Name = "txtBeds";
            this.txtBeds.Size = new System.Drawing.Size(209, 28);
            this.txtBeds.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(491, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::HFMS.Properties.Resources._1446290185_Add;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(178, 88);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(356, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "    Add New Room";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 28);
            this.textBox1.TabIndex = 21;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFirstName.Location = new System.Drawing.Point(27, 88);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Padding = new System.Windows.Forms.Padding(1);
            this.lblFirstName.Size = new System.Drawing.Size(160, 28);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(212, 88);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 28);
            this.txtFirstName.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(320, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Image = global::HFMS.Properties.Resources._1446290185_Add;
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Location = new System.Drawing.Point(24, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(1);
            this.lblHeading.Size = new System.Drawing.Size(356, 42);
            this.lblHeading.TabIndex = 15;
            this.lblHeading.Text = "    Add New Room";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInsert);
            this.Controls.Add(this.panel2);
            this.Name = "Rooms";
            this.Size = new System.Drawing.Size(951, 448);
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlInsert.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource1)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.hFMS_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roomTblBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label floorno;
        private System.Windows.Forms.TextBox txtfloorno;
        private System.Windows.Forms.Label vcancy;
        private System.Windows.Forms.TextBox txtvcancy;
        private System.Windows.Forms.Label beds;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtbed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.TextBox txtFloorNumber;
        private System.Windows.Forms.Label lblVacancy;
        private System.Windows.Forms.TextBox txtVacancy;
        private System.Windows.Forms.Label lblBeds;
        private System.Windows.Forms.TextBox txtBeds;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomTblBindingSource1;
        private HFMS_dbDataSet hFMS_dbDataSet;
        //private HFMS_dbDataSetTableAdapters.RoomTblTableAdapter roomTblTableAdapter;

    }
}
