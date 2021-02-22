namespace NS_DU1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.IterationNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weightsGrid = new System.Windows.Forms.DataGridView();
            this.WeightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightMinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightMaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.learningRateInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stepDisplayDurationInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trainSetGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.testSetGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testSetGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 576);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML files|*.xml";
            this.openFileDialog1.Title = "Choose input file";
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(336, 12);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(108, 23);
            this.openFileDialogButton.TabIndex = 1;
            this.openFileDialogButton.Text = "Select input file";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.selectInputFile);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(93, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(255, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(174, 12);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(12, 12);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 5;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.Location = new System.Drawing.Point(450, 16);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(245, 15);
            this.inputFileNameLabel.TabIndex = 6;
            this.inputFileNameLabel.Text = "Currently selected input file: ungabunga.xml ";
            // 
            // IterationNumberLabel
            // 
            this.IterationNumberLabel.AutoSize = true;
            this.IterationNumberLabel.Location = new System.Drawing.Point(6, 22);
            this.IterationNumberLabel.Name = "IterationNumberLabel";
            this.IterationNumberLabel.Size = new System.Drawing.Size(120, 15);
            this.IterationNumberLabel.TabIndex = 7;
            this.IterationNumberLabel.Text = "Iteration number: 999";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightsGrid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.learningRateInput);
            this.groupBox1.Controls.Add(this.IterationNumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 235);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perceptron state";
            // 
            // weightsGrid
            // 
            this.weightsGrid.AllowUserToAddRows = false;
            this.weightsGrid.AllowUserToDeleteRows = false;
            this.weightsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeightName,
            this.WeightValue,
            this.WeightMinValue,
            this.WeightMaxValue});
            this.weightsGrid.Location = new System.Drawing.Point(6, 69);
            this.weightsGrid.Name = "weightsGrid";
            this.weightsGrid.ReadOnly = true;
            this.weightsGrid.RowHeadersVisible = false;
            this.weightsGrid.Size = new System.Drawing.Size(597, 160);
            this.weightsGrid.TabIndex = 9;
            this.weightsGrid.Text = "dataGridView1";
            // 
            // WeightName
            // 
            this.WeightName.HeaderText = "Weight";
            this.WeightName.Name = "WeightName";
            this.WeightName.ReadOnly = true;
            // 
            // WeightValue
            // 
            this.WeightValue.HeaderText = "Value";
            this.WeightValue.Name = "WeightValue";
            this.WeightValue.ReadOnly = true;
            // 
            // WeightMinValue
            // 
            this.WeightMinValue.HeaderText = "Min";
            this.WeightMinValue.Name = "WeightMinValue";
            this.WeightMinValue.ReadOnly = true;
            // 
            // WeightMaxValue
            // 
            this.WeightMaxValue.HeaderText = "Max";
            this.WeightMaxValue.Name = "WeightMaxValue";
            this.WeightMaxValue.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Learning rate: ";
            // 
            // learningRateInput
            // 
            this.learningRateInput.Location = new System.Drawing.Point(94, 40);
            this.learningRateInput.Name = "learningRateInput";
            this.learningRateInput.Size = new System.Drawing.Size(100, 23);
            this.learningRateInput.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stepDisplayDurationInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(627, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 628);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perceptron Vizualization";
            // 
            // stepDisplayDurationInput
            // 
            this.stepDisplayDurationInput.Location = new System.Drawing.Point(163, 16);
            this.stepDisplayDurationInput.Name = "stepDisplayDurationInput";
            this.stepDisplayDurationInput.Size = new System.Drawing.Size(100, 23);
            this.stepDisplayDurationInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Step display duration (ms): ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trainSetGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 192);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Train Set";
            // 
            // trainSetGrid
            // 
            this.trainSetGrid.AllowUserToAddRows = false;
            this.trainSetGrid.AllowUserToDeleteRows = false;
            this.trainSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainSetGrid.Location = new System.Drawing.Point(6, 22);
            this.trainSetGrid.Name = "trainSetGrid";
            this.trainSetGrid.ReadOnly = true;
            this.trainSetGrid.Size = new System.Drawing.Size(596, 160);
            this.trainSetGrid.TabIndex = 0;
            this.trainSetGrid.Text = "dataGridView2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.testSetGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 189);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Set";
            // 
            // testSetGrid
            // 
            this.testSetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testSetGrid.Location = new System.Drawing.Point(6, 22);
            this.testSetGrid.Name = "testSetGrid";
            this.testSetGrid.Size = new System.Drawing.Size(597, 160);
            this.testSetGrid.TabIndex = 10;
            this.testSetGrid.Text = "dataGridView3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputFileNameLabel);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.openFileDialogButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainSetGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testSetGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.Label IterationNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox learningRateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView weightsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightMinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightMaxValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView trainSetGrid;
        private System.Windows.Forms.DataGridView testSetGrid;
        private System.Windows.Forms.TextBox stepDisplayDurationInput;
        private System.Windows.Forms.Label label5;

    }
}

