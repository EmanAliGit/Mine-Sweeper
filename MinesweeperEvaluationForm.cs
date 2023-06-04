using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{ enum player {player1,player2 };
    public partial class MinesweeperForm : Form
    {
        int Dim=0;
        Cell[,] Cs;
        int NOM; int FlagC=0;
        int S1 = 0;
        int S2 = 0;
        bool smileclick = false;
        player turn = player.player1;

        public MinesweeperForm()
        {
            InitializeComponent();
        }

        private void MinesweeperForm_Load(object sender, EventArgs e)
        {

        }
        
        private void Expert_CheckedChanged(object sender, EventArgs e)
        {

        }
   private void LoadCells(Color color)
        {
            Cs = new Cell[Dim, Dim];
            int H =( (Board.Height)/ Dim)-7;
            int W =( (Board.Width) / Dim)-7;
            for(int r=0;r<Dim;r++)
            {
                for(int c=0;c<Dim;c++)
                {
                    Cell C = new Cell(r, c, H, W);
                    Board.Controls.Add(C);
                    C.BackColor=color;
                    Cs[r, c] = C;
                    C.Click += new System.EventHandler(this.Cell_Click);
                    //C.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
                   
                }
            }
            InitMine();
        }
        private void InitMine()
        {
            Random R = new Random();
            for (int mi=1;mi<=NOM;mi++)
            {
                int ri = R.Next(Dim);
                int ci = R.Next(Dim);
                if(Cs[ri,ci].getnum()==-1)
                {
                    mi--;
                    continue;
                }
                Cs[ri, ci].SetNum(-1);
                //Cs[ri, ci].Text = Cs[ri, ci].getnum().ToString();
            }
            for(int ri=0;ri<Dim;ri++)
            {
                for(int ci=0;ci<Dim;ci++)
                {
                    if(Cs[ri,ci].getnum()==-1)
                    {
                        continue;
                    }
                    int MC = WindowCount(ri, ci);
                    Cs[ri, ci].SetNum (MC);
                   
                    //Cs[ri, ci].Text = Cs[ri, ci].getnum().ToString();
                }
            }
        }
        void changeturn()
        {
            
          if(turn==player.player1)
            {
                turn = player.player2;
            }
          else if(turn==player.player2)
            {
                turn = player.player1;
            }
        }
        int WindowCount(int ri,int ci)
        {
            int count = 0;
            for(int r=ri-1;r<=ri+1;r++)
            {
                for(int c=ci-1;c<=ci+1;c++)
                {
                    if((r==ri &&c==ci)||r<0||c<0||r>=Dim||c>=Dim)
                    {
                        continue;
                    }
                    if(Cs[r,c].getnum()==-1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void SmileStart_Click(object sender, EventArgs e)
        {
            SmileStart.BackgroundImage = Properties.Resources.SmileMode;
            SmileStart.BackgroundImageLayout = ImageLayout.Stretch;
            smileclick = true;
    if(Easy.Checked)
            {
                Dim = 9;
                NOM = 10;
            }
    if(Hard.Checked)
            {
                Dim = 12;
                NOM = 15;
            }
    if(Expert.Checked)
            {
                Dim = 16;
                NOM = 25;
            }
    if(Dim==0)
            {
                MessageBox.Show("Select Level");
                return;
            }
          
            LoadCells(Color.Yellow);
        }
       void Explore(int ri,int ci)
        {
            if (turn == player.player1)
            {
            
                if (Cs[ri, ci].IsOpen == true)
                {
                    return;
                }
                Cs[ri, ci].IsOpen = true;
                
                Cs[ri, ci].BackColor = Color.Green;
                for (int r = ri - 1; r <= ri + 1; r++)
                {
                    for (int c = ci - 1; c <= ci + 1; c++)
                    {
                        if (r < 0 || c < 0 || r >= Dim || c >= Dim)
                        {
                            continue;
                        }
                        if (Cs[r, c].IsOpen == false)
                        {

                            if ((Cs[r, c].getnum() != 0) && (Cs[r, c].getnum() != -1))
                            {

                                Cs[r, c].Text = Cs[r, c].getnum().ToString();
                                Cs[r, c].IsOpen = true;
                            }
                            else if (Cs[r, c].getnum() == 0)
                            {
                                Cs[r, c].BackColor = Color.Green;
                               
                                Explore(r, c);
                            }
                        }
                    }
                }
            }
            else if(turn==player.player2)
            {
               
                if (Cs[ri, ci].IsOpen == true)
                {
                    return;
                }
                Cs[ri, ci].IsOpen = true;
                S2= Int32.Parse(score1.Text);
                S2 += 10;
                score2.Text = S2.ToString();
                Cs[ri, ci].BackColor = Color.Red;
                for (int r = ri - 1; r <= ri + 1; r++)
                {
                    for (int c = ci - 1; c <= ci + 1; c++)
                    {
                        if (r < 0 || c < 0 || r >= Dim || c >= Dim)
                        {
                            continue;
                        }
                        if (Cs[r, c].IsOpen == false)
                        {

                            if ((Cs[r, c].getnum() != 0) && (Cs[r, c].getnum() != -1))
                            {

                                Cs[r, c].Text = Cs[r, c].getnum().ToString();
                                Cs[r, c].IsOpen = true;
                            }
                            else if (Cs[r, c].getnum() == 0)
                            {
                                Cs[r, c].BackColor = Color.Red;
                              
                                Explore(r, c);
                            }
                        }
                    }
                }
            }
        }
        bool endcheck()
        {
            for(int i=0;i<Dim;i++)
            {
                for(int c=0;c<Dim;c++)
                {
                    if(Cs[i,c].IsOpen==false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void Cell_Click(object sender, EventArgs e)
        {

            Cell C = (Cell)sender;

            if (smileclick)
            {
                if (turn == player.player1)
                {
                  
                    if (C.flag == true)
                    {
                        return;
                    }
                    if (C.IsOpen == true)
                    {
                        return;
                    }
                    if (C.getnum() == -1)
                    {
                        //for (int ri = 0; ri < Dim; ri++)
                        //{
                        //    for (int ci = 0; ci < Dim; ci++)
                        //    {
                        //        if (Cs[ri, ci].getnum() == -1)
                        //        {
                        //            Cs[ri, ci].BackgroundImage = Properties.Resources.mine;
                        //            Cs[ri, ci].BackgroundImageLayout = ImageLayout.Stretch;
                        //        }
                        //        else
                        //        {
                        //            continue;
                        //        }
                        //    }
                        //}
                        //SmileStart.BackgroundImage = Properties.Resources.Smilelost;
                        //C.BackgroundImageLayout = ImageLayout.Stretch;
                        //MessageBox.Show("You Lost");

                        //smileclick = false;
                        //Board.Controls.Clear();
                        if (Int32.Parse(score1.Text) < 10)
                        {
                            S1 = 0;
                            score1.Text = S1.ToString();
                            C.BackgroundImage = Properties.Resources.mine;
                            C.BackgroundImageLayout = ImageLayout.Stretch;
                            return;
                        }
                        S1 += -10;
                        score1.Text = S1.ToString();
                        C.BackgroundImage = Properties.Resources.mine;
                        C.BackgroundImageLayout = ImageLayout.Stretch;

                    }
                    if (C.getnum()> 0)
                    {
                        S1= Int32.Parse(score1.Text);
                        S1+= C.getnum();
                        score1.Text = S1.ToString();
                        C.Text = C.getnum().ToString();
                    }
                    else if (C.getnum() == 0)
                    {
                        S1 = Int32.Parse(score1.Text);
                        S1 += 10;
                        score1.Text = S1.ToString();
                        Explore(C.ci, C.ri);
                    }
                    if (endcheck())
                    {
                        if (Int32.Parse(score1.Text) > Int32.Parse(score2.Text))
                        {
                            MessageBox.Show("Player1 Won!");

                        }
                        else if (Int32.Parse(score1.Text) < Int32.Parse(score2.Text))
                        {
                            MessageBox.Show("Player2 Won!");
                        }
                        else
                        {
                            MessageBox.Show("Draw!");
                        }
                        smileclick = false;
                        Board.Controls.Clear();

                    }
                    changeturn();
                    return;
            }
                    if (turn == player.player2)
                    {
                        
                        if (C.flag == true)
                        {
                            return;
                        }
                        if (C.IsOpen == true)
                        {
                            return;
                        }
                    if (C.getnum() == -1)
                    {
                        //for (int ri = 0; ri < Dim; ri++)
                        //{
                        //    for (int ci = 0; ci < Dim; ci++)
                        //    {
                        //        if (Cs[ri, ci].getnum() == -1)
                        //        {
                        //            Cs[ri, ci].BackgroundImage = Properties.Resources.mine;
                        //            Cs[ri, ci].BackgroundImageLayout = ImageLayout.Stretch;
                        //        }
                        //        else
                        //        {
                        //            continue;
                        //        }
                        //    }
                        //}
                        //SmileStart.BackgroundImage = Properties.Resources.Smilelost;
                        //C.BackgroundImageLayout = ImageLayout.Stretch;
                        //MessageBox.Show("You Lost");

                        //smileclick = false;
                        //Board.Controls.Clear();
                        if (Int32.Parse(score2.Text) < 10)
                        {
                            S2 = 0;
                            score2.Text = S2.ToString();
                            C.BackgroundImage = Properties.Resources.mine;
                            C.BackgroundImageLayout = ImageLayout.Stretch;
                            return;
                        }
                        S2 = Int32.Parse(score2.Text);
                        S2 += -10;
                        score2.Text = S2.ToString();
                        C.Text = C.getnum().ToString();
                        C.BackgroundImage = Properties.Resources.mine;
                        C.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                            if (C.getnum() >0)
                            {
                                S2 += C.getnum();
                                score2.Text = S2.ToString();
                                C.Text = C.getnum().ToString();
                            }
                            else if (C.getnum() == 0)
                            {
                        S2 = Int32.Parse(score2.Text);
                        S2 += 10;
                        score2.Text = S2.ToString();
                        Explore(C.ci, C.ri);
                            }
                            if (endcheck())
                            {
                                if (Int32.Parse(score1.Text) > Int32.Parse(score2.Text))
                                {
                                    MessageBox.Show("Player1 Won!");

                                }
                                else if (Int32.Parse(score1.Text) < Int32.Parse(score2.Text))
                                {
                                    MessageBox.Show("Player2 Won!");
                                }
                                else
                                {
                                    MessageBox.Show("Draw!");
                                }
                                smileclick = false;
                                Board.Controls.Clear();
                               
                            }
                            changeturn();
                    return;
                   
                        }
                    }


                
            }
        
       

        
        private bool checkwin()
        {
            bool Iswin = true;
          
            if (smileclick == true)
            {
                for (int ri = 0; ri < Dim; ri++)
                {
                    for (int ci = 0; ci < Dim; ci++)
                    {
                        if ((Cs[ri, ci].getnum() == -1) && (Cs[ri, ci].BackgroundImage != Properties.Resources.flag))
                        {
                            Iswin = false;
                            return Iswin;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            return Iswin;
        }
        //private void Board_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Cell C = (Cell)sender;

        //    if (e.Button.Equals(MouseButtons.Right))
        //    {
        //        if (smileclick==true)
        //        {
        //            if (C.flag == false)
        //            {
        //                FlagC++;
        //                this.FlagCount.Text = FlagC.ToString();
        //                if (FlagC==NOM)
        //                {
        //                  if(  checkwin())
        //                    {
        //                        SmileStart.BackgroundImage = Properties.Resources.smileWin;
        //                        C.BackgroundImageLayout = ImageLayout.Stretch;
        //                        MessageBox.Show("You Won!");

        //                    }
        //                }
        //                C.BackgroundImage = Properties.Resources.flag;
        //                C.BackgroundImageLayout = ImageLayout.Stretch;
        //                C.flag = true;
        //                return;
        //            }
        //            else
        //            {
        //                FlagC--;
        //                this.FlagCount.Text = FlagC.ToString();
        //                C.BackgroundImage = Properties.Resources.yellow;
        //                C.BackgroundImageLayout = ImageLayout.Stretch;
        //                C.flag = false;

        //            }
        //        }
        //    }
        //    return;
        //}

        private void Flags_Click(object sender, EventArgs e)
        {

        }

       
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Score2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
