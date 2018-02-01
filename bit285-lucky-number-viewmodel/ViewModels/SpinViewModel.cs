using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        public SpinViewModel() { }
        public SpinViewModel (decimal n, decimal b)
        {
            Number = n;
            Balance = b;
        }
        //TODO: Add the properties needed by the Spin View
        public int[] Spinner = new int[3];
        public decimal Balance;
        public bool isWinner;
        public decimal Number;
        public string Message;
        // This method updates values for Spinner and isWinner based on wheter a Lucky Number was rolled
        public void spin()
        {
           Random _random = new Random();
           isWinner = false;
            //Spin up random numbers
            for (int i = 0; i < Spinner.Length; i++)
            {
                Spinner[i] = _random.Next(0, 10);
                if (Spinner[i] == Number)
                    isWinner = true;
            }

        }
    }

}