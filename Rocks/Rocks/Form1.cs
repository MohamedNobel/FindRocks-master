using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-- Summry--/
            //-- declare 2 char variable so i can search for the A and B Elements of gem rocks --//
            //-- one int variable to store the user Number form UI  --//
            //-- one char Array to containt the the User String Elements Letters from UI --//  
            //-- make any letters enter by user Lower case If it Upper case and deal with The Final Result at  "LetterLTxt" --//
            int RocksNumber ;
            char ElementA = 'a';
            char ElementB = 'b';
            LetterLTxt.Text = LetterTxt.Text.ToLower();
            char[] charLetter;
            //----------------------------------------------------------------//
            //-- use of if Condition to check for Our Number and Letter --//
            //-- the number must be 1=<Number<=100 and the Letters L=<6 --//
            //- our char Array will be equel to Letter string 
            //-- pass the result to Text Box To Find and Count The ElementA and ElementB --//
            if (string.IsNullOrEmpty(NumberTxt.Text) || string.IsNullOrEmpty(LetterTxt.Text))
            {
                MessageBox.Show("Enter Rock Number and Elements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         
              
            }
            else if (!NumberTxt.Text.All(char.IsDigit) || !LetterTxt.Text.All(char.IsLetter))
            {
                MessageBox.Show("Enter Rock Number and Elements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    RocksNumber = Convert.ToInt16(NumberTxt.Text); 
                    charLetter = LetterLTxt.Text.ToCharArray();
                    if (RocksNumber >=1 && RocksNumber<=100 && charLetter.Count()<=6)
                    {
                        if (charLetter.Contains(ElementA) && charLetter.Contains(ElementB))
                        {
                            MessageBox.Show("this is Gem Rock with Two Element", "Rocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ATxt.Text = "1";
                            BTxt.Text = "1";
                            ABTxt.Text = "2";
                            ATtxt.Text = charLetter.Count(txt => txt == ElementA).ToString();
                            BTtxt.Text = charLetter.Count(txt => txt == ElementB).ToString();
                            ABTtext.Text = (Convert.ToInt16(ATtxt.Text) + Convert.ToInt16(BTtxt.Text)).ToString();
                        }
                        else if (charLetter.Contains(ElementA) || charLetter.Contains(ElementB))
                        {
                            MessageBox.Show("this is Gem Rock with One Element", "Rocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ATxt.Text = Convert.ToInt32( charLetter.Contains(ElementA)).ToString();
                            BTxt.Text = Convert.ToInt32(charLetter.Contains(ElementB)).ToString();
                            ABTxt.Text = "1";
                            ATtxt.Text = charLetter.Count(txt => txt == ElementA).ToString();
                            BTtxt.Text = charLetter.Count(txt => txt == ElementB).ToString();
                            ABTtext.Text = (Convert.ToInt32(ATtxt.Text) + Convert.ToInt32(BTtxt.Text)).ToString();
                        }
                       
                        else
                        {
                            MessageBox.Show("this is Normal Rock", "Rocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ATxt.Text = "0";
                            BTxt.Text = "0";
                            ABTxt.Text = "0";
                            ATtxt.Text="0";
                            BTtxt.Text="0";
                            ABTtext.Text = "0";
                            
                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("the Rock Number Or Elements not right , enter rock number between 1 and 100 , so element between 1 to 6 letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

        }

        private void ATxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

    

        

       
    }
}
