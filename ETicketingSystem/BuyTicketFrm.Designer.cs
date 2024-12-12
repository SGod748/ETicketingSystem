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
            buyTicket_date = new TextBox();
            label1 = new Label();
            buyTicket_cinemaHours = new ComboBox();
            label18 = new Label();
            buyTicket_cinemaRoom = new Label();
            label16 = new Label();
            buyTicket_selectmovieBtn = new Button();
            buyTicket_movieDisclaimer = new Label();
            label11 = new Label();
            buyTicket_price = new Label();
            buyTicket_genre = new Label();
            label6 = new Label();
            label5 = new Label();
            buyTicket_movieName = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label13 = new Label();
            buyTicket_ticketQuantity = new Label();
            label7 = new Label();
            buyTicket_ticketPrice = new Label();
            label2 = new Label();
            buyTicket_calculateBtn = new Button();
            buyTicket_quantity = new TextBox();
            label17 = new Label();
            buyTicket_totalPrice = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buyTicket_date);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buyTicket_cinemaHours);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(buyTicket_cinemaRoom);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(buyTicket_selectmovieBtn);
            panel1.Controls.Add(buyTicket_movieDisclaimer);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(buyTicket_price);
            panel1.Controls.Add(buyTicket_genre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buyTicket_movieName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 374);
            panel1.TabIndex = 1;
            // 
            // buyTicket_date
            // 
            buyTicket_date.BorderStyle = BorderStyle.FixedSingle;
            buyTicket_date.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_date.Location = new Point(462, 280);
            buyTicket_date.Margin = new Padding(3, 2, 3, 2);
            buyTicket_date.Name = "buyTicket_date";
            buyTicket_date.Size = new Size(196, 26);
            buyTicket_date.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 280);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 48;
            label1.Text = "Date:";
            // 
            // buyTicket_cinemaHours
            // 
            buyTicket_cinemaHours.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_cinemaHours.FormattingEnabled = true;
            buyTicket_cinemaHours.Location = new Point(462, 241);
            buyTicket_cinemaHours.Margin = new Padding(3, 2, 3, 2);
            buyTicket_cinemaHours.Name = "buyTicket_cinemaHours";
            buyTicket_cinemaHours.Size = new Size(196, 27);
            buyTicket_cinemaHours.TabIndex = 47;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(314, 244);
            label18.Name = "label18";
            label18.Size = new Size(92, 20);
            label18.TabIndex = 46;
            label18.Text = "Cinema Hours:";
            // 
            // buyTicket_cinemaRoom
            // 
            buyTicket_cinemaRoom.AutoSize = true;
            buyTicket_cinemaRoom.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_cinemaRoom.Location = new Point(640, 76);
            buyTicket_cinemaRoom.Name = "buyTicket_cinemaRoom";
            buyTicket_cinemaRoom.Size = new Size(18, 20);
            buyTicket_cinemaRoom.TabIndex = 45;
            buyTicket_cinemaRoom.Text = "...";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(530, 76);
            label16.Name = "label16";
            label16.Size = new Size(56, 20);
            label16.TabIndex = 44;
            label16.Text = "Cinema:";
            // 
            // buyTicket_selectmovieBtn
            // 
            buyTicket_selectmovieBtn.BackColor = Color.RoyalBlue;
            buyTicket_selectmovieBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_selectmovieBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_selectmovieBtn.ForeColor = Color.White;
            buyTicket_selectmovieBtn.Location = new Point(462, 327);
            buyTicket_selectmovieBtn.Margin = new Padding(3, 2, 3, 2);
            buyTicket_selectmovieBtn.Name = "buyTicket_selectmovieBtn";
            buyTicket_selectmovieBtn.Size = new Size(196, 33);
            buyTicket_selectmovieBtn.TabIndex = 43;
            buyTicket_selectmovieBtn.Text = "SELECT MOVIE\r\n";
            buyTicket_selectmovieBtn.UseVisualStyleBackColor = false;
            buyTicket_selectmovieBtn.Click += buyTicket_selectmovieBtn_Click;
            // 
            // buyTicket_movieDisclaimer
            // 
            buyTicket_movieDisclaimer.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieDisclaimer.Location = new Point(324, 138);
            buyTicket_movieDisclaimer.Name = "buyTicket_movieDisclaimer";
            buyTicket_movieDisclaimer.Size = new Size(392, 61);
            buyTicket_movieDisclaimer.TabIndex = 42;
            buyTicket_movieDisclaimer.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(324, 118);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 41;
            label11.Text = "Movie Disclaimer:";
            // 
            // buyTicket_price
            // 
            buyTicket_price.AutoSize = true;
            buyTicket_price.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_price.Location = new Point(640, 39);
            buyTicket_price.Name = "buyTicket_price";
            buyTicket_price.Size = new Size(43, 20);
            buyTicket_price.TabIndex = 36;
            buyTicket_price.Text = "₱0.00";
            // 
            // buyTicket_genre
            // 
            buyTicket_genre.AutoSize = true;
            buyTicket_genre.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_genre.Location = new Point(401, 76);
            buyTicket_genre.Name = "buyTicket_genre";
            buyTicket_genre.Size = new Size(18, 20);
            buyTicket_genre.TabIndex = 35;
            buyTicket_genre.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(546, 39);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 34;
            label6.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(349, 76);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 33;
            label5.Text = "Genre:";
            // 
            // buyTicket_movieName
            // 
            buyTicket_movieName.AutoSize = true;
            buyTicket_movieName.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieName.Location = new Point(401, 39);
            buyTicket_movieName.Name = "buyTicket_movieName";
            buyTicket_movieName.Size = new Size(18, 20);
            buyTicket_movieName.TabIndex = 32;
            buyTicket_movieName.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 39);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 31;
            label4.Text = "Movie Name:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 11);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 349);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 349);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(buyTicket_ticketQuantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(buyTicket_ticketPrice);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(buyTicket_calculateBtn);
            panel2.Controls.Add(buyTicket_quantity);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(buyTicket_totalPrice);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(12, 389);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 334);
            panel2.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(5, 244);
            label13.Name = "label13";
            label13.Size = new Size(239, 16);
            label13.TabIndex = 45;
            label13.Text = "=============================";
            // 
            // buyTicket_ticketQuantity
            // 
            buyTicket_ticketQuantity.AutoSize = true;
            buyTicket_ticketQuantity.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_ticketQuantity.Location = new Point(116, 217);
            buyTicket_ticketQuantity.Name = "buyTicket_ticketQuantity";
            buyTicket_ticketQuantity.Size = new Size(18, 20);
            buyTicket_ticketQuantity.TabIndex = 44;
            buyTicket_ticketQuantity.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 217);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 43;
            label7.Text = "Quantity:";
            // 
            // buyTicket_ticketPrice
            // 
            buyTicket_ticketPrice.AutoSize = true;
            buyTicket_ticketPrice.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_ticketPrice.Location = new Point(116, 184);
            buyTicket_ticketPrice.Name = "buyTicket_ticketPrice";
            buyTicket_ticketPrice.Size = new Size(43, 20);
            buyTicket_ticketPrice.TabIndex = 42;
            buyTicket_ticketPrice.Text = "₱0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 184);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 41;
            label2.Text = "Ticket Price:";
            // 
            // buyTicket_calculateBtn
            // 
            buyTicket_calculateBtn.BackColor = Color.RoyalBlue;
            buyTicket_calculateBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_calculateBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_calculateBtn.ForeColor = Color.White;
            buyTicket_calculateBtn.Location = new Point(79, 123);
            buyTicket_calculateBtn.Margin = new Padding(3, 2, 3, 2);
            buyTicket_calculateBtn.Name = "buyTicket_calculateBtn";
            buyTicket_calculateBtn.Size = new Size(158, 31);
            buyTicket_calculateBtn.TabIndex = 40;
            buyTicket_calculateBtn.Text = "CALCULATE";
            buyTicket_calculateBtn.UseVisualStyleBackColor = false;
            buyTicket_calculateBtn.Click += buyTicket_calculateBtn_Click;
            // 
            // buyTicket_quantity
            // 
            buyTicket_quantity.BorderStyle = BorderStyle.FixedSingle;
            buyTicket_quantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_quantity.Location = new Point(79, 65);
            buyTicket_quantity.Margin = new Padding(3, 2, 3, 2);
            buyTicket_quantity.Name = "buyTicket_quantity";
            buyTicket_quantity.Size = new Size(158, 26);
            buyTicket_quantity.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(19, 67);
            label17.Name = "label17";
            label17.Size = new Size(57, 20);
            label17.TabIndex = 36;
            label17.Text = "Quantity:";
            // 
            // buyTicket_totalPrice
            // 
            buyTicket_totalPrice.AutoSize = true;
            buyTicket_totalPrice.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_totalPrice.Location = new Point(116, 267);
            buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            buyTicket_totalPrice.Size = new Size(42, 16);
            buyTicket_totalPrice.TabIndex = 19;
            buyTicket_totalPrice.Text = "₱0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(21, 267);
            label15.Name = "label15";
            label15.Size = new Size(84, 16);
            label15.TabIndex = 18;
            label15.Text = "Total Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 21);
            label9.Name = "label9";
            label9.Size = new Size(132, 16);
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
            panel4.Location = new Point(291, 389);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(564, 334);
            panel4.TabIndex = 3;
            // 
            // validationLabel
            // 
            validationLabel.Location = new Point(148, 206);
            validationLabel.Name = "validationLabel";
            validationLabel.Size = new Size(224, 45);
            validationLabel.TabIndex = 55;
            // 
            // validationBtn
            // 
            validationBtn.Location = new Point(122, 131);
            validationBtn.Name = "validationBtn";
            validationBtn.Size = new Size(223, 19);
            validationBtn.TabIndex = 54;
            // 
            // debitCard
            // 
            debitCard.AutoSize = true;
            debitCard.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debitCard.Location = new Point(341, 104);
            debitCard.Margin = new Padding(3, 2, 3, 2);
            debitCard.Name = "debitCard";
            debitCard.Size = new Size(77, 21);
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
            masterCard.Location = new Point(206, 104);
            masterCard.Margin = new Padding(3, 2, 3, 2);
            masterCard.Name = "masterCard";
            masterCard.Size = new Size(85, 21);
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
            payPal.Location = new Point(91, 104);
            payPal.Margin = new Padding(3, 2, 3, 2);
            payPal.Name = "payPal";
            payPal.Size = new Size(62, 21);
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
            goTyme.Location = new Point(385, 63);
            goTyme.Margin = new Padding(3, 2, 3, 2);
            goTyme.Name = "goTyme";
            goTyme.Size = new Size(73, 21);
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
            maya.Location = new Point(290, 63);
            maya.Margin = new Padding(3, 2, 3, 2);
            maya.Name = "maya";
            maya.Size = new Size(55, 21);
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
            payMaya.Location = new Point(159, 63);
            payMaya.Margin = new Padding(3, 2, 3, 2);
            payMaya.Name = "payMaya";
            payMaya.Size = new Size(75, 21);
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
            gCash.Location = new Point(54, 63);
            gCash.Margin = new Padding(3, 2, 3, 2);
            gCash.Name = "gCash";
            gCash.Size = new Size(65, 21);
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
            buyTicket_reference.Location = new Point(150, 178);
            buyTicket_reference.Margin = new Padding(3, 2, 3, 2);
            buyTicket_reference.Name = "buyTicket_reference";
            buyTicket_reference.Size = new Size(222, 26);
            buyTicket_reference.TabIndex = 46;
            buyTicket_reference.TextChanged += buyTicket_reference_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(148, 156);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 45;
            label8.Text = "Reference ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 21);
            label3.Name = "label3";
            label3.Size = new Size(143, 16);
            label3.TabIndex = 42;
            label3.Text = "Fill Payment Method";
            // 
            // buyTicket_printrecieptBtn
            // 
            buyTicket_printrecieptBtn.BackColor = Color.RoyalBlue;
            buyTicket_printrecieptBtn.FlatStyle = FlatStyle.Flat;
            buyTicket_printrecieptBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_printrecieptBtn.ForeColor = Color.White;
            buyTicket_printrecieptBtn.Location = new Point(279, 267);
            buyTicket_printrecieptBtn.Margin = new Padding(3, 2, 3, 2);
            buyTicket_printrecieptBtn.Name = "buyTicket_printrecieptBtn";
            buyTicket_printrecieptBtn.Size = new Size(148, 28);
            buyTicket_printrecieptBtn.TabIndex = 41;
            buyTicket_printrecieptBtn.Text = "PRINT RECIEPT";
            buyTicket_printrecieptBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_Btn
            // 
            buyTicket_Btn.BackColor = Color.RoyalBlue;
            buyTicket_Btn.FlatStyle = FlatStyle.Flat;
            buyTicket_Btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_Btn.ForeColor = Color.White;
            buyTicket_Btn.Location = new Point(91, 267);
            buyTicket_Btn.Margin = new Padding(3, 2, 3, 2);
            buyTicket_Btn.Name = "buyTicket_Btn";
            buyTicket_Btn.Size = new Size(148, 28);
            buyTicket_Btn.TabIndex = 40;
            buyTicket_Btn.Text = "BUY TICKET";
            buyTicket_Btn.UseVisualStyleBackColor = false;
            buyTicket_Btn.Click += buyTicket_Btn_Click;
            // 
            // BuyTicketFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 732);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyTicketFrm";
            Text = "BuyTicketFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox buyTicket_cinemaHours;
        private Label label18;
        private Label buyTicket_cinemaRoom;
        private Label label16;
        private Button buyTicket_selectmovieBtn;
        private Label buyTicket_movieDisclaimer;
        private Label label11;
        private Label buyTicket_price;
        private Label buyTicket_genre;
        private Label label6;
        private Label label5;
        private Label buyTicket_movieName;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label13;
        private Label buyTicket_ticketQuantity;
        private Label label7;
        private Label buyTicket_ticketPrice;
        private Label label2;
        private Button buyTicket_calculateBtn;
        private TextBox buyTicket_quantity;
        private Label label17;
        private Label buyTicket_totalPrice;
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
        private TextBox buyTicket_date;
    }
}