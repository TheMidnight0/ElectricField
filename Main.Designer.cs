namespace QuadrupoleElectricField
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
            drawField = new Button();
            addPoint = new Button();
            removePoint = new Button();
            SuspendLayout();
            // 
            // field
            // 
            field.BackColor = SystemColors.ButtonHighlight;
            field.BorderStyle = BorderStyle.Fixed3D;
            field.Location = new System.Drawing.Point(32, 12);
            field.Name = "field";
            field.Size = new Size(408, 221);
            field.TabIndex = 0;
            // 
            // drawField
            // 
            drawField.FlatStyle = FlatStyle.Flat;
            drawField.Location = new System.Drawing.Point(159, 271);
            drawField.Name = "drawField";
            drawField.Size = new Size(147, 55);
            drawField.TabIndex = 1;
            drawField.Text = "Рисовать";
            drawField.UseVisualStyleBackColor = true;
            // 
            // addPoint
            // 
            addPoint.FlatStyle = FlatStyle.Flat;
            addPoint.Location = new System.Drawing.Point(312, 271);
            addPoint.Name = "addPoint";
            addPoint.Size = new Size(128, 55);
            addPoint.TabIndex = 2;
            addPoint.Text = "Добавить";
            addPoint.UseVisualStyleBackColor = true;
            addPoint.Click += AddPoint_Click;
            // 
            // removePoint
            // 
            removePoint.FlatStyle = FlatStyle.Flat;
            removePoint.Location = new System.Drawing.Point(32, 271);
            removePoint.Name = "removePoint";
            removePoint.Size = new Size(121, 55);
            removePoint.TabIndex = 3;
            removePoint.Text = "Удалить";
            removePoint.UseVisualStyleBackColor = true;
            removePoint.Click += RemovePoint_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(900, 450);
            Controls.Add(removePoint);
            Controls.Add(addPoint);
            Controls.Add(drawField);
            Controls.Add(field);
            Font = new Font("Comic Sans MS", 9F);
            Name = "Main";
            Text = "Квадрупольные линии поля";
            ResumeLayout(false);
        }

        #endregion

        private Panel field;
        private Button drawField;
        private Button addPoint;
        private Button removePoint;
    }
}
