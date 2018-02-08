using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        public bool isWinner { get; set; }
        int[] Spinner = new int[3];
        decimal _balance;

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
       
        public decimal Balance
        {
            set
            {
                _balance = value;
            }
            get
            {
                if (Spinner[0] == Number || Spinner[1] == Number || Spinner[2] == Number)
                {
                    _balance += 2;
                }
                return _balance;
            }
        }

        public string Name { get; set; }

        public string Message
        {
            get
            {
                return _balance <= 0 ? "GAME OVER" : "";
            }
        }
        public int Number { get; set; }
        
    }

}