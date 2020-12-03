namespace Általános_nézegető
{
    partial class AdvancedQuery
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
            this.queryBoxTxt = new System.Windows.Forms.RichTextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.whereBtn = new System.Windows.Forms.Button();
            this.fromBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.useBtn = new System.Windows.Forms.Button();
            this.smallerBtn = new System.Windows.Forms.Button();
            this.largerBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.notEqualbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ListBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryBoxTxt
            // 
            this.queryBoxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBoxTxt.Location = new System.Drawing.Point(12, 12);
            this.queryBoxTxt.Name = "queryBoxTxt";
            this.queryBoxTxt.Size = new System.Drawing.Size(327, 402);
            this.queryBoxTxt.TabIndex = 0;
            this.queryBoxTxt.Text = "";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(345, 73);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(98, 34);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // whereBtn
            // 
            this.whereBtn.Location = new System.Drawing.Point(345, 298);
            this.whereBtn.Name = "whereBtn";
            this.whereBtn.Size = new System.Drawing.Size(98, 35);
            this.whereBtn.TabIndex = 3;
            this.whereBtn.Text = "WHERE";
            this.whereBtn.UseVisualStyleBackColor = true;
            this.whereBtn.Click += new System.EventHandler(this.whereBtn_Click);
            // 
            // fromBtn
            // 
            this.fromBtn.Location = new System.Drawing.Point(345, 186);
            this.fromBtn.Name = "fromBtn";
            this.fromBtn.Size = new System.Drawing.Size(98, 34);
            this.fromBtn.TabIndex = 4;
            this.fromBtn.Text = "FROM";
            this.fromBtn.UseVisualStyleBackColor = true;
            this.fromBtn.Click += new System.EventHandler(this.fromBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.Location = new System.Drawing.Point(345, 132);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(98, 34);
            this.allBtn.TabIndex = 5;
            this.allBtn.Text = "*";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // useBtn
            // 
            this.useBtn.Location = new System.Drawing.Point(345, 13);
            this.useBtn.Name = "useBtn";
            this.useBtn.Size = new System.Drawing.Size(98, 34);
            this.useBtn.TabIndex = 6;
            this.useBtn.Text = "USE";
            this.useBtn.UseVisualStyleBackColor = true;
            this.useBtn.Click += new System.EventHandler(this.useBtn_Click);
            // 
            // smallerBtn
            // 
            this.smallerBtn.Location = new System.Drawing.Point(480, 13);
            this.smallerBtn.Name = "smallerBtn";
            this.smallerBtn.Size = new System.Drawing.Size(94, 34);
            this.smallerBtn.TabIndex = 7;
            this.smallerBtn.Text = "<";
            this.smallerBtn.UseVisualStyleBackColor = true;
            this.smallerBtn.Click += new System.EventHandler(this.smallerBtn_Click);
            // 
            // largerBtn
            // 
            this.largerBtn.Location = new System.Drawing.Point(480, 73);
            this.largerBtn.Name = "largerBtn";
            this.largerBtn.Size = new System.Drawing.Size(94, 34);
            this.largerBtn.TabIndex = 8;
            this.largerBtn.Text = ">";
            this.largerBtn.UseVisualStyleBackColor = true;
            this.largerBtn.Click += new System.EventHandler(this.largerBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(480, 132);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(94, 34);
            this.equalBtn.TabIndex = 9;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // notEqualbtn
            // 
            this.notEqualbtn.Location = new System.Drawing.Point(480, 186);
            this.notEqualbtn.Name = "notEqualbtn";
            this.notEqualbtn.Size = new System.Drawing.Size(94, 34);
            this.notEqualbtn.TabIndex = 10;
            this.notEqualbtn.Text = "<>";
            this.notEqualbtn.UseVisualStyleBackColor = true;
            this.notEqualbtn.Click += new System.EventHandler(this.notEqualbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adattáblák";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(345, 362);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(233, 52);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // tableList
            // 
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(590, 45);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(152, 368);
            this.tableList.TabIndex = 16;
            this.tableList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tableList_MouseDoubleClick);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(345, 239);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(98, 34);
            this.orderBtn.TabIndex = 17;
            this.orderBtn.Text = "ORDER BY";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(480, 298);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 35);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "TÖRÖL";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // AdvancedQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 425);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notEqualbtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.largerBtn);
            this.Controls.Add(this.smallerBtn);
            this.Controls.Add(this.useBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.fromBtn);
            this.Controls.Add(this.whereBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.queryBoxTxt);
            this.Name = "AdvancedQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedQuery";
            this.Load += new System.EventHandler(this.AdvancedQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox queryBoxTxt;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button whereBtn;
        private System.Windows.Forms.Button fromBtn;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button useBtn;
        private System.Windows.Forms.Button smallerBtn;
        private System.Windows.Forms.Button largerBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button notEqualbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ListBox tableList;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}