using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NS_DU1
{
    public partial class Form1 : Form
    {
        private Model Model { get; set; }
        private Controller Controller { get; set; }

        public event Action<string> InputFileSelected;

        public Form1(Model model)
        {
            InitializeComponent();

            Model = model;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
        }

        public void SetController(Controller controller)
        {
            this.Controller = controller;
        }

        private void selectInputFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                InputFileSelected?.Invoke(openFileDialog1.FileName);
        }





    }
}
