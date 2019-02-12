namespace PooVueling
{
    public interface ICalculadora
    {
        /// <summary>
        ///Sumas the specified num1.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        int Suma(int num1, int num2);

        int Resta(int num1, int num2);

        int Multiplicacion(int num1, int num2);

        int Division(int num1, int num2);
    }
}
