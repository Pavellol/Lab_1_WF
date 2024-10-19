namespace Lab_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = System.Text.Encoding.Default.GetString(new byte[] { 12, 15, 12 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            double a = double.Parse(textBox1.Text);
            double c = double.Parse(textBox2.Text);
            double d = double.Parse(textBox3.Text);
            double x = double.Parse(textBox4.Text);

            double y = Math.Sqrt((c - d * Math.Pow(x, 2)) / x)
                     + Math.Log(Math.Pow(x, 2) + c) / (0.7 * x + a * d)
                     - Math.Pow(10, -2) / (c - d * Math.Pow(x, 3));

            textBox5.Text = Environment.NewLine + "y = " + y.ToString();
        }
    }
}
