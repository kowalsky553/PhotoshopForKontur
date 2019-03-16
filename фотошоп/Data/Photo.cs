using System;
using MyPhotoshop.Data;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int width;
		public readonly int height;
		private readonly Pixel[,] Pixels;

		public Pixel this[int x, int y]
		{
			get { return Pixels[x, y]; }
			set { Pixels[x, y] = value; }
		}

		public Photo(int width, int height)
		{
			this.height = height;
			this.width = width;
			this.Pixels = new Pixel[width, height];
		}
	}



}

