
namespace ConsoleAppMain
{
    partial class DoWhileConsole1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.buttonRea = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRea
            // 
            this.buttonRea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRea.Location = new System.Drawing.Point(461, 138);
            this.buttonRea.Name = "buttonRea";
            this.buttonRea.Size = new System.Drawing.Size(96, 39);
            this.buttonRea.TabIndex = 0;
            this.buttonRea.Text = "Кнопка";
            this.buttonRea.UseVisualStyleBackColor = true;
            this.buttonRea.Click += new System.EventHandler(this.buttonRea_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(831, 44);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(71, 30);
            this.textBoxN.TabIndex = 1;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(539, 261);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(64, 25);
            this.labelRes.TabIndex = 2;
            this.labelRes.Text = "label1";
            this.labelRes.Visible = false;
            this.labelRes.Click += new System.EventHandler(this.labelRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввводьте числа по одному, натискаючи кнопку після кожного введення. Введення заве" +
    "ршується нулем:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(466, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сума:";
            // 
            // DoWhileConsole1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonRea);
            this.Name = "DoWhileConsole1";
            this.Text = "DoWhileConsole1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRea;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}