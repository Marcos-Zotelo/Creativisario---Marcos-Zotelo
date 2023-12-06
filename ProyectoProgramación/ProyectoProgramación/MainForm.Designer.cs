/*
 * Created by SharpDevelop.
 * User: '
 * Date: 07/11/2023
 * Time: 9:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoProgramación
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnInsignias = new System.Windows.Forms.Button();
			this.btnCargarJuego = new System.Windows.Forms.Button();
			this.btnNuevoJuego = new System.Windows.Forms.Button();
			this.pic_logo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSalir.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(346, 303);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(130, 44);
			this.btnSalir.TabIndex = 30;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnInsignias
			// 
			this.btnInsignias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnInsignias.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsignias.Location = new System.Drawing.Point(346, 253);
			this.btnInsignias.Name = "btnInsignias";
			this.btnInsignias.Size = new System.Drawing.Size(130, 44);
			this.btnInsignias.TabIndex = 29;
			this.btnInsignias.Text = "Insignias";
			this.btnInsignias.UseVisualStyleBackColor = true;
			this.btnInsignias.Click += new System.EventHandler(this.BtnInsigniasClick);
			// 
			// btnCargarJuego
			// 
			this.btnCargarJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCargarJuego.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCargarJuego.Location = new System.Drawing.Point(346, 203);
			this.btnCargarJuego.Name = "btnCargarJuego";
			this.btnCargarJuego.Size = new System.Drawing.Size(130, 44);
			this.btnCargarJuego.TabIndex = 28;
			this.btnCargarJuego.Text = "Cargar juego";
			this.btnCargarJuego.UseVisualStyleBackColor = true;
			this.btnCargarJuego.Click += new System.EventHandler(this.BtnCargarJuegoClick);
			// 
			// btnNuevoJuego
			// 
			this.btnNuevoJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnNuevoJuego.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevoJuego.Location = new System.Drawing.Point(346, 153);
			this.btnNuevoJuego.Name = "btnNuevoJuego";
			this.btnNuevoJuego.Size = new System.Drawing.Size(130, 44);
			this.btnNuevoJuego.TabIndex = 27;
			this.btnNuevoJuego.Text = "Nuevo juego";
			this.btnNuevoJuego.UseVisualStyleBackColor = true;
			this.btnNuevoJuego.Click += new System.EventHandler(this.BtnNuevoJuegoClick);
			// 
			// pic_logo
			// 
			this.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_logo.Location = new System.Drawing.Point(662, 29);
			this.pic_logo.Name = "pic_logo";
			this.pic_logo.Size = new System.Drawing.Size(100, 98);
			this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_logo.TabIndex = 31;
			this.pic_logo.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 242);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 79);
			this.label1.TabIndex = 32;
			this.label1.Text = "captura las fotos los más rápido que puedas, antes de que sea tarde";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Font = new System.Drawing.Font("Perpetua", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(167, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(489, 98);
			this.label2.TabIndex = 33;
			this.label2.Text = "Creativisario";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(561, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 79);
			this.label4.TabIndex = 35;
			this.label4.Text = "Consigue solucionar problemas con enfoques creativos";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(885, 413);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pic_logo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnInsignias);
			this.Controls.Add(this.btnCargarJuego);
			this.Controls.Add(this.btnNuevoJuego);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Bienvenido";
			this.TransparencyKey = System.Drawing.Color.DarkGray;
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pic_logo;
		private System.Windows.Forms.Button btnNuevoJuego;
		private System.Windows.Forms.Button btnCargarJuego;
		private System.Windows.Forms.Button btnInsignias;
		private System.Windows.Forms.Button btnSalir;
	}
}
