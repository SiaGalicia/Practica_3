
// --------------------------------------------
// Anastasia Galitskaya
// Curso DAW
// Modalidad Semipresencial
// Práctica nº 3
// --------------------------------------------

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    
    public partial class MainWindow : Window

    {


        public string tel1;
        public int telInt1;
        public string tel2;
        public int telInt2;
        public bool formatExc1 = true;
        public bool formatExc2 = true;

        public string nombre;
        public string apellido1;
        public string apellido2;
        public string clienteOdistr;
        public string telefono1;
        public string telefono2;
        public string correo;
        public string direccion;
        public string cp;
        public string poblacion;
        public string provincia;

        public string SQL;
        public MainWindow()
        {
            InitializeComponent();
            btAceptar.IsEnabled = false;
            cbProvincia.Visibility = Visibility.Hidden;
            cbProvincia2.Visibility = Visibility.Hidden;
        }


        private void btAceptar_Click(object sender, RoutedEventArgs e)
        {

            tel1 = txtTelefono1.Text;
            try
            {
                telInt1 = Convert.ToInt32(tel1);
                txtTelefono1.Background = Brushes.White;
            }
            catch (FormatException)
            {
                txtTelefono1.Background = Brushes.IndianRed;
                txtTelefono1.Focus();
                formatExc1=false;
            }
            tel2 = txtTelefono2.Text;
            try
            {
                telInt2 = Convert.ToInt32(tel2);
                txtTelefono2.Background = Brushes.White;
            }
            catch (FormatException)
            {
                if (txtTelefono2.Text != "")
                {
                    txtTelefono2.Background = Brushes.IndianRed;
                    txtTelefono2.Focus();
                    formatExc2 = false;
                }
                else
                {
                    formatExc2 = true;
                    txtTelefono2.Background = Brushes.White;
                }
            }
            if((formatExc1==true)&&(formatExc2==true))
            {
                SQL = "INSERT INTO " + clienteOdistr + "\n" + "VALUES " + "(" + nombre + ", " + apellido1 + ", " + apellido2 + ", " + telefono1 + telefono2 + ", " + correo + ", " + direccion + ", " + cp + ", " + poblacion + ", " + provincia + ")";


                MessageBox.Show(SQL); 
            }
            else
            {
                formatExc1 = true;
                formatExc1 = true;
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
     
           nombre = txtNombre.Text;
        }

        private void txtPrimerApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            apellido1 = txtPrimerApellido.Text;
        }

        private void txtSegundoApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            apellido2 = txtSegundoApellido.Text;
        }

        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia.Visibility = Visibility.Visible;
                clienteOdistr = "clientes";
            }
            if (rbCliente.IsChecked == false)
            {
                cbProvincia.Visibility = Visibility.Hidden;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
      
        }

        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }

            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia2.Visibility = Visibility.Visible;
            }
            if (rbDistribuidor.IsChecked == false)
            {
                cbProvincia2.Visibility = Visibility.Hidden;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
                clienteOdistr = "distribuidores";
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            
        }

        private void txtTelefono1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            telefono1 = txtTelefono1.Text;
        }

        private void txtTelefono2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTelefono2.Text!="")
            telefono2 = ", "+txtTelefono2.Text;
        }

        private void txtCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            correo = txtCorreo.Text;
        }

        private void txtDirecion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            direccion = txtDirecion.Text;
        }

        private void txtCP_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            cp = txtCP.Text;
        }

        private void txtPoblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            poblacion = txtPoblacion.Text;
        }

        private void cbProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            if (cbProvincia.SelectedValue != null)
            {
                provincia = cbProvincia.SelectedValue.ToString();
            }
        }

        private void cbProvincia2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((txtPrimerApellido.Text != "") && (txtSegundoApellido.Text != "") && (txtNombre.Text != "") && (txtTelefono1.Text != "") && ((rbCliente.IsChecked == true) || (rbDistribuidor.IsChecked == true)) && (txtCorreo.Text != "") && (txtDirecion.Text != "") && (txtCP.Text != "") && (txtPoblacion.Text != "") && ((cbProvincia.SelectedIndex != -1) || (cbProvincia2.SelectedIndex != -1)))
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
            if (rbDistribuidor.IsChecked==true)
            {
                cbProvincia.SelectedIndex = -1;
            }
            if (rbCliente.IsChecked == true)
            {
                cbProvincia2.SelectedIndex = -1;
            }
            if (cbProvincia2.SelectedValue != null)
            {
                provincia = cbProvincia2.SelectedValue.ToString();
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
