
namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.responseLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.responseTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(47, 6);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(147, 20);
            this.hostTextBox.TabIndex = 0;
            this.hostTextBox.TextChanged += new System.EventHandler(this.hostTextBox_TextChanged);
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(9, 9);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(32, 13);
            this.hostLabel.TabIndex = 1;
            this.hostLabel.Text = "Host:";
            this.hostLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(200, 9);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            this.portLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(235, 6);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(62, 20);
            this.portTextBox.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(303, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(47, 36);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(331, 20);
            this.msgTextBox.TabIndex = 5;
            this.msgTextBox.TextChanged += new System.EventHandler(this.msgTextBox_TextChanged);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(11, 43);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(30, 13);
            this.msgLabel.TabIndex = 6;
            this.msgLabel.Text = "Msg:";
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(302, 62);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(76, 23);
            this.requestButton.TabIndex = 7;
            this.requestButton.Text = "Send";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(9, 72);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(58, 13);
            this.responseLabel.TabIndex = 8;
            this.responseLabel.Text = "Response:";
            this.responseLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(77, 71);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(0, 13);
            this.contentLabel.TabIndex = 9;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(303, 92);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // responseTextLabel
            // 
            this.responseTextLabel.AutoSize = true;
            this.responseTextLabel.Location = new System.Drawing.Point(74, 72);
            this.responseTextLabel.Name = "responseTextLabel";
            this.responseTextLabel.Size = new System.Drawing.Size(10, 13);
            this.responseTextLabel.TabIndex = 11;
            this.responseTextLabel.Text = "-";
            this.responseTextLabel.Click += new System.EventHandler(this.responseTextLabel_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 127);
            this.Controls.Add(this.responseTextLabel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.hostTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label responseTextLabel;
    }
}

