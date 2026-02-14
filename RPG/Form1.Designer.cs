namespace RPG
{
    partial class Form1
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
            label1 = new Label();
            Actions = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Events = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 0;
            label1.Text = "Action :";
            // 
            // Actions
            // 
            Actions.AutoSize = true;
            Actions.Font = new Font("Calibri", 20F, FontStyle.Bold);
            Actions.Location = new Point(12, 91);
            Actions.Name = "Actions";
            Actions.Size = new Size(0, 33);
            Actions.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(790, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 900);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(0, 440);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1600, 10);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label6.Location = new Point(12, 463);
            label6.Name = "label6";
            label6.Size = new Size(143, 33);
            label6.TabIndex = 7;
            label6.Text = "Inventory  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label7.Location = new Point(816, 9);
            label7.Name = "label7";
            label7.Size = new Size(108, 33);
            label7.TabIndex = 8;
            label7.Text = "Worlds :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label8.Location = new Point(816, 463);
            label8.Name = "label8";
            label8.Size = new Size(101, 33);
            label8.TabIndex = 9;
            label8.Text = "Events :";
            // 
            // Events
            // 
            Events.BackColor = SystemColors.InactiveCaptionText;
            Events.BorderStyle = BorderStyle.FixedSingle;
            Events.Font = new Font("Calibri", 12F);
            Events.Location = new Point(816, 496);
            Events.Name = "Events";
            Events.Size = new Size(756, 356);
            Events.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1584, 861);
            Controls.Add(Events);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Actions);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RPG";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Actions;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label Events;
    }
}
