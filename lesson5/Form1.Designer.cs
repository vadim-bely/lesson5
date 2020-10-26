namespace lesson5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lableWidth = new System.Windows.Forms.Label();
            this.lableColor = new System.Windows.Forms.Label();
            this.lableFilling = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelPx = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxBack = new System.Windows.Forms.ComboBox();
            this.groupBoxFigure = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonQuadrate = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxFigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lableWidth
            // 
            this.lableWidth.AutoSize = true;
            this.lableWidth.Location = new System.Drawing.Point(44, 44);
            this.lableWidth.Name = "lableWidth";
            this.lableWidth.Size = new System.Drawing.Size(99, 17);
            this.lableWidth.TabIndex = 0;
            this.lableWidth.Text = "Line width (px)";
            // 
            // lableColor
            // 
            this.lableColor.AutoSize = true;
            this.lableColor.Location = new System.Drawing.Point(77, 77);
            this.lableColor.Name = "lableColor";
            this.lableColor.Size = new System.Drawing.Size(70, 17);
            this.lableColor.TabIndex = 1;
            this.lableColor.Text = "Line color";
            // 
            // lableFilling
            // 
            this.lableFilling.AutoSize = true;
            this.lableFilling.Location = new System.Drawing.Point(68, 112);
            this.lableFilling.Name = "lableFilling";
            this.lableFilling.Size = new System.Drawing.Size(79, 17);
            this.lableFilling.TabIndex = 2;
            this.lableFilling.Text = "Filling color";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(157, 44);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(33, 22);
            this.textBoxWidth.TabIndex = 3;
            this.textBoxWidth.Text = "1";
            // 
            // labelPx
            // 
            this.labelPx.AutoSize = true;
            this.labelPx.BackColor = System.Drawing.Color.Transparent;
            this.labelPx.Location = new System.Drawing.Point(187, 46);
            this.labelPx.Name = "labelPx";
            this.labelPx.Size = new System.Drawing.Size(22, 17);
            this.labelPx.TabIndex = 4;
            this.labelPx.Text = "px";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(157, 77);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(111, 24);
            this.comboBoxColor.TabIndex = 5;
            // 
            // comboBoxBack
            // 
            this.comboBoxBack.FormattingEnabled = true;
            this.comboBoxBack.Location = new System.Drawing.Point(157, 109);
            this.comboBoxBack.Name = "comboBoxBack";
            this.comboBoxBack.Size = new System.Drawing.Size(111, 24);
            this.comboBoxBack.TabIndex = 6;
            // 
            // groupBoxFigure
            // 
            this.groupBoxFigure.Controls.Add(this.button1);
            this.groupBoxFigure.Controls.Add(this.radioButtonTriangle);
            this.groupBoxFigure.Controls.Add(this.radioButtonQuadrate);
            this.groupBoxFigure.Controls.Add(this.radioButtonCircle);
            this.groupBoxFigure.Location = new System.Drawing.Point(362, 44);
            this.groupBoxFigure.Name = "groupBoxFigure";
            this.groupBoxFigure.Size = new System.Drawing.Size(244, 241);
            this.groupBoxFigure.TabIndex = 7;
            this.groupBoxFigure.TabStop = false;
            this.groupBoxFigure.Text = "Figure";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(23, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.Location = new System.Drawing.Point(15, 95);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(104, 24);
            this.radioButtonTriangle.TabIndex = 2;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuadrate
            // 
            this.radioButtonQuadrate.Location = new System.Drawing.Point(15, 65);
            this.radioButtonQuadrate.Name = "radioButtonQuadrate";
            this.radioButtonQuadrate.Size = new System.Drawing.Size(104, 24);
            this.radioButtonQuadrate.TabIndex = 1;
            this.radioButtonQuadrate.TabStop = true;
            this.radioButtonQuadrate.Text = "Quadrate";
            this.radioButtonQuadrate.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.Location = new System.Drawing.Point(15, 33);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(71, 24);
            this.radioButtonCircle.TabIndex = 0;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 186);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxFigure);
            this.Controls.Add(this.comboBoxBack);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelPx);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.lableFilling);
            this.Controls.Add(this.lableColor);
            this.Controls.Add(this.lableWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFigure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lableFilling;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.RadioButton radioButtonTriangle;

        private System.Windows.Forms.RadioButton radioButtonQuadrate;

        private System.Windows.Forms.RadioButton radioButtonCircle;

        private System.Windows.Forms.GroupBox groupBoxFigure;

        private System.Windows.Forms.ComboBox comboBoxBack;

        #endregion

        private System.Windows.Forms.Label lableWidth;
        private System.Windows.Forms.Label lableColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelPx;
        private System.Windows.Forms.ComboBox comboBoxColor;
    }
}

