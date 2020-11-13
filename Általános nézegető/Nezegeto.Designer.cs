namespace Általános_nézegető
{
    partial class Nezegeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nezegeto));
            this.serverList = new System.Windows.Forms.ListBox();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.selectColumn = new System.Windows.Forms.Button();
            this.descOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.dbLoad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serverList
            // 
            this.serverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverList.FormattingEnabled = true;
            this.serverList.ItemHeight = 31;
            this.serverList.Location = new System.Drawing.Point(12, 12);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(221, 159);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // tableList
            // 
            this.tableList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tableList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(576, 12);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(248, 33);
            this.tableList.TabIndex = 2;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 245);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1260, 394);
            this.dataGrid.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(12, 645);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(1260, 50);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Frissítés";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(854, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 169);
            this.checkedListBox1.TabIndex = 5;
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(1076, 12);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(196, 173);
            this.orderList.TabIndex = 6;
            // 
            // selectColumn
            // 
            this.selectColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectColumn.Location = new System.Drawing.Point(854, 187);
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Size = new System.Drawing.Size(190, 52);
            this.selectColumn.TabIndex = 7;
            this.selectColumn.Text = "Kiválaszt";
            this.selectColumn.UseVisualStyleBackColor = true;
            this.selectColumn.Click += new System.EventHandler(this.selectColumn_Click);
            // 
            // descOrderCheckBox
            // 
            this.descOrderCheckBox.AutoSize = true;
            this.descOrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descOrderCheckBox.Location = new System.Drawing.Point(1076, 191);
            this.descOrderCheckBox.Name = "descOrderCheckBox";
            this.descOrderCheckBox.Size = new System.Drawing.Size(183, 28);
            this.descOrderCheckBox.TabIndex = 8;
            this.descOrderCheckBox.Text = "Csökkenő sorrend";
            this.descOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // dbLoad
            // 
            this.dbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLoad.FormattingEnabled = true;
            this.dbLoad.Location = new System.Drawing.Point(276, 12);
            this.dbLoad.Name = "dbLoad";
            this.dbLoad.Size = new System.Drawing.Size(248, 33);
            this.dbLoad.TabIndex = 9;
            this.dbLoad.SelectedIndexChanged += new System.EventHandler(this.dbLoad_SelectedIndexChanged);
            // 
            // Nezegeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 707);
            this.Controls.Add(this.dbLoad);
            this.Controls.Add(this.descOrderCheckBox);
            this.Controls.Add(this.selectColumn);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.serverList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nezegeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nézegető";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button selectColumn;
        private System.Windows.Forms.CheckBox descOrderCheckBox;
        private System.Windows.Forms.ComboBox dbLoad;
    }
}

