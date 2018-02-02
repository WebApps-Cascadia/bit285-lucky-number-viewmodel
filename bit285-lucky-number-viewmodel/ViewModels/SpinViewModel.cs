using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.ViewModels
{
    public class SpinViewModel
    {
        //TODO: Add the properties needed by the Spin View
        private int[] _Spinner = new int[3];
        private Random rnd = new Random();
        public int[] Spinner
        {
            get
            {
                for (int i = 0; i < _Spinner.Length; i++)
                {
                    _Spinner[i] = rnd.Next(0, 10);
                }
                return _Spinner;
            }
        }
    }
    public int Number { get; set; }
    public int Balance { get; set; }
    public string Message
    {
        get; {
            return Balance < 0 ? "Game Over" : "";
        }

    }
    public bool isWinner { get; set; }

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

