using System;

namespace JurassicPark
{
  // D I N O S A U R you are a dinosaur class
  public class Dinosaur
  {
    // species
    public string Species { get; set; }
    public string Name { get; set; }
    public string Diet { get; set; }
    public DateTime DateAcquired { get; set; }
    public decimal Weight { get; set; } = 0;
    public int EnclosureNumber { get; set; } = 0;
  }
}