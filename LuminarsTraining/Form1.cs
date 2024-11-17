using System.Diagnostics.Eventing.Reader;

namespace LuminarsTraining
{
    public partial class Form1 : Form
    {
        List<string> playerNames = new List<string>();
        List<int> playerKills = new List<int>();
        List<int> playerDeaths = new List<int>();
        List<int> playerRetreats = new List<int>();
        List<int> CplayerKills = new List<int>();
        List<int> CplayerDeaths = new List<int>();
        List<int> CplayerRetreats = new List<int>();
        List<int> playerMadeRetreat = new List<int>();
        List<int> CplayerMadeRetreat = new List<int>();
        List<int> Warnings = new List<int>();
        List<int> Rankings = new List<int>();

        bool debounce = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                PlayerName.Text = listBox1.Text;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int itemSelected = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(itemSelected);
                listBox2.Items.RemoveAt(itemSelected);
                listBox3.Items.RemoveAt(itemSelected);
                listBox4.Items.RemoveAt(itemSelected);
                listBox5.Items.RemoveAt(itemSelected);
                playerKills.RemoveAt(itemSelected);
                CplayerDeaths.RemoveAt(itemSelected);
                playerDeaths.RemoveAt(itemSelected);
                playerMadeRetreat.RemoveAt(itemSelected);
                CplayerMadeRetreat.RemoveAt(itemSelected);
                Warnings.RemoveAt(itemSelected);
                listBox1.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
                playerNames.Add(textBox1.Text);
                playerKills.Add(0);
                playerDeaths.Add(0);
                playerRetreats.Add(0);
                playerMadeRetreat.Add(0);
                CplayerKills.Add(0);
                CplayerDeaths.Add(0);
                CplayerRetreats.Add(0);
                CplayerMadeRetreat.Add(0);
                Warnings.Add(0);

                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add("0" + "K / " + "0" + "D / " + "0" + "R / " + "0" + "M");
                listBox4.Items.Add("0" + "K / " + "0" + "D / " + "0" + "R / " + "0" + "M");
                listBox5.Items.Add("");
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerNames.Count; i++)
            {
                CplayerKills[i] = 0;
                CplayerDeaths[i] = 0;
                CplayerRetreats[i] = 0;
                CplayerMadeRetreat[i] = 0;
                listBox3.Items.RemoveAt(i);
                listBox3.Items.Insert(i, CplayerKills[i] + "K / " + CplayerDeaths[i] + "D / " + CplayerRetreats[i] + "R / " + CplayerMadeRetreat[i] + "M");

            }
            PlayerName.Text = "N/A";
            KillsLabelCount.Text = "0";
            DeathsLabelCount.Text = "0";
            RetreatsLabelCount.Text = "0";
            MadeRetreatLabel.Text = "0";
        }

        private void KillButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerKills[listBox1.SelectedIndex] -= 1;
                CplayerKills[listBox1.SelectedIndex] -= 1;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                UpdateList();
            }

        }

        private void KillButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerKills[listBox1.SelectedIndex] += 1;
                CplayerKills[listBox1.SelectedIndex] += 1;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void DeathButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerDeaths[listBox1.SelectedIndex] -= 1;
                CplayerDeaths[listBox1.SelectedIndex] -= 1;
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void DeathButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerDeaths[listBox1.SelectedIndex] += 1;
                CplayerDeaths[listBox1.SelectedIndex] += 1;
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void RetreatButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerRetreats[listBox1.SelectedIndex] -= 1;
                CplayerRetreats[listBox1.SelectedIndex] -= 1;
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void RetreatButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerRetreats[listBox1.SelectedIndex] += 1;
                CplayerRetreats[listBox1.SelectedIndex] += 1;
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }


        private void UpdateList()
        {

            Rankings.Clear();
            for (int i = 0; i < playerNames.Count; i++)
            {
                int playerScore = 0;
                playerScore += playerKills[i] * 2;
                playerScore += playerMadeRetreat[i];
                // playerScore += playerRetreats[i] / 2;
                //playerScore -= playerDeaths[i];
                //playerScore += Warnings[i];

                Rankings.Add(playerScore);
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            for (int i = 0; i < playerNames.Count; i++)
            {
                int HighestScore = -9999;
                int CurrentScore = 0;
                int CurrentPositioning = 0;
                for (int j = 0; j < Rankings.Count; j++)
                {
                    CurrentScore = Rankings[j];
                    if (CurrentScore == HighestScore)
                    {
                        if (playerRetreats[j] > playerRetreats[CurrentPositioning])
                        {
                            CurrentPositioning = j;
                        }
                        else
                        {
                            if (playerDeaths[j] < playerDeaths[CurrentPositioning])
                            {
                                CurrentPositioning = j;
                            }
                            else
                            {
                                if (Warnings[j] < Warnings[CurrentPositioning])
                                {
                                    CurrentPositioning = j;
                                }

                            }
                        }
                    }
                    else
                    {
                        if(CurrentScore > HighestScore)
                        {
                            CurrentPositioning = j;
                            HighestScore = CurrentScore;
                        }
                    }
                    if (j == Rankings.Count - 1)
                    {
                        listBox2.Items.Add(playerNames[CurrentPositioning]);
                        listBox3.Items.Add(CplayerKills[CurrentPositioning] + "K / " + CplayerDeaths[CurrentPositioning] + "D / " + CplayerRetreats[CurrentPositioning] + "R / " + CplayerMadeRetreat[CurrentPositioning] + "M");
                        listBox4.Items.Add(playerKills[CurrentPositioning] + "K / " + playerDeaths[CurrentPositioning] + "D / " + playerRetreats[CurrentPositioning] + "R / " + playerMadeRetreat[CurrentPositioning] + "M");
                        Rankings[CurrentPositioning] = -9999;
                    }
                }
            }

        }
   


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KillsLabelCount_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MadeRetreatMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerMadeRetreat[listBox1.SelectedIndex] -= 1;
                CplayerMadeRetreat[listBox1.SelectedIndex] -= 1;
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void MadeRetreatPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                playerMadeRetreat[listBox1.SelectedIndex] += 1;
                CplayerMadeRetreat[listBox1.SelectedIndex] += 1;
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string currentWarnings = listBox5.Items[listBox1.SelectedIndex].ToString() + " X";
                listBox5.Items.RemoveAt(listBox1.SelectedIndex);
                listBox5.Items.Insert(listBox1.SelectedIndex, currentWarnings);
                listBox6.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString() + " - Warning - " + textBox2.Text);
                Warnings[listBox1.SelectedIndex] = Warnings[listBox1.SelectedIndex] + 1;
                UpdateList();
                textBox2.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox5.Items[listBox1.SelectedIndex].ToString().Length != 0)
            {
                string currentWarnings = (listBox5.Items[listBox1.SelectedIndex].ToString().Substring(0, listBox5.Items[listBox1.SelectedIndex].ToString().Length - 2));
                listBox5.Items.RemoveAt(listBox1.SelectedIndex);
                listBox5.Items.Insert(listBox1.SelectedIndex, currentWarnings);
                listBox6.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString() + " - Removed Warning");
                Warnings[listBox1.SelectedIndex] = Warnings[listBox1.SelectedIndex] - 1;
                UpdateList();
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("Note - " + textBox2.Text);
            textBox2.Text = "";
        }
    }
}
