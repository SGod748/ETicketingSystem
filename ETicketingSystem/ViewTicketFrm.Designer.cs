namespace ETicketingSystem
{
    partial class ViewTicketFrm
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
            flowViewTicketPanel = new FlowLayoutPanel();
            ticketListView1 = new TicketListView();
            flowViewTicketPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(858, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 732);
            panel1.TabIndex = 0;
            // 
            // flowViewTicketPanel
            // 
            flowViewTicketPanel.AutoScroll = true;
            flowViewTicketPanel.Controls.Add(ticketListView1);
            flowViewTicketPanel.Dock = DockStyle.Fill;
            flowViewTicketPanel.Location = new Point(0, 0);
            flowViewTicketPanel.Name = "flowViewTicketPanel";
            flowViewTicketPanel.Size = new Size(858, 732);
            flowViewTicketPanel.TabIndex = 1;
            // 
            // ticketListView1
            // 
            ticketListView1.Location = new Point(3, 3);
            ticketListView1.Name = "ticketListView1";
            ticketListView1.Size = new Size(840, 172);
            ticketListView1.TabIndex = 0;
            // 
            // ViewTicketFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 732);
            Controls.Add(flowViewTicketPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewTicketFrm";
            Text = "ViewTicketFrm";
            flowViewTicketPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowViewTicketPanel;
        private TicketListView ticketListView1;
    }
}