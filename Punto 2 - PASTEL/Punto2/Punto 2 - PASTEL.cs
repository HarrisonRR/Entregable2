namespace Punto2{
    public class Pastel_de_vainilla {
    static void Main(string[] args) {
        ingrediente ingrediente1 = new ingrediente("Mantequilla", 1, 4.300);
        ingrediente ingrediente2 = new ingrediente("Azucar", 1, 4.600);
        ingrediente ingrediente3 = new ingrediente("Harina", 1, 3.200);
        ingrediente ingrediente4 = new ingrediente("Huevos", 8, 0.400);
        ingrediente ingrediente5 = new ingrediente("Leche", 1, 2.500);

        Pastel pastel_vainilla = new Pastel("Pastel de vainilla", "Grande");
        pastel_vainilla.agregar_ingrediente(ingrediente1);
        pastel_vainilla.agregar_ingrediente(ingrediente2);
        pastel_vainilla.agregar_ingrediente(ingrediente3);
        pastel_vainilla.agregar_ingrediente(ingrediente4);
        pastel_vainilla.agregar_ingrediente(ingrediente5);

        Console.WriteLine("Cantidad de ingredientes: "+ pastel_vainilla.cantidad_de_ingredientes());
        Console.WriteLine("Ingredientes del pastel: "+ pastel_vainilla.lista_de_ingredientes());
        Console.WriteLine("El nombre del pastel es: "+ pastel_vainilla.nombre);
        Console.WriteLine("Costo total del pastel de vainilla es: "+pastel_vainilla.precio_del_pastel());
    }
}
}