namespace FiberTrade2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.destinationIPTextBox = new System.Windows.Forms.TextBox();
            this.destinationPortTextBox = new System.Windows.Forms.TextBox();
            this.sentPacketsLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.StartListeningButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.listenIPTextBox = new System.Windows.Forms.TextBox();
            this.listenPortTextBox = new System.Windows.Forms.TextBox();
            this.receivedPacketsLabel = new System.Windows.Forms.Label();
            this.receivedMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // destinationIPTextBox
            // 
            this.destinationIPTextBox.Location = new System.Drawing.Point(146, 207);
            this.destinationIPTextBox.Name = "destinationIPTextBox";
            this.destinationIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationIPTextBox.TabIndex = 0;
            this.destinationIPTextBox.Text = "IP";
            // 
            // destinationPortTextBox
            // 
            this.destinationPortTextBox.Location = new System.Drawing.Point(252, 207);
            this.destinationPortTextBox.Name = "destinationPortTextBox";
            this.destinationPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationPortTextBox.TabIndex = 1;
            this.destinationPortTextBox.Text = "PORT";
            // 
            // sentPacketsLabel
            // 
            this.sentPacketsLabel.AutoSize = true;
            this.sentPacketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sentPacketsLabel.Location = new System.Drawing.Point(141, 158);
            this.sentPacketsLabel.Name = "sentPacketsLabel";
            this.sentPacketsLabel.Size = new System.Drawing.Size(128, 25);
            this.sentPacketsLabel.TabIndex = 2;
            this.sentPacketsLabel.Text = "Sent Packets";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(202, 289);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 45);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // StartListeningButton
            // 
            this.StartListeningButton.Location = new System.Drawing.Point(497, 289);
            this.StartListeningButton.Name = "StartListeningButton";
            this.StartListeningButton.Size = new System.Drawing.Size(100, 45);
            this.StartListeningButton.TabIndex = 4;
            this.StartListeningButton.Text = "StartListening";
            this.StartListeningButton.UseVisualStyleBackColor = true;
            this.StartListeningButton.Click += new System.EventHandler(this.StartListeningButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(202, 250);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 20);
            this.messageTextBox.TabIndex = 6;
            this.messageTextBox.Text = "message";
            // 
            // listenIPTextBox
            // 
            this.listenIPTextBox.Location = new System.Drawing.Point(497, 207);
            this.listenIPTextBox.Name = "listenIPTextBox";
            this.listenIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.listenIPTextBox.TabIndex = 7;
            this.listenIPTextBox.Text = "IP";
            // 
            // listenPortTextBox
            // 
            this.listenPortTextBox.Location = new System.Drawing.Point(609, 207);
            this.listenPortTextBox.Name = "listenPortTextBox";
            this.listenPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.listenPortTextBox.TabIndex = 8;
            this.listenPortTextBox.Text = "PORT";
            // 
            // receivedPacketsLabel
            // 
            this.receivedPacketsLabel.AutoSize = true;
            this.receivedPacketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedPacketsLabel.Location = new System.Drawing.Point(492, 158);
            this.receivedPacketsLabel.Name = "receivedPacketsLabel";
            this.receivedPacketsLabel.Size = new System.Drawing.Size(168, 25);
            this.receivedPacketsLabel.TabIndex = 9;
            this.receivedPacketsLabel.Text = "Received Packets";
            // 
            // receivedMessageLabel
            // 
            this.receivedMessageLabel.AutoSize = true;
            this.receivedMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivedMessageLabel.Location = new System.Drawing.Point(603, 296);
            this.receivedMessageLabel.Name = "receivedMessageLabel";
            this.receivedMessageLabel.Size = new System.Drawing.Size(179, 25);
            this.receivedMessageLabel.TabIndex = 10;
            this.receivedMessageLabel.Text = "Received Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receivedMessageLabel);
            this.Controls.Add(this.receivedPacketsLabel);
            this.Controls.Add(this.listenPortTextBox);
            this.Controls.Add(this.listenIPTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.StartListeningButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.sentPacketsLabel);
            this.Controls.Add(this.destinationPortTextBox);
            this.Controls.Add(this.destinationIPTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox destinationIPTextBox;
        private System.Windows.Forms.TextBox destinationPortTextBox;
        private System.Windows.Forms.Label sentPacketsLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button StartListeningButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox listenIPTextBox;
        private System.Windows.Forms.TextBox listenPortTextBox;
        private System.Windows.Forms.Label receivedPacketsLabel;
        private System.Windows.Forms.Label receivedMessageLabel;
    }
}

