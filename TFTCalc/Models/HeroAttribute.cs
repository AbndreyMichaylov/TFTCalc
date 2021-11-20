using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.Models.BaseClasses;

namespace TFTCalc.Models
{
    public class HeroAttribute : ModelBase
    {
        public string Name { get; set; }

        public byte[] Icon { get; set; }

        public List<Hero> Hero { get; set; } = new List<Hero>();

        public List<ComboItem> ComboItems { get; set; } = new List<ComboItem>();
    }
}
