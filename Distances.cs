using System;
using System.Drawing;
					
public class Distances
{
	public static double AvgDistance3Points(PointF p1, PointF p2, PointF p3) 
	{
		double dist1 = Distance(p1, p2);
		double dist2 = Distance(p1, p3);
		double dist3 = Distance(p2, p3);
		return (dist1 + dist2 + dist3)/3;
	}

	public static double Distance(PointF p1, PointF p2) 
	{
		double a = (double)(p2.X - p1.X);
		double b = (double)(p2.Y - p1.Y);
		return Math.Sqrt(a * a + b * b);
	}
}