namespace Factory

{
    class Program
    {
        static void Main(string[] args)
        {
            Clima temp = CreaObjetos.CreadorObjet(CreaObjetos.TEMPERATURA_HERMOSILLO);
            Console.WriteLine(temp.Temperatura());

            Clima temp1 = CreaObjetos.CreadorObjet(CreaObjetos.TEMPERATURA_GUAYMAS);
            Console.WriteLine(temp1.Temperatura());

        }
    }

}