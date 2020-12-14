using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using static Általános_nézegető.Value;
namespace Általános_nézegető
{
    //Icons made by <a href="https://www.flaticon.com/authors/prosymbols" title="Prosymbols">Prosymbols</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
    public partial class Nezegeto : Form
    {
        private List<string> connectionString = new List<string>();
        private List<string> nameList = new List<string>();
        private List<string> selectedList = new List<string>();
        private List<string> columnList = new List<string>();
        public static List<string> table = new List<string>();
        private List<string> view = new List<string>();
        private List<string> readable = new List<string>();
        private List<string> readable1 = new List<string>();
        public static string tableName; 
        private string checkedItems = "";
        private string connString = "";
        public string adQuery = AdvancedQuery.query;
        public bool isAdvancedChecked = AdvancedQuery.asd;
        public static CheckBox cb = new CheckBox();
        public static Button btn = new Button();
        private bool isClicked = false;
        

        public Nezegeto()
        {
            
            InitializeComponent();
            LoadXml();
            LoadList();
            DisableAll();
            cb = advancedBox;
            btn = updateBtn;
            
        }
        private void LoadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("AppCon.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string connString = node.Attributes[0].Value;
                string name = node.Attributes[1].Value;
                connectionString.Add(connString);
                nameList.Add(name);

            }
        }
        private void LoadList()
        {

            foreach (var i in nameList)
            {
                serverList.Items.Add(i);
            }
        }
        private SqlDataAdapter LoadGridView(string conString, string sqlQuery)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlConnection.Close();
            return sqlDataAdapter;
        }
        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            try
            {
                DisableAll();
                columnList.Clear();
                selectedList.Clear();
                checkedListBox1.Items.Clear();
                orderList.Items.Clear();
                tableList.Items.Clear();
                datumList.Items.Clear();
                viewBox.Items.Clear();
                viewBox.Text = "";
                string user = getBetween(connectionString[serverList.SelectedIndex], "ID=", ";");
                try
                {
                    t.Start();
                    LoadDbList(connectionString[serverList.SelectedIndex], "DECLARE @DB_Users TABLE (DBName sysname, UserName sysname, LoginType sysname, AssociatedRole varchar(max), create_date datetime, modify_date datetime) INSERT @DB_Users EXEC sp_MSforeachdb 'use [?] SELECT ''?'' AS DB_Name,case prin.name when ''dbo'' then prin.name + '' (''+ (select SUSER_SNAME(owner_sid) from master.sys.databases where name =''?'') + '')''else prin.name end AS UserName,prin.type_desc AS LoginType,isnull(USER_NAME(mem.role_principal_id),'''') AS AssociatedRole, create_date, modify_date FROM sys.database_principals prin LEFT OUTER JOIN sys.database_role_members mem ON prin.principal_id=mem.member_principal_id WHERE prin.sid IS NOT NULL and prin.sid NOT IN (0x00) and prin.is_fixed_role <> 1 AND prin.name NOT LIKE ''##%''' SELECT dbname, username, logintype, create_date, modify_date, STUFF((SELECT ',' + CONVERT(VARCHAR(500), associatedrole) FROM @DB_Users user2 WHERE user1.DBName=user2.DBName AND user1.UserName=user2.UserName FOR XML PATH('')),1,1,'') AS Permissions_user FROM @DB_Users user1 WHERE user1.UserName = N'" + user + "'GROUP BY dbname, username, logintype, create_date, modify_date ORDER BY DBName, username");
                    isClicked = true;
                    t.Abort();
                }
                catch
                {
                    isClicked = false;
                }
                    tableList.Text = "";
            }
            catch
            {
                if(isClicked)
                { 
                    t.Abort();
                }
                // MessageBox.Show(asd.ToString());

            }
            Value.advancedQuery = "";
        }
        private void LoadDbList(string connection, string query)
        {
            dataGrid.DataSource = null;
            dbLoad.Text = "";
            dbLoad.Items.Clear();
            //advancedBox.Enabled = false;
            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                dbLoad.Items.Add(i["dbname"].ToString());                
            }
        }
        private void dbLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewBox.Items.Clear();
            viewBox.Enabled = true;
            // viewBox.SelectedIndex = -1;
            viewBox.Text = "";
            tableList.Enabled = true;
            checkedListBox1.Enabled = false;
            checkedListBox1.Items.Clear();
            orderList.Enabled = false;
            datumList.Enabled = false;
            descOrderCheckBox.Checked = false;
            descOrderCheckBox.Enabled = false;
            fromDate.Enabled = false;
            toDate.Enabled = false;
            setDayCheck.Checked = false;
            setDayCheck.Enabled = false;
            tableList.Items.Clear();
            orderList.Items.Clear();
            selectColumn.Enabled = false;
            ExcelBtn.Enabled = false;
            datumList.Items.Clear();
            connString = connectionString[serverList.SelectedIndex].Substring(0, connectionString[serverList.SelectedIndex].IndexOf(';')) + ";Initial Catalog = " + dbLoad.Text + connectionString[serverList.SelectedIndex].Substring(connectionString[serverList.SelectedIndex].IndexOf(';'));
            advancedBox.Enabled = false;
            advancedBox.Checked = false;
            table.Clear();
            tableName = "";
            // MessageBox.Show(connString);
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            LoadTableList(connString, "SELECT name FROM sys.tables ORDER BY name");
            LoadViewList(connString, "SELECT name FROM sys.views ORDER BY name");
            t.Abort();
            Value.advancedQuery = "";
        }
        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            updateBtn.Enabled = false;
            ExcelBtn.Enabled = true;
            checkedListBox1.Items.Clear();
            orderList.Items.Clear();
            columnList.Clear(); //2
            checkedListBox1.Enabled = true;
            selectColumn.Enabled = true;
            checkedListBox1.Enabled = true;
            orderList.Items.Clear();
            orderList.Enabled = false;
            viewBox.Items.Clear();
            viewBox.Enabled = false;
          //  datumList.SelectedIndex = -1;
            datumList.Items.Clear();
            datumList.Enabled = false;
            setDayCheck.Checked = false;
            setDayCheck.Enabled = false;
            // MessageBox.Show((RowCount(connString,"SELECT sum([rows]) as SOR FROM sys.partitions WHERE object_id = object_id('"+tableList.Text+"')").ToString()));
            if (RowCount(connString, "SELECT sum([rows]) as SOR FROM sys.partitions WHERE object_id = object_id('" + tableList.Text + "')") < 1000)
            {
                RefreshGrid(connString, "SELECT * FROM " + tableList.Text);
                ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + tableList.Text + "'");
                ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableList.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
            }
            else 
            {
                ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + tableList.Text + "'");
                ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableList.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
                string query = "SELECT TOP (1000) ";
                foreach (var i in columnList)
                {
                    query += i + ",";
                }
                query = query.Substring(0, query.Length - 1);
                RefreshGrid(connString, query + " FROM " + tableList.Text);

            }
            t.Abort();
            advancedBox.Checked = Value.isChecked;
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
            tableName = tableList.Text;
            Value.advancedQuery = "";

        }
        private void RefreshGrid(string connection, string query)
        {
            
            if (advancedBox.Checked == false)
            {
                DataTable dt = new DataTable();
                try
                {
                    LoadGridView(connection, query).Fill(dt);
                    dataGrid.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Rossz lekérdezést írtál", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    updateBtn.Enabled = false;
                }
            }
            else
            {
                //MessageBox.Show(Value.advancedQuery);
                DataTable dt = new DataTable();
                try
                {
                    LoadGridView(connection, Value.advancedQuery).Fill(dt);
                    dataGrid.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Rossz lekérdezést írtál","Figyelem!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    advancedBox.Checked = false;
                }
            }

        }
        private void LoadTableList(string connection, string query)
        {
            dataGrid.DataSource = null;
            tableList.Text = "";
            tableList.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                LoadGridView(connString, query).Fill(dt);
                foreach (DataRow i in dt.Rows)
                {
                    //table.Add(i["name"]+"\n".ToString());
                    tableList.Items.Add(i["name"].ToString());
                }
                //foreach (var a in table)
                //{
                //    tableList.Items.Add(a);
                //}
            }
            catch 
            {
                MessageBox.Show("Nincs jogosultságod megnyitni a táblát!");
            }


        }
        private void LoadViewList(string connection, string query)
        {
            dataGrid.DataSource = null;
            DataTable dt = new DataTable();
            try
            {
                LoadGridView(connString, query).Fill(dt);
                foreach (DataRow i in dt.Rows)
                {
                 
                    viewBox.Items.Add(i["name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Nincs jogosultságod megnyitni a táblát!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            try
            {
                t.Start();
                RefreshGrid(connString, /*"SELECT * FROM " + tableList.Text*/BuildQuery());
                t.Abort();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
            
        }
        private void ShowColumns(string connection, string query)
        {

            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                checkedListBox1.Items.Add(i["COLUMN_NAME"].ToString());
                orderList.Items.Add(i["COLUMN_NAME"].ToString());
                columnList.Add(i["COLUMN_NAME"].ToString());
                table.Add(i["COLUMN_NAME"].ToString());
                //tableName = tableList.Text;
                advancedBox.Enabled = true;
                // ide írtam bele
            }
        }
        private void ShowDate(string connection, string query)
        {
            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                datumList.Items.Add(i["COLUMN_NAME"].ToString());
            }
        }
        private long RowCount(string connection, string query)
        {
            string a = "";
            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                a = i["SOR"].ToString();
            }
            long b = Int32.Parse(a);

            return b;
        }
        private string GetCheckedItems() 
        {
            checkedItems = "";
            if (CheckColumn() == true) 
            { 
            
            for (int i = 0; i < checkedListBox1.Items.Count; i++) 
            {
                if (checkedListBox1.GetItemChecked(i)) 
                {
                    checkedItems += checkedListBox1.Items[i].ToString()+",";
                    selectedList.Add(checkedListBox1.Items[i].ToString());
                }
            }
            checkedItems = checkedItems.Substring(0, checkedItems.Length - 1);
                return checkedItems;
            }
        return "*";
        }
        private void selectColumn_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();
            if (GetCheckedItems() == "*")
            {
               LoadOrderList(columnList);
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else 
            { 
            LoadOrderList(columnList); //LoadOrderList(selectedList);
                
            }
            orderList.SelectedIndex = 0;
            orderList.Enabled = true;
            descOrderCheckBox.Enabled = true;
            updateBtn.Enabled = true;
            datumList.Enabled = true;
           // fromDate.Enabled = true;
           // toDate.Enabled = true;
            setDayCheck.Checked = false;
           // setDayCheck.Enabled = true;
        }
        private void LoadOrderList(List<string> lista) 
        {
            orderList.Items.Clear();

            foreach (var i in lista) 
            {
                orderList.Items.Add(i);  
            }
            
        }
        private bool CheckColumn() 
        {
            int sum = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    sum++;
                }
                if (sum > 0) 
                {
                    return true;
                }
            }
            return false;
        }
        private string BuildQuery()
        {
            string query = "SELECT ";
            if (checkedItems == "")
            {
                query += "*";
            }
            else
            {
                query += checkedItems;
            }
            if (tableList.SelectedIndex != -1)
            {
                query += " FROM " + tableList.Text;
            }
            else 
            {
                query += " FROM " + viewBox.Text;
            }

            if (datumList.SelectedIndex != -1)
            {
                string datum = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + fromDate.Value.Day.ToString();
                string datum2 = toDate.Value.Year.ToString() + "-" + toDate.Value.Month.ToString() + "-" + (toDate.Value.Day + 1).ToString();

                DateTime parseDate;
                DateTime parseDate2;

                if (setDayCheck.Checked == true)
                {
                    // MessageBox.Show("Bejöttem");
                    //

                    datum2 = "";
                    if ((fromDate.Value.Month == 1 || fromDate.Value.Month == 3 || fromDate.Value.Month == 5 || fromDate.Value.Month == 7 || fromDate.Value.Month == 8 ||
                        fromDate.Value.Month == 10) && fromDate.Value.Day == 31)
                    {
                        datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-" + "1";
                    }
                    else if (fromDate.Value.Month == 12 && fromDate.Value.Day == 31)
                    {
                        datum2 = (fromDate.Value.Year + 1).ToString() + "-" + "1" + "-" + "1";
                    }
                    else if ((fromDate.Value.Month == 4 || fromDate.Value.Month == 6 || fromDate.Value.Month == 9 || fromDate.Value.Month == 11)
                        && fromDate.Value.Day == 30)
                    {
                        datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                    }
                    else if (DateTime.IsLeapYear(fromDate.Value.Year) && fromDate.Value.Month == 2 && fromDate.Value.Day == 29)
                    {
                        datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                    }
                    else if (!DateTime.IsLeapYear(fromDate.Value.Year) && fromDate.Value.Month == 2 && fromDate.Value.Day == 28)
                    {
                        datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                    }
                    else
                    {
                        datum2 = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + (fromDate.Value.Day + 1).ToString();
                    }

                    // string datum2 = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + (fromDate.Value.Day+1).ToString();
                    //this.hal2EllenallasTempTableAdapter1.Fill(this.ellenallasMeresDataSet1.Hal2EllenallasTemp);
                    parseDate = DateTime.Parse(datum);
                    parseDate2 = DateTime.Parse(datum2);
                    // MessageBox.Show($"{parseDate2 }");
                    // this.hal2EllenallasTempTableAdapter1.FillBy(this.ellenallasMeresDataSet1.Hal2EllenallasTemp, parseDate, parseDate2); régi
                    query += " WHERE " + datumList.SelectedItem.ToString() + " BETWEEN " + "'"+datum+"'"  + " AND " + "'"+datum2+"'";
                }
                else 
                {
                    parseDate = DateTime.Parse(datum);
                    parseDate2 = DateTime.Parse(datum2);

                    query += " WHERE " + datumList.SelectedItem.ToString() + " BETWEEN " + "'" + datum + "'" + " AND " + "'" + datum2 + "'";
                }

            }
            query += " ORDER BY " + orderList.SelectedItem;
            if (descOrderCheckBox.Checked) 
            {
                query += " DESC";
            }
            return query;
        }
        private void DisableAll() 
        {
            checkedListBox1.Enabled = false;
            selectColumn.Enabled = false;
            orderList.Enabled = false;
            descOrderCheckBox.Enabled = false;
            updateBtn.Enabled = false;
            tableList.Enabled = false;
            viewBox.Enabled = false;
            setDayCheck.Checked = false;
            setDayCheck.Enabled = false;
            ExcelBtn.Enabled = false;
            advancedBox.Enabled = false;
            advancedBox.Checked = false;
            fromDate.Enabled = false;
            toDate.Enabled = false;
        }
        private void CopyToClipBoard(DataGridView dataGrid)
        {
            dataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGrid.MultiSelect = true;
            dataGrid.SelectAll();

            //dataGridView1.SelectAll();
            DataObject dataObject = dataGrid.GetClipboardContent();
            if (dataObject != null)
                Clipboard.SetDataObject(dataObject);
        }
        private void GenerateExcel()
        {
            Microsoft.Office.Interop.Excel.Application xexcel;
            Microsoft.Office.Interop.Excel.Workbook xWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xexcel = new Microsoft.Office.Interop.Excel.Application();
            xexcel.Visible = true;
            xWorkBook = xexcel.Workbooks.Add(misValue);
            xWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xWorkSheet.Cells[1, 1];
            CR.Select();
            xWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            xWorkBook.Close();
            xexcel.Quit();

        }
        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            CopyToClipBoard(dataGrid);
            GenerateExcel();
        }
        private void viewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            checkedListBox1.Items.Clear();
            orderList.Items.Clear();
            columnList.Clear(); //2
            datumList.Items.Clear();
            checkedListBox1.Enabled = true;
            selectColumn.Enabled = true;
            checkedListBox1.Enabled = true;
            orderList.Items.Clear();
            orderList.Enabled = false;
            tableList.Items.Clear();
            tableList.Enabled = false;
            ExcelBtn.Enabled = true;
            descOrderCheckBox.Checked = false;
            descOrderCheckBox.Enabled = false;
            datumList.Items.Clear();
            datumList.Enabled = false;
            fromDate.Enabled = false;
            toDate.Enabled = false;
            setDayCheck.Checked = false;
            setDayCheck.Enabled = false;
            updateBtn.Enabled = false;
            //RefreshGrid(connString, "SELECT * FROM " + viewBox.Text);
            //ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + viewBox.Text + "'");
            //ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + viewBox.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");

            if (RowCount(connString, /*"SELECT sum([rows]) as SOR FROM sys.partitions WHERE object_id = object_id('" + viewBox.Text + "')"*/ "SELECT count(*) as SOR FROM "+viewBox.Text) < 1000)
            {
                RefreshGrid(connString, "SELECT * FROM " + viewBox.Text);
                ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + viewBox.Text + "'");
                ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + viewBox.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
            }
            else
            {
                ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + viewBox.Text + "'");
                ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + viewBox.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
                string query = "SELECT TOP (1000) ";
                foreach (var i in columnList)
                {
                    query += i + ",";
                }
                query = query.Substring(0, query.Length - 1);
                RefreshGrid(connString, query + " FROM " + viewBox.Text);

            }

            t.Abort();
            advancedBox.Checked = Value.isChecked;
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
            tableName = viewBox.Text;
        }
        private static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
        private void StartForm()
        {
            Application.Run(new LoadScreen());
        }
        private void setDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (setDayCheck.Checked == true)
            {
                fromDate.Value = DateTime.Now;
                toDate.Value = DateTime.Now;

                fromDate.Enabled = false;
                toDate.Enabled = false;
            }
            else
            {
                fromDate.Value = DateTime.Now;
                toDate.Value = DateTime.Now;

                fromDate.Enabled = true;
                toDate.Enabled = true;
            }

        }
        private void advancedBox_Click(object sender, EventArgs e)
        {
            if (advancedBox.Checked == false)
            {
                AdvancedQuery advancedQuery = new AdvancedQuery();
                advancedQuery.Show();
                //updateBtn.Enabled = true;
                advancedBox.Checked = true;
            }
            else 
            {
                AdvancedQuery advancedQuery = new AdvancedQuery();
                advancedQuery.Show();
                //updateBtn.Enabled = true;
                advancedBox.Checked = true;
            }
        }
        private void datumList_Click(object sender, EventArgs e)
        {
            fromDate.Enabled = true;
            toDate.Enabled = true;
            setDayCheck.Enabled = true;
        }
        private void datumList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            datumList.SelectedIndex = -1;
            fromDate.Enabled = false;
            toDate.Enabled = false;
            setDayCheck.Enabled = false;
        }
        private void orderList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            orderList.SelectedIndex = -1;
        }
    }
}
