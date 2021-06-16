using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building","John McLane sneaks around", "Shoot out by the vault" };
            //VHS v = new VHS("Die Hard", Genre.Action, 120, dieHardScenes);
            //Console.WriteLine();

            //List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            //DVD d = new DVD("Mean Girls", Genre.Comedy, 133, meanGirls);

            //d.Play();
            BlockBusterVideo bv = new BlockBusterVideo();
            bv.PrintAllMovies();
            bv.Checkout();

            //List<string> scenes = new List<string>();
            //scenes.Add("test1");

            //DVD d1 = new DVD();
            //Movie m1 = new Movie("test", Genre.Action, 90, scenes, d1);

            ////d1.Play();

            //m1.PlayMovie();

           
   
        }
    }
}
