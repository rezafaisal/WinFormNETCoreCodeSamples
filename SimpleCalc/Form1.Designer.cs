namespace SimpleCalc
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
            this.labelBil1 = new System.Windows.Forms.Label();
            this.labelBil2 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.textBoxBil1 = new System.Windows.Forms.TextBox();
            this.textBoxBil2 = new System.Windows.Forms.TextBox();
            this.textBoxHasil = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBil1
            // 
            this.labelBil1.AutoSize = true;
            this.labelBil1.Location = new System.Drawing.Point(12, 38);
            this.labelBil1.Name = "labelBil1";
            this.labelBil1.Size = new System.Drawing.Size(126, 32);
            this.labelBil1.TabIndex = 0;
            this.labelBil1.Text = "Bilangan 1";
            // 
            // labelBil2
            // 
            this.labelBil2.AutoSize = true;
            this.labelBil2.Location = new System.Drawing.Point(13, 100);
            this.labelBil2.Name = "labelBil2";
            this.labelBil2.Size = new System.Drawing.Size(126, 32);
            this.labelBil2.TabIndex = 1;
            this.labelBil2.Text = "Bilangan 2";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(15, 172);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(65, 32);
            this.labelHasil.TabIndex = 5;
            this.labelHasil.Text = "Hasil";
            // 
            // textBoxBil1
            // 
            this.textBoxBil1.Location = new System.Drawing.Point(171, 31);
            this.textBoxBil1.Name = "textBoxBil1";
            this.textBoxBil1.Size = new System.Drawing.Size(443, 39);
            this.textBoxBil1.TabIndex = 6;
            // 
            // textBoxBil2
            // 
            this.textBoxBil2.Location = new System.Drawing.Point(171, 100);
            this.textBoxBil2.Name = "textBoxBil2";
            this.textBoxBil2.Size = new System.Drawing.Size(443, 39);
            this.textBoxBil2.TabIndex = 7;
            // 
            // textBoxHasil
            // 
            this.textBoxHasil.Location = new System.Drawing.Point(171, 165);
            this.textBoxHasil.Name = "textBoxHasil";
            this.textBoxHasil.Size = new System.Drawing.Size(443, 39);
            this.textBoxHasil.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(171, 230);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 60);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(257, 230);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(64, 60);
            this.buttonSub.TabIndex = 10;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(343, 230);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(64, 60);
            this.buttonMul.TabIndex = 11;
            this.buttonMul.Text = "x";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(432, 230);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(182, 60);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxHasil);
            this.Controls.Add(this.textBoxBil2);
            this.Controls.Add(this.textBoxBil1);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelBil2);
            this.Controls.Add(this.labelBil1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBil1;
        private System.Windows.Forms.Label labelBil2;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.TextBox textBoxBil1;
        private System.Windows.Forms.TextBox textBoxBil2;
        private System.Windows.Forms.TextBox textBoxHasil;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonReset;
    }
}

