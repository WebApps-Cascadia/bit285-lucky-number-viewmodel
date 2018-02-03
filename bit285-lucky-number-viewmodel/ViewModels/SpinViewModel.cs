using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
      //  public string Message { get; set; }
        //TODO: Add the properties needed by the Spin View
        [Display(Name = "SPIN")]
        public int[] Spinner = new int[3];

       // private int _random;
        public bool isWinner;

        [Required]
        [Display(Name = "Lucky Number")]
        //number is the chosen number and if matches 
        //one of the spin array numbers is a winner
        public int Number { get; set; }

        //Makes Balance a require field and displays the word Balance
        //makes the balance be a currency field
        // [Required]
        [Display(Name = "Balance")]
        [DataType(DataType.Currency)]
        public double Balance { get; set; }

        //displays a message to the user if the balance is equal
        //to or less than 0 the game is over
        public string Message
        {
            get
           {
               return Balance <= 0 ? "GAME OVER" : "";
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