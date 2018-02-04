using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        public int Number;
        public decimal Balance;
        public int[] Spinner = new int[3];
        public string Message = "";
        public bool isWinner = false;

        Random _random = new Random();

        // This method updates values for Spinner and isWinner based on wheter a Lucky Number was rolled
        public void Spin()
        {
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