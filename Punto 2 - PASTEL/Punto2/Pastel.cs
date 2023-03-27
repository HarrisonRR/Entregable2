namespace Punto2{
    public class Pastel {
    public string nombre;
    public string tamaño;
    public List<ingrediente> ingredientes = new List<ingrediente>();

    public Pastel(string nombre, string tamaño) {
        this.nombre = nombre;
        this.tamaño = tamaño;
    }

    public void agregar_ingrediente(ingrediente ingrediente) {
        this.ingredientes.Add(ingrediente);
    }

    public int cantidad_de_ingredientes() {
        return this.ingredientes.Count;
    }

    public string lista_de_ingredientes() {
        string lista = "";
        foreach (ingrediente ingrediente in this.ingredientes) {
            lista += $"{ingrediente.nombre} ({ingrediente.cantidad}) - ${ingrediente.precio}\n";
        }
        return lista;
    }

    public double precio_del_pastel() {
        double total = 0;
        foreach (ingrediente ingrediente in this.ingredientes) {
            total += ingrediente.cantidad * ingrediente.precio;
        }
        return Math.Round(total,2);
    }
}
}