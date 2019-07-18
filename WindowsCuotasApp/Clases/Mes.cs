

namespace WindowsCuotasApp.Clases
{
    class Mes
    {
        private int id;
        private string nombreMes;

        public Mes(int id, string nombreMes)
        {
            this.Id = id;
            this.NombreMes = nombreMes;
        }

        public int Id { get => id; set => id = value; }
        public string NombreMes { get => nombreMes; set => nombreMes = value; }
    }
}
