
namespace ConsoleAppMain
{
    partial class ForConsole3
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
            this.buttonRes3 = new System.Windows.Forms.Button();
            this.labelA3 = new System.Windows.Forms.Label();
            this.labelN3 = new System.Windows.Forms.Label();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRes3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRes3
            // 
            this.buttonRes3.Location = new System.Drawing.Point(87, 175);
            this.buttonRes3.Name = "buttonRes3";
            this.buttonRes3.Size = new System.Drawing.Size(141, 36);
            this.buttonRes3.TabIndex = 0;
            this.buttonRes3.Text = "Результат";
            this.buttonRes3.UseVisualStyleBackColor = true;
            this.buttonRes3.Click += new System.EventHandler(this.buttonRes3_Click);
            // 
            // labelA3
            // 
            this.labelA3.AutoSize = true;
            this.labelA3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA3.Location = new System.Drawing.Point(92, 104);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(39, 23);
            this.labelA3.TabIndex = 1;
            this.labelA3.Text = "a =";
            // 
            // labelN3
            // 
            this.labelN3.AutoSize = true;
            this.labelN3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN3.Location = new System.Drawing.Point(93, 133);
            this.labelN3.Name = "labelN3";
            this.labelN3.Size = new System.Drawing.Size(38, 23);
            this.labelN3.TabIndex = 2;
            this.labelN3.Text = "n =";
            // 
            // textBoxA3
            // 
            this.textBoxA3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA3.Location = new System.Drawing.Point(128, 104);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(100, 27);
            this.textBoxA3.TabIndex = 3;
            // 
            // textBoxN3
            // 
            this.textBoxN3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN3.Location = new System.Drawing.Point(128, 133);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 27);
            this.textBoxN3.TabIndex = 4;
            this.textBoxN3.TextChanged += new System.EventHandler(this.textBoxN3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "res =";
            this.label1.Visible = false;
            // 
            // labelRes3
            // 
            this.labelRes3.AutoSize = true;
            this.labelRes3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes3.Location = new System.Drawing.Point(140, 246);
            this.labelRes3.Name = "labelRes3";
            this.labelRes3.Size = new System.Drawing.Size(62, 23);
            this.labelRes3.TabIndex = 6;
            this.labelRes3.Text = "label2";
            this.labelRes3.Visible = false;
            // 
            // ForConsole3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRes3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.labelN3);
            this.Controls.Add(this.labelA3);
            this.Controls.Add(this.buttonRes3);
            this.Name = "ForConsole3";
            this.Text = "ForConsole3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRes3;
        private System.Windows.Forms.Label labelA3;
        private System.Windows.Forms.Label labelN3;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRes3;
    }
}