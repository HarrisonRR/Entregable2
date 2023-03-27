namespace Punto2{
    public class ingrediente:interfzingredientes{
        public ingrediente(string nombre, int cantidad, double precio){
        this.nombre = nombre;
        this.cantidad = cantidad;
        this.precio = precio;
        }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
    }
}