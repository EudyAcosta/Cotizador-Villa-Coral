
namespace WinFormsApp2
{
    public class Reserva
    {
        public string Huesped { get; private set; }
        public int Noches { get; private set; }
        public decimal Tarifa { get; private set; }

        public Reserva(string huesped, int noches, decimal tarifa)
        {
            if (string.IsNullOrWhiteSpace(huesped))
                throw new System.ArgumentException("Debe ingresar el nombre del huésped.");

            if (noches <= 0)
                throw new System.ArgumentException("Las noches deben ser mayores que cero.");

            if (tarifa <= 0)
                throw new System.ArgumentException("La tarifa debe ser mayor que cero.");

            Huesped = huesped;
            Noches = noches;
            Tarifa = tarifa;
        }

        public decimal Subtotal => Noches * Tarifa;
        public decimal Descuento => Noches >= 7 ? Subtotal * 0.10m : 0m;
        public decimal BaseImponible => Subtotal - Descuento;
        public decimal Itbis => BaseImponible * 0.18m;
        public decimal Servicio => BaseImponible * 0.10m;
        public decimal Total => BaseImponible + Itbis + Servicio;
    }
}
