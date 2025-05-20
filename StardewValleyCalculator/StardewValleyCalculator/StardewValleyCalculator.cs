using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace StardewValleyCalculator
{
    public partial class StardewValleyCalculator : Form
    {
        //Project independently created by Brody McCormick
        
        public StardewValleyCalculator()
        {
            InitializeComponent();

            //Calls method to intialize dictionary 
            InitializeBaseCropValues();

            //For loop to display options 0-14 in Farming Level combo box
            for (int i = 0; i <= 14; i++)
            {
                cmbFarmingLvl.Items.Add(i.ToString());

                cmbFarmingLvl.SelectedIndex = 0;
            }
        }


        private void StardewValleyCalculator_Load(object sender, EventArgs e)
        {
            txtFertilizer.Text = "0";
            txtCostPerSeed.Text = "0";
            txtSeedNumber.Text = "0";
        }

        int seedNumber;
        int costPerSeed, fertilizerLevel;
        int farmingLevel;
        int avgProcessedProfit;

        int minProfit, avgProfit, maxProfit;

        

        //cropValues dataset representing crop names and their corresponding value
        private void InitializeBaseCropValues()
        {
            cropValues.Add("Coffee Bean", 15);
            cropValues.Add("Tulip", 30);
            cropValues.Add("Rice", 30);
            cropValues.Add("Parsnip", 35);
            cropValues.Add("Green Bean", 40);
            cropValues.Add("Blue Jazz", 50);
            cropValues.Add("Garlic", 60);
            cropValues.Add("Potato", 80);
            cropValues.Add("Kale", 110);
            cropValues.Add("Strawberry", 120);
            cropValues.Add("Cauliflower", 175);
            cropValues.Add("Rhubarb", 220);
            cropValues.Add("Ancient Fruit", 550);
            cropValues.Add("Cactus Fruit", 75);
            cropValues.Add("Hops", 25);
            cropValues.Add("Wheat", 25);
            cropValues.Add("Hot Pepper", 40);
            cropValues.Add("Blueberry", 50);
            cropValues.Add("Corn", 50);
            cropValues.Add("Tomato", 60);
            cropValues.Add("Sunflower", 80);
            cropValues.Add("Radish", 90);
            cropValues.Add("Summer Spangle", 90);
            cropValues.Add("Poppy", 140);
            cropValues.Add("Melon", 250);
            cropValues.Add("Red Cabbage", 260);
            cropValues.Add("Starfruit", 750);
            cropValues.Add("Taro Root", 30);
            cropValues.Add("Pineapple", 30);
            cropValues.Add("Eggplant", 60);
            cropValues.Add("Bok Choy", 80);
            cropValues.Add("Cranberries", 75);
            cropValues.Add("Grape", 80);
            cropValues.Add("Beet", 100);
            cropValues.Add("Amaranth", 150);
            cropValues.Add("Artichoke", 160);
            cropValues.Add("Yam", 160);
            cropValues.Add("Fairy Rose", 290);
            cropValues.Add("Pumpkin", 320);
            cropValues.Add("Sweet Gem Berry", 3000);
        }

        //Creates dictionary called cropValues
        private readonly Dictionary<string, int> cropValues = new Dictionary<string, int>();
        

        private bool ValidateInputFields()
        {
            //Data validation for empty(Null) textboxes 
            if (string.IsNullOrWhiteSpace(txtEnterCrop.Text) ||
                string.IsNullOrWhiteSpace(txtSeedNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCostPerSeed.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ParseInput(out int seedNumber, out int costPerSeed, out int farmingLevel, out int fertilizerLevel)
        {
            costPerSeed = 0;
            farmingLevel = 0;
            fertilizerLevel = 0;

            //Data validation 
            if (!int.TryParse(txtSeedNumber.Text, out seedNumber) ||
                !int.TryParse(txtCostPerSeed.Text, out costPerSeed))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values in Seed Number and Cost Per Seed fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeedNumber.Text = "0";
                txtCostPerSeed.Text = "0";
                return false;
            }

            if (!int.TryParse(txtFertilizer.Text, out fertilizerLevel))
            {
                MessageBox.Show("Fertilizer input error. Please enter valid number values following the key provided.", "Fertilizer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFertilizer.Text = "0";
                return false;
            }

            if (int.TryParse(cmbFarmingLvl.SelectedItem.ToString(), out farmingLevel))
            {
                if(farmingLevel < 0 || farmingLevel > 14)
                    {
                    MessageBox.Show("Farming level must be between 0 and 14.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbFarmingLvl.SelectedIndex = 0; // Reset combo box to the first item
                    return false;
                }
            }

            return true;
        }

        private bool ValidateCropName(string cropName)
        {
            //Validate crop name to see if name is contained in the dictionary
            if (!cropValues.ContainsKey(cropName))
            {
                MessageBox.Show("Invalid crop name entered, check for spelling or capitalization error.", "Crop Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        
        //Trims 
        private void txtEnterCrop_TextChanged(object sender, EventArgs e)
        {
            string cropName = txtEnterCrop.Text.Trim();

            if (cropValues.ContainsKey(cropName))
            {
                _ = cropValues[cropName];
            }
        }


        private void btnCalculateProfit_Click(object sender, EventArgs e)
        {
            //Inside a try-catch statement for exception handling
            try
            {
                //3 methods called for data validation
                if (!ValidateInputFields())
                    return;

                //Calls ParseInput 
                if (!ParseInput(out seedNumber, out costPerSeed, out farmingLevel, out fertilizerLevel))
                    return;

                // Check if the entered crop name exists in the dictionary
                string cropName = txtEnterCrop.Text;
                if (!ValidateCropName(cropName))
                    return;

                //Checks if checkbox is checked
                bool tillerChecked = cbTiller.Checked;
                bool kegChecked = cbKeg.Checked;
                bool preservesChecked = cbPreserves.Checked;


                // Calculate probabilities
                double goldProbability = (0.2 * (farmingLevel / 10.0) + 0.2 * fertilizerLevel * ((farmingLevel + 2) / 12.0) + 0.01) * seedNumber;
                double silverProbability = 2 * goldProbability;
                double iridiumProbability = 0.0;
                if (fertilizerLevel == 3)
                {
                    iridiumProbability = goldProbability / 2;
                }

                // Calculate profits
                int baseProfit = seedNumber * cropValues[cropName];
                int goldProfit = (int)Math.Floor(goldProbability * cropValues[cropName] * 1.5);
                int silverProfit = (int)Math.Floor(silverProbability * cropValues[cropName] * 1.25);
                int iridiumProfit = (int)Math.Floor(iridiumProbability * cropValues[cropName] * 2);

                int avgMarginGold = (int)Math.Floor(goldProbability * cropValues[cropName]);
                int avgMarginSilver = (int)Math.Floor(silverProbability * cropValues[cropName]);
                int avgMarginIridium = (int)Math.Floor(iridiumProbability * cropValues[cropName]);


                if (fertilizerLevel == 3)
                {
                    //Calculations for min, max, and avg if fertilizer is equal to 3
                    minProfit = (int)(baseProfit * 1.25 - (costPerSeed * seedNumber));
                    maxProfit = (int)(seedNumber * cropValues[cropName] * 2 - (costPerSeed * seedNumber)); //Fertilizer 3 = 2* multiplier on max profit
                    avgProfit = (int)(seedNumber * cropValues[cropName] - (avgMarginGold) - (avgMarginIridium) + (goldProfit) + (iridiumProfit) - (seedNumber * costPerSeed));
                }
                else
                {
                    //Calculations for min, max, and avg if fertilizer does not equal 3
                    minProfit = (int)(baseProfit - (costPerSeed * seedNumber));
                    maxProfit = (int)(baseProfit * 1.5);
                    avgProfit = (int)(baseProfit - (avgMarginGold) - (avgMarginSilver) + (goldProfit) + (silverProfit) - (seedNumber * costPerSeed));
                }

                // Additional logic for vegetables and fruits for processed profits
                if (IsVegetable(cropName))
                {
                    if (kegChecked)
                    {
                        avgProcessedProfit = ((int)(baseProfit * 2.25 - (costPerSeed * seedNumber))); // multiply avgProfit by 2.25 if cbKeg is checked
                    }
                    else if (preservesChecked)
                    {
                        avgProcessedProfit = minProfit * 2 + 50 * seedNumber; // calculate avgProfit for preserves
                    }
                    else
                    {
                        avgProcessedProfit = 0;
                    }
                }
                else if (IsFruit(cropName))
                {
                    if (kegChecked)
                    {
                        avgProcessedProfit = minProfit * 3; // multiply avgProfit by 3 if cbKeg is checked
                    }
                    else if (preservesChecked)
                    {
                        avgProcessedProfit = minProfit * 2 + 50 * seedNumber; // calculate avgProfit for preserves
                    }
                    else
                    {
                        avgProcessedProfit = 0;
                    }
                }
                else if (IsCoffee(cropName))
                {
                    if (kegChecked)
                    {
                        avgProcessedProfit = (int)((seedNumber * 4) / 5 * 150 - (costPerSeed * seedNumber));
                    }
                    else { avgProcessedProfit = 0; }
                }
                else if (IsWheat(cropName))
                {
                    if (kegChecked)
                    {
                        avgProcessedProfit = seedNumber * 200;
                    }
                    else { avgProcessedProfit = 0; }
                }
                else if (IsHops(cropName))
                {
                    if (kegChecked)
                    {
                        avgProcessedProfit = seedNumber * 300;
                    }
                    else { avgProcessedProfit = 0; }
                }


                //Adds 10% bonues if tiller proffession is checked
                if (tillerChecked)
                {
                    minProfit = (int)(minProfit * 1.1);
                    avgProfit = (int)(avgProfit * 1.1);
                    maxProfit = (int)(maxProfit * 1.1);
                }

                // Display results
                txtMinProfit.Text = minProfit.ToString() + "g";
                txtAvgProfit.Text = avgProfit.ToString() + "g";
                txtMaxProfit.Text = maxProfit.ToString() + "g";
                txtProcessed.Text = avgProcessedProfit.ToString() + "g";
            }
            catch (Exception ex)
            {
                //Exception handling error message
                MessageBox.Show("An exception has occured: " + ex.Message, "Exception Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Methods to represent categories of crops for processed profit calculations
        private bool IsFruit(string cropName)
        {
            List<string> fruits = new List<string> { "Ancient Fruit", "Blueberry", "Cactus Fruit", "Cranberries", "Grape", 
                "Hot Pepper", "Melon", "Pineapple", "Rhubarb", "Starfruit", "Strawberry" };
            return fruits.Contains(cropName);
        }

        private bool IsVegetable(string cropName)
        {
            List<string> vegetables = new List<string> { "Amaranth", "Artichoke", "Beet", "Bok Choy", "Cauliflower", "Corn", "Eggplant", "Garlic", "Green Bean", 
                "Kale", "Parsnip", "Potato", "Pumpkin", "Radish", "Red Cabbage", "Taro Root", "Rice", "Yam" };
            return vegetables.Contains(cropName);
        }

        private bool IsCoffee(string cropName)
        {
            List<string> coffee = new List<string> { "Coffee Bean" };
            return coffee.Contains(cropName);
        }

        private bool IsWheat(string cropName)
        {
            List<string> wheat = new List<string> { "Wheat" };
            return wheat.Contains(cropName);
        }

        private bool IsHops(string cropName)
        {
            List<string> hops = new List<string> { "Hops" };
            return hops.Contains(cropName);
        }

        
        
        //Exit event to close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //Clear click events
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMinProfit.Clear();
            txtAvgProfit.Clear();
            txtMaxProfit.Clear();
            txtProcessed.Clear();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtAvgProfit.Clear();
            txtMaxProfit.Clear();
            txtMinProfit.Clear();
            txtCostPerSeed.Text = "0";
            txtFertilizer.Text = "0";
            txtEnterCrop.Clear();
            txtSeedNumber.Text = "0";
            txtProcessed.Clear();
            cmbFarmingLvl.SelectedItem = 0;
            cbKeg.Checked = false;
            cbPreserves.Checked = false;
            cbTiller.Checked = false;
        }

        
        //CheckedChanged methods to allow user to only select 1 or the other
        private void cbPreserves_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeg.Checked && cbPreserves.Checked)
            {
                MessageBox.Show("You may only select either Keg or Preserves Jar, not both.", "CheckBox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbKeg.Checked = false;
            }
        }
        private void cbKeg_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeg.Checked && cbPreserves.Checked)
            {
                MessageBox.Show("You may only select either Keg or Preserves Jar, not both.", "CheckBox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPreserves.Checked = false;
            }
        }
       
        //Unused methods
        private void txtFertilizer_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCostPerSeed_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbTiller_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtProcessed_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblNumberofCalculations_Click(object sender, EventArgs e)
        {

        }
        private void txtMinProfit_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAvgProfit_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbFarmingLvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void txtMaxProfit_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        //Copyright Notice: The Stardew Valley™ Logo, Background, and it's likeness are property of Eric Barone ©2016: https://www.stardewvalley.net
        //Scroll name and title images created by kdau found here: https://www.kdau.com/scrollish/
        //Stardew Valley™ font created by Elliot Truelove found here: https://www.fontbolt.com/font/stardew-valley-font/
        //Calculations and formulas taken from the Stardew Valley™ Wiki which are taken directly from Stardew Valley's™ code: https://stardewvalleywiki.com/Farming
    }
}
