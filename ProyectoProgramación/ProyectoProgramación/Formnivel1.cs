using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoProgramación
{
    public partial class Formnivel1 : Form
    {
    	public string nombre;
    	public int time = 0;
    	private int userId;
    	ClassConexion miConexion;
        private Timer imagenTimer;
        public string imagePath = @"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\fotos de niveles\Curiosidad.jpg";
        private int punt = 0;
        private PictureBox[] pictureBoxes; 

        public Formnivel1(int userId)
        {
            InitializeComponent();
            imagenTimer = new Timer();
            imagenTimer.Interval = 2500;
            imagenTimer.Tick += ImagenTimer_Tick;
            Timer cronometro = new Timer();
            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            this.userId = userId;
            

        }
        
        private void ImagenTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                int num = rnd.Next(2); 
                pictureBox.Visible = false;
                pictureBox.Tag = "0";

                pictureBox.Image = Image.FromFile(imagePath);

                if (num == 1)
                {
                    pictureBox.Visible = true;
                }
            }
           }
        
        private void MostrarYDesaparecerImagen()
        {
        	 
            imagenTimer.Start();
            pictureBox1.ImageLocation = imagePath;
            pictureBox2.ImageLocation = imagePath;
            pictureBox3.ImageLocation = imagePath;
            pictureBox4.ImageLocation = imagePath;
            pictureBox5.ImageLocation = imagePath;
        }
   
        void Formnivel1Load(object sender, EventArgs e)
        {
        	miConexion = new ClassConexion();
    		miConexion.CrearConexion();
        	nombre = miConexion.ObtenerNombreUsuario(userId); 
        	lbl_userNombre.Text = nombre;
        	timer1.Start();          	
            MostrarYDesaparecerImagen();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }
        
        void Btn_menuClick(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea regresar al menu?", "Salir", MessageBoxButtons.YesNo);
            
            if(resultado == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }
        void Timer1Tick(object sender, EventArgs e)
       {

            lbl_puntaje.Text = punt.ToString();  
            timer1.Stop(); 
            
            if (punt<2000){
            		imagenTimer.Stop();
					MessageBox.Show("Game Over", "Has perdido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            		MainForm mainForm = new MainForm();
                	mainForm.Show();
                	this.Close();
            }
        }
  
       void PictureBox5Click(object sender, EventArgs e)
        {
			PictureBox pic = (PictureBox)sender;
            string explosionPath = AppDomain.CurrentDomain.BaseDirectory + @"\img\explosion.png";
			if (pic.Tag.ToString() == "0"){
				pic.Image = Image.FromFile(explosionPath);                            
				punt += 100;
				lbl_puntaje.Text = punt.ToString();    
				if (punt==2000){
					MessageBox.Show("¡Pasaste de nivel!, Vamos por el siguiente", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
					string qry = "exec sp_ActualizarNivelUsuario '" + userId + "', 2";
		    		miConexion.EjecutarSentencia(qry);
					Formnivel2 nivel2 = new Formnivel2(userId);
            		nivel2.Show();
            		this.Hide();
				}
				pic.Tag = "1";
			}            
        }	
		
	
		
		void Timer2Tick(object sender, EventArgs e)
		{
			time++;
        	lbl_tiemp.Text = time.ToString();			
		}
    }
}
