namespace BCSP7C
{
    partial class FrmUnit
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
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtunitName = new System.Windows.Forms.TextBox();
            this.txtunitID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(467, 288);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 53);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "ອອກ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtunitName);
            this.groupBox1.Controls.Add(this.txtunitID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 667);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ຈັດການຂໍ້ມູນຫົວໜ່ວຍ";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(34, 370);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(551, 276);
            this.DGV.TabIndex = 3;
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(324, 288);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(118, 53);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "ລົບອອກ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(180, 288);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(118, 53);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "ແກ້ໄຂ";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(34, 288);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(118, 53);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "ບັນທຶກ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຊື່ຫົວໜ່ວຍ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ລະຫັດຫົວໜ່ວຍ";
            // 
            // txtunitName
            // 
            this.txtunitName.Location = new System.Drawing.Point(218, 175);
            this.txtunitName.Multiline = true;
            this.txtunitName.Name = "txtunitName";
            this.txtunitName.Size = new System.Drawing.Size(342, 52);
            this.txtunitName.TabIndex = 0;
            // 
            // txtunitID
            // 
            this.txtunitID.Location = new System.Drawing.Point(218, 79);
            this.txtunitID.Multiline = true;
            this.txtunitID.Name = "txtunitID";
            this.txtunitID.Size = new System.Drawing.Size(342, 52);
            this.txtunitID.TabIndex = 0;
            // 
            // FrmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 715);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmUnit";
            this.Text = "FrmUnit";
            this.Load += new System.EventHandler(this.FrmUnit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtunitName;
        private System.Windows.Forms.TextBox txtunitID;
    }
}