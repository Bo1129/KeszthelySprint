namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();

            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyzo(sor));
            }

            //2.feladat
            Console.WriteLine($"2.feladat: A versenyt {versenyzok.Count} versenyző fejezte be");

            //3.feladat

            int junior = 0;
            foreach (var v in versenyzok)
            {
                if (v.kategoria == "elit junior")
                {
                    junior++;
                }
            }
            Console.WriteLine($"3.feladat: Versenyzők száma az \"elit junior\" kategóriában: {junior} fő");

            //4.feladat
            double ossz_eletkor = 0;
            foreach (var v in versenyzok)
            {
                ossz_eletkor += DateTime.Now.Year - v.szuletesi_ev;
            }
            Console.WriteLine($"4.feladat: Átlag életkor: {ossz_eletkor / versenyzok.Count} év");

            

        }
        
    }
}
