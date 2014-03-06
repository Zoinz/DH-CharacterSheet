using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_CharacterSheet_V2
{
    public partial class Form1 : Form
    {
        string baseLanguage = "Languages: Common";
        int RaceStatHealth = 0;
        int RaceStatResillience = 0;
        int RaceStatWillpower = 0;
        int RaceStatEnergy = 0;
        int RaceStatMeleeDmg = 0;
        int RaceStatMeleeCrit = 0;
        int RaceStatRangedDmg = 0;
        int RaceStatRangedCrit = 0;
        int RaceStatSpeed = 0;
        int RaceStatPower = 0;
        int RaceStatMagicDmg = 0;
        int RaceStatMagicCrit = 0;
        int RaceStatCrowdPower = 0;
        int RaceStatPowerEff = 0;
        int RaceStatPowerRecharge = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Stats()
        {
            int CurrentStatHealth = Convert.ToInt32(HealthStatAmountLabel.Text) - RaceStatHealth;
            int CurrentStatResillience = Convert.ToInt32(ResillienceStatAmountLabel.Text) - RaceStatResillience;
            int CurrentStatWillpower = Convert.ToInt32(WillpowerStatAmountLabel.Text) - RaceStatWillpower;
            int CurrentStatEnergy = Convert.ToInt32(EnergyStatAmountLabel.Text) - RaceStatEnergy;
            int CurrentStatMeleeDmg = Convert.ToInt32(MeleeDmgStatAmountLabel.Text) - RaceStatMeleeDmg;
            int CurrentStatMeleeCrit = Convert.ToInt32(MeleeCritStatAmountLabel.Text) - RaceStatMeleeCrit;
            int CurrentStatRangedDmg = Convert.ToInt32(RangedDmgStatAmountLabel.Text) - RaceStatRangedDmg;
            int CurrentStatRangedCrit = Convert.ToInt32(RangedCritStatAmountLabel.Text) - RaceStatRangedCrit;
            int CurrentStatSpeed = Convert.ToInt32(SpeedStatAmountLabel.Text) - RaceStatSpeed;
            int CurrentStatPower = Convert.ToInt32(PowerStatAmountLabel.Text) - RaceStatPower;
            int CurrentStatMagicDmg = Convert.ToInt32(MagicDmgStatAmountLabel.Text) - RaceStatMagicDmg;
            int CurrentStatMagicCrit = Convert.ToInt32(MagicCritStatAmountLabel.Text) - RaceStatMagicCrit;
            int CurrentStatCrowdPower = Convert.ToInt32(CrowdPowerStatAmountLabel.Text) - RaceStatCrowdPower;
            int CurrentStatPowerEff = Convert.ToInt32(PowerEffStatAmountLabel.Text) - RaceStatPowerEff;
            int CurrentStatPowerRecharge = Convert.ToInt32(PowerRechargeStatAmountLabel.Text) - RaceStatPowerRecharge;

            RaceStatHealth = 0;
            RaceStatResillience = 0;
            RaceStatWillpower = 0;
            RaceStatEnergy = 0;
            RaceStatMeleeDmg = 0;
            RaceStatMeleeCrit = 0;
            RaceStatRangedDmg = 0;
            RaceStatRangedCrit = 0;
            RaceStatSpeed = 0;
            RaceStatPower = 0;
            RaceStatMagicDmg = 0;
            RaceStatMagicCrit = 0;
            RaceStatCrowdPower = 0;
            RaceStatPowerEff = 0;
            RaceStatPowerRecharge = 0;

            switch (RaceCB.Text)
            {
                case "Human":
                    MessageBox.Show("I Hate You");
                    Application.Exit();
                    break;
                case "Dwarf":
                    RaceStatMeleeDmg = 2;
                    RaceStatResillience = 2;
                    break;
                case "Halfling":
                    RaceStatSpeed = 2;
                    RaceStatRangedCrit = 2;
                    break;
                case "Elf": 
                    RaceStatRangedDmg = 2;
                    RaceStatRangedCrit = 2;
                    break;
                case "Half-Elf":
                    RaceStatWillpower = 2;
                    RaceStatPowerRecharge = 2;
                    break;

            }

            if (RaceCB.Text != "Human")
            {
                HealthStatAmountLabel.Text = Convert.ToString(CurrentStatHealth + RaceStatHealth);
                ResillienceStatAmountLabel.Text = Convert.ToString(CurrentStatResillience + RaceStatResillience);
                WillpowerStatAmountLabel.Text = Convert.ToString(CurrentStatWillpower + RaceStatWillpower);
                EnergyStatAmountLabel.Text = Convert.ToString(CurrentStatEnergy + RaceStatEnergy);
                MeleeDmgStatAmountLabel.Text = Convert.ToString(CurrentStatMeleeDmg + RaceStatMeleeDmg);
                MeleeCritStatAmountLabel.Text = Convert.ToString(CurrentStatMeleeCrit + RaceStatMeleeCrit);
                RangedDmgStatAmountLabel.Text = Convert.ToString(CurrentStatRangedDmg + RaceStatRangedDmg);
                RangedCritStatAmountLabel.Text = Convert.ToString(CurrentStatRangedCrit + RaceStatRangedCrit);
                SpeedStatAmountLabel.Text = Convert.ToString(CurrentStatSpeed + RaceStatSpeed);
                PowerStatAmountLabel.Text = Convert.ToString(CurrentStatPower + RaceStatPower);
                MagicDmgStatAmountLabel.Text = Convert.ToString(CurrentStatMagicDmg + RaceStatMagicDmg);
                MagicCritStatAmountLabel.Text = Convert.ToString(CurrentStatMagicCrit + RaceStatMagicCrit);
                CrowdPowerStatAmountLabel.Text = Convert.ToString(CurrentStatCrowdPower + RaceStatCrowdPower);
                PowerEffStatAmountLabel.Text = Convert.ToString(CurrentStatPowerEff + RaceStatPowerEff);
                PowerRechargeStatAmountLabel.Text = Convert.ToString(CurrentStatPowerRecharge + RaceStatPowerRecharge);
            }

        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            //Adds languages to you character
            LanguageTB.Text = LanguageTB.Text + ", " + LanguageCB.Text;
        }

        private void ResetLanguageButton_Click(object sender, EventArgs e)
        {
            //Resets Languages to base language for your race
            LanguageTB.Text = baseLanguage;
        }

        public void RaceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolTip ToolTip = new ToolTip();

            switch (RaceCB.Text)
            {
                //Changes the base language of the character to reset languages
                case "Human":
                    ToolTip.SetToolTip(HeightLabel, "Average Height: 170 - 195 cm.");
                    ToolTip.SetToolTip(HeightTB, "Average Height: 170 - 195 cm.");
                    ToolTip.SetToolTip(WeightLabel, "Average Weight: 75 - 100 kg.");
                    ToolTip.SetToolTip(WeightTB, "Average Weight: 75 - 100 kg.");
                    baseLanguage = "Languages: Common";
                    VisionLabel.Text = "Vision: Normal";
                    RacialLabel.Visible = false;
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;
                case "Dwarf":
                    ToolTip.SetToolTip(HeightLabel, "Average Height: 140 - 155 cm.");
                    ToolTip.SetToolTip(HeightTB, "Average Height: 140 - 155 cm.");
                    ToolTip.SetToolTip(WeightLabel, "Average Weight: 70 - 100 kg.");
                    ToolTip.SetToolTip(WeightTB, "Average Weight: 70 - 100 kg.");

                    baseLanguage = "Languages: Common, Dwarven";
                    VisionLabel.Text = "Vision: Normal, Lowlight";
                    RacialLabel.Text = "Weapon Mastery: Dwarf have easier training weapons";
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;
                case "Halfling":
                    ToolTip.SetToolTip(HeightLabel, "Average Height: 75 - 100 cm.");
                    ToolTip.SetToolTip(HeightTB, "Average Height: 75 - 100 cm.");
                    ToolTip.SetToolTip(WeightLabel, "Average Weight: 35 - 55 kg.");
                    ToolTip.SetToolTip(WeightTB, "Average Weight: 35 - 55 kg.");
                    baseLanguage = "Languages: Common";
                    VisionLabel.Text = "Vision: Normal, Lowlight";
                    RacialLabel.Text = "Well Fed: When you are fed you recuperate faster";
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;
                case "Elf":
                    ToolTip.SetToolTip(HeightLabel, "Average Height: 165 - 180 cm.");
                    ToolTip.SetToolTip(HeightTB, "Average Height: 165 - 180 cm.");
                    ToolTip.SetToolTip(WeightLabel, "Average Weight: 55 - 70 kg.");
                    ToolTip.SetToolTip(WeightTB, "Average Weight: 55 - 70 kg.");
                    baseLanguage = "Languages: Common, Elven";
                    VisionLabel.Text = "Vision: Normal, Lowlight";
                    RacialLabel.Text = "Lightweight: You are more stealthy when moving";
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;
                case "Half-Elf":
                    ToolTip.SetToolTip(HeightLabel, "Average Height: 165 - 185 cm.");
                    ToolTip.SetToolTip(HeightTB, "Average Height: 165 - 185 cm.");
                    ToolTip.SetToolTip(WeightLabel, "Average Weight: 70 - 90 kg.");
                    ToolTip.SetToolTip(WeightTB, "Average Weight: 70 - 90 kg.");
                    baseLanguage = "Languages: Common, Elven";
                    VisionLabel.Text = "Vision: Normal";
                    RacialLabel.Text = "Silver Tongue: You are more persuasive than normal";
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;
                default:
                    baseLanguage = "Languages: Common";
                    VisionLabel.Text = "Vision: Normal";
                    RacialLabel.Visible = false;
                    Racial1Label.Visible = false;
                    Racial2Label.Visible = false;
                    RaceSpecialSpecialsLabel.Visible = false;
                    break;


            }
            Stats();
        }

        private void AddExpButton_Click(object sender, EventArgs e)
        {
            ExpProgressBar.Maximum = Convert.ToInt16(LevelAmountLabel.Text); //Changing Progressbar amount needed for full to Level + 1
            int CurrentExp = ExpProgressBar.Value;
            int NumericUpDownValue = Convert.ToInt16(AddToExpNumericUpDown.Value); //Creates int for adding exp
            int RemainingForLevelUp = Convert.ToInt16(LevelAmountLabel.Text) - CurrentExp;
            int ExcessiveExpLevelUp = NumericUpDownValue - RemainingForLevelUp; // Sets excessive amount of exp
            int RequiredForLevelDown = ExpProgressBar.Minimum + ExpProgressBar.Value; //Makes a int for the amount of exp left for level down
            int LevelValue = Convert.ToInt16(LevelAmountLabel.Text); //Making the LevelLabel a int
            int PrimaryStatValue = Convert.ToInt16(PrimaryStatPointsAmountLabel.Text);

            if (NumericUpDownValue == RemainingForLevelUp)
            {
                LevelAmountLabel.Text = Convert.ToString(LevelValue + 1); //Increases level when progressbar reaches maximum
                ExpProgressBar.Value = ExpProgressBar.Minimum; //Resets Expbar
                PrimaryStatPointsAmountLabel.Text = Convert.ToString(PrimaryStatValue + 1); //Increases primary stat amount to spend
            }
            else if (NumericUpDownValue > RemainingForLevelUp)
            {
                ExpProgressBar.Value = (ExpProgressBar.Value + RemainingForLevelUp); //Gives exact exp u need to level up
                LevelAmountLabel.Text = Convert.ToString(LevelValue + 1); //Increases level when progressbar reaches maximum
                ExpProgressBar.Value = ExpProgressBar.Minimum; //Resets Expbar
                ExpProgressBar.Value = (ExpProgressBar.Value + ExcessiveExpLevelUp); //Adds excessive exp 
                ExpProgressBar.Maximum = Convert.ToInt16(LevelAmountLabel.Text); //Changing Progressbar amount needed for full to Level + 1
                PrimaryStatPointsAmountLabel.Text = Convert.ToString(PrimaryStatValue + 1); //Increases primary stat amount to spend
            }
            else if (NumericUpDownValue < RemainingForLevelUp)
            {
                ExpProgressBar.Value = ExpProgressBar.Value + NumericUpDownValue; //Increases expamount
            }

        }
    }
}
