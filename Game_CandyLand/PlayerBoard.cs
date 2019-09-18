//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Triple B & Schulze">
//     Copyright (c) Biles & Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Game_CandyLand
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class PlayerBoard : Form
    {
        public PlayerBoard()
        {
            InitializeComponent();
            outputlog_lbl.Text = "Singleplayer...";

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            //set up locations for where each color is
            int[] GreenLocations = new int[21] {6,13,19,26,32,38,45,51,57,63,70,76,82,88,95,101,107,114,120,126,132};
            int[] OrangeLocations = new int[21] {5,12,18,25,31,37,44,50,56,62,68,75,81,87,94,100,106,113,119,125,131};
            int[] BlueLocations = new int[21] { 4, 11, 17, 24, 30, 36, 43, 49, 55, 61, 67, 74, 80, 86, 93, 99, 105, 112, 118, 124, 130 };
            int[] YellowLocations = new int[21] {3,10,16,23,29,35,41,48,54,60,66,73,79,85,91,98,105,111,117,123,129};
            int[] PurpleLocations = new int[21] { 2, 8, 15, 22, 28, 34, 40, 47, 53, 59, 65, 72, 78, 84, 90, 97, 104, 110, 116, 122, 128 };
            int[] RedLocations = new int[22] {1,7,14,21,27,33,39,46,52,58,64,71,77,83,89,96,103,109,115,121,127,133};
            int[] SpecialLocations = new int[6] {9,20,42,69,92,102};            

            //create the board and initialize it
            Board PlayBoard = new Board();

            //set up 134 board locations
            for (int i = 0; i < PlayBoard.Locations.Length; i++)
            {
                PlayBoard.Locations[i] = i;
            }

            //set up the x and y locations for each location by adding it to the correct array
            PlayBoard.LocationsX[0] = 62;
            PlayBoard.LocationsY[0] = 713;

            PlayBoard.LocationsX[1] = 211;
            PlayBoard.LocationsY[1] = 814;

            PlayBoard.LocationsX[2] = 262;
            PlayBoard.LocationsY[2] = 816;

            PlayBoard.LocationsX[3] = 297;
            PlayBoard.LocationsY[3] = 801;

            PlayBoard.LocationsX[4] = 321;
            PlayBoard.LocationsY[4] = 770;

            PlayBoard.LocationsX[5] = 340;
            PlayBoard.LocationsY[5] = 733;

            PlayBoard.LocationsX[6] = 372;
            PlayBoard.LocationsY[6] = 702;

            PlayBoard.LocationsX[7] = 416;
            PlayBoard.LocationsY[7] = 686;

            PlayBoard.LocationsX[8] = 459;
            PlayBoard.LocationsY[8] = 684;

            PlayBoard.LocationsX[9] = 509;
            PlayBoard.LocationsY[9] = 689;

            PlayBoard.LocationsX[10] = 549;
            PlayBoard.LocationsY[10] = 704;

            PlayBoard.LocationsX[11] = 585;
            PlayBoard.LocationsY[11] = 733;

            PlayBoard.LocationsX[12] = 613;
            PlayBoard.LocationsY[12] = 767;

            PlayBoard.LocationsX[13] = 647;
            PlayBoard.LocationsY[13] = 792;

            PlayBoard.LocationsX[14] = 685;
            PlayBoard.LocationsY[14] = 820;

            PlayBoard.LocationsX[15] = 729;
            PlayBoard.LocationsY[15] = 830;

            PlayBoard.LocationsX[16] = 772;
            PlayBoard.LocationsY[16] = 835;

            PlayBoard.LocationsX[17] = 817;
            PlayBoard.LocationsY[17] = 834;

            PlayBoard.LocationsX[18] = 864;
            PlayBoard.LocationsY[18] = 830;

            PlayBoard.LocationsX[19] = 901;
            PlayBoard.LocationsY[19] = 811;

            PlayBoard.LocationsX[20] = 916;
            PlayBoard.LocationsY[20] = 767;

            PlayBoard.LocationsX[21] = 893;
            PlayBoard.LocationsY[21] = 732;

            PlayBoard.LocationsX[22] = 853;
            PlayBoard.LocationsY[22] = 713;

            PlayBoard.LocationsX[23] = 806;
            PlayBoard.LocationsY[23] = 713;

            PlayBoard.LocationsX[24] = 761;
            PlayBoard.LocationsY[24] = 713;

            PlayBoard.LocationsX[25] = 714;
            PlayBoard.LocationsY[25] = 713;

            PlayBoard.LocationsX[26] = 668;
            PlayBoard.LocationsY[26] = 713;

            PlayBoard.LocationsX[27] = 628;
            PlayBoard.LocationsY[27] = 694;

            PlayBoard.LocationsX[28] = 599;
            PlayBoard.LocationsY[28] = 659;

            PlayBoard.LocationsX[29] = 594;
            PlayBoard.LocationsY[29] = 613;

            PlayBoard.LocationsX[30] = 626;
            PlayBoard.LocationsY[30] = 584;

            PlayBoard.LocationsX[31] = 673;
            PlayBoard.LocationsY[31] = 582;

            PlayBoard.LocationsX[32] = 717;
            PlayBoard.LocationsY[32] = 596;

            PlayBoard.LocationsX[33] = 759;
            PlayBoard.LocationsY[33] = 622;

            PlayBoard.LocationsX[34] = 800;
            PlayBoard.LocationsY[34] = 643;

            PlayBoard.LocationsX[35] = 840;
            PlayBoard.LocationsY[35] = 658;

            PlayBoard.LocationsX[36] = 883;
            PlayBoard.LocationsY[36] = 670;

            PlayBoard.LocationsX[37] = 883;
            PlayBoard.LocationsY[37] = 670;

            PlayBoard.LocationsX[38] = 883;
            PlayBoard.LocationsY[38] = 670;

            PlayBoard.LocationsX[39] = 883;
            PlayBoard.LocationsY[39] = 670;

            PlayBoard.LocationsX[40] = 883;
            PlayBoard.LocationsY[40] = 670;

            PlayBoard.LocationsX[41] = 883;
            PlayBoard.LocationsY[41] = 670;

            PlayBoard.LocationsX[42] = 883;
            PlayBoard.LocationsY[42] = 670;

            PlayBoard.LocationsX[43] = 883;
            PlayBoard.LocationsY[43] = 670;

            PlayBoard.LocationsX[44] = 883;
            PlayBoard.LocationsY[44] = 670;

            PlayBoard.LocationsX[45] = 883;
            PlayBoard.LocationsY[45] = 670;

            PlayBoard.LocationsX[46] = 883;
            PlayBoard.LocationsY[46] = 670;

            PlayBoard.LocationsX[47] = 883;
            PlayBoard.LocationsY[47] = 670;

            PlayBoard.LocationsX[48] = 883;
            PlayBoard.LocationsY[48] = 670;

            PlayBoard.LocationsX[49] = 883;
            PlayBoard.LocationsY[49] = 670;

            PlayBoard.LocationsX[50] = 883;
            PlayBoard.LocationsY[50] = 670;

            PlayBoard.LocationsX[51] = 883;
            PlayBoard.LocationsY[51] = 670;

            PlayBoard.LocationsX[52] = 883;
            PlayBoard.LocationsY[52] = 670;

            PlayBoard.LocationsX[53] = 883;
            PlayBoard.LocationsY[53] = 670;

            PlayBoard.LocationsX[54] = 883;
            PlayBoard.LocationsY[54] = 670;

            PlayBoard.LocationsX[55] = 883;
            PlayBoard.LocationsY[55] = 670;

            PlayBoard.LocationsX[56] = 883;
            PlayBoard.LocationsY[56] = 670;

            PlayBoard.LocationsX[57] = 883;
            PlayBoard.LocationsY[57] = 670;

            PlayBoard.LocationsX[58] = 883;
            PlayBoard.LocationsY[58] = 670;

            PlayBoard.LocationsX[59] = 883;
            PlayBoard.LocationsY[59] = 670;

            PlayBoard.LocationsX[60] = 883;
            PlayBoard.LocationsY[60] = 670;

            PlayBoard.LocationsX[61] = 883;
            PlayBoard.LocationsY[61] = 670;

            PlayBoard.LocationsX[62] = 883;
            PlayBoard.LocationsY[62] = 670;

            PlayBoard.LocationsX[63] = 883;
            PlayBoard.LocationsY[63] = 670;

            PlayBoard.LocationsX[64] = 883;
            PlayBoard.LocationsY[64] = 670;

            PlayBoard.LocationsX[65] = 883;
            PlayBoard.LocationsY[65] = 670;

            PlayBoard.LocationsX[66] = 883;
            PlayBoard.LocationsY[66] = 670;

            PlayBoard.LocationsX[67] = 883;
            PlayBoard.LocationsY[67] = 670;

            PlayBoard.LocationsX[68] = 883;
            PlayBoard.LocationsY[68] = 670;

            PlayBoard.LocationsX[69] = 883;
            PlayBoard.LocationsY[69] = 670;

            PlayBoard.LocationsX[70] = 883;
            PlayBoard.LocationsY[70] = 670;

            PlayBoard.LocationsX[71] = 883;
            PlayBoard.LocationsY[71] = 670;

            PlayBoard.LocationsX[72] = 883;
            PlayBoard.LocationsY[72] = 670;

            PlayBoard.LocationsX[73] = 883;
            PlayBoard.LocationsY[73] = 670;

            PlayBoard.LocationsX[74] = 883;
            PlayBoard.LocationsY[74] = 670;

            PlayBoard.LocationsX[75] = 883;
            PlayBoard.LocationsY[75] = 670;

            PlayBoard.LocationsX[76] = 883;
            PlayBoard.LocationsY[76] = 670;

            PlayBoard.LocationsX[77] = 883;
            PlayBoard.LocationsY[77] = 670;

            PlayBoard.LocationsX[78] = 883;
            PlayBoard.LocationsY[78] = 670;

            PlayBoard.LocationsX[79] = 883;
            PlayBoard.LocationsY[79] = 670;

            PlayBoard.LocationsX[80] = 883;
            PlayBoard.LocationsY[80] = 670;

            PlayBoard.LocationsX[80] = 883;
            PlayBoard.LocationsY[80] = 670;

            PlayBoard.LocationsX[81] = 883;
            PlayBoard.LocationsY[81] = 670;

            PlayBoard.LocationsX[82] = 883;
            PlayBoard.LocationsY[82] = 670;

            PlayBoard.LocationsX[83] = 883;
            PlayBoard.LocationsY[83] = 670;

            PlayBoard.LocationsX[84] = 883;
            PlayBoard.LocationsY[84] = 670;

            PlayBoard.LocationsX[85] = 883;
            PlayBoard.LocationsY[85] = 670;

            PlayBoard.LocationsX[86] = 883;
            PlayBoard.LocationsY[86] = 670;

            PlayBoard.LocationsX[87] = 883;
            PlayBoard.LocationsY[87] = 670;

            PlayBoard.LocationsX[88] = 883;
            PlayBoard.LocationsY[88] = 670;

            PlayBoard.LocationsX[89] = 883;
            PlayBoard.LocationsY[89] = 670;

            PlayBoard.LocationsX[90] = 883;
            PlayBoard.LocationsY[90] = 670;

            PlayBoard.LocationsX[91] = 883;
            PlayBoard.LocationsY[91] = 670;

            PlayBoard.LocationsX[92] = 883;
            PlayBoard.LocationsY[92] = 670;

            PlayBoard.LocationsX[93] = 883;
            PlayBoard.LocationsY[93] = 670;

            PlayBoard.LocationsX[94] = 883;
            PlayBoard.LocationsY[94] = 670;

            PlayBoard.LocationsX[95] = 883;
            PlayBoard.LocationsY[95] = 670;

            PlayBoard.LocationsX[96] = 883;
            PlayBoard.LocationsY[96] = 670;

            PlayBoard.LocationsX[97] = 883;
            PlayBoard.LocationsY[97] = 670;

            PlayBoard.LocationsX[98] = 883;
            PlayBoard.LocationsY[98] = 670;

            PlayBoard.LocationsX[99] = 883;
            PlayBoard.LocationsY[99] = 670;

            PlayBoard.LocationsX[100] = 883;
            PlayBoard.LocationsY[100] = 670;

            PlayBoard.LocationsX[101] = 883;
            PlayBoard.LocationsY[101] = 670;

            PlayBoard.LocationsX[102] = 883;
            PlayBoard.LocationsY[102] = 670;

            PlayBoard.LocationsX[103] = 883;
            PlayBoard.LocationsY[103] = 670;

            PlayBoard.LocationsX[104] = 883;
            PlayBoard.LocationsY[104] = 670;

            PlayBoard.LocationsX[105] = 883;
            PlayBoard.LocationsY[105] = 670;

            PlayBoard.LocationsX[106] = 883;
            PlayBoard.LocationsY[106] = 670;

            PlayBoard.LocationsX[107] = 883;
            PlayBoard.LocationsY[107] = 670;

            PlayBoard.LocationsX[108] = 883;
            PlayBoard.LocationsY[108] = 670;

            PlayBoard.LocationsX[109] = 883;
            PlayBoard.LocationsY[109] = 670;

            PlayBoard.LocationsX[110] = 883;
            PlayBoard.LocationsY[110] = 670;

            PlayBoard.LocationsX[111] = 883;
            PlayBoard.LocationsY[111] = 670;

            PlayBoard.LocationsX[112] = 883;
            PlayBoard.LocationsY[112] = 670;

            PlayBoard.LocationsX[113] = 883;
            PlayBoard.LocationsY[113] = 670;

            PlayBoard.LocationsX[114] = 883;
            PlayBoard.LocationsY[114] = 670;

            PlayBoard.LocationsX[115] = 883;
            PlayBoard.LocationsY[115] = 670;

            PlayBoard.LocationsX[116] = 883;
            PlayBoard.LocationsY[116] = 670;

            PlayBoard.LocationsX[117] = 883;
            PlayBoard.LocationsY[117] = 670;

            PlayBoard.LocationsX[118] = 883;
            PlayBoard.LocationsY[118] = 670;

            PlayBoard.LocationsX[119] = 883;
            PlayBoard.LocationsY[119] = 670;

            PlayBoard.LocationsX[120] = 883;
            PlayBoard.LocationsY[120] = 670;

            PlayBoard.LocationsX[121] = 883;
            PlayBoard.LocationsY[121] = 670;

            PlayBoard.LocationsX[122] = 883;
            PlayBoard.LocationsY[122] = 670;

            PlayBoard.LocationsX[123] = 883;
            PlayBoard.LocationsY[123] = 670;

            PlayBoard.LocationsX[124] = 883;
            PlayBoard.LocationsY[124] = 670;

            PlayBoard.LocationsX[125] = 883;
            PlayBoard.LocationsY[125] = 670;

            PlayBoard.LocationsX[126] = 883;
            PlayBoard.LocationsY[126] = 670;

            PlayBoard.LocationsX[127] = 883;
            PlayBoard.LocationsY[127] = 670;

            PlayBoard.LocationsX[128] = 883;
            PlayBoard.LocationsY[128] = 670;

            PlayBoard.LocationsX[129] = 883;
            PlayBoard.LocationsY[129] = 670;

            PlayBoard.LocationsX[130] = 883;
            PlayBoard.LocationsY[130] = 670;

            PlayBoard.LocationsX[131] = 883;
            PlayBoard.LocationsY[131] = 670;

            PlayBoard.LocationsX[132] = 883;
            PlayBoard.LocationsY[132] = 670;

            PlayBoard.LocationsX[133] = 883;
            PlayBoard.LocationsY[133] = 670;

            PlayBoard.LocationsX[134] = 883;
            PlayBoard.LocationsY[134] = 670;
            // End of plotting out points in array

            //fill the locationcolor array
            int colorcounter = 0;
            int j = 1;
            while (colorcounter <= 20)
            {
                while(j <= 133)
                {
                    if (RedLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Red";
                    }
                    else if (PurpleLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Purple";
                    }
                    else if (YellowLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Yellow";
                    }
                    else if (BlueLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Blue";
                    }
                    else if (OrangeLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Orange";
                    }
                    else if (GreenLocations[colorcounter] == j)
                    {
                        PlayBoard.LocationsColor[j] = "Green";
                    }
                    j++;
                }
                j = 0;
                colorcounter++;
            }

            outputlog_lbl.Text = "Arrays initialized...";
            label3.Location = new Point(PlayBoard.LocationsX[35], PlayBoard.LocationsY[35]);
            label1.Location = new Point(PlayBoard.LocationsX[0],PlayBoard.LocationsY[0]);
            label2.Location = new Point(PlayBoard.LocationsX[20],PlayBoard.LocationsY[20]);
            outputlog_lbl.Text = "Players moved...";

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult Closeform = MessageBox.Show("Are you sure you want to exit? All progress will be lost.","Exit CandyLand?", MessageBoxButtons.YesNo);
            if (Closeform == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
