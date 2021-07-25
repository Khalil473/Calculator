using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        bool right,trueZiro,arthimaticClicked;
        Stack<String> results=new Stack<String>();
        public Form1()
        {
            InitializeComponent();
            right = true;
            trueZiro = false;
            arthimaticClicked = false;
            results.Push("0.0");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DoubleConverter d = new DoubleConverter();

        private void button1_Click(object sender, EventArgs e)
        {
            DoubleConverter d = new DoubleConverter();
            String text=textBox1.Text;
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0.0";
                trueZiro = false;
            }
            else if ((Double)d.ConvertFromString(text) == 0.0)
            {
                textBox1.Text = "0.0";
                trueZiro = false;
            }
            else if (Int32.Parse(textBox1.Text.Split(".")[1]) == 0 && trueZiro) trueZiro = false;
            else if (Int32.Parse(textBox1.Text.Split(".")[1]) == 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Split(".")[0].Length - 1);
                right = true;
            }
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".0";
                trueZiro = false;
                right = true;
            }
            else if (textBox1.Text.IndexOf(".") == textBox1.Text.Length - 1)
            {
                textBox1.Text += "0";
                trueZiro = false;
            }
            if (textBox1.Text.IndexOf(".") == 0)
            {
                textBox1.Text = "0.0";
                trueZiro = false;
                right = true;
            }
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {
                if(texts[0]=="0") texts[0] = "9";
                else 
                texts[0] += "9";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "9";
                else if (texts[1] == "0") texts[1] = "9";
                else texts[1] += "9";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "1";
                else
                    texts[0] += "1";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "1";
                else if (texts[1] == "0") texts[1] = "1";
                else texts[1] += "1";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "7";
                else
                    texts[0] += "7";
            }
            else
            {
                if(texts[1]=="0" && trueZiro) texts[1] += "7";
                else if(texts[1] == "0") texts[1] = "7";
                else texts[1] += "7";
            }
            textBox1.Text = texts[0] +"."+ texts[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "8";
                else
                    texts[0] += "8";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "8";
                else if (texts[1] == "0") texts[1] = "8";
                else texts[1] += "8";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "4";
                else
                    texts[0] += "4";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "4";
                else if (texts[1] == "0") texts[1] = "4";
                else texts[1] += "4";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "5";
                else
                    texts[0] += "5";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "5";
                else if (texts[1] == "0") texts[1] = "5";
                else texts[1] += "5";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "6";
                else
                    texts[0] += "6";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "6";
                else if (texts[1] == "0") texts[1] = "6";
                else texts[1] += "6";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "2";
                else
                    texts[0] += "2";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "2";
                else if (texts[1] == "0") texts[1] = "2";
                else texts[1] += "2";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right)
            {

                if (texts[0] == "0") texts[0] = "3";
                else
                    texts[0] += "3";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "3";
                else if (texts[1] == "0") texts[1] = "3";
                else texts[1] += "3";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (arthimaticClicked)
            {
                textBox1.Text = "0.0";
                arthimaticClicked = false;
            }
            String[] texts = textBox1.Text.Split(".");
            if (right && texts[0]!="0")
            {
                texts[0] += "0";
            }
            else
            {
                if (texts[1] == "0" && trueZiro) texts[1] += "0";
                else if (texts[1] == "0") trueZiro=true;
                else texts[1] += "0";
            }
            textBox1.Text = texts[0] + "." + texts[1];
        }
        double firstNum = 0.0;
        void showRes(char op)
        {
            

            if (op == '+')
            {
                if (arthimaticClicked) lastNum += firstNum;
                else if (lastNum != 0.0) lastNum += (Double)d.ConvertFromString(textBox1.Text);
                else lastNum = firstNum + (Double)d.ConvertFromString(textBox1.Text);
                arthimaticClicked = true;
            }
            if (op == '-')
            {
                if (arthimaticClicked) lastNum -= firstNum;
                else lastNum -= (Double)d.ConvertFromString(textBox1.Text);
                arthimaticClicked = true;
            }
            if (op == '*')
            {
                if (arthimaticClicked) lastNum *= firstNum;
                else lastNum *= (Double)d.ConvertFromString(textBox1.Text);
                arthimaticClicked = true;
            }
            if (op == '/')
            {
                if (arthimaticClicked) lastNum /= firstNum;
                else lastNum /= (Double)d.ConvertFromString(textBox1.Text);
                arthimaticClicked = true;
            }
            String a = lastNum + "";
            if (a.Contains(".")) textBox1.Text = a;
            else textBox1.Text = a + ".0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            firstNum = 0.0;
            lastNum = 0.0;
            right = true;
            arthimaticClicked = false;
            trueZiro = false;
            textBox1.Text = "0.0";
            results.Clear();
            results.Push("0.0");
            results.Push("0.0");
        }
        Double lastNum = 0.0;

        private void button12_Click(object sender, EventArgs e)
        {
            doCalculate();
            String s = results.Peek();
            if (results.Count < 2)
                results.Push((Double)d.ConvertFromString(textBox1.Text) + "");
            results.Push("-");
            arthimaticClicked = true;
            textBox1.Text = s;
            if (!s.Contains(".")) textBox1.Text += ".0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            doCalculate();
            String s = results.Peek();
            if (results.Count < 2)
                results.Push((Double)d.ConvertFromString(textBox1.Text) + "");
            results.Push("*");
            arthimaticClicked = true;
            textBox1.Text = s;
            if (!s.Contains(".")) textBox1.Text += ".0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            doCalculate();
            String s = results.Peek();
            if (results.Count < 2)
                results.Push((Double)d.ConvertFromString(textBox1.Text) + "");
            results.Push("/");
            arthimaticClicked = true;
            textBox1.Text = s;
            if (!s.Contains(".")) textBox1.Text += ".0";
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            String preOp = results.Peek();
          
            doCalculate();
            if (arthimaticClicked) results.Push(preOp);
            String s = results.Peek();
            textBox1.Text = s;
            if (!s.Contains(".")) textBox1.Text += ".0";
            arthimaticClicked = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            doCalculate();
            String s = results.Peek();
            if(results.Count<2)
            results.Push((Double)d.ConvertFromString(textBox1.Text) + "");
            results.Push("+");
            arthimaticClicked = true;
            textBox1.Text = s;
            if (!s.Contains(".")) textBox1.Text += ".0";
        }

        private void doCalculate()
        {
            String op=results.Pop();
            if (op == "0.0") return;
            if (op == "+")
            {
                if (!arthimaticClicked)
                {
                    results.Push(((Double)d.ConvertFromString(results.Peek()) + (Double)d.ConvertFromString(textBox1.Text))+"");
                    firstNum = (Double)d.ConvertFromString(textBox1.Text);
                }
                else
                    results.Push(((Double)d.ConvertFromString(results.Peek()) + firstNum)+"");
                return;
            }
            if (op == "-")
            {
                if (!arthimaticClicked)
                {
                    results.Push(((Double)d.ConvertFromString(results.Peek()) - (Double)d.ConvertFromString(textBox1.Text)) + "");
                    firstNum = (Double)d.ConvertFromString(textBox1.Text);
                }
                else
                    results.Push(((Double)d.ConvertFromString(results.Peek()) - firstNum) + "");
                return;
            }
            if (op == "*")
            {
                if (!arthimaticClicked)
                {
                    results.Push(((Double)d.ConvertFromString(results.Peek()) * (Double)d.ConvertFromString(textBox1.Text)) + "");
                    firstNum = (Double)d.ConvertFromString(textBox1.Text);
                }
                else
                    results.Push(((Double)d.ConvertFromString(results.Peek()) * firstNum) + "");
                return;
            }
            if (op == "/")
            {
                if (!arthimaticClicked)
                {
                    results.Push(((Double)d.ConvertFromString(results.Peek()) / (Double)d.ConvertFromString(textBox1.Text)) + "");
                    firstNum = (Double)d.ConvertFromString(textBox1.Text);
                }
                else
                    results.Push(((Double)d.ConvertFromString(results.Peek()) / firstNum) + "");
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            right = false;
        }
        
     
    }
}
