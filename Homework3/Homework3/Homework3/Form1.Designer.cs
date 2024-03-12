namespace Homework3
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
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonregister = new System.Windows.Forms.Button();
            this.buttondeposit = new System.Windows.Forms.Button();
            this.buttonwithdraw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(128, 129);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(160, 19);
            this.textBoxusername.TabIndex = 0;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(128, 164);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(160, 19);
            this.textBoxpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "UC BANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(30, 247);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.Location = new System.Drawing.Point(213, 247);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(75, 23);
            this.buttonregister.TabIndex = 6;
            this.buttonregister.Text = "register";
            this.buttonregister.UseVisualStyleBackColor = true;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttondeposit
            // 
            this.buttondeposit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeposit.Location = new System.Drawing.Point(30, 184);
            this.buttondeposit.Name = "buttondeposit";
            this.buttondeposit.Size = new System.Drawing.Size(75, 23);
            this.buttondeposit.TabIndex = 7;
            this.buttondeposit.Text = "Deposit";
            this.buttondeposit.UseVisualStyleBackColor = true;
            this.buttondeposit.Visible = false;
            this.buttondeposit.Click += new System.EventHandler(this.buttondeposit_Click);
            // 
            // buttonwithdraw
            // 
            this.buttonwithdraw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonwithdraw.Location = new System.Drawing.Point(30, 213);
            this.buttonwithdraw.Name = "buttonwithdraw";
            this.buttonwithdraw.Size = new System.Drawing.Size(75, 23);
            this.buttonwithdraw.TabIndex = 8;
            this.buttonwithdraw.Text = "Withdraw";
            this.buttonwithdraw.UseVisualStyleBackColor = true;
            this.buttonwithdraw.Visible = false;
            this.buttonwithdraw.Click += new System.EventHandler(this.buttonwithdraw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            this.label4.Visible = false;
            // 
            // buttonlogout
            // 
            this.buttonlogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.Location = new System.Drawing.Point(213, 74);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(75, 23);
            this.buttonlogout.TabIndex = 10;
            this.buttonlogout.Text = "logout";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Visible = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 352);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonwithdraw);
            this.Controls.Add(this.buttondeposit);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button buttondeposit;
        private System.Windows.Forms.Button buttonwithdraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonlogout;
    }
}

