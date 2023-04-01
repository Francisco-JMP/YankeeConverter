namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Controller database;
        public Form1()
        {
            //Initalize and create even handlers
            InitializeComponent();
            button1.Click += new EventHandler(Button1_Click);
            button2.Click += new EventHandler(Button2_Click);
            button3.Click += new EventHandler(Button3_Click);

           /* 
            // The password character is an asterisk.
            textBox2.Password = '*';
            //The control will allow no more than 14 characters.
            texbox2.MaxLength = 14;
           */
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            database = new Controller("Server = DESKTOP-5I7LOLJ\\SQLEXPRESS; " +
                                       "Trusted_Connection=true;" +
                                       "Database=Northwind;" +
                                       "User Instance=false;" +
                                       "Connection timeout=30");

            MessageBox.Show("Conneciton information sent");
               
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Get the cocunt
            string count = database.GetCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Get the names
            string names = database.GetCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}