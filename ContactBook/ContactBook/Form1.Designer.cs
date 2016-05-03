namespace ContactBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnName;
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAdd = new CloudToolkitN6.CloudButton();
            this.btnExit = new CloudToolkitN6.CloudButton();
            this.btnClear = new CloudToolkitN6.CloudButton();
            this.btnDelete = new CloudToolkitN6.CloudButton();
            this.btnRemove = new CloudToolkitN6.CloudButton();
            this.btnSave = new CloudToolkitN6.CloudButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cloudLabel5 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel4 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel3 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel2 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel1 = new CloudToolkitN6.CloudLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new CloudToolkitN6.CloudTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new CloudToolkitN6.CloudTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new CloudToolkitN6.CloudTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new CloudToolkitN6.CloudTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cloudHeader1 = new CloudToolkitN6.CloudHeader();
            this.txtSearch = new CloudToolkitN6.CloudTextBox();
            this.btnSearch = new CloudToolkitN6.CloudButton();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnName
            // 
            columnName.Text = "Details";
            columnName.Width = 213;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactId,
            this.colName,
            this.colEmail,
            this.colAddress,
            this.colPhone,
            this.colCountry});
            this.dataGridView1.Location = new System.Drawing.Point(22, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(555, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // colContactId
            // 
            this.colContactId.HeaderText = "ContactId";
            this.colContactId.Name = "colContactId";
            this.colContactId.ReadOnly = true;
            this.colContactId.Visible = false;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl.Location = new System.Drawing.Point(29, 237);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(552, 132);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnAdd.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Icon = null;
            this.btnAdd.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnAdd.IconSpacingX = 5;
            this.btnAdd.IconSpacingY = 5;
            this.btnAdd.IconTransparency = 0F;
            this.btnAdd.Location = new System.Drawing.Point(43, 391);
            this.btnAdd.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnAdd.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnAdd.Size = new System.Drawing.Size(80, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnAdd.TextSpacingX = 5;
            this.btnAdd.TextSpacingY = 5;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnExit.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Icon = null;
            this.btnExit.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnExit.IconSpacingX = 5;
            this.btnExit.IconSpacingY = 5;
            this.btnExit.IconTransparency = 0F;
            this.btnExit.Location = new System.Drawing.Point(473, 391);
            this.btnExit.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnExit.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnExit.Name = "btnExit";
            this.btnExit.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnExit.Size = new System.Drawing.Size(80, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnExit.TextSpacingX = 5;
            this.btnExit.TextSpacingY = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnClear.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Icon = null;
            this.btnClear.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnClear.IconSpacingX = 5;
            this.btnClear.IconSpacingY = 5;
            this.btnClear.IconTransparency = 0F;
            this.btnClear.Location = new System.Drawing.Point(387, 391);
            this.btnClear.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnClear.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnClear.Name = "btnClear";
            this.btnClear.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnClear.Size = new System.Drawing.Size(80, 33);
            this.btnClear.TabIndex = 10;
            this.btnClear.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnClear.TextSpacingX = 5;
            this.btnClear.TextSpacingY = 5;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnDelete.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Icon = null;
            this.btnDelete.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnDelete.IconSpacingX = 5;
            this.btnDelete.IconSpacingY = 5;
            this.btnDelete.IconTransparency = 0F;
            this.btnDelete.Location = new System.Drawing.Point(301, 391);
            this.btnDelete.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnDelete.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnDelete.Size = new System.Drawing.Size(80, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnDelete.TextSpacingX = 5;
            this.btnDelete.TextSpacingY = 5;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnRemove.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Icon = null;
            this.btnRemove.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnRemove.IconSpacingX = 5;
            this.btnRemove.IconSpacingY = 5;
            this.btnRemove.IconTransparency = 0F;
            this.btnRemove.Location = new System.Drawing.Point(215, 391);
            this.btnRemove.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnRemove.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnRemove.Size = new System.Drawing.Size(80, 33);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnRemove.TextSpacingX = 5;
            this.btnRemove.TextSpacingY = 5;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnSave.FontsStyle = System.Drawing.FontStyle.Bold;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Icon = null;
            this.btnSave.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnSave.IconSpacingX = 5;
            this.btnSave.IconSpacingY = 5;
            this.btnSave.IconTransparency = 0F;
            this.btnSave.Location = new System.Drawing.Point(129, 391);
            this.btnSave.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnSave.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnSave.Name = "btnSave";
            this.btnSave.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnSave.TextSpacingX = 5;
            this.btnSave.TextSpacingY = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCountry);
            this.groupBox1.Controls.Add(this.cloudLabel5);
            this.groupBox1.Controls.Add(this.cloudLabel4);
            this.groupBox1.Controls.Add(this.cloudLabel3);
            this.groupBox1.Controls.Add(this.cloudLabel2);
            this.groupBox1.Controls.Add(this.cloudLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 205);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei ",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor  ",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa ",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain ",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland ",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand ",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe "});
            this.cboCountry.Location = new System.Drawing.Point(58, 144);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(143, 21);
            this.cboCountry.Sorted = true;
            this.cboCountry.TabIndex = 10;
            this.cboCountry.Text = "Choose Country";
            // 
            // cloudLabel5
            // 
            this.cloudLabel5.AutoSize = true;
            this.cloudLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel5.Location = new System.Drawing.Point(9, 147);
            this.cloudLabel5.Name = "cloudLabel5";
            this.cloudLabel5.Size = new System.Drawing.Size(43, 13);
            this.cloudLabel5.TabIndex = 4;
            this.cloudLabel5.Text = "Country";
            // 
            // cloudLabel4
            // 
            this.cloudLabel4.AutoSize = true;
            this.cloudLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel4.Location = new System.Drawing.Point(7, 119);
            this.cloudLabel4.Name = "cloudLabel4";
            this.cloudLabel4.Size = new System.Drawing.Size(38, 13);
            this.cloudLabel4.TabIndex = 3;
            this.cloudLabel4.Text = "Phone";
            // 
            // cloudLabel3
            // 
            this.cloudLabel3.AutoSize = true;
            this.cloudLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel3.Location = new System.Drawing.Point(6, 84);
            this.cloudLabel3.Name = "cloudLabel3";
            this.cloudLabel3.Size = new System.Drawing.Size(45, 13);
            this.cloudLabel3.TabIndex = 2;
            this.cloudLabel3.Text = "Address";
            // 
            // cloudLabel2
            // 
            this.cloudLabel2.AutoSize = true;
            this.cloudLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel2.Location = new System.Drawing.Point(16, 53);
            this.cloudLabel2.Name = "cloudLabel2";
            this.cloudLabel2.Size = new System.Drawing.Size(32, 13);
            this.cloudLabel2.TabIndex = 1;
            this.cloudLabel2.Text = "Email";
            // 
            // cloudLabel1
            // 
            this.cloudLabel1.AutoSize = true;
            this.cloudLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.cloudLabel1.Location = new System.Drawing.Point(16, 27);
            this.cloudLabel1.Name = "cloudLabel1";
            this.cloudLabel1.Size = new System.Drawing.Size(35, 13);
            this.cloudLabel1.TabIndex = 0;
            this.cloudLabel1.Text = "Name";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(61, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(57, 72);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 40);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(59, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(57, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 20);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.txtPhone.TabIndexChanged += new System.EventHandler(this.txtPhone_TabIndexChanged);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(59, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contact Book";
            // 
            // cloudHeader1
            // 
            this.cloudHeader1.BackColor = System.Drawing.Color.Transparent;
            this.cloudHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudHeader1.BorderColor = System.Drawing.Color.DarkGray;
            this.cloudHeader1.BorderWidth = 1F;
            this.cloudHeader1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloudHeader1.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.cloudHeader1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.cloudHeader1.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.cloudHeader1.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.cloudHeader1.FontColorMouseOn = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.cloudHeader1.FontColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.cloudHeader1.HeaderText = null;
            this.cloudHeader1.Icon = null;
            this.cloudHeader1.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right;
            this.cloudHeader1.IconPadding = 5;
            this.cloudHeader1.ImageHeader = false;
            this.cloudHeader1.Location = new System.Drawing.Point(382, 56);
            this.cloudHeader1.Name = "cloudHeader1";
            this.cloudHeader1.Size = new System.Drawing.Size(109, 14);
            this.cloudHeader1.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(380, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(109, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextRenderingMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.txtSearch.TextChanged += new System.EventHandler(this.cloudTextBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(152)))));
            this.btnSearch.Icon = null;
            this.btnSearch.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnSearch.IconSpacingX = 5;
            this.btnSearch.IconSpacingY = 5;
            this.btnSearch.IconTransparency = 0F;
            this.btnSearch.Location = new System.Drawing.Point(503, 46);
            this.btnSearch.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnSearch.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnSearch.TextSpacingX = 5;
            this.btnSearch.TextSpacingY = 5;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnName});
            this.lvSearch.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvSearch.Location = new System.Drawing.Point(350, 76);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(214, 133);
            this.lvSearch.TabIndex = 19;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 436);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cloudHeader1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl;
        private CloudToolkitN6.CloudButton btnAdd;
        private CloudToolkitN6.CloudButton btnExit;
        private CloudToolkitN6.CloudButton btnClear;
        private CloudToolkitN6.CloudButton btnDelete;
        private CloudToolkitN6.CloudButton btnRemove;
        private CloudToolkitN6.CloudButton btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private CloudToolkitN6.CloudTextBox txtPhone;
        private CloudToolkitN6.CloudTextBox txtAddress;
        private CloudToolkitN6.CloudTextBox txtEmail;
        private CloudToolkitN6.CloudTextBox txtName;
        private CloudToolkitN6.CloudLabel cloudLabel5;
        private CloudToolkitN6.CloudLabel cloudLabel4;
        private CloudToolkitN6.CloudLabel cloudLabel3;
        private CloudToolkitN6.CloudLabel cloudLabel2;
        private CloudToolkitN6.CloudLabel cloudLabel1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private CloudToolkitN6.CloudHeader cloudHeader1;
        private CloudToolkitN6.CloudTextBox txtSearch;
        private CloudToolkitN6.CloudButton btnSearch;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

