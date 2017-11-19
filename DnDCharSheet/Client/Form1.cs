using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ClassesAndLevels.Rows.Add("Barbarian");
            ClassesAndLevels.Rows.Add("Bard");
            ClassesAndLevels.Rows.Add("Cleric");
            ClassesAndLevels.Rows.Add("Druid");
            ClassesAndLevels.Rows.Add("Fighter");
            ClassesAndLevels.Rows.Add("Monk");
            ClassesAndLevels.Rows.Add("Paladin");
            ClassesAndLevels.Rows.Add("Ranger");
            ClassesAndLevels.Rows.Add("Rogue");
            ClassesAndLevels.Rows.Add("Sorceror");
            ClassesAndLevels.Rows.Add("Warlock");
            ClassesAndLevels.Rows.Add("Wizard");
        }

        private void textStrength_TextChanged(object sender, EventArgs e)
        {
            labelStrength.Text = calculateStats(textStrength.Text);
        }

        private void textDexterity_TextChanged(object sender, EventArgs e)
        {
            labelDexterity.Text = calculateStats(textDexterity.Text);
        }

        private void textConstitution_TextChanged(object sender, EventArgs e)
        {
            labelConstitution.Text = calculateStats(textConstitution.Text);
        }

        private void textIntelligence_TextChanged(object sender, EventArgs e)
        {
            labelIntelligence.Text = calculateStats(textIntelligence.Text);
        }

        private void textWidsom_TextChanged(object sender, EventArgs e)
        {
            labelWisdom.Text = calculateStats(textWisdom.Text);
        }

        private void textCharisma_TextChanged(object sender, EventArgs e)
        {
            labelCharisma.Text = calculateStats(textCharisma.Text);
        }
        public string calculateStats(string text)
        {
            switch (text)
            {
                case "1":
                    return "-5";
                case "2":
                case "3":
                    return "-4";
                case "4":
                case "5":
                    return "-3";
                case "6":
                case "7":
                    return "-2";
                case "8":
                case "9":
                    return "-1";
                case "10":
                case "11":
                    return "+0";
                case "12":
                case "13":
                    return "+1";
                case "14":
                case "15":
                    return "+2";
                case "16":
                case "17":
                    return "+3";
                case "18":
                case "19":
                    return "+4";
                case "20":
                case "21":
                    return "+5";
                case "22":
                case "23":
                    return "+6";
                case "24":
                case "25":
                    return "+7";
                case "26":
                case "27":
                    return "+8";
                case "28":
                case "29":
                    return "+9";
                case "30":
                    return "10";
            }
            return "";
        }
    }
}
