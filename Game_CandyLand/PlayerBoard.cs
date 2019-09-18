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
            //set up locations for where each color is on the board
            int[] GreenLocations = new int[21] {6,13,19,26,32,38,45,51,57,63,70,76,82,88,95,101,107,114,120,126,132};
            int[] OrangeLocations = new int[21] {5,12,18,25,31,37,44,50,56,62,68,75,81,87,94,100,106,113,119,125,131};
            int[] BlueLocations = new int[21] { 4, 11, 17, 24, 30, 36, 43, 49, 55, 61, 67, 74, 80, 86, 93, 99, 105, 112, 118, 124, 130 };
            int[] YellowLocations = new int[21] {3,10,16,23,29,35,41,48,54,60,66,73,79,85,91,98,105,111,117,123,129};
            int[] PurpleLocations = new int[21] { 2, 8, 15, 22, 28, 34, 40, 47, 53, 59, 65, 72, 78, 84, 90, 97, 104, 110, 116, 122, 128 };
            int[] RedLocations = new int[22] {1,7,14,21,27,33,39,46,52,58,64,71,77,83,89,96,103,109,115,121,127,133};
            int[] SpecialLocations = new int[6] {9,20,42,69,92,102};            

            //create the board and initialize it
            Board PlayBoard = new Board();
            PlayBoard.Round = 1;
            PlayBoard.Leader = 1;
            PlayBoard.CurrentPlayer = 1;
            PlayBoard.NumberOfPlayers = 1;

            //set up 134 board locations in the locations array
            for (int i = 0; i < PlayBoard.Locations.Length; i++)
            {
                PlayBoard.Locations[i] = i;
            }

            //set up the x and y locations for each location by adding it to the correct array LONG
            //Any way to improve below code?
            PlayBoard.LocationsX[0] = 0;
            PlayBoard.LocationsY[0] = 0;

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

            PlayBoard.LocationsX[37] = 930;
            PlayBoard.LocationsY[37] = 668;

            PlayBoard.LocationsX[38] = 969;
            PlayBoard.LocationsY[38] = 646;

            PlayBoard.LocationsX[39] = 992;
            PlayBoard.LocationsY[39] = 611;

            PlayBoard.LocationsX[40] = 995;
            PlayBoard.LocationsY[40] = 564;

            PlayBoard.LocationsX[41] = 979;
            PlayBoard.LocationsY[41] = 524;

            PlayBoard.LocationsX[42] = 941;
            PlayBoard.LocationsY[42] = 499;//SPECIAL

            PlayBoard.LocationsX[43] = 891;
            PlayBoard.LocationsY[43] = 503;

            PlayBoard.LocationsX[44] = 850;
            PlayBoard.LocationsY[44] = 516;

            PlayBoard.LocationsX[45] = 806;
            PlayBoard.LocationsY[45] = 532;//RECIEVES FROM 35

            PlayBoard.LocationsX[46] = 760;
            PlayBoard.LocationsY[46] = 527;//STUCK

            PlayBoard.LocationsX[47] = 718;
            PlayBoard.LocationsY[47] = 508;

            PlayBoard.LocationsX[48] = 681;
            PlayBoard.LocationsY[48] = 484;

            PlayBoard.LocationsX[49] = 640;
            PlayBoard.LocationsY[49] = 457;

            PlayBoard.LocationsX[50] = 598;
            PlayBoard.LocationsY[50] = 442;

            PlayBoard.LocationsX[51] = 552;
            PlayBoard.LocationsY[51] = 435;

            PlayBoard.LocationsX[52] = 504;
            PlayBoard.LocationsY[52] = 441;

            PlayBoard.LocationsX[53] = 462;
            PlayBoard.LocationsY[53] = 456;

            PlayBoard.LocationsX[54] = 422;
            PlayBoard.LocationsY[54] = 481;

            PlayBoard.LocationsX[55] = 392;
            PlayBoard.LocationsY[55] = 514;

            PlayBoard.LocationsX[56] = 362;
            PlayBoard.LocationsY[56] = 550;

            PlayBoard.LocationsX[57] = 335;
            PlayBoard.LocationsY[57] = 587;

            PlayBoard.LocationsX[58] = 305;
            PlayBoard.LocationsY[58] = 617;

            PlayBoard.LocationsX[59] = 268;
            PlayBoard.LocationsY[59] = 642;//RECIEVE FROM 5

            PlayBoard.LocationsX[60] = 228;
            PlayBoard.LocationsY[60] = 653;

            PlayBoard.LocationsX[61] = 186;
            PlayBoard.LocationsY[61] = 656;

            PlayBoard.LocationsX[62] = 142;
            PlayBoard.LocationsY[62] = 648;

            PlayBoard.LocationsX[63] = 102;
            PlayBoard.LocationsY[63] = 636;

            PlayBoard.LocationsX[64] = 67;
            PlayBoard.LocationsY[64] = 609;

            PlayBoard.LocationsX[65] = 51;
            PlayBoard.LocationsY[65] = 569;

            PlayBoard.LocationsX[66] = 44;
            PlayBoard.LocationsY[66] = 522;

            PlayBoard.LocationsX[67] = 69;
            PlayBoard.LocationsY[67] = 488;

            PlayBoard.LocationsX[68] = 109;
            PlayBoard.LocationsY[68] = 473;

            PlayBoard.LocationsX[69] = 152;
            PlayBoard.LocationsY[69] = 476;//SPECIAL

            PlayBoard.LocationsX[70] = 192;
            PlayBoard.LocationsY[70] = 489;

            PlayBoard.LocationsX[71] = 235;
            PlayBoard.LocationsY[71] = 504;

            PlayBoard.LocationsX[72] = 281;
            PlayBoard.LocationsY[72] = 508;

            PlayBoard.LocationsX[73] = 319;
            PlayBoard.LocationsY[73] = 494;

            PlayBoard.LocationsX[74] = 326;
            PlayBoard.LocationsY[74] = 449;

            PlayBoard.LocationsX[75] = 297;
            PlayBoard.LocationsY[75] = 413;

            PlayBoard.LocationsX[76] = 258;
            PlayBoard.LocationsY[76] = 392;

            PlayBoard.LocationsX[77] = 225;
            PlayBoard.LocationsY[77] = 361;

            PlayBoard.LocationsX[78] = 230;
            PlayBoard.LocationsY[78] = 311;

            PlayBoard.LocationsX[79] = 262;
            PlayBoard.LocationsY[79] = 283;

            PlayBoard.LocationsX[80] = 308;
            PlayBoard.LocationsY[80] = 270;

            PlayBoard.LocationsX[81] = 352;
            PlayBoard.LocationsY[81] = 273;

            PlayBoard.LocationsX[82] = 394;
            PlayBoard.LocationsY[82] = 281;

            PlayBoard.LocationsX[83] = 438;
            PlayBoard.LocationsY[83] = 202;

            PlayBoard.LocationsX[84] = 479;
            PlayBoard.LocationsY[84] = 324;

            PlayBoard.LocationsX[85] = 521;
            PlayBoard.LocationsY[85] = 347;

            PlayBoard.LocationsX[86] = 561;
            PlayBoard.LocationsY[86] = 370;//STUCK

            PlayBoard.LocationsX[87] = 605;
            PlayBoard.LocationsY[87] = 386;

            PlayBoard.LocationsX[88] = 649;
            PlayBoard.LocationsY[88] = 400;

            PlayBoard.LocationsX[89] = 695;
            PlayBoard.LocationsY[89] = 411;

            PlayBoard.LocationsX[90] = 741;
            PlayBoard.LocationsY[90] = 417;

            PlayBoard.LocationsX[91] = 788;
            PlayBoard.LocationsY[91] = 425;

            PlayBoard.LocationsX[92] = 835;
            PlayBoard.LocationsY[92] = 426;//SPECIAL magnifying glass

            PlayBoard.LocationsX[93] = 882;
            PlayBoard.LocationsY[93] = 426;

            PlayBoard.LocationsX[94] = 926;
            PlayBoard.LocationsY[94] = 413;

            PlayBoard.LocationsX[95] = 968;
            PlayBoard.LocationsY[95] = 397;

            PlayBoard.LocationsX[96] = 996;
            PlayBoard.LocationsY[96] = 363;

            PlayBoard.LocationsX[97] = 1005;
            PlayBoard.LocationsY[97] = 316;

            PlayBoard.LocationsX[98] = 992;
            PlayBoard.LocationsY[98] = 273;

            PlayBoard.LocationsX[99] = 956;
            PlayBoard.LocationsY[99] = 247;

            PlayBoard.LocationsX[100] = 919;
            PlayBoard.LocationsY[100] = 221;

            PlayBoard.LocationsX[101] = 903;
            PlayBoard.LocationsY[101] = 177;

            PlayBoard.LocationsX[102] = 882;
            PlayBoard.LocationsY[102] = 137;//SPECIAL ice cream

            PlayBoard.LocationsX[103] = 841;
            PlayBoard.LocationsY[103] = 117;

            PlayBoard.LocationsX[104] = 794;
            PlayBoard.LocationsY[104] = 131;

            PlayBoard.LocationsX[105] = 763;
            PlayBoard.LocationsY[105] = 163;

            PlayBoard.LocationsX[106] = 743;
            PlayBoard.LocationsY[106] = 208;

            PlayBoard.LocationsX[107] = 722;
            PlayBoard.LocationsY[107] = 248;

            PlayBoard.LocationsX[108] = 695;
            PlayBoard.LocationsY[108] = 285;

            PlayBoard.LocationsX[109] = 657;
            PlayBoard.LocationsY[109] = 312;

            PlayBoard.LocationsX[110] = 609;
            PlayBoard.LocationsY[110] = 318;

            PlayBoard.LocationsX[111] = 565;
            PlayBoard.LocationsY[111] = 302;

            PlayBoard.LocationsX[112] = 526;
            PlayBoard.LocationsY[112] = 282;

            PlayBoard.LocationsX[113] = 486;
            PlayBoard.LocationsY[113] = 255;

            PlayBoard.LocationsX[114] = 448;
            PlayBoard.LocationsY[114] = 230;

            PlayBoard.LocationsX[115] = 404;
            PlayBoard.LocationsY[115] = 216;

            PlayBoard.LocationsX[116] = 357;
            PlayBoard.LocationsY[116] = 209;

            PlayBoard.LocationsX[117] = 312;
            PlayBoard.LocationsY[117] = 213;

            PlayBoard.LocationsX[118] = 267;
            PlayBoard.LocationsY[118] = 221;

            PlayBoard.LocationsX[119] = 223;
            PlayBoard.LocationsY[119] = 225;

            PlayBoard.LocationsX[120] = 179;
            PlayBoard.LocationsY[120] = 225;

            PlayBoard.LocationsX[121] = 138;
            PlayBoard.LocationsY[121] = 218;

            PlayBoard.LocationsX[122] = 102;
            PlayBoard.LocationsY[122] = 198;

            PlayBoard.LocationsX[123] = 81;
            PlayBoard.LocationsY[123] = 164;

            PlayBoard.LocationsX[124] = 77;
            PlayBoard.LocationsY[124] = 114;

            PlayBoard.LocationsX[125] = 90;
            PlayBoard.LocationsY[125] = 72;

            PlayBoard.LocationsX[126] = 125;
            PlayBoard.LocationsY[126] = 44;

            PlayBoard.LocationsX[127] = 167;
            PlayBoard.LocationsY[127] = 25;

            PlayBoard.LocationsX[128] = 211;
            PlayBoard.LocationsY[128] = 24;

            PlayBoard.LocationsX[129] = 253;
            PlayBoard.LocationsY[129] = 33;

            PlayBoard.LocationsX[130] = 291;
            PlayBoard.LocationsY[130] = 56;

            PlayBoard.LocationsX[131] = 327;
            PlayBoard.LocationsY[131] = 82;

            PlayBoard.LocationsX[132] = 363;
            PlayBoard.LocationsY[132] = 109;

            PlayBoard.LocationsX[133] = 403;
            PlayBoard.LocationsY[133] = 127;

            PlayBoard.LocationsX[134] = 448;
            PlayBoard.LocationsY[134] = 147;
            // End of plotting out points in array

            //fill the locationcolor array with the correct color
            // this will make location[1] = locationcolor[1]. EX) Location[1] = LocationColor[1], where LocationColor[1] = "Red"
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
            //add the special locations to the array
            PlayBoard.LocationsColor[9] = "GingerbreadMan";
            PlayBoard.LocationsColor[20] = "Candy Cane";
            PlayBoard.LocationsColor[42] = "Gumdrop";
            PlayBoard.LocationsColor[69] = "Peanut Brittle";
            PlayBoard.LocationsColor[92] = "Ice Cream";
            PlayBoard.LocationsColor[102] = "Lolly";
            PlayBoard.LocationsColor[133] = "Red";
            PlayBoard.LocationsColor[134] = "Finish";
            
            //testing the movement on some random locations
            outputlog_lbl.Text = "Arrays initialized...";
            label3.Location = new Point(62,713);
            label4.Location = new Point(147,801);
            label2.Location = new Point(147,713);
            label1.Location = new Point(62,801);
            outputlog_lbl.Text = "Players moved...";

        }

        //close and exit the game
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult Closeform = MessageBox.Show("Are you sure you want to exit? All progress will be lost.","Exit CandyLand?", MessageBoxButtons.YesNo);
            if (Closeform == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {
            Deck CardDeck = new Deck();
            CardDeck.Draw();
        }

    }
}
