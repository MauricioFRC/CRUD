using System.Drawing;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Crud : Form
    {
        private DatabaseManager _dbManager;

        public void UpdateDataSource()
        {
            dataGridView1.DataSource = _dbManager.QueryUser();
            dataGridView3.DataSource = _dbManager.QueryUser();
            dataGridView4.DataSource = _dbManager.QueryUser();
        }

        public void ClearTexBoxes()
        {
            // Registrar Usuario
            TxtCid.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            //  TxtFecNac.Text = "";
            TxtNumTelf.Text = "+595 09";

            // Actualizar Usuario
            TxtCidActualizar.Text = "";
            TxtNombresActualizar.Text = "";
            TxtApellidosActualizar.Text = "";
            // TxtFecNacActualizar.Text = "";
            TxtNumTelfActualizar.Text = "";
        }

        public Crud()
        {
            InitializeComponent();
            _dbManager = new DatabaseManager("db.sqlite3");
            UpdateDataSource();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCid.Text == "")
                {
                    MessageBox.Show("La Cédula de Identidad NO puede ser un Campo Vacio!!!");
                }
                else
                {
                    _dbManager.InsertUser(
                        Convert.ToInt32(TxtCid.Text),
                        TxtNombres.Text,
                        TxtApellidos.Text,
                        TxtNumTelf.Text,
                        DateTimePickerRegist.Value.Date.ToString("yyyy-MM-dd") // Insert Date from dateTimePicker
                        // TxtFecNac.Text
                    );
                    UpdateDataSource();
                    ClearTexBoxes();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es valido\nFavor ingrese correctamente los datos");
            }
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEliminarUsuario.Text != "")
                {
                    _dbManager.DeleteUser(
                        Convert.ToInt32(TxtEliminarUsuario.Text)
                    );
                    UpdateDataSource();
                    ClearTexBoxes();
                }
                else
                {
                    MessageBox.Show("La Cédula de Identidad NO puede ser un Campo Vacio!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es valido\nFavor ingrese correctamente los datos");
            }
        }

        private void BtnActualizarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCidActualizarBusc.Text != "")
                {
                    _dbManager.UpdateUser(
                        Convert.ToInt32(TxtCidActualizar.Text),
                        Convert.ToInt32(TxtCidActualizarBusc.Text),
                        TxtNombresActualizar.Text,
                        TxtApellidosActualizar.Text,
                        TxtNumTelfActualizar.Text,
                        TxtFecNacActualizar.Text
                    );

                    MessageBox.Show("El usuario " + TxtNombresActualizar.Text + " se ha actualizado!");
                    UpdateDataSource();
                }
                else
                {
                    MessageBox.Show("El Campo de búsqueda de cédula no deber estar vacia!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es valido\nFavor ingrese correctamente los datos");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCidActualizarBusc.Text != "")
                {
                    _dbManager.SearchUser(
                        Convert.ToInt32(TxtCidActualizarBusc.Text),
                        TxtCidActualizar,
                        TxtNombresActualizar,
                        TxtApellidosActualizar,
                        TxtNumTelfActualizar,
                        TxtFecNacActualizar
                    );
                }
                else
                {
                    MessageBox.Show("El Campo de búsqueda de usuario es un campo requerido!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es valido\nFavor ingrese correctamente los datos");
            }
        }
    }
}
