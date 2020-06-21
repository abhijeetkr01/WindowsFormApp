namespace WindowsForms_07
{
    partial class WindowsForms_07
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Enum = new System.Windows.Forms.TextBox();
            this.Ename = new System.Windows.Forms.TextBox();
            this.Edoj = new System.Windows.Forms.TextBox();
            this.Edep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Esal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecnumber :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Joining :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name :";
            // 
            // Enum
            // 
            this.Enum.Location = new System.Drawing.Point(186, 36);
            this.Enum.Name = "Enum";
            this.Enum.Size = new System.Drawing.Size(193, 20);
            this.Enum.TabIndex = 4;
            this.Enum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enum_KeyUp);
            // 
            // Ename
            // 
            this.Ename.Location = new System.Drawing.Point(186, 68);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(193, 20);
            this.Ename.TabIndex = 5;
            this.Ename.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ename_KeyUp);
            // 
            // Edoj
            // 
            this.Edoj.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Edoj.Location = new System.Drawing.Point(186, 102);
            this.Edoj.Name = "Edoj";
            this.Edoj.Size = new System.Drawing.Size(193, 20);
            this.Edoj.TabIndex = 6;
            this.Edoj.Text = "mm-dd-yyyy";
            this.Edoj.Enter += new System.EventHandler(this.Edoj_Enter);
            this.Edoj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Edoj_KeyUp);
            this.Edoj.Leave += new System.EventHandler(this.Edoj_Leave);
            // 
            // Edep
            // 
            this.Edep.Location = new System.Drawing.Point(187, 134);
            this.Edep.Name = "Edep";
            this.Edep.Size = new System.Drawing.Size(193, 20);
            this.Edep.TabIndex = 7;
            this.Edep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Edep_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Department :";
            // 
            // Esal
            // 
            this.Esal.Location = new System.Drawing.Point(186, 168);
            this.Esal.Name = "Esal";
            this.Esal.Size = new System.Drawing.Size(193, 20);
            this.Esal.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WindowsForms_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 247);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Esal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edep);
            this.Controls.Add(this.Edoj);
            this.Controls.Add(this.Ename);
            this.Controls.Add(this.Enum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WindowsForms_07";
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.WindowsForms_07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Enum;
        private System.Windows.Forms.TextBox Ename;
        private System.Windows.Forms.TextBox Edoj;
        private System.Windows.Forms.TextBox Edep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Esal;
        private System.Windows.Forms.Button btnSave;
    }
}

