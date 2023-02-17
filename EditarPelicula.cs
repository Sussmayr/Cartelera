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
    public partial class EditarPelicula : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");
        SqlCommand cmd;
        public EditarPelicula()
        {
            InitializeComponent();
            CargarLista();
            loadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update Peliculas set Director= '" + txtDirector.Text + "',Productor= '" + txtProductor.Text +
                "',Clasificacion= '" + cbxClasificacion.Text + "',Duracion= '" + txtDuracion.Text + "',Genero= '" + cbxGenero.Text + 
                "'where Nombre= '" + cbxPeliculas.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("pelicula modificada");
            con.Close();
            LimpiarControles();
        }

        public void CargarLista()
        {
            //generar lista con las peliculas
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");
            List<string> inputStr = new List<string>();
            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT Nombre FROM Peliculas";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(0).ToString());
            }

            cbxPeliculas.DataSource = inputStr;

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
            txtDirector.Clear();
            txtProductor.Clear();
            cbxClasificacion.Items.Clear();
            cbxGenero.Items.Clear();
            txtDuracion.Clear();
        }

        private void cbxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Peliculas WHERE Nombre = '" + cbxPeliculas.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Director = (string)dr["Director"].ToString();
                txtDirector.Text = Director;

                string Productor = (string)dr["Productor"].ToString();
                txtProductor.Text = Productor;

                string Clasificacion = (string)dr["Clasificacion"].ToString();
                cbxClasificacion.Text = Clasificacion;

                string Duracion = (string)dr["Duracion"].ToString();
                txtDuracion.Text = Duracion;

                string Genero = (string)dr["Genero"].ToString();
                cbxGenero.Text = Genero;
            }
            con.Close();
        }
    }
}
