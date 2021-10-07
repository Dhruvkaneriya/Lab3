using System;
using System.Collections.Generic;

using Lab3.Geometry2D;
using Lab3.Particles;

namespace Lab3.ModelComponents
{
	public enum SurfaceLocation
	{
		left = 0,
		right = 1,
		top = 2,
		bottom = 3
	}

	public class Cell : Rectangle
	{
		private const int NUM_SURFACES = 4;
        private List<Phonon> phonons = new() { };
		private List<Phonon> incomingPhonons = new() { };
		private ISurface[] surfaces = new ISurface[NUM_SURFACES];

		public List<Phonon> Phonons { get { return phonons; } }

        public List<Phonon> Phonons1 { get => phonons; set => phonons = value; }

        public Cell(double length, double width)
			: base(length, width)
		{
			
		}

		public void AddPhonon(Phonon p)
		{
			phonons.Add(p);
		}

		public void AddIncPhonon(Phonon p)
		{
			incomingPhonons.Add(p);
		}


		public void MergeIncPhonons()
		{
			foreach (var phonon in incomingPhonons)
			{
				phonons.Add(phonon);
			}
			incomingPhonons.Clear();
		}

		public ISurface GetSurface(SurfaceLocation loc)
		{
			throw new NotImplementedException();
		}

		public SurfaceLocation? MoveToNearestSurface(Phonon p)
		{	
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return string.Format("{0,-7} {1,-7}", phonons.Count, incomingPhonons.Count);
		}
	}
}
