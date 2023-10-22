namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel newCirkel = new Cirkel();
            Console.WriteLine("Area Cirkel: " + Math.Round(newCirkel.Area(), 2));

            Fyrkant newFyrkant = new Fyrkant();
            Console.WriteLine("Area Fyrkant: " + newFyrkant.Area());

            Rektangel newRektangel = new Rektangel();
            Console.WriteLine("Area Rektangel: " + newRektangel.Area());

            Parallellogram newParallellogram = new Parallellogram();
            Console.WriteLine("Area Parallellogram: " + newParallellogram.Area());

            Ellips newEllips = new Ellips();
            Console.WriteLine("Area Ellips: " + Math.Round(newEllips.Area(), 2));



        }
    }
}