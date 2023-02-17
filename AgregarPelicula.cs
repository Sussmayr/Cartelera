using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartelera
{
    public partial class AgregarPelicula : Form
    {
        CarteleraEntities Cartelera;
        Peliculas peliculas;
        CRUD Gestor;
        SqlConnection con = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");
        SqlCommand cmd;

        public AgregarPelicula()
        {
            InitializeComponent();
            loadData();
        }

        public AgregarPelicula(Peliculas peliculas)
        {
            InitializeComponent();
            peliculas = new Peliculas();

            if (peliculas != null)
            {
                txtNombre.Enabled = false;

                peliculas.Nombre = txtNombre.Text;
                peliculas.Director = txtDirector.Text;
                peliculas.Productor = txtProductor.Text;
                peliculas.Clasificacion = cbxClasificacion.Text;
                peliculas.Genero = cbxGenero.Text;
                peliculas.Duracion = TimeSpan.Parse(txtDuracion.Text);
            }

            Gestor = new CRUD();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Peliculas values ('" + txtNombre.Text + "','" + txtDirector.Text + "','" + txtProductor.Text + "','" + cbxClasificacion.Text + "','" + txtDuracion.Text + "','" + cbxGenero.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("pelicula agregada");
            con.Close();
            LimpiarControles();
        }

        public void loadData()
        {
            CarteleraEntities dbe = new CarteleraEntities();

            var listaClasificacion = dbe.Clasificacion.ToList();
            foreach (var item in listaClasificacion)
            {
                cbxClasificacion.Items.Add(item.Clasificacion1);
            }

            var listaGenero = dbe.Genero.ToList();
            foreach (var item in listaGenero)
            {
                cbxGenero.Items.Add(item.Genero1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtDirector.Clear();
            txtProductor.Clear();
            cbxClasificacion.Items.Clear();
            cbxGenero.Items.Clear();
            txtDuracion.Clear();
        }
    }
}
