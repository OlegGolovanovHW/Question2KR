using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Question2KR
{
    public partial class Form1 : Form
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33};
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Text = lloyd.Name + " says...";
            frm2.label1.Text = "My ears are " + Convert.ToString(lloyd.EarSize) + " inches tall.";
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Text = lucinda.Name + " says...";
            frm2.label1.Text = "My ears are " + Convert.ToString(lucinda.EarSize) + " inches tall.";
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant buf = new Elephant();
            buf = lucinda;
            lucinda = lloyd;
            lloyd = buf;
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
    public class Elephant
    {
        public int EarSize;
        public string Name;
        public string WhoAmI()
        {
            return Name;
        }
    }
}
