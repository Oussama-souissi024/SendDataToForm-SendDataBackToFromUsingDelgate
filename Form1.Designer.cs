namespace WindowsFormsApp1
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
			this.txtPersonID1 = new System.Windows.Forms.TextBox();
			this.btnSendData = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenForm3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPersonID2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPersonID1
			// 
			this.txtPersonID1.Location = new System.Drawing.Point(121, 64);
			this.txtPersonID1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPersonID1.Name = "txtPersonID1";
			this.txtPersonID1.Size = new System.Drawing.Size(148, 26);
			this.txtPersonID1.TabIndex = 0;
			// 
			// btnSendData
			// 
			this.btnSendData.Location = new System.Drawing.Point(305, 55);
			this.btnSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSendData.Name = "btnSendData";
			this.btnSendData.Size = new System.Drawing.Size(182, 35);
			this.btnSendData.TabIndex = 1;
			this.btnSendData.Text = "Send Data To Form 2";
			this.btnSendData.UseVisualStyleBackColor = true;
			this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "PersonID";
			// 
			// btnOpenForm3
			// 
			this.btnOpenForm3.Location = new System.Drawing.Point(29, 65);
			this.btnOpenForm3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOpenForm3.Name = "btnOpenForm3";
			this.btnOpenForm3.Size = new System.Drawing.Size(182, 35);
			this.btnOpenForm3.TabIndex = 3;
			this.btnOpenForm3.Text = "Open Form 3";
			this.btnOpenForm3.UseVisualStyleBackColor = true;
			this.btnOpenForm3.Click += new System.EventHandler(this.btnOpenForm3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(261, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "PersonID";
			// 
			// txtPersonID2
			// 
			this.txtPersonID2.ForeColor = System.Drawing.Color.Red;
			this.txtPersonID2.Location = new System.Drawing.Point(361, 65);
			this.txtPersonID2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPersonID2.Name = "txtPersonID2";
			this.txtPersonID2.Size = new System.Drawing.Size(148, 26);
			this.txtPersonID2.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPersonID1);
			this.groupBox1.Controls.Add(this.btnSendData);
			this.groupBox1.Location = new System.Drawing.Point(69, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 137);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SendDataToForm";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnOpenForm3);
			this.groupBox2.Controls.Add(this.txtPersonID2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(69, 189);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(532, 136);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SendDataBackToFromUsingDelgate";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 380);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpenForm3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPersonID2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

