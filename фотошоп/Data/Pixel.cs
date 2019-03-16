using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace MyPhotoshop.Data
{
	public struct Pixel
	{


		public Pixel(double R, double G, double B)
		{
			this.r = this.b = this.g = 0;
			this.R = R;
			this.G = G;
			this.B = B;
		}

		public double Check(double value)
		{
			if (value > 1)
				throw new Exception();
			return value;
		}

		private double r;

		public double R
		{
			get { return r; }
			set { r = Check(value); }
		}

		private double g;
		public double G
		{
			get { return g; }
			set { g = Check(value); }
		}

		private double b;
		public double B
		{
			get { return b; }
			set { b = Check(value); }
		}

		public static double Trim(double value)
		{
			if (value > 1)
				return 1;
			return value;
		}

		public static Pixel operator*(Pixel p, double c)
		{
			return new Pixel(
				Trim(p.R * c),
				Trim(p.G * c),
				Trim(p.B * c));
		}

		public static Pixel operator *(double c, Pixel p)
		{
			return new Pixel(
				Trim(p.R * c),
				Trim(p.G * c),
				Trim(p.B * c));
		}
	}
}
