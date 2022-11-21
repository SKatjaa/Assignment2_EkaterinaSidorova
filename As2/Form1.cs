using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace As2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ClassA, ClassB, ClassC;
            double TotalA, TotalB, TotalC, Total;
            double PriceA, PriceB, PriceC;
            ClassA = int.Parse(textBox5.Text);
            ClassB = int.Parse(textBox6.Text);
            ClassC = int.Parse(textBox7.Text);

            PriceA = 15.00;
            PriceB = 12.00;
            PriceC = 9.00;

            TotalA = ClassA * PriceA;
            TotalB = ClassB * PriceB;
            TotalC = ClassC * PriceC;
            Total = TotalA + TotalB + TotalC;

            
            textBox1.Text = TotalA.ToString() + " $";
            textBox2.Text = TotalB.ToString() + " $";
            textBox3.Text = TotalC.ToString() + " $";
            textBox4.Text = Total.ToString() + " $";
        }
    }
}