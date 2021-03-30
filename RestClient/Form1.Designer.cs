namespace RestClient
{
    partial class Form1
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
            this.textRequest = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdBtn = new System.Windows.Forms.Button();
            this.reqlLabel = new System.Windows.Forms.Label();
            this.respLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textRequest
            // 
            this.textRequest.Location = new System.Drawing.Point(173, 38);
            this.textRequest.Name = "textRequest";
            this.textRequest.Size = new System.Drawing.Size(268, 20);
            this.textRequest.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(173, 74);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(410, 169);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdBtn
            // 
            this.cmdBtn.Location = new System.Drawing.Point(447, 38);
            this.cmdBtn.Name = "cmdBtn";
            this.cmdBtn.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn.TabIndex = 2;
            this.cmdBtn.Text = "Go";
            this.cmdBtn.UseVisualStyleBackColor = true;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // reqlLabel
            // 
            this.reqlLabel.AutoSize = true;
            this.reqlLabel.Location = new System.Drawing.Point(92, 41);
            this.reqlLabel.Name = "reqlLabel";
            this.reqlLabel.Size = new System.Drawing.Size(75, 13);
            this.reqlLabel.TabIndex = 3;
            this.reqlLabel.Text = "Request URL:";
            // 
            // respLabel
            // 
            this.respLabel.AutoSize = true;
            this.respLabel.Location = new System.Drawing.Point(92, 77);
            this.respLabel.Name = "respLabel";
            this.respLabel.Size = new System.Drawing.Size(58, 13);
            this.respLabel.TabIndex = 4;
            this.respLabel.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 268);
            this.Controls.Add(this.respLabel);
            this.Controls.Add(this.reqlLabel);
            this.Controls.Add(this.cmdBtn);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.textRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdBtn;
        private System.Windows.Forms.Label reqlLabel;
        private System.Windows.Forms.Label respLabel;
    }
}

