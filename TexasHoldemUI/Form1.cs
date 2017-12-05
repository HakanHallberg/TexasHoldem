using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexasHoldem.Library.Classes;
using TexasHoldem.Library.Structs;

namespace TexasHoldemUI
{
    public partial class Form1 : Form
    {
        private void ClearPlayerCardsFromTable()
        {
            foreach (var Card in _playerCardLabels.ToList())
            {
                this.Controls.Remove(Card);
            }
        }

        private void ClearDealerCardsFromTable()
        {
            foreach (var Card in _dealerCardLabels)
            {
                this.Controls.Remove(Card);
            }
        }

        private List<Label> _playerCardLabels = new List<Label>();
        private List<Label> _dealerCardLabels = new List<Label>();

        Point[] _playerLblPos = new Point[]
        {
            new Point(630, 265), new Point(680, 265),
            new Point(500, 365), new Point(550, 365),
            new Point(300, 365), new Point(350, 365),
            new Point(160, 265), new Point(210, 265)
        };

        Point[] _dealerLblPos = new Point[]
        {
            new Point(320, 265), new Point(370, 265),
            new Point(420, 265), new Point(470, 265),
            new Point(520, 265)
        };

        private Label CreateCard(int x, int y, Card card)
        {
            Label lbl = new Label();
            lbl.Text = card.Output;
            lbl.Size = new Size(45, 60);
            lbl.Location = new Point(x, y);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Font = new Font("Consolas", 15);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BackColor = Color.White;

            if(card.Suit.Equals("Hearts") || card.Suit.Equals("Dimonds"))
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Black;
            }
            return lbl;
        }

        void ClearHandLabels()
        {
            lblHand1.Text = string.Empty;
            lblHand2.Text = string.Empty;
            lblHand3.Text = string.Empty;
            lblHand4.Text = string.Empty;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> names = new List<string>();

                if (!string.IsNullOrEmpty(txtPlayerName1.Text))
                {
                    names.Add(txtPlayerName1.Text);
                    lblPlayerName1.Text = txtPlayerName1.Text;
                }

                if (!string.IsNullOrEmpty(txtPlayerName2.Text))
                {
                    names.Add(txtPlayerName2.Text);
                    lblPlayerName2.Text = txtPlayerName2.Text;
                }

                if (!string.IsNullOrEmpty(txtPlayerName3.Text))
                {
                    names.Add(txtPlayerName3.Text);
                    lblPlayerName3.Text = txtPlayerName3.Text;
                }

                if (!string.IsNullOrEmpty(txtPlayerName4.Text))
                {
                    names.Add(txtPlayerName4.Text);
                    lblPlayerName4.Text = txtPlayerName4.Text;
                }
                ClearHandLabels();
                btnDrawCard.Enabled = false;
                btnNewHand.Enabled = true;
                lblWinner.Visible = false;
                ClearPlayerCardsFromTable();
                ClearDealerCardsFromTable();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                #region Code to test cards
                var card = new Card(TexasHoldem.Library.Enums.Values.Eight, TexasHoldem.Library.Enums.Suits.Diamonds);


                //_playerCardLabels.Add(CreateCard(_playerLblPos[0].X, _playerLblPos[0].Y, card));
                //this.Controls.Add(this._playerCardLabels[0]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[1].X, _playerLblPos[1].Y, card));
                //this.Controls.Add(this._playerCardLabels[1]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[2].X, _playerLblPos[2].Y, card));
                //this.Controls.Add(this._playerCardLabels[2]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[3].X, _playerLblPos[3].Y, card));
                //this.Controls.Add(this._playerCardLabels[3]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[4].X, _playerLblPos[4].Y, card));
                //this.Controls.Add(this._playerCardLabels[4]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[5].X, _playerLblPos[5].Y, card));
                //this.Controls.Add(this._playerCardLabels[5]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[6].X, _playerLblPos[6].Y, card));
                //this.Controls.Add(this._playerCardLabels[6]);
                //_playerCardLabels.Add(CreateCard(_playerLblPos[7].X, _playerLblPos[7].Y, card));
                //this.Controls.Add(this._playerCardLabels[7]);

                //_dealerCardLabels.Add(CreateCard(_dealerLblPos[0].X, _dealerLblPos[0].Y, card));
                //this.Controls.Add(this._dealerCardLabels[0]);
                //_dealerCardLabels.Add(CreateCard(_dealerLblPos[1].X, _dealerLblPos[1].Y, card));
                //this.Controls.Add(this._dealerCardLabels[1]);
                //_dealerCardLabels.Add(CreateCard(_dealerLblPos[2].X, _dealerLblPos[2].Y, card));
                //this.Controls.Add(this._dealerCardLabels[2]);
                //_dealerCardLabels.Add(CreateCard(_dealerLblPos[3].X, _dealerLblPos[3].Y, card));
                //this.Controls.Add(this._dealerCardLabels[3]);
                //_dealerCardLabels.Add(CreateCard(_dealerLblPos[4].X, _dealerLblPos[4].Y, card));
                //this.Controls.Add(this._dealerCardLabels[4]);
                #endregion
                var player = new Player("PlayerOne");
                player.RecieveCard(card, true);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch { }
            #region Test to draw randome card
            //var deck = new Deck();
            //deck.ShuffleDeck(2);
            //deck.DrawCard();
            #endregion
        }
    }
}
