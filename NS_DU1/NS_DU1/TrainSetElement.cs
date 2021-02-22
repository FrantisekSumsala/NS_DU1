using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class TrainSetElement
    {
        public ICollection<float> Inputs { get; set; }
        public float ExpectedOutput { get; set; }
        public float CurrentOutput { get; set; }
    }
}
