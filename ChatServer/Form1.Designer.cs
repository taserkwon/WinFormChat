namespace ChatServer
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
			btnServerStart = new Button();
			btnServerStop = new Button();
			label1 = new Label();
			listBox1 = new ListBox();
			listBox2 = new ListBox();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// btnServerStart
			// 
			btnServerStart.Location = new Point(12, 27);
			btnServerStart.Name = "btnServerStart";
			btnServerStart.Size = new Size(70, 50);
			btnServerStart.TabIndex = 0;
			btnServerStart.Text = "서버 시작";
			btnServerStart.UseVisualStyleBackColor = true;
			btnServerStart.Click += btnServerStart_Click;
			// 
			// btnServerStop
			// 
			btnServerStop.Location = new Point(88, 27);
			btnServerStop.Name = "btnServerStop";
			btnServerStop.Size = new Size(70, 50);
			btnServerStop.TabIndex = 1;
			btnServerStop.Text = "서버 종료";
			btnServerStop.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(40, 15);
			label1.TabIndex = 2;
			label1.Text = "Server";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 123);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(223, 319);
			listBox1.TabIndex = 3;
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 15;
			listBox2.Location = new Point(241, 123);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(547, 319);
			listBox2.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(241, 105);
			label2.Name = "label2";
			label2.Size = new Size(59, 15);
			label2.TabIndex = 5;
			label2.Text = "서버 콘솔";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 105);
			label3.Name = "label3";
			label3.Size = new Size(71, 15);
			label3.TabIndex = 6;
			label3.Text = "접속자 명단";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(listBox2);
			Controls.Add(listBox1);
			Controls.Add(label1);
			Controls.Add(btnServerStop);
			Controls.Add(btnServerStart);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnServerStart;
		private Button btnServerStop;
		private Label label1;
		private ListBox listBox1;
		private ListBox listBox2;
		private Label label2;
		private Label label3;
	}
}