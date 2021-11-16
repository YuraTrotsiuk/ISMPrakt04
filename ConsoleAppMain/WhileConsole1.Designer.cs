
namespace ConsoleAppMain
{
    partial class WhileConsole1
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(77, 161);
            this.labelN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(38, 23);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "n =";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(113, 161);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(92, 30);
            this.textBoxN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "res =";
            this.label2.Visible = false;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(130, 262);
            this.labelRes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(62, 23);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "label3";
            this.labelRes.Visible = false;
            // 
            // WhileConsole1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 445);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "WhileConsole1";
            this.Text = "WhileConsole1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRes;
    }
}