namespace DrawGeoFigures
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSqCircle = new System.Windows.Forms.Button();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(417, 358);
            this.DrawingPanel.TabIndex = 1;
            this.DrawingPanel.Click += new System.EventHandler(this.DrawingPanel_Click);
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(444, 12);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(100, 23);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(574, 12);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(100, 23);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y";
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(444, 73);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(100, 23);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Высота";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(444, 38);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(574, 38);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(444, 99);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.Text = "30";
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(574, 73);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(100, 23);
            this.labelWidth.TabIndex = 10;
            this.labelWidth.Text = "Ширина";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(574, 99);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 11;
            this.textBoxWidth.Text = "50";
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(444, 237);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(230, 133);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSqCircle);
            this.panel1.Controls.Add(this.radioButtonTriangle);
            this.panel1.Controls.Add(this.radioButtonRectangle);
            this.panel1.Controls.Add(this.radioButtonEllipse);
            this.panel1.Location = new System.Drawing.Point(444, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 91);
            this.panel1.TabIndex = 14;
            // 
            // buttonSqCircle
            // 
            this.buttonSqCircle.Location = new System.Drawing.Point(121, 4);
            this.buttonSqCircle.Name = "buttonSqCircle";
            this.buttonSqCircle.Size = new System.Drawing.Size(106, 83);
            this.buttonSqCircle.TabIndex = 4;
            this.buttonSqCircle.Text = "Круг \\ Квадрат";
            this.buttonSqCircle.UseVisualStyleBackColor = true;
            this.buttonSqCircle.Click += new System.EventHandler(this.buttonSqCircle_Click);
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.Location = new System.Drawing.Point(3, 63);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(112, 24);
            this.radioButtonTriangle.TabIndex = 3;
            this.radioButtonTriangle.Text = "Треугольник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.Location = new System.Drawing.Point(3, 33);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(112, 24);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.Checked = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(3, 3);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(112, 24);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Эллипс";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.DrawingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Фигуры";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonSqCircle;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;

        #endregion
    }
}