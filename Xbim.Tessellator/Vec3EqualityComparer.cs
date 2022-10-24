using System.Collections.Generic;
using LibTessDotNet.Double;

namespace Xbim.Tessellator
{
    public struct Vec3EqualityComparer : IEqualityComparer<Vec3>
    {
        private readonly double _precision2;
        private readonly double _gridDim;
        public Vec3EqualityComparer(double precision)
        {
            _precision2 = precision * precision;
            _gridDim = precision * 10;//coursen  up
        }
        public bool Equals(Vec3 a, Vec3 b)
        {
            Vec3.Sub(ref a, ref b, out Vec3 c);
            bool same = c.Length2() <= _precision2;

            return same;
        }
        public int GetHashCode(Vec3 point)
        {
            //This hashcode snaps points to a grid of 10 * tolerance to ensure similar points fall into the same hash cell
            double xs = point.X - point.X % _gridDim;
            double ys = point.Y - point.Y % _gridDim;
            double zs = point.Z - point.Z % _gridDim;
            unchecked // Overflow is fine, just wrap
            {
                var hash = (int)2166136261;
                hash = hash * 16777619 ^ xs.GetHashCode();
                hash = hash * 16777619 ^ ys.GetHashCode();
                hash = hash * 16777619 ^ zs.GetHashCode();
                return hash;
            }
        }
    }
}
