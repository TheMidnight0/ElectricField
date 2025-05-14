namespace ElectricField
{
    partial class Main
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
            field = new Panel();
            drawButton = new Button();
            addPositive = new Button();
            removePoint = new Button();
            pointSizeLabel = new Label();
            pointSizeBar = new TrackBar();
            pointSizeBox = new TextBox();
            linesCountBox = new TextBox();
            linesCountBar = new TrackBar();
            linesCountLabel = new Label();
            stepLengthBox = new TextBox();
            stepLengthBar = new TrackBar();
            stepLengthLabel = new Label();
            drawingStyle = new CheckBox();
            label1 = new Label();
            addNegative = new Button();
            ((System.ComponentModel.ISupportInitialize)pointSizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linesCountBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stepLengthBar).BeginInit();
            SuspendLayout();
            // 
            // field
            // 
            field.BackColor = Color.White;
            field.BackgroundImageLayout = ImageLayout.None;
            field.BorderStyle = BorderStyle.Fixed3D;
            field.Location = new Point(335, 12);
            field.Name = "field";
            field.Size = new Size(616, 370);
            field.TabIndex = 0;
            // 
            // drawButton
            // 
            drawButton.FlatStyle = FlatStyle.Flat;
            drawButton.Font = new Font("Comic Sans MS", 16F);
            drawButton.Location = new Point(541, 388);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(204, 55);
            drawButton.TabIndex = 1;
            drawButton.Text = "Рисовать";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += DrawButton_Click;
            // 
            // addPositive
            // 
            addPositive.FlatStyle = FlatStyle.Flat;
            addPositive.Font = new Font("Comic Sans MS", 20F);
            addPositive.Location = new Point(751, 388);
            addPositive.Name = "addPositive";
            addPositive.Size = new Size(100, 55);
            addPositive.TabIndex = 2;
            addPositive.Text = "+";
            addPositive.UseVisualStyleBackColor = true;
            addPositive.Click += AddPositive_Click;
            // 
            // removePoint
            // 
            removePoint.FlatStyle = FlatStyle.Flat;
            removePoint.Font = new Font("Comic Sans MS", 16F);
            removePoint.Location = new Point(335, 388);
            removePoint.Name = "removePoint";
            removePoint.Size = new Size(200, 55);
            removePoint.TabIndex = 3;
            removePoint.Text = "Удалить";
            removePoint.UseVisualStyleBackColor = true;
            removePoint.Click += RemovePoint_Click;
            // 
            // pointSizeLabel
            // 
            pointSizeLabel.AutoSize = true;
            pointSizeLabel.Font = new Font("Comic Sans MS", 14F);
            pointSizeLabel.Location = new Point(12, 15);
            pointSizeLabel.Name = "pointSizeLabel";
            pointSizeLabel.Size = new Size(165, 33);
            pointSizeLabel.TabIndex = 4;
            pointSizeLabel.Text = "Размер точек";
            // 
            // pointSizeBar
            // 
            pointSizeBar.Location = new Point(12, 51);
            pointSizeBar.Maximum = 100;
            pointSizeBar.Minimum = 10;
            pointSizeBar.Name = "pointSizeBar";
            pointSizeBar.Size = new Size(226, 56);
            pointSizeBar.TabIndex = 5;
            pointSizeBar.TickStyle = TickStyle.Both;
            pointSizeBar.Value = 30;
            pointSizeBar.Scroll += PointSizeBar_Scroll;
            // 
            // pointSizeBox
            // 
            pointSizeBox.Font = new Font("Comic Sans MS", 16F);
            pointSizeBox.Location = new Point(244, 51);
            pointSizeBox.Name = "pointSizeBox";
            pointSizeBox.Size = new Size(55, 45);
            pointSizeBox.TabIndex = 6;
            pointSizeBox.Text = "30";
            pointSizeBox.TextChanged += PointSizeBox_TextChanged;
            // 
            // linesCountBox
            // 
            linesCountBox.Font = new Font("Comic Sans MS", 16F);
            linesCountBox.Location = new Point(244, 146);
            linesCountBox.Name = "linesCountBox";
            linesCountBox.Size = new Size(55, 45);
            linesCountBox.TabIndex = 9;
            linesCountBox.Text = "12";
            linesCountBox.TextChanged += LinesCountBox_TextChanged;
            // 
            // linesCountBar
            // 
            linesCountBar.Location = new Point(12, 146);
            linesCountBar.Maximum = 100;
            linesCountBar.Minimum = 5;
            linesCountBar.Name = "linesCountBar";
            linesCountBar.Size = new Size(226, 56);
            linesCountBar.TabIndex = 8;
            linesCountBar.TickStyle = TickStyle.Both;
            linesCountBar.Value = 12;
            linesCountBar.Scroll += LinesCountBar_Scroll;
            // 
            // linesCountLabel
            // 
            linesCountLabel.AutoSize = true;
            linesCountLabel.Font = new Font("Comic Sans MS", 14F);
            linesCountLabel.Location = new Point(12, 110);
            linesCountLabel.Name = "linesCountLabel";
            linesCountLabel.Size = new Size(231, 33);
            linesCountLabel.TabIndex = 7;
            linesCountLabel.Text = "Количество линий";
            // 
            // stepLengthBox
            // 
            stepLengthBox.Font = new Font("Comic Sans MS", 16F);
            stepLengthBox.Location = new Point(244, 241);
            stepLengthBox.Name = "stepLengthBox";
            stepLengthBox.Size = new Size(65, 45);
            stepLengthBox.TabIndex = 12;
            stepLengthBox.Text = "5";
            stepLengthBox.TextChanged += StepLengthBox_TextChanged;
            // 
            // stepLengthBar
            // 
            stepLengthBar.Location = new Point(12, 241);
            stepLengthBar.Maximum = 300;
            stepLengthBar.Minimum = 10;
            stepLengthBar.Name = "stepLengthBar";
            stepLengthBar.Size = new Size(231, 56);
            stepLengthBar.TabIndex = 11;
            stepLengthBar.TickStyle = TickStyle.Both;
            stepLengthBar.Value = 50;
            stepLengthBar.Scroll += StepLengthBar_Scroll;
            // 
            // stepLengthLabel
            // 
            stepLengthLabel.AutoSize = true;
            stepLengthLabel.Font = new Font("Comic Sans MS", 14F);
            stepLengthLabel.Location = new Point(12, 205);
            stepLengthLabel.Name = "stepLengthLabel";
            stepLengthLabel.Size = new Size(163, 33);
            stepLengthLabel.TabIndex = 10;
            stepLengthLabel.Text = "Длинна шага";
            // 
            // drawingStyle
            // 
            drawingStyle.AutoSize = true;
            drawingStyle.Font = new Font("Comic Sans MS", 12F);
            drawingStyle.Location = new Point(22, 411);
            drawingStyle.Name = "drawingStyle";
            drawingStyle.Size = new Size(277, 32);
            drawingStyle.TabIndex = 13;
            drawingStyle.Text = "Рисовать по обновлению";
            drawingStyle.UseVisualStyleBackColor = true;
            drawingStyle.CheckedChanged += DrawingStyle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F);
            label1.Location = new Point(780, 446);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 14;
            label1.Text = "Добавить";
            // 
            // addNegative
            // 
            addNegative.FlatStyle = FlatStyle.Flat;
            addNegative.Font = new Font("Comic Sans MS", 16F);
            addNegative.Location = new Point(857, 388);
            addNegative.Name = "addNegative";
            addNegative.Size = new Size(94, 55);
            addNegative.TabIndex = 15;
            addNegative.Text = "-";
            addNegative.UseVisualStyleBackColor = true;
            addNegative.Click += AddNegative_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(972, 487);
            Controls.Add(addNegative);
            Controls.Add(label1);
            Controls.Add(drawingStyle);
            Controls.Add(stepLengthBox);
            Controls.Add(stepLengthBar);
            Controls.Add(stepLengthLabel);
            Controls.Add(linesCountBox);
            Controls.Add(linesCountBar);
            Controls.Add(linesCountLabel);
            Controls.Add(pointSizeBox);
            Controls.Add(pointSizeBar);
            Controls.Add(pointSizeLabel);
            Controls.Add(removePoint);
            Controls.Add(addPositive);
            Controls.Add(drawButton);
            Controls.Add(field);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 9F);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Визуализация электрического поля";
            ((System.ComponentModel.ISupportInitialize)pointSizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)linesCountBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)stepLengthBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel field;
        private Button drawButton;
        private Button addPositive;
        private Button removePoint;
        private Label pointSizeLabel;
        private TrackBar pointSizeBar;
        private TextBox pointSizeBox;
        private TextBox linesCountBox;
        private TrackBar linesCountBar;
        private Label linesCountLabel;
        private TextBox stepLengthBox;
        private TrackBar stepLengthBar;
        private Label stepLengthLabel;
        private CheckBox drawingStyle;
        private Label label1;
        private Button addNegative;
    }
}
