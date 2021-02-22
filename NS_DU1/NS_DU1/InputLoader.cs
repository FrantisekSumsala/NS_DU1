using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml;

namespace NS_DU1
{
    public class InputLoader
    {
        public static PerceptronInput LoadPerceptronInput(string inputFilePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(inputFilePath);
            XmlNode root = doc.DocumentElement;
            XmlNode perceptronNode = root.SelectSingleNode(".//perceptron");

            PerceptronInput perceptronInput = new PerceptronInput();

            // weights
            XmlNodeList inputDescriptionNodes = perceptronNode.SelectNodes(".//inputDescriptions");
            XmlNode learningRateNode = perceptronNode.SelectSingleNode(".//lerningRate");
            XmlNodeList weightNodes = perceptronNode.SelectNodes(".//weights//weight");

            perceptronInput.LearningRate = float.Parse(learningRateNode.InnerText, CultureInfo.InvariantCulture);

            // weight0
            ICollection<PerceptronWeight> inputWeights = new List<PerceptronWeight>();
            PerceptronWeight weight0 = new PerceptronWeight();
            weight0.Name = "weight0";
            weight0.Value = float.Parse(weightNodes[0].InnerText, CultureInfo.InvariantCulture);
            inputWeights.Add(weight0);

            // input weights
            for (int i = 0; i < inputDescriptionNodes.Count; i++)
            {
                PerceptronWeight weight = new PerceptronWeight();

                XmlNode weightNode = weightNodes[i+1];
                weight.Value = float.Parse(weightNode.InnerText, CultureInfo.InvariantCulture);

                XmlNode inputDescriptionNode = inputDescriptionNodes[i];
                XmlNode maxNode = inputDescriptionNode.SelectSingleNode(".//maximum");
                XmlNode minNode = inputDescriptionNode.SelectSingleNode(".//minimum");
                XmlNode nameNode = inputDescriptionNode.SelectSingleNode(".//name");

                weight.MaxValue = float.Parse(maxNode.InnerText, CultureInfo.InvariantCulture);
                weight.MinValue = float.Parse(minNode.InnerText, CultureInfo.InvariantCulture);
                weight.Name = nameNode.InnerText;

                inputWeights.Add(weight);
            }

            perceptronInput.Weights = inputWeights;

            // train set
            ICollection<TrainSetElement> trainSetElements = new List<TrainSetElement>();
            XmlNode trainSetNode = root.SelectSingleNode(".//TrainSet");
            XmlNodeList trainSetElementNodes = trainSetNode.SelectNodes(".//element");
            foreach (XmlNode trainSetElementNode in trainSetElementNodes)
            {
                TrainSetElement trainSetElement = new TrainSetElement();
                ICollection<float> inputValues = new List<float>();

                XmlNodeList inputNodes = trainSetElementNode.SelectNodes(".//inputs//value");
                foreach (XmlNode inputValueNode in inputNodes)
                {
                    inputValues.Add(float.Parse(inputValueNode.InnerText, CultureInfo.InvariantCulture));
                }
                trainSetElement.Inputs = inputValues;

                XmlNode expectedOutputNode = trainSetElementNode.SelectSingleNode(".//output");
                trainSetElement.ExpectedOutput = float.Parse(expectedOutputNode.InnerText, CultureInfo.InvariantCulture);


                trainSetElements.Add(trainSetElement);
            }

            perceptronInput.TrainSet = trainSetElements;


            // test set
            ICollection<TestSetElement> testSetElements = new List<TestSetElement>();
            XmlNode testSetNode = root.SelectSingleNode(".//TestSet");
            XmlNodeList testSetElementNodes = testSetNode.SelectNodes(".//element");
            foreach (XmlNode testSetElementNode in testSetElementNodes)
            {
                TestSetElement testSetElement = new TestSetElement();
                ICollection<float> inputValues = new List<float>();

                XmlNodeList inputNodes = testSetElementNode.SelectNodes(".//inputs//value");
                foreach (XmlNode inputValueNode in inputNodes)
                {
                    inputValues.Add(float.Parse(inputValueNode.InnerText, CultureInfo.InvariantCulture));
                }
                testSetElement.Inputs = inputValues;


                testSetElements.Add(testSetElement);
            }

            perceptronInput.TestSet = testSetElements;


            return perceptronInput;
        }
    }
}
