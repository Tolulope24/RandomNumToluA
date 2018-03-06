/*
 * Created by: Tolu Adebayo
 * Created on: 06-03-2017
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Numbers
 * This program generates random numbers when the user clicks on the button.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumToluA
{
    public partial class frmRandomNumbers : Form
    {
        public frmRandomNumbers()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Identify The constants 
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();
            //Generate a Random Number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            //Add the random number to the label
            lblNumberAnswer.Text = "The number is:    " + Convert.ToString(aRandomNumber);
        }
    }
}
