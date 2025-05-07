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
            DrawButton = new Button();
            addPoint = new Button();
            SuspendLayout();
            // 
            // field
            // 
            field.BackColor = SystemColors.ActiveBorder;
            field.Location = new System.Drawing.Point(127, 32);
            field.Name = "field";
            field.Size = new Size(264, 221);
            field.TabIndex = 0;
            // 
            // DrawButton
            // 
            DrawButton.FlatStyle = FlatStyle.Flat;
            DrawButton.Location = new System.Drawing.Point(218, 302);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(94, 29);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "Рисовать";
            DrawButton.UseVisualStyleBackColor = true;
            // 
            // addPoint
            // 
            addPoint.Location = new System.Drawing.Point(368, 297);
            addPoint.Name = "addPoint";
            addPoint.Size = new Size(94, 29);
            addPoint.TabIndex = 2;
            addPoint.Text = "Добавить";
            addPoint.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(addPoint);
            Controls.Add(DrawButton);
            Controls.Add(field);
            Font = new Font("Comic Sans MS", 9F);
            Name = "Main";
            Text = "Квадрупольные линии поля";
            ResumeLayout(false);
        }

        #endregion

        private Panel field;
        private Button DrawButton;
        private Button addPoint;
    }
}
