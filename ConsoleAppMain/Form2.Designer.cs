
namespace ConsoleAppMain
{
    partial class Form2
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRes = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(81, 73);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(39, 23);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "а =";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(81, 126);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(39, 23);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b =";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(116, 72);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 29);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(116, 125);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 29);
            this.textBoxB.TabIndex = 4;
            // 
            // buttonRes
            // 
            this.buttonRes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes.Location = new System.Drawing.Point(85, 179);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(131, 31);
            this.buttonRes.TabIndex = 5;
            this.buttonRes.Text = "Обчислити";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(84, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 28);
            this.label.TabIndex = 6;
            this.label.Text = "Увага a<b";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(154, 237);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 23);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "label1";
            this.labelResult.Visible = false;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDob.Location = new System.Drawing.Point(90, 237);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(61, 23);
            this.labelDob.TabIndex = 8;
            this.labelDob.Text = "dob =";
            this.labelDob.Visible = false;
            this.labelDob.Click += new System.EventHandler(this.labelDob_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form2";
            this.Text = "ForConsole1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelA;
        public System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonRes;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelDob;
    }
}