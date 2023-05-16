namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] temperatureUnits = { "Celcius", "Fahrenheit", "Kelvin"};
            
            comboBox1.Items.AddRange(temperatureUnits);
            
            comboBox2.Items.AddRange(temperatureUnits);

            comboBox1.SelectedIndex= 1;
            comboBox2.SelectedIndex= 0;
        }

        double CelciusToKelvin(double celcius)
        { 
            return celcius + 273.15;
        }
        double KelvinToCelcius(double kelvin)
        { 
            return kelvin - 273.15;
        }
        double CelciusToFahrenheit(double celcius)
        { 
            return celcius * 1.8 + 32;
        }
        double KelvinToFahrenheit(double kelvin)
        { 
            return kelvin * 1.8 - 459.67;
        }
        double FahrenheitToCelcius(double fahrenheit)
        { 
            return (fahrenheit -32)/1.8;
        }
        double FahrenheitToKelvin(double fahrenheit)
        { 
            return (fahrenheit + 459.67)*1.8;
        }

        void Calculate()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            double input = double.Parse(textBox1.Text);
            string result = "";

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1) // c to f
            {
                result = CelciusToFahrenheit(input).ToString();
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)//c to k
            {
                result = CelciusToKelvin(input).ToString();
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)//f to c
            {
                result = FahrenheitToCelcius(input).ToString();
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)//f to k
            {
                result = FahrenheitToKelvin(input).ToString();
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)//k to c
            {
                result = KelvinToCelcius(input).ToString();
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)//k to f
            {
                result = KelvinToFahrenheit(input).ToString();
            }
            textBox2.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}