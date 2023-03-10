namespace RngTest
{
    public partial class Form1 : Form
    {

        Auto auto;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auto = new("swag123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Zastav(15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto.ToString());
        }
    }
}