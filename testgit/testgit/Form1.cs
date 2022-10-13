namespace testgit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                useraccount frm=new useraccount();
                frm.Show();
            }
        }
    }
}