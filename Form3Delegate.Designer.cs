namespace WindowsFormsApp1
{
	partial class Form3Delegate
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtPersonID = new System.Windows.Forms.TextBox();
			this.btnSendDataBackToForm1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(87, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "PersonID";
			// 
			// txtPersonID
			// 
			this.txtPersonID.Location = new System.Drawing.Point(170, 179);
			this.txtPersonID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPersonID.Name = "txtPersonID";
			this.txtPersonID.Size = new System.Drawing.Size(148, 20);
			this.txtPersonID.TabIndex = 11;
			// 
			// btnSendDataBackToForm1
			// 
			this.btnSendDataBackToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSendDataBackToForm1.Location = new System.Drawing.Point(354, 166);
			this.btnSendDataBackToForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSendDataBackToForm1.Name = "btnSendDataBackToForm1";
			this.btnSendDataBackToForm1.Size = new System.Drawing.Size(211, 39);
			this.btnSendDataBackToForm1.TabIndex = 12;
			this.btnSendDataBackToForm1.Text = "Send Data Back To Form 1";
			this.btnSendDataBackToForm1.UseVisualStyleBackColor = true;
			this.btnSendDataBackToForm1.Click += new System.EventHandler(this.btnSendDataBackToForm1_Click);
			// 
			// Form3Delegate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 371);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPersonID);
			this.Controls.Add(this.btnSendDataBackToForm1);
			this.Name = "Form3Delegate";
			this.Text = "Form3Delegate";
			this.Load += new System.EventHandler(this.Form3Delegate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPersonID;
		private System.Windows.Forms.Button btnSendDataBackToForm1;
	}
}