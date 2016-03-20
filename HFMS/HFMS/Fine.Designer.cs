namespace HFMS
{
    partial class Fine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine));
            this.lblDueDays = new System.Windows.Forms.Label();
            this.txtDueDays = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSendSms = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.paneAddFine = new System.Windows.Forms.Panel();
            this.paneCollectFine = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.btnCollect = new System.Windows.Forms.Button();
            this.txtRollNo2 = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFineDetail2 = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblFineDetail2 = new System.Windows.Forms.Label();
            this.sidePane = new System.Windows.Forms.Panel();
            this.paneView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMSsentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineRecordTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hFMS_dbDataSet = new HFMS.HFMS_dbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.viewFines = new System.Windows.Forms.Button();
            this.btnCollectFine = new System.Windows.Forms.Button();
            this.btnAddFine = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fineRecordTblTableAdapter = new HFMS.HFMS_dbDataSetTableAdapters.FineRecordTblTableAdapter();
            this.paneAddFine.SuspendLayout();
            this.paneCollectFine.SuspendLayout();
            this.sidePane.SuspendLayout();
            this.paneView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineRecordTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hFMS_dbDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDueDays
            // 
            this.lblDueDays.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDays.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDueDays.Location = new System.Drawing.Point(130, 134);
            this.lblDueDays.Name = "lblDueDays";
            this.lblDueDays.Padding = new System.Windows.Forms.Padding(1);
            this.lblDueDays.Size = new System.Drawing.Size(160, 28);
            this.lblDueDays.TabIndex = 5;
            this.lblDueDays.Text = "Due Days";
            // 
            // txtDueDays
            // 
            this.txtDueDays.Location = new System.Drawing.Point(315, 134);
            this.txtDueDays.Multiline = true;
            this.txtDueDays.Name = "txtDueDays";
            this.txtDueDays.Size = new System.Drawing.Size(263, 28);
            this.txtDueDays.TabIndex = 13;
            this.txtDueDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount);
            // 
            // lblDetail
            // 
            this.lblDetail.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDetail.Location = new System.Drawing.Point(130, 168);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Padding = new System.Windows.Forms.Padding(1);
            this.lblDetail.Size = new System.Drawing.Size(160, 28);
            this.lblDetail.TabIndex = 6;
            this.lblDetail.Text = "Fine Detail";
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFineAmount.Location = new System.Drawing.Point(130, 100);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Padding = new System.Windows.Forms.Padding(1);
            this.lblFineAmount.Size = new System.Drawing.Size(160, 28);
            this.lblFineAmount.TabIndex = 8;
            this.lblFineAmount.Text = "Fine Amount";
            this.lblFineAmount.Click += new System.EventHandler(this.lblFineAmount_Click);
            // 
            // lblRollNo
            // 
            this.lblRollNo.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRollNo.Location = new System.Drawing.Point(130, 66);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Padding = new System.Windows.Forms.Padding(1);
            this.lblRollNo.Size = new System.Drawing.Size(160, 28);
            this.lblRollNo.TabIndex = 9;
            this.lblRollNo.Text = "Roll No.";
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Location = new System.Drawing.Point(315, 100);
            this.txtFineAmount.Multiline = true;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(263, 28);
            this.txtFineAmount.TabIndex = 12;
            this.txtFineAmount.TextChanged += new System.EventHandler(this.txtFineAmount_TextChanged);
            this.txtFineAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount);
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(315, 66);
            this.txtRollNo.Multiline = true;
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(263, 28);
            this.txtRollNo.TabIndex = 11;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(315, 168);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(263, 207);
            this.txtDetail.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(495, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendSms
            // 
            this.btnSendSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSms.Location = new System.Drawing.Point(229, 388);
            this.btnSendSms.Name = "btnSendSms";
            this.btnSendSms.Size = new System.Drawing.Size(84, 28);
            this.btnSendSms.TabIndex = 19;
            this.btnSendSms.Text = "SendSMS";
            this.btnSendSms.UseVisualStyleBackColor = true;
            this.btnSendSms.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(319, 388);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(84, 28);
            this.btnSendMail.TabIndex = 21;
            this.btnSendMail.Text = "SendMail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(406, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 28);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Image = ((System.Drawing.Image)(resources.GetObject("lblHeading.Image")));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Location = new System.Drawing.Point(258, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(1);
            this.lblHeading.Size = new System.Drawing.Size(356, 41);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "   Fine Student";
            // 
            // paneAddFine
            // 
            this.paneAddFine.Controls.Add(this.txtFineAmount);
            this.paneAddFine.Controls.Add(this.btnSave);
            this.paneAddFine.Controls.Add(this.txtRollNo);
            this.paneAddFine.Controls.Add(this.btnSendMail);
            this.paneAddFine.Controls.Add(this.lblHeading);
            this.paneAddFine.Controls.Add(this.btnCancel);
            this.paneAddFine.Controls.Add(this.lblRollNo);
            this.paneAddFine.Controls.Add(this.btnSendSms);
            this.paneAddFine.Controls.Add(this.lblFineAmount);
            this.paneAddFine.Controls.Add(this.lblDueDays);
            this.paneAddFine.Controls.Add(this.txtDetail);
            this.paneAddFine.Controls.Add(this.txtDueDays);
            this.paneAddFine.Controls.Add(this.lblDetail);
            this.paneAddFine.Location = new System.Drawing.Point(200, 3);
            this.paneAddFine.Name = "paneAddFine";
            this.paneAddFine.Size = new System.Drawing.Size(775, 448);
            this.paneAddFine.TabIndex = 23;
            this.paneAddFine.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // paneCollectFine
            // 
            this.paneCollectFine.Controls.Add(this.btnSearch);
            this.paneCollectFine.Controls.Add(this.txtAmount2);
            this.paneCollectFine.Controls.Add(this.btnCollect);
            this.paneCollectFine.Controls.Add(this.txtRollNo2);
            this.paneCollectFine.Controls.Add(this.lblHeader);
            this.paneCollectFine.Controls.Add(this.button6);
            this.paneCollectFine.Controls.Add(this.label2);
            this.paneCollectFine.Controls.Add(this.label3);
            this.paneCollectFine.Controls.Add(this.label4);
            this.paneCollectFine.Controls.Add(this.txtFineDetail2);
            this.paneCollectFine.Controls.Add(this.txtDueDate);
            this.paneCollectFine.Controls.Add(this.lblFineDetail2);
            this.paneCollectFine.Location = new System.Drawing.Point(200, 0);
            this.paneCollectFine.Name = "paneCollectFine";
            this.paneCollectFine.Size = new System.Drawing.Size(775, 446);
            this.paneCollectFine.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(506, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 28);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(320, 110);
            this.txtAmount2.Multiline = true;
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(294, 28);
            this.txtAmount2.TabIndex = 29;
            // 
            // btnCollect
            // 
            this.btnCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.Location = new System.Drawing.Point(440, 344);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(84, 28);
            this.btnCollect.TabIndex = 35;
            this.btnCollect.Text = "Paid";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // txtRollNo2
            // 
            this.txtRollNo2.Location = new System.Drawing.Point(320, 76);
            this.txtRollNo2.Multiline = true;
            this.txtRollNo2.Name = "txtRollNo2";
            this.txtRollNo2.Size = new System.Drawing.Size(144, 28);
            this.txtRollNo2.TabIndex = 28;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(258, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(1);
            this.lblHeader.Size = new System.Drawing.Size(356, 41);
            this.lblHeader.TabIndex = 27;
            this.lblHeader.Text = "   Collect Fine";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(530, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 33;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(135, 76);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Roll No.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(135, 110);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fine Amount";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(135, 144);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Due Date";
            // 
            // txtFineDetail2
            // 
            this.txtFineDetail2.Location = new System.Drawing.Point(320, 178);
            this.txtFineDetail2.Multiline = true;
            this.txtFineDetail2.Name = "txtFineDetail2";
            this.txtFineDetail2.Size = new System.Drawing.Size(294, 135);
            this.txtFineDetail2.TabIndex = 31;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(320, 144);
            this.txtDueDate.Multiline = true;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(294, 28);
            this.txtDueDate.TabIndex = 30;
            // 
            // lblFineDetail2
            // 
            this.lblFineDetail2.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineDetail2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFineDetail2.Location = new System.Drawing.Point(135, 178);
            this.lblFineDetail2.Name = "lblFineDetail2";
            this.lblFineDetail2.Padding = new System.Windows.Forms.Padding(1);
            this.lblFineDetail2.Size = new System.Drawing.Size(160, 28);
            this.lblFineDetail2.TabIndex = 24;
            this.lblFineDetail2.Text = "Fine Detail";
            // 
            // sidePane
            // 
            this.sidePane.BackColor = System.Drawing.Color.SkyBlue;
            this.sidePane.Controls.Add(this.paneView);
            this.sidePane.Controls.Add(this.paneCollectFine);
            this.sidePane.Controls.Add(this.viewFines);
            this.sidePane.Controls.Add(this.btnCollectFine);
            this.sidePane.Controls.Add(this.btnAddFine);
            this.sidePane.Location = new System.Drawing.Point(0, 0);
            this.sidePane.Name = "sidePane";
            this.sidePane.Size = new System.Drawing.Size(200, 448);
            this.sidePane.TabIndex = 24;
            this.sidePane.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePane_Paint);
            // 
            // paneView
            // 
            this.paneView.Controls.Add(this.dataGridView1);
            this.paneView.Controls.Add(this.label1);
            this.paneView.Location = new System.Drawing.Point(200, 0);
            this.paneView.Name = "paneView";
            this.paneView.Size = new System.Drawing.Size(775, 446);
            this.paneView.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.fineDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.fineDetailDataGridViewTextBoxColumn,
            this.sMSsentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fineRecordTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 303);
            this.dataGridView1.TabIndex = 37;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // fineDateDataGridViewTextBoxColumn
            // 
            this.fineDateDataGridViewTextBoxColumn.DataPropertyName = "FineDate";
            this.fineDateDataGridViewTextBoxColumn.HeaderText = "FineDate";
            this.fineDateDataGridViewTextBoxColumn.Name = "fineDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // fineDetailDataGridViewTextBoxColumn
            // 
            this.fineDetailDataGridViewTextBoxColumn.DataPropertyName = "FineDetail";
            this.fineDetailDataGridViewTextBoxColumn.HeaderText = "FineDetail";
            this.fineDetailDataGridViewTextBoxColumn.Name = "fineDetailDataGridViewTextBoxColumn";
            // 
            // sMSsentDataGridViewTextBoxColumn
            // 
            this.sMSsentDataGridViewTextBoxColumn.DataPropertyName = "SMSsent";
            this.sMSsentDataGridViewTextBoxColumn.HeaderText = "SMSsent";
            this.sMSsentDataGridViewTextBoxColumn.Name = "sMSsentDataGridViewTextBoxColumn";
            // 
            // fineRecordTblBindingSource
            // 
            this.fineRecordTblBindingSource.DataMember = "FineRecordTbl";
            this.fineRecordTblBindingSource.DataSource = this.hFMS_dbDataSet;
            // 
            // hFMS_dbDataSet
            // 
            this.hFMS_dbDataSet.DataSetName = "HFMS_dbDataSet";
            this.hFMS_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(190, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(356, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "View All Pendings";
            // 
            // viewFines
            // 
            this.viewFines.Location = new System.Drawing.Point(43, 166);
            this.viewFines.Name = "viewFines";
            this.viewFines.Size = new System.Drawing.Size(125, 23);
            this.viewFines.TabIndex = 2;
            this.viewFines.Text = "View All Pandings";
            this.viewFines.UseVisualStyleBackColor = true;
            this.viewFines.Click += new System.EventHandler(this.viewFines_Click);
            // 
            // btnCollectFine
            // 
            this.btnCollectFine.Location = new System.Drawing.Point(43, 126);
            this.btnCollectFine.Name = "btnCollectFine";
            this.btnCollectFine.Size = new System.Drawing.Size(125, 23);
            this.btnCollectFine.TabIndex = 1;
            this.btnCollectFine.Text = "Collect Fine";
            this.btnCollectFine.UseVisualStyleBackColor = true;
            this.btnCollectFine.Click += new System.EventHandler(this.btnCollectFine_Click);
            // 
            // btnAddFine
            // 
            this.btnAddFine.Location = new System.Drawing.Point(43, 86);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(125, 23);
            this.btnAddFine.TabIndex = 0;
            this.btnAddFine.Text = "Add Fine";
            this.btnAddFine.UseVisualStyleBackColor = true;
            this.btnAddFine.Click += new System.EventHandler(this.button5_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(975, 25);
            this.fillByToolStrip.TabIndex = 25;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fineRecordTblTableAdapter
            // 
            this.fineRecordTblTableAdapter.ClearBeforeFill = true;
            // 
            // Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneAddFine);
            this.Controls.Add(this.sidePane);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "Fine";
            this.Size = new System.Drawing.Size(975, 449);
            this.Load += new System.EventHandler(this.Fine_Load);
            this.paneAddFine.ResumeLayout(false);
            this.paneAddFine.PerformLayout();
            this.paneCollectFine.ResumeLayout(false);
            this.paneCollectFine.PerformLayout();
            this.sidePane.ResumeLayout(false);
            this.paneView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineRecordTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hFMS_dbDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDueDays;
        private System.Windows.Forms.TextBox txtDueDays;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSendSms;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel paneAddFine;
        private System.Windows.Forms.Panel sidePane;
        private System.Windows.Forms.Button viewFines;
        private System.Windows.Forms.Button btnCollectFine;
        private System.Windows.Forms.Button btnAddFine;
        private System.Windows.Forms.Panel paneCollectFine;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtRollNo2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFineDetail2;
        private System.Windows.Forms.Label lblFineDetail2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Panel paneView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMSsentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fineRecordTblBindingSource;
        private HFMS_dbDataSet hFMS_dbDataSet;
        private System.Windows.Forms.Label label1;
        private HFMS_dbDataSetTableAdapters.FineRecordTblTableAdapter fineRecordTblTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
