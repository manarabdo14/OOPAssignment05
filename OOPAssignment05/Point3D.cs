using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment05
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Overriding Equals method
        public override bool Equals(object obj)
        {
            if (obj is Point3D)
            {
                Point3D p = (Point3D)obj;
                return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y, Z).GetHashCode();
        }

        // Implementing IComparable interface
        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;
            int result = X.CompareTo(other.X);
            if (result == 0)
            {
                result = Y.CompareTo(other.Y);
            }
            return result;
        }

        // Implementing ICloneable interface
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        // Overloading == operator
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
            return p1.Equals(p2);
        }

        // Overloading != operator
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

     

    }
}