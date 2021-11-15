using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Shop
{
    public partial class SandwichOrderingForm : Form
    {
        double totalCost = 0;
        double breadCost = 0;
        double ingredientsCost = 0;

        List<Bread> breads = new List<Bread>();
        List<Ingredient> ingredients = new List<Ingredient>();

        private RadioButton[] breadRadioButtons;
        private CheckBox[] ingredientsCheckBoxes;
        
        public SandwichOrderingForm()
        {
            InitializeComponent();
        }

        private void SandwichOrderingForm_Load(object sender, EventArgs e)
        {
            getBreadsFromFile();
            getIngredientsFromFile();
            createBreadRadioButtons();
            createIngredientsRadioButtons();
        }

        private void breadRadioButtons_ClickHandler(object sender, EventArgs e)
        {
            int position = (int)((RadioButton)sender).Tag;

            breadCost = breads[position].Price;
            getTotalCost();
        }

        private void IngredientsCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {   
            int position = (int)((CheckBox)sender).Tag;
            ingredientsCost = ingredients[position].Price;
            getTotalCost();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {

        }

        private void getTotalCost()
        {
            totalCost = breadCost + ingredientsCost;
            priceLabel.Text = totalCost.ToString();
        }

        private void setBreadsInFile()
        {
            string inputFile = "breadsInputFile.json";

            var breadsJson = JsonConvert.SerializeObject(breads);
            File.WriteAllText(inputFile, breadsJson);
        }

        private void setIngredientsInFile()
        {
            string inputFile = "ingredientsInputFile.json";

            var ingredientsJson = JsonConvert.SerializeObject(ingredients);
            File.WriteAllText(inputFile, ingredientsJson);
        }

        private void getBreadsFromFile()
        {
            string inputFile = "breadsInputFile.json";

            if (File.Exists(inputFile))
            {
                var fileContent = File.ReadAllText(inputFile);
                breads = JsonConvert.DeserializeObject<List<Bread>>(fileContent);
            }
            else
            {
                Bread white = new Bread("White", 5.5, 3);
                breads.Add(white);
                setBreadsInFile();
            }
        }

        private void getIngredientsFromFile()
        {
            string inputFile = "ingredientsInputFile.json";

            if (File.Exists(inputFile))
            {
                var fileContent = File.ReadAllText(inputFile);
                ingredients = JsonConvert.DeserializeObject<List<Ingredient>>(fileContent);
            }
            else
            {
                Ingredient ham = new Ingredient("Ham", 0.5);
                ingredients.Add(ham);
                setIngredientsInFile();
            }
        }

        private void createBreadRadioButtons()
        {
            breadRadioButtons = new RadioButton[breads.Count];

            for (int i = 0; i < breads.Count; ++i)
            {
                // PROPERTIES
                breadRadioButtons[i] = new RadioButton();
                breadGroupBox.Controls.Add(breadRadioButtons[i]);
                breadRadioButtons[i].Text = breads[i].Name;
                breadRadioButtons[i].Location = new Point(breadRadioButtons[i].Location.X + 10, breadRadioButtons[i].Location.Y + 20 + (i * 20));
                breadRadioButtons[i].AutoSize = true;
                breadRadioButtons[i].Tag = i;

                // EVENTS
                breadRadioButtons[i].Click += new System.EventHandler(breadRadioButtons_ClickHandler);
            }
        }

        private void createIngredientsRadioButtons()
        {
            ingredientsCheckBoxes = new CheckBox[ingredients.Count];

            for (int i = 0; i < ingredients.Count; ++i)
            {
                // PROPERTIES
                ingredientsCheckBoxes[i] = new CheckBox();
                ingredientsGroupBox.Controls.Add(ingredientsCheckBoxes[i]);
                ingredientsCheckBoxes[i].Text = ingredients[i].Name;
                ingredientsCheckBoxes[i].Location = new Point(ingredientsCheckBoxes[i].Location.X + 10, ingredientsCheckBoxes[i].Location.Y + 20 + (i * 20));
                ingredientsCheckBoxes[i].AutoSize = true;
                ingredientsCheckBoxes[i].Tag = i;

                // EVENTS
                ingredientsCheckBoxes[i].Click += new System.EventHandler(IngredientsCheckBoxes_CheckedChanged);
            }
        }
    }
}
