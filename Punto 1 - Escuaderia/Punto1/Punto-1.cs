namespace Punto1
{   class Cronometro_Mejor_Vuelta_Escuderia
    {    static void Main(string[] args)
        {
            Circuito circuito = new Circuito("Circuito de pruebas", 5);
            Monoplaza mclaren = new McLaren();
            Monoplaza ferrari = new Ferrari();
            Monoplaza redbull = new RedBull();

            circuito.AgregarMonoplaza(mclaren);
            circuito.RealizarPrueba();
            circuito.SacarMonoplaza(mclaren);

            circuito.AgregarMonoplaza(ferrari);
            circuito.RealizarPrueba();
            circuito.SacarMonoplaza(ferrari);

            circuito.AgregarMonoplaza(redbull);
            circuito.RealizarPrueba();
            circuito.SacarMonoplaza(redbull);

            // No funciona
            Console.WriteLine("Tabla de posiciones: ");
            circuito.TablaDePosiciones();
        }
    }
}
