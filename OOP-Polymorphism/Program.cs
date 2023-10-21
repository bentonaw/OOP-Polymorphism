namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel newCirkel = new Cirkel();
            Console.WriteLine("Area Cirkel: " + Math.Round(newCirkel.Area(),2));
        }
    }
}