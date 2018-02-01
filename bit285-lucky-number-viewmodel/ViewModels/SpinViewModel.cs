using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        //Modify the ViewModels/SpinViewModel.cs class 
        //to include ALL properties used by its View (see Spin.cshtml)
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public bool isWinner { get; set; }
        public int[] Spinner { get; set; }
        public string Message { get; set; }

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