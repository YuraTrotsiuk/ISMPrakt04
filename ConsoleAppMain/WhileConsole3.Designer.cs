
namespace ConsoleAppMain
{
    partial class WhileConsole3
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
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.buttonRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP.Location = new System.Drawing.Point(53, 99);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(39, 23);
            this.labelP.TabIndex = 0;
            this.labelP.Text = "p =";
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP.Location = new System.Drawing.Point(88, 99);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 27);
            this.textBoxP.TabIndex = 1;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(57, 148);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(131, 31);
            this.buttonRes.TabIndex = 2;
            this.buttonRes.Text = "Обчислити";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "s =";
            this.label1.Visible = false;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Location = new System.Drawing.Point(104, 225);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(62, 23);
            this.labelS.TabIndex = 4;
            this.labelS.Text = "label2";
            this.labelS.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "day =";
            this.label3.Visible = false;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDay.Location = new System.Drawing.Point(107, 264);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(62, 23);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "label4";
            this.labelDay.Visible = false;
            // 
            // WhileConsole3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelP);
            this.Name = "WhileConsole3";
            this.Text = "WhileConsole3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDay;
    }
}