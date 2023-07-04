#region usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace sodoko_winform3
{
    public partial class Form1 : Form
    {
        #region gelobalArray
     
        TextBox[,] Tarray = new TextBox[9, 9];
        #endregion

        #region iSEmpty
       
        private bool isEmpty(TextBox[,]Tarray,int row,int col)
        {
            bool isEmptyCell = false;            
            if (Tarray[row, col].Text == "")
            {
               isEmptyCell = true;
               Tarray[row, col].BackColor = Color.Red;
            }
            return isEmptyCell;
           
        }
        #endregion

        #region Solve_sodoko
        private bool solveSodoko(TextBox[,] Tarray)
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (isEmpty(Tarray, i, j)) 
                    {
                        for (int num = 1; num <= 9; num++) 
                        {
                            if (isValid(num, Tarray, i, j)) 
                            {
                                Tarray[i, j].Text = num.ToString(); 
                                Tarray[i, j].BackColor = Color.Green;
                                Tarray[i, j].ReadOnly = true;
                                if (solveSodoko(Tarray)) 
                                {
                                    return true;
                                }
                                else 
                                {
                                    Tarray[i, j].Text = "";
                                }
                            }
                        }
                        Tarray[i, j].BackColor = Color.White;
                        return false; 
                    }
                }
            }
            return true; 
        }
        #endregion 

        #region isValid
        private bool isValid(int num, TextBox[,] Tarray,int row,int col)
        {
       
                for (int k =0; k <= 8; k++)
                {
                    if (Tarray[row, k].Text == num.ToString() || Tarray[k, col].Text == num.ToString())
                    {
                    return false;
                    }
                }
               int blockRow = row - (row % 3);
               int blockCol = col - (col % 3);
               for (int i = blockRow; i < blockRow + 3; i++)
               {
                     for (int j = blockCol; j < blockCol + 3; j++)
                     {
                       if (Tarray[i, j].Text == num.ToString())
                       {
                        return false;
                       }
                     }
               }
            return true;      
        }
        #endregion

        #region Form
        
        public Form1()
        {
            InitializeComponent();
        }


        #region form_load
             private void Form1_Load(object sender, EventArgs e)
        {
            int txtWidth = 30;
            int txtHeight = 32;
            int spcasing = 5;
            int startX = 30;
            int startY = 30;

            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    Tarray[i, j] = new TextBox
                    {
                        Location = new Point(startX + j * (txtWidth + spcasing), startY + i * (txtHeight + spcasing)),

                        Multiline = true,
                        TextAlign = HorizontalAlignment.Center,
                        Size = new Size(txtWidth, txtHeight),
                        Parent = this,
                        Font = new Font("Times New Roman", 16, FontStyle.Bold)
                    };
                }
            }
        }
        #endregion

        #region a
        private void button1_Click(object sender, EventArgs e)
        { }
        #endregion
        private void btn_sovle_Click(object sender, EventArgs e)
        {
            if(solveSodoko(Tarray))
            {
                MessageBox.Show("سودوکو حل شد");
            }
        }
    }
    #endregion
}
