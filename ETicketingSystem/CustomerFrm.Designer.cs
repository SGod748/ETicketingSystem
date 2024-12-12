namespace ETicketingSystem
{
    partial class CustomerFrm
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
            panel1 = new Panel();
            button2 = new Button();
            logout_btn = new Button();
            buyTicket_btn = new Button();
            dashboard_btn = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            closebtn = new Label();
            userPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(logout_btn);
            panel1.Controls.Add(buyTicket_btn);
            panel1.Controls.Add(dashboard_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 773);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 345);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(191, 38);
            button2.TabIndex = 11;
            button2.Text = "VIEW TICKET";
            button2.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = Properties.Resources.icons8_logout_30;
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(10, 691);
            logout_btn.Margin = new Padding(3, 2, 3, 2);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(191, 38);
            logout_btn.TabIndex = 9;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // buyTicket_btn
            // 
            buyTicket_btn.FlatAppearance.BorderSize = 0;
            buyTicket_btn.FlatStyle = FlatStyle.Flat;
            buyTicket_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_btn.ForeColor = Color.White;
            buyTicket_btn.Location = new Point(10, 285);
            buyTicket_btn.Margin = new Padding(3, 2, 3, 2);
            buyTicket_btn.Name = "buyTicket_btn";
            buyTicket_btn.Size = new Size(191, 38);
            buyTicket_btn.TabIndex = 7;
            buyTicket_btn.Text = "BUY TICKET";
            buyTicket_btn.UseVisualStyleBackColor = true;
            buyTicket_btn.Click += buyTicket_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(10, 221);
            dashboard_btn.Margin = new Padding(3, 2, 3, 2);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(191, 38);
            dashboard_btn.TabIndex = 5;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(closebtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(217, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 40);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 15);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 3;
            label3.Text = "Welcome, User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(193, 17);
            label2.TabIndex = 2;
            label2.Text = "Movie E-Ticketing System";
            // 
            // closebtn
            // 
            closebtn.AutoSize = true;
            closebtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closebtn.Location = new Point(839, 9);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(17, 17);
            closebtn.TabIndex = 1;
            closebtn.Text = "X";
            closebtn.Click += closebtn_Click;
            // 
            // userPanel
            // 
            userPanel.Dock = DockStyle.Fill;
            userPanel.Location = new Point(217, 40);
            userPanel.Margin = new Padding(3, 2, 3, 2);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(868, 733);
            userPanel.TabIndex = 4;
            // 
            // CustomerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 773);
            Controls.Add(userPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffFrm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label closebtn;
        private Button logout_btn;
        private Button buyTicket_btn;
        private Button dashboard_btn;
        private Label label2;
        private Label label3;
        private Button button2;
        private Panel userPanel;
    }
}