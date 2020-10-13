using System;
using Microsoft.WindowsCE.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UltimateNotepad
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.SaveFileDialog saveas;
        private System.Windows.Forms.SaveFileDialog save;
        int flag = 0;
        
        Timer tmr1 = new Timer();

        public Form1()
        {
            InitializeComponent(); 
       
        }

        static int t = 900;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.WordWrap = true;
            ques[0] = "Earlier name of Java Programming Language was";
            ques[1] = "Bytecode is given as input to";
            ques[2] = "Which of the following utilities can be used to compile managed assemblies into processor-specific native code?";
            ques[3] = "In C#.NET if we do not catch the exception thrown at runtime then who will catch it?";
            ques[4] = "Which bitwise operator is suitable for checking whether a particular bit is on or off?";
            ques[5] = "The data elements in structure are also known as what?";
            ques[6] = "Two methods with the same name but with different parameters?";
            ques[7] = "Array subscript in C always start at?";
            ques[8] = "C was developed in the year?";
            ques[9] = "What does 0110 >> 2 evaluate to in binary?";
            ques[10] = "Function can be overloaded even if they differ only by their datatype? State True or False";
            ques[11] = "In C++, Which data type is suitable for storing a number like? Number= 10.0000000001";
            ques[12] = "Which type of class allows only one object of it to be created?";
            ques[13] = "cout is a/an-";
            ques[14] = "Name of the first personal computer created by Berkeley Enterprises ";
            ques[15] = "Which operator has only one operand?";
            ques[16] = "Who actually manufactured the retina display used in Apple’s Ipad? ";
            ques[17] = "What is the name of the folder which cannot be created anywhere on a Windows PC? ";
            ques[18] = "Which method will send an encrypted input to a script via a URL?";
            ques[19] = "Total number of transistor the Dynamic RAM consist of";
            ques[20] = "Which is never implemented in parallel processor? (MISD/MIMD)";
            ques[21] = "The ______ directive can also be used to refer to a particular item within namespace.";
            ques[22] = "C++ has one operator that takes a three arguments known as __ operator.";
            ques[23] = "A ______ defines the characteristics of an object.";
            ques[24] = "Pointers are the variable which hold _______of the other variables.";
            ques[25] = "Strings are nothing but _______ of characters.";
            ques[26] = "File I/O is done using _____ to improve efficiency.";
            ques[27] = "The command line argv contains ______ passed to the program.";
            ques[28] = "The operators <  and  > are called ___________ operators.";
            ques[29] = "The _______ statement takes the execution control out of the loop.";
            ques[30] = "How many bits are required to identify an IPv4 address?";

            ans[0] = "oak";
            ans[1] = "jvm";
            ans[2] = "ngen";
            ans[3] = "clr";
            ans[4] = "&";
            ans[5] = "members";
            ans[6] = "overloading";
            ans[7] = "zero";
            ans[8] = "1972";
            ans[9] = "0001";
            ans[10] = "false";
            ans[11] = "double";
            ans[12] = "singleton";
            ans[13] = "object";
            ans[14] = "simon";
            ans[15] = "unary";
            ans[16] = "samsung";
            ans[17] = "con";
            ans[18] = "post";
            ans[19] = "6";
            ans[20] = "mimd";
            ans[21] = "using";
            ans[22] = "ternary";
            ans[23] = "class";
            ans[24] = "address";
            ans[25] = "array";
            ans[26] = "buffer";
            ans[27] = "values";
            ans[28] = "redirection";
            ans[29] = "break";
            ans[30] = "32";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                open = new OpenFileDialog();
                open.Filter = "All Files|*.*";
                open.Title = "Open";
                open.ShowDialog();
                System.IO.StreamReader openfile = new System.IO.StreamReader(open.FileName);
                textBox1.Text = openfile.ReadToEnd();
                openfile.Close();
            }
            catch (Exception) { }
        }
        int flagforsave = 0; string filename = "NewTextDocumentTest";
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
        }
        private void comprnd_Tick(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Time Left: " + t + " Seconds"; t--;
                if (t == 0)
                {
                    tmr1.Stop();
                    MessageBox.Show("Time Up..!!! Thank You For Participating.");
                    System.IO.StreamWriter savefile = new System.IO.StreamWriter(filename);
                    savefile.WriteLine(textBox1.Text);
                    savefile.Close();
                    Application.Exit();
                }
                if (flagforsave == 1 && t % 15 == 0)
                {
                    System.IO.StreamWriter savefile = new System.IO.StreamWriter(filename);
                    savefile.WriteLine(textBox1.Text);
                    savefile.Close();
                }
            }
            catch (Exception) { }
        }

        private void blnkscrn()
        {
            textBox1.Text = "";
        }
        
        private void delline_Tick(object sender, EventArgs e)
        {
            try
            {
                int n;
                n = new Random().Next(textBox1.Lines.Length - 1);
                List<string> str1 = new List<string>();
                str1.AddRange(textBox1.Lines);
                str1.RemoveAt(3);
                textBox1.Lines = str1.ToArray();
                textBox1.SelectionStart = textBox1.TextLength;
            }
            catch (Exception) { }
     
        }
        private void flickerscrn()
        {
            try
            {
                if (flag == 0)
                {
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.Black;
                    flag = flag + 1;
                }
                else if (flag == 1)
                {
                    textBox1.BackColor = Color.Black;
                    textBox1.ForeColor = Color.White;
                    flag = flag + 1;
                }
                else if (flag == 2)
                {
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.White;
                    flag = flag + 1;
                }
                else if (flag == 3)
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.ForeColor = Color.Yellow;
                    flag = flag + 1;
                }
                else if (flag == 4)
                {
                    textBox1.BackColor = Color.Yellow;
                    textBox1.ForeColor = Color.Yellow;
                    flag = flag + 1;
                }
                else if (flag == 5)
                {
                    textBox1.BackColor = Color.Yellow;
                    textBox1.ForeColor = Color.Blue;
                    flag = 0;
                }
            }
            catch (Exception) { }
        }

       
        private void fontchange()
        {
            try
            {
                if (t%2 == 1)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 6);
                }
                if (t%2 == 0)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 200);
                }
            }
            catch (Exception) { }

        }

        private void blind()
        {
            try
            {
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.White;   
            }
            catch (Exception) { }
        }

        double z = 1.0; int f = 0;
        private void transscrn()
        {
            try
            {
                if (f == 0)
                    if (z > 0.50)
                    {
                        if (z <= 1.0)
                        {

                            z = z - 0.10;
                            ActiveForm.Opacity = z;
                            if (z == 0.00)
                                f = 1;

                        }
                        if (f == 1)
                        {
                            if (z > 0.0)
                            {
                                if (z < 1.0)
                                {
                                    z = z + 0.01;
                                    ActiveForm.Opacity = z;
                                    if (z == 1.0)
                                        f = 0;
                                }
                            }
                        }

                    }
            }
            catch (Exception) { }
        }

        private void cursorshift()
        {
            try
            {
                Random r = new Random();
                textBox1.SelectionStart = r.Next(textBox1.Text.Length);
            }
            catch (Exception) { }
        }
        string []ques = new string[40];
        string[] ans = new string[40];
        static int i = 0;
       // int l = 0;
        private void popup_Tick(object sender, EventArgs e)
        {
            try
            {
                groupBox2.BringToFront();
                label1.Text = ques[i];
                answerbox.Enabled = true;
                button3.Enabled = true;
                textBox1.ReadOnly = true;
                groupBox2.Visible = true;
                delline.Stop(); Blank_Screen.Stop(); flicker.Stop(); transparent.Stop(); curshift.Stop();
                popup.Stop();
            }
            catch (Exception) { }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            textBox1.Visible = false;
            groupBox1.Visible = true;
            groupBox1.BringToFront();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "sukash")
                {
                    textBox3.Text = "";
                    checking();
                    comprnd.Enabled = true;
                    menuStrip1.BackColor = Color.LightGreen;
              
                }
                else
                {
                    textBox3.Text = "";
                    MessageBox.Show("Incorrect Password");
                }
            }
            catch (Exception) { }
        }

        static int flick = 0;
        static int fchange = 0;

        public void checking()
        {
            try
            {
                textBox1.Visible = true;
                groupBox1.Visible = false;

                if (checkBox1.Checked == true)
                    Blank_Screen.Enabled = true;
                else
                    Blank_Screen.Enabled = false;

                if (checkBox2.Checked == true)
                    delline.Enabled = true;
                else
                    delline.Enabled = false;

                if (checkBox4.Checked == true)
                {
                    flick = 1;
                    flicker.Enabled = true;
                }
                else
                {
                    flick = 0;
                    if (flick == 0 && fchange == 0)
                    {
                        flicker.Enabled = false;
                        textBox1.BackColor = Color.White;
                        textBox1.ForeColor = Color.Black;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    }
                }
                if (checkBox6.Checked == true)
                    curshift.Enabled = true;
                else
                    curshift.Enabled = false;

                if (checkBox7.Checked == true)
                    flag123 = 1;
                else
                    flag123 = 0;

                if (checkBox9.Checked == true)
                    popup.Enabled = true;
                else
                {
                    popup.Enabled = false;
                    groupBox2.Visible = false;
                    textBox1.ReadOnly = false;
                }

                if (checkBox3.Checked == true)
                    back = 1;
                else
                    back = 0;

                if (checkBox5.Checked == true)
                {
                    blank.Enabled = true;
                    arrow = 1;
                }
                else if (checkBox5.Checked == false)
                {
                    blank.Enabled = false;
                    textBox1.ForeColor = Color.Black;
                    arrow = 0;
                }

                if (checkBox8.Checked == true)
                {
                    fchange = 1;
                    flicker.Enabled = true;
                }
                else
                {
                    fchange = 0;
                    if (flick == 0 && fchange == 0)
                    {
                        flicker.Enabled = false;
                        textBox1.BackColor = Color.White;
                        textBox1.ForeColor = Color.Black;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    }
                }
                  
            }
            catch (Exception) { }
        }
        private void Blank_Screen_Tick(object sender, EventArgs e)
        {
            blnkscrn();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void flicker_Tick(object sender, EventArgs e)
        {
           if(flick==1)
               flickerscrn();
           if(fchange==1)
               fontchange();
        }

        private void transparent_Tick(object sender, EventArgs e)
        {
            transscrn();
        }

        private void curshift_Tick(object sender, EventArgs e)
        {
            cursorshift();
        }

        private void backspace_Tick(object sender, EventArgs e)
        {
            blind();
        }

        static int flag123 = 0; 
        static int back = 0;
        static int arrow = 0;

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (flag123 == 1)
                {
                    if (e.KeyValue == 13)
                    {
                        int l = textBox1.Text.Length;
                        string s = textBox1.Text;
                        string s1 = s.Substring(0, (l - 1));
                        textBox1.Text = s1;
                        textBox1.SelectionStart = l;
                    }
                    if (e.KeyValue == 8)
                    {
                        textBox1.Text = "";
                    }
            }
            }
            catch (Exception) { }

            
            try
            {
                string str = textBox1.Text;
                if (back == 1)
                {
                    if (e.KeyValue == 8)
                    {
                        textBox1.Text = str + str; //crazy backspace!!!
                    }
                }
            }
            catch (Exception) { }

            try
            {
                if (arrow == 1)
                {
                    if (e.KeyValue == 37)
                    {
                        int l = textBox1.Text.Length;
                        textBox1.SelectionStart = l;
                    }
                }
            }
            catch (Exception) { }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "sukash")
                {
                    textBox2.Text = "";
                    groupBox2.Visible = false;
                    textBox1.ReadOnly = false;
                    checking();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    textBox2.Text = "";
                }
            }
            catch (Exception) { }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        int flagfornew = 0;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flagfornew = 1;
            textBox1.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagforsave == 0 || flagfornew == 1)
                {
                    save = new SaveFileDialog();
                    save.Filter = "Text Files|*.txt|All Files|*.*";
                    save.Title = "Save";
                    save.ShowDialog();
                    if (save.FileName == "")
                    {
                        MessageBox.Show("please provide a file name");
                    }
                    else
                    {
                        System.IO.StreamWriter savefile = new System.IO.StreamWriter(save.FileName);
                        savefile.WriteLine(textBox1.Text);
                        savefile.Close();
                        filename = save.FileName;
                        flagfornew = 0;
                    }
                    flagforsave = 1;
                    ActiveForm.Text = filename + " - ULTIMATE NOTEPAD";
                }
                else
                {
                    System.IO.StreamWriter savefile = new System.IO.StreamWriter(filename);
                    savefile.WriteLine(textBox1.Text);
                    savefile.Close();
                }
            }
            catch (Exception) { }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                open = new OpenFileDialog();
                open.Filter = "All Files|*.*";
                open.Title = "Open";
                open.ShowDialog();
                System.IO.StreamReader openfile = new System.IO.StreamReader(open.FileName);
                textBox1.Text = openfile.ReadToEnd();
                openfile.Close();
            }
            catch (Exception) { }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveas = new SaveFileDialog();
                saveas.Filter = "Text Files|*.txt|All Files|*.*";
                saveas.Title = "Save";
                saveas.ShowDialog();
                System.IO.StreamWriter saveasfile = new System.IO.StreamWriter(saveas.FileName);
                saveasfile.WriteLine(textBox1.Text);
                saveasfile.Close();
            }
            catch (Exception) { }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pAsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = true;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void featuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            groupBox1.Visible = true;
            groupBox1.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form1.DefaultBackColor = "#ffffff";
            //Form1.DefaultForeColor = "White";
          //  this.BackColor = Color.FromArgb(z, 255 - z, z);
        }

        private void invi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void font_tmr_Tick(object sender, EventArgs e)
        {
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false; 
            try
            {
                if (flagforsave == 0 || flagfornew == 1)
                {
                    save = new SaveFileDialog();
                    save.Filter = "Text Files|*.txt|All Files|*.*";
                    save.Title = "Save";
                    save.ShowDialog();
                    if (save.FileName == "")
                    {
                        MessageBox.Show("please provide a file name");
                    }
                    else
                    {
                        System.IO.StreamWriter savefile = new System.IO.StreamWriter(save.FileName);
                        savefile.WriteLine(textBox1.Text);
                        savefile.Close();
                        filename = save.FileName;
                        flagfornew = 0;
                    }
                    flagforsave = 1;
                    ActiveForm.Text = filename + " - ULTIMATE NOTEPAD";
                }
                else
                {
                    System.IO.StreamWriter savefile = new System.IO.StreamWriter(filename);
                    savefile.WriteLine(textBox1.Text);
                    savefile.Close();
                }
            }
            catch (Exception) { }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (answerbox.Text.ToLower() == "")
                MessageBox.Show("No answer provided!");
            else
                popanswer();
        }

        private void popanswer()
        {
            try
            {
                if (ans[i] == answerbox.Text.ToLower())
                {
                    textBox1.ReadOnly = false;
                    groupBox2.Visible = false;
                    answerbox.Text = "";
                    popup.Start();
                    popup.Interval = 20000;
                }
                else
                {
                        textBox1.ReadOnly = true;
                        label1.Text = "Penalty Wait!";
                        answerbox.Text = "";
                        answerbox.Enabled = false;
                        button3.Enabled = false;
               
                    popup.Start();
                    popup.Interval = 30000;
                }
                if (i < 18)
                    i++;
            }
            catch (Exception)
            {
            }
        }
    }
}
