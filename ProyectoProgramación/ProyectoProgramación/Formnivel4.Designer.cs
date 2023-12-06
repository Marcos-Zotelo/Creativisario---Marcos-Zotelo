/*
 * Created by SharpDevelop.
 * User: '
 * Date: 21/11/2023
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoProgramación
{
	partial class Formnivel4
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formnivel4));
			this.lbl_puntaje = new System.Windows.Forms.Label();
			this.btn_menu = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_persistencia = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbl_userNombre = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.lbl_tiemp = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_puntaje
			// 
			this.lbl_puntaje.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_puntaje.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_puntaje.Location = new System.Drawing.Point(235, 80);
			this.lbl_puntaje.Name = "lbl_puntaje";
			this.lbl_puntaje.Size = new System.Drawing.Size(159, 32);
			this.lbl_puntaje.TabIndex = 33;
			// 
			// btn_menu
			// 
			this.btn_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.BackgroundImage")));
			this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_menu.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
			this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_menu.Location = new System.Drawing.Point(12, 12);
			this.btn_menu.Name = "btn_menu";
			this.btn_menu.Size = new System.Drawing.Size(57, 41);
			this.btn_menu.TabIndex = 32;
			this.btn_menu.UseVisualStyleBackColor = true;
			this.btn_menu.Click += new System.EventHandler(this.Btn_menuClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 41);
			this.label1.TabIndex = 30;
			this.label1.Text = "Tu puntaje:";
			// 
			// lbl_persistencia
			// 
			this.lbl_persistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_persistencia.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_persistencia.Location = new System.Drawing.Point(275, 12);
			this.lbl_persistencia.Name = "lbl_persistencia";
			this.lbl_persistencia.Size = new System.Drawing.Size(290, 41);
			this.lbl_persistencia.TabIndex = 29;
			this.lbl_persistencia.Text = "Nivel 4: Persistencia";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox5.Location = new System.Drawing.Point(110, 142);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(160, 86);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 28;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "0";
			this.pictureBox5.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.Location = new System.Drawing.Point(331, 215);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(160, 86);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "0";
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Location = new System.Drawing.Point(573, 142);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 86);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "0";
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox4.Location = new System.Drawing.Point(110, 299);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(160, 86);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 25;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "0";
			this.pictureBox4.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox3.Location = new System.Drawing.Point(573, 287);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(161, 86);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 24;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "0";
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(331, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 46);
			this.label3.TabIndex = 36;
			this.label3.Text = "Consigue 2000 puntos ";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 30000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// lbl_userNombre
			// 
			this.lbl_userNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_userNombre.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_userNombre.Location = new System.Drawing.Point(99, 12);
			this.lbl_userNombre.Name = "lbl_userNombre";
			this.lbl_userNombre.Size = new System.Drawing.Size(171, 56);
			this.lbl_userNombre.TabIndex = 37;
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// lbl_tiemp
			// 
			this.lbl_tiemp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_tiemp.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tiemp.Location = new System.Drawing.Point(635, 22);
			this.lbl_tiemp.Name = "lbl_tiemp";
			this.lbl_tiemp.Size = new System.Drawing.Size(170, 46);
			this.lbl_tiemp.TabIndex = 38;
			// 
			// Formnivel4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 466);
			this.Controls.Add(this.lbl_tiemp);
			this.Controls.Add(this.lbl_userNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl_puntaje);
			this.Controls.Add(this.btn_menu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_persistencia);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Name = "Formnivel4";
			this.Text = "Nivel 4";
			this.Load += new System.EventHandler(this.Formnivel4Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_tiemp;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label lbl_userNombre;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label lbl_persistencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_menu;
		private System.Windows.Forms.Label lbl_puntaje;
	}
}
