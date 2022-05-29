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

namespace HerramientasCONCIVELS
{
    public partial class formInterfazH : Form
    {
        public void Limpiar(Form xform)
        {
            foreach (var xctrl in xform.Controls)
            {
                if (xctrl is TextBox)
                {
                    ((TextBox)xctrl).Text = string.Empty;
                }
                else
                {
                    if (xctrl is ComboBox)
                    {
                        ((ComboBox)xctrl).Items.Clear();
                    }
                }
            }
        }
        public formInterfazH()
        {
            InitializeComponent();
            
        }

        private void formInterfazH_Load(object sender, EventArgs e)
        {
            lblcambio.Text = "";
            txtBuscar.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modificarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LeonelLora\\Documents\\HerramientasCONCIVELS.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open(); 
           SqlCommand cmd = new SqlCommand("insert into Herramientas values (@Codigo,@Tipo,@Marca,@Color)",con);
            cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text); 
            cmd.Parameters.AddWithValue("@Tipo", cmbTipo.Text); 
            cmd.Parameters.AddWithValue("@Marca", cmbMarca.Text);
            cmd.Parameters.AddWithValue("@Color", cmbColor.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("  La herramienta se agrego correctamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar(this);
            con.Close();
            




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void modificarHerramientasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LeonelLora\\Documents\\HerramientasCONCIVELS.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = new SqlCommand("Update Herramientas set Tipo=@Tipo, Marca=@Marca, Color=@Color where Codigo=@Codigo",con);
            cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@Tipo", cmbTipo.Text);
            cmd.Parameters.AddWithValue("@Marca", cmbMarca.Text);
            cmd.Parameters.AddWithValue("@Color", cmbColor.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("  La herramienta se modifico correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar(this);
            con.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LeonelLora\\Documents\\HerramientasCONCIVELS.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Herramientas where Codigo= @Codigo",con);
            cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("  La herramienta se elimino correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Limpiar(this);
            con.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarpor.Text == "Tipo")
            {
                lblcambio.Text = "Tipo:";
                txtBuscar.Show();

            }
            else
            {
                if (cmbBuscarpor.Text == "Codigo")
                {
                    lblcambio.Text = "Codigo:";
                    txtBuscar.Show();
                }
                else
                {
                    if (cmbBuscarpor.Text == "Marca")
                    {
                        lblcambio.Text = "Marca:";
                        txtBuscar.Show();
                    }

                    else
                    {
                        if (cmbBuscarpor.Text == "Color")
                        {
                            lblcambio.Text = "Color:";
                            txtBuscar.Show();
                        }
                    }

                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LeonelLora\\Documents\\HerramientasCONCIVELS.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            SqlCommand cmd = new SqlCommand();


            if (cmbBuscarpor.Text == "Tipo")
            {
                lblcambio.Text = "Tipo:";
                cmd = new SqlCommand("Select * from Herramientas where Tipo=@Tipo", con);
                cmd.Parameters.AddWithValue("Tipo", txtBuscar.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListaH.DataSource = dt;

            }
            else
            {
                if (cmbBuscarpor.Text == "Codigo")
                {
                    lblcambio.Text = "Codigo:";
                    cmd = new SqlCommand("Select * from Herramientas where Codigo=@Codigo", con);
                    cmd.Parameters.AddWithValue("Codigo", txtBuscar.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListaH.DataSource = dt;
                }
                else
                {
                    if (cmbBuscarpor.Text == "Marca")
                    {
                        lblcambio.Text = "Marca:";
                        cmd = new SqlCommand("Select * from Herramientas where Marca=@Marca", con);
                        cmd.Parameters.AddWithValue("Marca", txtBuscar.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvListaH.DataSource = dt;
                    }

                    else
                    {
                        if (cmbBuscarpor.Text == "Color")
                        {
                            lblcambio.Text = "Color:";
                            cmd = new SqlCommand("Select * from Herramientas where Color=@Color", con);
                            cmd.Parameters.AddWithValue("Color", txtBuscar.Text);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvListaH.DataSource = dt;
                        }
                    }

                }

            }

            con.Close();
        }
    }
}
