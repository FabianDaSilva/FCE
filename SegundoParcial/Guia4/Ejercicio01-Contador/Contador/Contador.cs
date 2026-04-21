class Contador
{
    private int valorActual;

    public int ValorActual
    {
        get { return valorActual; }
    }

    public void Incrementar()
    {
        valorActual += 1;
    }

    public void Restablecer()
    {
        valorActual = 0;
    }

}