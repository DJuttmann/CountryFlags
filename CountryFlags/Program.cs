


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace CountryFlags
{
  class RandomGenerator
  {
    public static Random Generator = new Random ();

    public static int [] FourValues (int max) {
      int [] values = new int [4];
      for (int i = 0; i < 4; i++)
      {
        bool retry;
        do
        {
          values [i] = Generator.Next (max);
          retry = false;
          for (int j = 0; j < i; j++)
          {
            if (values [j] == values [i])
              retry = true; // retry picking this random number because it is a duplicate
          }
        } while (retry);
      }
      return values;
    }
  }
  
  class Country
  {
    private string name;
    public string Name {get {return name;}}

    private string code; // Two letter code
    public string Code {get {return code;}}

    private string flag;
    public string Flag {get {return flag;}}

    // METHODS

    public Country (string name, string flag, string code)
    {
      this.name = name;
      this.flag = flag;
      this.code = code;
    }
  }


   
  class Explorer
  {
    private string IndexFile = "settings.txt"; // file containing path to flag images
    private string DataPath; // path to the folder containing flag images

    private List <Country> Countries;

    // METHODS

    // Constructor.
    public Explorer ()
    {
      Countries = new List <Country> (0);
      Init ();
    }


    // Read list of countries from file.
    bool ReadCountryList (string fileName)
    {
      Countries.Capacity = 0;
      Country newCountry;
      string [] countryList; // list of countries
      string [] countryProperties; // properties of the countries
      try
      {
        countryList = System.IO.File.ReadAllLines (fileName);
      }
      catch (Exception ex)
      {
        // Handle exception
        return false;
      }
      for (int i = 0; i < countryList.Length; i++)
      {
        countryProperties = countryList [i].Split (new [] {'\t'});
        if (countryProperties.Length >= 3)
        {
          newCountry = new Country (countryProperties [0],
                                    countryProperties [1],
                                    countryProperties [2]);
          Countries.Add (newCountry);
        }
      }
      return true;
    }


    // Initialize, read filename for country list.
    bool Init ()
    {
      string [] lines;
      string indexFile;
      try
      {
        lines = System.IO.File.ReadAllLines (IndexFile);
        if (lines.Length >= 2) {
          DataPath = lines [0];
          indexFile = DataPath + lines [1];
        }
        else
          return false;
      }
      catch (Exception ex)
      {
        // handle exception
        return false;
      }
      ReadCountryList (indexFile);

      return true;
    }


    // Returns name of country.
    public string GetCountryName (int index)
    {
      if (index >= 0 && index < Countries.Count)
        return Countries [index].Name;
      return "<Invalid index>";
    }


    // Returns two letter code of country.
    public string GetCountryCode (int index)
    {
      if (index < Countries.Count)
        return ((Country) Countries [index]).Code;
      return "";
    }


    // Returns flag filename of country.
    public string GetCountryFlag (int index)
    {
      if (index < Countries.Count)
        return DataPath + ((Country) Countries [index]).Flag;
      return "";
    }


    // Returns the number of countries.
    public int GetNumberOfCountries ()
    {
      return Countries.Count;
    }
  }


  
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }

  }
}
