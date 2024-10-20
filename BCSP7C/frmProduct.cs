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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        connectdatabase ccd = new connectdatabase();
        private void frmProduct_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            SqlDataAdapter daU = new SqlDataAdapter("select * from tbUnit", ccd.conn);
            DataSet dsU = new DataSet();
            daU.Fill(dsU);
            cbUnit.DataSource = dsU.Tables[0];
            cbUnit.DisplayMember = "UnitName";
            cbCategory.ValueMember = "unitID";
            //load
            SqlDataAdapter daC = new SqlDataAdapter("select * from tbCategory", ccd.conn);
            DataSet dsC = new DataSet();
            daC.Fill(dsC);
            cbCategory.DataSource = dsC.Tables[0];
            cbCategory.DisplayMember = "categoryName";
            cbCategory.ValueMember = "categoryID";
            ShowProduct();
            DGV.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            DGV.Columns[1].HeaderText = "ຊື້ສິນຄ້າ";
            DGV.Columns[2].HeaderText = "ລາຄາ";
            DGV.Columns[3].HeaderText = "ຈຳນວນ";
            DGV.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            DGV.Columns[5].HeaderText = "ປະເພດສິນຄ້າ";
            DGV.Columns[6].HeaderText = "ເງືອນໄຂສິນຄ້າ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 220;
            DGV.Columns[2].Width = 80;
            DGV.Columns[3].Width = 90;
            DGV.Columns[4].Width = 80;
            DGV.Columns[5].Width = 120;
            DGV.Columns[6].Width = 150;
            //count
            lbCount.Text=(DGV.RowCount - 1).ToString();
        }
            void ShowProduct()
        {
            ccd.da=new SqlDataAdapter("select * from View_product", ccd.conn);
            ccd.da.Fill(ccd.ds);
            ccd.ds.Tables[0].Clear();
            ccd.da.Fill(ccd.ds);
            DGV.DataSource = ccd.ds.Tables[0];
            DGV.Refresh();
        }
        void allClear()
        {
            txtproductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtConditionCheck.Clear();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("insert into tbProduct values(@productID,@productName,@price,@qty,@UnitID,@categoryID,@conditionCheck)", ccd.conn); ccd.cmd.Parameters.AddWithValue("productID",txtproductID.Text);
            ccd.cmd.Parameters.AddWithValue("productName",txtProductName.Text);
            ccd.cmd.Parameters.AddWithValue("price", txtPrice.Text);
            ccd.cmd.Parameters.AddWithValue("qty", txtQty.Text);
            ccd.cmd.Parameters.AddWithValue("UnitID", cbUnit.SelectedValue);
            ccd.cmd.Parameters.AddWithValue("categoryID", cbCategory.SelectedValue);
            ccd.cmd.Parameters.AddWithValue("conditionCheck", txtConditionCheck.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowProduct();
            allClear();
        }
    }
}
