namespace Client
{
	partial class Client
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.tbxText = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbxIP = new System.Windows.Forms.TextBox();
			this.tbxPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbxStatus = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxReceive = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27472F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.50549F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 455);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSend);
			this.groupBox1.Controls.Add(this.tbxText);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(498, 60);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter text:";
			// 
			// btnSend
			// 
			this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSend.Location = new System.Drawing.Point(370, 22);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 6;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// tbxText
			// 
			this.tbxText.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxText.Location = new System.Drawing.Point(42, 22);
			this.tbxText.Name = "tbxText";
			this.tbxText.Size = new System.Drawing.Size(322, 23);
			this.tbxText.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbxIP);
			this.panel1.Controls.Add(this.tbxPort);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnDisconnect);
			this.panel1.Controls.Add(this.btnConnect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(498, 109);
			this.panel1.TabIndex = 0;
			// 
			// tbxIP
			// 
			this.tbxIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxIP.Location = new System.Drawing.Point(73, 15);
			this.tbxIP.Name = "tbxIP";
			this.tbxIP.Size = new System.Drawing.Size(179, 23);
			this.tbxIP.TabIndex = 1;
			this.tbxIP.Text = "127.0.0.1";
			// 
			// tbxPort
			// 
			this.tbxPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxPort.Location = new System.Drawing.Point(336, 15);
			this.tbxPort.Name = "tbxPort";
			this.tbxPort.Size = new System.Drawing.Size(100, 23);
			this.tbxPort.TabIndex = 2;
			this.tbxPort.Text = "9000";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "IP:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(292, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port:";
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDisconnect.Location = new System.Drawing.Point(257, 51);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(98, 51);
			this.btnDisconnect.TabIndex = 4;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnConnect.Location = new System.Drawing.Point(136, 51);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(98, 51);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbxStatus);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.tbxReceive);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 184);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(498, 268);
			this.panel3.TabIndex = 2;
			// 
			// tbxStatus
			// 
			this.tbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxStatus.Location = new System.Drawing.Point(181, 236);
			this.tbxStatus.Name = "tbxStatus";
			this.tbxStatus.ReadOnly = true;
			this.tbxStatus.Size = new System.Drawing.Size(282, 23);
			this.tbxStatus.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 239);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Connection Status:";
			// 
			// tbxReceive
			// 
			this.tbxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxReceive.Location = new System.Drawing.Point(9, 3);
			this.tbxReceive.Multiline = true;
			this.tbxReceive.Name = "tbxReceive";
			this.tbxReceive.ReadOnly = true;
			this.tbxReceive.Size = new System.Drawing.Size(480, 227);
			this.tbxReceive.TabIndex = 0;
			// 
			// Client
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 455);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Client";
			this.Text = "Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox tbxText;
		private System.Windows.Forms.TextBox tbxReceive;
		private System.Windows.Forms.TextBox tbxStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxIP;
		private System.Windows.Forms.TextBox tbxPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

