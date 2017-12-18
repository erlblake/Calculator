using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Calculator
{

    //TODO: Love your bubby

    public partial class Form1 : Form
    {
        bool Additionclicked = false;

        bool multiplicationClicked = false;
        bool divisionClicked = false;
        bool subtractClicked = false;
        List<string> digitscalc = new List<string>();
        List<int> additionlist = new List<int>();
        float total;
        private Button lastButton = null;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void calculation()
        {
            if (digitscalc.Count >= 2)
            {
                float next = int.Parse(digitscalc[digitscalc.Count - 1]);
                float prev = int.Parse(digitscalc[digitscalc.Count - 2]);

                if (Additionclicked == true)
                {
                    total = next + prev;
                    addtolist();
                    textfile();
                    Additionclicked = false;
                }

                else if (multiplicationClicked == true)
                {
                    total = next * prev;
                    addtolist();
                    textfile();
                    multiplicationClicked = false;
                }
                else if (divisionClicked == true)
                {

                    total = prev / next;
                    addtolist();
                    textfile();

                    divisionClicked = false;
                }
                else if (subtractClicked == true)
                {
                    total = prev - next;
                    addtolist();
                    textfile();

                    divisionClicked = false;

                }
            }
        }

        private void addtolist()
        {
            textBox1.Text = total.ToString();
            digitscalc.Add(total.ToString());
        }

        private void button_Click(object sender)
        {
            Button current = (Button)sender;
            current.BackColor = Color.LightSkyBlue;

            if (lastButton != null)
            {
                lastButton.BackColor = SystemColors.Control;
            }
            lastButton = current;
        }

        private void gen(string text)
        {     
            textBox1.Text += text;
            digitscalc.Add(textBox1.Text);

            textfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number1.Text);
        }

        private void textfile()
        {
            TextWriter tw = new StreamWriter("myFile.txt", true);
            tw.WriteLine(digitscalc[digitscalc.Count - 1]);
            tw.Close();
        }

        private void number2_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number2.Text);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number3.Text);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number4.Text);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number5.Text);
        }

        private void number6_Click(object sender, EventArgs e)
        {        
            button_Click(sender);
            gen(number6.Text);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            gen(number7.Text);
        }

        private void number8_Click(object sender, EventArgs e)
        {          
            button_Click(sender);
            gen(number8.Text);
        }

        private void number9_Click(object sender, EventArgs e)
        {          
            button_Click(sender);
            gen(number9.Text);
        }

        private void number0_Click(object sender, EventArgs e)
        {          
            button_Click(sender);
            gen(number0.Text);
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Additionclicked = true;
            button_Click(sender);
            textBox1.Text = Addition.Text;
            textBox1.Clear();

        }

        private void Equals_Click(object sender, EventArgs e)
        {
            button_Click(sender);
            textBox1.Text = Equals.Text;
            calculation();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            multiplicationClicked = true;
            button_Click(sender);
            textBox1.Text = multiplication.Text;
            textBox1.Clear();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            divisionClicked = true;
            button_Click(sender);
            textBox1.Text = Division.Text;
            textBox1.Clear();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            subtractClicked = true;
            button_Click(sender);
            textBox1.Text = Subtraction.Text;
            textBox1.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            digitscalc.Clear();
            File.WriteAllText("myFile.txt", String.Empty);
        }
    }
}
