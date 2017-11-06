using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryFlags
{
  public partial class Form1 : Form
  {
    private Explorer countryExplorer;
    private int SelectedAnswer;
    private int Solution;

    public Form1 ()
    {
      InitializeComponent();
      countryExplorer = new Explorer ();
      LoadCountryList ();
      countryCode.Text = "";
      SelectedAnswer = 0; // no answer selected.
      buttonSubmitAnswer.Enabled = false;
    }


    // Load a list of countries into the country select box.
    public void LoadCountryList () 
    {
      string country;
      for (int i = 0; i < countryExplorer.GetNumberOfCountries (); i++)
      {
        country = countryExplorer.GetCountryName (i);
        countrySelect.Items.Add (country);
      }
    }


    // Update the flag image if user selects different country.
    private void countrySelect_SelectedIndexChanged (object sender, EventArgs e)
    {
      int countryIndex = countrySelect.SelectedIndex;
      try {
        flagImage.Image = Image.FromFile(countryExplorer.GetCountryFlag (countryIndex));
        countryCode.Text = "Country Code: " + countryExplorer.GetCountryCode (countryIndex);
      }
      catch
      {
        countryCode.Text = "Error: flag image not found";
        // handle exception
      }
    }

    private void radioButton1_CheckedChanged (object sender, EventArgs e)
    {
      SelectedAnswer = 1;
    }

    private void radioButton2_CheckedChanged (object sender, EventArgs e)
    {
      SelectedAnswer = 2;
    }

    private void radioButton3_CheckedChanged (object sender, EventArgs e)
    {
      SelectedAnswer = 3;
    }

    private void radioButton4_CheckedChanged (object sender, EventArgs e)
    {
      SelectedAnswer = 4;
    }

    private void buttonNewQuestion_Click (object sender, EventArgs e)
    {
      int [] options;
      options = RandomGenerator.FourValues (countryExplorer.GetNumberOfCountries ());
      radioButton1.Text = countryExplorer.GetCountryName (options [0]);
      radioButton2.Text = countryExplorer.GetCountryName (options [1]);
      radioButton3.Text = countryExplorer.GetCountryName (options [2]);
      radioButton4.Text = countryExplorer.GetCountryName (options [3]);
      radioButton1.Checked = false;
      radioButton2.Checked = false;
      radioButton3.Checked = false;
      radioButton4.Checked = false;
      Solution = RandomGenerator.Generator.Next (4);
      quizImage.Image = Image.FromFile(countryExplorer.GetCountryFlag (options [Solution]));
      buttonSubmitAnswer.Enabled = true;
    }

    private void buttonSubmitAnswer_Click (object sender, EventArgs e)
    {
      if (SelectedAnswer != 0) // don't evaluate if no answer selected
      {
        bool correct = false;
        switch (Solution)
        {
        case 0:
          if (SelectedAnswer == 1)
            correct = true;
          break;
        case 1:
          if (SelectedAnswer == 2)
            correct = true;
          break;
        case 2:
          if (SelectedAnswer == 3)
            correct = true;
          break;
        case 3:
          if (SelectedAnswer == 4)
            correct = true;
          break;
        default:
          break;
        }
        if (correct)
          quizImage.Image = Image.FromFile("Correct.png");
        else
          quizImage.Image = Image.FromFile("Wrong.png");
        buttonSubmitAnswer.Enabled = false;
        SelectedAnswer = 0;
      }
    }
  }
}
