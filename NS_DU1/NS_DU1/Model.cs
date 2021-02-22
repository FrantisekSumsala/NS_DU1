using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class Model
    {
        public int IterationNumber { get; set; }
        public float LearningRate { get; set; }
        public int StepDisplayDuration { get; set; }
        public string InputFileName { get; set; }
        public ICollection<PerceptronWeight> PerceptronWeights { get; set; }
        public ICollection<TrainSetElement> TrainSetElements { get; set; }
        public ICollection<TestSetElement> TestSetElements { get; set; }
        public ApplicationState ApplicationState { get; set; }

    }
}
