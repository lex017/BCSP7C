using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BCSP7C
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        connectdatabase ccd = new connectdatabase();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            ShowData();
            DGV.Columns[0].HeaderText = "ລະຫັດປະເພດສິນຄ້າ";
            DGV.Columns[1].HeaderText = "ຊື່ປະເພດສິນຄ້າ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 200;

        }
        void ShowData()
        {
            ccd.da = new SqlDataAdapter("select * from tbcategory", ccd.conn);
            ccd.da.Fill(ccd.ds);
            ccd.ds.Tables[0].Clear();
            ccd.da.Fill(ccd.ds);
            DGV.DataSource = ccd.ds.Tables[0];
            DGV.Refresh();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtcategoryID.Text == "")
                {
                    MessageBox.Show("pleace put your id first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryID.Focus();
                }
                else if (txtcategoryName.Text == "")
                {
                    MessageBox.Show("pleace put your Name first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryName.Focus();
                }
                else if (txtcategoryID.Text == txtcategoryID.Text)
                {
                    MessageBox.Show("pleace dont put the same ID", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryID.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch = int.TryParse(txtcategoryID.Text, out num);
                    if (ch == false)
                    {
                        MessageBox.Show("pleace put only number", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcategoryID.Clear();
                        txtcategoryID.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("did you want to Accept", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("Insert into tbCategory values(@categoryID,@categoryName)", ccd.conn);
                            ccd.cmd.Parameters.AddWithValue("categoryID", txtcategoryID.Text);
                            ccd.cmd.Parameters.AddWithValue("categoryName", txtcategoryName.Text);
                            ccd.cmd.ExecuteNonQuery();
                            ShowData();
                            AllClear();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            txtcategoryID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtcategoryName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtcategoryID.Text == "")
                {
                    MessageBox.Show("pleace put your id first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryID.Focus();
                }
                else if (txtcategoryName.Text == "")
                {
                    MessageBox.Show("pleace put your Name first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryName.Focus();
                }
                else if (txtcategoryID.Text == txtcategoryID.Text)
                {
                    MessageBox.Show("pleace dont put the same ID", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcategoryID.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch = int.TryParse(txtcategoryID.Text, out num);
                    if (ch == false)
                    {
                        MessageBox.Show("pleace put only number", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcategoryID.Clear();
                        txtcategoryID.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("did you want to Accept", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("update tbCategory set categoryName=@categoryName where categoryID=@categoryID", ccd.conn);
                            ccd.cmd.Parameters.AddWithValue("categoryID", txtcategoryID.Text);
                            ccd.cmd.Parameters.AddWithValue("categoryName", txtcategoryName.Text);
                            ccd.cmd.ExecuteNonQuery();
                            ShowData();
                            AllClear();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
        void AllClear()
        {
            txtcategoryID.Clear();
            txtcategoryName.Clear();
            txtcategoryID.Focus();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("delete from tbCategory where categoryID=@categoryID", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("categoryID", txtcategoryID.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            txtcategoryID.Clear();
            txtcategoryName.Clear();
            txtcategoryID.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
