using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.textBox1.Text = "FIND COUNTRIES NAME ?" + Environment.NewLine;
            this.textBox1.Text += "1. PAKISTAN " + Environment.NewLine;
            this.textBox1.Text += "2. AUSTRALIA" + Environment.NewLine;
            this.textBox1.Text += "3. NEPAL" + Environment.NewLine;
            this.textBox1.Text += "4. BENGAL" + Environment.NewLine;
            this.textBox1.Text += "5. IRAN" + Environment.NewLine;
            this.textBox1.Text += "6. AFGHANISTAN" + Environment.NewLine;
            this.textBox1.Text += "7. SHAM" + Environment.NewLine;
            this.textBox1.Text += "8. INDIA" + Environment.NewLine;
            this.textBox1.Text += "9. INDONESIA" + Environment.NewLine;
            this.textBox1.Text += "10. MALAISIA" + Environment.NewLine;
            this.textBox1.Text += "11. ISRAEL" + Environment.NewLine;
            this.textBox1.Text +="12. AMERICA" + Environment.NewLine;
            this.textBox1.Text += "13. UNITEDKINGDOM" + Environment.NewLine;
            this.textBox1.ReadOnly = true;
            this.textBox1.Enabled = false;
            //this.button172.Visible = false;
            //AUSTRALIA //NEPAL// BENGAL//IRAN IRAN AFGHANISTAN SHAM INDIA INDONESIA MALAISIA ISRAEL AMERICA
            this.Text = "R.K Game";
            this.button94.Text = "B";
            this.button92.Text = "N";
            this.button93.Text = "E";
            this.button91.Text = "G";
            this.button90.Text = "A";
            this.button89.Text = "L";


            this.button42.Text = "N";
            this.button41.Text = "E";
            this.button40.Text = "P";
            this.button39.Text = "A";
            this.button38.Text = "L";

            this.button167.Text = "S";
            this.button74.Text = "H";
            this.button85.Text = "A";
           // this.button156.Text = "T";

            this.button108.Text = "U";
            this.button107.Text = "N";
            this.button106.Text = "I";
            this.button105.Text = "T";
            this.button104.Text = "E";
            this.button103.Text = "D";
            this.button102.Text = "K";
            this.button101.Text = "I";
            this.button100.Text = "N";
            this.button99.Text = "G";
            this.button98.Text = "D";
            this.button97.Text = "O";
            this.button156.Text = "M";

            this.button141.Text = "M";
            this.button140.Text = "A";
            this.button139.Text = "L";
            this.button138.Text = "A";
            this.button137.Text = "I";
            this.button136.Text = "S";
            this.button135.Text = "I";
            this.button134.Text = "A";

            this.button2.Text = "A";
            this.button3.Text = "M";
            this.button4.Text = "E";
            this.button5.Text = "R";
            this.button6.Text = "I";
            this.button12.Text = "C";
            this.button11.Text = "A";

            
            this.button58.Text = "R";
            this.button47.Text = "A";
            this.button147.Text = "N";
            
            this.button17.Text = "N";
            this.button69.Text = "I";
            this.button68.Text = "S";
            this.button67.Text = "R";
            this.button66.Text = "A";
            this.button65.Text = "e";
            this.button64.Text = "L";
            this.button22.Text = "U";
            this.button21.Text = "S";
            this.button20.Text = "T";
            this.button19.Text = "R";
            this.button18.Text = "A";
            this.button17.Text = "L";
            this.button157.Text = "I";
            this.button15.Text = "A";
            this.button109.Text = "F";
            this.button110.Text = "G";
            this.button111.Text = "H";
            this.button112.Text = "A";
            this.button113.Text = "N";
            this.button114.Text = "I";
            this.button115.Text = "S";
            this.button116.Text = "T";
            this.button117.Text = "A";
            this.button118.Text = "N";

            this.button1.Text = "P";
            this.button23.Text = "A";
            this.button34.Text = "K";
            this.button69.Text = "I";
            this.button56.Text = "S";
            this.button43.Text = "T";
            this.button138.Text = "A";
            this.button125.Text = "N";

            this.button145.Text = "I";
            this.button13.Text = "N";
            this.button26.Text = "D";
            this.button63.Text = "I";
            this.button52.Text = "A";

            this.button146.Text = "N";
            this.button147.Text = "D";
            this.button150.Text = "O";
            this.button149.Text = "N";
            this.button148.Text = "E";
            this.button153.Text = "S";
            this.button152.Text = "I";
            this.button151.Text = "A";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Yellow;
            if (textBox2.Text == "")
            {
                textBox2.Text += "P";
            }
        }

        private void button172_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "PAKISTAN";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            this.button69.BackColor = Color.Yellow;
           
            if (textBox2.Text == "PAK")
            {
                textBox2.Text += "I";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text += "I";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text += "I";
            }
            
        }

        private void button145_Click(object sender, EventArgs e)
        {
            //this.textBox2.Text= this.button145.Text;
            //this.textBox3.Text = this.button145.Text;
            this.button145.BackColor = Color.Yellow;
            if (textBox9.Text == "")
            {
                textBox9.Text += "I";
            }
            if (textBox10.Text == "")
            {
                textBox10.Text += "I";
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button146_Click(object sender, EventArgs e)
        {
            //this.textBox3.Text += this.button146.Text;
            this.button146.BackColor = Color.Yellow;
            if (textBox10.Text == "I")
            {
                textBox10.Text += "N";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.button23.BackColor = Color.Yellow;
            if (textBox2.Text == "P")
            {
                textBox2.Text += "A";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text += "A";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.button34.BackColor = Color.Yellow;
            if (textBox2.Text == "PA")
            {
                textBox2.Text += "K";
            }
           
        }

        private void button56_Click(object sender, EventArgs e)
        {
            this.button56.BackColor = Color.Yellow;
            if (textBox2.Text == "PAKI")
            {
                textBox2.Text += "S";
            }
          
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.button43.BackColor = Color.Yellow;
            if (textBox2.Text == "PAKIS")
            {
                textBox2.Text += "T";
            }
            
        }

        private void button138_Click(object sender, EventArgs e)
        {
            this.button138.BackColor = Color.Yellow;
            if (textBox2.Text == "PAKIST")
            {
                textBox2.Text += "A";
            }
            if (textBox11.Text == "MAL")
            {
                textBox11.Text += "A";
            }
            //this.button138.BackColor = Color.Blue;
        }

        private void button125_Click(object sender, EventArgs e)
        {
            this.button125.BackColor = Color.Yellow;
            if (textBox2.Text == "PAKISTA")
            {
                textBox2.Text += "N";
                MessageBox.Show("You founded Pakistan Sucessfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Yellow;
            if (textBox13.Text == "")
            {
                textBox13.Text += "A";
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Yellow;
            if (textBox13.Text == "A")
            {
                textBox13.Text += "M";
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.BackColor = Color.Yellow;
            if (textBox13.Text == "AM")
            {
                textBox13.Text += "E";
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.BackColor = Color.Yellow;
            if (textBox13.Text == "AME")
            {
                textBox13.Text += "R";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.BackColor = Color.Yellow;
            if (textBox13.Text == "AMER")
            {
                textBox13.Text += "I";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button12.BackColor = Color.Yellow;
            if (textBox13.Text == "AMERI")
            {
                textBox13.Text += "C";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button11.BackColor = Color.Yellow;
            if (textBox13.Text == "AMERIC")
            {
                textBox13.Text += "A";
                MessageBox.Show("You founded America Sucessfully");
            }
        }

        private void button147_Click(object sender, EventArgs e)
        {
            this.button147.BackColor = Color.Yellow;
            if (textBox10.Text == "IN")
            {
                textBox10.Text += "D";
            }
        }

        private void button150_Click(object sender, EventArgs e)
        {
            this.button150.BackColor = Color.Yellow;
            this.button147.BackColor = Color.Yellow;
            if (textBox10.Text == "IND")
            {
                textBox10.Text += "O";
            }
        }

        private void button149_Click(object sender, EventArgs e)
        {
            this.button149.BackColor = Color.Yellow;
            if (textBox10.Text == "INDO")
            {
                textBox10.Text += "N";
            }
        }

        private void button148_Click(object sender, EventArgs e)
        {
            this.button148.BackColor = Color.Yellow;
            if (textBox10.Text == "INDON")
            {
                textBox10.Text += "E";
            }
        }

        private void button153_Click(object sender, EventArgs e)
        {
            this.button153.BackColor = Color.Yellow;
            if (textBox10.Text == "INDONE")
            {
                textBox10.Text += "S";
            }
        }

        private void button152_Click(object sender, EventArgs e)
        {
            this.button152.BackColor = Color.Yellow;
            if (textBox10.Text == "INDONES")
            {
                textBox10.Text += "I";
            }
        }

        private void button151_Click(object sender, EventArgs e)
        {
            this.button151.BackColor = Color.Yellow;
            if (textBox7.Text == "")
            {
                textBox7.Text += "A";
            }
            if (textBox10.Text == "INDONESI")
            {
                textBox10.Text += "A";
                MessageBox.Show("You founded Indonesia Sucessfully");
            }
        }

        private void button167_Click(object sender, EventArgs e)
        {
            this.button167.BackColor = Color.Yellow;
            if (textBox8.Text == "")
            {
                textBox8.Text += "S";
                
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            this.button74.BackColor = Color.Yellow;
            this.button167.BackColor = Color.Yellow;
            if (textBox8.Text == "S")
            {
                textBox8.Text += "H";
              }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            this.button85.BackColor = Color.Yellow;
            if (textBox8.Text == "SH")
            {
                textBox8.Text += "A";
            }
        }

        private void button156_Click(object sender, EventArgs e)
        {
            this.button156.BackColor = Color.Yellow;
            if (textBox8.Text == "SHA")
            {
                textBox8.Text += "M";
                MessageBox.Show("You founded Sham Sucessfully");
            }
            if (textBox14.Text == "UNITEDKINGDO")
            {
                textBox14.Text += "M";
                MessageBox.Show("You founded UNITEDKINGDOM Sucessfully");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            this.button58.BackColor = Color.Yellow;
            if (textBox6.Text == "I")
            {
                textBox6.Text += "R";
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.button47.BackColor = Color.Yellow;
            if (textBox6.Text == "IR")
            {
                textBox6.Text += "A";
            }
        }

        private void button144_Click(object sender, EventArgs e)
        {
            this.button144.BackColor = Color.Yellow;
            if (textBox6.Text == "IRA")
            {
                textBox6.Text += "N";
                MessageBox.Show("You finded Iran Successfully");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.button13.BackColor = Color.Yellow;
            if (textBox9.Text == "I")
            {
                textBox9.Text += "N";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.button26.BackColor = Color.Yellow;
            if (textBox9.Text == "IN")
            {
                textBox9.Text += "D";
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            this.button63.BackColor = Color.Yellow;
            if (textBox9.Text == "IND")
            {
                textBox9.Text += "I";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.button52.BackColor = Color.Yellow;
            if (textBox9.Text == "INDI")
            {
                textBox9.Text += "A";
                MessageBox.Show("You founded India Sucessfully");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.button42.BackColor = Color.Yellow;
            if (textBox4.Text == "")
            {
                this.textBox4.Text += "N";
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.button41.BackColor = Color.Yellow;
            if (textBox4.Text == "N")
            {
                this.textBox4.Text += "E";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.button40.BackColor = Color.Yellow;
            if (textBox4.Text == "NE")
            {
                this.textBox4.Text += "P";
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.button39.BackColor = Color.Yellow;
            this.button40.BackColor = Color.Yellow;
            if (textBox4.Text == "NEP")
            {
                this.textBox4.Text += "A";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.button38.BackColor = Color.Yellow;
            if (textBox4.Text == "NEPA")
            {
                this.textBox4.Text += "L";
                MessageBox.Show("You Finded Nepal Sucessfully");
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            this.button141.BackColor = Color.Yellow;
            if (textBox11.Text == "")
            {
                textBox11.Text += "M";
            }
        }

        private void button140_Click(object sender, EventArgs e)
        {
            this.button140.BackColor = Color.Yellow;
            if (textBox11.Text == "M")
            {
                textBox11.Text += "A";
            }
        }

        private void button139_Click(object sender, EventArgs e)
        {
            this.button139.BackColor = Color.Yellow;
            if (textBox11.Text == "MA")
            {
                textBox11.Text += "L";
            }
        }

        private void button137_Click(object sender, EventArgs e)
        {
            this.button137.BackColor = Color.Yellow;
            if (textBox11.Text == "MALA")
            {
                textBox11.Text += "I";
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            this.button136.BackColor = Color.Yellow;
            if (textBox11.Text == "MALAI")
            {
                textBox11.Text += "S";
            }
        }

        private void button135_Click(object sender, EventArgs e)
        {
            this.button135.BackColor = Color.Yellow;
            if (textBox11.Text == "MALAIS")
            {
                textBox11.Text += "I";
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            this.button134.BackColor = Color.Yellow;
            if (textBox11.Text == "MALAISI")
            {
                textBox11.Text += "A";
                MessageBox.Show("You finded Malaisia successfully");
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            this.button108.BackColor = Color.Yellow;
            if (textBox14.Text == "")
            {
                textBox14.Text += "U";
            }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            this.button107.BackColor = Color.Yellow;
            if (textBox14.Text == "U")
            {
                textBox14.Text += "N";
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            this.button106.BackColor = Color.Yellow;
            if (textBox14.Text == "UN")
            {
                textBox14.Text += "I";
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {
            this.button105.BackColor = Color.Yellow;
            if (textBox14.Text == "UNI")
            {
                textBox14.Text += "T";
            }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            this.button104.BackColor = Color.Yellow;
            if (textBox14.Text == "UNIT")
            {
                textBox14.Text += "E";
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            this.button103.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITE")
            {
                textBox14.Text += "D";
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {
            this.button102.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITED")
            {
                textBox14.Text += "K";
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            this.button101.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITEDK")
            {
                textBox14.Text += "I";
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            this.button100.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITEDKI")
            {
                textBox14.Text += "N";
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            this.button99.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITEDKIN")
            {
                textBox14.Text += "G";
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            this.button98.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITEDKING")
            {
                textBox14.Text += "D";
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            this.button97.BackColor = Color.Yellow;
            if (textBox14.Text == "UNITEDKINGD")
            {
                textBox14.Text += "O";
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            this.button109.BackColor = Color.Yellow;
            if (textBox7.Text == "A")
            {
                textBox7.Text += "F";
            }
        }

        private void button110_Click(object sender, EventArgs e)
        {
            this.button110.BackColor = Color.Yellow;
            if (textBox7.Text == "AF")
            {
                textBox7.Text += "G";
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            this.button111.BackColor = Color.Yellow;
            if (textBox7.Text == "AFG")
            {
                textBox7.Text += "H";
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            this.button112.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGH")
            {
                textBox7.Text += "A";
            }
        }

        private void button113_Click(object sender, EventArgs e)
        {
            this.button113.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHA")
            {
                textBox7.Text += "N";
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            this.button114.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHAN")
            {
                textBox7.Text += "I";
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.button115.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHANI")
            {
                textBox7.Text += "S";
            }
        }

        private void button116_Click(object sender, EventArgs e)
        {
            this.button116.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHANIS")
            {
                textBox7.Text += "T";
            }
        }

        private void button117_Click(object sender, EventArgs e)
        {
            this.button117.BackColor = Color.Yellow;
            this.button116.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHANIST")
            {
                textBox7.Text += "A";
            }
        }

        private void button118_Click(object sender, EventArgs e)
        {
            this.button118.BackColor = Color.Yellow;
            if (textBox7.Text == "AFGHANISTA")
            {
                textBox7.Text += "N";
                MessageBox.Show("You finded Afghanistan Successfully");
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            this.button94.BackColor = Color.Yellow;
            if (textBox5.Text == "")
            {
                textBox5.Text += "B"; 
            }
           
        }

        private void button93_Click(object sender, EventArgs e)
        {
            this.button93.BackColor = Color.Yellow;
            if (textBox5.Text == "B")
            {
                textBox5.Text += "E";
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            this.button92.BackColor = Color.Yellow;
            if (textBox5.Text == "BE")
            {
                textBox5.Text += "N";
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            this.button91.BackColor = Color.Yellow;
            if (textBox5.Text == "BEN")
            {
                textBox5.Text += "G";
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            this.button90.BackColor = Color.Yellow;
            if (textBox5.Text == "BENG")
            {
                textBox5.Text += "A";
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            this.button89.BackColor = Color.Yellow;

            if (textBox5.Text == "BENGA")
            {
                textBox5.Text += "L";
                MessageBox.Show("You Finded Bengal Sucessfully");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.button22.BackColor = Color.Yellow;
            if (textBox3.Text == "A")
            {
                textBox3.Text += "U";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.button21.BackColor = Color.Yellow;
            if (textBox3.Text == "AU" )
            {
                textBox3.Text += "S";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.button20.BackColor = Color.Yellow;
            if (textBox3.Text == "AUS")
            {
                textBox3.Text += "T";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.button19.BackColor = Color.Yellow;
            if (textBox3.Text == "AUST")
            {
                textBox3.Text += "R";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.button18.BackColor = Color.Yellow;
            if (textBox3.Text == "AUSTR")
            {
                textBox3.Text += "A";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.button17.BackColor = Color.Blue;
        }

        private void button157_Click(object sender, EventArgs e)
        {
            this.button157.BackColor = Color.Blue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button15.BackColor = Color.Blue;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.button17.BackColor = Color.Yellow;
            if (textBox3.Text == "AUSTRA")
            {
                textBox3.Text += "L";
            }
        }

        private void button157_Click_1(object sender, EventArgs e)
        {
            this.button157.BackColor = Color.Yellow;
            if (textBox3.Text == "AUSTRAL")
            {
                textBox3.Text += "I";
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.button15.BackColor = Color.Yellow;
            if (textBox3.Text == "AUSTRALI")
            {
                textBox3.Text += "A";
                MessageBox.Show("You finded Australia successfully ");
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            this.button68.BackColor = Color.Yellow;
            if (textBox12.Text == "I")
            {
                textBox12.Text += "S";
            }

        }

        private void button67_Click(object sender, EventArgs e)
        {
            this.button67.BackColor = Color.Yellow;
            if (textBox12.Text == "IS")
            {
                textBox12.Text += "R";
            }

        
        }


        private void button66_Click(object sender, EventArgs e)
        {
            this.button66.BackColor = Color.Yellow;
            if (textBox12.Text == "ISR")
            {
                textBox12.Text += "A";
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            this.button65.BackColor = Color.Yellow;
            if (textBox12.Text == "ISRA")
            {
                textBox12.Text += "E";
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            this.button64.BackColor = Color.Yellow;
            if (textBox12.Text == "ISRAE")
            {
                textBox12.Text += "L";
                MessageBox.Show("You founded Israel Sucessfully");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button173_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Yellow && button23.BackColor == Color.Yellow && button34.BackColor == Color.Yellow && button69.BackColor == Color.Yellow && button56.BackColor == Color.Yellow && button43.BackColor == Color.Yellow && button138.BackColor == Color.Yellow && button125.BackColor == Color.Yellow)
            { //PAk
               
                            button1.Enabled = true;
                            //button23.Enabled = true;
                            button34.Enabled = true;
                            button69.Enabled = true;
                            button56.Enabled = true;
                            button43.Enabled = true;
                            button138.Enabled = true;
                            button125.Enabled = true;
                            MessageBox.Show("Right Ans");
                      
                        
            }
            //else if()
            //{
            
            //}


            else
            {
                    MessageBox.Show("You Loose"); 
                }
                
            
            
        }

        private void button174_Click(object sender, EventArgs e)
        {
            if (button97.BackColor == Color.Yellow && button98.BackColor == Color.Yellow && button99.BackColor == Color.Yellow && button100.BackColor == Color.Yellow && button101.BackColor == Color.Yellow && button102.BackColor == Color.Yellow && button103.BackColor == Color.Yellow && button104.BackColor == Color.Yellow && button105.BackColor == Color.Yellow && button106.BackColor == Color.Yellow && button107.BackColor == Color.Yellow && button108.BackColor == Color.Yellow && button1.BackColor == Color.Yellow && button23.BackColor == Color.Yellow && button34.BackColor == Color.Yellow && button69.BackColor == Color.Yellow && button56.BackColor == Color.Yellow && button43.BackColor == Color.Yellow && button138.BackColor == Color.Yellow && button125.BackColor == Color.Yellow && button2.BackColor == Color.Yellow && button3.BackColor == Color.Yellow && button4.BackColor == Color.Yellow && button5.BackColor == Color.Yellow && button6.BackColor == Color.Yellow && button12.BackColor == Color.Yellow && button11.BackColor == Color.Yellow && button22.BackColor == Color.Yellow && button21.BackColor == Color.Yellow && button20.BackColor == Color.Yellow && button19.BackColor == Color.Yellow && button18.BackColor == Color.Yellow && button17.BackColor == Color.Yellow && button157.BackColor == Color.Yellow && button15.BackColor == Color.Yellow && button145.BackColor == Color.Yellow && button146.BackColor == Color.Yellow && button147.BackColor == Color.Yellow && button150.BackColor == Color.Yellow && button149.BackColor == Color.Yellow && button148.BackColor == Color.Yellow && button153.BackColor == Color.Yellow && button152.BackColor == Color.Yellow && button151.BackColor == Color.Yellow && button109.BackColor == Color.Yellow && button110.BackColor == Color.Yellow && button111.BackColor == Color.Yellow && button112.BackColor == Color.Yellow && button113.BackColor == Color.Yellow && button114.BackColor == Color.Yellow && button115.BackColor == Color.Yellow && button116.BackColor == Color.Yellow && button117.BackColor == Color.Yellow && button118.BackColor == Color.Yellow && button89.BackColor == Color.Yellow && button90.BackColor == Color.Yellow && button91.BackColor == Color.Yellow && button92.BackColor == Color.Yellow && button93.BackColor == Color.Yellow && button94.BackColor == Color.Yellow && button38.BackColor == Color.Yellow && button39.BackColor == Color.Yellow && button40.BackColor == Color.Yellow && button41.BackColor == Color.Yellow && button42.BackColor == Color.Yellow && button13.BackColor == Color.Yellow && button26.BackColor == Color.Yellow && button63.BackColor == Color.Yellow && button52.BackColor == Color.Yellow && button58.BackColor == Color.Yellow && button47.BackColor == Color.Yellow && button144.BackColor == Color.Yellow && button68.BackColor == Color.Yellow && button67.BackColor == Color.Yellow && button66.BackColor == Color.Yellow && button65.BackColor == Color.Yellow && button64.BackColor == Color.Yellow && button141.BackColor == Color.Yellow && button140.BackColor == Color.Yellow && button139.BackColor == Color.Yellow && button137.BackColor == Color.Yellow && button136.BackColor == Color.Yellow && button135.BackColor == Color.Yellow && button134.BackColor == Color.Yellow && button167.BackColor == Color.Yellow && button74.BackColor == Color.Yellow && button85.BackColor == Color.Yellow && button156.BackColor == Color.Yellow)
            {
                MessageBox.Show("You Win");
               
            }
            else { 
                MessageBox.Show("You Loose"); }
        }

        private void button171_Click(object sender, EventArgs e)
        {
             //AUSTRALIA //NEPAL// BENGAL//IRAN IRAN AFGHANISTAN SHAM INDIA INDONESIA MALAISIA ISRAEL AMERICA
            /* this.textBox1.Text = "FIND COUNTRIES NAME ?" + Environment.NewLine;
            this.textBox1.Text += "1.PAKISTAN " + Environment.NewLine;
            this.textBox1.Text += "2.AUSTRALIA" + Environment.NewLine;
            this.textBox1.Text += "3.NEPAL" + Environment.NewLine;
            this.textBox1.Text += "5. BENGAL" + Environment.NewLine;
             * 
            this.textBox1.Text += "6. IRAN" + Environment.NewLine;
            this.textBox1.Text += "7. AFGHANISTAN" + Environment.NewLine;
            this.textBox1.Text += "8. SHAM" + Environment.NewLine;
            this.textBox1.Text += "9. INDIA" + Environment.NewLine;
            this.textBox1.Text += "10. INDONESIA" + Environment.NewLine;
            this.textBox1.Text += "11. MALAISIA" + Environment.NewLine;
            this.textBox1.Text += "12. ISRAEL" + Environment.NewLine;
            this.textBox1.Text += "13. AMERICA" + Environment.NewLine;*/
            if (textBox2.Text == "PAKISTAN" && textBox3.Text == "AUSTRALIA" && textBox4.Text == "NEPAL" && textBox5.Text == "BENGAL" && textBox6.Text == "IRAN" && textBox7.Text == "AFGHANISTAN" && textBox8.Text == "SHAM" && textBox9.Text == "INDIA" && textBox10.Text == "INDONESIA" && textBox11.Text == "MALAISIA" && textBox12.Text == "ISRAEL" && textBox13.Text == "AMERICA" && textBox14.Text == "UNITEDKINGDOM")
            {
                MessageBox.Show("You Win");

            }
            else MessageBox.Show("You loose");
            }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox15.Text = System.DateTime.Today.ToString();

            //textBox15.Text = timer1.Interval();
           // textBox15.Text = Timer(t)
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}