﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFun.Data
{
    public class Bowler
    {
        [Key]
        public int BowlerID { get; set; }
        [ForeignKey("TeamID")]
        public int TeamID { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }        
        public string? BowlerState { get; set; }
        public string? BowlerZip {  get; set; }
        public string? BowlerPhoneNumber { get; set; }


    }
}