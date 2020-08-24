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
            this.serverList.Size = new System.Drawing.Size(221, 97);
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
            this.dataGrid.Location = new System.Drawing.Point(12, 301);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1021, 394);
            this.dataGrid.TabIndex = 3;
            // 
            // Nezegeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 707);
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
    }
}

