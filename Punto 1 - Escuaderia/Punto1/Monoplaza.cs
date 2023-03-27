namespace Punto1
{
    abstract class Monoplaza : intMonoplaza{
    protected bool encendido;
    protected bool detenido;

    public abstract string Escuderia { get; }
    public string? TiempoTotal { get; internal set; }
    public double TablaPosiciones { get; set;}
    public bool EnMovimiento { get; internal set; }

    public void Encender(){
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine($"{Escuderia} encendido");
        }
    }

    public void Apagar(){
        if (encendido && detenido)
        {
            encendido = false;
            Console.WriteLine($"{Escuderia} apagado");
        }
    }

    public void Detener(){
        if (encendido && !detenido)
        {
            detenido = true;
            Console.WriteLine($"{Escuderia} detenido");
        }
    }

    public void Mover(){
        if (encendido && detenido)
        {
            detenido = false;
            Console.WriteLine($"{Escuderia} en movimiento");
        }
    }

        internal static IEnumerable<Monoplaza> TabladePosiciones()
        {
            throw new NotImplementedException();
        }
    }

class McLaren : Monoplaza{
    public override string Escuderia => "McLaren";
}

class Ferrari : Monoplaza{
    public override string Escuderia => "Ferrari";
}

class RedBull : Monoplaza{
    public override string Escuderia => "RedBull";
}
    
}