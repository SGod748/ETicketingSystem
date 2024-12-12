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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(981, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 976);
            panel1.TabIndex = 0;
            // 
            // flowViewTicketPanel
            // 
            flowViewTicketPanel.AutoScroll = true;
            flowViewTicketPanel.Dock = DockStyle.Fill;
            flowViewTicketPanel.Location = new Point(0, 0);
            flowViewTicketPanel.Margin = new Padding(3, 4, 3, 4);
            flowViewTicketPanel.Name = "flowViewTicketPanel";
            flowViewTicketPanel.Size = new Size(981, 976);
            flowViewTicketPanel.TabIndex = 1;
            // 
            // ViewTicketFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 976);
            Controls.Add(flowViewTicketPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewTicketFrm";
            Text = "ViewTicketFrm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowViewTicketPanel;
    }
}