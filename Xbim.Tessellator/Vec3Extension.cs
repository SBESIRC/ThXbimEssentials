using System;
using LibTessDotNet.Double;

namespace Xbim.Tessellator
{
    public static class Vec3Extension
    {
        public static double Length2(this Vec3 v)
        {
            return v.X * v.X + v.Y * v.Y + v.Z * v.Z;
        }

        public static double Length(this Vec3 v)
        {
            return Math.Sqrt(v.Length2());
        }

        public static bool IsValid(this Vec3 v)
        {
            return v.Length2() > 0;
        }

        public static void Cross(ref Vec3 u, ref Vec3 v, out Vec3 cross)
        {
            cross.X = u.Y * v.Z - u.Z * v.Y;
            cross.Y = u.Z * v.X - u.X * v.Z;
            cross.Z = u.X * v.Y - u.Y * v.X;
        }

        public static double Angle(ref Vec3 v1, ref Vec3 v2)
        {
            Vec3.Dot(ref v1, ref v2, out double cosinus);
            if (cosinus > -0.70710678118655 && cosinus < 0.70710678118655)
                return Math.Acos(cosinus);
            Cross(ref v1, ref v2, out Vec3 v3);
            var sinus = v3.Length();
            if (cosinus < 0.0) return Math.PI - Math.Asin(sinus);
            return Math.Asin(sinus);
        }

        public static void AddTo(ref Vec3 lhs, ref Vec3 rhs)
        {
            lhs.X += rhs.X;
            lhs.Y += rhs.Y;
            lhs.Z += rhs.Z;
        }

        public static bool Colinear(Vec3 a, Vec3 b, Vec3 c)
        {
            Vec3.Sub(ref a, ref b, out Vec3 ab);
            Vec3.Sub(ref b, ref c, out Vec3 bc);
            return ab.X * bc.Y == bc.X * ab.Y &&
                   ab.Y * bc.Z == bc.Y * ab.Z &&
                   ab.Z * bc.X == bc.Z * ab.X;
        }
    }
}
