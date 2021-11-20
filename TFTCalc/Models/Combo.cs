using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.Models.BaseClasses;

namespace TFTCalc.Models
{
    public class Combo : ModelBase
    {
        public List<ComboItem> Combos { get; set; } = new List<ComboItem>();
    }
}
