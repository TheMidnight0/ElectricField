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
            components = new System.ComponentModel.Container();
            field = new Panel();
            drawEFieldButton = new Button();
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
            drawingStyleCheck = new CheckBox();
            label1 = new Label();
            addNegative = new Button();
            drawEqPFieldButton = new Button();
            updateField = new System.Windows.Forms.Timer(components);
            EFieldCheck = new CheckBox();
            EqPFieldCheck = new CheckBox();
            label2 = new Label();
            densityBox = new TextBox();
            densityBar = new TrackBar();
            label3 = new Label();
            fieldRowsBox = new TextBox();
            fieldRowsBar = new TrackBar();
            label4 = new Label();
            fieldColsBox = new TextBox();
            fieldColsBar = new TrackBar();
            label5 = new Label();
            clearFieldButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pointSizeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linesCountBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stepLengthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldRowsBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldColsBar).BeginInit();
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
            // drawEFieldButton
            // 
            drawEFieldButton.BackgroundImage = Properties.Resources.Elecrtic_Field;
            drawEFieldButton.BackgroundImageLayout = ImageLayout.Zoom;
            drawEFieldButton.FlatStyle = FlatStyle.Flat;
            drawEFieldButton.Font = new Font("Comic Sans MS", 10F);
            drawEFieldButton.Location = new Point(541, 388);
            drawEFieldButton.Name = "drawEFieldButton";
            drawEFieldButton.Size = new Size(95, 80);
            drawEFieldButton.TabIndex = 1;
            drawEFieldButton.UseVisualStyleBackColor = true;
            drawEFieldButton.Click += DrawEFieldButton_Click;
            // 
            // addPositive
            // 
            addPositive.BackgroundImage = Properties.Resources.Positive;
            addPositive.BackgroundImageLayout = ImageLayout.Zoom;
            addPositive.FlatStyle = FlatStyle.Flat;
            addPositive.Font = new Font("Comic Sans MS", 20F);
            addPositive.Location = new Point(755, 388);
            addPositive.Name = "addPositive";
            addPositive.Size = new Size(95, 80);
            addPositive.TabIndex = 2;
            addPositive.UseVisualStyleBackColor = true;
            addPositive.Click += AddPositive_Click;
            // 
            // removePoint
            // 
            removePoint.FlatStyle = FlatStyle.Flat;
            removePoint.Font = new Font("Comic Sans MS", 16F);
            removePoint.Location = new Point(335, 388);
            removePoint.Name = "removePoint";
            removePoint.Size = new Size(184, 80);
            removePoint.TabIndex = 3;
            removePoint.Text = "Удалить";
            removePoint.UseVisualStyleBackColor = true;
            removePoint.Click += RemovePoint_Click;
            // 
            // pointSizeLabel
            // 
            pointSizeLabel.AutoSize = true;
            pointSizeLabel.Font = new Font("Comic Sans MS", 14F);
            pointSizeLabel.Location = new Point(12, 16);
            pointSizeLabel.Name = "pointSizeLabel";
            pointSizeLabel.Size = new Size(165, 33);
            pointSizeLabel.TabIndex = 4;
            pointSizeLabel.Text = "Размер точек";
            // 
            // pointSizeBar
            // 
            pointSizeBar.Location = new Point(12, 52);
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
            pointSizeBox.Location = new Point(244, 52);
            pointSizeBox.Name = "pointSizeBox";
            pointSizeBox.Size = new Size(55, 45);
            pointSizeBox.TabIndex = 6;
            pointSizeBox.Text = "30";
            pointSizeBox.TextChanged += PointSizeBox_TextChanged;
            // 
            // linesCountBox
            // 
            linesCountBox.Font = new Font("Comic Sans MS", 16F);
            linesCountBox.Location = new Point(244, 147);
            linesCountBox.Name = "linesCountBox";
            linesCountBox.Size = new Size(55, 45);
            linesCountBox.TabIndex = 9;
            linesCountBox.Text = "12";
            linesCountBox.TextChanged += LinesCountBox_TextChanged;
            // 
            // linesCountBar
            // 
            linesCountBar.Location = new Point(12, 147);
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
            linesCountLabel.Location = new Point(12, 111);
            linesCountLabel.Name = "linesCountLabel";
            linesCountLabel.Size = new Size(231, 33);
            linesCountLabel.TabIndex = 7;
            linesCountLabel.Text = "Количество линий";
            // 
            // stepLengthBox
            // 
            stepLengthBox.Font = new Font("Comic Sans MS", 16F);
            stepLengthBox.Location = new Point(244, 242);
            stepLengthBox.Name = "stepLengthBox";
            stepLengthBox.Size = new Size(65, 45);
            stepLengthBox.TabIndex = 12;
            stepLengthBox.Text = "5";
            stepLengthBox.TextChanged += StepLengthBox_TextChanged;
            // 
            // stepLengthBar
            // 
            stepLengthBar.Location = new Point(12, 242);
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
            stepLengthLabel.Location = new Point(12, 206);
            stepLengthLabel.Name = "stepLengthLabel";
            stepLengthLabel.Size = new Size(163, 33);
            stepLengthLabel.TabIndex = 10;
            stepLengthLabel.Text = "Длинна шага";
            // 
            // drawingStyleCheck
            // 
            drawingStyleCheck.AutoSize = true;
            drawingStyleCheck.Font = new Font("Comic Sans MS", 13F);
            drawingStyleCheck.Location = new Point(22, 392);
            drawingStyleCheck.Name = "drawingStyleCheck";
            drawingStyleCheck.Size = new Size(241, 34);
            drawingStyleCheck.TabIndex = 13;
            drawingStyleCheck.Text = "Рисовать регулярно";
            drawingStyleCheck.UseVisualStyleBackColor = true;
            drawingStyleCheck.CheckedChanged += DrawingStyle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F);
            label1.Location = new Point(782, 471);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 14;
            label1.Text = "Добавить";
            // 
            // addNegative
            // 
            addNegative.BackgroundImage = Properties.Resources.Negative;
            addNegative.BackgroundImageLayout = ImageLayout.Zoom;
            addNegative.FlatStyle = FlatStyle.Flat;
            addNegative.Font = new Font("Comic Sans MS", 16F);
            addNegative.Location = new Point(856, 388);
            addNegative.Name = "addNegative";
            addNegative.Size = new Size(95, 80);
            addNegative.TabIndex = 15;
            addNegative.UseVisualStyleBackColor = true;
            addNegative.Click += AddNegative_Click;
            // 
            // drawEqPFieldButton
            // 
            drawEqPFieldButton.BackgroundImage = Properties.Resources.Equipotential_Field;
            drawEqPFieldButton.BackgroundImageLayout = ImageLayout.Zoom;
            drawEqPFieldButton.FlatStyle = FlatStyle.Flat;
            drawEqPFieldButton.Font = new Font("Comic Sans MS", 9F);
            drawEqPFieldButton.Location = new Point(640, 388);
            drawEqPFieldButton.Name = "drawEqPFieldButton";
            drawEqPFieldButton.Size = new Size(95, 80);
            drawEqPFieldButton.TabIndex = 16;
            drawEqPFieldButton.UseVisualStyleBackColor = true;
            drawEqPFieldButton.Click += DrawEqPFieldButton_Click;
            // 
            // updateField
            // 
            updateField.Interval = 1000;
            updateField.Tick += UpdateField_Tick;
            // 
            // EFieldCheck
            // 
            EFieldCheck.AutoSize = true;
            EFieldCheck.Checked = true;
            EFieldCheck.CheckState = CheckState.Checked;
            EFieldCheck.Enabled = false;
            EFieldCheck.Location = new Point(22, 430);
            EFieldCheck.Name = "EFieldCheck";
            EFieldCheck.Size = new Size(180, 24);
            EFieldCheck.TabIndex = 18;
            EFieldCheck.Text = "Электрическое поле";
            EFieldCheck.UseVisualStyleBackColor = true;
            EFieldCheck.Visible = false;
            // 
            // EqPFieldCheck
            // 
            EqPFieldCheck.AutoSize = true;
            EqPFieldCheck.Checked = true;
            EqPFieldCheck.CheckState = CheckState.Checked;
            EqPFieldCheck.Enabled = false;
            EqPFieldCheck.Location = new Point(22, 460);
            EqPFieldCheck.Name = "EqPFieldCheck";
            EqPFieldCheck.Size = new Size(206, 24);
            EqPFieldCheck.TabIndex = 19;
            EqPFieldCheck.Text = "Поле эквипотенциалей";
            EqPFieldCheck.UseVisualStyleBackColor = true;
            EqPFieldCheck.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16F);
            label2.Location = new Point(561, 471);
            label2.Name = "label2";
            label2.Size = new Size(158, 38);
            label2.TabIndex = 20;
            label2.Text = "Построить";
            // 
            // densityBox
            // 
            densityBox.Font = new Font("Comic Sans MS", 16F);
            densityBox.Location = new Point(1198, 246);
            densityBox.Name = "densityBox";
            densityBox.Size = new Size(98, 45);
            densityBox.TabIndex = 29;
            densityBox.Text = "0,0005";
            densityBox.TextChanged += DensityBox_TextChanged;
            // 
            // densityBar
            // 
            densityBar.Location = new Point(966, 246);
            densityBar.Maximum = 500;
            densityBar.Minimum = 1;
            densityBar.Name = "densityBar";
            densityBar.Size = new Size(226, 56);
            densityBar.TabIndex = 28;
            densityBar.TickStyle = TickStyle.Both;
            densityBar.Value = 1;
            densityBar.Scroll += DensityBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F);
            label3.Location = new Point(966, 210);
            label3.Name = "label3";
            label3.Size = new Size(293, 28);
            label3.TabIndex = 27;
            label3.Text = "Плотность эквипотенциалей";
            // 
            // fieldRowsBox
            // 
            fieldRowsBox.Font = new Font("Comic Sans MS", 16F);
            fieldRowsBox.Location = new Point(1198, 151);
            fieldRowsBox.Name = "fieldRowsBox";
            fieldRowsBox.Size = new Size(55, 45);
            fieldRowsBox.TabIndex = 26;
            fieldRowsBox.Text = "50";
            fieldRowsBox.TextChanged += FieldRowsBox_TextChanged;
            // 
            // fieldRowsBar
            // 
            fieldRowsBar.Location = new Point(966, 151);
            fieldRowsBar.Maximum = 300;
            fieldRowsBar.Minimum = 5;
            fieldRowsBar.Name = "fieldRowsBar";
            fieldRowsBar.Size = new Size(226, 56);
            fieldRowsBar.TabIndex = 25;
            fieldRowsBar.TickStyle = TickStyle.Both;
            fieldRowsBar.Value = 50;
            fieldRowsBar.Scroll += FieldRowsBar_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14F);
            label4.Location = new Point(966, 115);
            label4.Name = "label4";
            label4.Size = new Size(164, 33);
            label4.TabIndex = 24;
            label4.Text = "Строки сетки";
            // 
            // fieldColsBox
            // 
            fieldColsBox.Font = new Font("Comic Sans MS", 16F);
            fieldColsBox.Location = new Point(1198, 56);
            fieldColsBox.Name = "fieldColsBox";
            fieldColsBox.Size = new Size(55, 45);
            fieldColsBox.TabIndex = 23;
            fieldColsBox.Text = "50";
            fieldColsBox.TextChanged += FieldColsBox_TextChanged;
            // 
            // fieldColsBar
            // 
            fieldColsBar.Location = new Point(966, 56);
            fieldColsBar.Maximum = 300;
            fieldColsBar.Minimum = 5;
            fieldColsBar.Name = "fieldColsBar";
            fieldColsBar.Size = new Size(226, 56);
            fieldColsBar.TabIndex = 22;
            fieldColsBar.TickStyle = TickStyle.Both;
            fieldColsBar.Value = 50;
            fieldColsBar.Scroll += FieldColsBar_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14F);
            label5.Location = new Point(966, 20);
            label5.Name = "label5";
            label5.Size = new Size(187, 33);
            label5.TabIndex = 21;
            label5.Text = "Столбцы сетки";
            // 
            // clearFieldButton
            // 
            clearFieldButton.FlatStyle = FlatStyle.Flat;
            clearFieldButton.Location = new Point(335, 474);
            clearFieldButton.Name = "clearFieldButton";
            clearFieldButton.Size = new Size(184, 29);
            clearFieldButton.TabIndex = 30;
            clearFieldButton.Text = "Очистить поле";
            clearFieldButton.UseVisualStyleBackColor = true;
            clearFieldButton.Click += ClearFieldButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1314, 513);
            Controls.Add(clearFieldButton);
            Controls.Add(densityBox);
            Controls.Add(densityBar);
            Controls.Add(label3);
            Controls.Add(fieldRowsBox);
            Controls.Add(fieldRowsBar);
            Controls.Add(label4);
            Controls.Add(fieldColsBox);
            Controls.Add(fieldColsBar);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(EqPFieldCheck);
            Controls.Add(EFieldCheck);
            Controls.Add(drawEqPFieldButton);
            Controls.Add(addNegative);
            Controls.Add(label1);
            Controls.Add(drawingStyleCheck);
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
            Controls.Add(drawEFieldButton);
            Controls.Add(field);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 9F);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Визуализация электрического поля и эквипотенциалей";
            ((System.ComponentModel.ISupportInitialize)pointSizeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)linesCountBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)stepLengthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldRowsBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldColsBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel field;
        private Button drawEFieldButton;
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
        private CheckBox drawingStyleCheck;
        private Label label1;
        private Button addNegative;
        private Button drawEqPFieldButton;
        private System.Windows.Forms.Timer updateField;
        private CheckBox EFieldCheck;
        private CheckBox EqPFieldCheck;
        private Label label2;
        private TextBox densityBox;
        private TrackBar densityBar;
        private Label label3;
        private TextBox fieldRowsBox;
        private TrackBar fieldRowsBar;
        private Label label4;
        private TextBox fieldColsBox;
        private TrackBar fieldColsBar;
        private Label label5;
        private Button clearFieldButton;
    }
}
