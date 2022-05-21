/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 5/21/2022
 * Time: 9:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Download_dan_Upload_PV2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnopenupload = new System.Windows.Forms.Button();
			this.btnsaveupload = new System.Windows.Forms.Button();
			this.btnopendownload = new System.Windows.Forms.Button();
			this.btnsavedownload = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Input_id = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(110, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(434, 310);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox2.Location = new System.Drawing.Point(718, 79);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(434, 309);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// btnopenupload
			// 
			this.btnopenupload.Location = new System.Drawing.Point(198, 435);
			this.btnopenupload.Name = "btnopenupload";
			this.btnopenupload.Size = new System.Drawing.Size(101, 43);
			this.btnopenupload.TabIndex = 2;
			this.btnopenupload.Text = "Open File";
			this.btnopenupload.UseVisualStyleBackColor = true;
			this.btnopenupload.Click += new System.EventHandler(this.BtnopenuploadClick);
			// 
			// btnsaveupload
			// 
			this.btnsaveupload.Location = new System.Drawing.Point(326, 435);
			this.btnsaveupload.Name = "btnsaveupload";
			this.btnsaveupload.Size = new System.Drawing.Size(101, 43);
			this.btnsaveupload.TabIndex = 3;
			this.btnsaveupload.Text = "Save File";
			this.btnsaveupload.UseVisualStyleBackColor = true;
			this.btnsaveupload.Click += new System.EventHandler(this.BtnsaveuploadClick);
			// 
			// btnopendownload
			// 
			this.btnopendownload.Location = new System.Drawing.Point(817, 435);
			this.btnopendownload.Name = "btnopendownload";
			this.btnopendownload.Size = new System.Drawing.Size(101, 43);
			this.btnopendownload.TabIndex = 4;
			this.btnopendownload.Text = "Open File";
			this.btnopendownload.UseVisualStyleBackColor = true;
			this.btnopendownload.Click += new System.EventHandler(this.BtnopendownloadClick);
			// 
			// btnsavedownload
			// 
			this.btnsavedownload.Location = new System.Drawing.Point(950, 435);
			this.btnsavedownload.Name = "btnsavedownload";
			this.btnsavedownload.Size = new System.Drawing.Size(101, 43);
			this.btnsavedownload.TabIndex = 5;
			this.btnsavedownload.Text = "Save File";
			this.btnsavedownload.UseVisualStyleBackColor = true;
			this.btnsavedownload.Click += new System.EventHandler(this.BtnsavedownloadClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(110, 526);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1042, 231);
			this.dataGridView1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(222, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 49);
			this.label1.TabIndex = 7;
			this.label1.Text = "Tes Upload File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(839, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 49);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tes Download File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(930, 391);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Input id untuk di load";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label4.Location = new System.Drawing.Point(462, 487);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(293, 36);
			this.label4.TabIndex = 10;
			this.label4.Text = "Data Dari Database";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Input_id
			// 
			this.Input_id.Location = new System.Drawing.Point(1051, 388);
			this.Input_id.Name = "Input_id";
			this.Input_id.Size = new System.Drawing.Size(101, 20);
			this.Input_id.TabIndex = 11;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1249, 768);
			this.Controls.Add(this.Input_id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnsavedownload);
			this.Controls.Add(this.btnopendownload);
			this.Controls.Add(this.btnsaveupload);
			this.Controls.Add(this.btnopenupload);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Download dan Upload PV2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox Input_id;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnsavedownload;
		private System.Windows.Forms.Button btnopendownload;
		private System.Windows.Forms.Button btnsaveupload;
		private System.Windows.Forms.Button btnopenupload;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
