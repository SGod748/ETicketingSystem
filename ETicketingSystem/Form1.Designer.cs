namespace ETicketingSystem
{
    partial class LoginFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_Closebtn = new Label();
            label1 = new Label();
            label2 = new Label();
            login_usernametxt = new TextBox();
            login_passtxt = new TextBox();
            label3 = new Label();
            login_showPass = new CheckBox();
            loginbtn = new Button();
            login_signupbtn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // login_Closebtn
            // 
            login_Closebtn.AutoSize = true;
            login_Closebtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_Closebtn.Location = new Point(343, 9);
            login_Closebtn.Name = "login_Closebtn";
            login_Closebtn.Size = new Size(19, 20);
            login_Closebtn.TabIndex = 0;
            login_Closebtn.Text = "X";
            login_Closebtn.Click += login_Closebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 2;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 115);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // login_usernametxt
            // 
            login_usernametxt.BorderStyle = BorderStyle.FixedSingle;
            login_usernametxt.Location = new Point(29, 147);
            login_usernametxt.Name = "login_usernametxt";
            login_usernametxt.Size = new Size(321, 27);
            login_usernametxt.TabIndex = 4;
            // 
            // login_passtxt
            // 
            login_passtxt.BorderStyle = BorderStyle.FixedSingle;
            login_passtxt.Location = new Point(29, 242);
            login_passtxt.Name = "login_passtxt";
            login_passtxt.Size = new Size(321, 27);
            login_passtxt.TabIndex = 6;
            login_passtxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 210);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(29, 275);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(132, 24);
            login_showPass.TabIndex = 7;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.RoyalBlue;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(29, 324);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(321, 54);
            loginbtn.TabIndex = 8;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // login_signupbtn
            // 
            login_signupbtn.BackColor = Color.RoyalBlue;
            login_signupbtn.FlatStyle = FlatStyle.Flat;
            login_signupbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupbtn.ForeColor = Color.White;
            login_signupbtn.Location = new Point(28, 585);
            login_signupbtn.Name = "login_signupbtn";
            login_signupbtn.Size = new Size(321, 54);
            login_signupbtn.TabIndex = 9;
            login_signupbtn.Text = "Sign up";
            login_signupbtn.UseVisualStyleBackColor = false;
            login_signupbtn.Click += login_signupbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 562);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 10;
            label4.Text = "Create an account?";
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 668);
            Controls.Add(label4);
            Controls.Add(login_signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(login_showPass);
            Controls.Add(login_passtxt);
            Controls.Add(label3);
            Controls.Add(login_usernametxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_Closebtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_Closebtn;
        private Label label1;
        private Label label2;
        private TextBox login_usernametxt;
        private TextBox login_passtxt;
        private Label label3;
        private CheckBox login_showPass;
        private Button loginbtn;
        private Button login_signupbtn;
        private Label label4;
    }
}
