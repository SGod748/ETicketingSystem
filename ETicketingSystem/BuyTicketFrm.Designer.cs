namespace ETicketingSystem
{
    partial class BuyTicketFrm
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
            panel3 = new Panel();
            lblCinema = new Label();
            label16 = new Label();
            lblDisclaimer = new Label();
            label11 = new Label();
            lblPrice = new Label();
            lblGenre = new Label();
            label6 = new Label();
            label5 = new Label();
            lblMovieName = new Label();
            label4 = new Label();
            cbMovieName = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label18 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            lblQuantity = new Label();
            label7 = new Label();
            lblTicketPrice = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            txtQuantity = new TextBox();
            label17 = new Label();
            lblTotal = new Label();
            label15 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            validationLabel = new Label();
            validationBtn = new Label();
            debitCard = new RadioButton();
            masterCard = new RadioButton();
            payPal = new RadioButton();
            goTyme = new RadioButton();
            maya = new RadioButton();
            payMaya = new RadioButton();
            gCash = new RadioButton();
            buyTicket_reference = new TextBox();
            label8 = new Label();
            label3 = new Label();
            buyTicket_printrecieptBtn = new Button();
            buyTicket_Btn = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(cbMovieName);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label18);
            panel1.Location = new Point(333, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 498);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(lblCinema);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(lblDisclaimer);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lblPrice);
            panel3.Controls.Add(lblGenre);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblMovieName);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(41, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 221);
            panel3.TabIndex = 52;
            // 
            // lblCinema
            // 
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCinema.Location = new Point(426, 65);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(22, 22);
            lblCinema.TabIndex = 55;
            lblCinema.Text = "...";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(355, 65);
            label16.Name = "label16";
            label16.Size = new Size(65, 22);
            label16.TabIndex = 54;
            label16.Text = "Cinema:";
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisclaimer.Location = new Point(21, 126);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.Size = new Size(448, 81);
            lblDisclaimer.TabIndex = 53;
            lblDisclaimer.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 99);
            label11.Name = "label11";
            label11.Size = new Size(125, 22);
            label11.TabIndex = 52;
            label11.Text = "Movie Disclaimer:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(402, 16);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 22);
            lblPrice.TabIndex = 51;
            lblPrice.Text = "00.00";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(88, 57);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(22, 22);
            lblGenre.TabIndex = 50;
            lblGenre.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(349, 16);
            label6.Name = "label6";
            label6.Size = new Size(47, 22);
            label6.TabIndex = 49;
            label6.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 57);
            label5.Name = "label5";
            label5.Size = new Size(54, 22);
            label5.TabIndex = 48;
            label5.Text = "Genre:";
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(124, 16);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(22, 22);
            lblMovieName.TabIndex = 47;
            lblMovieName.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 16);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 46;
            label4.Text = "Movie Name:";
            // 
            // cbMovieName
            // 
            cbMovieName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMovieName.FormattingEnabled = true;
            cbMovieName.Items.AddRange(new object[] { "Moana 2", "Hello, Love, Again", "Mufasa The Lion King", "Gladiator 2", "Solo Leveling The Movie" });
            cbMovieName.Location = new Point(252, 320);
            cbMovieName.Name = "cbMovieName";
            cbMovieName.Size = new Size(319, 31);
            cbMovieName.TabIndex = 51;
            cbMovieName.SelectedIndexChanged += cbMovieName_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(283, 370);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 30);
            dateTimePicker1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 375);
            label1.Name = "label1";
            label1.Size = new Size(44, 22);
            label1.TabIndex = 48;
            label1.Text = "Date:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(149, 327);
            label18.Name = "label18";
            label18.Size = new Size(97, 22);
            label18.TabIndex = 46;
            label18.Text = "Movie Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblTicketPrice);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnCalculate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(14, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 949);
            panel2.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 325);
            label13.Name = "label13";
            label13.Size = new Size(299, 20);
            label13.TabIndex = 45;
            label13.Text = "=============================";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(133, 289);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(22, 22);
            lblQuantity.TabIndex = 44;
            lblQuantity.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 289);
            label7.Name = "label7";
            label7.Size = new Size(65, 22);
            label7.TabIndex = 43;
            label7.Text = "Quantity:";
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.AutoSize = true;
            lblTicketPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketPrice.Location = new Point(133, 245);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(50, 22);
            lblTicketPrice.TabIndex = 42;
            lblTicketPrice.Text = "₱0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 245);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 41;
            label2.Text = "Ticket Price:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.RoyalBlue;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(90, 164);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(181, 41);
            btnCalculate.TabIndex = 40;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += buyTicket_calculateBtn_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(90, 87);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 30);
            txtQuantity.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(22, 89);
            label17.Name = "label17";
            label17.Size = new Size(65, 22);
            label17.TabIndex = 36;
            label17.Text = "Quantity:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(133, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 20);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "₱0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(24, 356);
            label15.Name = "label15";
            label15.Size = new Size(103, 20);
            label15.TabIndex = 18;
            label15.Text = "Total Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 28);
            label9.Name = "label9";
            label9.Size = new Size(162, 20);
            label9.TabIndex = 1;
            label9.Text = "Fill Ticket Booking";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(validationLabel);
            panel4.Controls.Add(validationBtn);
            panel4.Controls.Add(debitCard);
            panel4.Controls.Add(masterCard);
            panel4.Controls.Add(payPal);
            panel4.Controls.Add(goTyme);
            panel4.Controls.Add(maya);
            panel4.Controls.Add(payMaya);
            panel4.Controls.Add(gCash);
            panel4.Controls.Add(buyTicket_reference);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(buyTicket_printrecieptBtn);
            panel4.Controls.Add(buyTicket_Btn);
            panel4.Location = new Point(333, 519);
            panel4.Name = "panel4";
            panel4.Size = new Size(644, 445);
            panel4.TabIndex = 3;
            // 
            // validationLabel
            // 
            validationLabel.Location = new Point(169, 275);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(256, 60);
            validationLabel.TabIndex = 55;
            // 
            // validationBtn
            // 
            validationBtn.Location = new Point(139, 175);
            validationBtn.Name = "validationBtn";
            validationBtn.Size = new Size(255, 25);
            validationBtn.TabIndex = 54;
            // 
            // debitCard
            // 
            debitCard.AutoSize = true;
            debitCard.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debitCard.Location = new Point(390, 139);
            debitCard.Name = "debitCard";
            debitCard.Size = new Size(98, 26);
            debitCard.TabIndex = 53;
            debitCard.TabStop = true;
            debitCard.Text = "Debit Card";
            debitCard.UseVisualStyleBackColor = true;
            debitCard.CheckedChanged += debitCard_CheckedChanged;
            // 
            // masterCard
            // 
            masterCard.AutoSize = true;
            masterCard.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            masterCard.Location = new Point(235, 139);
            masterCard.Name = "masterCard";
            masterCard.Size = new Size(106, 26);
            masterCard.TabIndex = 52;
            masterCard.TabStop = true;
            masterCard.Text = "MasterCard";
            masterCard.UseVisualStyleBackColor = true;
            masterCard.CheckedChanged += masterCard_CheckedChanged;
            // 
            // payPal
            // 
            payPal.AutoSize = true;
            payPal.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payPal.Location = new Point(104, 139);
            payPal.Name = "payPal";
            payPal.Size = new Size(75, 26);
            payPal.TabIndex = 51;
            payPal.TabStop = true;
            payPal.Text = "PayPal";
            payPal.UseVisualStyleBackColor = true;
            payPal.CheckedChanged += payPal_CheckedChanged;
            // 
            // goTyme
            // 
            goTyme.AutoSize = true;
            goTyme.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goTyme.Location = new Point(440, 84);
            goTyme.Name = "goTyme";
            goTyme.Size = new Size(91, 26);
            goTyme.TabIndex = 50;
            goTyme.TabStop = true;
            goTyme.Text = "Go Tyme";
            goTyme.UseVisualStyleBackColor = true;
            goTyme.CheckedChanged += goTyme_CheckedChanged;
            // 
            // maya
            // 
            maya.AutoSize = true;
            maya.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maya.Location = new Point(331, 84);
            maya.Name = "maya";
            maya.Size = new Size(67, 26);
            maya.TabIndex = 49;
            maya.TabStop = true;
            maya.Text = "Maya";
            maya.UseVisualStyleBackColor = true;
            maya.CheckedChanged += maya_CheckedChanged;
            // 
            // payMaya
            // 
            payMaya.AutoSize = true;
            payMaya.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payMaya.Location = new Point(182, 84);
            payMaya.Name = "payMaya";
            payMaya.Size = new Size(91, 26);
            payMaya.TabIndex = 48;
            payMaya.TabStop = true;
            payMaya.Text = "PayMaya";
            payMaya.UseVisualStyleBackColor = true;
            payMaya.CheckedChanged += payMaya_CheckedChanged;
            // 
            // gCash
            // 
            gCash.AutoSize = true;
            gCash.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gCash.ImageAlign = ContentAlignment.MiddleRight;
            gCash.Location = new Point(62, 84);
            gCash.Name = "gCash";
            gCash.Size = new Size(80, 26);
            gCash.TabIndex = 47;
            gCash.TabStop = true;
            gCash.Text = "G-Cash";
            gCash.UseVisualStyleBackColor = true;
            gCash.CheckedChanged += gCash_CheckedChanged;
            // 
            // buyTicket_reference
            // 
            buyTicket_reference.BorderStyle = BorderStyle.FixedSingle;
            buyTicket_reference.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_reference.Location = new Point(171, 237);
            buyTicket_reference.Name = "buyTicket_reference";
            buyTicket_reference.Size = new Size(253, 30);
            buyTicket_reference.TabIndex = 46;
            buyTicket_reference.TextChanged += buyTicket_reference_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(169, 208);
            label8.Name = "label8";
            label8.Size = new Size(98, 22);
            label8.TabIndex = 45;
            label8.Text = "Reference ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 28);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 42;
            label3.Text = "Fill Payment Method";
            // 
            // buyTicket_printrecieptBtn
            // 
            buyTicket_printrecieptBtn.BackColor = Color.RoyalBlue;
            buyTicket_printrecieptBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_printrecieptBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_printrecieptBtn.ForeColor = Color.White;
            buyTicket_printrecieptBtn.Location = new Point(319, 356);
            buyTicket_printrecieptBtn.Name = "buyTicket_printrecieptBtn";
            buyTicket_printrecieptBtn.Size = new Size(169, 37);
            buyTicket_printrecieptBtn.TabIndex = 41;
            buyTicket_printrecieptBtn.Text = "PRINT RECIEPT";
            buyTicket_printrecieptBtn.UseVisualStyleBackColor = false;
            buyTicket_printrecieptBtn.Click += buyTicket_printrecieptBtn_Click;
            // 
            // buyTicket_Btn
            // 
            buyTicket_Btn.BackColor = Color.RoyalBlue;
            buyTicket_Btn.FlatStyle = FlatStyle.Flat;
            buyTicket_Btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_Btn.ForeColor = Color.White;
            buyTicket_Btn.Location = new Point(104, 356);
            buyTicket_Btn.Name = "buyTicket_Btn";
            buyTicket_Btn.Size = new Size(169, 37);
            buyTicket_Btn.TabIndex = 40;
            buyTicket_Btn.Text = "BUY TICKET";
            buyTicket_Btn.UseVisualStyleBackColor = false;
            buyTicket_Btn.Click += buyTicket_Btn_Click;
            // 
            // BuyTicketFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 976);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuyTicketFrm";
            Text = "BuyTicketFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label18;
        private Panel panel2;
        private Label label13;
        private Label lblQuantity;
        private Label label7;
        private Label lblTicketPrice;
        private Label label2;
        private Button btnCalculate;
        private TextBox txtQuantity;
        private Label label17;
        private Label lblTotal;
        private Label label15;
        private Label label9;
        private Panel panel4;
        private RadioButton debitCard;
        private RadioButton masterCard;
        private RadioButton payPal;
        private RadioButton goTyme;
        private RadioButton maya;
        private RadioButton payMaya;
        private RadioButton gCash;
        private TextBox buyTicket_reference;
        private Label label8;
        private Label label3;
        private Button buyTicket_printrecieptBtn;
        private Button buyTicket_Btn;
        private Label validationBtn;
        private Label validationLabel;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbMovieName;
        private Panel panel3;
        private Label lblCinema;
        private Label label16;
        private Label lblDisclaimer;
        private Label label11;
        private Label lblPrice;
        private Label lblGenre;
        private Label label6;
        private Label label5;
        private Label lblMovieName;
        private Label label4;
    }
}