class Operaciones
{
    private double valorA, valorB;

    public static double Sumar(double valorA, double valorB)
    {
        return valorA + valorB;
    }
    public static double Restar(double valorA, double valorB)
    {
        return valorA - valorB;
    }
    public static double Multiplicar(double valorA, double valorB)
    {
        return valorA * valorB;
    }
    public static double Dividir(double valorA, double valorB)
    {
        if (valorB == 0)
            return double.NaN;
        return valorA / valorB;
    }
}
