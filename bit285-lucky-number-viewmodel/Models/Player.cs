using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)
        //Modify the Models/Player.cs class to include properties associated 
        //with Player Entity (Name, Number, Balance). 
        //make them public, get setter methods
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public int PlayerId { get; set; }

      



    }
}