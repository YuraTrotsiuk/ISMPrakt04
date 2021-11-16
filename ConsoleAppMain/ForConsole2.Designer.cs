
namespace ConsoleAppMain
{
    partial class ForConsole2
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
            this.labelN2 = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.labelSum2 = new System.Windows.Forms.Label();
            this.buttonRes2 = new System.Windows.Forms.Button();
            this.labelRes2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN2.Location = new System.Drawing.Point(24, 71);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(38, 23);
            this.labelN2.TabIndex = 0;
            this.labelN2.Text = "n =";
            // 
            // textBoxN2
            // 
            this.textBoxN2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN2.Location = new System.Drawing.Point(68, 72);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 27);
            this.textBoxN2.TabIndex = 1;
            this.textBoxN2.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // labelSum2
            // 
            this.labelSum2.AutoSize = true;
            this.labelSum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum2.Location = new System.Drawing.Point(24, 220);
            this.labelSum2.Name = "labelSum2";
            this.labelSum2.Size = new System.Drawing.Size(64, 23);
            this.labelSum2.TabIndex = 2;
            this.labelSum2.Text = "sum =";
            this.labelSum2.Visible = false;
            // 
            // buttonRes2
            // 
            this.buttonRes2.Location = new System.Drawing.Point(28, 138);
            this.buttonRes2.Name = "buttonRes2";
            this.buttonRes2.Size = new System.Drawing.Size(141, 38);
            this.buttonRes2.TabIndex = 4;
            this.buttonRes2.Text = "Обчислити";
            this.buttonRes2.UseVisualStyleBackColor = true;
            this.buttonRes2.Click += new System.EventHandler(this.buttonRes2_Click);
            // 
            // labelRes2
            // 
            this.labelRes2.AutoSize = true;
            this.labelRes2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes2.Location = new System.Drawing.Point(85, 220);
            this.labelRes2.Name = "labelRes2";
            this.labelRes2.Size = new System.Drawing.Size(62, 23);
            this.labelRes2.TabIndex = 5;
            this.labelRes2.Text = "label1";
            this.labelRes2.Visible = false;
            // 
            // ForConsole2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRes2);
            this.Controls.Add(this.buttonRes2);
            this.Controls.Add(this.labelSum2);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.labelN2);
            this.Name = "ForConsole2";
            this.Text = "ForConsole2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.Button buttonRes2;
        public System.Windows.Forms.Label labelN2;
        public System.Windows.Forms.Label labelSum2;
        private System.Windows.Forms.Label labelRes2;
    }
}