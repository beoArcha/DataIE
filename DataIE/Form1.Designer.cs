namespace DataIE
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboDatabaseList = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSQLtoXML = new System.Windows.Forms.Button();
            this.buttonXMLtoSQL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioXML = new System.Windows.Forms.RadioButton();
            this.radioSQL = new System.Windows.Forms.RadioButton();
            this.buttonSchemaToXML = new System.Windows.Forms.Button();
            this.buttonAddTableXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(104, 45);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(116, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "root";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(104, 79);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(116, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Location = new System.Drawing.Point(104, 113);
            this.textBoxDataSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(116, 22);
            this.textBoxDataSource.TabIndex = 5;
            this.textBoxDataSource.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "data source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(104, 147);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(116, 22);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.Text = "3306";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDatabase.Location = new System.Drawing.Point(104, 181);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(116, 22);
            this.textBoxDatabase.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 305);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(88, 357);
            this.buttonShowData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(116, 49);
            this.buttonShowData.TabIndex = 3;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Visible = false;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(727, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(104, 215);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(116, 49);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Test connection";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboDatabaseList
            // 
            this.comboDatabaseList.FormattingEnabled = true;
            this.comboDatabaseList.Items.AddRange(new object[] {
            "OK",
            "Lool"});
            this.comboDatabaseList.Location = new System.Drawing.Point(34, 308);
            this.comboDatabaseList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDatabaseList.Name = "comboDatabaseList";
            this.comboDatabaseList.Size = new System.Drawing.Size(187, 25);
            this.comboDatabaseList.TabIndex = 2;
            this.comboDatabaseList.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "List of tables";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSQLtoXML
            // 
            this.buttonSQLtoXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSQLtoXML.Location = new System.Drawing.Point(235, 357);
            this.buttonSQLtoXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSQLtoXML.Name = "buttonSQLtoXML";
            this.buttonSQLtoXML.Size = new System.Drawing.Size(116, 49);
            this.buttonSQLtoXML.TabIndex = 5;
            this.buttonSQLtoXML.Text = "Backup data XML";
            this.buttonSQLtoXML.UseVisualStyleBackColor = true;
            this.buttonSQLtoXML.Visible = false;
            this.buttonSQLtoXML.Click += new System.EventHandler(this.buttonSQLtoXML_Click);
            // 
            // buttonXMLtoSQL
            // 
            this.buttonXMLtoSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonXMLtoSQL.Location = new System.Drawing.Point(480, 357);
            this.buttonXMLtoSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXMLtoSQL.Name = "buttonXMLtoSQL";
            this.buttonXMLtoSQL.Size = new System.Drawing.Size(116, 49);
            this.buttonXMLtoSQL.TabIndex = 6;
            this.buttonXMLtoSQL.Text = "Adding data to database";
            this.buttonXMLtoSQL.UseVisualStyleBackColor = true;
            this.buttonXMLtoSQL.Visible = false;
            this.buttonXMLtoSQL.Click += new System.EventHandler(this.buttonXMLtoSQL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioXML);
            this.groupBox1.Controls.Add(this.radioSQL);
            this.groupBox1.Location = new System.Drawing.Point(8, 344);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(74, 75);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // radioXML
            // 
            this.radioXML.AutoSize = true;
            this.radioXML.Location = new System.Drawing.Point(11, 39);
            this.radioXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioXML.Name = "radioXML";
            this.radioXML.Size = new System.Drawing.Size(57, 21);
            this.radioXML.TabIndex = 1;
            this.radioXML.Text = "XML";
            this.radioXML.UseVisualStyleBackColor = true;
            // 
            // radioSQL
            // 
            this.radioSQL.AutoSize = true;
            this.radioSQL.Checked = true;
            this.radioSQL.Location = new System.Drawing.Point(11, 13);
            this.radioSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSQL.Name = "radioSQL";
            this.radioSQL.Size = new System.Drawing.Size(57, 21);
            this.radioSQL.TabIndex = 0;
            this.radioSQL.TabStop = true;
            this.radioSQL.Text = "SQL";
            this.radioSQL.UseVisualStyleBackColor = true;
            // 
            // buttonSchemaToXML
            // 
            this.buttonSchemaToXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSchemaToXML.Location = new System.Drawing.Point(355, 357);
            this.buttonSchemaToXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSchemaToXML.Name = "buttonSchemaToXML";
            this.buttonSchemaToXML.Size = new System.Drawing.Size(116, 49);
            this.buttonSchemaToXML.TabIndex = 154;
            this.buttonSchemaToXML.Text = "Backup database schema to XML";
            this.buttonSchemaToXML.UseVisualStyleBackColor = true;
            this.buttonSchemaToXML.Visible = false;
            this.buttonSchemaToXML.Click += new System.EventHandler(this.buttonSchemaToXML_Click);
            // 
            // buttonAddTableXML
            // 
            this.buttonAddTableXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddTableXML.Location = new System.Drawing.Point(603, 357);
            this.buttonAddTableXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTableXML.Name = "buttonAddTableXML";
            this.buttonAddTableXML.Size = new System.Drawing.Size(116, 49);
            this.buttonAddTableXML.TabIndex = 155;
            this.buttonAddTableXML.Text = "Adding table from XML schema";
            this.buttonAddTableXML.UseVisualStyleBackColor = true;
            this.buttonAddTableXML.Visible = false;
            this.buttonAddTableXML.Click += new System.EventHandler(this.buttonAddTableXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 421);
            this.Controls.Add(this.buttonAddTableXML);
            this.Controls.Add(this.buttonSchemaToXML);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonXMLtoSQL);
            this.Controls.Add(this.buttonSQLtoXML);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboDatabaseList);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDataSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDatabase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(854, 457);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboDatabaseList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSQLtoXML;
        private System.Windows.Forms.Button buttonXMLtoSQL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioXML;
        private System.Windows.Forms.RadioButton radioSQL;
        private System.Windows.Forms.Button buttonSchemaToXML;
        private System.Windows.Forms.Button buttonAddTableXML;
    }
}

