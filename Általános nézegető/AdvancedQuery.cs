using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Általános_nézegető
{
    public partial class AdvancedQuery : Form
    {
        public static string query = "";
        public AdvancedQuery()
        {
            InitializeComponent();
        }

        private void useBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "USE ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "SELECT ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "* ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void fromBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += " FROM "+Nezegeto.tableName+" ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void whereBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "WHERE ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void smallerBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "< ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void largerBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "> ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "= ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void notEqualbtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "<> ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            
            Value.advancedQuery = queryBoxTxt.Text;
            this.Close();
        }

        private void AdvancedQuery_Load(object sender, EventArgs e)
        {
           // Nezegeto nezegeto = new Nezegeto();
            foreach (var a in Nezegeto.table)
            {
                tableList.Items.Add(a);
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text += "ORDER BY ";
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void tableList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            queryBoxTxt.Text += (tableList.SelectedItem).ToString();
            queryBoxTxt.SelectionStart = queryBoxTxt.Text.Length;
            queryBoxTxt.Focus();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            queryBoxTxt.Text = "";
            queryBoxTxt.Focus();
        }
    }
}
