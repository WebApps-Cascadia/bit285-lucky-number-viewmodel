using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        private Random _random = new Random();
        private int[] _spinner = new int[3];

        [Required]
        public int Number { get; set; }
        [Required]
        public decimal Balance { get; set; }
        public bool isWinner { get; set; }
        public string Message
        {
            get
            {
                return Balance <= 0 ? "GAME OVER" : "";
            }
        }
        public int[] Spinner
        {
            get
            {
                //Spin up three random numbers
                for (int i = 0; i < 3; i++)
                {
                    _spinner[i] = _random.Next(0, 10);
                }
                return _spinner;
            }
        }
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