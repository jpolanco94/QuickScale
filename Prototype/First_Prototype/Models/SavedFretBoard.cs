﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickScaleProtoType.Models
{
    public class SavedFretBoard
    {
        //[Key]
        public int FretboardID { get; set; }
        public int NumberOfFrets { get; set; }
        public int NumberOfStrings { get; set; }
        public string FirstStringNote { get; set; }
        public string SecondStringNote { get; set; }
        public string ThirdStringNote { get; set; }
        public string FourthStringNote { get; set; }
        public string FifthStringNote { get; set; }
        public string SixthStringNote { get; set; }
        public string SeventhStringNote { get; set; }
        public string EigthStringNote { get; set; }
        //I am still not sure if Entity Framework implicitly makes foreign keys so I
        //told it to make one
        //public int UserID { get; set; }
        //[ForeignKey("UserID")]
        //public User User { get; set; }
        //public int ScaleID { get; set; }
        //[ForeignKey("ScaleID")]
        //public Scale Scale { get; set; }
    }
}
