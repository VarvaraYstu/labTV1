using System;
using System.Windows.Forms;

namespace tv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pA, pB, pC, pD, pE;

            pA = Convert.ToDouble(textBox1.Text);
            pB = Convert.ToDouble(textBox2.Text);
            pC = Convert.ToDouble(textBox3.Text);
            pD = Convert.ToDouble(textBox4.Text);
            pE = Convert.ToDouble(textBox5.Text);
            int testNumber = Convert.ToInt32(textBox6.Text);

            Random r = new Random();
            Random rA = new Random(r.Next(10000));
            Random rB = new Random(r.Next(10000));
            Random rC = new Random(r.Next(10000));
            Random rD = new Random(r.Next(10000));
            Random rE = new Random(r.Next(10000));

            double x;
            int result = 0;
            bool a, b, c, d, eE;
            for (int i = 0; i < testNumber; ++i)
            {
                x = rA.NextDouble();
                a = (x <= pA);

                x = rB.NextDouble();
                b = (x <= pB);

                x = rC.NextDouble();
                c = (x <= pC);

                x = rD.NextDouble();
                d = (x <= pD);

                x = rE.NextDouble();
                eE = (x <= pE);

                if ( (a && b) || (!c && !d && eE) )
                {
                    result++;
                }
            }
            textBox7.Text = ((double)result / (double)testNumber).ToString();
            double p = ((pA * pB) + ((1 - pC) * (1 - pD) * pE) - ((pA * pB) * ((1 - pC) * (1 - pD) * pE)));
            textBox8.Text = p.ToString();
        }
    }
}
