
namespace RobotGame.DesktopUI
{
    partial class MainForm
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
            this.chargeButton = new System.Windows.Forms.Button();
            this.moveToChargingRoomButton = new System.Windows.Forms.Button();
            this.moveToPlayingRoomButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chargingListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playingListBox = new System.Windows.Forms.ListBox();
            this.playButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargeButton
            // 
            this.chargeButton.Location = new System.Drawing.Point(6, 272);
            this.chargeButton.Name = "chargeButton";
            this.chargeButton.Size = new System.Drawing.Size(304, 27);
            this.chargeButton.TabIndex = 11;
            this.chargeButton.Text = "Charge";
            this.chargeButton.UseVisualStyleBackColor = true;
            // 
            // moveToChargingRoomButton
            // 
            this.moveToChargingRoomButton.Location = new System.Drawing.Point(349, 172);
            this.moveToChargingRoomButton.Name = "moveToChargingRoomButton";
            this.moveToChargingRoomButton.Size = new System.Drawing.Size(96, 22);
            this.moveToChargingRoomButton.TabIndex = 9;
            this.moveToChargingRoomButton.Text = "<<";
            this.moveToChargingRoomButton.UseVisualStyleBackColor = true;
            // 
            // moveToPlayingRoomButton
            // 
            this.moveToPlayingRoomButton.Location = new System.Drawing.Point(349, 133);
            this.moveToPlayingRoomButton.Name = "moveToPlayingRoomButton";
            this.moveToPlayingRoomButton.Size = new System.Drawing.Size(96, 22);
            this.moveToPlayingRoomButton.TabIndex = 10;
            this.moveToPlayingRoomButton.Text = ">>";
            this.moveToPlayingRoomButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chargeButton);
            this.groupBox2.Controls.Add(this.chargingListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 314);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charging Room";
            // 
            // chargingListBox
            // 
            this.chargingListBox.FormattingEnabled = true;
            this.chargingListBox.Location = new System.Drawing.Point(6, 29);
            this.chargingListBox.Name = "chargingListBox";
            this.chargingListBox.Size = new System.Drawing.Size(304, 225);
            this.chargingListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playingListBox);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Location = new System.Drawing.Point(461, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 314);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playing Room";
            // 
            // playingListBox
            // 
            this.playingListBox.FormattingEnabled = true;
            this.playingListBox.Location = new System.Drawing.Point(6, 29);
            this.playingListBox.Name = "playingListBox";
            this.playingListBox.Size = new System.Drawing.Size(304, 225);
            this.playingListBox.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(6, 272);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(304, 27);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 348);
            this.Controls.Add(this.moveToChargingRoomButton);
            this.Controls.Add(this.moveToPlayingRoomButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Game";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chargeButton;
        private System.Windows.Forms.Button moveToChargingRoomButton;
        private System.Windows.Forms.Button moveToPlayingRoomButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox chargingListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox playingListBox;
        private System.Windows.Forms.Button playButton;
    }
}

