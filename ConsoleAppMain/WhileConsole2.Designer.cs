
namespace ConsoleAppMain
{
    partial class WhileConsole2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(44, 79);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(38, 23);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "n =";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(88, 80);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 27);
            this.textBoxN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "k =";
            this.label1.Visible = false;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(84, 214);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(62, 23);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "label2";
            this.labelK.Visible = false;
            // 
            // WhileConsole2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Name = "WhileConsole2";
            this.Text = "WhileConsole2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelK;
    }
}