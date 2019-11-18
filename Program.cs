using System;
using System.Collections.Generic;

namespace _1_06.Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            // Give each building a width, height, and number of stories
            FiveOneTwoEigth.Width = 10_0;
            FiveOneTwoEigth.Depth = 10_0;
            FiveOneTwoEigth.Stories = 1;
            // Construct each building
            FiveOneTwoEigth.Construct();
            // Have business people in your city purchase each of your buildings
            FiveOneTwoEigth.Purchase("First Owner");

            buildings.Add(FiveOneTwoEigth);

            //
            Building OneZeroOneSix = new Building("101 6th Avenue");
            OneZeroOneSix.Width = 11_0;
            OneZeroOneSix.Depth = 11_0;
            OneZeroOneSix.Stories = 2;
            OneZeroOneSix.Construct();
            OneZeroOneSix.Purchase("Second Owner");

            buildings.Add(OneZeroOneSix);

            //
            Building TreeZeroFiveNine = new Building("305 9th Avenue");
            TreeZeroFiveNine.Width = 12_0;
            TreeZeroFiveNine.Depth = 12_0;
            TreeZeroFiveNine.Stories = 3;
            TreeZeroFiveNine.Construct();
            TreeZeroFiveNine.Purchase("Third Owner");

            buildings.Add(TreeZeroFiveNine);

            foreach( Building building in buildings )
            {
                building.PrintInfo();
            }
        }
    }
}
