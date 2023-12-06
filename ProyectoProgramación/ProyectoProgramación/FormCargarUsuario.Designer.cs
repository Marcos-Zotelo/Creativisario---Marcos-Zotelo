/*
 * Created by SharpDevelop.
 * User: '
 * Date: 01/12/2023
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoProgramación
{
	partial class FormCargarUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarUsuario));
			this.btn_menu = new System.Windows.Forms.Button();
			this.btn_ingreso = new System.Windows.Forms.Button();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.lbl_user = new System.Windows.Forms.Label();
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
			this.btn_menu.Size = new System.Drawing.Size(57, 43);
			this.btn_menu.TabIndex = 37;
			this.btn_menu.UseVisualStyleBackColor = true;
			this.btn_menu.Click += new System.EventHandler(this.Btn_menuClick);
			// 
			// btn_ingreso
			// 
			this.btn_ingreso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_ingreso.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ingreso.Location = new System.Drawing.Point(150, 207);
			this.btn_ingreso.Name = "btn_ingreso";
			this.btn_ingreso.Size = new System.Drawing.Size(130, 44);
			this.btn_ingreso.TabIndex = 36;
			this.btn_ingreso.Text = "Jugar";
			this.btn_ingreso.UseVisualStyleBackColor = true;
			this.btn_ingreso.Click += new System.EventHandler(this.Btn_ingresoClick);
			// 
			// txt_user
			// 
			this.txt_user.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_user.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_user.Location = new System.Drawing.Point(251, 143);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(100, 32);
			this.txt_user.TabIndex = 35;
			// 
			// lbl_user
			// 
			this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_user.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_user.Location = new System.Drawing.Point(90, 143);
			this.lbl_user.Name = "lbl_user";
			this.lbl_user.Size = new System.Drawing.Size(100, 23);
			this.lbl_user.TabIndex = 34;
			this.lbl_user.Text = "Usuario";
			// 
			// FormCargarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 320);
			this.Controls.Add(this.btn_menu);
			this.Controls.Add(this.btn_ingreso);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.lbl_user);
			this.Name = "FormCargarUsuario";
			this.Text = "Cargar Usuario";
			this.Load += new System.EventHandler(this.FormCargarUsuarioLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.Button btn_ingreso;
		private System.Windows.Forms.Button btn_menu;
	}
}
