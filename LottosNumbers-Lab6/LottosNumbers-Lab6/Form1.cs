using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Devon Sihra

namespace LottosNumbers_Lab6
{
    public partial class Form1 : Form
    {
        int[] playerNum = new int[7];
        int[] RanNum = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayerButton_Click(object sender, EventArgs e)
        {
            string display = "";

            lblWinningNumbers.Text = "00 00 00 00 00 00 00";

            GenerateNumbers(playerNum);

            Array.Sort(playerNum);

            display = DisplayResults(playerNum);

            
            lblPlayerNumbers.Text = display;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int winCount = 0;
            string display = "";

         //   lblPlayerNumbers.Text = "00 00 00 00 00 00 00";

            GenerateNumbers(RanNum);

            Array.Sort(RanNum);

            display = DisplayResults(RanNum);

            lblWinningNumbers.Text = display;

            winCount = CompareTwoArrays(playerNum, RanNum);

            lblMatch.Text = winCount.ToString("D2");

        }

        private void GenerateNumbers(int[] numberArray)
        {
            int count = 0, i = 0;
            int luckyNumber = 0;
            Random lucky = new Random();


            while (count < numberArray.Length)
            {
                luckyNumber = lucky.Next(1, 50);


                for (i = 0; i < numberArray.Length; i++)
                {
                    if (numberArray[i] == luckyNumber)
                        break;
                }
                if (i == numberArray.Length)
                {
                    numberArray[count] = luckyNumber;
                    count++;
                }
            }
        }


        private string DisplayResults(int[] numberArray)
        {
          
            string display = "  ";

            foreach (int number in numberArray)
                display += number.ToString("D2") + "  ";

            return display;
        }

        private int CompareTwoArrays(int[] array1, int[] array2)
        {
           
            int numberMatching = 0;

        
            foreach (int value in array1)
            {
                if (Array.BinarySearch(array2, value) >= 0)
                    numberMatching++;  
            }

            return numberMatching;
        }
    }
}
