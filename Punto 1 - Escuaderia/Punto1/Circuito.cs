namespace Punto1{   
    class Circuito{
    private Monoplaza? monoplazaActual;
    private string nombre;
    private int vueltasPermitidas;
    private List<double> tiempos = new List<double>();


    public Circuito(string nombre, int vueltasPermitidas)
    {
        this.nombre = nombre;
        this.vueltasPermitidas = vueltasPermitidas;
    }

    public void AgregarMonoplaza(Monoplaza monoplaza)
    {
        if (monoplazaActual == null)
        {
            monoplazaActual = monoplaza;
        }
    }

    public void SacarMonoplaza(Monoplaza monoplaza)
    {
        if (monoplazaActual != null)
        {
            monoplazaActual.Apagar();
            monoplazaActual = null;
        }
    }

    public void RealizarPrueba()
    {
        if (monoplazaActual != null)
        {
            Console.WriteLine($"Iniciando prueba en {nombre} para {monoplazaActual.Escuderia}");

            tiempos.Clear();

            monoplazaActual.Encender();
            monoplazaActual.Detener();
            monoplazaActual.Mover();

            for (int i = 1; i <= vueltasPermitidas; i++)
            {
                double tiempo = GenerarTiempoAleatorio();
                tiempos.Add(tiempo);
                Console.WriteLine($"Tiempo de vuelta {i}: {tiempo}");
            }

            double mejorTiempo = tiempos.Min();
            Console.WriteLine($"El mejor tiempo de {monoplazaActual.Escuderia} fue: {mejorTiempo}");

            monoplazaActual.Detener();
            monoplazaActual.Apagar();
            monoplazaActual = null;
        }
    }

    private static double GenerarTiempoAleatorio()
    {
        Random random = new Random();
        return random.NextDouble() * 1000000;
    }

    public string TablaDePosiciones(){
        int posicion = 1;
            foreach (Monoplaza monoplaza in Monoplaza.TabladePosiciones()) {
                Console.WriteLine(posicion + " - " + monoplaza.Escuderia + " - " + monoplaza.TiempoTotal);
                posicion++;
        }
        return TablaDePosiciones();
    }
    }
}
