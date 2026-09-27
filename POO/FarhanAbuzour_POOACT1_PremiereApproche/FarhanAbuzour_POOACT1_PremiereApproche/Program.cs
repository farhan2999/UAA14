namespace FarhanAbuzour_POOACT1_PremiereApproche
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrez le nom du premier chien : ");
            string nom1 = Console.ReadLine();
            Console.Write("Entrez sa date de naissance (AAAA-MM-JJ) : ");
            DateTime age1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Entrez sa race : ");
            string race1 = Console.ReadLine();
            Console.Write("Entrez l'état du carnet de santé : ");
            string carnet1 = Console.ReadLine();
            Console.Write("Entrez son poids (en kg) : ");
            double poids1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez sa couleur : ");
            string couleur1 = Console.ReadLine();

            Chien chien1 = new Chien(nom1, age1, race1, carnet1, poids1, couleur1);

           
            Console.WriteLine();
            Console.WriteLine("=== INFORMATIONS DES CHIENS ===");
            Console.WriteLine(chien1.Infochien());


            Console.WriteLine();
            Console.Write("Nom du vaccin à ajouter au premier chien : ");
            string vaccin = Console.ReadLine();
            chien1.Vacciner(vaccin, DateTime.Now);

            Console.WriteLine();
            Console.WriteLine("=== MISE À JOUR ===");
            Console.WriteLine(chien1.Infochien());
        }
    }
}
