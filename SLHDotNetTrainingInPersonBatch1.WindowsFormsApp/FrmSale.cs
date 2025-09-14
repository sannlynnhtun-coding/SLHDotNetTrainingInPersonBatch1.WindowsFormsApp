using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            BindProduct();
        }

        private void BindProduct()
        {
            using (IDbConnection db = new SqlConnection(AppSetting.ConnectionStringBuilder.ConnectionString))
            {
                var lst = db.Query<ProductDto>("select * from tbl_product where DeleteFlag = 0;").ToList();
                lst.Insert(0, new ProductDto
                {
                    ProductId = "0",
                    ProductName = "-- Select One --"
                });
                cboProduct.SelectedIndexChanged -= cboProduct_SelectedIndexChanged;
                cboProduct.DataSource = lst;
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "ProductId";
                cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboProduct.SelectedValue.ToString()!;
            using IDbConnection db = new SqlConnection(AppSetting.ConnectionStringBuilder.ConnectionString);
            var parameters = new { ProductId = id };
            var item = db.Query<ProductDto>("select * from tbl_product where DeleteFlag = 0 and ProductId = @ProductId", parameters).FirstOrDefault();
            if (item is null)
            {
                return;
            }

            txtPrice.Text = item.Price.ToString();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private List<ProductDto> Products { get; set; } = new List<ProductDto>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productId = cboProduct.SelectedValue!.ToString()!;
            string productName = cboProduct.Text.ToString();
            decimal price = Convert.ToDecimal(txtPrice.Text.Trim());
            int qty = Convert.ToInt32(txtQuantity.Text.Trim());

            var item = Products.FirstOrDefault(x => x.ProductId == productId);
            if (item is null)
            {
                Products.Add(new ProductDto
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = qty
                });
            }
            else
            {
                item.Quantity += qty;
            }

            dgvData.DataSource = null;
            dgvData.DataSource = Products;

            txtTotalAmount.Text = Products.Sum(x => (x.Price * x.Quantity)).ToString();

            //cboProduct.SelectedIndex = 0;
            //txtPrice.Clear();
            //txtQuantity.Clear();

            ClearControls();
        }

        private void ClearControls()
        {
            cboProduct.SelectedIndex = 0;
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Sale Insert
            // Sale Detail
            int saleId = CreateSale();
            if (saleId == 0)
            {
                MessageBox.Show("Cannot create sale");
                return;
            }
            bool result = CreateSaleDetail(saleId);
            if (result == false)
            {
                MessageBox.Show("Cannot create sale detail");
                return;
            }

            MessageBox.Show("Save completed");
            ClearControls();
            Products = new List<ProductDto>();
            dgvData.DataSource = null;
            dgvData.DataSource = Products;
        }

        /// <summary>
        /// Return SaleId
        /// </summary>
        /// <returns></returns>
        private int CreateSale()
        {
            string querySaleInsert = @"INSERT INTO [dbo].[Tbl_Sale]
           ([VoucherNo]
           ,[SaleDate]
           ,[TotalAmount])
     VALUES
           (@VoucherNo
           ,@SaleDate
           ,@TotalAmount);
SELECT SCOPE_IDENTITY();";
            using IDbConnection db = new SqlConnection(AppSetting.ConnectionStringBuilder.ConnectionString);
            var parameters = new
            {
                VoucherNo = "V" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                SaleDate = DateTime.Now,
                TotalAmount = Convert.ToDecimal(txtTotalAmount.Text.Trim())
            };
            var saleId = db.ExecuteScalar(querySaleInsert, parameters);
            if (saleId != null && saleId != DBNull.Value)
            {
                return Convert.ToInt32(saleId);
            }
            return 0;
        }

        private bool CreateSaleDetail(int saleId)
        {
            int result = 0;
            string querySaleDetailInsert = @"INSERT INTO [dbo].[Tbl_SaleDetail]
           ([SaleId]
           ,[ProductId]
           ,[Quantity]
           ,[Price])
     VALUES
           (@SaleId
           ,@ProductId
           ,@Quantity
           ,@Price)";
            using (IDbConnection db = new SqlConnection(AppSetting.ConnectionStringBuilder.ConnectionString))
            {
                foreach (ProductDto item in Products)
                {
                    result += db.Execute(querySaleDetailInsert, new
                    {
                        SaleId = saleId,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    });
                }
            }

            return result == Products.Count;
        }
    }
}
