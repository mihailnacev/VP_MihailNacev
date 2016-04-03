using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_SportsBet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Team t = new Team("Барселона", "Шпанија");
            lbTeams.Items.Add(t);
            t= new Team("Реал Мадрид", "Шпанија");
            lbTeams.Items.Add(t);
            t= new Team("Манчестер Ј.", "Англија");
            lbTeams.Items.Add(t);
            t = new Team("Арсенал", "Англија");
            lbTeams.Items.Add(t);
            t = new Team("Милан", "Италија");
            lbTeams.Items.Add(t);
            t = new Team("Бенфика", "Португалија");
            lbTeams.Items.Add(t);
        }

        private void btnDodadiTim_Click(object sender, EventArgs e)
        {
            AddTeamForm forma = new AddTeamForm();
            if(forma.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            lbTeams.Items.Add(forma.team);
        }

        private void btnDodadiBilten_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count == 2)
            {
                Game game = new Game();
                game.homeTeam = lbTeams.SelectedItems[0] as Team;
                game.guestTeam = lbTeams.SelectedItems[1] as Team;
                game.code = tbSifra.Text;
                game.Coeff[0] = (double)nudKoef1.Value;
                game.Coeff[1] = (double)nudKoef2.Value;
                game.Coeff[2] = (double)nudKoef3.Value;
                lbGames.Items.Add(game);
            }
            else
            {
                MessageBox.Show("Избери точно 2 тима!");
            }
        }

        private void btnDodadiNatprevar_Click(object sender, EventArgs e)
        {
            if(lbGames.SelectedItem!=null && cbTip.SelectedItem != null)
            {
                TicketItem ti = new TicketItem();
                ti.game = lbGames.SelectedItem as Game;
                ti.tip = cbTip.SelectedIndex;
                lbTickets.Items.Add(ti);
            }
        }
    }
}
