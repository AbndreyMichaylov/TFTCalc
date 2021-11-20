using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.Models.BaseClasses;

namespace TFTCalc.Models
{
    public class ComboItem : ModelBase
    {
        public int ToComboCount { get; set; }
        public string Effect { get; set; }

        public List<HeroAttribute> HeroAttribute { get; set; } = new List<HeroAttribute>();
    }
}
