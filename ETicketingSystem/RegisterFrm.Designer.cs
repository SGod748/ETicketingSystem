namespace ETicketingSystem
{
    partial class RegisterFrm
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
            signup_loginbtn = new Button();
            signupbtn = new Button();
            signup_showPass = new CheckBox();
            signup_cPasstxt = new TextBox();
            label3 = new Label();
            signup_usernametxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            login_Closebtn = new Label();
            signup_passtxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            passwordStrengthLabel = new Label();
            signup_email = new TextBox();
            label6 = new Label();
            emailValidationLabel = new Label();
            SuspendLayout();
            // 
            // signup_loginbtn
            // 
            signup_loginbtn.BackColor = Color.RoyalBlue;
            signup_loginbtn.FlatStyle = FlatStyle.Flat;
            signup_loginbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginbtn.ForeColor = Color.White;
            signup_loginbtn.Location = new Point(25, 521);
            signup_loginbtn.Margin = new Padding(3, 2, 3, 2);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(281, 40);
            signup_loginbtn.TabIndex = 18;
            signup_loginbtn.Text = "Login";
            signup_loginbtn.UseVisualStyleBackColor = false;
            signup_loginbtn.Click += signup_loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.RoyalBlue;
            signupbtn.FlatStyle = FlatStyle.Flat;
            signupbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = Color.White;
            signupbtn.Location = new Point(25, 425);
            signupbtn.Margin = new Padding(3, 2, 3, 2);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(281, 40);
            signupbtn.TabIndex = 17;
            signupbtn.Text = "Sign up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Location = new Point(25, 387);
            signup_showPass.Margin = new Padding(3, 2, 3, 2);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(108, 19);
            signup_showPass.TabIndex = 16;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_cPasstxt
            // 
            signup_cPasstxt.BorderStyle = BorderStyle.FixedSingle;
            signup_cPasstxt.Location = new Point(25, 362);
            signup_cPasstxt.Margin = new Padding(3, 2, 3, 2);
            signup_cPasstxt.Name = "signup_cPasstxt";
            signup_cPasstxt.Size = new Size(281, 23);
            signup_cPasstxt.TabIndex = 15;
            signup_cPasstxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 338);
            label3.Name = "label3";
            label3.Size = new Size(135, 16);
            label3.TabIndex = 14;
            label3.Text = "Confrim Password:";
            // 
            // signup_usernametxt
            // 
            signup_usernametxt.BorderStyle = BorderStyle.FixedSingle;
            signup_usernametxt.Location = new Point(25, 112);
            signup_usernametxt.Margin = new Padding(3, 2, 3, 2);
            signup_usernametxt.Name = "signup_usernametxt";
            signup_usernametxt.Size = new Size(281, 23);
            signup_usernametxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 47);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 11;
            label1.Text = "Sign up Form";
            // 
            // login_Closebtn
            // 
            login_Closebtn.AutoSize = true;
            login_Closebtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_Closebtn.Location = new Point(301, 9);
            login_Closebtn.Name = "login_Closebtn";
            login_Closebtn.Size = new Size(15, 16);
            login_Closebtn.TabIndex = 10;
            login_Closebtn.Text = "X";
            login_Closebtn.Click += login_Closebtn_Click;
            // 
            // signup_passtxt
            // 
            signup_passtxt.BorderStyle = BorderStyle.FixedSingle;
            signup_passtxt.Location = new Point(25, 266);
            signup_passtxt.Margin = new Padding(3, 2, 3, 2);
            signup_passtxt.Name = "signup_passtxt";
            signup_passtxt.Size = new Size(281, 23);
            signup_passtxt.TabIndex = 20;
            signup_passtxt.UseSystemPasswordChar = true;
            signup_passtxt.TextChanged += signup_passtxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 242);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 19;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 504);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 21;
            label5.Text = "Already have an account?";
            // 
            // passwordStrengthLabel
            // 
            passwordStrengthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            passwordStrengthLabel.Location = new Point(25, 291);
            passwordStrengthLabel.Name = "passwordStrengthLabel";
            passwordStrengthLabel.Size = new Size(281, 39);
            passwordStrengthLabel.TabIndex = 22;
            // 
            // signup_email
            // 
            signup_email.BorderStyle = BorderStyle.FixedSingle;
            signup_email.Location = new Point(25, 174);
            signup_email.Margin = new Padding(3, 2, 3, 2);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(281, 23);
            signup_email.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 150);
            label6.Name = "label6";
            label6.Size = new Size(53, 16);
            label6.TabIndex = 23;
            label6.Text = "E-mail:";
            // 
            // emailValidationLabel
            // 
            emailValidationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            emailValidationLabel.Location = new Point(25, 199);
            emailValidationLabel.Name = "emailValidationLabel";
            emailValidationLabel.Size = new Size(281, 39);
            emailValidationLabel.TabIndex = 25;
            // 
            // RegisterFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(327, 583);
            Controls.Add(emailValidationLabel);
            Controls.Add(signup_email);
            Controls.Add(label6);
            Controls.Add(passwordStrengthLabel);
            Controls.Add(label5);
            Controls.Add(signup_passtxt);
            Controls.Add(label4);
            Controls.Add(signup_loginbtn);
            Controls.Add(signupbtn);
            Controls.Add(signup_showPass);
            Controls.Add(signup_cPasstxt);
            Controls.Add(label3);
            Controls.Add(signup_usernametxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_Closebtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_loginbtn;
        private Button signupbtn;
        private CheckBox signup_showPass;
        private TextBox signup_cPasstxt;
        private Label label3;
        private TextBox signup_usernametxt;
        private Label label2;
        private Label label1;
        private Label login_Closebtn;
        private TextBox signup_passtxt;
        private Label label4;
        private Label label5;
        private Label passwordStrengthLabel;
        private TextBox signup_email;
        private Label label6;
        private Label emailValidationLabel;
    }
}