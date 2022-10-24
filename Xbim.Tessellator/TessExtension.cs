using System;
using System.Linq;
using System.Collections.Generic;
using LibTessDotNet.Double;

namespace Xbim.Tessellator
{
    public static class TessExtension
    {
        public static void AddContours(this Tess tess, List<ContourVertex[]> contours)
        {
            if (contours.Any())
            {
                ContourVertex[] outer = contours[0];
                if (contours.Count > 1)
                {
                    double largestArea = Math.Abs(SignedArea(contours[0]));
                    for (int i = 1; i < contours.Count; i++)
                    {
                        double area = Math.Abs(SignedArea(contours[i]));
                        if (area > largestArea)
                        {
                            largestArea = area;
                            tess.AddContour(outer, ContourOrientation.Clockwise); //outer is now an inner
                            outer = contours[i];
                        }
                        else
                            tess.AddContour(contours[i], ContourOrientation.Clockwise);
                    }
                }
                tess.AddContour(outer, ContourOrientation.CounterClockwise);
            }
        }

        private static double SignedArea(ContourVertex[] vertices)
        {
            double area = 0.0f;

            for (int i = 0; i < vertices.Length; i++)
            {
                var v0 = vertices[i];
                var v1 = vertices[(i + 1) % vertices.Length];

                area += v0.Position.X * v1.Position.Y;
                area -= v0.Position.Y * v1.Position.X;
            }

            return area * 0.5f;
        }
    }
}
