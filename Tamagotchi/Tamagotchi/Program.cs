namespace Tamagotchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi Pookie = new Tamagotchi(); //Am creat primul Tamagochi, sa-i zicem Pookie
            //O metoda excelenta de gestionare a posibilelor erori cand vine vorba de metoda Hraneste()
            try
            {
                Pookie.Hraneste();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Pookie.Joaca();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pookie.Odihneste();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
    
}
