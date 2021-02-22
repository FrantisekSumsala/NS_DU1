using System;
using System.Collections.Generic;
using System.Text;

namespace NS_DU1
{
    public class Controller
    {
        private Model Model { get; set; }

        private Form1 View { get; set; }

        private ApplicationState ApplicationState { get; set; }

        private PerceptronInput 

        public Controller(Model model, Form1 view)
        {
            Model = model;
            View = view;

            view.SetController(this);
            InitController();

            ApplicationState = ApplicationState.NotReady;
        }

        private void InitController()
        {
            View.InputFileSelected += LoadInputFile;
        }

        private void LoadInputFile(string inputFilePath)
        {
            PerceptronInput input = InputLoader.LoadPerceptronInput(inputFilePath);

            ApplicationState = ApplicationState.Ready;


        }

        private void ChangeAppState(ApplicationState newState)
        {
            ApplicationState = newState;
            Model.ApplicationState = newState;

            View.UpdateForNewAppState(Model);
        }

        private void ResetToInput()
        {

        }
    }
}
