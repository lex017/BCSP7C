namespace BCSP7C
{
    partial class frmProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConditionCheck = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtproductID = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtSeacrh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConditionCheck);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtproductID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ຈັດການຂໍ້ມູນສິນຄ້າ";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(799, 142);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(304, 40);
            this.cbCategory.TabIndex = 12;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(238, 137);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(342, 40);
            this.cbUnit.TabIndex = 12;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(668, 258);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 53);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "ອອກ";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(525, 258);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(118, 53);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "ລົບອອກ";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(381, 258);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(118, 53);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "ແກ້ໄຂ";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(235, 258);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(118, 53);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "ບັນທຶກ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "ເງືອນໄຂສັ່ງຊື້ສິນຄ້າ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "ປະເພດສິນຄ້າ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "ຫົວໜ່ວຍ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(699, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "ຈຳນວນ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "ລາຄາ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "ຊື້ສິນຄ້າ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "ລະຫັດສິນຄ້າ";
            // 
            // txtConditionCheck
            // 
            this.txtConditionCheck.Location = new System.Drawing.Point(238, 186);
            this.txtConditionCheck.Multiline = true;
            this.txtConditionCheck.Name = "txtConditionCheck";
            this.txtConditionCheck.Size = new System.Drawing.Size(342, 41);
            this.txtConditionCheck.TabIndex = 4;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(799, 89);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(304, 41);
            this.txtQty.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(799, 41);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(458, 42);
            this.txtProductName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(238, 89);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(342, 41);
            this.txtPrice.TabIndex = 4;
            // 
            // txtproductID
            // 
            this.txtproductID.Location = new System.Drawing.Point(238, 41);
            this.txtproductID.Multiline = true;
            this.txtproductID.Name = "txtproductID";
            this.txtproductID.Size = new System.Drawing.Size(342, 42);
            this.txtproductID.TabIndex = 5;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 417);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1279, 296);
            this.DGV.TabIndex = 12;
            // 
            // txtSeacrh
            // 
            this.txtSeacrh.Location = new System.Drawing.Point(107, 360);
            this.txtSeacrh.Multiline = true;
            this.txtSeacrh.Name = "txtSeacrh";
            this.txtSeacrh.Size = new System.Drawing.Size(666, 42);
            this.txtSeacrh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "ຄົ້ນຫາ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(882, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "ຈຳນວນລາຍການສິນຄ້າທັງໝົດ";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(1140, 370);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(36, 32);
            this.lbCount.TabIndex = 6;
            this.lbCount.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1182, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "ລາຍການ";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 737);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSeacrh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtproductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConditionCheck;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtSeacrh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label11;
    }
}