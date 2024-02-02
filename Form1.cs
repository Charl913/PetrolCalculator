namespace PetrolCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(textBox1.Text);
            double kmPerLiter = double.Parse(textBox2.Text);
            double pricePerLiter = double.Parse(textBox3.Text);
            double daysOff = double.Parse(textBox4.Text);
            double daysOfMonth = double.Parse(textBox5.Text);

            label6.Text = "Petrol money needed to location and back = R" + $"{Math.Ceiling(CalculateToAndBack(distance, kmPerLiter, pricePerLiter, daysOff, daysOfMonth))}";
        }

        double CalculateToAndBack(double distance, double kmPerLiter, double pricePerLiter, double daysOff, double daysOfMonth)
        {
            return ((((distance / kmPerLiter) * pricePerLiter) * 2) * (daysOfMonth - daysOff));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}