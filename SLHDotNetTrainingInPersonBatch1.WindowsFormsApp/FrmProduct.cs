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
            }
        }

        private void ClearControls()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
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
    }
}
