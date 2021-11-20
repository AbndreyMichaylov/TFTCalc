using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.Models.BaseClasses;

namespace TFTCalc.Models
{
    public class Hero : ModelBase
    {
        public string Name { get; set; }
        public byte[] Icon { get; set;  }
        public int Cost { get; set; }
        public List<HeroAttribute> Attributes { get; set;  } = new List<HeroAttribute>();
    }
}
