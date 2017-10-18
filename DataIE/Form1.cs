using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Xml.Schema;


namespace DataIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            DBConnection connection = DBConnection.Instance();
            try
            {                
                connection.DatabaseName = "information_schema";
                connection.Port = textBoxPort.Text;
                connection.Server = textBoxDataSource.Text;
                connection.Password = textBoxPassword.Text;
                connection.Login = textBoxLogin.Text;
                if (connection.IsConnect())
                {
                    string sql = "SELECT schema_name from information_schema.SCHEMATA";
                    MySqlCommand cmd = new MySqlCommand(sql, connection.Connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        textBoxDatabase.AutoCompleteCustomSource.Add(rdr.GetString(0));
                    }
                    rdr.Close();
                    connection.Close();
                    textBoxDatabase.Update();
                    
                    MessageBox.Show("Connection to server was successful");
                }               
            }
            catch (MySqlException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message + ex.Number);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnection connection = DBConnection.Instance();
            try
            {
                comboDatabaseList.Items.Clear();
                connection.DatabaseName = textBoxDatabase.Text;
                connection.Port = textBoxPort.Text;
                connection.Server = textBoxDataSource.Text;
                connection.Password = textBoxPassword.Text;
                connection.Login = textBoxLogin.Text;
                if (connection.IsConnect())
                {
                    string sql = string.Format("SELECT table_name FROM information_schema.tables where table_schema='{0}'", textBoxDatabase.Text);
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection.Connection))
                    {
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            comboDatabaseList.Items.Add(rdr.GetString(0));
                        }
                        rdr.Close();
                    }
                    connection.Close();
                    comboDatabaseList.Visible = true;
                    comboDatabaseList.Update();
                    buttonShowData.Visible = true;
                    buttonShowData.Update();
                    buttonSQLtoXML.Visible = true;
                    buttonSQLtoXML.Update();
                    buttonXMLtoSQL.Visible = true;
                    buttonXMLtoSQL.Update();
                    buttonAddTableXML.Visible = true;
                    buttonAddTableXML.Update();
                    buttonSchemaToXML.Visible = true;
                    buttonSchemaToXML.Update();
                    groupBox1.Visible = true;
                    groupBox1.Update();                    
                }
            }
            catch (MySqlException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message + ex.Number);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (radioSQL.Checked)
            {
                DBConnection connection = DBConnection.Instance();
                try
                {
                    connection.DatabaseName = textBoxDatabase.Text;
                    connection.Port = textBoxPort.Text;
                    connection.Server = textBoxDataSource.Text;
                    connection.Password = textBoxPassword.Text;
                    connection.Login = textBoxLogin.Text;
                    if (connection.IsConnect())
                    {
                        string sql = string.Format("SELECT * FROM {0}", comboDatabaseList.SelectedItem);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection.Connection))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                            connection.Close();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message + ex.Number);
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "XML|*.xml|XaML|*.xaml|All|*.*", ValidateNames = true, Multiselect = false })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                                DataSet ds = new DataSet();
                                ds.ReadXml(xmlFile);
                                dataGridView1.DataSource = ds.Tables[0];
                                xmlFile.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error with file", ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonSQLtoXML_Click(object sender, EventArgs e)
        {
            try {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "XML|*.xml|XaML|*.xaml|All|*.*", ValidateNames = true})
                {
                    try
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            DBConnection connection = DBConnection.Instance();
                            connection.DatabaseName = textBoxDatabase.Text;
                            connection.Port = textBoxPort.Text;
                            connection.Server = textBoxDataSource.Text;
                            connection.Password = textBoxPassword.Text;
                            connection.Login = textBoxLogin.Text;
                            if (connection.IsConnect())
                            {
                                string sql = string.Format("SELECT * FROM {0}", comboDatabaseList.SelectedItem);
                                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection.Connection))
                                {
                                    //DataSet ds = new DataSet();
                                    //adapter.Fill(ds);
                                    //ds.DataSetName = comboDatabaseList.SelectedItem.ToString();
                                    DataTable ds = new DataTable();
                                    adapter.Fill(ds);                                    
                                    ds.TableName = comboDatabaseList.SelectedItem.ToString();
                                    XmlWriterSettings settings = new XmlWriterSettings();
                                    settings.Indent = true;
                                    
                                    XmlWriter xmlFile = XmlWriter.Create(sfd.FileName, settings);
                                    ds.WriteXml(xmlFile, XmlWriteMode.WriteSchema);
                                    xmlFile.Close();
                                    connection.Close();                                       
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXMLtoSQL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "XML|*.xml|XaML|*.xaml|All|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DBConnection connection = DBConnection.Instance();
                        connection.DatabaseName = textBoxDatabase.Text;
                        connection.Port = textBoxPort.Text;
                        connection.Server = textBoxDataSource.Text;
                        connection.Password = textBoxPassword.Text;
                        connection.Login = textBoxLogin.Text;
                        string tableName = comboDatabaseList.SelectedItem.ToString();
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.ValidationFlags = XmlSchemaValidationFlags.ProcessInlineSchema;
                        XmlReader xmlFile = XmlReader.Create(ofd.FileName, settings);
                        DataTable dt = new DataTable();
                        dt.ReadXml(xmlFile);
                        xmlFile.Close();
                        string sql = string.Format("Insert into {0} (", tableName);
                        int i = 0;
                        int[] colQout = new int [dt.Columns.Count];
                        foreach (DataColumn col in dt.Columns)
                        {
                            //sql += string.Format("'{0}', ", col.ColumnName);
                            colQout[i] = NeedQuotation.IsQuotation(col.DataType);
                            if (colQout[i] == 2)
                            {
                                if (connection.IsConnect())
                                {
                                    string comm = string.Format("SHOW COLUMNS FROM {0}.{1}", connection.DatabaseName, tableName);
                                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comm, connection.Connection))
                                    {
                                        DataTable answer = new DataTable();
                                        adapter.Fill(answer);
                                        DataRow rw = answer.Rows[i];
                                        switch(rw["Type"].ToString())
                                        {
                                            case "datetime":
                                                colQout[i] = 4;
                                                break;
                                            case "time":
                                                colQout[i] = 3;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                            i++;
                        }
                        sql = sql.Substring(0, sql.Length - 2) + " Values ";
                        
                        foreach (DataRow row in dt.Rows)
                        {
                            sql += "(";
                            int j = 0;
                            foreach(var item in row.ItemArray)
                            {
                                string need = item.ToString();
                                switch (colQout[j])
                                {
                                    case 0:
                                        sql += need + ", ";
                                        break;
                                    case 1:
                                        sql += string.Format("'{0}', ", need);
                                        break;
                                    case 2:
                                        sql += string.Format("'{0}', ", DateService.Service(need));
                                        break;
                                    case 3:
                                        sql += string.Format("'{0}', ", DateService.Service(need,2));
                                        break;
                                    case 4:
                                        sql += string.Format("'{0}', ", DateService.Service(need,3));
                                        break;
                                }            
                                j++;
                            }
                            sql = sql.Substring(0, sql.Length - 2) + "),";
                        }
                        sql = sql.Substring(0, sql.Length - 1) + ";";
                        //MessageBox.Show(sql);
                        
                        if (connection.IsConnect())
                        {
                            using (MySqlCommand command = new MySqlCommand(sql, connection.Connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }                    
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonSchemaToXML_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "XML|*.xml|XaML|*.xaml|All|*.*", ValidateNames = true })
                {
                    try
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            DBConnection connection = DBConnection.Instance();
                            connection.DatabaseName = textBoxDatabase.Text;
                            connection.Port = textBoxPort.Text;
                            connection.Server = textBoxDataSource.Text;
                            connection.Password = textBoxPassword.Text;
                            connection.Login = textBoxLogin.Text;
                            if (connection.IsConnect())                                
                            {
                                string[] restrictions = new string[4];
                                restrictions[3] = comboDatabaseList.SelectedItem.ToString();
                                DataTable table = connection.Connection.GetSchema("Columns");
                                XmlWriterSettings settings = new XmlWriterSettings();
                                settings.Indent = true;
                                XmlWriter xmlFile = XmlWriter.Create(sfd.FileName, settings);
                                table.WriteXml(xmlFile);
                                xmlFile.Close();
                                connection.Close();
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddTableXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "XML|*.xml|XaML|*.xaml|All|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                        DataSet ds = new DataSet();
                        ds.ReadXmlSchema(xmlFile);
                        xmlFile.Close();
                        NewTableSQL nTSQL = new NewTableSQL(ds);
                        DBConnection connection = DBConnection.Instance();
                        connection.DatabaseName = textBoxDatabase.Text;
                        connection.Port = textBoxPort.Text;
                        connection.Server = textBoxDataSource.Text;
                        connection.Password = textBoxPassword.Text;
                        connection.Login = textBoxLogin.Text;
                        //MessageBox.Show(nTSQL.CreateTable());
                        if (connection.IsConnect())
                        {
                            using (MySqlCommand command = new MySqlCommand(nTSQL.CreateTable(), connection.Connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}