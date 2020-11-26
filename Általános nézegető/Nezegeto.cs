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

namespace Általános_nézegető
{
    //Icons made by <a href="https://www.flaticon.com/authors/prosymbols" title="Prosymbols">Prosymbols</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
    public partial class Nezegeto : Form
    {
        private List<string> connectionString = new List<string>();
        private List<string> nameList = new List<string>();
        private List<string> selectedList = new List<string>();
        private List<string> columnList = new List<string>();
        private List<string> table = new List<string>();
        private List<string> view = new List<string>();
        private string checkedItems = "";
        private string connString = "";



        public Nezegeto()
        {
            
            InitializeComponent();
            LoadXml();
            LoadList();
            DisableAll();
            
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
            DisableAll();
            columnList.Clear();
            selectedList.Clear();
            checkedListBox1.Items.Clear();
            orderList.Items.Clear();
            tableList.Items.Clear();
            datumList.Items.Clear();
            viewBox.Items.Clear();
            viewBox.Text = "";
            // MessageBox.Show(connectionString[serverList.SelectedIndex]);
            //LoadTableList(connectionString[serverList.SelectedIndex], "SELECT name FROM sys.tables ORDER BY name");
            LoadDbList(connectionString[serverList.SelectedIndex], "SELECT name FROM sys.databases ORDER BY name");
            tableList.Text = "";
        }
        private void LoadDbList(string connection, string query)
        {
            dataGrid.DataSource = null;
            dbLoad.Text = "";
            dbLoad.Items.Clear();
            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                dbLoad.Items.Add(i["name"].ToString());
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
            connString = connectionString[serverList.SelectedIndex].Substring(0, connectionString[serverList.SelectedIndex].IndexOf(';')) + ";Initial Catalog = " + dbLoad.Text + connectionString[serverList.SelectedIndex].Substring(connectionString[serverList.SelectedIndex].IndexOf(';'));
            // MessageBox.Show(connString);
            LoadTableList(connString, "SELECT name FROM sys.tables ORDER BY name");
            LoadViewList(connString, "SELECT name FROM sys.views ORDER BY name");
        }
        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExcelBtn.Enabled = true;
            checkedListBox1.Items.Clear();
            orderList.Items.Clear();
            columnList.Clear(); //2
            datumList.Items.Clear();
            checkedListBox1.Enabled = true;
            selectColumn.Enabled = true;
            checkedListBox1.Enabled = true;
            orderList.Items.Clear();
            orderList.Enabled = false;
            viewBox.Items.Clear();
            viewBox.Enabled = false;
            RefreshGrid(connString, "SELECT * FROM " + tableList.Text);
            ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + tableList.Text + "'");
            ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableList.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
           
        }
        private void RefreshGrid(string connection, string query)
        {
            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            dataGrid.DataSource = dt;
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
                   // table.Add(i["name"].ToString());
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
            RefreshGrid(connString, /*"SELECT * FROM " + tableList.Text*/BuildQuery());
        }
        private void ShowColumns(string connection, string query)
        {

            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                checkedListBox1.Items.Add(i["COLUMN_NAME"].ToString());
                orderList.Items.Add(i["COLUMN_NAME"].ToString());
                columnList.Add(i["COLUMN_NAME"].ToString());   // ide írtam bele
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
            fromDate.Enabled = true;
            toDate.Enabled = true;
            setDayCheck.Checked = false;
            setDayCheck.Enabled = true;
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
            RefreshGrid(connString, "SELECT * FROM " + viewBox.Text);
            ShowColumns(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='" + viewBox.Text + "'");
            ShowDate(connString, "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + viewBox.Text + "' AND (DATA_TYPE = 'date' OR DATA_TYPE = 'datetime')");
        }
    }
}
