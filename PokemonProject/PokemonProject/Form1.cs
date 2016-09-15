using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonProject
{
    public partial class Form1 : Form
    {

        //Variables for the Cost of Pokemon
        int pikachuCost = 6;
        int squirtleCost = 5;
        int charmanderCost = 5;
        int charmanderTotalCost = 0;
        int squirtleTotalCost = 0;
        int pikachuTotalCost = 0;
        double undiscountedCost = 0;
        double discountedCost = 0;
        int pikachuCount = 0;
        int squirtleCount = 0;
        int charmanderCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pikachuCounter_ValueChanged(object sender, EventArgs e)
        {
            //Counts for Pikachu Purchases
            if (pikachuCounter.Value > pikachuCount)
            {
                //Adds Pikachus
                pikachuCount++;
            }
            else if (pikachuCounter.Value < pikachuCount)
            {
                //Subtracts Pikachus
                pikachuCount--;
            }
        }

        private void SquirtleCounter_ValueChanged(object sender, EventArgs e)
        {
            //Counts for Squirtle Purchases
            if (SquirtleCounter.Value > squirtleCount)
            {
                //Adds Squirtles
                squirtleCount++;
            }
            else if (SquirtleCounter.Value < squirtleCount)
            {
                //Subtracts Squirtles
                squirtleCount--;
            }
        }

        private void CharmanderCounter_ValueChanged(object sender, EventArgs e)
        {
            //Counts for Charmander Purchases
            if (CharmanderCounter.Value > charmanderCount)
            {
                //Adds Charmanders
                charmanderCount++;
            }
            else if (CharmanderCounter.Value < charmanderCount)
            {
                //Subtracts Charmanders
                charmanderCount--;
            }
        }

        private double UndiscountedCostCalculation()
        {
            //Accounts for if you have 1 pokemon only
            undiscountedCost = pikachuTotalCost + squirtleTotalCost + charmanderTotalCost;
            return undiscountedCost;
        }

        private double DiscountedCostCalculation()
        {
            
            //Cost of Individual Discounts
            double psDiscCost = 0;
            double pcDiscCost = 0;
            double scDiscCost = 0;
            double pscDiscCost = 0;

            #region 10% Discount Calculations 
            //Pikachu and Squirtle Discount Calculations
            if ((pikachuCount >= 1 && squirtleCount >= 1))
            {
                if (pikachuCount == squirtleCount || pikachuCount < squirtleCount)
                {
                    psDiscCost = (((pikachuCost + squirtleCost) * .9) * pikachuCount);
                }
                else if (pikachuCount > squirtleCount)
                {
                    psDiscCost = (((pikachuCost + squirtleCost) * .9)) * squirtleCount;
                }
            }
            //Pikachu and Charmander Discount Calculations
            else if ((pikachuCount >= 1 && charmanderCount >= 1))
            {
                if (pikachuCount == squirtleCount || pikachuCount < charmanderCount)
                {
                    pcDiscCost = (((pikachuCost + charmanderCost) * .9) * pikachuCount);
                }
                else if (pikachuCount > charmanderCount)
                {
                    pcDiscCost = (((pikachuCost + charmanderCost) * .9)) * charmanderCount;
                }
            }
            //Squirtle Charmander Discount Calculations
            else if ((squirtleCount >= 1 && charmanderCount >= 1))
            {
                if (charmanderCount == squirtleCount || squirtleCount < charmanderCount)
                {
                    scDiscCost = (((squirtleCost + charmanderCost) * .9) * squirtleCount);
                }
                else if (squirtleCount > charmanderCount)
                {
                    scDiscCost = (((squirtleCost + charmanderCost) * .9)) * charmanderCount;
                }
            }

            //Excess Calculations i.e 3 pikachus and 1 squirtle
            //Pikachu and Squirtle
            //Pikachu is higher
            if (pikachuCount >= squirtleCount && (pikachuCount >= 1 && squirtleCount >= 1))
            {
                discountedCost = psDiscCost + (pikachuCost * (pikachuCount - squirtleCount));
            }
            //Squirtle is higher
            else if (squirtleCount >= pikachuCount && (pikachuCount >= 1 && squirtleCount >= 1))
            {
                discountedCost = psDiscCost + (squirtleCost * (squirtleCount - pikachuCount));
            }
            //Pikachu and Charmander
            //Pikachu is higher
            else if (pikachuCount >= charmanderCount && (pikachuCount >= 1 && charmanderCount >= 1))
            {
                discountedCost = pcDiscCost + (pikachuCost * (pikachuCount - charmanderCount));
            }
            //Charmander is Higher
            else if (charmanderCount >= pikachuCount && (pikachuCount >= 1 && charmanderCount >= 1))
            {
                discountedCost = pcDiscCost + (charmanderCost * (charmanderCount - pikachuCount));
            }
            //Squirtle and Charmander
            //Squirtle is higher
            else if (squirtleCount >= charmanderCount && (charmanderCount >= 1 && squirtleCount >= 1))
            {
                discountedCost = scDiscCost + (squirtleCost * (squirtleCount - charmanderCount));
            }
            //Charmander is higher
            else if (charmanderCount >= squirtleCount && (charmanderCount >= 1 && squirtleCount >= 1))
            {
                discountedCost = scDiscCost + (charmanderCost * (charmanderCount - squirtleCount));
            }
            //If only one pokemon
            else
            {
                return UndiscountedCostCalculation();
            }
            #endregion

            #region 20% Discount Calculations
            //Checks if it is for the 20% discount
            if (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1)
            {
                //All equal or Pikachu is least
                if ((pikachuCount == squirtleCount && pikachuCount == charmanderCount) || (pikachuCount < squirtleCount && pikachuCount < charmanderCount))
                {
                    pscDiscCost = (((pikachuCost + squirtleCost + charmanderCost) * .8) * pikachuCount);
                }
                //Squirtle is least
                else if (pikachuCount > squirtleCount && charmanderCost > squirtleCount)
                {
                    pscDiscCost = (((pikachuCost + squirtleCost + charmanderCost) * .8)) * squirtleCount;
                }
                //Charmander is least
                else if (pikachuCount > charmanderCount && squirtleCount > charmanderCount)
                {
                    pscDiscCost = (((pikachuCost + squirtleCost + charmanderCost) * .8)) * charmanderCount;
                }

                //Excess Pokemon Calculations
                //If one pokemon has more than the others.
                if ((pikachuCount >= squirtleCount && pikachuCount >= charmanderCount && squirtleCount == charmanderCount) && (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (pikachuCost * (pikachuCount - squirtleCount));
                }
                else if ((squirtleCount >= pikachuCount && squirtleCount >= charmanderCount && pikachuCount == charmanderCount) && (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (squirtleCost * (squirtleCount - pikachuCount));
                }
                else if ((charmanderCount >= pikachuCount && charmanderCount >= squirtleCount && pikachuCount == squirtleCount) && (pikachuCount >= 1 && charmanderCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (pikachuCost * (pikachuCount - charmanderCount));
                }
                //If two pokemon have more than the last one.
                else if ((pikachuCount >= squirtleCount && pikachuCount >= charmanderCount && pikachuCount == charmanderCount) && (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (((pikachuCost * (pikachuCount - squirtleCount)) + (charmanderCost * (charmanderCount - squirtleCount))) * .9);
                }
                else if ((pikachuCount <= squirtleCount && squirtleCount >= charmanderCount && squirtleCount == charmanderCount) && (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (((squirtleCost * (squirtleCount - pikachuCount)) + (charmanderCost * (charmanderCount - pikachuCount))) * .9);
                }
                else if ((pikachuCount >= charmanderCount && squirtleCount >= charmanderCount && squirtleCount == pikachuCount) && (pikachuCount >= 1 && squirtleCount >= 1 && charmanderCount >= 1))
                {
                    discountedCost = pscDiscCost + (((squirtleCost * (squirtleCount - charmanderCount)) + (pikachuCost * (pikachuCount - charmanderCount))) * .9);
                }
            }
            #endregion

            return discountedCost;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Displays the total Cost
            costLabel.Text = String.Format("{0:C}", DiscountedCostCalculation());
        }
    }
}
