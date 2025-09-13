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
    public partial class FrmProduct : Form
    {
        private string? _productId = null;
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
        {
            DataSource = ".",
            InitialCatalog = "InPersonBatch1MiniPOS",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };
        public FrmProduct()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            //colProductId.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = CheckRequiredFields();
            if (result == false) return;

            // Insert into Product Table
            SaveProduct();
        }

        private void SaveProduct()
        {
            string id = Guid.NewGuid().ToString();
            ProductDto dto = new ProductDto()
            {
                DeleteFlag = false,
                Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                ProductCode = txtCode.Text.Trim(),
                ProductId = id,
                ProductName = txtName.Text.Trim(),
                Quantity = Convert.ToInt32(txtQty.Text.Trim())
            };
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                string query = @"INSERT INTO [dbo].[Tbl_Product]
           ([ProductId]
           ,[ProductCode]
           ,[ProductName]
           ,[Price]
           ,[Quantity]
           ,[DeleteFlag])
     VALUES
           (@ProductId
           ,@ProductCode
           ,@ProductName
           ,@Price
           ,@Quantity
           ,@DeleteFlag)";
                db.Open();
                int result = db.Execute(query, dto);
                string message = result > 0 ? "Product saved successfully" : "Failed to save product";
                MessageBox.Show(message);
                ClearControls();
                BindData();
            }
        }

        private void ClearControls()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            _productId = null;
            txtCode.Focus();
        }

        private void SaveProduct(string code, string name, decimal price, int qty)
        {

        }

        private void SaveProduct(ProductDto dto)
        {

        }

        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("Product Code is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Product Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                MessageBox.Show("Quantity is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return false;
            }
            return true;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                List<ProductDto> lst = db.Query<ProductDto>("select * from tbl_product where DeleteFlag = 0").ToList();
                dgvData.DataSource = lst;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // Edit Action
            {
                string productId = dgvData.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                using (IDbConnection db = new SqlConnection(sb.ConnectionString))
                {
                    db.Open();
                    string query = "select * from tbl_product where ProductId = @ProductId";
                    ProductDto item = db.QueryFirstOrDefault<ProductDto>(query, new { ProductId = productId })!;
                    if (item is null)
                    {
                        MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BindData();
                        return;
                    }

                    _productId = productId;
                    txtCode.Text = item.ProductCode;
                    txtName.Text = item.ProductName;
                    txtPrice.Text = item.Price.ToString();
                    txtQty.Text = item.Quantity.ToString();
                    btnUpdate.Visible = true;
                    btnSave.Visible = false;
                }
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0) // Delete Action
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No) return;

                string productId = dgvData.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
                using (IDbConnection db = new SqlConnection(sb.ConnectionString))
                {
                    db.Open();
                    string query = "select * from tbl_product where ProductId = @ProductId";
                    ProductDto item = db.QueryFirstOrDefault<ProductDto>(query, new { ProductId = productId })!;
                    if (item is null)
                    {
                        MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BindData();
                        return;
                    }

                    string deleteQuery = @"UPDATE [dbo].[Tbl_Product]
                                   SET [DeleteFlag] = 1
                                 WHERE ProductId = @ProductId";
                    int result = db.Execute(deleteQuery, new { ProductId = productId });
                    string message = result > 0 ? "Product deleted successfully" : "Failed to delete product";
                    MessageBox.Show(message);
                    ClearControls();
                    BindData();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_productId))
            {
                MessageBox.Show("Please select a product to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductDto dto = new ProductDto()
            {
                Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                ProductCode = txtCode.Text.Trim(),
                ProductId = _productId,
                ProductName = txtName.Text.Trim(),
                Quantity = Convert.ToInt32(txtQty.Text.Trim())
            };

            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                string query = @"UPDATE [dbo].[Tbl_Product]
                                   SET [ProductCode] = @ProductCode
                                      ,[ProductName] = @ProductName
                                      ,[Price] = @Price
                                      ,[Quantity] = @Quantity
                                 WHERE ProductId = @ProductId";
                int result = db.Execute(query, dto);
                string message = result > 0 ? "Product updated successfully" : "Failed to update product";
                MessageBox.Show(message);
                ClearControls();
                BindData();
            }
        }
    }
}
