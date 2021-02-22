using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class PerceptronWeight
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }

        public PerceptronWeight(string name, float value, float minValue, float maxValue)
        {
            Name = name;
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public PerceptronWeight()
        {
        }
    }
}
