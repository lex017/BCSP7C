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
    public partial class FrmUnit : Form
    {
        public FrmUnit()
        {
            InitializeComponent();
        }
        connectdatabase ccd = new connectdatabase();
        private void FrmUnit_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            ShowData();
            DGV.Columns[0].HeaderText = "ລະຫັດຫົວໜ່ວຍ";
            DGV.Columns[1].HeaderText = "ຊື່ຫົວໜ່ວຍ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 200;
            DGV.DefaultCellStyle.BackColor = Color.Azure;
            DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
        }
        void ShowData()
        {
            ccd.da = new SqlDataAdapter("select * from tbUnit", ccd.conn);
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
                if (txtunitID.Text == "")
                {
                    MessageBox.Show("pleace put your id first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitID.Focus();
                }
                else if (txtunitName.Text == "")
                {
                    MessageBox.Show("pleace put your Name first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitName.Focus();
                }
                else if (txtunitID == txtunitID)
                {
                    MessageBox.Show("pleace dont put the same ID", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitID.Clear();
                    txtunitID.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch=int.TryParse(txtunitID.Text, out num);
                    if (ch==false)
                    {
                        MessageBox.Show("pleace put only number", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtunitID.Clear();
                        txtunitID.Focus();
                    }
                    /*else if (ch==ch)
                    {
                        MessageBox.Show("pleace dont put the same ID", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtunitID.Clear();
                        txtunitID.Focus();
                    }*/
                    else
                    {
                        if (MessageBox.Show("did you want to Accept", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("Insert into tbUnit values(@UnitID,@UnitName)", ccd.conn);
                            ccd.cmd.Parameters.Add("UnitID", SqlDbType.Int ).Value = txtunitID.Text;
                            ccd.cmd.Parameters.Add("UnitName",SqlDbType.NVarChar).Value = txtunitName.Text;
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
            txtunitID.Clear();
            txtunitName.Clear();
            txtunitID.Focus();
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtunitID.Text == "")
                {
                    MessageBox.Show("pleace put your id first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitID.Focus();
                }
                else if (txtunitName.Text == "")
                {
                    MessageBox.Show("pleace put your Name first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitName.Focus();
                }
                else if (txtunitID.Text == txtunitID.Text)
                {
                    MessageBox.Show("pleace dont put the same ID", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitID.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch = int.TryParse(txtunitID.Text, out num);
                    if (ch == false)
                    {
                        MessageBox.Show("pleace put only number", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtunitID.Clear();
                        txtunitID.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("did you want to Accept", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("update tbUnit set UnitName=@UnitName where UnitID=@UnitID", ccd.conn);
                            ccd.cmd.Parameters.Add("UnitID", SqlDbType.Int).Value = txtunitID.Text;
                            ccd.cmd.Parameters.Add("UnitName", SqlDbType.NVarChar).Value = txtunitName.Text;
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
            txtunitID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtunitName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtunitID.Text == "")
                {
                    MessageBox.Show("pleace put your id first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitID.Focus();
                }
                else if (txtunitName.Text == "")
                {
                    MessageBox.Show("pleace put your Name first", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtunitName.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch = int.TryParse(txtunitID.Text, out num);
                    if (ch == false)
                    {
                        MessageBox.Show("pleace put only number", "check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtunitID.Clear();
                        txtunitID.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("did you want to Accept", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("delete from tbUnit where UnitID=@UnitID", ccd.conn);
                            ccd.cmd.Parameters.Add("UnitID", SqlDbType.Int).Value = txtunitID.Text;
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
