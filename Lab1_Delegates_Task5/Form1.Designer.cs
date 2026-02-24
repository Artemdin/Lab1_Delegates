namespace Lab1_Delegates_Task5
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
            btnOpacity = new Button();
            btnColor = new Button();
            btnHello = new Button();
            chbOpacity = new CheckBox();
            btnSuper = new Button();
            chbColor = new CheckBox();
            chbHello = new CheckBox();
            SuspendLayout();
            // 
            // btnOpacity
            // 
            btnOpacity.Location = new Point(22, 40);
            btnOpacity.Name = "btnOpacity";
            btnOpacity.Size = new Size(116, 29);
            btnOpacity.TabIndex = 0;
            btnOpacity.Text = "Прозорість";
            btnOpacity.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(156, 40);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(117, 29);
            btnColor.TabIndex = 1;
            btnColor.Text = "Колір тла";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(279, 40);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(114, 29);
            btnHello.TabIndex = 2;
            btnHello.Text = "hello World";
            btnHello.UseVisualStyleBackColor = true;
            // 
            // chbOpacity
            // 
            chbOpacity.AutoSize = true;
            chbOpacity.Location = new Point(22, 167);
            chbOpacity.Name = "chbOpacity";
            chbOpacity.Size = new Size(317, 24);
            chbOpacity.TabIndex = 3;
            chbOpacity.Text = "супермегакнопка поглинає \"Прозорість\"";
            chbOpacity.UseVisualStyleBackColor = true;
            chbOpacity.CheckedChanged += chbOpacity_CheckedChanged;
            // 
            // btnSuper
            // 
            btnSuper.Location = new Point(84, 84);
            btnSuper.Name = "btnSuper";
            btnSuper.Size = new Size(241, 53);
            btnSuper.TabIndex = 4;
            btnSuper.Text = "супермегакнопка";
            btnSuper.UseVisualStyleBackColor = true;
            btnSuper.Click += buttonSuper;
            // 
            // chbColor
            // 
            chbColor.AutoSize = true;
            chbColor.Location = new Point(22, 197);
            chbColor.Name = "chbColor";
            chbColor.Size = new Size(303, 24);
            chbColor.TabIndex = 5;
            chbColor.Text = "супермегакнопка поглинає \"Колір тла\"";
            chbColor.UseVisualStyleBackColor = true;
            chbColor.CheckedChanged += chbColor_CheckedChanged;
            // 
            // chbHello
            // 
            chbHello.AutoSize = true;
            chbHello.Location = new Point(22, 227);
            chbHello.Name = "chbHello";
            chbHello.Size = new Size(318, 24);
            chbHello.TabIndex = 6;
            chbHello.Text = "супермегакнопка поглинає \"Hello World\"";
            chbHello.UseVisualStyleBackColor = true;
            chbHello.CheckedChanged += chbHello_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 284);
            Controls.Add(chbHello);
            Controls.Add(chbColor);
            Controls.Add(btnSuper);
            Controls.Add(chbOpacity);
            Controls.Add(btnHello);
            Controls.Add(btnColor);
            Controls.Add(btnOpacity);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpacity;
        private Button btnColor;
        private Button btnHello;
        private CheckBox chbOpacity;
        private Button btnSuper;
        private CheckBox chbColor;
        private CheckBox chbHello;
    }
}
