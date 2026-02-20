namespace RPG
{
    partial class Forest
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
            components = new System.ComponentModel.Container();
            Action = new Label();
            Events = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Actions = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Action
            // 
            Action.BackColor = SystemColors.InactiveCaptionText;
            Action.BorderStyle = BorderStyle.FixedSingle;
            Action.Font = new Font("Calibri", 26F);
            Action.Location = new Point(12, 42);
            Action.Name = "Action";
            Action.Size = new Size(764, 382);
            Action.TabIndex = 20;
            Action.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Events
            // 
            Events.BackColor = SystemColors.InactiveCaptionText;
            Events.BorderStyle = BorderStyle.FixedSingle;
            Events.Font = new Font("Calibri", 12F);
            Events.Location = new Point(816, 496);
            Events.Name = "Events";
            Events.Size = new Size(756, 356);
            Events.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label8.Location = new Point(816, 463);
            label8.Name = "label8";
            label8.Size = new Size(101, 33);
            label8.TabIndex = 18;
            label8.Text = "Events :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label7.Location = new Point(816, 9);
            label7.Name = "label7";
            label7.Size = new Size(108, 33);
            label7.TabIndex = 17;
            label7.Text = "Worlds :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label6.Location = new Point(12, 463);
            label6.Name = "label6";
            label6.Size = new Size(143, 33);
            label6.TabIndex = 16;
            label6.Text = "Inventory  :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, 440);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1600, 10);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(790, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 900);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Actions
            // 
            Actions.AutoSize = true;
            Actions.Font = new Font("Calibri", 20F, FontStyle.Bold);
            Actions.Location = new Point(12, 91);
            Actions.Name = "Actions";
            Actions.Size = new Size(0, 33);
            Actions.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 12;
            label1.Text = "Action :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Forest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1584, 861);
            Controls.Add(Action);
            Controls.Add(Events);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Actions);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Forest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Forest";
            Load += Forest_Load;
            KeyDown += Forest_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Action;
        private Label Events;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label Actions;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}