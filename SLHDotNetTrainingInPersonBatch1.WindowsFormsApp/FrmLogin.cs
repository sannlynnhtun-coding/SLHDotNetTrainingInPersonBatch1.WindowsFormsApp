namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    // Successful login
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Successful login

            this.Hide();
            FrmMenu frm = new FrmMenu();
            //frm.Show();
            frm.ShowDialog();
            this.Show();
            //MessageBox.Show("Test");
        }
    }
}
