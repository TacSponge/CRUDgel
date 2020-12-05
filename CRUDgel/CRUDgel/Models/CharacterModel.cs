using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDgel.Models
{
    public class CharacterModel
    {
        public int Id { get; set; } = 1; 
        public string ForeName { get; set; } = "Bart";
        public string Surname { get; set; } = "StrongMan";
        public int Punch { get; set; } = 9;
        public int Speak { get; set; } = 7;
        public int  Think { get; set; } = 3;
        public string Race { get; set; } = "Elf";
        public string Class { get; set; } = "PunchPunch";
        public int level { get; set; } = 3;

    }
}
