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
            this.serverList = new System.Windows.Forms.ListBox();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.uptadteBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.selectColumn = new System.Windows.Forms.Button();
            this.selectOrder = new System.Windows.Forms.Button();
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
            this.tableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(267, 12);
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
            this.dataGrid.Size = new System.Drawing.Size(1021, 394);
            this.dataGrid.TabIndex = 3;
            // 
            // uptadteBtn
            // 
            this.uptadteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uptadteBtn.Location = new System.Drawing.Point(12, 645);
            this.uptadteBtn.Name = "uptadteBtn";
            this.uptadteBtn.Size = new System.Drawing.Size(1021, 50);
            this.uptadteBtn.TabIndex = 4;
            this.uptadteBtn.Text = "Frissítés";
            this.uptadteBtn.UseVisualStyleBackColor = true;
            this.uptadteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(549, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 169);
            this.checkedListBox1.TabIndex = 5;
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(783, 12);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(196, 173);
            this.orderList.TabIndex = 6;
            // 
            // selectColumn
            // 
            this.selectColumn.Location = new System.Drawing.Point(549, 187);
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Size = new System.Drawing.Size(190, 52);
            this.selectColumn.TabIndex = 7;
            this.selectColumn.Text = "Kiválaszt";
            this.selectColumn.UseVisualStyleBackColor = true;
            this.selectColumn.Click += new System.EventHandler(this.selectColumn_Click);
            // 
            // selectOrder
            // 
            this.selectOrder.Location = new System.Drawing.Point(783, 187);
            this.selectOrder.Name = "selectOrder";
            this.selectOrder.Size = new System.Drawing.Size(196, 52);
            this.selectOrder.TabIndex = 8;
            this.selectOrder.Text = "button1";
            this.selectOrder.UseVisualStyleBackColor = true;
            // 
            // Nezegeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 707);
            this.Controls.Add(this.selectOrder);
            this.Controls.Add(this.selectColumn);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.uptadteBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.serverList);
            this.Name = "Nezegeto";
            this.Text = "Nézegető";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button uptadteBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button selectColumn;
        private System.Windows.Forms.Button selectOrder;
    }
}

