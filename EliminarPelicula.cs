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
    public partial class EliminarPelicula : Form
    {
        public EliminarPelicula()
        {
            InitializeComponent();
            CargarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");
            cmd.Connection = con;
            cmd.Connection.Open();

            cmd = new SqlCommand("delete from Peliculas where Nombre='" + cbxPeliculas.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("pelicula Eliminada");
            con.Close();

        }
    }
}
