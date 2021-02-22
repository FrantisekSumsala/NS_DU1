using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class Controller
    {
        private Model Model { get; set; }

        private Form1 View { get; set; }

        public Controller(Model model, Form1 view)
        {
            Model = model;
            View = view;

            view.SetController(this);
            InitController();
        }

        private void InitController()
        {
            View.InputFileSelected += LoadInputFile;
        }

        private void LoadInputFile(string inputFilePath)
        {
            PerceptronInput input = InputLoader.LoadPerceptronInput(inputFilePath);

        }
    }
}
