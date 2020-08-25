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
    public partial class Nezegeto : Form
    {
        private List<string> connectionString = new List<string>();
        private List<string> nameList = new List<string>();

        public Nezegeto()
        {
            InitializeComponent();
            LoadStrings();
            LoadList();
            //checkedListBox1.Visible = false;
        }

        private void LoadStrings()
        {
            //ConnectionString connectionString = new ConnectionString();


            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\balindattila\source\repos\Nézegető\Általános nézegető\AppCon.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string connString = node.Attributes[0].Value;
                string name = node.Attributes[1].Value;
                // connectionString.connectionString.Add(node.Attributes[0].Value);
                // connectionString.name.Add(node.Attributes[1].Value);
                connectionString.Add(connString);
                nameList.Add(name);
                // MessageBox.Show(name);

            }

            /*  XmlDocument doc = new XmlDocument();
              doc.Load(@"C:\Users\balindattila\source\repos\Nézegető\Általános nézegető\AppCon.xml");

              foreach (XmlNode node in doc.DocumentElement) 
              { 
                  serverList.Items.Add(node.Attributes[0].InnerText);

                  foreach (XmlNode child in doc.ChildNodes) 
                  {
                      //connectionStrings.Items.Add(child.InnerText);
                      connectionString.Add(child.InnerText);

                  }
              }*/

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
            LoadTableList(connectionString[serverList.SelectedIndex], "SELECT name FROM sys.tables ORDER BY name");
        }
        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid(connectionString[serverList.SelectedIndex], "SELECT * FROM " + tableList.Text);
            checkedListBox1.Items.Clear();
            ShowColumns(connectionString[serverList.SelectedIndex], "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + tableList.Text + "'");
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
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                tableList.Items.Add(i["name"].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid(connectionString[serverList.SelectedIndex], "SELECT * FROM " + tableList.Text);
            MessageBox.Show(GetCheckedItems());
        }
        private void ShowColumns(string connection, string query)
        {

            DataTable dt = new DataTable();
            LoadGridView(connection, query).Fill(dt);
            foreach (DataRow i in dt.Rows)
            {

                checkedListBox1.Items.Add(i["COLUMN_NAME"].ToString());
            }
        }
        private string GetCheckedItems() 
        {
            string checkedItems = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++) 
            {
                if (checkedListBox1.GetItemChecked(i)) 
                {
                    checkedItems += checkedListBox1.Items[i].ToString()+",";
                }
            }
            return checkedItems.Substring(0,checkedItems.Length-1);
        }
    }
}
