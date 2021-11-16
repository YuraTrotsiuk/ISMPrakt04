
namespace ConsoleAppMain
{
    partial class ForConsole5
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
            this.buttonRes = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(51, 133);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(131, 43);
            this.buttonRes.TabIndex = 0;
            this.buttonRes.Text = "Результат";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(47, 89);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(38, 23);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "n =";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(82, 90);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 27);
            this.textBoxN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "res =";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(114, 193);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(62, 23);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "label3";
            this.labelRes.Visible = false;
            // 
            // ForConsole5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonRes);
            this.Name = "ForConsole5";
            this.Text = "ForConsole5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRes;
    }
}