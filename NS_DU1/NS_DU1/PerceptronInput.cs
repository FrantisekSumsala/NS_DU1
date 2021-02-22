using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class PerceptronInput
    {
        public float LearningRate { get; set; }
        public ICollection<PerceptronWeight> Weights { get; set; }
        public ICollection<TrainSetElement> TrainSet { get; set; }
        public ICollection<TestSetElement> TestSet { get; set; }

    }
}
