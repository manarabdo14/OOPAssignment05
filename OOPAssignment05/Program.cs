namespace OOPAssignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Project01
            //Console.WriteLine("Enter coordinates for P1 (x y z):");
            //Point3D P1 = ReadPointFromUser();

            //Console.WriteLine("Enter coordinates for P2 (x y z):");
            //Point3D P2 = ReadPointFromUser();

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());

            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 is equal to P2.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 is not equal to P2.");
            //}

            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(3, 4, 5),
            //new Point3D(1, 2, 3),
            //new Point3D(6, 7, 8),
            //new Point3D(2, 3, 4)
            //};

            //Array.Sort(points);

            //Console.WriteLine("Sorted points:");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point.ToString());
            //}

            //Point3D P1Clone = (Point3D)P1.Clone();
            //Console.WriteLine("Clone of P1: " + P1Clone.ToString());
            #endregion

            #region Project02
            //int a = 10;
            //int b = 5;

            //Console.WriteLine($"Add: {a} + {b} = {Maths.Add(a, b)}");
            //Console.WriteLine($"Subtract: {a} - {b} = {Maths.Subtract(a, b)}");
            //Console.WriteLine($"Multiply: {a} * {b} = {Maths.Multiply(a, b)}");
            //Console.WriteLine($"Divide: {a} / {b} = {Maths.Divide(a, b)}");
            #endregion

            #region Project03
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());

            //D3 = D1 + D2;
            //Console.WriteLine("D3 = D1 + D2: " + D3.ToString());

            //D3 = D1 + 7800;
            //Console.WriteLine("D3 = D1 + 7800: " + D3.ToString());

            //D3 = 666 + D3;
            //Console.WriteLine("D3 = 666 + D3: " + D3.ToString());

            //D3 = ++D1;
            //Console.WriteLine("D3 = ++D1: " + D3.ToString());

            //D3 = --D2;
            //Console.WriteLine("D3 = --D2: " + D3.ToString());

            //D1 = D1 - D2;
            //Console.WriteLine("D1 = D1 - D2: " + D1.ToString());

            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 is greater than D2");
            //}

            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 is less than or equal to D2");
            //}

            //if (D1)
            //{
            //    Console.WriteLine("D1 is non-zero");
            //}

            //DateTime dateTime = (DateTime)D1;
            //Console.WriteLine("DateTime from D1: " + dateTime.ToString());
            #endregion
        }


        private static Point3D ReadPointFromUser()
        {
            int x, y, z;
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if (inputs.Length == 3 &&
                    int.TryParse(inputs[0], out x) &&
                    int.TryParse(inputs[1], out y) &&
                    int.TryParse(inputs[2], out z))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter three integers separated by spaces.");
            }
            return new Point3D(x, y, z);
        }
    }

  
}
