﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)
        [Key]
        public int PlayerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,9, ErrorMessage ="the Number must be from 1 - 9")]
        public int Number { get; set; }
        [Required]
        public int Balance { get; set; }
    }
}