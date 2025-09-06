namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    partial class FrmProduct
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
            label1 = new Label();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Code: ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(169, 171);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 2;
            label2.Text = "Product Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 100);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "Price: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 137);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 4;
            label4.Text = "Quantity: ";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(169, 23);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(354, 31);
            txtCode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 31);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(354, 31);
            txtPrice.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(169, 134);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(354, 31);
            txtQty.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(287, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 568);
            Controls.Add(btnSave);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQty;
        private Button btnSave;
    }
}