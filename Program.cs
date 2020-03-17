using System;
using System.IO;
using Stripe;

namespace dotnet_old
{
  class Program
  {
    static void Main(string[] args)
    {

      try
      {   // Open the text file using a stream reader.
        using (StreamReader sr = new StreamReader("results.json"))
        {
          // Read the stream to a string, and write the string to the console.
          String line = sr.ReadToEnd();
          StripeList<Charge> charges = Mapper<StripeList<Charge>>.MapFromJson(line);
          foreach(Charge ch in charges.Data) {
            Console.WriteLine(ch.Id);
          }
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
      }
      // var charge = Mapper<Charge>.MapFromJson(json);
    }
  }
}
