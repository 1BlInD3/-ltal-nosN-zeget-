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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.datumList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.setDayCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.viewBox = new System.Windows.Forms.ComboBox();
            this.advancedBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serverList
            // 
            this.serverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverList.FormattingEnabled = true;
            this.serverList.ItemHeight = 31;
            this.serverList.Location = new System.Drawing.Point(12, 42);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(221, 345);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // tableList
            // 
            this.tableList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tableList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(276, 166);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(248, 33);
            this.tableList.TabIndex = 2;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Location = new System.Drawing.Point(12, 488);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1388, 411);
            this.dataGrid.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(12, 423);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(1388, 50);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Frissítés";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(576, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 256);
            this.checkedListBox1.TabIndex = 5;
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 20;
            this.orderList.Location = new System.Drawing.Point(896, 42);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(190, 264);
            this.orderList.TabIndex = 6;
            // 
            // selectColumn
            // 
            this.selectColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectColumn.Location = new System.Drawing.Point(576, 354);
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Size = new System.Drawing.Size(190, 52);
            this.selectColumn.TabIndex = 7;
            this.selectColumn.Text = "Kiválaszt";
            this.selectColumn.UseVisualStyleBackColor = true;
            this.selectColumn.Click += new System.EventHandler(this.selectColumn_Click);
            // 
            // descOrderCheckBox
            // 
            this.descOrderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descOrderCheckBox.AutoSize = true;
            this.descOrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descOrderCheckBox.Location = new System.Drawing.Point(896, 367);
            this.descOrderCheckBox.Name = "descOrderCheckBox";
            this.descOrderCheckBox.Size = new System.Drawing.Size(183, 28);
            this.descOrderCheckBox.TabIndex = 8;
            this.descOrderCheckBox.Text = "Csökkenő sorrend";
            this.descOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // dbLoad
            // 
            this.dbLoad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dbLoad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLoad.FormattingEnabled = true;
            this.dbLoad.Location = new System.Drawing.Point(276, 42);
            this.dbLoad.Name = "dbLoad";
            this.dbLoad.Size = new System.Drawing.Size(248, 33);
            this.dbLoad.TabIndex = 9;
            this.dbLoad.SelectedIndexChanged += new System.EventHandler(this.dbLoad_SelectedIndexChanged);
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelBtn.Location = new System.Drawing.Point(1210, 354);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(190, 52);
            this.ExcelBtn.TabIndex = 10;
            this.ExcelBtn.Text = "Excel generálás";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // datumList
            // 
            this.datumList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datumList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumList.FormattingEnabled = true;
            this.datumList.ItemHeight = 20;
            this.datumList.Location = new System.Drawing.Point(1210, 42);
            this.datumList.Name = "datumList";
            this.datumList.Size = new System.Drawing.Size(190, 124);
            this.datumList.TabIndex = 11;
            this.datumList.SelectedIndexChanged += new System.EventHandler(this.datumList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Szerver lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adatbázisok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adattáblák";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Megjelenítendő sorok";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(892, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rendezés";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1206, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dátum szerint";
            // 
            // fromDate
            // 
            this.fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDate.CustomFormat = "yyyy.MM.dd";
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(1210, 202);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(190, 26);
            this.fromDate.TabIndex = 18;
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.CustomFormat = "yyyy.MM.dd";
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(1210, 256);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(190, 26);
            this.toDate.TabIndex = 19;
            // 
            // setDayCheck
            // 
            this.setDayCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setDayCheck.AutoSize = true;
            this.setDayCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setDayCheck.Location = new System.Drawing.Point(1210, 308);
            this.setDayCheck.Name = "setDayCheck";
            this.setDayCheck.Size = new System.Drawing.Size(120, 28);
            this.setDayCheck.TabIndex = 20;
            this.setDayCheck.Text = "Csak a mai";
            this.setDayCheck.UseVisualStyleBackColor = true;
            this.setDayCheck.CheckedChanged += new System.EventHandler(this.setDayCheck_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "View-k";
            // 
            // viewBox
            // 
            this.viewBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.viewBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.viewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBox.FormattingEnabled = true;
            this.viewBox.Location = new System.Drawing.Point(276, 283);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(248, 33);
            this.viewBox.TabIndex = 22;
            this.viewBox.SelectedIndexChanged += new System.EventHandler(this.viewBox_SelectedIndexChanged);
            // 
            // advancedBox
            // 
            this.advancedBox.AutoSize = true;
            this.advancedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedBox.Location = new System.Drawing.Point(276, 367);
            this.advancedBox.Name = "advancedBox";
            this.advancedBox.Size = new System.Drawing.Size(186, 28);
            this.advancedBox.TabIndex = 23;
            this.advancedBox.Text = "Haladó lekérdezés";
            this.advancedBox.UseVisualStyleBackColor = true;
            this.advancedBox.CheckedChanged += new System.EventHandler(this.advancedBox_CheckedChanged);
            this.advancedBox.Click += new System.EventHandler(this.advancedBox_Click);
            // 
            // Nezegeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1412, 911);
            this.Controls.Add(this.advancedBox);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.setDayCheck);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumList);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.dbLoad);
            this.Controls.Add(this.descOrderCheckBox);
            this.Controls.Add(this.selectColumn);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.serverList);
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
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.ListBox datumList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.CheckBox setDayCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox viewBox;
        private System.Windows.Forms.CheckBox advancedBox;
    }
}

