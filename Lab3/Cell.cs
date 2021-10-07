using System;
using System.Collections.Generic;

using Lab3.Geometry2D;
using Lab3.Particles;

namespace Lab3.ModelComponents
{
	public enum SurfaceLocation
	{
		// TODO -> set up these enums
	}

	public class Cell : Rectangle
	{
		private const int NUM_SURFACES = 4;
		private List<Phonon> phonons = new() { };
		private List<Phonon> incomingPhonons = new() { };
		private ISurface[] surfaces = new ISurface[NUM_SURFACES];
		public List<Phonon> Phonons { get { return phonons; } }

		public Cell(double length, double width)
			: base(length, width)
		{
			// Initialize surfaces
		}

		/// <summary>
		/// Adds a phonon to the main phonon 'array' of the cell.
		/// </summary>
		/// <param name="p">The phonon that will be added</param>
		public void AddPhonon(Phonon p)
		{
			// TODO
			throw new NotImplementedException();
		}

		/// <summary>
		/// Adds a phonon to the incoming phonon 'array' of the cell
		/// The incoming phonon will come from the phonons 'array' of another cell
		/// </summary>
		/// <param name="p">The phonon that will be added</param>
		public void AddIncPhonon(Phonon p)
		{
			// TODO
			throw new NotImplementedException();
		}

		/// <summary>
		/// Merges the incoming phonons with the existing phonons and clears the incoming phonons
		/// </summary>
		public void MergeIncPhonons()
		{
			// TODO
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the surface at SurfaceLocation loc
		/// </summary>
		/// <param name="loc">The SurfaceLocation of the surface to be returned</param>
		/// <returns>The surface at location loc</returns>
		public ISurface GetSurface(SurfaceLocation loc)
		{
			// TODO
			throw new NotImplementedException();
		}

		/// <summary>
		/// Moves a phonon to the surface that it will impact first.
		/// The phonon will be moved to the surface and the surface
		/// it impacts is returned
		/// </summary>
		/// <param name="p">The phonon to be moved</param>
		/// <returns>The surface that the phonon collides with</returns>
		public SurfaceLocation? MoveToNearestSurface(Phonon p)
		{
			// TODO - challenging!! be cautious of floating point issues!
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return string.Format("{1,-7} {2,-7}", phonons.Count, incomingPhonons.Count);
		}
	}
}
