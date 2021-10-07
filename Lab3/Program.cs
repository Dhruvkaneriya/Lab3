using Lab3.Geometry2D;
using Lab3.ModelComponents;
using Lab3.Particles;
using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonon p = new Phonon(1);
            p.SetDirection(0.2, -0.2);
            Cell c = new Cell(9, 10);
            c.AddPhonon(new Phonon(1));
            c.AddIncPhonon(new Phonon(1));
            Console.WriteLine(c);
            
            BoundarySurface Boundarysurfaceleft = new BoundarySurface(SurfaceLocation.left, new Cell(10, 10));
            BoundarySurface Boundarysurfacetop = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
            BoundarySurface Boundarysurfaceright = new BoundarySurface(SurfaceLocation.left, new Cell(10, 10));
            BoundarySurface Boundarysurfacebottom = new BoundarySurface(SurfaceLocation.top, new Cell(10, 10));
            Console.WriteLine(p);
            
            Boundarysurfaceleft.HandlePhonon(p);
            Boundarysurfacetop.HandlePhonon(p);
            Boundarysurfaceright.HandlePhonon(p);
            Boundarysurfacebottom.HandlePhonon(p);

            Cell cell = new Cell(10, 10);
            for (int i = 0; i < 30; i++)
            {
                if (i >= 20)
                {
                    cell.AddIncPhonon(new Phonon(1));
                }
                else
                {
                    cell.AddPhonon(new Phonon(1));
                }
            }

            Console.WriteLine(c);
            c.MergeIncPhonons();
            Console.WriteLine(c);
        }
    }
}
