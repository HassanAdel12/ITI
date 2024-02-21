namespace Lap_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10,5);
            Square s1 = new Square(10);
            Circle c1 = new Circle(4);
            Triangle t1 = new Triangle(5,10);

            Console.WriteLine(r1.CArea());
            Console.WriteLine(s1.CArea());
            Console.WriteLine(c1.CArea());
            Console.WriteLine(t1.CArea());

            Rectangle r2 = new Rectangle(8, 4);
            Square s2 = new Square(6);
            Circle c2 = new Circle(5);
            Triangle t2 = new Triangle(4, 8);

            Geoshape[] Geoshapes = { r1, s1, c1, t1, r2, s2, c2, t2 };

            Console.WriteLine(Utility.SumOfAreasV1(r1, s1, c1, t1));
            Console.WriteLine(Utility.SumOfAreasV1(r2, s2, c2, t2));

            Console.WriteLine(Utility.SumOfAreasV2(Geoshapes));

            Geoshape g1 = new Rectangle();
            Geoshape g2 = new Square();
            Geoshape g3 = new Circle();
            Geoshape g4 = new Triangle();

            //early binding
            g3.Show();
            g4.Show();
            //late binding
            g1.Show();
            g2.Show();
            
        }
    }
}
