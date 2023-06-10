namespace calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDevid = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "جواب";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(12, 105);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(299, 20);
            this.txtRes.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "عدد دوم";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(299, 20);
            this.txt2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "عدد اول";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(299, 20);
            this.txt1.TabIndex = 17;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(273, 64);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(81, 35);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDevid
            // 
            this.btnDevid.Location = new System.Drawing.Point(99, 64);
            this.btnDevid.Name = "btnDevid";
            this.btnDevid.Size = new System.Drawing.Size(81, 35);
            this.btnDevid.TabIndex = 15;
            this.btnDevid.Text = "/";
            this.btnDevid.UseVisualStyleBackColor = true;
            this.btnDevid.Click += new System.EventHandler(this.btnDevid_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(12, 64);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(81, 35);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(186, 64);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(81, 35);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDevid);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDevid;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSum;
    }
}

