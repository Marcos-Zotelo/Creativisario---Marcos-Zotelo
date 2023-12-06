/*
 * Created by SharpDevelop.
 * User: '
 * Date: 21/11/2023
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoProgramación
{
	partial class FormInsignias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsignias));
			this.btn_menu = new System.Windows.Forms.Button();
			this.lbl_InsCreatvidad = new System.Windows.Forms.Label();
			this.lbl_inisgnias = new System.Windows.Forms.Label();
			this.pic_InsCreatividad = new System.Windows.Forms.PictureBox();
			this.lbl_InsObservacion = new System.Windows.Forms.Label();
			this.pic_InsObservacion = new System.Windows.Forms.PictureBox();
			this.lbl_IngFmental = new System.Windows.Forms.Label();
			this.pic_InsFmental = new System.Windows.Forms.PictureBox();
			this.lbl_InsRproblemas = new System.Windows.Forms.Label();
			this.pic_InsRproblemas = new System.Windows.Forms.PictureBox();
			this.lbl_InsPersistencia = new System.Windows.Forms.Label();
			this.pic_InsPersistencia = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsCreatividad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsObservacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsFmental)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsRproblemas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsPersistencia)).BeginInit();
			this.SuspendLayout();
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
			this.btn_menu.Size = new System.Drawing.Size(57, 31);
			this.btn_menu.TabIndex = 39;
			this.btn_menu.UseVisualStyleBackColor = true;
			this.btn_menu.Click += new System.EventHandler(this.Btn_menuClick);
			// 
			// lbl_InsCreatvidad
			// 
			this.lbl_InsCreatvidad.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_InsCreatvidad.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_InsCreatvidad.Location = new System.Drawing.Point(38, 67);
			this.lbl_InsCreatvidad.Name = "lbl_InsCreatvidad";
			this.lbl_InsCreatvidad.Size = new System.Drawing.Size(147, 41);
			this.lbl_InsCreatvidad.TabIndex = 37;
			this.lbl_InsCreatvidad.Text = "Creatividad";
			this.lbl_InsCreatvidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_inisgnias
			// 
			this.lbl_inisgnias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_inisgnias.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_inisgnias.Location = new System.Drawing.Point(236, -3);
			this.lbl_inisgnias.Name = "lbl_inisgnias";
			this.lbl_inisgnias.Size = new System.Drawing.Size(290, 78);
			this.lbl_inisgnias.TabIndex = 36;
			this.lbl_inisgnias.Text = "Insignias";
			this.lbl_inisgnias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_InsCreatividad
			// 
			this.pic_InsCreatividad.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_InsCreatividad.Location = new System.Drawing.Point(38, 111);
			this.pic_InsCreatividad.Name = "pic_InsCreatividad";
			this.pic_InsCreatividad.Size = new System.Drawing.Size(160, 86);
			this.pic_InsCreatividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_InsCreatividad.TabIndex = 35;
			this.pic_InsCreatividad.TabStop = false;
			this.pic_InsCreatividad.Click += new System.EventHandler(this.Pic_InsCreatividadClick);
			// 
			// lbl_InsObservacion
			// 
			this.lbl_InsObservacion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_InsObservacion.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_InsObservacion.Location = new System.Drawing.Point(306, 67);
			this.lbl_InsObservacion.Name = "lbl_InsObservacion";
			this.lbl_InsObservacion.Size = new System.Drawing.Size(147, 41);
			this.lbl_InsObservacion.TabIndex = 41;
			this.lbl_InsObservacion.Text = "Observación";
			this.lbl_InsObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_InsObservacion
			// 
			this.pic_InsObservacion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_InsObservacion.Location = new System.Drawing.Point(306, 111);
			this.pic_InsObservacion.Name = "pic_InsObservacion";
			this.pic_InsObservacion.Size = new System.Drawing.Size(160, 86);
			this.pic_InsObservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_InsObservacion.TabIndex = 40;
			this.pic_InsObservacion.TabStop = false;
			this.pic_InsObservacion.Click += new System.EventHandler(this.Pic_InsObservacionClick);
			// 
			// lbl_IngFmental
			// 
			this.lbl_IngFmental.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_IngFmental.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_IngFmental.Location = new System.Drawing.Point(575, 49);
			this.lbl_IngFmental.Name = "lbl_IngFmental";
			this.lbl_IngFmental.Size = new System.Drawing.Size(147, 59);
			this.lbl_IngFmental.TabIndex = 43;
			this.lbl_IngFmental.Text = "Flexibilidad mental";
			this.lbl_IngFmental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_InsFmental
			// 
			this.pic_InsFmental.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_InsFmental.Location = new System.Drawing.Point(575, 111);
			this.pic_InsFmental.Name = "pic_InsFmental";
			this.pic_InsFmental.Size = new System.Drawing.Size(160, 86);
			this.pic_InsFmental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_InsFmental.TabIndex = 42;
			this.pic_InsFmental.TabStop = false;
			this.pic_InsFmental.Click += new System.EventHandler(this.Pic_InsFmentalClick);
			// 
			// lbl_InsRproblemas
			// 
			this.lbl_InsRproblemas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_InsRproblemas.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_InsRproblemas.Location = new System.Drawing.Point(477, 277);
			this.lbl_InsRproblemas.Name = "lbl_InsRproblemas";
			this.lbl_InsRproblemas.Size = new System.Drawing.Size(185, 65);
			this.lbl_InsRproblemas.TabIndex = 47;
			this.lbl_InsRproblemas.Text = "Resolución de problemas";
			this.lbl_InsRproblemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_InsRproblemas
			// 
			this.pic_InsRproblemas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_InsRproblemas.Location = new System.Drawing.Point(478, 347);
			this.pic_InsRproblemas.Name = "pic_InsRproblemas";
			this.pic_InsRproblemas.Size = new System.Drawing.Size(160, 86);
			this.pic_InsRproblemas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_InsRproblemas.TabIndex = 46;
			this.pic_InsRproblemas.TabStop = false;
			this.pic_InsRproblemas.Click += new System.EventHandler(this.Pic_InsRproblemasClick);
			// 
			// lbl_InsPersistencia
			// 
			this.lbl_InsPersistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_InsPersistencia.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_InsPersistencia.Location = new System.Drawing.Point(38, 279);
			this.lbl_InsPersistencia.Name = "lbl_InsPersistencia";
			this.lbl_InsPersistencia.Size = new System.Drawing.Size(147, 41);
			this.lbl_InsPersistencia.TabIndex = 49;
			this.lbl_InsPersistencia.Text = "Persistencia";
			this.lbl_InsPersistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pic_InsPersistencia
			// 
			this.pic_InsPersistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_InsPersistencia.Location = new System.Drawing.Point(38, 323);
			this.pic_InsPersistencia.Name = "pic_InsPersistencia";
			this.pic_InsPersistencia.Size = new System.Drawing.Size(160, 86);
			this.pic_InsPersistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_InsPersistencia.TabIndex = 48;
			this.pic_InsPersistencia.TabStop = false;
			this.pic_InsPersistencia.Click += new System.EventHandler(this.Pic_InsPersistenciaClick);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 79);
			this.label3.TabIndex = 50;
			this.label3.Click += new System.EventHandler(this.Pic_InsCreatividadClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(285, 200);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 92);
			this.label1.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(562, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(207, 79);
			this.label2.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(204, 323);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(207, 91);
			this.label4.TabIndex = 53;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(644, 342);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(207, 91);
			this.label5.TabIndex = 54;
			// 
			// FormInsignias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 462);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbl_InsPersistencia);
			this.Controls.Add(this.pic_InsPersistencia);
			this.Controls.Add(this.lbl_InsRproblemas);
			this.Controls.Add(this.pic_InsRproblemas);
			this.Controls.Add(this.lbl_IngFmental);
			this.Controls.Add(this.pic_InsFmental);
			this.Controls.Add(this.lbl_InsObservacion);
			this.Controls.Add(this.pic_InsObservacion);
			this.Controls.Add(this.btn_menu);
			this.Controls.Add(this.lbl_InsCreatvidad);
			this.Controls.Add(this.lbl_inisgnias);
			this.Controls.Add(this.pic_InsCreatividad);
			this.Name = "FormInsignias";
			this.Text = "Insignias";
			((System.ComponentModel.ISupportInitialize)(this.pic_InsCreatividad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsObservacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsFmental)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsRproblemas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_InsPersistencia)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pic_InsPersistencia;
		private System.Windows.Forms.Label lbl_InsPersistencia;
		private System.Windows.Forms.PictureBox pic_InsRproblemas;
		private System.Windows.Forms.Label lbl_InsRproblemas;
		private System.Windows.Forms.PictureBox pic_InsFmental;
		private System.Windows.Forms.Label lbl_InsObservacion;
		private System.Windows.Forms.PictureBox pic_InsObservacion;
		private System.Windows.Forms.PictureBox pic_InsCreatividad;
		private System.Windows.Forms.Label lbl_inisgnias;
		private System.Windows.Forms.Label lbl_InsCreatvidad;
		private System.Windows.Forms.Label lbl_IngFmental;
		private System.Windows.Forms.Button btn_menu;
	}
}
