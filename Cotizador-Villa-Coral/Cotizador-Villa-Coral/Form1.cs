
using System;
using System.Windows.Forms;

namespace Cotizador_Villa_Coral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnImperativo.Click += btnImperativo_Click;
            btnObjetos.Click += btnObjetos_Click;
            btnFuncional.Click += btnFuncional_Click;
        }

        private bool ObtenerDatos(out string huesped, out int noches, out decimal tarifa)
        {
            huesped = txtbHuesped.Text.Trim();
            noches = (int)nudNoches.Value;
            tarifa = nudTarifa.Value;

            if (string.IsNullOrWhiteSpace(huesped))
            {
                MessageBox.Show("Ingrese el nombre del huésped.");
                return false;
            }

            if (noches <= 0 || tarifa <= 0)
            {
                MessageBox.Show("Las noches y la tarifa deben ser mayores que cero.");
                return false;
            }

            return true;
        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            if (!ObtenerDatos(out string huesped, out int noches, out decimal tarifa))
                return;

            decimal subtotal = noches * tarifa;
            decimal descuento = noches >= 7 ? subtotal * 0.10m : 0m;
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            MostrarCotizacion("1. Imperativo", huesped, subtotal, descuento, itbis, servicio, total);
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            if (!ObtenerDatos(out string huesped, out int noches, out decimal tarifa))
                return;

            Reserva reserva = new Reserva(huesped, noches, tarifa);

            lblSubtotalN.Text = reserva.Subtotal.ToString("N2");
            lblDescuentoN.Text = reserva.Descuento.ToString("N2");
            lblITBISn.Text = reserva.Itbis.ToString("N2");
            lblServicioN.Text = reserva.Servicio.ToString("N2");
            lblTOTALn.Text = reserva.Total.ToString("N2");

            lstResultados.Items.Add($"2. Objetos: {reserva.Huesped} - US$ {reserva.Total:N2}");
        }

        private void btnFuncional_Click(object sender, EventArgs e)
        {
            if (!ObtenerDatos(out string huesped, out int noches, out decimal tarifa))
                return;

            Func<int, decimal, decimal> calcularSubtotal = (n, t) => n * t;
            Func<decimal, int, decimal> calcularDescuento = (s, n) => n >= 7 ? s * 0.10m : 0m;

            decimal subtotal = calcularSubtotal(noches, tarifa);
            decimal descuento = calcularDescuento(subtotal, noches);
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            MostrarCotizacion("3. Funcional", huesped, subtotal, descuento, itbis, servicio, total);
        }

        private void MostrarCotizacion(string paradigma, string huesped, decimal subtotal, decimal descuento, decimal itbis, decimal servicio, decimal total)
        {
            lblSubtotalN.Text = subtotal.ToString("N2");
            lblDescuentoN.Text = descuento.ToString("N2");
            lblITBISn.Text = itbis.ToString("N2");
            lblServicioN.Text = servicio.ToString("N2");
            lblTOTALn.Text = total.ToString("N2");

            lstResultados.Items.Add($"{paradigma}: {huesped} - US$ {total:N2}");
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
