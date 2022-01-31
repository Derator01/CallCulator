using System;
using System.Windows.Forms;

namespace CallCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double PTriangle(double a, double b)
        {
            if (counter == 0)
            {
                p = a + b;
                OutputN = p;
                counter++;
                return p;
            }
            else
            {
                double P = (p + c) / 2;
                double S = Math.Pow(P
                                    * (P - a)
                                    * (P - b)
                                    * (P - c), 0.5);
                Ctrstr = OutputN.ToString();
                Ctrstr1 = "0";
                ID = 6;
                a = 0;
                b = 0;
                c = 0;
                p = 0;
                counter--;
                return S;
            }            
        }

        int counter = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        double p = 0;
        string Ctrstr = "0";
        string Ctrstr1 = "0";
        bool Wright = false;
        int ID = 6;
        double OutputN = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Че лыбишся?");


        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "1";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "1";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "2";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "2";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "3";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "3";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "4";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "4";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "5";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "5";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "6";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "6";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "7";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "7";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Wright == false)
                if (Wright == false)
                {
                    Ctrstr += "8";
                    double CtrStr = double.Parse(Ctrstr);
                    Ctrstr = CtrStr.ToString();
                }
                else
                {
                    Ctrstr1 += "8";
                    double CtrStr1 = double.Parse(Ctrstr1);
                    Ctrstr1 = CtrStr1.ToString();
                }
            Updating();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (Wright == false)
            {
                Ctrstr += "9";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "9";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += ".";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += ".";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Wright == false)
            {
                Ctrstr += "0";
                double CtrStr = double.Parse(Ctrstr);
                Ctrstr = CtrStr.ToString();
            }
            else
            {
                Ctrstr1 += "0";
                double CtrStr1 = double.Parse(Ctrstr1);
                Ctrstr1 = CtrStr1.ToString();
            }
            Updating();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double FirstNumber = double.Parse(Ctrstr);
            double SecondNumber = double.Parse(Ctrstr1);
            Solve(FirstNumber, SecondNumber);
            Ctrstr = OutputN.ToString();
            Ctrstr1 = "0";
            Wright = false;
            ID = 0;
            Updating();

        }

        private void Solve(double FirstNumber, double SecondNumber)
        {
            switch (ID)
            {
                case 0:
                    {
                        if (FirstNumber <= 50)
                            OutputN = Math.Pow(FirstNumber, FirstNumber);
                        else
                            OutputN = 0;
                    }
                    break;
                case 1:
                    {
                        OutputN = FirstNumber + SecondNumber;
                    }
                    break;
                case 2:
                    {
                        OutputN = FirstNumber - SecondNumber;
                    }
                    break;
                case 3:
                    {
                        OutputN = FirstNumber * SecondNumber;
                    }
                    break;
                case 4:
                    {
                        OutputN = FirstNumber / SecondNumber;
                    }
                    break;
                case 5:
                    {
                        OutputN = Math.Pow(FirstNumber, SecondNumber);
                    }
                    break;
                case 6:
                    {
                        OutputN = Math.Pow(FirstNumber, 1 / SecondNumber);
                    }
                    break;
                case 7:
                    {
                        a = FirstNumber;
                        b = SecondNumber;
                        OutputN = PTriangle(FirstNumber, SecondNumber);
                    }
                    break;
                case 8:
                    {
                        ID = 9
                        
                    }
                    break;
                case 9:
                    {

                    }
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void Updating()
        {
            if (Wright == false)
            {
                textBox1.Text = Ctrstr;
            }
            else
            {
                textBox1.Text = Ctrstr1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 4;

        }

        void button21_Click(object sender, EventArgs e)
        {
            Wright = false;
            ID = 6;
            Ctrstr = "0";
            Ctrstr1 = "0";
            OutputN = 0;
            Updating();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 5;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 6;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 7;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            Wright = true;
            ID = 8;
        }
    }
}
