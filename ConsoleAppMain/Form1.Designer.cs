
namespace ConsoleAppMain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ForConsole1 = new System.Windows.Forms.Button();
            this.ForConsole2 = new System.Windows.Forms.Button();
            this.ForConsole3 = new System.Windows.Forms.Button();
            this.ForConsole4 = new System.Windows.Forms.Button();
            this.ForConsole5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WhileConsole2 = new System.Windows.Forms.Button();
            this.WhileConsole3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ForConsole1
            // 
            this.ForConsole1.Location = new System.Drawing.Point(34, 21);
            this.ForConsole1.Name = "ForConsole1";
            this.ForConsole1.Size = new System.Drawing.Size(132, 44);
            this.ForConsole1.TabIndex = 0;
            this.ForConsole1.Text = "ForConsole1";
            this.ForConsole1.UseVisualStyleBackColor = true;
            this.ForConsole1.Click += new System.EventHandler(this.ForConsole1_Click);
            // 
            // ForConsole2
            // 
            this.ForConsole2.Location = new System.Drawing.Point(34, 90);
            this.ForConsole2.Name = "ForConsole2";
            this.ForConsole2.Size = new System.Drawing.Size(132, 45);
            this.ForConsole2.TabIndex = 1;
            this.ForConsole2.Text = "ForConsole2";
            this.ForConsole2.UseVisualStyleBackColor = true;
            this.ForConsole2.Click += new System.EventHandler(this.ForConsole2_Click);
            // 
            // ForConsole3
            // 
            this.ForConsole3.Location = new System.Drawing.Point(34, 152);
            this.ForConsole3.Name = "ForConsole3";
            this.ForConsole3.Size = new System.Drawing.Size(132, 45);
            this.ForConsole3.TabIndex = 2;
            this.ForConsole3.Text = "ForConsole3";
            this.ForConsole3.UseVisualStyleBackColor = true;
            this.ForConsole3.Click += new System.EventHandler(this.ForConsole3_Click);
            // 
            // ForConsole4
            // 
            this.ForConsole4.Location = new System.Drawing.Point(34, 216);
            this.ForConsole4.Name = "ForConsole4";
            this.ForConsole4.Size = new System.Drawing.Size(132, 45);
            this.ForConsole4.TabIndex = 3;
            this.ForConsole4.Text = "ForConsole4";
            this.ForConsole4.UseVisualStyleBackColor = true;
            this.ForConsole4.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForConsole5
            // 
            this.ForConsole5.Location = new System.Drawing.Point(34, 283);
            this.ForConsole5.Name = "ForConsole5";
            this.ForConsole5.Size = new System.Drawing.Size(132, 45);
            this.ForConsole5.TabIndex = 4;
            this.ForConsole5.Text = "ForConsole5";
            this.ForConsole5.UseVisualStyleBackColor = true;
            this.ForConsole5.Click += new System.EventHandler(this.ForConsole5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "WhileConsole1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WhileConsole2
            // 
            this.WhileConsole2.Location = new System.Drawing.Point(222, 90);
            this.WhileConsole2.Name = "WhileConsole2";
            this.WhileConsole2.Size = new System.Drawing.Size(132, 45);
            this.WhileConsole2.TabIndex = 6;
            this.WhileConsole2.Text = "WhileConsole2";
            this.WhileConsole2.UseVisualStyleBackColor = true;
            this.WhileConsole2.Click += new System.EventHandler(this.WhileConsole2_Click);
            // 
            // WhileConsole3
            // 
            this.WhileConsole3.Location = new System.Drawing.Point(222, 152);
            this.WhileConsole3.Name = "WhileConsole3";
            this.WhileConsole3.Size = new System.Drawing.Size(132, 45);
            this.WhileConsole3.TabIndex = 7;
            this.WhileConsole3.Text = "WhileConsole3";
            this.WhileConsole3.UseVisualStyleBackColor = true;
            this.WhileConsole3.Click += new System.EventHandler(this.WhileConsole3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Роботу виконав: Троцюк Юрій Михайлович";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhileConsole3);
            this.Controls.Add(this.WhileConsole2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ForConsole5);
            this.Controls.Add(this.ForConsole4);
            this.Controls.Add(this.ForConsole3);
            this.Controls.Add(this.ForConsole2);
            this.Controls.Add(this.ForConsole1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне вікно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ForConsole1;
        private System.Windows.Forms.Button ForConsole2;
        private System.Windows.Forms.Button ForConsole3;
        private System.Windows.Forms.Button ForConsole4;
        private System.Windows.Forms.Button ForConsole5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button WhileConsole2;
        private System.Windows.Forms.Button WhileConsole3;
        private System.Windows.Forms.Label label1;
    }
}

