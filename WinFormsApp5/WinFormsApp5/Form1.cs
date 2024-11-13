namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Class1 Class1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1=new Class1();
            string fullname = fbox.Text;
            string dob = dOb.Text;
            string age = agebox.Text;
            string username = userBox.Text;
            int gender;
            if (radioButton1.Checked == true)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
            string pass = userBox.Text;
            try
            {
                String query =@"Insert into dbo.users(")
            }values();
            catch
            {

            }

            if (fullname != "" && dob != "" && age != "" && username != "" && pass != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show($"Account Successfully registered!! " +
                    $"Fullname :{fullname}" +
                    $"Date of Birth: {dob}" +
                    $"Age :{age}" +
                    $"Username :{username}", "Login Successful", buttons);

                if (result == DialogResult.OK)
                {
                    Form2 log = new Form2();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("close the box");
                }
            }

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
