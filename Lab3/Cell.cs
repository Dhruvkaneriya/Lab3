using System;
using System.Collections.Generic;

using Lab3.Geometry2D;
using Lab3.Particles;

namespace Lab3.ModelComponents
{
	public enum SurfaceLocation
	{
		left = 0,
		top = 1,
		right = 2,
		bot = 3
	}

	public class Cell : Rectangle
	{
		private const int NUM_SURFACES = 4;
		private List<Phonon> phonons = new List<Phonon>() { };
		private List<Phonon> incomingPhonons = new List<Phonon>() { };
		private ISurface[] surfaces = new ISurface[NUM_SURFACES];
		public List<Phonon> Phonons { get { return phonons; } }

		public Cell(double length, double width)
			: base(length, width)
		{

			foreach (int surface in Enum.GetValues(typeof(SurfaceLocation)))
			{
				surfaces[surface] = new BoundarySurface((SurfaceLocation)surface, this);
			}

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
			phonons.AddRange(incomingPhonons);
			incomingPhonons.Clear();
		}

		public ISurface GetSurface(SurfaceLocation loc)
		{
			return surfaces[(int)loc];
		}

		public SurfaceLocation? MoveToNearestSurface(Phonon p)
		{
			// TODO - challenging!! be cautious of floating point issues!
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return string.Format($"{phonons.Count}, {incomingPhonons.Count}");
		}
	}
}