namespace Lab6
{
	partial class Server
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cbxClients = new System.Windows.Forms.ComboBox();
			this.tbxPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxStatus = new System.Windows.Forms.TextBox();
			this.tbxReceive = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.cbxClients);
			this.splitContainer1.Panel1.Controls.Add(this.tbxPort);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.btnStop);
			this.splitContainer1.Panel1.Controls.Add(this.btnStart);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new System.Drawing.Size(504, 443);
			this.splitContainer1.SplitterDistance = 100;
			this.splitContainer1.TabIndex = 0;
			// 
			// cbxClients
			// 
			this.cbxClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxClients.FormattingEnabled = true;
			this.cbxClients.Location = new System.Drawing.Point(92, 68);
			this.cbxClients.Name = "cbxClients";
			this.cbxClients.Size = new System.Drawing.Size(370, 24);
			this.cbxClients.TabIndex = 4;
			// 
			// tbxPort
			// 
			this.tbxPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxPort.Location = new System.Drawing.Point(92, 25);
			this.tbxPort.Name = "tbxPort";
			this.tbxPort.Size = new System.Drawing.Size(100, 23);
			this.tbxPort.TabIndex = 1;
			this.tbxPort.Text = "9000";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clients:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port:";
			// 
			// btnStop
			// 
			this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnStop.Location = new System.Drawing.Point(370, 12);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(92, 49);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(240, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(92, 49);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbxStatus);
			this.groupBox1.Controls.Add(this.tbxReceive);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 339);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Text received from client:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Connection Status:";
			// 
			// tbxStatus
			// 
			this.tbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxStatus.Location = new System.Drawing.Point(180, 304);
			this.tbxStatus.Name = "tbxStatus";
			this.tbxStatus.ReadOnly = true;
			this.tbxStatus.Size = new System.Drawing.Size(282, 23);
			this.tbxStatus.TabIndex = 2;
			// 
			// tbxReceive
			// 
			this.tbxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxReceive.Location = new System.Drawing.Point(6, 22);
			this.tbxReceive.Multiline = true;
			this.tbxReceive.Name = "tbxReceive";
			this.tbxReceive.ReadOnly = true;
			this.tbxReceive.Size = new System.Drawing.Size(492, 270);
			this.tbxReceive.TabIndex = 0;
			// 
			// Server
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnStop;
			this.ClientSize = new System.Drawing.Size(504, 443);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Server";
			this.Text = "Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbxStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxReceive;
		private System.Windows.Forms.TextBox tbxPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxClients;
		private System.Windows.Forms.Label label3;
	}
}

