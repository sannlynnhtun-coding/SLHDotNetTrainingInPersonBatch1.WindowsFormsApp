namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    partial class FrmSale
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
            cboProduct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            dgvData = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(51, 53);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(230, 33);
            cboProduct.TabIndex = 0;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(51, 117);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(230, 31);
            txtPrice.TabIndex = 3;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(51, 179);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(230, 31);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 151);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(51, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colPrice, colQuantity });
            dgvData.Location = new Point(339, 12);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(449, 283);
            dgvData.TabIndex = 8;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "Product Id";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 150;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 150;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 150;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(339, 338);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(449, 31);
            txtTotalAmount.TabIndex = 10;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(669, 310);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 9;
            label4.Text = "Total Amount";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(676, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmSale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtTotalAmount);
            Controls.Add(label4);
            Controls.Add(dgvData);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboProduct);
            Name = "FrmSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale";
            Load += FrmSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProduct;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label3;
        private Button btnAdd;
        private Button btnCancel;
        private DataGridView dgvData;
        private TextBox txtTotalAmount;
        private Label label4;
        private Button btnSave;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
    }
}