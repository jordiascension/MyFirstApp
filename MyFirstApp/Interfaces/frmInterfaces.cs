using System;
using System.Windows.Forms;

namespace MyFirstApp.Interfaces
{
    public partial class frmInterfaces : Form
    {
        public frmInterfaces()
        {
            InitializeComponent();
        }

        private void frmInterfaces_Load(object sender, EventArgs e)
        {
            //Interface Polymorphism
            IVehiculo vehiculo = new Avion();

            //Aquí no podría acceder al método Clone
            vehiculo.Acelerar(1000);

            //Interface Polymorphism
            ICloneable clonable = new Avion();
            clonable.Clone();

        }
    }
}
