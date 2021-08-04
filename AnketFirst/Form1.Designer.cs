
namespace AnketFirst
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
            this.AnketlistBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgeTxtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.professionTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.FemaleRBtn = new System.Windows.Forms.RadioButton();
            this.MaleRbtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.englishCckb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnketlistBox
            // 
            this.AnketlistBox.FormattingEnabled = true;
            this.AnketlistBox.Location = new System.Drawing.Point(487, 41);
            this.AnketlistBox.Name = "AnketlistBox";
            this.AnketlistBox.Size = new System.Drawing.Size(252, 290);
            this.AnketlistBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgeTxtb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.printBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.professionTxtb);
            this.groupBox1.Controls.Add(this.emailTxtb);
            this.groupBox1.Controls.Add(this.surnameTxtb);
            this.groupBox1.Controls.Add(this.nameTxtb);
            this.groupBox1.Controls.Add(this.FemaleRBtn);
            this.groupBox1.Controls.Add(this.MaleRbtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.englishCckb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AgeTxtb
            // 
            this.AgeTxtb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AgeTxtb.Location = new System.Drawing.Point(117, 91);
            this.AgeTxtb.Name = "AgeTxtb";
            this.AgeTxtb.Size = new System.Drawing.Size(225, 20);
            this.AgeTxtb.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Age";
            // 
            // printBtn
            // 
            this.printBtn.AutoSize = true;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(175, 286);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(101, 35);
            this.printBtn.TabIndex = 24;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(117, 195);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(225, 21);
            this.maskedTextBox2.TabIndex = 22;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 166);
            this.maskedTextBox1.Mask = "(+994)-50-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(225, 21);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // professionTxtb
            // 
            this.professionTxtb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.professionTxtb.Location = new System.Drawing.Point(117, 242);
            this.professionTxtb.Name = "professionTxtb";
            this.professionTxtb.Size = new System.Drawing.Size(225, 20);
            this.professionTxtb.TabIndex = 20;
            // 
            // emailTxtb
            // 
            this.emailTxtb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.emailTxtb.Location = new System.Drawing.Point(117, 140);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(225, 20);
            this.emailTxtb.TabIndex = 19;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.surnameTxtb.Location = new System.Drawing.Point(117, 62);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(225, 20);
            this.surnameTxtb.TabIndex = 18;
            // 
            // nameTxtb
            // 
            this.nameTxtb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameTxtb.Location = new System.Drawing.Point(117, 36);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(225, 20);
            this.nameTxtb.TabIndex = 17;
            // 
            // FemaleRBtn
            // 
            this.FemaleRBtn.AutoSize = true;
            this.FemaleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRBtn.Location = new System.Drawing.Point(222, 110);
            this.FemaleRBtn.Name = "FemaleRBtn";
            this.FemaleRBtn.Size = new System.Drawing.Size(107, 29);
            this.FemaleRBtn.TabIndex = 16;
            this.FemaleRBtn.Text = "Female";
            this.FemaleRBtn.UseVisualStyleBackColor = true;
            this.FemaleRBtn.CheckedChanged += new System.EventHandler(this.FemaleRBtn_CheckedChanged);
            // 
            // MaleRbtn
            // 
            this.MaleRbtn.AutoSize = true;
            this.MaleRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRbtn.Location = new System.Drawing.Point(135, 108);
            this.MaleRbtn.Name = "MaleRbtn";
            this.MaleRbtn.Size = new System.Drawing.Size(81, 29);
            this.MaleRbtn.TabIndex = 15;
            this.MaleRbtn.Text = "Male";
            this.MaleRbtn.UseVisualStyleBackColor = true;
            this.MaleRbtn.CheckedChanged += new System.EventHandler(this.MaleRbtn_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Profession";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Language";
            // 
            // englishCckb
            // 
            this.englishCckb.AutoSize = true;
            this.englishCckb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishCckb.Location = new System.Drawing.Point(127, 220);
            this.englishCckb.Name = "englishCckb";
            this.englishCckb.Size = new System.Drawing.Size(78, 20);
            this.englishCckb.TabIndex = 11;
            this.englishCckb.Text = "English";
            this.englishCckb.UseVisualStyleBackColor = true;
            this.englishCckb.CheckedChanged += new System.EventHandler(this.englishCckb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnketlistBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AnketlistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AgeTxtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox professionTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.RadioButton FemaleRBtn;
        private System.Windows.Forms.RadioButton MaleRbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox englishCckb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

