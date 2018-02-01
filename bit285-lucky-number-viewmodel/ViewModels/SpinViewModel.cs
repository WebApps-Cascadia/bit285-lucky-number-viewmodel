using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        public int number;
        public decimal balance;
        public int[] spinner;
        public string message;
        public bool isWinner = false;

        Random _random = new Random();

        // This method updates values for Spinner and isWinner based on wheter a Lucky Number was rolled
        public void spin()
        {
           
            //Spin up random numbers
            for (int i = 0; i < spinner.Length; i++)
            {
                spinner[i] = _random.Next(0, 10);
                if (spinner[i] == number)
                    isWinner = true;
            }

        }
    }

}