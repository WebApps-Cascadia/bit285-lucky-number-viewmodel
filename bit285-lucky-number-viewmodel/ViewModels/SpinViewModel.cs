using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        public Boolean isWinner { get; set; }
        public int[] Spinner { get; set; } = new int[3];
        public string Message { get; set; } = "Welcome";
        [Range(1, 9)]
        public int Number { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Balance { get; set; }


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