using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        private Marker human = new Marker("Human");
        private Marker computer1 = new Marker("Computer1");
        private Marker computer2 = new Marker("Comptuer2");
        private Marker computer3 = new Marker("Computer3");

        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            new SetMap();
            StartGame();
        }

        private void StartGame()
        {
            human = new Marker("Human");
            computer1 = new Marker("Computer1");
            computer2 = new Marker("Computer2");
            computer3 = new Marker("Computer3");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DiceRoll();
            }
        }

        private void DiceRoll()
        {
            human.pos += rnd.Next(1, 6);
            computer1.pos += rnd.Next(1, 6);
            computer2.pos += rnd.Next(1, 6);
            computer3.pos += rnd.Next(1, 6);
            if (human.pos >= 100) { 
                Finish("Human");
            }
            else if (computer1.pos >= 100)
            {
                Finish("Computer1");
            }
            else if (computer2.pos >= 100)
            {
                Finish("Computer2");
            }
            else if (computer3.pos >= 100){
                Finish("Computer3");
            }
            CheckPos(human);
            CheckPos(computer1);
            CheckPos(computer2);
            CheckPos(computer3);
            UpdateScore();
        }

        private void CheckPos(Marker Player)
        {
            if (SetMap.landings.ContainsKey(Player.pos))
            {
                int oldPos = Player.pos;
                SetMap.landings.TryGetValue(Player.pos, out Player.pos);
                AlertChanges(Player, oldPos);
            }
        }

        private void AlertChanges(Marker Player, int oldPos)
        {
            if (Player.pos < oldPos)
            {
                MessageBox.Show(Player.name + " landed on a snake (" + oldPos + ") and moved back to " + Player.pos);
            }
            else
            {
                MessageBox.Show(Player.name + " landed on a ladder (" + oldPos + ") and moved up to " + Player.pos);
            }
        } 

        private void UpdateScore()
        {
            humanposlbl.Text = human.pos + "";
            computer1poslbl.Text = computer1.pos + "";
            computer2poslbl.Text = computer2.pos + "";
            computer3poslbl.Text = computer3.pos + "";
            UpdatePosition(human);
            UpdatePosition(computer1);
            UpdatePosition(computer2);
            UpdatePosition(computer3);

        }

        private void UpdatePosition(Marker Player)
        {
            int colPos = Player.pos % 10;
            if (colPos < 1) colPos = 0;
            int rowPos = Player.pos / 10;
            if (Player.name.Equals("Human", StringComparison.Ordinal))
            {
                int newRowPos = 450 - (rowPos * 50);
                int newColPos = colPos * 50;
                humanpnl.Location = new Point(newColPos, newRowPos);
            }
            else if (Player.name.Equals("Computer1", StringComparison.Ordinal))
            {
                int newRowPos = 450 - rowPos * 50;
                int newColPos = colPos * 50 + 25;
                compupnl1.Location = new Point(newColPos, newRowPos);
            }
            else if (Player.name.Equals("Computer2", StringComparison.Ordinal))
            {
                int newRowPos = (450 - rowPos * 50) + 25;
                int newColPos = colPos * 50;
                compupnl2.Location = new Point(newColPos, newRowPos);
            }
            else if (Player.name.Equals("Computer3", StringComparison.Ordinal))
            {
                int newRowPos = (450 - rowPos * 50) + 25;
                int newColPos = colPos * 50 + 25;
                compupnl3.Location = new Point(newColPos, newRowPos);
            }

        }

        private void Finish(string winner)
        {
            MessageBox.Show("The winner was the " + winner + "\nHuman = " + human.pos + "\nComputer1 = " + computer1.pos
                + "\nComputer2 = " + computer2.pos + "\nComputer3 = " + computer3.pos);
            StartGame();
        }

    }
}
