namespace taskD06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1

            //Point3D p = new Point3D(10, 10, 10);
            //Console.WriteLine(p.ToString());
            #endregion


            #region task 2

            //string str = (string)p;
            //Console.WriteLine(str);

            #endregion

            #region task 3
            //Point3D point1 = new Point3D();
            //Console.WriteLine("please enter first point p1 p2 p3");
            //point1.P1 = int.Parse( Console.ReadLine());
            //point1.P2 = int.Parse(Console.ReadLine());
            //point1.P3 = int.Parse(Console.ReadLine());

            //Point3D point2 = new Point3D();
            //Console.WriteLine("please enter second point p1 p2 p3");
            //point2.P1 = int.Parse(Console.ReadLine());
            //point2.P2 = int.Parse(Console.ReadLine());
            //point2.P3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(point1.ToString());
            //Console.WriteLine(point2.ToString());


            //Point3D point1 = new Point3D();
            //Point3D point2 = new Point3D();
            //Console.WriteLine("please enter first point p1 p2 p3");
            //try
            //{
            //    point2.P1 = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("invalide input");
            //}
            //try
            //{
            //    point2.P2 = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("invalide input");
            //}
            //try
            //{
            //    point2.P3 = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("invalide input");
            //}
            //Console.WriteLine(point2.ToString());

            #endregion


            #region task 4

            //Point3D[] points = new Point3D[3];

            //for (int i = 0; i < points.Length; i++)
            //{

            //    points[i] = new Point3D();
            //    Console.WriteLine($"please enter coordinates for Point {i + 1} (P1, P2, P3) ");
            //    points[i].P1 = int.Parse(Console.ReadLine());
            //    points[i].P2 = int.Parse(Console.ReadLine());
            //    points[i].P3 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(points[i].ToString());

            //}


            #endregion


            #region task 5

            //Console.WriteLine(Math.Add(5, 6));
            //Console.WriteLine(Math.Subtract(10, 6));
            //Console.WriteLine(Math.Multiply(10, 6));
            //Console.WriteLine(Math.Divide(10, 2));
            //Console.WriteLine(Math.Divide(0, 2));




            #endregion



            #region Final Task Duration

            //Duration d1 = new Duration(1,10,15);
            //Console.WriteLine(d1.ToString());

            //Duration d1 = new Duration(3600);
            //Console.WriteLine( d1.ToString());

            //Duration d1 = new Duration(7800);
            //Console.WriteLine(d1.ToString());

            //Duration d1 = new Duration(666);
            //Console.WriteLine(d1.ToString());

            Duration d1 = new Duration(3600);
            Duration d2 = new Duration(3600);
            Duration d3 = new Duration();

            //d3 = d1 + d2;
            //d3 = d1 + 7800;
            d3 = 666 + d3;
            Console.WriteLine(d3.ToString());



            //Duration d1 = new Duration(3600);
            //Duration d2 = new Duration(3600);

            //Console.WriteLine();

            #endregion
        }
    }
}
