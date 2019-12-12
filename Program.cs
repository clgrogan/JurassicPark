using System;
using System.Collections.Generic;

namespace JurassicPark
{
  class Program
  {
    // List of dinosaurs
    static List<Dinosaur> Dinosaurs = new List<Dinosaur>();

    // add a dinosaur
    static void AddDino()
    {
      Console.WriteLine();
      Console.WriteLine("What SPECIES is the dinosaur?");
      Console.Write("...:");
      var dinoSpecies = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("What is the NAME of the dinosaur?");
      Console.Write("...:");
      var dinoName = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("Is the dinosaur a carnivore or herbivore?");
      Console.Write("...:");
      var dinoDiet = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("How many pounds does the dinosaur weigh?");
      Console.Write("...:");
      var dinoWeight = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("What is the NUMBER of the dinosaur's enclosure?");
      Console.Write("...:");
      var dinoEnclosure = Console.ReadLine();

      // Create a new dinosaur
      var dino = new Dinosaur();
      // Make it yours
      dino.Species = dinoSpecies;
      dino.Name = dinoName;
      dino.Diet = dinoDiet;
      dino.Weight = decimal.Parse(dinoWeight);
      dino.EnclosureNumber = int.Parse(dinoEnclosure);
      dino.DateAcquired = DateTime.Now;

      // Add this dinosaur to the dinosaurs list
      Dinosaurs.Add(item: dino);
      Console.WriteLine(dino.Species);
      Console.WriteLine(Dinosaurs[0].Species);
    }
    static void Main(string[] args)
    {
      // Display the welcome greeting.
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("            DMS");
      Console.WriteLine("(Dinosaur Management System)");
      Console.WriteLine(" ");
      Console.WriteLine("do NOT feed the dinosaurs");
      Console.WriteLine("  ...they eat people...");
      Console.WriteLine();
      // Initialize variables
      var input = "";
      var lowerCaseInput = "";

      // Loop on console output and input until user exits

      while ((input) != "exit")
      {
        //Ask the user what they want to do, and solicit input
        Console.WriteLine();
        Console.WriteLine("What would you like to do here?");
        Console.WriteLine("...type the letter inclosed in ' ' and hit Enter/Return...");
        Console.WriteLine("View 'V'| Add 'A'| Delete 'D'| Transfer 'T'| Summary 'S'| 'Exit'");
        Console.WriteLine();
        Console.Write("...:");
        input = Console.ReadLine();

        // evaluate input and trigger event as appropriate
        lowerCaseInput = input.ToLower();
        switch (lowerCaseInput)
        {
          case "v":
            Console.WriteLine("You opted to add a dinosaur.");
            break;
          case "a":
            Console.WriteLine("You opted to add a dinosaur.");
            AddDino();
            break;
          case "d":
            Console.WriteLine("You opted to delete a dinosaur.");
            break;
          case "t":
            Console.WriteLine("You opted to Transfer a dinosaur");
            Console.WriteLine("to a new enclosure.");
            break;
          case "s":
            Console.WriteLine("You opted to view the Dietary Summary.");
            break;
          default:
            Console.WriteLine("You did NOT make a valid selection.");
            break;
        }

      }
    }
  }
}
