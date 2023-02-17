using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cartelera
{
    public partial class CarteleraCliente : Form
    {
        CRUD Gestor;
        Peliculas pelicula;
        //Registro FormularioRegistro;

        public CarteleraCliente()
        {
            InitializeComponent();
            loadDataCbx();
            mostrarLista();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        public void loadDataCbx()
        {
            CarteleraEntities dbe = new CarteleraEntities();

            var listaEstado = dbe.Clasificacion.ToList();
            foreach (var item in listaEstado)
            {
                cbxClasificacion.Items.Add(item.Clasificacion1);
            }

            var listaMunicipio = dbe.Genero.ToList();
            foreach (var item in listaMunicipio)
            {
                cbxGenero.Items.Add(item.Genero1);
            }
        }

        public void mostrarLista()
        {
            var select = "SELECT * FROM Peliculas";
            var c = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DGVPeliculas.ReadOnly = true;
            DGVPeliculas.DataSource = ds.Tables[0];
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string sql = "SELECT * FROM Peliculas";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection = conn;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ordenar Ascendente
            //conexion SQL
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

            //creacion de lista con informacion de SQL
            List<string> inputStr = new List<string>();

            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM Peliculas";
            SqlDataReader dr = cmd.ExecuteReader();

            //Agregar a lista
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(1).ToString());
            }

            //convertir List <> a Array[]
            string[] myArray = inputStr.ToArray();

            ////Ordenar lista
            quickSortAcendente(myArray, 0, myArray.Length - 1);

            //mostrar lista on DataGridView
            var result = myArray.Select(s => new { value = s }).ToList();
            DGVPeliculas.DataSource = result;
        }

        //*******
        //***QuickSort Acendente***
        static int particion(string[] arr, int start, int end)
        {
            int pivot = end;
            int i = start, j = end;
            string temp;
            while (i < j)
            {
                while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
                    i++;
                while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
                    j--;

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            return j;
        }

        static void quickSortAcendente(string[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = particion(arr, start, end);
                quickSortAcendente(arr, start, pivotIndex - 1);
                quickSortAcendente(arr, pivotIndex + 1, end);
            }
        }
        //*******

        //private ListaPeliculas[] conexionList()
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

        //    ListaPeliculas[] allRecords = null;
        //    //string[] array = null;
        //    string sql = @"SELECT Nombre,Director,Productor,Clasificacion,Duracion,Genero
        //       FROM  Peliculas";

        //    var list = new List<ListaPeliculas>();

        //    using (var command = new SqlCommand(sql, con))
        //    {
        //        con.Open();
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //                list.Add(new ListaPeliculas { Nombre = reader.GetString(1), Director = reader.GetString(2), Productor = reader.GetString(1), Clasificacion = reader.GetString(1), Duracion = reader.GetString(1), Genero = reader.GetString(1), });
        //        }
        //        allRecords = list.ToArray();

        //        return allRecords;
        //    }
        //}


        private void button2_Click(object sender, EventArgs e)
        {
            //ordenar Descendente
            //conexion SQL
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

            //creacion de lista con informacion de SQL
            List<string> inputStr = new List<string>();

            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM Peliculas";
            SqlDataReader dr = cmd.ExecuteReader();

            //Agregar a lista
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(1).ToString());
            }

            //convertir List <> a Array[]
            string[] myArray = inputStr.ToArray();

            //Ordenar lista
            quickSortDescendente(myArray, 0, myArray.Length - 1);

            //mostrar lista on DataGridView
            myArray = myArray.OrderByDescending(d => d).ToArray();
            var result = myArray.Select(s => new { value = s }).ToList();
            DGVPeliculas.DataSource = result;
        }

        //*******
        //***QuickSort Descendente***
        private static int partition(string[] list, int start, int end)
        {
            string pivot = list[end];

            int i = start, j = end;
            string temp;

            while (i < j)
            {
                while (list[i].CompareTo(pivot) <= 0 && i < end && j > i)
                    i++;
                while (list[j].CompareTo(pivot) >= 0 && j > start && j >= i)
                    j--;

                if (i < j)
                {
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
            temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            return end;
        }

        private static void quickSortDescendente(string[] list, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = partition(list, start, end);
                quickSortDescendente(list, start, pivotIndex - 1);
                quickSortDescendente(list, pivotIndex + 1, end);
            }
        }

        //*******

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //conexion SQL
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

            //creacion de lista con informacion de SQL
            List<string> inputStr = new List<string>();

            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT Nombre FROM Peliculas";
            SqlDataReader dr = cmd.ExecuteReader();

            //Agregar a lista
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(0).ToString());
            }

            //buscar nombre
            if (txtBuscaNumbre.Text.Length == 0)
            {
                MessageBox.Show("debe ingresar valores antes de Buscar");
            }
            else
            {
                string element = txtBuscaNumbre.Text;

                if (secuancial_string(inputStr, element) == -1)
                {
                    txtBuscaNumbre.Clear();
                    MessageBox.Show("Pelicula no encontrada");
                }
                else
                {
                    //se encontro?
                    MessageBox.Show(element + " encontrada");

                    //despliega solo el valor elegido
                    var select = "SELECT * FROM Peliculas where Nombre LIKE '" + element + "'";
                    var c = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true"); // Your Connection String here
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    DGVPeliculas.ReadOnly = true;
                    DGVPeliculas.DataSource = ds.Tables[0];
                }
            }
        }


        private void btnBuscarClasifica_Click(object sender, EventArgs e)
        {
            //conexion SQL
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

            //creacion de lista con informacion de SQL
            List<string> inputStr = new List<string>();

            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT Clasificacion FROM Clasificacion";
            SqlDataReader dr = cmd.ExecuteReader();

            //Agregar a lista
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(0).ToString());
            }

            //buscar nombre
            if (cbxClasificacion.Text.Length == 0)
            {
                MessageBox.Show("debe ingresar valores antes de Buscar");
            }
            else
            {
                string element = cbxClasificacion.Text;

                if (secuancial_string(inputStr, element) == -1)
                {
                    txtBuscaNumbre.Clear();
                    MessageBox.Show("Pelicula no encontrada");
                }
                else
                {
                    //se encontro?
                    MessageBox.Show(element + " encontrada");

                    //despliega solo el valor elegido
                    var select = "SELECT * FROM Peliculas where Clasificacion LIKE '" + element + "'";
                    var c = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true"); // Your Connection String here
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    DGVPeliculas.ReadOnly = true;
                    DGVPeliculas.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            //conexion SQL
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = ("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");

            //creacion de lista con informacion de SQL
            List<string> inputStr = new List<string>();

            cmd.Connection = cn;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT Genero FROM Genero";
            SqlDataReader dr = cmd.ExecuteReader();

            //Agregar a lista
            while (dr.Read())
            {
                inputStr.Add(dr.GetValue(0).ToString());
            }

            //buscar nombre
            if (cbxGenero.Text.Length == 0)
            {
                MessageBox.Show("debe ingresar valores antes de Buscar");
            }
            else
            {
                string element = cbxGenero.Text;

                if (secuancial_string(inputStr, element) == -1)
                {
                    txtBuscaNumbre.Clear();
                    MessageBox.Show("Pelicula no encontrada");
                }
                else
                {
                    //se encontro?
                    MessageBox.Show(element + " encontrada");

                    //despliega solo el valor elegido
                    var select = "SELECT * FROM Peliculas where Genero LIKE '" + element + "'";
                    var c = new SqlConnection("server=DESKTOP-EV3RATL ; database=Cartelera ; integrated security = true");
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    DGVPeliculas.ReadOnly = true;
                    DGVPeliculas.DataSource = ds.Tables[0];
                }
            }
        }

        static int secuancial_string(List<string> array, string element)
        {

            for (int currentElement = 0; currentElement < array.Count; currentElement++)
            {
                if (array[currentElement] == element)
                {
                    return currentElement;
                }
            }
            return -1;
        }

    }
}
