using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace Cartelera
{
    public partial class Form1 : Form
    {
        CRUD Gestor;

        SqlConnection con = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Code,Estado FROM Estados", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Estado"] = "Seleccionar un Estado";
            dt.Rows.InsertAt(fila, 0);

            cbxEstado.ValueMember = "Code";
            cbxEstado.DisplayMember = "Estado";
            cbxEstado.DataSource = dt;
        }

        public void cargaMunicipio(string id_estado)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Code, Municipio FROM Municipios WHERE Code = @Code", con);
            cmd.Parameters.AddWithValue("Code", id_estado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow dr = dt.NewRow();
            dr["Municipio"] = "Selecciona un Municipio";
            dt.Rows.InsertAt(dr, 0);

            cbxMunicipio.ValueMember = "Code";
            cbxMunicipio.DisplayMember = "Municipio";
            cbxMunicipio.DataSource = dt;
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cbxEstado.SelectedIndex == 0)
            {
                MessageBox.Show("favor de elegir un Estado");
            }
            else
            {
                if (cbxMunicipio.SelectedIndex == 0)
                {
                    MessageBox.Show("favor de elegir un Municipio");
                }
                else
                {
                    if (cbxMunicipio.SelectedItem != null)
                    {
                        MessageBox.Show("Bienvenido al cine de " + cbxMunicipio.Text.ToString());

                        this.Hide();
                        CarteleraCliente frm = new CarteleraCliente();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("favor de elegir una opcion");
                    }
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (cbxEstado.SelectedIndex == 0)
            {
                MessageBox.Show("favor de elegir un Estado");
            }
            else
            {
                if (cbxMunicipio.SelectedIndex == 0)
                {
                    MessageBox.Show("favor de elegir un Municipio");
                }
                else
                {
                    if (cbxMunicipio.SelectedItem != null)
                    {
                        MessageBox.Show("Bienvenido al cine de " + cbxMunicipio.Text.ToString());

                        this.Hide();
                        Admin frm = new Admin();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("favor de elegir una opcion");
                    }
                }
            }
            
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstado.SelectedValue.ToString() != null)
            {
                string id_municipio = cbxEstado.SelectedValue.ToString();
                cargaMunicipio(id_municipio);
            }
        }
    }
}
