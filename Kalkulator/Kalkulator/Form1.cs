using System.Linq.Expressions;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Prostok¹t");
            comboBox1.Items.Add("Kwadrat");
            comboBox1.Items.Add("Trójkat");
            comboBox1.Items.Add("Kolo");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double wynik = 0;

            if (comboBox1.SelectedItem.ToString() == "Prostok¹t")
            {
                wynik = a * b;
            }
            else if (comboBox1.SelectedItem.ToString() == "Kwadrat")
            {
                wynik = a * a;
            }
            else if (comboBox1.SelectedItem.ToString() == "Trójkat")
            {
                wynik = (a * b)/2;
            }
            else if (comboBox1.SelectedItem.ToString() == "Kolo")
            {
                wynik = Math.PI * a * a;
            }
            label4.Text = "pole" + wynik.ToString("0.00");
        }
        catch (Exception ex)
            {
                MessageBox.Show("B³ad" + ex.Message);
            }
            
                
            
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
