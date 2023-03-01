using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ffgameRedux
{

    


    public class Globals {

        /// INIT VARS

        
        

       

            

        public static int EnemyX = 128;
        public static int EnemyY = 96;
        public static WMPLib.WindowsMediaPlayer MusicPlayer = new WMPLib.WindowsMediaPlayer();
        public static string SongID;
        public static string BossName;

        //Dynamic Game Vals
        public static int Floor;  // put = X for floor + 1, 32 is last floor
        public static int[] Spells = {1,2,0};
        public static int[] BossTech = { 0,1,2,3,4 };
        public static string Rank = "F";

        public static int PlayerTurn = 1;
        public static string [] PartySize = { "0","1" };
        public static int[] CritArray = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99 };

        public static string Player1Name;
        public static string Player2Name;
        public static string Player3Name;
        public static string Player4Name;

        public static int Player1Attack;
        public static int Player2Attack;
        public static int Player3Attack;
        public static int Player4Attack;

        public static int Player1Defense;
        public static int Player2Defense;
        public static int Player3Defense;
        public static int Player4Defense;

        public static int Player1Speed;
        public static int Player2Speed;
        public static int Player3Speed;
        public static int Player4Speed;

        public static int Player1HP;
        public static int Player2HP;
        public static int Player3HP;   
        public static int Player4HP;

        public static int Player1MaxHP;
        public static int Player2MaxHP;
        public static int Player3MaxHP;
        public static int Player4MaxHP;

        public static int Player1MP;
        public static int Player2MP;
        public static int Player3MP;
        public static int Player4MP;

        public static int Player1MaxMP;
        public static int Player2MaxMP;
        public static int Player3MaxMP;
        public static int Player4MaxMP;

        public static bool Player1IsDead = false;
        public static bool Player2IsDead = false;
        public static bool Player3IsDead = true;
        public static bool Player4IsDead = true;

        public static bool Player1InAir = false;
        public static bool Player2InAir = false;
        public static bool Player3InAir = false;
        public static bool Player4InAir = false;

        //Actual Character Stats ff1,3,4,5,7
        public static int OnionAttack = 6;
        public static int WarAttack = 10;
        public static int ThiefAttack = 7;
        public static int CidAttack = 8;
        public static int RydiaAttack = 4;
        public static int EdgarAttack = 9;

        public static int OnionDefense= 3;
        public static int WarDefense= 2;
        public static int ThiefDefense= 1;
        public static int CidDefense= 2;
        public static int RydiaDefense = 1;
        public static int EdgarDefense = 2;

        public static int OnionSpeed= 6;
        public static int WarSpeed= 7;
        public static int ThiefSpeed= 10;
        public static int CidSpeed=9;
        public static int RydiaSpeed = 8;
        public static int EdgarSpeed = 3;

        public static int OnionHP=51;
        public static int WarHP=63;
        public static int ThiefHP=49;
        public static int CidHP=48;
        public static int RydiaHP = 55;
        public static int EdgarHP = 42;

        public static int OnionMaxHP= OnionHP;
        public static int WarMaxHP= WarHP;
        public static int ThiefMaxHP= ThiefHP;
        public static int CidMaxHP= CidHP;
        public static int RydiaMaxHP = RydiaHP;
        public static int EdgarMaxHP = EdgarHP;

        public static int OnionMP=12;
        public static int WarMP=5;
        public static int ThiefMP=3;
        public static int CidMP=4;
        public static int RydiaMP = 27;
        public static int EdgarMP = 7;




        public static int OnionMaxMP = OnionMP;
        public static int WarMaxMP = WarMP;
        public static int ThiefMaxMP = ThiefMP;
        public static int CidMaxMP = CidMP;
        public static int RydiaMaxMP = RydiaMP;
        public static int EdgarMaxMP = EdgarMP;

        //ENemy stuff

        public static int EnemyHP = 41;
        public static int EnemyAttack = 6;
        public static bool BossFight = false;
        public static bool BellyFull = false;

        // Level Up
        public static int[] HPUpPool = { 5, 7, 9, 10, 13, 18, 20 };
        public static int[] StatUpPool = {1,2, 3, 4, 5, 6};

        public static bool mouseDown;
        public static Point lastLocation;



        // PartySelect

        public static bool PartySelectOverride = false;
        public static System.Windows.Forms.Form PartySelectForm = new System.Windows.Forms.Form();
        public static int P1Override = 0;
        public static int P2Override = 0;
        public static int P3Override = 0;
        public static int P4Override = 0;

        public static ListBox P1CharList = new ListBox();
        public static ListBox P2CharList = new ListBox();
        public static ListBox P3CharList = new ListBox();
        public static ListBox P4CharList = new ListBox();

        //joe biden secret input button

        public static bool SummonTheJoe = false;

        public static System.Windows.Forms.Timer DanceAnim = new System.Windows.Forms.Timer();
        public static bool DanceState = false;
    }

    partial class MainForm
    {


        private void InitializeComponent()
        {
            PartySelectwindow();

            #region windowelements

            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player3 = new System.Windows.Forms.PictureBox();
            this.Player4 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Gameweapon = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.SummonWeapon = new System.Windows.Forms.PictureBox();
            this.Player1ActList = new System.Windows.Forms.ListBox();
            this.Player2ActList = new System.Windows.Forms.ListBox();
            this.Player3ActList = new System.Windows.Forms.ListBox();
            this.Player4ActList = new System.Windows.Forms.ListBox();
            this.Player1HPGauge = new System.Windows.Forms.Label();
            this.Player2HPGauge = new System.Windows.Forms.Label();
            this.Player3HPGauge = new System.Windows.Forms.Label();
            this.Player4HPGauge = new System.Windows.Forms.Label();
            this.PartyRank = new System.Windows.Forms.Label();
            this.PartyScore = new System.Windows.Forms.Label();
            this.EngageButton = new System.Windows.Forms.Button();
            this.DMGLabel = new System.Windows.Forms.Label();
            this.StatGraph = new System.Windows.Forms.Label();
            this.SpellWeapon = new System.Windows.Forms.PictureBox();
            this.Player1MPGauge = new System.Windows.Forms.Label();
            this.Player2MPGauge = new System.Windows.Forms.Label();
            this.Player3MPGauge = new System.Windows.Forms.Label();
            this.Player4MPGauge = new System.Windows.Forms.Label();
            this.PlayerBackpack = new System.Windows.Forms.ListBox();
            this.HPBackground = new System.Windows.Forms.PictureBox();
            this.ActListBG = new System.Windows.Forms.PictureBox();
            this.BatBG = new System.Windows.Forms.PictureBox();
            this.InfoBG = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MenuWin = new System.Windows.Forms.Form();

            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
            this.Player1.Location = new System.Drawing.Point(600, 140);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(32, 48);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;

            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Player2.Location = new System.Drawing.Point(630, 200);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(32, 48);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Player3
            // 
            this.Player3.BackColor = System.Drawing.Color.Transparent;
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
            this.Player3.Location = new System.Drawing.Point(660, 260);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(32, 48);
            this.Player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player3.TabIndex = 2;
            this.Player3.TabStop = false;
            this.Player3.Visible = false;
            // 
            // Player4
            // 
            this.Player4.BackColor = System.Drawing.Color.Transparent;
            this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
            this.Player4.Location = new System.Drawing.Point(690, 320);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(32, 48);
            this.Player4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player4.TabIndex = 4;
            this.Player4.TabStop = false;
            this.Player4.Click += new System.EventHandler(this.pictureBox1_Click);
            this.Player4.Visible = false;
            // 
            // Background
            // 
            this.Background.BackgroundImage = global::ffgameRedux.Properties.Resources.bg0;
            this.Background.Image = global::ffgameRedux.Properties.Resources.bg0;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(800, 450);
            this.Background.TabIndex = 3;
            this.Background.TabStop = false;
            // 
            // HPBG
            // 

            this.HPBackground.BackgroundImage = global::ffgameRedux.Properties.Resources.bghp;
            this.HPBackground.Image = global::ffgameRedux.Properties.Resources.bghp;
            this.HPBackground.Location = new System.Drawing.Point(448, 450);
            this.HPBackground.Name = "hpbg";
            this.HPBackground.Size = new System.Drawing.Size(global::ffgameRedux.Properties.Resources.bghp.Width, global::ffgameRedux.Properties.Resources.bghp.Height);
            this.HPBackground.TabIndex = 3;
            this.HPBackground.TabStop = false;

            // 
            // BatBG
            // 

            this.BatBG.BackgroundImage = global::ffgameRedux.Properties.Resources.bgbat;
            this.BatBG.Image = global::ffgameRedux.Properties.Resources.bgbat;
            this.BatBG.Location = new System.Drawing.Point(178, 450);
            this.BatBG.Name = "BatBG";
            this.BatBG.Size = new System.Drawing.Size(global::ffgameRedux.Properties.Resources.bgbat.Width, global::ffgameRedux.Properties.Resources.bgbat.Height);
            this.BatBG.TabIndex = 3;
            this.BatBG.TabStop = false;

            // 
            // InfoBG
            // 

            this.InfoBG.BackgroundImage = global::ffgameRedux.Properties.Resources.bginfo;
            this.InfoBG.Image = global::ffgameRedux.Properties.Resources.bginfo;
            this.InfoBG.Location = new System.Drawing.Point(0, 450);
            this.InfoBG.Name = "BatBG";
            this.InfoBG.Size = new System.Drawing.Size(global::ffgameRedux.Properties.Resources.bginfo.Width, global::ffgameRedux.Properties.Resources.bginfo.Height);
            this.InfoBG.TabIndex = 3;
            this.InfoBG.TabStop = false;

            ///
            /// actlistbg
            /// 

            this.ActListBG.BackgroundImage = global::ffgameRedux.Properties.Resources.bgact;
            this.ActListBG.Image = global::ffgameRedux.Properties.Resources.bgact;
            this.ActListBG.Location = new System.Drawing.Point(274, 450);
            this.ActListBG.Name = "actbg";
            this.ActListBG.Size = new System.Drawing.Size(global::ffgameRedux.Properties.Resources.bgact.Width, global::ffgameRedux.Properties.Resources.bgact.Height);
            this.ActListBG.TabIndex = 3;
            this.ActListBG.TabStop = false;


            // 
            // Playerbakcpack
            // 
            this.PlayerBackpack.FormattingEnabled = true;
            this.PlayerBackpack.ItemHeight = 15;
            this.PlayerBackpack.Location = new System.Drawing.Point(13, 52);
            this.PlayerBackpack.Name = "playerbackpack";
            this.PlayerBackpack.Size = new System.Drawing.Size(70, 50);
            this.PlayerBackpack.TabIndex = 4;
            this.PlayerBackpack.ForeColor = Color.White;
            this.PlayerBackpack.BackColor = Color.DarkSlateGray;

            // 
            // Player1ActList
            // 
            this.Player1ActList.FormattingEnabled = true;
            this.Player1ActList.ItemHeight = 15;
            this.Player1ActList.Location = new System.Drawing.Point(12, 7);
            this.Player1ActList.Name = "Player1ActList";
            this.Player1ActList.Size = new System.Drawing.Size(70, 52);
            this.Player1ActList.TabIndex = 4;
            this.Player1ActList.SelectedIndexChanged += Player1ActList_SelectedIndexChanged;
            this.Player1ActList.ForeColor = Color.White;
            this.Player1ActList.BackColor = Color.DarkBlue;




            int incval = 20;
            ///
            /// Player1HPGauge
            /// 
            this.Player1HPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player1HPGauge.ForeColor = System.Drawing.Color.White;
            this.Player1HPGauge.AutoSize = true;
            this.Player1HPGauge.Location = new Point(20, incval);

            ///
            /// Player1MPGauge
            /// 
            this.Player1MPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player1MPGauge.ForeColor = System.Drawing.Color.White;
            this.Player1MPGauge.AutoSize = true;
            this.Player1MPGauge.Location = new Point(200, incval);
            this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

            // 
            // Player2ActList
            // 
            this.Player2ActList.FormattingEnabled = true;
            this.Player2ActList.ItemHeight = 15;
            this.Player2ActList.Location = new System.Drawing.Point(92, 7);
            this.Player2ActList.Name = "Player2ActList";
            this.Player2ActList.Size = new System.Drawing.Size(70, 52);
            this.Player2ActList.TabIndex = 4;
            this.Player2ActList.SelectedIndexChanged += Player2ActList_SelectedIndexChanged;
            this.Player2ActList.ForeColor = Color.White;
            this.Player2ActList.BackColor = Color.DarkRed;

            ///
            /// Player2HPGauge
            /// 
            this.Player2HPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player2HPGauge.ForeColor = System.Drawing.Color.White;
            this.Player2HPGauge.AutoSize = true;
            this.Player2HPGauge.Location = new Point(20, incval*2);

            ///
            /// Player2MPGauge
            /// 
            this.Player2MPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player2MPGauge.ForeColor = System.Drawing.Color.White;
            this.Player2MPGauge.AutoSize = true;
            this.Player2MPGauge.Location = new Point(200, incval*2);
            this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
            // 
            // Player3ActList
            // 
            this.Player3ActList.FormattingEnabled = true;
            this.Player3ActList.ItemHeight = 15;
            this.Player3ActList.Location = new System.Drawing.Point(12, 55);
            this.Player3ActList.Name = "Player3ActList";
            this.Player3ActList.Size = new System.Drawing.Size(70, 52);
            this.Player3ActList.TabIndex = 4;
            this.Player3ActList.SelectedIndexChanged += Player3ActList_SelectedIndexChanged;
            this.Player3ActList.ForeColor = Color.White;
            this.Player3ActList.BackColor = Color.DarkGreen;
            ///
            /// Player3HPGauge
            /// 
            this.Player3HPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player3HPGauge.ForeColor = System.Drawing.Color.White;
            this.Player3HPGauge.AutoSize = true;
            this.Player3HPGauge.Location = new Point(20, incval*3);
            ///
            /// Player3MPGauge
            /// 
            this.Player3MPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player3MPGauge.ForeColor = System.Drawing.Color.White;
            this.Player3MPGauge.AutoSize = true;
            this.Player3MPGauge.Location = new Point(200, incval*3);
            this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            // 
            // Player4ActList
            // 
            this.Player4ActList.FormattingEnabled = true;
            this.Player4ActList.ItemHeight = 15;
            this.Player4ActList.Location = new System.Drawing.Point(92, 55);
            this.Player4ActList.Name = "Player4ActList";
            this.Player4ActList.Size = new System.Drawing.Size(70, 52);
            this.Player4ActList.TabIndex = 4;
            this.Player4ActList.SelectedIndexChanged += Player4ActList_SelectedIndexChanged;
            this.Player4ActList.ForeColor = Color.White;
            this.Player4ActList.BackColor = Color.SaddleBrown;

            ///
            /// Player4HPGauge
            /// 
            this.Player4HPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player4HPGauge.ForeColor = System.Drawing.Color.White;
            this.Player4HPGauge.AutoSize = true;
            this.Player4HPGauge.Location = new Point(20, incval*4);
            ///
            /// Player4MPGauge
            /// 
            this.Player4MPGauge.BackColor = System.Drawing.Color.Transparent;
            this.Player4MPGauge.ForeColor = System.Drawing.Color.White;
            this.Player4MPGauge.AutoSize = true;
            this.Player4MPGauge.Location = new Point(200, incval*4);
            this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);

            ///
            /// menu button
            /// 
            this.MenuButton.BackColor = Color.DarkSlateBlue;
            this.MenuButton.ForeColor = Color.White;
            this.MenuButton.Text = "Menu";
            this.MenuButton.Size = new Size(50, 35);
            this.MenuButton.Location = new Point(30, 60);
            this.MenuButton.Click += CallMenu;

            ///
            /// engage button
            /// 
            this.EngageButton.BackColor = Color.RebeccaPurple;
            this.EngageButton.Text = "Engage";
            this.EngageButton.Size = new Size(76, 34);
            this.EngageButton.Location = new Point(10, 10);
            this.EngageButton.Click += EngageCombat;

            ///
            /// enemy one
            /// 
            this.Enemy1.Location = new Point(110, 180);
            this.Enemy1.Size = new Size(Globals.EnemyX, Globals.EnemyY);
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;

            ///
            /// GameWeapon
            /// 
            this.Gameweapon.Location = new Point(0, 0);
            this.Gameweapon.Size = new Size(32, 32);
            this.Gameweapon.BackColor = System.Drawing.Color.Transparent;

            ///
            /// SpellWeapon
            /// 
            this.SpellWeapon.Location = new Point(0, 0);
            this.SpellWeapon.Size = new Size(32, 32);
            this.SpellWeapon.BackColor = System.Drawing.Color.Transparent;

            this.SpellWeapon.Visible = false;
            ///
            /// SummonWeapon
            /// 
            this.SummonWeapon.Location = new Point(0, 0);
            this.SummonWeapon.Size = new Size(32, 32);
            this.SummonWeapon.BackColor = System.Drawing.Color.Transparent;
            this.SummonWeapon.Visible = false;

            ///
            /// 
            /// DMGLAbel
            /// 
            this.DMGLabel.Location = new Point(0, 0);
            this.DMGLabel.Size = new Size(80, 32);
            this.DMGLabel.ForeColor = Color.Red;
            this.DMGLabel.BackColor = System.Drawing.Color.Transparent;
            this.DMGLabel.Visible = false;
            this.DMGLabel.Font = new Font("Arial Black", 14);


            ///
            /// PartyRank
            /// 
            this.PartyRank.BackColor = System.Drawing.Color.Transparent;
            this.PartyRank.ForeColor = System.Drawing.Color.White;
            this.PartyRank.AutoSize = true;
            this.PartyRank.Location = new Point(40, 16);
            this.PartyRank.Text = ("Party Rank: " + Globals.Rank);


            ///
            /// PartyScore
            /// 
            this.PartyScore.BackColor = System.Drawing.Color.Transparent;
            this.PartyScore.ForeColor = System.Drawing.Color.White;
            this.PartyScore.AutoSize = true;
            this.PartyScore.Location = new Point(33, 36);
            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2  + 1 ));


            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.ControlBox = true;
            this.Name = "MainForm";
            this.Text = "FFGameRedux";
            this.KeyDown += this_KeyDown;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);


            // add elements
            
            this.Controls.Add(ActListBG);
            this.Controls.Add(HPBackground);
            this.Controls.Add(BatBG);
            this.Controls.Add(InfoBG);
            this.ActListBG.Controls.Add(this.Player1ActList);
            this.ActListBG.Controls.Add(this.Player2ActList);
            this.BatBG.Controls.Add(this.PlayerBackpack);
            this.HPBackground.Controls.Add(this.Player1HPGauge);
            this.HPBackground.Controls.Add(this.Player2HPGauge);
            this.HPBackground.Controls.Add(this.Player1MPGauge);
            this.HPBackground.Controls.Add(this.Player2MPGauge);
            this.Controls.Add(this.Background);
            this.BatBG.Controls.Add(EngageButton);
            this.Background.Controls.Add(this.DMGLabel);
            this.Background.Controls.Add(this.Player4);
            this.Background.Controls.Add(this.Player3);
            this.Background.Controls.Add(this.Player2);
            this.Background.Controls.Add(this.Player1);
            this.InfoBG.Controls.Add(PartyRank);
            this.InfoBG.Controls.Add(PartyScore);
            this.InfoBG.Controls.Add(MenuButton);

            this.Background.Controls.Add(this.Gameweapon);
            this.Background.Controls.Add(this.SummonWeapon);
            this.Background.Controls.Add(this.Enemy1);
            this.Enemy1.Controls.Add(SpellWeapon);
            #endregion

            #region LoadPlayer1Graphics

           
            
            Random rand = new Random();
            int[] RecruitNumbers = { 0, 1, 2, 3, 4, 5 };


            int SelectedMember = Globals.P1Override;
            if (Globals.PartySelectOverride == false)
            {
                 SelectedMember = rand.Next(0, RecruitNumbers.Length);
            }
            //Get ran number for loading list
            //SelectedMember = 5;
            

            if (SelectedMember == 0) {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Black",
            " White"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
                Globals.Player1HP = Globals.OnionHP;
                Globals.Player1MaxHP = Globals.OnionMaxHP;
                Globals.Player1MP = Globals.OnionMP;
                Globals.Player1Attack = Globals.OnionAttack;
                Globals.Player1Defense = Globals.OnionDefense;
                Globals.Player1Speed = Globals.OnionSpeed;
                Globals.Player1MP = Globals.OnionMP;
                Globals.Player1MaxMP = Globals.OnionMaxMP;
                Globals.Player1Name = "Luneth";
            }

            if (SelectedMember == 1)
            {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Revenger",
            " Blood"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                Globals.Player1HP = Globals.WarHP;
                Globals.Player1MaxHP = Globals.WarMaxHP;
                Globals.Player1MP = Globals.WarMP;
                Globals.Player1Attack = Globals.WarAttack;
                Globals.Player1Defense = Globals.WarDefense;
                Globals.Player1Speed = Globals.WarSpeed;
                Globals.Player1Name = "Warrior";
                Globals.Player1MP = Globals.WarMP;
                Globals.Player1MaxMP = Globals.WarMaxMP;
            }

            if (SelectedMember == 2)
            {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Steal"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
                Globals.Player1HP = Globals.ThiefHP;
                Globals.Player1MaxHP = Globals.ThiefMaxHP;
                Globals.Player1MP = Globals.ThiefMP;
                Globals.Player1Attack = Globals.ThiefAttack;
                Globals.Player1Defense = Globals.ThiefDefense;
                Globals.Player1Speed = Globals.ThiefSpeed;
                Globals.Player1Name = "Thief";
                Globals.Player1MP = Globals.ThiefMP;
                Globals.Player1MaxMP = Globals.ThiefMaxMP;
            }

            if (SelectedMember == 3)
            {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Jump",
            " Tent"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
                Globals.Player1HP = Globals.CidHP;
                Globals.Player1MaxHP = Globals.CidMaxHP;
                Globals.Player1MP = Globals.CidMP;
                Globals.Player1Attack = Globals.CidAttack;
                Globals.Player1Defense = Globals.CidDefense;
                Globals.Player1Speed = Globals.CidSpeed;
                Globals.Player1Name = "Cid";
                Globals.Player1MP = Globals.CidMP;
                Globals.Player1MaxMP = Globals.CidMaxMP;
            }

            if (SelectedMember == 4)
            {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Summon",
            " Osmose"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                Globals.Player1HP = Globals.RydiaHP;
                Globals.Player1MaxHP = Globals.RydiaMaxHP;
                Globals.Player1MP = Globals.RydiaMP;
                Globals.Player1Attack = Globals.RydiaAttack;
                Globals.Player1Defense = Globals.RydiaDefense;
                Globals.Player1Speed = Globals.RydiaSpeed;
                Globals.Player1Name = "Rydia";
                Globals.Player1MP = Globals.RydiaMP;
                Globals.Player1MaxMP = Globals.RydiaMaxMP;
            }

            //eddy
            if (SelectedMember == 5)
            {
                this.Player1ActList.Items.AddRange(new object[] {
            " Fight",
            " Tools",
            " Magic"});
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                Globals.Player1HP = Globals.EdgarHP;
                Globals.Player1MaxHP = Globals.EdgarMaxHP;
                Globals.Player1MP = Globals.EdgarMP;
                Globals.Player1Attack = Globals.EdgarAttack;
                Globals.Player1Defense = Globals.EdgarDefense;
                Globals.Player1Speed = Globals.EdgarSpeed;
                Globals.Player1Name = "Edgar";
                Globals.Player1MP = Globals.EdgarMP;
                Globals.Player1MaxMP = Globals.EdgarMaxMP;
            }

            this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
            this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

            #endregion

            #region LoadPlayer2Graphics

            int SelectedMember2 = Globals.P2Override;
            if (Globals.PartySelectOverride == false)
            {
                SelectedMember2 = rand.Next(0, RecruitNumbers.Length);
                while (SelectedMember == SelectedMember2)
                {
                    SelectedMember2 = rand.Next(0, RecruitNumbers.Length);
                };
            }
            //SelectedMember2 = 5;
            //Get ran number for loading list
            if (SelectedMember2 == 0)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Black",
            " White"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
                Globals.Player2HP = Globals.OnionHP;
                Globals.Player2MaxHP = Globals.OnionMaxHP;
                Globals.Player2MP = Globals.OnionMP;
                Globals.Player2Attack = Globals.OnionAttack;
                Globals.Player2Defense = Globals.OnionDefense;
                Globals.Player2Speed = Globals.OnionSpeed;
                Globals.Player2MP = Globals.OnionMP;
                Globals.Player2MaxMP = Globals.OnionMaxMP;
                Globals.Player2Name = "Luneth";

            }

            if (SelectedMember2 == 1)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Revenger",
            " Blood"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
                Globals.Player2HP = Globals.WarHP;
                Globals.Player2MaxHP = Globals.WarMaxHP;
                Globals.Player2MP = Globals.WarMP;
                Globals.Player2Attack = Globals.WarAttack;
                Globals.Player2Defense = Globals.WarDefense;
                Globals.Player2Speed = Globals.WarSpeed;
                Globals.Player2MP = Globals.WarMP;
                Globals.Player2MaxMP = Globals.WarMaxMP;
                Globals.Player2Name = "Warrior";

            }

            if (SelectedMember2 == 2)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Steal"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
                Globals.Player2HP = Globals.ThiefHP;
                Globals.Player2MaxHP = Globals.ThiefMaxHP;
                Globals.Player2MP = Globals.ThiefMP;
                Globals.Player2Attack = Globals.ThiefAttack;
                Globals.Player2Defense = Globals.ThiefDefense;
                Globals.Player2Speed = Globals.ThiefSpeed;
                Globals.Player2MP = Globals.ThiefMP;
                Globals.Player2MaxMP = Globals.ThiefMaxMP;
                Globals.Player2Name = "Thief";

            }

            if (SelectedMember2 == 3)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Jump",
            " Tent"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
                Globals.Player2HP = Globals.CidHP;
                Globals.Player2MaxHP = Globals.CidMaxHP;
                Globals.Player2MP = Globals.CidMP;
                Globals.Player2Attack = Globals.CidAttack;
                Globals.Player2Defense = Globals.CidDefense;
                Globals.Player2Speed = Globals.CidSpeed;
                Globals.Player2MP = Globals.CidMP;
                Globals.Player2MaxMP = Globals.CidMaxMP;
                Globals.Player2Name = "Cid";

            }


            if (SelectedMember2 == 4)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Summon",
            " Osmose"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                Globals.Player2HP = Globals.RydiaHP;
                Globals.Player2MaxHP = Globals.RydiaMaxHP;
                Globals.Player2MP = Globals.RydiaMP;
                Globals.Player2Attack = Globals.RydiaAttack;
                Globals.Player2Defense = Globals.RydiaDefense;
                Globals.Player2Speed = Globals.RydiaSpeed;
                Globals.Player2Name = "Rydia";
                Globals.Player2MP = Globals.RydiaMP;
                Globals.Player2MaxMP = Globals.RydiaMaxMP;
            }

            if (SelectedMember2 == 5)
            {
                this.Player2ActList.Items.AddRange(new object[] {
            " Fight",
            " Tools",
            " Magic"});
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                Globals.Player2HP = Globals.EdgarHP;
                Globals.Player2MaxHP = Globals.EdgarMaxHP;
                Globals.Player2MP = Globals.EdgarMP;
                Globals.Player2Attack = Globals.EdgarAttack;
                Globals.Player2Defense = Globals.EdgarDefense;
                Globals.Player2Speed = Globals.EdgarSpeed;
                Globals.Player2Name = "Edgar";
                Globals.Player2MP = Globals.EdgarMP;
                Globals.Player2MaxMP = Globals.EdgarMaxMP;
            }

            this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
            this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

            #endregion

            #region LoadPlayer3Graphics
            int SelectedMember3 = Globals.P3Override;
            if (Globals.PartySelectOverride == false)
            {
                SelectedMember3 = rand.Next(0, RecruitNumbers.Length);
                while (SelectedMember == SelectedMember3 || SelectedMember2 == SelectedMember3)
                {
                    SelectedMember3 = rand.Next(0, RecruitNumbers.Length);
                };
            }
            //SelectedMember3 = 5;
            //Get ran number for loading list
            if (SelectedMember3 == 0)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Black",
            " White"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
                Globals.Player3HP = Globals.OnionHP;
                Globals.Player3MaxHP = Globals.OnionMaxHP;
                Globals.Player3MP = Globals.OnionMP;
                Globals.Player3Attack = Globals.OnionAttack;
                Globals.Player3Defense = Globals.OnionDefense;
                Globals.Player3Speed = Globals.OnionSpeed;
                Globals.Player3MP = Globals.OnionMP;
                Globals.Player3MaxMP = Globals.OnionMaxMP;
                Globals.Player3Name = "Luneth";

            }

            if (SelectedMember3 == 1)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Revenger",
            " Blood"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
                Globals.Player3HP = Globals.WarHP;
                Globals.Player3MaxHP = Globals.WarMaxHP;
                Globals.Player3MP = Globals.WarMP;
                Globals.Player3Attack = Globals.WarAttack;
                Globals.Player3Defense = Globals.WarDefense;
                Globals.Player3Speed = Globals.WarSpeed;
                Globals.Player3MP = Globals.WarMP;
                Globals.Player3MaxMP = Globals.WarMaxMP;
                Globals.Player3Name = "Warrior";

            }

            if (SelectedMember3 == 2)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Steal"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
                Globals.Player3HP = Globals.ThiefHP;
                Globals.Player3MaxHP = Globals.ThiefMaxHP;
                Globals.Player3MP = Globals.ThiefMP;
                Globals.Player3Attack = Globals.ThiefAttack;
                Globals.Player3Defense = Globals.ThiefDefense;
                Globals.Player3Speed = Globals.ThiefSpeed;
                Globals.Player3MP = Globals.ThiefMP;
                Globals.Player3MaxMP = Globals.ThiefMaxMP;
                Globals.Player3Name = "Thief";

            }

            if (SelectedMember3 == 3)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Jump",
            " Tent"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
                Globals.Player3HP = Globals.CidHP;
                Globals.Player3MaxHP = Globals.CidMaxHP;
                Globals.Player3MP = Globals.CidMP;
                Globals.Player3Attack = Globals.CidAttack;
                Globals.Player3Defense = Globals.CidDefense;
                Globals.Player3Speed = Globals.CidSpeed;
                Globals.Player3MP = Globals.CidMP;
                Globals.Player3MaxMP = Globals.CidMaxMP;
                Globals.Player3Name = "Cid";

            }

            if (SelectedMember3 == 4)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Summon",
            " Osmose"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                Globals.Player3HP = Globals.RydiaHP;
                Globals.Player3MaxHP = Globals.RydiaMaxHP;
                Globals.Player3MP = Globals.RydiaMP;
                Globals.Player3Attack = Globals.RydiaAttack;
                Globals.Player3Defense = Globals.RydiaDefense;
                Globals.Player3Speed = Globals.RydiaSpeed;
                Globals.Player3Name = "Rydia";
                Globals.Player3MP = Globals.RydiaMP;
                Globals.Player3MaxMP = Globals.RydiaMaxMP;
            }

            if (SelectedMember3 == 5)
            {
                this.Player3ActList.Items.AddRange(new object[] {
            " Fight",
            " Tools",
            " Magic"});
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                Globals.Player3HP = Globals.EdgarHP;
                Globals.Player3MaxHP = Globals.EdgarMaxHP;
                Globals.Player3MP = Globals.EdgarMP;
                Globals.Player3Attack = Globals.EdgarAttack;
                Globals.Player3Defense = Globals.EdgarDefense;
                Globals.Player3Speed = Globals.EdgarSpeed;
                Globals.Player3Name = "Edgar";
                Globals.Player3MP = Globals.EdgarMP;
                Globals.Player3MaxMP = Globals.EdgarMaxMP;
            }

            this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
            this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            #endregion

            #region LoadPlayer4Graphics
            int SelectedMember4 = Globals.P4Override;
            if (Globals.PartySelectOverride == false)
            {
                SelectedMember4 = rand.Next(0, RecruitNumbers.Length);
                while (SelectedMember == SelectedMember4 || SelectedMember2 == SelectedMember4 || SelectedMember3 == SelectedMember4)
                {
                    SelectedMember4 = rand.Next(0, RecruitNumbers.Length);
                };
            }
            //SelectedMember4 = 5;

            //Get ran number for loading list
            if (SelectedMember4 == 0)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Black",
            " White"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
                Globals.Player4HP = Globals.OnionHP;
                Globals.Player4MaxHP = Globals.OnionMaxHP;
                Globals.Player4MP = Globals.OnionMP;
                Globals.Player4Attack = Globals.OnionAttack;
                Globals.Player4Defense = Globals.OnionDefense;
                Globals.Player4Speed = Globals.OnionSpeed;
                Globals.Player4MP = Globals.OnionMP;
                Globals.Player4MaxMP = Globals.OnionMaxMP;
                Globals.Player4Name = "Luneth";

            }

            if (SelectedMember4 == 1)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Revenger",
            " Blood"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
                Globals.Player4HP = Globals.WarHP;
                Globals.Player4MaxHP = Globals.WarMaxHP;
                Globals.Player4MP = Globals.WarMP;
                Globals.Player4Attack = Globals.WarAttack;
                Globals.Player4Defense = Globals.WarDefense;
                Globals.Player4Speed = Globals.WarSpeed;
                Globals.Player4MP = Globals.WarMP;
                Globals.Player4MaxMP = Globals.WarMaxMP;
                Globals.Player4Name = "Warrior";

            }

            if (SelectedMember4 == 2)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Steal"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
                Globals.Player4HP = Globals.ThiefHP;
                Globals.Player4MaxHP = Globals.ThiefMaxHP;
                Globals.Player4MP = Globals.ThiefMP;
                Globals.Player4Attack = Globals.ThiefAttack;
                Globals.Player4Defense = Globals.ThiefDefense;
                Globals.Player4Speed = Globals.ThiefSpeed;
                Globals.Player4MP = Globals.ThiefMP;
                Globals.Player4MaxMP = Globals.ThiefMaxMP;
                Globals.Player4Name = "Thief";

            }

            if (SelectedMember4 == 3)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Jump",
            " Tent"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
                Globals.Player4HP = Globals.CidHP;
                Globals.Player4MaxHP = Globals.CidMaxHP;
                Globals.Player4MP = Globals.CidMP;
                Globals.Player4Attack = Globals.CidAttack;
                Globals.Player4Defense = Globals.CidDefense;
                Globals.Player4Speed = Globals.CidSpeed;
                Globals.Player4MP = Globals.CidMP;
                Globals.Player4MaxMP = Globals.CidMaxMP;
                Globals.Player4Name = "Cid";

            }
            if (SelectedMember4 == 4)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Summon",
            " Osmose"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                Globals.Player4HP = Globals.RydiaHP;
                Globals.Player4MaxHP = Globals.RydiaMaxHP;
                Globals.Player4MP = Globals.RydiaMP;
                Globals.Player4Attack = Globals.RydiaAttack;
                Globals.Player4Defense = Globals.RydiaDefense;
                Globals.Player4Speed = Globals.RydiaSpeed;
                Globals.Player4Name = "Rydia";
                Globals.Player4MP = Globals.RydiaMP;
                Globals.Player4MaxMP = Globals.RydiaMaxMP;
            }

            if (SelectedMember4 == 5)
            {
                this.Player4ActList.Items.AddRange(new object[] {
            " Fight",
            " Tools",
            " Magic"});
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                Globals.Player4HP = Globals.EdgarHP;
                Globals.Player4MaxHP = Globals.EdgarMaxHP;
                Globals.Player4MP = Globals.EdgarMP;
                Globals.Player4Attack = Globals.EdgarAttack;
                Globals.Player4Defense = Globals.EdgarDefense;
                Globals.Player4Speed = Globals.EdgarSpeed;
                Globals.Player4Name = "Edgar";
                Globals.Player4MP = Globals.EdgarMP;
                Globals.Player4MaxMP = Globals.EdgarMaxMP;
            }

            this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
            this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);

            #endregion


            this.Background.MouseDown += this_MouseDown;
            this.Background.MouseUp += this_MouseUp;
            this.Background.MouseMove += this_MouseMove;
            this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_1;
            MusicShift();
            this.FormBorderStyle = FormBorderStyle.None;
            this.PlayerBackpack.Items.Add(" Potion");
            Player3JoinsTheParty();
            Player4JoinsTheParty();
            // End of Main  
        }


        public void PartySelectwindow()
        {

            string[] Strarray = { "Luneth", "Warrior", "Thief", "Cid", "Rydia", "Edgar" };



            int charc = 0;
            while (charc < 6)
            {
                Globals.P1CharList.Items.Add(Strarray[charc]);
                Globals.P2CharList.Items.Add(Strarray[charc]);
                Globals.P3CharList.Items.Add(Strarray[charc]);
                Globals.P4CharList.Items.Add(Strarray[charc]);
                charc++;
            }


            Globals.P1CharList.Location = new Point(10, 30);
            Globals.P2CharList.Location = new Point(80, 30);
            Globals.P3CharList.Location = new Point(150, 30);
            Globals.P4CharList.Location = new Point(220, 30);

            Globals.P1CharList.Size = new Size(60, 90);
            Globals.P2CharList.Size = new Size(60, 90);
            Globals.P3CharList.Size = new Size(60, 90);
            Globals.P4CharList.Size = new Size(60, 90);

            Button RandomizeParty = new Button();
            Button TakeThisParty = new Button();

            RandomizeParty.Size = new Size(100, 45);
            RandomizeParty.Text = "Random\nParty";
            RandomizeParty.Location = new Point(300, 75);
            RandomizeParty.Click += ClosePartySelect;

            TakeThisParty.Size = new Size(100, 45);
            TakeThisParty.Text = "Take This\nParty";
            TakeThisParty.Location = new Point(300, 30);
            TakeThisParty.Click += SetPartyVals;

            Globals.PartySelectForm.Size = new Size(440, 180);
            Globals.PartySelectForm.Text = "Party Select";

            Globals.PartySelectForm.Controls.Add(Globals.P1CharList);
            Globals.PartySelectForm.Controls.Add(Globals.P2CharList);
            Globals.PartySelectForm.Controls.Add(Globals.P3CharList);
            Globals.PartySelectForm.Controls.Add(Globals.P4CharList);
            Globals.PartySelectForm.Controls.Add(TakeThisParty);
            Globals.PartySelectForm.Controls.Add(RandomizeParty);
            //PartySelectForm.FormBorderStyle = FormBorderStyle.None;
            Globals.PartySelectForm.ShowDialog();

        }

        public void ClosePartySelect(object sender, EventArgs e)
        {
            Globals.PartySelectForm.Close();
        }

        public void SetPartyVals (object sender, EventArgs e)
        {
            Globals.P1Override = Globals.P1CharList.SelectedIndex;
            Globals.P2Override = Globals.P2CharList.SelectedIndex;
            Globals.P3Override = Globals.P3CharList.SelectedIndex;
            Globals.P4Override = Globals.P4CharList.SelectedIndex;
            Globals.PartySelectOverride = true;

            Globals.PartySelectForm.Close();
        }

        private void CallMenu(object sender, System.EventArgs e)
        {

           
            MenuWin.FormBorderStyle = FormBorderStyle.None;
            
            MenuWin.Size = new Size(ffgameRedux.Properties.Resources.bgmenu.Width, ffgameRedux.Properties.Resources.bgmenu.Height);
            MenuWin.BackgroundImage = global::ffgameRedux.Properties.Resources.bgmenu;
            MenuWin.KeyPreview = true;
            MenuWin.KeyDown += MenuWinKeyHandler;

            

            this.Visible = false;

            StatGraph.BackColor = Color.Transparent;
            StatGraph.ForeColor = Color.White;
            StatGraph.Size = new Size(ffgameRedux.Properties.Resources.bgmenu.Width - 1, ffgameRedux.Properties.Resources.bgmenu.Height - 1);
            StatGraph.Location = new Point(9, 9);

            if (Globals.PartySize.Length == 4)
            {

                StatGraph.Text = (
                    
                    Globals.Player1Name + " HP: " + Globals.Player1HP  + " / " + Globals.Player1MaxHP +
                    "  MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP + " \n" +
                    "Attack:  " + Globals.Player1Attack + "  Defense:  " + Globals.Player1Defense + "  Speed:  " + Globals.Player1Speed
                    + "\n\n" +
                    Globals.Player2Name + " HP: " + Globals.Player2HP + " / " + Globals.Player2MaxHP +
                    "  MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP + " \n" +
                    "Attack:  " + Globals.Player2Attack + " Defense:  " + Globals.Player2Defense + " Speed:  " + Globals.Player2Speed
                     + "\n\n" +
                    Globals.Player3Name + " HP: " + Globals.Player3HP + " / " + Globals.Player3MaxHP +
                    "  MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP + " \n" +
                    "Attack:  " + Globals.Player3Attack + " Defense:  " + Globals.Player3Defense + " Speed:  " + Globals.Player3Speed
                     + "\n\n" +
                    Globals.Player4Name + " HP: " + Globals.Player4HP + " / " + Globals.Player4MaxHP +
                    "  MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP + " \n" +
                    "Attack:  " + Globals.Player4Attack + " Defense:  " + Globals.Player4Defense + " Speed:  " + Globals.Player4Speed




                    );
            }

            

            MenuWin.Controls.Add(StatGraph);
            MenuWin.ShowDialog();
            ///////////////////////////////////////
            /////////redraw battle window//////////
            ///////////////////////////////////////
            
            

            
            this.Visible = true;

        }

        private void MenuWinKeyHandler(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                MenuWin.Close();

            }
            if (e.KeyCode == Keys.Enter)
            {
                MenuWin.Close();

            }
            if (e.KeyCode == Keys.Insert)
            {
                Globals.Floor = 31;
                LoadNextFloor();
            }

            if (e.KeyCode == Keys.PageUp)
            {
                Globals.Floor = 49;
                LoadNextFloor();
            }

            if (e.KeyCode == Keys.PageDown)
            {
                EndingSequence();


            }
        }

        private void this_MouseDown(object sender, MouseEventArgs e)
        {
            Globals.mouseDown = true;
            Globals.lastLocation = e.Location;
        }

        private void this_MouseMove(object sender, MouseEventArgs e)
        {
            if (Globals.mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - Globals.lastLocation.X) + e.X, (this.Location.Y - Globals.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void this_MouseUp(object sender, MouseEventArgs e)
        {
            Globals.mouseDown = false;
        }

        private void this_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }

            if (Globals.Player1InAir == false)
            {
                if (Globals.Player1IsDead == false)
                {

                    if (e.KeyCode == Keys.NumPad7)
                    {
                        this.Player1ActList.SelectedIndex = 0;

                    }

                    if (e.KeyCode == Keys.NumPad4)
                    {
                        this.Player1ActList.SelectedIndex = 1;

                    }

                    if (e.KeyCode == Keys.NumPad1)
                    {
                        if (Player1ActList.Items.Count > 2)
                        {
                            this.Player1ActList.SelectedIndex = 2;
                        }

                    }
                }
            }



            if (Globals.Player2InAir == false)
            {
                if (Globals.Player2IsDead == false)
                {

                    if (e.KeyCode == Keys.NumPad8)
                    {
                        this.Player2ActList.SelectedIndex = 0;

                    }

                    if (e.KeyCode == Keys.NumPad5)
                    {
                        this.Player2ActList.SelectedIndex = 1;

                    }

                    if (e.KeyCode == Keys.NumPad2)
                    {

                        if (Player2ActList.Items.Count > 2)
                        {
                            this.Player2ActList.SelectedIndex = 2;
                        }

                    }
                }
            }



            if (Globals.Player3InAir == false)
            {

                if (Globals.Player3IsDead == false)
                {
                    if (e.KeyCode == Keys.NumPad9)
                    {
                        this.Player3ActList.SelectedIndex = 0;

                    }

                    if (e.KeyCode == Keys.NumPad6)
                    {
                        this.Player3ActList.SelectedIndex = 1;

                    }

                    if (e.KeyCode == Keys.NumPad3)
                    {
                        if (Player3ActList.Items.Count > 2)
                        {
                            this.Player3ActList.SelectedIndex = 2;
                        }
                    }
                }
            }







            if (Globals.Player4InAir == false)
            {


                if (Globals.Player4IsDead == false)
                {

                    if (e.KeyCode == Keys.Divide)
                    {
                        this.Player4ActList.SelectedIndex = 0;

                    }

                    if (e.KeyCode == Keys.Multiply)
                    {
                        this.Player4ActList.SelectedIndex = 1;

                    }

                    if (e.KeyCode == Keys.Subtract)
                    {
                        if (Player4ActList.Items.Count > 2)
                        {
                            this.Player4ActList.SelectedIndex = 2;
                        }

                    }
                }
            }

            if (e.KeyCode == Keys.Add)
            {
                EngageCombat(null,null);

            }


        }

        private void Player1ActList_SelectedIndexChanged(object sender, System.EventArgs e) {

            if (Globals.Player1Name == "Luneth")
            {
                if (this.Player1ActList.SelectedIndex == 0) {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_m;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_l;
                }
            };

            if (Globals.Player1Name == "Warrior")
            {
                if (this.Player1ActList.SelectedIndex == 0)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_m;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_l;
                }
            };

            if (Globals.Player1Name == "Thief")
            {
                if (this.Player1ActList.SelectedIndex == 0)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_l;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_m;
                }
            };

            if (Globals.Player1Name == "Cid")
            {
                if (this.Player1ActList.SelectedIndex == 0)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_l;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_m;
                }
            };
            if (Globals.Player1Name == "Rydia")
            {
                if (this.Player1ActList.SelectedIndex == 0)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_m;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_l;
                }
            };
            if (Globals.Player1Name == "Edgar")
            {
                if (this.Player1ActList.SelectedIndex == 0)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                }
                if (this.Player1ActList.SelectedIndex == 1)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                }
                if (this.Player1ActList.SelectedIndex == 2)
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_m;
                }
            };

        }

        private void Player2ActList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (Globals.Player2Name == "Luneth")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_m;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_l;
                }
            };

            if (Globals.Player2Name == "Warrior")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_m;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_l;
                }
            };

            if (Globals.Player2Name == "Thief")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_l;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_m;
                }
            };

            if (Globals.Player2Name == "Cid")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_l;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_m;
                }
            };
            if (Globals.Player2Name == "Rydia")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_m;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_l;
                }
            };
            if (Globals.Player2Name == "Edgar")
            {
                if (this.Player2ActList.SelectedIndex == 0)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                }
                if (this.Player2ActList.SelectedIndex == 1)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                }
                if (this.Player2ActList.SelectedIndex == 2)
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_m;
                }
            };

        }

        private void Player3ActList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (Globals.Player3Name == "Luneth")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_m;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_l;
                }
            };

            if (Globals.Player3Name == "Warrior")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_m;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_l;
                }
            };

            if (Globals.Player3Name == "Thief")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_l;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_m;
                }
            };

            if (Globals.Player3Name == "Cid")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_l;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_m;
                }
            };
            if (Globals.Player3Name == "Rydia")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_m;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_l;
                }
            };
            if (Globals.Player3Name == "Edgar")
            {
                if (this.Player3ActList.SelectedIndex == 0)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                }
                if (this.Player3ActList.SelectedIndex == 1)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                }
                if (this.Player3ActList.SelectedIndex == 2)
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_m;
                }
            };
        }

        private void Player4ActList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (Globals.Player4Name == "Luneth")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_m;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_l;
                }
            };

            if (Globals.Player4Name == "Warrior")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_m;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_l;
                }
            };

            if (Globals.Player4Name == "Thief")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_l;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_m;
                }
            };

            if (Globals.Player4Name == "Cid")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_l;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_m;
                }
            };
            if (Globals.Player4Name == "Rydia")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_m;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_l;
                }
            };

            if (Globals.Player4Name == "Edgar")
            {
                if (this.Player4ActList.SelectedIndex == 0)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                }
                if (this.Player4ActList.SelectedIndex == 1)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                }
                if (this.Player4ActList.SelectedIndex == 2)
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_m;
                }
            };

        }

        public void MusicShift()
        {
            
            if (Globals.Floor == 0)
            {
                Globals.SongID = "data/ff3bat.wav";
                
            }
            if (Globals.Floor == 3)
            {
                Globals.SongID = "data/ff6bat.wav";

            }
            if (Globals.Floor == 6)
            {
                Globals.SongID = "data/ffmqboss.wav";
                
            }
            if (Globals.Floor == 7)
            {
                Globals.SongID = "data/ffvbig.wav";

            }
            if (Globals.Floor == 13)
            {
                Globals.SongID = "data/ffmqboss.wav";

            }
            if (Globals.Floor == 14)
            {
                Globals.SongID = "data/ff9bat.wav";

            }
            if (Globals.Floor == 20)
            {
                Globals.SongID = "data/ffmqboss.wav";

            }
            if (Globals.Floor == 21)
            {
                Globals.SongID = "data/ffvexdeath.mp3";

            }
            if(Globals.Floor == 25)
            {
                Globals.SongID = "data/ffmqboss.wav";

            }
            if (Globals.Floor == 26)
            {
                Globals.SongID = "data/ff4boss.mp3";

            }
            if (Globals.Floor == 29)
            {
                Globals.SongID = "data/jenova.mp3";

            }
            if (Globals.Floor == 32)
            {
                Globals.SongID = "data/sa3.wav";

            }

            if (Globals.Floor == 50) 
            {
                Globals.SongID = "data/ffbe_sky.mp3";

            }/// JOE BIDEN

            Globals.MusicPlayer.URL = Globals.SongID;
            Globals.MusicPlayer.controls.play();
        }

        private void EngageCombat(object sender, System.EventArgs e)
        {

            ///Do Fancy stuff here
            ///



            //backpack stuff
            Globals.PlayerTurn = 0;
            if (this.PlayerBackpack.SelectedItem == " Tent")
            {
                if (Globals.EnemyHP >= 1)
                {
                    TentFormula();
                    this.PlayerBackpack.SelectedIndex = -1;
                }
            }
            if (this.PlayerBackpack.SelectedItem == " Potion")
            {
                if (Globals.EnemyHP >= 1)
                {
                    PotionFormula();
                    this.PlayerBackpack.SelectedIndex = -1;
                }
            }
            if (this.PlayerBackpack.SelectedItem == " Phoenix")
            {
                if (Globals.EnemyHP >= 1)
                {
                    PhoenixFormula();
                    this.PlayerBackpack.SelectedIndex = -1;
                }
            }



            // actual players

            Globals.PlayerTurn = 1;
            if (this.Player1ActList.SelectedItem == " Fight") {
                if (Globals.EnemyHP >= 1)
                {
                    P1FightFormula();
                }
            }

            if (this.Player1ActList.SelectedItem == " Black")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1BlackMagicFormula();
                }
            }
            if (this.Player1ActList.SelectedItem == " White")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1WhiteMagicFormula();
                }
            }
            if (this.Player1ActList.SelectedItem == " Revenger")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1RevengeFormula();
                }
            }
            if (this.Player1ActList.SelectedItem == " Blood")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1BloodSwordFormula();
                }
            }
            if (this.Player1ActList.SelectedItem == " Steal")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1ThiefSteal();
                }
            }
            if (this.Player1ActList.SelectedItem == " Osmose")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1Osmose();
                }
            }
            if (this.Player1ActList.SelectedItem == " Tent")
            {
                if (Globals.EnemyHP >= 1)
                {
                    TentFormula();
                }
            }
            if (this.Player1ActList.SelectedItem == " Summon")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1Summon();
                }
            }
            if (this.Player1ActList.SelectedItem == " Tools")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1Tools();
                }
            }
            if (this.Player1ActList.SelectedItem == " Magic")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1BlackMagicFormula();
                }
            }

            if (Globals.Player1InAir == true && Globals.EnemyHP >= 1)
            {

                P1LandFormula();
            }
            if (this.Player1ActList.SelectedItem == " Jump")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P1JumpFormula();
                }
            }

            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2 + 1));
            Globals.PlayerTurn = 2;
            if (this.Player2ActList.SelectedItem == " Fight")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2FightFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " Black")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2BlackMagicFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " White")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2WhiteMagicFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " Revenger")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2RevengeFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " Blood")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2BloodSwordFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " Steal")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2ThiefSteal();
                }
            }
            if (this.Player2ActList.SelectedItem == " Tent")
            {
                if (Globals.EnemyHP >= 1)
                {
                    TentFormula();
                }
            }
            if (this.Player2ActList.SelectedItem == " Summon")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2Summon();
                }
            }
            if (this.Player2ActList.SelectedItem == " Osmose")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2Osmose();
                }
            }
            if (this.Player2ActList.SelectedItem == " Tools")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2Tools();
                }
            }
            if (this.Player2ActList.SelectedItem == " Magic")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2BlackMagicFormula();
                }
            }

            if (Globals.Player2InAir == true && Globals.EnemyHP >= 1)
            {

                P2LandFormula();
            }

            if (this.Player2ActList.SelectedItem == " Jump")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P2JumpFormula();
                }
            }

            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2 + 1));
            Globals.PlayerTurn = 3;
            if (this.Player3ActList.SelectedItem == " Fight")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3FightFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " Black")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3BlackMagicFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " White")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3WhiteMagicFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " Revenger")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3RevengeFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " Blood")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3BloodSwordFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " Steal")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3ThiefSteal();
                }
            }
            if (this.Player3ActList.SelectedItem == " Tent")
            {
                if (Globals.EnemyHP >= 1)
                {
                    TentFormula();
                }
            }
            if (this.Player3ActList.SelectedItem == " Summon")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3Summon();
                }
            }
            if (this.Player3ActList.SelectedItem == " Osmose")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3Osmose();
                }
            }
            if (this.Player3ActList.SelectedItem == " Tools")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3Tools();
                }
            }
            if (this.Player3ActList.SelectedItem == " Magic")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3BlackMagicFormula();
                }
            }

            if (Globals.Player3InAir == true && Globals.EnemyHP >= 1)
            {

                P3LandFormula();
            }

            if (this.Player3ActList.SelectedItem == " Jump")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P3JumpFormula();
                }
            }

            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2 + 1));
            Globals.PlayerTurn = 4;
            if (this.Player4ActList.SelectedItem == " Fight")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4FightFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " Black")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4BlackMagicFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " White")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4WhiteMagicFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " Revenger")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4RevengeFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " Blood")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4BloodSwordFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " Steal")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4ThiefSteal();
                }
            }
            if (this.Player4ActList.SelectedItem == " Tent")
            {
                if (Globals.EnemyHP >= 1)
                {
                    TentFormula();
                }
            }
            if (this.Player4ActList.SelectedItem == " Summon")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4Summon();
                }
            }
            if (this.Player4ActList.SelectedItem == " Osmose")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4Osmose();
                }
            }
            if (this.Player4ActList.SelectedItem == " Tools")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4Tools();
                }
            }
            if (this.Player4ActList.SelectedItem == " Magic")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4BlackMagicFormula();
                }
            }

            if (Globals.Player4InAir == true && Globals.EnemyHP >= 1)
            {

                P4LandFormula();
            }
            if (this.Player4ActList.SelectedItem == " Jump")
            {
                if (Globals.EnemyHP >= 1)
                {
                    P4JumpFormula();
                }
            }





            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2 + 1));
            if (Globals.EnemyHP >= 1)
            {


                BossFinder();
                
                
                 
                
            }

            if (Globals.EnemyHP == 0)
            {
                LoadNextFloor();
            }

            this.Player1ActList.SelectedIndex = -1;
            this.Player2ActList.SelectedIndex = -1;
            this.Player3ActList.SelectedIndex = -1;
            this.Player4ActList.SelectedIndex = -1;
            
        }

        private void BossFinder()
        {

            if (Globals.BossFight == true)
            {
                Random ran = new Random();
                int BattleOption = ran.Next(0, Globals.Spells.Length);

                BattleOption = 2;
                
                Thread.Sleep(800);
                if (Globals.BossName == "ravana")
                {
                   
                    if (BattleOption == 0 || BattleOption == 1)
                    {

                        EnemyFightFormula();
                    }

                    if (BattleOption == 2)
                    {

                        EnemyFightFormula();
                        EnemyFightFormula();
                    }


                }
                if (Globals.BossName == "mon_22")
                {
                    
                    if (BattleOption == 0 || BattleOption == 1)
                    {
                        EnemyFightFormula();
                    }

                    if (BattleOption == 2)
                    {

                        EnemyDoom();
                       
                    }


                }
                if (Globals.BossName == "Atomos")
                {

                    if (BattleOption == 0)
                    {
                        EnemyFightFormula();
                    }

                    if (BattleOption == 1)
                    {

                        EnemyDoom();

                    }
                    if (BattleOption == 2)
                    {
                        if (Globals.BellyFull == true)
                        {
                            EnemyFightFormula();
                        }
                        if (Globals.BellyFull == false)
                        {
                            AtomosConsume();
                        }
                        

                    }


                }
                if (Globals.BossName == "Emporer")
                {
                    Random ran2 = new Random();
                    int BossOption = ran2.Next(0, Globals.BossTech.Length);
                    //BossOption = 4;
                    if (BossOption == 0)
                    {
                        //do nothing
                    }

                    if(BossOption == 1)
                    {
                        
                        EnemyFightFormula();
                    }

                    if (BossOption == 2)
                    {

                        EnemyFightFormula();
                        EnemyFightFormula();

                    }

                    if (BossOption == 3)
                    {

                        EnemyDoom();

                    }

                    if (BossOption == 4)
                    {

                        GrandCross();

                    }


                }
            }

            if (Globals.BossFight == false)
            {

                EnemyFightFormula();
            }

        }

        private void AtomosConsume()
        {
            Random random = new Random();
            int Target = random.Next(0, Globals.PartySize.Length);
            if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; }
            if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
            if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
            if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }
            if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; } //twice is nessacary
            if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
            if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
            if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }

            int lc = 0;
            if (Target == 0 && Globals.Player1InAir == false)
            {
                

                while (lc < 20)
                {
                    Player1.Location = new Point(Player1.Location.X - 20, Player1.Location.Y + 2);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player1.Location = new Point(Player1.Location.X + 10, Player1.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }
                while (lc < 32)
                {
                    Player1.Location = new Point(Player1.Location.X - 21, Player1.Location.Y + 4);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player1.Location = new Point(Player1.Location.X + 10, Player1.Location.Y) ;
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }


                //anim

                Globals.Player1IsDead = true;
                Player1Died();
                this.Player1.Visible = false;
                Globals.BellyFull = true;
            }

            if (Target == 1 && Globals.Player2InAir == false)
            {

                while (lc < 20)
                {
                    Player2.Location = new Point(Player2.Location.X - 20, Player2.Location.Y + 2);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player2.Location = new Point(Player2.Location.X + 10, Player2.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }
                while (lc < 32)
                {
                    Player2.Location = new Point(Player2.Location.X - 21, Player2.Location.Y + 1);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player2.Location = new Point(Player2.Location.X + 10, Player2.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }


                //anim

                Globals.Player2IsDead = true;
                Player2Died();
                this.Player2.Visible = false;
                Globals.BellyFull = true;
            }

            if (Target == 2 && Globals.Player3InAir == false)
            {
                while (lc < 40)
                {
                    Player3.Location = new Point(Player3.Location.X - 20, Player3.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player3.Location = new Point(Player3.Location.X + 10, Player3.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }
                while (lc < 12)
                {
                    Player3.Location = new Point(Player3.Location.X - 21, Player3.Location.Y -1);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player3.Location = new Point(Player3.Location.X + 10, Player3.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }
                //anim

                Globals.Player3IsDead = true;
                Player3Died();
                this.Player3.Visible = false;
                Globals.BellyFull = true;
            }

            if (Target == 3 && Globals.Player4InAir == false)
            {

                while (lc < 20)
                {
                    Player4.Location = new Point(Player4.Location.X - 20, Player4.Location.Y - 1);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player4.Location = new Point(Player4.Location.X + 10, Player4.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }
                while (lc < 37)
                {
                    Player4.Location = new Point(Player4.Location.X - 22, Player4.Location.Y - 1);
                    this.Refresh();
                    Thread.Sleep(15);
                    Player4.Location = new Point(Player4.Location.X + 10, Player4.Location.Y);
                    this.Refresh();
                    Thread.Sleep(15);
                    lc++;
                }

                //anim

                Globals.Player4IsDead = true;
                Player4Died();
                this.Player4.Visible = false;
                Globals.BellyFull = true;
            }
            PartyDeathCheck();
        }

        private void GrandCross()
        {
            
            Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width + 5, this.Enemy1.Location.Y );
            Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.gc1.Width, global::ffgameRedux.Properties.Resources.gc1.Height);
            Gameweapon.Visible = true;
            
            while (Gameweapon.Location.X < 810)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 15, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 15, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 15, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 15, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                
            }
            while (Gameweapon.Location.X > this.Enemy1.Location.X + this.Enemy1.Width + 64)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 25, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 25, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 25, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 25, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);


            }
            while (Gameweapon.Location.X < 810)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 35, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 35, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 35, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 35, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);


            }
            #region  playerDMG
            if (Globals.Player1InAir == false)
            {

               
                if (Globals.Player1Name == "Luneth")
                {

                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();



                }

                if (Globals.Player1Name == "Warrior")
                {
                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.war_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player1Name == "Thief")
                {
                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player1Name == "Cid")
                {
                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player1Name == "Rydia")
                {
                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player1Name == "Edgar")
                {
                    this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                    this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                    this.Refresh();

                }

            }
            if (Globals.Player2InAir == false)
            {

                
                if (Globals.Player2Name == "Luneth")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();



                }

                if (Globals.Player2Name == "Warrior")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.war_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player2Name == "Thief")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player2Name == "Cid")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player2Name == "Rydia")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player2Name == "Edgar")
                {
                    this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                    this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                    this.Refresh();

                }

            }
            if (Globals.Player3InAir == false)
            {

                
                if (Globals.Player3Name == "Luneth")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();



                }

                if (Globals.Player3Name == "Warrior")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.war_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player3Name == "Thief")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player3Name == "Cid")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player3Name == "Rydia")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player3Name == "Edgar")
                {
                    this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                    this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                    this.Refresh();

                }

            }
            if (Globals.Player4InAir == false)
            {

               
                if (Globals.Player4Name == "Luneth")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();



                }

                if (Globals.Player4Name == "Warrior")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.war_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player4Name == "Thief")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player4Name == "Cid")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();

                }

                if (Globals.Player4Name == "Rydia")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();

                }
                if (Globals.Player4Name == "Edgar")
                {
                    this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                    this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                    this.Refresh();

                }
            }

            #endregion //dmg anim
            while (Gameweapon.Location.X > this.Enemy1.Location.X + this.Enemy1.Width + 164)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);


            }
            while (Gameweapon.Location.X < 810)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 75, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 75, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 75, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 75, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);
                

            }

            while (Gameweapon.Location.X > this.Enemy1.Location.X + this.Enemy1.Width + 220)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(2);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(2);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(2);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X - 45, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(2);


            }
            while (Gameweapon.Location.X < 810)
            {
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc4;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 115, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc3;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 115, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc2;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 115, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X + 2, this.Location.Y - 2);
                this.Refresh();
                Thread.Sleep(5);

                Gameweapon.Image = global::ffgameRedux.Properties.Resources.gc1;
                Gameweapon.Location = new Point(Gameweapon.Location.X + 115, Gameweapon.Location.Y);
                this.Location = new Point(this.Location.X - 2, this.Location.Y + 2);
                this.Refresh();
                Thread.Sleep(5);


            }

            Thread.Sleep(400);
            int BaseDMG = 64 * Globals.PartySize.Length;
            Globals.Player1HP = Globals.Player1HP - BaseDMG;
            Globals.Player2HP = Globals.Player2HP - BaseDMG;
            Globals.Player3HP = Globals.Player3HP - BaseDMG;
            Globals.Player4HP = Globals.Player4HP - BaseDMG;

            if (Globals.Player1HP <= 0) { Globals.Player1HP = 0; }
            this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
            ResetPlayer1Position();
            if (Globals.Player1HP == 0) { Player1Died(); }

            if (Globals.Player2HP <= 0) { Globals.Player2HP = 0; }
            this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
            ResetPlayer2Position();
            if (Globals.Player2HP == 0) { Player2Died(); }

            if (Globals.Player3HP <= 0) { Globals.Player3HP = 0; }
            this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
            ResetPlayer3Position();
            if (Globals.Player3HP == 0) { Player3Died(); }

            if (Globals.Player4HP <= 0) { Globals.Player4HP = 0; }
            this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
            ResetPlayer4Position();
            if (Globals.Player4HP == 0) { Player4Died(); }

            PartyDeathCheck();
            Thread.Sleep(100);
        }

        private void P1FightFormula()
        {
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);


            if (Globals.Player1Name == "Luneth") {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;

                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0) {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    
                
                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player1Name == "Warrior")
            {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player1Name == "Thief")
            {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player1Name == "Cid")
            {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player1Name == "Rydia")
            {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player1Name == "Edgar")
            {

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            ResetPlayer1Position();
            this.Refresh();
            Thread.Sleep(540);
        }

        private void P2FightFormula()
        {
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);

            if (Globals.Player2Name == "Luneth")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;

                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                  

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player2Name == "Warrior")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player2Name == "Thief")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player2Name == "Cid")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player2Name == "Rydia")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player2Name == "Edgar")
            {

                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player2Attack + 1 + Globals.Floor;
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            ResetPlayer2Position();
            this.Refresh();
            Thread.Sleep(540);
        }

        private void P3FightFormula()
        {
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);

            if (Globals.Player3Name == "Luneth")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;

                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();


                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player3Name == "Warrior")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player3Name == "Thief")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();


                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player3Name == "Cid")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();


                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player3Name == "Rydia")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player3Name == "Edgar")
            {

                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player3Attack + 1 + Globals.Floor;
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            ResetPlayer3Position();
            this.Refresh();
            Thread.Sleep(540);
        }

        private void P4FightFormula()
        {
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);


            if (Globals.Player4Name == "Luneth")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player4Attack + 1 + Globals.Floor;

                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();


                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player4Name == "Warrior")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                // DMG Step
                int BaseDMG = Globals.Player4Attack + 1 + Globals.Floor;
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player4Name == "Thief")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player4Attack + 1 + Globals.Floor;
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player4Name == "Cid")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player1Attack + 1 + Globals.Floor;
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player4Name == "Rydia")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player4Attack + 1 + Globals.Floor;
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            if (Globals.Player4Name == "Edgar")
            {

                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                // DMG Step
                int BaseDMG = Globals.Player4Attack + 1 + Globals.Floor;
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

                Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                this.Text = Convert.ToString(Globals.EnemyHP);
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            }
            ResetPlayer4Position();
            this.Refresh();
            Thread.Sleep(540);
        }

        private void EnemyFightFormula() {

            Random random = new Random();
            int Target = random.Next(0, Globals.PartySize.Length);

                
                if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; }
                if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
                if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
                if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }
                if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; } //twice is nessacary
                if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
                if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
                if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }

            this.Gameweapon.Size = new Size(33, 48);
            if (Target == 0)
            {
                if (Globals.Player1InAir == false)
                {
                    this.Gameweapon.Location = new Point(this.Player1.Location.X - 54, this.Player1.Location.Y);
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_scratch;
                    this.Gameweapon.Visible = true;
                    this.Gameweapon.Refresh();
                    Thread.Sleep(300);
                    this.Gameweapon.Visible = false;
                    if (Globals.Player1Name == "Luneth")
                    {

                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);


                    }

                    if (Globals.Player1Name == "Warrior")
                    {
                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.war_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player1Name == "Thief")
                    {
                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player1Name == "Cid")
                    {
                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player1Name == "Rydia")
                    {
                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player1Name == "Edgar")
                    {
                        this.Player1.Image = this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                        this.Player1.Location = new Point(this.Player1.Location.X + 40, this.Player1.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    Globals.Player1HP = Globals.Player1HP - Globals.EnemyAttack + Globals.Floor - Globals.Player1Defense;
                    if (Globals.Player1HP <= 0) { Globals.Player1HP = 0; }
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                    ResetPlayer1Position();
                    if (Globals.Player1HP == 0) { Player1Died(); }
                }
            }
            if (Target == 1)
            {
                if (Globals.Player2InAir == false)
                {
                    this.Gameweapon.Location = new Point(this.Player2.Location.X - 54, this.Player2.Location.Y);
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_scratch;
                    this.Gameweapon.Visible = true;
                    this.Gameweapon.Refresh();
                    Thread.Sleep(300);
                    this.Gameweapon.Visible = false;
                    if (Globals.Player2Name == "Luneth")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);


                    }

                    if (Globals.Player2Name == "Warrior")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.war_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player2Name == "Thief")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player2Name == "Cid")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player2Name == "Rydia")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player2Name == "Edgar")
                    {
                        this.Player2.Image = this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                        this.Player2.Location = new Point(this.Player2.Location.X + 40, this.Player2.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    Globals.Player2HP = Globals.Player2HP - Globals.EnemyAttack + Globals.Floor - Globals.Player2Defense;
                    if (Globals.Player2HP <= 0) { Globals.Player2HP = 0; }
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    ResetPlayer2Position();
                    if (Globals.Player2HP == 0) { Player2Died(); }
                }
            }
            if (Target == 2)
            {
                if (Globals.Player3InAir == false)
                {
                    this.Gameweapon.Location = new Point(this.Player3.Location.X - 54, this.Player3.Location.Y);
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_scratch;
                    this.Gameweapon.Visible = true;
                    this.Gameweapon.Refresh();
                    Thread.Sleep(300);
                    this.Gameweapon.Visible = false;
                    if (Globals.Player3Name == "Luneth")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);


                    }

                    if (Globals.Player3Name == "Warrior")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.war_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player3Name == "Thief")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player3Name == "Cid")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player3Name == "Rydia")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    if (Globals.Player3Name == "Edgar")
                    {
                        this.Player3.Image = this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                        this.Player3.Location = new Point(this.Player3.Location.X + 40, this.Player3.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }
                    Globals.Player3HP = Globals.Player3HP - Globals.EnemyAttack + Globals.Floor - Globals.Player3Defense;
                    if (Globals.Player3HP <= 0) { Globals.Player3HP = 0; }
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    ResetPlayer3Position();
                    if (Globals.Player3HP == 0) { Player3Died(); }
                }
            }
            if (Target == 3)
            {
                if (Globals.Player4InAir == false)
                {
                    this.Gameweapon.Location = new Point(this.Player4.Location.X - 54, this.Player4.Location.Y);
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_scratch;
                    this.Gameweapon.Visible = true;
                    this.Gameweapon.Refresh();
                    Thread.Sleep(300);
                    this.Gameweapon.Visible = false;
                    if (Globals.Player4Name == "Luneth")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);


                    }

                    if (Globals.Player4Name == "Warrior")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.war_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player4Name == "Thief")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player4Name == "Cid")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player4Name == "Rydia")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    if (Globals.Player4Name == "Edgar")
                    {
                        this.Player4.Image = this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_h;
                        this.Player4.Location = new Point(this.Player4.Location.X + 40, this.Player4.Location.Y);
                        this.Refresh();
                        Thread.Sleep(700);
                    }

                    Globals.Player4HP = Globals.Player4HP - Globals.EnemyAttack + Globals.Floor - Globals.Player4Defense;
                    if (Globals.Player4HP <= 0) { Globals.Player4HP = 0; }
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    ResetPlayer4Position();
                    if (Globals.Player4HP == 0) { Player4Died(); }
                }
            }
            PartyDeathCheck();
        }

        private void EnemyDoom() {

            Random random = new Random();
            int Target = random.Next(0, Globals.PartySize.Length);


            if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; }
            if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
            if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
            if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }
            if ((Target == 0) && (Globals.Player1IsDead == true)) { Target = 1; } //twice is nessacary
            if ((Target == 1) && (Globals.Player2IsDead == true)) { Target = 2; }
            if ((Target == 2) && (Globals.Player3IsDead == true)) { Target = 3; }
            if ((Target == 3) && (Globals.Player4IsDead == true)) { Target = 0; }

            

            this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.doom.Width, global::ffgameRedux.Properties.Resources.doom.Height);
            if (Target == 0)
            {
                if (Globals.Player1InAir == false)
                {
                    Gameweapon.Image = global::ffgameRedux.Properties.Resources.doom;
                    Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width + 1, this.Player1.Location.Y-2);
                    Gameweapon.Visible = true;
                    this.Refresh();

                   
                    int animspeed = 8;
                    while (this.Player1.Location.Y >= -192)
                    {
                        this.Player1.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y - animspeed);
                        this.Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width + 1, this.Player1.Location.Y - 2);
                        this.Refresh();
                        Thread.Sleep(10);
                    }
                    ResetPlayer1Position();
                    Globals.Player1IsDead = true;
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + "0" + "/ " + Convert.ToString(Globals.Player1MaxHP));

                    Player1Died();

                }

            }
            if (Target == 1)
            {
                if (Globals.Player2InAir == false)
                {
                    Gameweapon.Image = global::ffgameRedux.Properties.Resources.doom;
                    Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width + 1, this.Player2.Location.Y - 2);
                    Gameweapon.Visible = true;
                    this.Refresh();


                    int animspeed = 8;
                    while (this.Player2.Location.Y >= -192)
                    {
                        this.Player2.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y - animspeed);
                        this.Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width + 1, this.Player2.Location.Y - 2);
                        this.Refresh();
                        Thread.Sleep(10);
                    }
                    ResetPlayer2Position();
                    Globals.Player2IsDead = true;
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + "0" + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    Player2Died();

                }

            }
            if (Target == 2)
            {
                if (Globals.Player3InAir == false)
                {
                    Gameweapon.Image = global::ffgameRedux.Properties.Resources.doom;
                    Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width + 1, this.Player3.Location.Y - 2);
                    Gameweapon.Visible = true;
                    this.Refresh();


                    int animspeed = 8;
                    while (this.Player3.Location.Y >= -192)
                    {
                        this.Player3.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y - animspeed);
                        this.Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width + 1, this.Player3.Location.Y - 2);
                        this.Refresh();
                        Thread.Sleep(10);
                    }
                    ResetPlayer3Position();
                    Globals.Player3IsDead = true;
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + "0" + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    Player3Died();

                }

            }
            if (Target == 3)
            {
                if (Globals.Player4InAir == false)
                {
                    Gameweapon.Image = global::ffgameRedux.Properties.Resources.doom;
                    Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width + 1, this.Player4.Location.Y - 2);
                    Gameweapon.Visible = true;
                    this.Refresh();


                    int animspeed = 8;
                    while (this.Player4.Location.Y >= -192)
                    {
                        this.Player4.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y - animspeed);
                        this.Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width + 1, this.Player4.Location.Y - 2);
                        this.Refresh();
                        Thread.Sleep(10);
                    }
                    ResetPlayer4Position();
                    Globals.Player4IsDead = true;
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + "0" + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    Player4Died();

                }

            }
            PartyDeathCheck();
        }

        private void LoadNextFloor()
        {




            // dance anim

            #region dance Anim
            int DanceCooldown = 300;
            if (Globals.Player1IsDead == false)
            {
                
                if (Globals.Player1Name == "Luneth")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_w;    
                }

                if (Globals.Player1Name == "Warrior")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player1Name == "Thief")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player1Name == "Cid")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player1Name == "Rydia")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player1Name == "Edgar")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player2IsDead == false)
            {

                if (Globals.Player2Name == "Luneth")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player2Name == "Warrior")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player2Name == "Thief")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player2Name == "Cid")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player2Name == "Rydia")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player2Name == "Edgar")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player3IsDead == false)
            {

                if (Globals.Player3Name == "Luneth")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player3Name == "Warrior")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player3Name == "Thief")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player3Name == "Cid")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player3Name == "Rydia")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player3Name == "Edgar")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player4IsDead == false)
            {

                if (Globals.Player4Name == "Luneth")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player4Name == "Warrior")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player4Name == "Thief")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player4Name == "Cid")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player4Name == "Rydia")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player4Name == "Edgar")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);
            if (Globals.Player1IsDead == false)
            {
                ResetPlayer1Position();
                
            }
            if (Globals.Player2IsDead == false)
            {
                ResetPlayer2Position();

            }
            if (Globals.Player3IsDead == false)
            {
                ResetPlayer3Position();

            }
            if (Globals.Player4IsDead == false)
            {
                ResetPlayer4Position();

            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);
            if (Globals.Player1IsDead == false)
            {

                if (Globals.Player1Name == "Luneth")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player1Name == "Warrior")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player1Name == "Thief")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player1Name == "Cid")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player1Name == "Rydia")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player1Name == "Edgar")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player2IsDead == false)
            {

                if (Globals.Player2Name == "Luneth")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player2Name == "Warrior")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player2Name == "Thief")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player2Name == "Cid")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player2Name == "Rydia")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player2Name == "Edgar")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player3IsDead == false)
            {

                if (Globals.Player3Name == "Luneth")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player3Name == "Warrior")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player3Name == "Thief")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player3Name == "Cid")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player3Name == "Rydia")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player3Name == "Edgar")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player4IsDead == false)
            {

                if (Globals.Player4Name == "Luneth")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player4Name == "Warrior")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player4Name == "Thief")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player4Name == "Cid")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player4Name == "Rydia")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player4Name == "Edgar")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);
            if (Globals.Player1IsDead == false)
            {
                ResetPlayer1Position();

            }
            if (Globals.Player2IsDead == false)
            {
                ResetPlayer2Position();

            }
            if (Globals.Player3IsDead == false)
            {
                ResetPlayer3Position();

            }
            if (Globals.Player4IsDead == false)
            {
                ResetPlayer4Position();

            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);
            #endregion DanceAnim


            if (Globals.Floor > 6) {
                int[] F6HP = {13,17,20,23,27,31 };
                int[] F6SP = { 4,5,6,7,8,9 };

                Globals.HPUpPool = F6HP;
                Globals.StatUpPool = F6SP;
                
                
              
            }

            if (Globals.Floor > 13)
            {
                int[] F14HP = { 21, 29, 38, 46, 43, 51 };
                int[] F14SP = { 7, 8, 9, 10, 11, 12 };

                Globals.HPUpPool = F14HP;
                Globals.StatUpPool = F14SP;



            }

            if (Globals.Floor > 21)
            {
                int[] F21HP = { 43, 50, 57, 67, 76, 84 };
                int[] F21SP = { 11, 12, 13, 14, 15, 18 };

                Globals.HPUpPool = F21HP;
                Globals.StatUpPool = F21SP;



            }

            #region stat ups
            Random ran = new Random();

            int RIndex;
            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player1MaxHP = Globals.Player1MaxHP + Globals.HPUpPool[RIndex];
            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player1MaxMP = Globals.Player1MaxMP + Globals.HPUpPool[RIndex] / 4;



            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player1Attack = Globals.Player1Attack + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player1Defense = Globals.Player1Defense + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player1Speed = Globals.Player1Speed + Globals.StatUpPool[RIndex] / 2;

            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player2MaxHP = Globals.Player2MaxHP + Globals.HPUpPool[RIndex];
            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player2MaxMP = Globals.Player2MaxMP + Globals.HPUpPool[RIndex] / 4;

            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player2Attack = Globals.Player2Attack + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player2Defense = Globals.Player2Defense + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player2Speed = Globals.Player2Speed + Globals.StatUpPool[RIndex] / 2;

            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player3MaxHP = Globals.Player3MaxHP + Globals.HPUpPool[RIndex];
            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player3MaxMP = Globals.Player3MaxMP + Globals.HPUpPool[RIndex] / 4;

            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player3Attack = Globals.Player3Attack + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player3Defense = Globals.Player3Defense + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player3Speed = Globals.Player3Speed + Globals.StatUpPool[RIndex] / 2;

            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player4MaxHP = Globals.Player4MaxHP + Globals.HPUpPool[RIndex];
            RIndex = ran.Next(0, Globals.HPUpPool.Length);
            Globals.Player4MaxMP = Globals.Player4MaxMP + Globals.HPUpPool[RIndex] / 4;

            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player4Attack = Globals.Player4Attack + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player4Defense = Globals.Player4Defense + Globals.StatUpPool[RIndex];
            RIndex = ran.Next(0, Globals.StatUpPool.Length);
            Globals.Player4Speed = Globals.Player4Speed + Globals.StatUpPool[RIndex] / 2;

            this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + " / " + Convert.ToString(Globals.Player1MaxHP));
            this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + " / " + Convert.ToString(Globals.Player2MaxHP));
            this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + " / " + Convert.ToString(Globals.Player3MaxHP));
            this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + " / " + Convert.ToString(Globals.Player4MaxHP));

            this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
            this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
            this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
            this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);


            
            this.PartyScore.Text = ("Party Score: " + (Globals.Floor * 2 + 1));
            #endregion

            Globals.Floor++;
            if (Globals.Floor == 1)
            {
                
                // load new enemy
                Globals.EnemyAttack = 8;
                Globals.EnemyHP = 60;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_2;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_2.Width, global::ffgameRedux.Properties.Resources.mon_2.Height);
                this.Enemy1.Visible = true;
               
            }
            if (Globals.Floor == 2)
            {
                
                // load new enemy
                Globals.EnemyAttack = 11;
                Globals.EnemyHP = 70;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_3;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_3.Width, global::ffgameRedux.Properties.Resources.mon_3.Height);
                this.Enemy1.Visible = true;
                
            }
            if (Globals.Floor == 3)
            {
                MusicShift();
                // load new enemy
                Globals.EnemyAttack = 12;
                Globals.EnemyHP = 80;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_4;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_4.Width, global::ffgameRedux.Properties.Resources.mon_4.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 4)
            {

                // load new enemy
                Globals.EnemyAttack = 14;
                Globals.EnemyHP = 105;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_5;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_5.Width, global::ffgameRedux.Properties.Resources.mon_5.Height);
                this.Enemy1.Visible = true;
                

            }
            if (Globals.Floor == 5)
            {

                // load new enemy
                Globals.EnemyAttack = 20;
                Globals.EnemyHP = 170;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_6;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_6.Width, global::ffgameRedux.Properties.Resources.mon_6.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 6)
            {
               
                MusicShift();
                Globals.BossFight = true;
                // load new enemy
                Globals.EnemyAttack = 25;
                Globals.EnemyHP = 500;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_lich;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_lich.Width, global::ffgameRedux.Properties.Resources.mon_lich.Height);
                this.Enemy1.Location = new Point(this.Enemy1.Location.X + 15, this.Enemy1.Location.Y - 50);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 7)
            {
                Globals.Rank = "D";
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                this.Background.Image = global::ffgameRedux.Properties.Resources.bg1;
                MusicShift();
                Globals.BossFight = false;
                
                Globals.EnemyAttack = 22;
                Globals.EnemyHP = 220;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X + 30, this.Enemy1.Location.Y); //edits from fllor 6
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_7;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_7.Width, global::ffgameRedux.Properties.Resources.mon_7.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 8)
            {

                // load new enemy
                Globals.EnemyAttack = 24;
                Globals.EnemyHP = 270;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_8;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_8.Width, global::ffgameRedux.Properties.Resources.mon_8.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 9)
            {

                // load new enemy
                Globals.EnemyAttack = 30;
                Globals.EnemyHP = 300;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_9;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_9.Width, global::ffgameRedux.Properties.Resources.mon_9.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 10)
            {

                // load new enemy
                Globals.EnemyAttack = 32;
                Globals.EnemyHP = 340;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_10;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X + 30, this.Enemy1.Location.Y); //edits from fllor 7

                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_10.Width, global::ffgameRedux.Properties.Resources.mon_10.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 11)
            {

                // load new enemy
                Globals.EnemyAttack = 38;
                Globals.EnemyHP = 400;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_11;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X - 20, this.Enemy1.Location.Y); //edits from fllor 10
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_11.Width, global::ffgameRedux.Properties.Resources.mon_11.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 12)
            {

                // load new enemy
                Globals.EnemyAttack = 40;
                Globals.EnemyHP = 430;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_12;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_12.Width, global::ffgameRedux.Properties.Resources.mon_12.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 13)
            {
                Globals.Rank = "C";
                MusicShift();
                Globals.BossFight = true;
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 50;
                Globals.EnemyHP = 900;
                Globals.BossName = "ravana";
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_ravana;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X - 20, this.Enemy1.Location.Y + 40); //edits from fllor 10

                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_ravana.Width, global::ffgameRedux.Properties.Resources.mon_ravana.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 14)
            {
                this.Background.Image = global::ffgameRedux.Properties.Resources.bg2;
                MusicShift();
                Globals.BossFight = false;
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 42;
                Globals.EnemyHP = 500;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_13;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X + 20, this.Enemy1.Location.Y - 50); //edits from fllor 10

                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_13.Width, global::ffgameRedux.Properties.Resources.mon_13.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 15)
            {
                
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 50;
                Globals.EnemyHP = 670;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_14;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_14.Width, global::ffgameRedux.Properties.Resources.mon_14.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 16)
            {

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 50;
                Globals.EnemyHP = 690;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_15;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_15.Width, global::ffgameRedux.Properties.Resources.mon_15.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 17)
            {

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 60;
                Globals.EnemyHP = 790;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_16;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_16.Width, global::ffgameRedux.Properties.Resources.mon_16.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 18)
            {

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 72;
                Globals.EnemyHP = 900;
                this.Enemy1.Location = new Point(Enemy1.Location.X + 28, Enemy1.Location.Y-20);
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_17;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_17.Width, global::ffgameRedux.Properties.Resources.mon_17.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 19)
            {

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 81;
                Globals.EnemyHP = 1200;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_18;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_18.Width, global::ffgameRedux.Properties.Resources.mon_18.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 20)
            {
                Globals.Rank = "B";
                MusicShift();
                Globals.BossFight = true;
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 99;
                Globals.EnemyHP = 2200;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_wraith;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X - 20, this.Enemy1.Location.Y - 20); //edits from fllor 10

                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_wraith.Width, global::ffgameRedux.Properties.Resources.mon_wraith.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 21)
            {
                MusicShift();
                Globals.BossFight = false;
                this.Background.Image = global::ffgameRedux.Properties.Resources.bg3;
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 72;
                Globals.EnemyHP = 1500;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_19;
                this.Enemy1.Location = new Point(Enemy1.Location.X + 28, Enemy1.Location.Y);
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_19.Width, global::ffgameRedux.Properties.Resources.mon_18.Height);
                this.Enemy1.Visible = true;
            }
            if (Globals.Floor == 22)
            {

                
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 90;
                Globals.EnemyHP = 1900;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_20;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_20.Width, global::ffgameRedux.Properties.Resources.mon_20.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 23)
            {
              
               
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy
                Globals.EnemyAttack = 101;
                Globals.EnemyHP = 2200;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_21;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_21.Width, global::ffgameRedux.Properties.Resources.mon_21.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 24)
            {
                //workaround for skills
                Globals.BossFight = true;
                Globals.BossName = "mon_22";
               
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 80;
                Globals.EnemyHP = 2600;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_22;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_22.Width, global::ffgameRedux.Properties.Resources.mon_21.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 25)
            {
                Globals.Rank = "A";
                MusicShift();
                //workaround for skills
                Globals.BossFight = true;
                Globals.BossName = "Atomos";

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 80;
                Globals.EnemyHP = 3200;
                this.Enemy1.Location = new Point(this.Enemy1.Location.X+7,this.Enemy1.Location.Y +3);
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_atomos;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_atomos.Width, global::ffgameRedux.Properties.Resources.mon_atomos.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 26)
            {
                //workaround for skills
                Globals.BossFight = false;

                this.Background.Image = global::ffgameRedux.Properties.Resources.bg4;
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 132;
                Globals.EnemyHP = 2000;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_23;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_23.Width, global::ffgameRedux.Properties.Resources.mon_23.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 27)
            {
                //workaround for skills
                Globals.BossFight = false;

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 148;
                Globals.EnemyHP = 2400;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_24;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_24.Width, global::ffgameRedux.Properties.Resources.mon_24.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 28)
            {
                //workaround for skills
                Globals.BossFight = false;

              
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 167;
                Globals.EnemyHP = 2800;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_25;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_25.Width, global::ffgameRedux.Properties.Resources.mon_25.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 29)
            {
                MusicShift();
                //workaround for skills
                Globals.BossFight = false;

           
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 192;
                Globals.EnemyHP = 3300;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_26;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_26.Width, global::ffgameRedux.Properties.Resources.mon_26.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 30)
            {
                //workaround for skills
                Globals.BossFight = false;

              
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 212;
                Globals.EnemyHP = 3601;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_27;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_27.Width, global::ffgameRedux.Properties.Resources.mon_27.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 31)
            {
                //workaround for skills
                Globals.BossFight = false;
                Globals.Rank = "S";

                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 250;
                Globals.EnemyHP = 4001;
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_28;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_28.Width, global::ffgameRedux.Properties.Resources.mon_28.Height);
                this.Enemy1.Visible = true;

            }
            if (Globals.Floor == 32)
            {
                this.Background.Image = global::ffgameRedux.Properties.Resources.bgFinal;
              
                MusicShift();
                //workaround for skills
                Globals.BossFight = true;
                Globals.BossName = "Emporer";
                TentFormula();
                this.PartyRank.Text = ("Party Rank: " + Globals.Rank);
                // load new enemy

                Globals.EnemyAttack = 320;
                Globals.EnemyHP = 7500;
                
                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.mon_emp;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.mon_emp.Width, global::ffgameRedux.Properties.Resources.mon_emp.Height);
                this.Enemy1.Visible = true;
                FinalBossIntro();
                this.Enemy1.Location = new Point(80, 115); //comment me out later

            }


            // SECRERT JOE BIDEN BOSS FIGHT

            if (Globals.Floor == 50)
            {
                this.Background.Image = global::ffgameRedux.Properties.Resources.bg5;

                MusicShift();
                //workaround for skills
                Globals.BossFight = true;
                Globals.BossName = "Sleepy Joe";
                TentFormula();
                this.PartyRank.Text = ("Party Rank: SSS");
                // load new enemy

                Globals.EnemyAttack = 570;
                Globals.EnemyHP = 800000;

                this.Enemy1.Image = global::ffgameRedux.Properties.Resources.Joe_Biden;
                this.Enemy1.Size = new Size(global::ffgameRedux.Properties.Resources.Joe_Biden.Width, global::ffgameRedux.Properties.Resources.Joe_Biden.Height);
                this.Enemy1.Visible = true;


                this.Enemy1.Location = new Point(80, 115); //comment me out later

            }

        } //load next floor

        private void FinalBossIntro()
        {
            this.Enemy1.Location = new Point(80, 451);
            while (this.Enemy1.Location.Y > 115)
            {
                this.Enemy1.Location = new Point(this.Enemy1.Location.X - 3, this.Enemy1.Location.Y - 2);
                this.Location = new Point(this.Location.X, this.Location.Y - 3);
                this.Refresh();
                Thread.Sleep(10);

                this.Enemy1.Location = new Point(this.Enemy1.Location.X + 3, this.Enemy1.Location.Y - 2);
                this.Location = new Point(this.Location.X, this.Location.Y + 3);
                this.Refresh();
                Thread.Sleep(10);
            } 
        }

        private void Player1Died()
        {
            this.Player1.Size = new Size(48, 32);
            this.Player1.Location = new Point(this.Player1.Location.X - 32, this.Player1.Location.Y + 25);
            if (Globals.Player1Name == "Luneth")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_d;
            }

            if (Globals.Player1Name == "Warrior")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_d;
            }

            if (Globals.Player1Name == "Thief")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_d;
            }

            if (Globals.Player1Name == "Cid")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_d;
            }

            if (Globals.Player1Name == "Rydia")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_d;
            }
            if (Globals.Player1Name == "Edgar")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_d;
            }

            Globals.Player1IsDead = true;
            this.Player1ActList.Enabled = false;
            this.Refresh();

        }

        private void Player2Died() {
            this.Player2.Size = new Size(48, 32);
            this.Player2.Location = new Point(this.Player2.Location.X - 32, this.Player2.Location.Y + 25);
            if (Globals.Player2Name == "Luneth")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_d;
            }

            if (Globals.Player2Name == "Warrior")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_d;
            }

            if (Globals.Player2Name == "Thief")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_d;
            }

            if (Globals.Player2Name == "Cid")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_d;
            }
            if (Globals.Player2Name == "Rydia")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_d;
            }
            if (Globals.Player2Name == "Edgar")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_d;
            }

            Globals.Player2IsDead = true;
            this.Player2ActList.Enabled = false;
            this.Refresh();

        }

        private void Player3Died()
        {
            this.Player3.Size = new Size(48, 32);
            this.Player3.Location = new Point(this.Player3.Location.X - 32, this.Player3.Location.Y + 25);
            if (Globals.Player3Name == "Luneth")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_d;
            }

            if (Globals.Player3Name == "Warrior")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_d;
            }

            if (Globals.Player3Name == "Thief")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_d;
            }

            if (Globals.Player3Name == "Cid")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_d;
            }
            if (Globals.Player3Name == "Rydia")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_d;
            }
            if (Globals.Player3Name == "Edgar")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_d;
            }

            Globals.Player3IsDead = true;
            this.Player3ActList.Enabled = false;
            this.Refresh();

        }

        private void Player4Died()
        {
            this.Player4.Size = new Size(48, 32);
            this.Player4.Location = new Point(this.Player4.Location.X - 32, this.Player4.Location.Y + 25);
            if (Globals.Player4Name == "Luneth")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_d;
            }

            if (Globals.Player4Name == "Warrior")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_d;
            }

            if (Globals.Player4Name == "Thief")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_d;
            }

            if (Globals.Player4Name == "Cid")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_d;
            }
            if (Globals.Player4Name == "Rydia")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_d;
            }
            if (Globals.Player4Name == "Edgar")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_d;
            }

            Globals.Player4IsDead = true;
            this.Player4ActList.Enabled = false;
            this.Refresh();

        }

        private void ResetPlayer1Position() {
            if (Globals.Player1Name == "Luneth")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
            }

            if (Globals.Player1Name == "Warrior")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            }

            if (Globals.Player1Name == "Thief")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
            }

            if (Globals.Player1Name == "Cid")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
            }

            if (Globals.Player1Name == "Rydia")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
            }
            if (Globals.Player1Name == "Edgar")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
            }
            this.Player1.Location = new System.Drawing.Point(600, 140);
        }

        private void ResetPlayer2Position()
        {
            if (Globals.Player2Name == "Luneth")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
            }

            if (Globals.Player2Name == "Warrior")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            }

            if (Globals.Player2Name == "Thief")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
            }

            if (Globals.Player2Name == "Cid")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
            }
            if (Globals.Player2Name == "Rydia")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
            }
            if (Globals.Player2Name == "Edgar")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
            }
            this.Player2.Location = new System.Drawing.Point(630, 200);
            this.Refresh();
        }

        private void ResetPlayer3Position()
        {
            if (Globals.Player3Name == "Luneth")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
            }

            if (Globals.Player3Name == "Warrior")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            }

            if (Globals.Player3Name == "Thief")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
            }

            if (Globals.Player3Name == "Cid")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
            }
            if (Globals.Player3Name == "Rydia")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
            }
            if (Globals.Player3Name == "Edgar")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
            }
            this.Player3.Location = new System.Drawing.Point(660, 260);
            this.Refresh();
        }

        private void ResetPlayer4Position()
        {
            if (Globals.Player4Name == "Luneth")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
            }

            if (Globals.Player4Name == "Warrior")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            }

            if (Globals.Player4Name == "Thief")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
            }

            if (Globals.Player4Name == "Cid")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
            }
            if (Globals.Player4Name == "Rydia")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
            }
            if (Globals.Player4Name == "Edgar")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
            }
            this.Player4.Location = new System.Drawing.Point(690, 320);
            this.Refresh();
        }

        private void PartyDeathCheck() {


            if ((Globals.Player1IsDead == true) && (Globals.Player2IsDead == true) && (Globals.Player3IsDead == true) && (Globals.Player4IsDead == true)) {
                this.EngageButton.Enabled = false;
                this.PlayerBackpack.Enabled = false;
                Globals.MusicPlayer.controls.stop();
                
                Globals.SongID = "data/deadsong.mp3";
                Globals.MusicPlayer.URL = Globals.SongID;
                Globals.MusicPlayer.controls.play();
             

            }

        }


        private void P1BlackMagicFormula() {
            if (Globals.Player1Name == "Luneth")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_w;
            }
            if (Globals.Player1Name == "Edgar")
            {
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_w;
            }
            this.Player1.Location = new Point(this.Player1.Location.X - 32, this.Player1.Location.Y);
            if (Globals.Player1MP <= 2)
            {
                this.Player1MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                ResetPlayer1Position();
            }

            if (Globals.Player1MP >= 3)
            {
                
               
                Random rand = new Random();
                int SelectedSpell = rand.Next(0, Globals.Spells.Length);
                int BaseDMG = 0;
                
                if (Globals.PlayerTurn == 1)
                {
                    // fire
                    if (SelectedSpell == 0)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.s_fire.Width, global::ffgameRedux.Properties.Resources.s_fire.Height);
                        this.SpellWeapon.Location = new Point(this.Enemy1.Size.Width / 8, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim
                        int CritVal = rand.Next(0, Globals.CritArray.Length);
                        int FireSpeed = 45;
                        if (FireSpeed > CritVal) { Globals.Player1Attack = Globals.Player1Attack * 2; }


                        BaseDMG = Globals.Player1Attack + Globals.Floor + Globals.Player1Speed / 2;

                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        this.Text = Convert.ToString(Globals.EnemyHP);
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                        if (FireSpeed > CritVal) { Globals.Player1Attack = Globals.Player1Attack / 2; }
                    }

                    // ice
                    if (SelectedSpell == 1)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.ice.Width, global::ffgameRedux.Properties.Resources.ice.Height);
                        this.SpellWeapon.Location = new Point(0, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice3;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim

                        BaseDMG = Globals.Player1Attack / 2 + Globals.EnemyAttack / 2 + Globals.Floor;
                        Globals.EnemyAttack--;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }
                        
                    }

                    // thinder
                    if (SelectedSpell == 2)
                    {
                        
                        this.Gameweapon.Size = new Size(32, 198);
                        this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width / 2, this.Enemy1.Location.Y - 199);
                        this.Gameweapon.Visible = true;
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit;
                        this.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit2;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit3;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(40);

                        this.SpellWeapon.Location = new Point(0, 0);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.lit4;
                        this.SpellWeapon.Size = new Size (this.Enemy1.Location.X + this.Enemy1.Size.Width / 4, this.Enemy1.Height);
                        this.SpellWeapon.Visible = true;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(400);
                        this.Gameweapon.Visible = false;
                        this.SpellWeapon.Visible = false;
                        //do speel anim


                        BaseDMG = Globals.Floor + Globals.Player1Attack + Globals.Player1Speed;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }
                    }

                    ResetPlayer1Position();
                    Globals.Player1MP = Globals.Player1MP - 3;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    this.Refresh();
                } 
                
            }
        
        }

        private void P2BlackMagicFormula()
        {
            if (Globals.Player2Name == "Luneth")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_w;
            }
            if (Globals.Player2Name == "Edgar")
            {
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_w;
            }
            this.Player2.Location = new Point(this.Player2.Location.X - 32, this.Player2.Location.Y);
            if (Globals.Player2MP <= 2)
            {
                this.Player2MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                ResetPlayer2Position();
            }

            if (Globals.Player2MP >= 3)
            {


                Random rand = new Random();
                int SelectedSpell = rand.Next(0, Globals.Spells.Length);
                int BaseDMG = 0;
                //SelectedSpell = 0;
                if (Globals.PlayerTurn == 2)
                {
                    // fire
                    if (SelectedSpell == 0)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.s_fire.Width, global::ffgameRedux.Properties.Resources.s_fire.Height);
                        this.SpellWeapon.Location = new Point(this.Enemy1.Size.Width / 8, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim
                        int CritVal = rand.Next(0, Globals.CritArray.Length);
                        int FireSpeed = 45;
                        if (FireSpeed > CritVal) { Globals.Player2Attack = Globals.Player2Attack * 2; }


                        BaseDMG = Globals.Player2Attack + Globals.Floor + Globals.Player2Speed / 2;

                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                        if (FireSpeed > CritVal) { Globals.Player2Attack = Globals.Player2Attack / 2; }
                    }

                    // ice
                    if (SelectedSpell == 1)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.ice.Width, global::ffgameRedux.Properties.Resources.ice.Height);
                        this.SpellWeapon.Location = new Point(0, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice3;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim

                        BaseDMG = Globals.Player2Attack / 2 + Globals.EnemyAttack / 2 + Globals.Floor;
                        Globals.EnemyAttack--;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                    }

                    // thinder
                    if (SelectedSpell == 2)
                    {

                        this.Gameweapon.Size = new Size(32, 198);
                        this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width / 2, this.Enemy1.Location.Y - 199);
                        this.Gameweapon.Visible = true;
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit;
                        this.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit2;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit3;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(40);

                        this.SpellWeapon.Location = new Point(0, 0);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.lit4;
                        this.SpellWeapon.Size = new Size(this.Enemy1.Location.X + this.Enemy1.Size.Width / 4, this.Enemy1.Height);
                        this.SpellWeapon.Visible = true;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(400);
                        this.Gameweapon.Visible = false;
                        this.SpellWeapon.Visible = false;
                        //do speel anim


                        BaseDMG = Globals.Floor + Globals.Player2Attack + Globals.Player2Speed;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }
                    }

                    ResetPlayer2Position();
                    Globals.Player2MP = Globals.Player2MP - 3;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    this.Refresh();
                }

            }

        }

        private void P3BlackMagicFormula()
        {
            if (Globals.Player3Name == "Luneth")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_w;
            }
            if (Globals.Player3Name == "Edgar")
            {
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_w;
            }
            this.Player3.Location = new Point(this.Player3.Location.X - 32, this.Player3.Location.Y);
            if (Globals.Player3MP <= 2)
            {
                this.Player3MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                ResetPlayer3Position();
            }

            if (Globals.Player3MP >= 3)
            {


                Random rand = new Random();
                int SelectedSpell = rand.Next(0, Globals.Spells.Length);
                int BaseDMG = 0;

                if (Globals.PlayerTurn == 3)
                {
                    // fire
                    if (SelectedSpell == 0)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.s_fire.Width, global::ffgameRedux.Properties.Resources.s_fire.Height);
                        this.SpellWeapon.Location = new Point(this.Enemy1.Size.Width / 8, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim
                        int CritVal = rand.Next(0, Globals.CritArray.Length);
                        int FireSpeed = 45;
                        if (FireSpeed > CritVal) { Globals.Player3Attack = Globals.Player3Attack * 2; }


                        BaseDMG = Globals.Player3Attack + Globals.Floor + Globals.Player3Speed / 2;

                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                        if (FireSpeed > CritVal) { Globals.Player3Attack = Globals.Player3Attack / 2; }
                    }

                    // ice
                    if (SelectedSpell == 1)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.ice.Width, global::ffgameRedux.Properties.Resources.ice.Height);
                        this.SpellWeapon.Location = new Point(0, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice3;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim

                        BaseDMG = Globals.Player3Attack / 2 + Globals.EnemyAttack / 2 + Globals.Floor;
                        Globals.EnemyAttack--;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                    }

                    // thinder
                    if (SelectedSpell == 2)
                    {

                        this.Gameweapon.Size = new Size(32, 198);
                        this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width / 2, this.Enemy1.Location.Y - 199);
                        this.Gameweapon.Visible = true;
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit;
                        this.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit2;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit3;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(40);

                        this.SpellWeapon.Location = new Point(0, 0);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.lit4;
                        this.SpellWeapon.Size = new Size(this.Enemy1.Location.X + this.Enemy1.Size.Width / 4, this.Enemy1.Height);
                        this.SpellWeapon.Visible = true;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(400);
                        this.Gameweapon.Visible = false;
                        this.SpellWeapon.Visible = false;
                        //do speel anim


                        BaseDMG = Globals.Floor + Globals.Player3Attack + Globals.Player3Speed;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }
                    }

                    ResetPlayer3Position();
                    Globals.Player3MP = Globals.Player3MP - 3;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    this.Refresh();
                }

            }

        }

        private void P4BlackMagicFormula()
        {
            if (Globals.Player4Name == "Luneth")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_w;
            }
            if (Globals.Player4Name == "Edgar")
            {
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_w;
            }
            this.Player4.Location = new Point(this.Player4.Location.X - 32, this.Player4.Location.Y);
            if (Globals.Player4MP <= 2)
            {
                this.Player4MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                ResetPlayer4Position();
            }

            if (Globals.Player4MP >= 3)
            {


                Random rand = new Random();
                int SelectedSpell = rand.Next(0, Globals.Spells.Length);
                int BaseDMG = 0;

                if (Globals.PlayerTurn == 4)
                {
                    // fire
                    if (SelectedSpell == 0)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.s_fire.Width, global::ffgameRedux.Properties.Resources.s_fire.Height);
                        this.SpellWeapon.Location = new Point(this.Enemy1.Size.Width / 8, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(85);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.s_fire;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim
                        int CritVal = rand.Next(0, Globals.CritArray.Length);
                        int FireSpeed = 45;
                        if (FireSpeed > CritVal) { Globals.Player4Attack = Globals.Player4Attack * 2; }


                        BaseDMG = Globals.Player4Attack + Globals.Floor + Globals.Player4Speed / 2;

                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                        if (FireSpeed > CritVal) { Globals.Player4Attack = Globals.Player4Attack / 2; }
                    }

                    // ice
                    if (SelectedSpell == 1)
                    {
                        this.SpellWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.ice.Width, global::ffgameRedux.Properties.Resources.ice.Height);
                        this.SpellWeapon.Location = new Point(0, 0);

                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Visible = true;
                        this.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice2;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.ice3;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(100);
                        this.SpellWeapon.Visible = false;
                        this.SpellWeapon.Location = new Point(0, 0);
                        //do speel anim

                        BaseDMG = Globals.Player4Attack / 2 + Globals.EnemyAttack / 2 + Globals.Floor;
                        Globals.EnemyAttack--;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }

                    }

                    // thinder
                    if (SelectedSpell == 2)
                    {

                        this.Gameweapon.Size = new Size(32, 198);
                        this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width / 2, this.Enemy1.Location.Y - 199);
                        this.Gameweapon.Visible = true;
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit;
                        this.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit2;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(20);
                        this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.lit3;
                        this.Gameweapon.Refresh();
                        Thread.Sleep(40);

                        this.SpellWeapon.Location = new Point(0, 0);
                        this.SpellWeapon.Image = global::ffgameRedux.Properties.Resources.lit4;
                        this.SpellWeapon.Size = new Size(this.Enemy1.Location.X + this.Enemy1.Size.Width / 4, this.Enemy1.Height);
                        this.SpellWeapon.Visible = true;
                        this.SpellWeapon.Refresh();
                        Thread.Sleep(400);
                        this.Gameweapon.Visible = false;
                        this.SpellWeapon.Visible = false;
                        //do speel anim


                        BaseDMG = Globals.Floor + Globals.Player4Attack + Globals.Player4Speed;
                        Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                        this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                        this.DMGLabel.Text = Convert.ToString(BaseDMG);
                        this.DMGLabel.Visible = true;
                        this.Refresh();
                        Thread.Sleep(600);
                        this.DMGLabel.Visible = false;
                        if (Globals.EnemyHP <= 0)
                        {
                            this.Enemy1.Visible = false;
                            Globals.EnemyHP = 0;
                            this.Refresh();


                        }
                    }

                    ResetPlayer4Position();
                    Globals.Player4MP = Globals.Player4MP - 3;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    this.Refresh();
                }

            }

        }

        private void P1WhiteMagicFormula()
        {

            this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_w;
            this.Player1.Location = new Point(this.Player1.Location.X - 32, this.Player1.Location.Y);
            if (Globals.Player1MP <= 4)
            {
                this.Player1MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                ResetPlayer1Position();
            }

            if (Globals.Player1MP >= 5)
            {
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.cure1;
                this.Gameweapon.Size = new Size(64, 64);
                if (Globals.Player1IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player1HP = Globals.Player1HP + Globals.Player1Attack * 2;
                    if (Globals.Player1HP > Globals.Player1MaxHP) { Globals.Player1HP = Globals.Player1MaxHP; }
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + " / " + Convert.ToString(Globals.Player1MaxHP));
                    Thread.Sleep(400);
                }
                if (Globals.Player2IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player2HP = Globals.Player2HP + Globals.Player2Attack * 2;
                    if (Globals.Player2HP > Globals.Player2MaxHP) { Globals.Player2HP = Globals.Player2MaxHP; }
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + " / " + Convert.ToString(Globals.Player2MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player3IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player3HP = Globals.Player3HP + Globals.Player3Attack * 2;
                    if (Globals.Player3HP > Globals.Player3MaxHP) { Globals.Player3HP = Globals.Player3MaxHP; }
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + " / " + Convert.ToString(Globals.Player3MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player4IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player4HP = Globals.Player4HP + Globals.Player4Attack * 2;
                    if (Globals.Player4HP > Globals.Player4MaxHP) { Globals.Player4HP = Globals.Player4MaxHP; }
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + " / " + Convert.ToString(Globals.Player4MaxHP));

                    Thread.Sleep(400);
                }

                Globals.Player1MP = Globals.Player1MP - 5;
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                this.Gameweapon.Visible = false;
                this.Gameweapon.Location = new Point(0,0);
               
                ResetPlayer1Position();
            }
        }

        private void P2WhiteMagicFormula()
        {

            this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_w;
            this.Player2.Location = new Point(this.Player2.Location.X - 32, this.Player2.Location.Y);
            if (Globals.Player2MP <= 4)
            {
                this.Player2MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                ResetPlayer2Position();
            }

            if (Globals.Player2MP >= 5)
            {
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.cure1;
                this.Gameweapon.Size = new Size(64, 64);
                if (Globals.Player1IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player1HP = Globals.Player1HP + Globals.Player1Attack * 2;
                    if (Globals.Player1HP > Globals.Player1MaxHP) { Globals.Player1HP = Globals.Player1MaxHP; }
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + " / " + Convert.ToString(Globals.Player1MaxHP));
                    Thread.Sleep(400);
                }
                if (Globals.Player2IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player2HP = Globals.Player2HP + Globals.Player2Attack * 2;
                    if (Globals.Player2HP > Globals.Player2MaxHP) { Globals.Player2HP = Globals.Player2MaxHP; }
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + " / " + Convert.ToString(Globals.Player2MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player3IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player3HP = Globals.Player3HP + Globals.Player3Attack * 2;
                    if (Globals.Player3HP > Globals.Player3MaxHP) { Globals.Player3HP = Globals.Player3MaxHP; }
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + " / " + Convert.ToString(Globals.Player3MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player4IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player4HP = Globals.Player4HP + Globals.Player4Attack * 2;
                    if (Globals.Player4HP > Globals.Player4MaxHP) { Globals.Player4HP = Globals.Player4MaxHP; }
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + " / " + Convert.ToString(Globals.Player4MaxHP));

                    Thread.Sleep(400);
                }

                Globals.Player2MP = Globals.Player2MP - 5;
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                this.Gameweapon.Visible = false;
                this.Gameweapon.Location = new Point(0, 0);
                ResetPlayer2Position();
            }
        }

        private void P3WhiteMagicFormula()
        {

            this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_w;
            this.Player3.Location = new Point(this.Player3.Location.X - 32, this.Player3.Location.Y);
            if (Globals.Player3MP <= 4)
            {
                this.Player3MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                ResetPlayer3Position();
            }

            if (Globals.Player3MP >= 5)
            {
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.cure1;
                this.Gameweapon.Size = new Size(64, 64);
                if (Globals.Player1IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player1HP = Globals.Player1HP + Globals.Player1Attack * 2;
                    if (Globals.Player1HP > Globals.Player1MaxHP) { Globals.Player1HP = Globals.Player1MaxHP; }
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + " / " + Convert.ToString(Globals.Player1MaxHP));
                    Thread.Sleep(400);
                }
                if (Globals.Player2IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player2HP = Globals.Player2HP + Globals.Player2Attack * 2;
                    if (Globals.Player2HP > Globals.Player2MaxHP) { Globals.Player2HP = Globals.Player2MaxHP; }
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + " / " + Convert.ToString(Globals.Player2MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player3IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player3HP = Globals.Player3HP + Globals.Player3Attack * 2;
                    if (Globals.Player3HP > Globals.Player3MaxHP) { Globals.Player3HP = Globals.Player3MaxHP; }
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + " / " + Convert.ToString(Globals.Player3MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player4IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player4HP = Globals.Player4HP + Globals.Player4Attack * 2;
                    if (Globals.Player4HP > Globals.Player4MaxHP) { Globals.Player4HP = Globals.Player4MaxHP; }
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + " / " + Convert.ToString(Globals.Player4MaxHP));

                    Thread.Sleep(400);
                }

                Globals.Player3MP = Globals.Player1MP - 5;
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                this.Gameweapon.Visible = false;
                this.Gameweapon.Location = new Point(0, 0);
                ResetPlayer3Position();
            }
        }

        private void P4WhiteMagicFormula()
        {

            this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_w;
            this.Player4.Location = new Point(this.Player4.Location.X - 32, this.Player4.Location.Y);
            if (Globals.Player4MP <= 4)
            {
                this.Player4MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                ResetPlayer4Position();
            }

            if (Globals.Player4MP >= 5)
            {
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.cure1;
                this.Gameweapon.Size = new Size(64, 64);
                if (Globals.Player1IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player1HP = Globals.Player1HP + Globals.Player1Attack * 2;
                    if (Globals.Player1HP > Globals.Player1MaxHP) { Globals.Player1HP = Globals.Player1MaxHP; }
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + " / " + Convert.ToString(Globals.Player1MaxHP));
                    Thread.Sleep(400);
                }
                if (Globals.Player2IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player2HP = Globals.Player2HP + Globals.Player2Attack * 2;
                    if (Globals.Player2HP > Globals.Player2MaxHP) { Globals.Player2HP = Globals.Player2MaxHP; }
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + " / " + Convert.ToString(Globals.Player2MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player3IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player3HP = Globals.Player3HP + Globals.Player3Attack * 2;
                    if (Globals.Player3HP > Globals.Player3MaxHP) { Globals.Player3HP = Globals.Player3MaxHP; }
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + " / " + Convert.ToString(Globals.Player3MaxHP));

                    Thread.Sleep(400);
                }
                if (Globals.Player4IsDead == false)
                {
                    this.Gameweapon.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Globals.Player4HP = Globals.Player4HP + Globals.Player4Attack * 2;
                    if (Globals.Player4HP > Globals.Player4MaxHP) { Globals.Player4HP = Globals.Player4MaxHP; }
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + " / " + Convert.ToString(Globals.Player4MaxHP));

                    Thread.Sleep(400);
                }

                Globals.Player4MP = Globals.Player1MP - 5;
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                this.Gameweapon.Visible = false;
                this.Gameweapon.Location = new Point(0, 0);
                ResetPlayer4Position();
            }
        }

        private void P1JumpFormula()
        {
            this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_l;
            Thread.Sleep(300);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_w;
            int JumpLoop = 0;
            while (JumpLoop < 20) {
                this.Player1.Location = new Point(this.Player1.Location.X - 10, this.Player1.Location.Y - 25);
                this.Refresh();
                JumpLoop++;
            }

            //do anim 
            
            Globals.Player1InAir = true;
            this.Player1ActList.Enabled = false;


        }

        private void P1LandFormula() 
        {
            Size Prejumpsize = this.Gameweapon.Size;
            Image PreJumpweapon = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Size = new Size(14, 64);
            this.Gameweapon.Location = new Point(this.Player1.Location.X - 16,this.Player1.Location.Y + 16);
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_spear;
            this.Gameweapon.Visible = true;
            int P1Y = 0;
            while (this.Player1.Location.Y <= this.Enemy1.Location.Y - this.Enemy1.Height /2) {
                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width - this.Enemy1.Width / 3, P1Y);
                this.Gameweapon.Location = new Point(this.Player1.Location.X - 16, this.Player1.Location.Y - 16);
                P1Y = P1Y + 26 ;
                this.Refresh();
            }
            this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_l;
            this.Player1.Refresh();
            Thread.Sleep(300);


            //do anim
           
            Globals.Player1InAir = false;


            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player1Attack * 2 + Globals.Floor + Globals.EnemyAttack;

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            this.Player1ActList.Enabled = true;
            this.Gameweapon.Visible = false;
            this.Gameweapon.Size = Prejumpsize;
            this.Gameweapon.Image = PreJumpweapon;
            this.Gameweapon.Location = new Point(0, 0);
            this.Gameweapon.Refresh();
            ResetPlayer1Position();

        }

        private void P2JumpFormula()
        {
            this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_l;
            Thread.Sleep(300);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_w;
            int JumpLoop = 0;
            while (JumpLoop < 20)
            {
                this.Player2.Location = new Point(this.Player2.Location.X - 10, this.Player2.Location.Y - 25);
                this.Refresh();
                JumpLoop++;
            }

            //do anim 
 
            Globals.Player2InAir = true;
            this.Player2ActList.Enabled = false;


        }

        private void P2LandFormula()
        {
            Size Prejumpsize = this.Gameweapon.Size;
            Image PreJumpweapon = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Size = new Size(14, 64);
            this.Gameweapon.Location = new Point(this.Player2.Location.X - 16, this.Player2.Location.Y + 16);
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_spear;
            this.Gameweapon.Visible = true;
            int P1Y = 0;
            while (this.Player2.Location.Y <= this.Enemy1.Location.Y - this.Enemy1.Height / 2)
            {
                this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width - this.Enemy1.Width / 3, P1Y);
                this.Gameweapon.Location = new Point(this.Player2.Location.X - 16, this.Player2.Location.Y - 16);
                P1Y = P1Y + 26;
                this.Refresh();
            }
            this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_l;
            this.Player2.Refresh();
            Thread.Sleep(300);


            //do anim
       
            Globals.Player2InAir = false;


            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player2Attack * 2 + Globals.Floor + Globals.EnemyAttack;

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            this.Player2ActList.Enabled = true;
            this.Gameweapon.Visible = false;
            this.Gameweapon.Size = Prejumpsize;
            this.Gameweapon.Image = PreJumpweapon;
            this.Gameweapon.Location = new Point(0, 0);
            this.Gameweapon.Refresh();
            ResetPlayer2Position();

        }

        private void P3JumpFormula()
        {
            this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_l;
            Thread.Sleep(300);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_w;
            int JumpLoop = 0;
            while (JumpLoop < 20)
            {
                this.Player3.Location = new Point(this.Player3.Location.X - 10, this.Player3.Location.Y - 25);
                this.Refresh();
                JumpLoop++;
            }

            //do anim 
        
            Globals.Player3InAir = true;
            this.Player3ActList.Enabled = false;


        }

        private void P3LandFormula()
        {
            Size Prejumpsize = this.Gameweapon.Size;
            Image PreJumpweapon = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Size = new Size(14, 64);
            this.Gameweapon.Location = new Point(this.Player3.Location.X - 16, this.Player3.Location.Y + 16);
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_spear;
            this.Gameweapon.Visible = true;
            int P1Y = 0;
            while (this.Player3.Location.Y <= this.Enemy1.Location.Y - this.Enemy1.Height / 2)
            {
                this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width - this.Enemy1.Width / 3, P1Y);
                this.Gameweapon.Location = new Point(this.Player3.Location.X - 16, this.Player3.Location.Y - 16);
                P1Y = P1Y + 26;
                this.Refresh();
            }
            this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_l;
            this.Player3.Refresh();
            Thread.Sleep(300);


            //do anim
       
            Globals.Player3InAir = false;


            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player3Attack * 2 + Globals.Floor + Globals.EnemyAttack;

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            this.Player3ActList.Enabled = true;
            this.Gameweapon.Visible = false;
            this.Gameweapon.Size = Prejumpsize;
            this.Gameweapon.Image = PreJumpweapon;
            this.Gameweapon.Location = new Point(0, 0);
            this.Gameweapon.Refresh();
            ResetPlayer3Position();

        }

        private void P4JumpFormula()
        {
            this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_l;
            Thread.Sleep(300);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_w;
            int JumpLoop = 0;
            while (JumpLoop < 20)
            {
                this.Player4.Location = new Point(this.Player4.Location.X - 10, this.Player4.Location.Y - 25);
                this.Refresh();
                JumpLoop++;
            }

            //do anim 
  
            Globals.Player4InAir = true;
            this.Player4ActList.Enabled = false;


        }

        private void P4LandFormula()
        {
            Size Prejumpsize = this.Gameweapon.Size;
            Image PreJumpweapon = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Size = new Size(14, 64);
            this.Gameweapon.Location = new Point(this.Player4.Location.X - 16, this.Player4.Location.Y + 16);
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_spear;
            this.Gameweapon.Visible = true;
            int P1Y = 0;
            while (this.Player4.Location.Y <= this.Enemy1.Location.Y - this.Enemy1.Height / 2)
            {
                this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width - this.Enemy1.Width / 3, P1Y);
                this.Gameweapon.Location = new Point(this.Player4.Location.X - 16, this.Player4.Location.Y - 16);
                P1Y = P1Y + 26;
                this.Refresh();
            }
            this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_l;
            this.Player4.Refresh();
            Thread.Sleep(300);


            //do anim
 
            Globals.Player4InAir = false;


            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player4Attack * 2 + Globals.Floor + Globals.EnemyAttack;

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            this.Player4ActList.Enabled = true;
            this.Gameweapon.Visible = false;
            this.Gameweapon.Size = Prejumpsize;
            this.Gameweapon.Image = PreJumpweapon;
            this.Gameweapon.Location = new Point(0, 0);
            this.Gameweapon.Refresh();
            ResetPlayer4Position();

        }

        private void P1RevengeFormula()
        {

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 20;

            #region lots of slashes
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            #endregion
            // do anim
            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player1MaxHP - Globals.Player1HP;
            if (BaseDMG <= 0) { BaseDMG = 1; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            ResetPlayer1Position();
            
        }

        private void P2RevengeFormula()
        {

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 20;

            #region lots of slashes
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            #endregion
            // do anim
            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player2MaxHP - Globals.Player2HP;
            if (BaseDMG <= 0) { BaseDMG = 1; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            ResetPlayer2Position();

        }

        private void P3RevengeFormula()
        {

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 20;

            #region lots of slashes
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            #endregion
            // do anim
            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player3MaxHP - Globals.Player3HP;
            if (BaseDMG <= 0) { BaseDMG = 1; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            ResetPlayer3Position();

        }

        private void P4RevengeFormula()
        {

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 20;

            #region lots of slashes
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_regal;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            #endregion
            // do anim
            //dmg step
            int BaseDMG;
            BaseDMG = Globals.Player4MaxHP - Globals.Player4HP;
            if (BaseDMG <= 0) { BaseDMG = 1; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();


            }

            ResetPlayer4Position();

        }

        private void P1BloodSwordFormula(){


                Random rand = new Random();
                int CritVal = rand.Next(0, Globals.CritArray.Length);

                this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Refresh();
                int AnimCooldown = 75;

                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);

                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_f;
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(AnimCooldown);
                this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                this.Gameweapon.Visible = false;
                this.Refresh();
                Thread.Sleep(AnimCooldown);


                // DMG Step
                int BaseDMG = Globals.Player1Attack - Globals.Floor;
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }
                if (BaseDMG < 10) { BaseDMG = 10; }
                Globals.Player1HP = Globals.Player1HP + BaseDMG;
                this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
                this.DMGLabel.Text = Convert.ToString(BaseDMG);
                this.DMGLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(600);
                this.DMGLabel.Visible = false;
                if (Globals.EnemyHP <= 0)
                {
                    this.Enemy1.Visible = false;
                    Globals.EnemyHP = 0;
                    this.Refresh();
                    // Load next floor

                }
                if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            ResetPlayer1Position();

        }

        private void P2BloodSwordFormula()
        {


            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 75;

            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            // DMG Step
            int BaseDMG = Globals.Player2Attack - Globals.Floor;
            if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }
            if (BaseDMG < 10) { BaseDMG = 10; }
            Globals.Player2HP = Globals.Player2HP + BaseDMG;
            this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }
            if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            ResetPlayer2Position();

        }

        private void P3BloodSwordFormula()
        {


            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 75;

            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            // DMG Step
            int BaseDMG = Globals.Player3Attack - Globals.Floor;
            if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }
            if (BaseDMG < 10) { BaseDMG = 10; }
            Globals.Player3HP = Globals.Player3HP + BaseDMG;
            this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }
            if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            ResetPlayer3Position();

        }

        private void P4BloodSwordFormula()
        {


            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Refresh();
            int AnimCooldown = 75;

            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);

            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_f;
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.w_blood;
            this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Size.Width, this.Enemy1.Location.Y + this.Enemy1.Size.Height / 2);
            this.Gameweapon.Visible = true;
            this.Refresh();
            Thread.Sleep(AnimCooldown);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
            this.Gameweapon.Visible = false;
            this.Refresh();
            Thread.Sleep(AnimCooldown);


            // DMG Step
            int BaseDMG = Globals.Player4Attack - Globals.Floor;
            if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }
            if (BaseDMG < 10) { BaseDMG = 10; }
            Globals.Player4HP = Globals.Player4HP + BaseDMG;
            this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }
            if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }
            ResetPlayer4Position();

        }

        private void TentFormula()
        {

            this.Player1.Image = global::ffgameRedux.Properties.Resources.tent;
            this.Player1.Refresh();
            Thread.Sleep(200);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.tent;
            this.Player2.Refresh();
            Thread.Sleep(200);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.tent;
            this.Player3.Refresh();
            Thread.Sleep(200);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.tent;
            this.Player4.Refresh();
            Thread.Sleep(1000);
            Globals.Player1IsDead = false;
            Globals.Player2IsDead = false;
            Globals.Player3IsDead = false;
            Globals.Player4IsDead = false;
            Globals.Player1HP = Globals.Player1MaxHP;
            Globals.Player1MP = Globals.Player1MaxMP;
            this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
            this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

            Globals.Player2HP = Globals.Player2MaxHP;
            Globals.Player2MP = Globals.Player2MaxMP;
            this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
            this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

            Globals.Player3HP = Globals.Player3MaxHP;
            Globals.Player3MP = Globals.Player3MaxMP;
            this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
            this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            Globals.Player4HP = Globals.Player4MaxHP;
            Globals.Player4MP = Globals.Player4MaxMP;
            this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
            this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
            if (Globals.PlayerTurn == 0) { this.PlayerBackpack.Items.Remove(" Tent"); }
            if (Globals.PlayerTurn == 1) { this.Player1ActList.Items.Remove(" Tent"); }
            if (Globals.PlayerTurn == 2) { this.Player2ActList.Items.Remove(" Tent"); }
            if (Globals.PlayerTurn == 3) { this.Player3ActList.Items.Remove(" Tent"); }
            if (Globals.PlayerTurn == 4) { this.Player4ActList.Items.Remove(" Tent"); }

            this.Player1ActList.Enabled = true;
            this.Player2ActList.Enabled = true;
            this.Player3ActList.Enabled = true;
            this.Player4ActList.Enabled = true;

            this.Player1.Visible = true;
            this.Player2.Visible = true;
            this.Player3.Visible = true;
            this.Player4.Visible = true;

            ResetPlayer1Position();
            ResetPlayer2Position();
            ResetPlayer3Position();
            ResetPlayer4Position();


        }

        private void PhoenixFormula()
        {



            if (Globals.Player1IsDead == true)
            {
                this.Player1.Visible = true;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width / 2, this.Player1.Location.Y - 80);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe1;
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe2;
                this.Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width / 2, this.Player1.Location.Y - 60);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width / 2, this.Player1.Location.Y - 40);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player1.Location.X + this.Player1.Width / 2, this.Player1.Location.Y - 28);
                this.Refresh();
                Thread.Sleep(200);


                //do anim
                Globals.Player1IsDead = false;
                Globals.Player1HP = Globals.Player1HP + Globals.Player1MaxHP / 8;
                this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                this.Player1ActList.Enabled = true;
                ResetPlayer1Position();

            }
            if (Globals.Player2IsDead == true)
            {
                this.Player2.Visible = true;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width / 2, this.Player2.Location.Y - 80);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe1;
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe2;
                this.Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width / 2, this.Player2.Location.Y - 60);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width / 2, this.Player2.Location.Y - 40);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player2.Location.X + this.Player2.Width / 2, this.Player2.Location.Y - 28);
                this.Refresh();
                Thread.Sleep(200);


                //do anim
                Globals.Player2IsDead = false;
                Globals.Player2HP = Globals.Player2HP + Globals.Player2MaxHP / 8;
                this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                this.Player2ActList.Enabled = true;
                ResetPlayer2Position();

            }
            if (Globals.Player3IsDead == true)
            {
                this.Player3.Visible = true;

                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width / 2, this.Player3.Location.Y - 80);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe1;
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe2;
                this.Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width / 2, this.Player3.Location.Y - 60);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width / 2, this.Player3.Location.Y - 40);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player3.Location.X + this.Player3.Width / 2, this.Player3.Location.Y - 28);
                this.Refresh();
                Thread.Sleep(200);


                //do anim
                Globals.Player3IsDead = false;
                Globals.Player3HP = Globals.Player3HP + Globals.Player3MaxHP / 8;
                this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                this.Player3ActList.Enabled = true;
                ResetPlayer3Position();

            }
            if (Globals.Player4IsDead == true)
            {
                this.Player4.Visible = true;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width / 2, this.Player4.Location.Y - 80);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe1;
                this.Gameweapon.Visible = true;
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe2;
                this.Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width / 2, this.Player4.Location.Y - 60);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width / 2, this.Player4.Location.Y - 40);
                this.Refresh();
                Thread.Sleep(200);

                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.fe3;
                this.Gameweapon.Location = new Point(this.Player4.Location.X + this.Player4.Width / 2, this.Player4.Location.Y - 28);
                this.Refresh();
                Thread.Sleep(200);


                //do anim
                Globals.Player4IsDead = false;
                Globals.Player4HP = Globals.Player4HP + Globals.Player4MaxHP / 8;
                this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                this.Player4ActList.Enabled = true;
                ResetPlayer4Position();

            }





            this.PlayerBackpack.Items.Remove(" Phoenix"); 


        }

        private void PotionFormula()
        {
            this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.cure1;
            if (Globals.Player1IsDead == false)
            {

                this.Gameweapon.Location = new Point(this.Player1.Location.X, this.Player1.Location.Y - 20);
                this.Gameweapon.Visible = true;
                Thread.Sleep(200);
                this.Refresh();

                Globals.Player1HP = Globals.Player1HP + Globals.Player1MaxHP / 4;
                if (Globals.Player1HP > Globals.Player1MaxHP) {Globals.Player1HP = Globals.Player1MaxHP; }
                this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                

            }
            if (Globals.Player2IsDead == false)
            {

                this.Gameweapon.Location = new Point(this.Player2.Location.X, this.Player2.Location.Y - 20);
                this.Gameweapon.Visible = true;
                Thread.Sleep(200);
                this.Refresh();

                Globals.Player2HP = Globals.Player2HP + Globals.Player2MaxHP / 4;
                if (Globals.Player2HP > Globals.Player2MaxHP) { Globals.Player2HP = Globals.Player2MaxHP; }
                this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));

            }
            if (Globals.Player3IsDead == false)
            {

                this.Gameweapon.Location = new Point(this.Player3.Location.X, this.Player3.Location.Y - 20);
                this.Gameweapon.Visible = true;
                Thread.Sleep(200);
                this.Refresh();

                Globals.Player3HP = Globals.Player3HP + Globals.Player3MaxHP / 4;
                if (Globals.Player3HP > Globals.Player3MaxHP) { Globals.Player3HP = Globals.Player3MaxHP; }
                this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                this.Player3ActList.Enabled = true;

            }
            if (Globals.Player4IsDead == false)
            {

                this.Gameweapon.Location = new Point(this.Player4.Location.X, this.Player4.Location.Y - 20);
                this.Gameweapon.Visible = true;
                Thread.Sleep(200);
                this.Refresh();

                Globals.Player4HP = Globals.Player4HP + Globals.Player4MaxHP / 4;
                if (Globals.Player4HP > Globals.Player4MaxHP) { Globals.Player4HP = Globals.Player4MaxHP; }
                this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                this.Player4ActList.Enabled = true;

            }






            this.PlayerBackpack.Items.Remove(" Potion");


        }

        private void P1ThiefSteal() {

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width , this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width , this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width , this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width , this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width , this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            ResetPlayer1Position();

            //do anim

            //"Potion", "Tent", "Phoenix", "Nothing"
            int[] StealOptions = { 0,1,2,3,4,5,6,7,8,9 };
            Random rand = new Random();

            int StolenItem = rand.Next(0, StealOptions.Length);
            Thread.Sleep(1000);
            if (this.PlayerBackpack.Items.Count < 3)
            {
                if (StolenItem == 0 || StolenItem == 1 || StolenItem == 2 ||StolenItem == 3)
                {
                    // stole nothing

                }
                if (StolenItem == 4 || StolenItem == 5 || StolenItem == 6 )
                {
                    this.PlayerBackpack.Items.Add(" Potion");
                    
                }
                if (StolenItem == 7 || StolenItem == 8)
                {
                    this.PlayerBackpack.Items.Add(" Phoenix");
                    

                }
                if (StolenItem == 9)
                {
                    this.PlayerBackpack.Items.Add(" Tent");
                    
                }
            }
            


        }

        private void P2ThiefSteal()
        {
            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            ResetPlayer2Position();

            //do anim

            //"Potion", "Tent", "Phoenix", "Nothing"
            int[] StealOptions = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();

            int StolenItem = rand.Next(0, StealOptions.Length);
            Thread.Sleep(1000);
            if (this.PlayerBackpack.Items.Count < 3)
            {
                if (StolenItem == 0 || StolenItem == 1 || StolenItem == 2 || StolenItem == 3)
                {
                    // stole nothing

                }
                if (StolenItem == 4 || StolenItem == 5 || StolenItem == 6)
                {
                    this.PlayerBackpack.Items.Add(" Potion");

                }
                if (StolenItem == 7 || StolenItem == 8)
                {
                    this.PlayerBackpack.Items.Add(" Phoenix");


                }
                if (StolenItem == 9)
                {
                    this.PlayerBackpack.Items.Add(" Tent");

                }
            }
            ResetPlayer2Position();


        }

        private void P3ThiefSteal()
        {
            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            ResetPlayer3Position();

            //do anim

            //"Potion", "Tent", "Phoenix", "Nothing"
            int[] StealOptions = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();

            int StolenItem = rand.Next(0, StealOptions.Length);
            Thread.Sleep(1000);
            if (this.PlayerBackpack.Items.Count < 3)
            {
                if (StolenItem == 0 || StolenItem == 1 || StolenItem == 2 || StolenItem == 3)
                {
                    // stole nothing

                }
                if (StolenItem == 4 || StolenItem == 5 || StolenItem == 6)
                {
                    this.PlayerBackpack.Items.Add(" Potion");

                }
                if (StolenItem == 7 || StolenItem == 8)
                {
                    this.PlayerBackpack.Items.Add(" Phoenix");


                }
                if (StolenItem == 9)
                {
                    this.PlayerBackpack.Items.Add(" Tent");

                }
            }
            ResetPlayer3Position();


        }

        private void P4ThiefSteal()
        {
            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 2);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width / 3);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width, this.Enemy1.Location.X + this.Enemy1.Width);
            this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_f;
            this.Refresh();
            Thread.Sleep(150);

            ResetPlayer4Position();

            //do anim

            //"Potion", "Tent", "Phoenix", "Nothing"
            int[] StealOptions = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();

            int StolenItem = rand.Next(0, StealOptions.Length);
            Thread.Sleep(1000);
            if (this.PlayerBackpack.Items.Count < 3)
            {
                if (StolenItem == 0 || StolenItem == 1 || StolenItem == 2 || StolenItem == 3)
                {
                    // stole nothing

                }
                if (StolenItem == 4 || StolenItem == 5 || StolenItem == 6)
                {
                    this.PlayerBackpack.Items.Add(" Potion");

                }
                if (StolenItem == 7 || StolenItem == 8)
                {
                    this.PlayerBackpack.Items.Add(" Phoenix");


                }
                if (StolenItem == 9)
                {
                    this.PlayerBackpack.Items.Add(" Tent");

                }
            }
            ResetPlayer4Position();


        }

        private void P1Osmose()
        {
            this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player1.Location = new Point(this.Player1.Location.X - 32, this.Player1.Location.Y);

            if (Globals.Player1MP < 2)
            {
                this.Player1MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
               
            }

            if (Globals.Player1MP >= 2)
            {
                Globals.Player1MP = Globals.Player1MP - 2;
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                int animcool = 80;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.osmose1;
                this.Gameweapon.Visible = true;
                //anim

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width - 1, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                // go back

                

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                this.Gameweapon.Visible = false;
                int mpgain = Globals.EnemyAttack / 4 + Globals.Floor;
              
                if (mpgain < 0) { mpgain++; }
                Globals.Player1MP = Globals.Player1MP + mpgain;
                if (Globals.Player1MP > Globals.Player1MaxMP) { Globals.Player1MP = Globals.Player1MaxMP; }

                
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

            }

            ResetPlayer1Position();

        }


        private void P2Osmose()
        {
            this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player2.Location = new Point(this.Player2.Location.X - 32, this.Player2.Location.Y);

            if (Globals.Player2MP < 2)
            {
                this.Player2MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

            }

            if (Globals.Player2MP >= 2)
            {
                Globals.Player2MP = Globals.Player2MP - 2;
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                int animcool = 80;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.osmose1;
                this.Gameweapon.Visible = true;
                //anim

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width - 1, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                // go back



                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                this.Gameweapon.Visible = false;
                int mpgain = Globals.EnemyAttack / 4 + Globals.Floor;

                if (mpgain < 0) { mpgain++; }
                Globals.Player2MP = Globals.Player2MP + mpgain;
                if (Globals.Player2MP > Globals.Player2MaxMP) { Globals.Player2MP = Globals.Player2MaxMP; }


                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

            }

            ResetPlayer2Position();

        }


        private void P3Osmose()
        {
            this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player3.Location = new Point(this.Player3.Location.X - 32, this.Player3.Location.Y);

            if (Globals.Player3MP < 2)
            {
                this.Player3MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            }

            if (Globals.Player3MP >= 2)
            {
                Globals.Player3MP = Globals.Player3MP - 2;
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                int animcool = 80;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.osmose1;
                this.Gameweapon.Visible = true;
                //anim

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width - 1, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                // go back



                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                this.Gameweapon.Visible = false;
                int mpgain = Globals.EnemyAttack / 4 + Globals.Floor;

                if (mpgain < 0) { mpgain++; }
                Globals.Player3MP = Globals.Player3MP + mpgain;
                if (Globals.Player3MP > Globals.Player3MaxMP) { Globals.Player3MP = Globals.Player3MaxMP; }


                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            }

            ResetPlayer3Position();

        }


        private void P4Osmose()
        {
            this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player4.Location = new Point(this.Player4.Location.X - 32, this.Player4.Location.Y);

            if (Globals.Player4MP < 2)
            {
                this.Player4MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);

            }

            if (Globals.Player4MP >= 2)
            {
                Globals.Player4MP = Globals.Player4MP - 2;
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                int animcool = 80;
                this.Gameweapon.Size = new Size(32, 32);
                this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.osmose1;
                this.Gameweapon.Visible = true;
                //anim

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width - 1, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                // go back



                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);

                this.Gameweapon.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width / 2 / 2, this.Enemy1.Location.Y - 10);
                this.Refresh();
                Thread.Sleep(animcool);


                this.Gameweapon.Visible = false;
                int mpgain = Globals.EnemyAttack / 4 + Globals.Floor;

                if (mpgain < 0) { mpgain++; }
                Globals.Player4MP = Globals.Player4MP + mpgain;
                if (Globals.Player4MP > Globals.Player4MaxMP) { Globals.Player4MP = Globals.Player4MaxMP; }


                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);

            }

            ResetPlayer4Position();

        }

        private void P1Summon() {

            this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player1.Location = new Point(this.Player1.Location.X - 32, this.Player1.Location.Y);

            if (Globals.Player1MP < 12)
            {
                this.Player1MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

            }

            if (Globals.Player1MP >= 12)
            {

                int[] summontable = { 0,1,2,3,4,5,6,7,8,9};
                // 0 - 1 ifirt
                // 2 - 3 ramuh
                // 4 - 5 leviathan
                // 6 - 7 titan
                // 8 Phoenix
                // 9 Bahamut
                // 


                Random ran = new Random();
                int selsummon = ran.Next(0, summontable.Length);

                

                if (selsummon == 0 || selsummon == 1)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ifrit;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ifrit.Width, global::ffgameRedux.Properties.Resources.sum_ifrit.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.flamepillar1.Width, global::ffgameRedux.Properties.Resources.flamepillar1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X,0);
                    this.SummonWeapon.Visible = true;
                    int Xborder = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;
                   
                    
                        while (Xborder < 330)
                        {
                            this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                            this.SummonWeapon.Location = new Point(Xborder, 0);
                            Xborder = Xborder + animspeed;
                            Thread.Sleep(50);
                            this.Refresh();
                            this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                            this.SummonWeapon.Location = new Point(Xborder, 0);
                            Xborder = Xborder + animspeed;
                            Thread.Sleep(50);
                            this.Refresh();

                        }
                        while (Xborder > 0)
                        {
                            this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                            this.SummonWeapon.Location = new Point(Xborder, 0);
                            Thread.Sleep(50);
                            this.Refresh();
                            Xborder = Xborder - animspeed;
                            this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                            this.SummonWeapon.Location = new Point(Xborder, 0);
                            Thread.Sleep(50);
                            this.Refresh();
                            Xborder = Xborder - animspeed;
                        }
                        while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }


                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Attack + Globals.Player2Attack + Globals.Player3Attack + Globals.Player4Attack + Globals.EnemyAttack + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player1MP = Globals.Player1MP - 12;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }
                    

                }

                if (selsummon == 2 || selsummon == 3)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ramuh;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ramuh.Width, global::ffgameRedux.Properties.Resources.sum_ramuh.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.thun1.Width, global::ffgameRedux.Properties.Resources.thun1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 2, 0);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;
                    int animspeed2 = 140;
                    while (lc < 4)
                    {
                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 3, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(this.Enemy1.Location.X - 90, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width - 128, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        lc++;


                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Speed + Globals.Player2Speed + Globals.Player3Speed + Globals.Player4Speed + 15 + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player1MP = Globals.Player1MP - 12;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 4 || selsummon == 5)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_levi;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_levi.Width, global::ffgameRedux.Properties.Resources.sum_levi.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.wave.Width, global::ffgameRedux.Properties.Resources.wave.Height);
                    this.SummonWeapon.Location = new Point(this.Width, 0);
                    this.SummonWeapon.Visible = true;

                    int Xborder = this.Width;
                    Thread.Sleep(100);
                    int animspeed = 30;

                    while (Xborder > -97)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave3;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave4;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave5;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1HP + Globals.Player2HP + Globals.Player3HP + Globals.Player4HP  + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player1MP = Globals.Player1MP - 12;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }

                if (selsummon == 6 || selsummon == 7)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_titan;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_titan.Width, global::ffgameRedux.Properties.Resources.sum_titan.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.quake1.Width, global::ffgameRedux.Properties.Resources.quake1.Height);
                    this.SummonWeapon.Location = new Point(280, 240);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 12;
                    int WinlocX = this.Location.X;
                    int WinlocY = this.Location.Y;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;

                    while (lc < 5)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake2;

                    while (lc < 10)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake3;

                    while (lc < 15)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake4;

                    while (lc < 20)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake5;

                    while (lc < 25)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    
                    BaseDMG = Globals.EnemyHP / 5;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player1MP = Globals.Player1MP - 12;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                    this.Location = new Point(PreWinlocX, PreWinlocY);


                }

                if (selsummon == 8)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_phoe;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_phoe.Width, global::ffgameRedux.Properties.Resources.sum_phoe.Height);
                    this.Gameweapon.Location = new Point(800, 60);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    int animspeed = 5;
                    int lc = 800;
                    while (lc > -20 - global::ffgameRedux.Properties.Resources.sum_phoe.Width)
                    {

                        this.Gameweapon.Location = new Point(lc, 60);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc = lc - 25;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step

                    Thread.Sleep(1000);
                    Globals.Player1IsDead = false;
                    Globals.Player2IsDead = false;
                    Globals.Player3IsDead = false;
                    Globals.Player4IsDead = false;
                    Globals.Player1HP = Globals.Player1MaxHP;
                    Globals.Player1MP = Globals.Player1MaxMP;
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

                    Globals.Player2HP = Globals.Player2MaxHP;
                    Globals.Player2MP = Globals.Player2MaxMP;
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

                    Globals.Player3HP = Globals.Player3MaxHP;
                    Globals.Player3MP = Globals.Player3MaxMP;
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

                    Globals.Player4HP = Globals.Player4MaxHP;
                    Globals.Player4MP = Globals.Player4MaxMP;
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.PlayerTurn == 0) { this.PlayerBackpack.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 1) { this.Player1ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 2) { this.Player2ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 3) { this.Player3ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 4) { this.Player4ActList.Items.Remove(" Tent"); }

                    this.Player1ActList.Enabled = true;
                    this.Player2ActList.Enabled = true;
                    this.Player3ActList.Enabled = true;
                    this.Player4ActList.Enabled = true;
                    ResetPlayer1Position();
                    ResetPlayer2Position();
                    ResetPlayer3Position();
                    ResetPlayer4Position();


                }

                if (selsummon == 9)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_baham;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_baham.Width, global::ffgameRedux.Properties.Resources.sum_baham.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);


                    
                    Thread.Sleep(100);
                    int animspeed = 29;
                    Image PreBG = this.Background.Image;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;
                    int lc = 0;
                    while (lc < 20)
                    {

                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo1;
                        this.Location = new Point(PreWinlocX - 5, PreWinlocY - 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo2;
                        this.Location = new Point(PreWinlocX, PreWinlocY );
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo3;
                        this.Location = new Point(PreWinlocX + 5, PreWinlocY + 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo4;
                        this.Location = new Point(PreWinlocX , PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc++;
                    }

                    this.Background.Image = PreBG;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = (Globals.Floor * 3
                        + Globals.Player1Attack + Globals.Player1Defense + Globals.Player1Speed + Globals.Player1MaxHP //p1 max formore dmg
                        + Globals.Player2Attack + Globals.Player2Defense + Globals.Player2Speed + Globals.Player2HP
                        + Globals.Player3Attack + Globals.Player3Defense + Globals.Player3Speed + Globals.Player3HP
                        + Globals.Player4Attack + Globals.Player4Defense + Globals.Player4Speed + Globals.Player4HP
                        );
                    Thread.Sleep(1000);
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player1MP = Globals.Player1MP - 12;
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }
            }

            ResetPlayer1Position();

        }

        private void P2Summon()
        {

            this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player2.Location = new Point(this.Player2.Location.X - 32, this.Player2.Location.Y);

            if (Globals.Player2MP < 12)
            {
                this.Player2MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

            }

            if (Globals.Player2MP >= 12)
            {

                int[] summontable = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                // 0 - 1 ifirt
                // 2 - 3 ramuh
                // 4 - 5 leviathan
                // 6 - 7 titan
                // 8 Phoenix
                // 9 Bahamut
                // 


                Random ran = new Random();
                int selsummon = ran.Next(0, summontable.Length);

              

                if (selsummon == 0 || selsummon == 1)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ifrit;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ifrit.Width, global::ffgameRedux.Properties.Resources.sum_ifrit.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.flamepillar1.Width, global::ffgameRedux.Properties.Resources.flamepillar1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X, 0);
                    this.SummonWeapon.Visible = true;
                    int Xborder = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;


                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }
                    while (Xborder > 0)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                    }
                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }


                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Attack + Globals.Player2Attack + Globals.Player3Attack + Globals.Player4Attack + Globals.EnemyAttack + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player2MP = Globals.Player2MP - 12;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 2 || selsummon == 3)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ramuh;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ramuh.Width, global::ffgameRedux.Properties.Resources.sum_ramuh.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.thun1.Width, global::ffgameRedux.Properties.Resources.thun1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 2, 0);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;
                    int animspeed2 = 140;
                    while (lc < 4)
                    {
                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 3, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(this.Enemy1.Location.X - 90, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width - 128, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        lc++;


                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Speed + Globals.Player2Speed + Globals.Player3Speed + Globals.Player4Speed + 15 + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player2MP = Globals.Player2MP - 12;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 4 || selsummon == 5)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_levi;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_levi.Width, global::ffgameRedux.Properties.Resources.sum_levi.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.wave.Width, global::ffgameRedux.Properties.Resources.wave.Height);
                    this.SummonWeapon.Location = new Point(this.Width, 0);
                    this.SummonWeapon.Visible = true;

                    int Xborder = this.Width;
                    Thread.Sleep(100);
                    int animspeed = 30;

                    while (Xborder > -97)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave3;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave4;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave5;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1HP + Globals.Player2HP + Globals.Player3HP + Globals.Player4HP + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player2MP = Globals.Player2MP - 12;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }

                if (selsummon == 6 || selsummon == 7)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_titan;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_titan.Width, global::ffgameRedux.Properties.Resources.sum_titan.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.quake1.Width, global::ffgameRedux.Properties.Resources.quake1.Height);
                    this.SummonWeapon.Location = new Point(280, 240);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 12;
                    int WinlocX = this.Location.X;
                    int WinlocY = this.Location.Y;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;

                    while (lc < 5)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake2;

                    while (lc < 10)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake3;

                    while (lc < 15)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake4;

                    while (lc < 20)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake5;

                    while (lc < 25)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = Globals.EnemyHP / 5;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    Globals.Player2MP = Globals.Player2MP - 12;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                    this.Location = new Point(PreWinlocX, PreWinlocY);


                }

                if (selsummon == 8)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_phoe;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_phoe.Width, global::ffgameRedux.Properties.Resources.sum_phoe.Height);
                    this.Gameweapon.Location = new Point(800, 60);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    int animspeed = 5;
                    int lc = 800;
                    while (lc > -20 - global::ffgameRedux.Properties.Resources.sum_phoe.Width)
                    {

                        this.Gameweapon.Location = new Point(lc, 60);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc = lc - 25;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step

                    Thread.Sleep(1000);
                    Globals.Player1IsDead = false;
                    Globals.Player2IsDead = false;
                    Globals.Player3IsDead = false;
                    Globals.Player4IsDead = false;
                    Globals.Player1HP = Globals.Player1MaxHP;
                    Globals.Player1MP = Globals.Player1MaxMP;
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

                    Globals.Player2HP = Globals.Player2MaxHP;
                    Globals.Player2MP = Globals.Player2MaxMP;
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

                    Globals.Player3HP = Globals.Player3MaxHP;
                    Globals.Player3MP = Globals.Player3MaxMP;
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

                    Globals.Player4HP = Globals.Player4MaxHP;
                    Globals.Player4MP = Globals.Player4MaxMP;
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.PlayerTurn == 0) { this.PlayerBackpack.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 1) { this.Player1ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 2) { this.Player2ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 3) { this.Player3ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 4) { this.Player4ActList.Items.Remove(" Tent"); }

                    this.Player1ActList.Enabled = true;
                    this.Player2ActList.Enabled = true;
                    this.Player3ActList.Enabled = true;
                    this.Player4ActList.Enabled = true;
                    ResetPlayer1Position();
                    ResetPlayer2Position();
                    ResetPlayer3Position();
                    ResetPlayer4Position();


                }

                if (selsummon == 9)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_baham;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_baham.Width, global::ffgameRedux.Properties.Resources.sum_baham.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);



                    Thread.Sleep(100);
                    int animspeed = 29;
                    Image PreBG = this.Background.Image;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;
                    int lc = 0;
                    while (lc < 20)
                    {

                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo1;
                        this.Location = new Point(PreWinlocX - 5, PreWinlocY - 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo2;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo3;
                        this.Location = new Point(PreWinlocX + 5, PreWinlocY + 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo4;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc++;
                    }

                    this.Background.Image = PreBG;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = (Globals.Floor * 3
                        + Globals.Player1Attack + Globals.Player1Defense + Globals.Player1Speed + Globals.Player1HP 
                        + Globals.Player2Attack + Globals.Player2Defense + Globals.Player2Speed + Globals.Player2MaxHP //p2 max formore dmg
                        + Globals.Player3Attack + Globals.Player3Defense + Globals.Player3Speed + Globals.Player3HP
                        + Globals.Player4Attack + Globals.Player4Defense + Globals.Player4Speed + Globals.Player4HP
                        );
                  
                    Thread.Sleep(1000);
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                 
                    Globals.Player2MP = Globals.Player2MP - 12;
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }
            }

            ResetPlayer2Position();

        }

        private void P3Summon()
        {

            this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player3.Location = new Point(this.Player3.Location.X - 32, this.Player3.Location.Y);

            if (Globals.Player3MP < 12)
            {
                this.Player3MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

            }

            if (Globals.Player3MP >= 12)
            {

                int[] summontable = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                // 0 - 1 ifirt
                // 2 - 3 ramuh
                // 4 - 5 leviathan
                // 6 - 7 titan
                // 8 Phoenix
                // 9 Bahamut
                // 


                Random ran = new Random();
                int selsummon = ran.Next(0, summontable.Length);



                if (selsummon == 0 || selsummon == 1)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ifrit;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ifrit.Width, global::ffgameRedux.Properties.Resources.sum_ifrit.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.flamepillar1.Width, global::ffgameRedux.Properties.Resources.flamepillar1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X, 0);
                    this.SummonWeapon.Visible = true;
                    int Xborder = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;


                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }
                    while (Xborder > 0)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                    }
                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }


                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Attack + Globals.Player2Attack + Globals.Player3Attack + Globals.Player4Attack + Globals.EnemyAttack + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player3MP = Globals.Player3MP - 12;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 2 || selsummon == 3)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ramuh;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ramuh.Width, global::ffgameRedux.Properties.Resources.sum_ramuh.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.thun1.Width, global::ffgameRedux.Properties.Resources.thun1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 2, 0);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;
                    int animspeed2 = 140;
                    while (lc < 4)
                    {
                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 3, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(this.Enemy1.Location.X - 90, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width - 128, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        lc++;


                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Speed + Globals.Player2Speed + Globals.Player3Speed + Globals.Player4Speed + 15 + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player3MP = Globals.Player3MP - 12;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 4 || selsummon == 5)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_levi;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_levi.Width, global::ffgameRedux.Properties.Resources.sum_levi.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.wave.Width, global::ffgameRedux.Properties.Resources.wave.Height);
                    this.SummonWeapon.Location = new Point(this.Width, 0);
                    this.SummonWeapon.Visible = true;

                    int Xborder = this.Width;
                    Thread.Sleep(100);
                    int animspeed = 30;

                    while (Xborder > -97)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave3;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave4;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave5;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1HP + Globals.Player2HP + Globals.Player3HP + Globals.Player4HP + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player3MP = Globals.Player3MP - 12;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }

                if (selsummon == 6 || selsummon == 7)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_titan;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_titan.Width, global::ffgameRedux.Properties.Resources.sum_titan.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.quake1.Width, global::ffgameRedux.Properties.Resources.quake1.Height);
                    this.SummonWeapon.Location = new Point(280, 240);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 12;
                    int WinlocX = this.Location.X;
                    int WinlocY = this.Location.Y;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;

                    while (lc < 5)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake2;

                    while (lc < 10)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake3;

                    while (lc < 15)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake4;

                    while (lc < 20)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake5;

                    while (lc < 25)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = Globals.EnemyHP / 5;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player3MP = Globals.Player3MP - 12;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                    this.Location = new Point(PreWinlocX, PreWinlocY);


                }

                if (selsummon == 8)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_phoe;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_phoe.Width, global::ffgameRedux.Properties.Resources.sum_phoe.Height);
                    this.Gameweapon.Location = new Point(800, 60);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    int animspeed = 5;
                    int lc = 800;
                    while (lc > -20 - global::ffgameRedux.Properties.Resources.sum_phoe.Width)
                    {

                        this.Gameweapon.Location = new Point(lc, 60);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc = lc - 25;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step

                    Thread.Sleep(1000);
                    Globals.Player1IsDead = false;
                    Globals.Player2IsDead = false;
                    Globals.Player3IsDead = false;
                    Globals.Player4IsDead = false;
                    Globals.Player1HP = Globals.Player1MaxHP;
                    Globals.Player1MP = Globals.Player1MaxMP;
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

                    Globals.Player2HP = Globals.Player2MaxHP;
                    Globals.Player2MP = Globals.Player2MaxMP;
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

                    Globals.Player3HP = Globals.Player3MaxHP;
                    Globals.Player3MP = Globals.Player3MaxMP;
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

                    Globals.Player4HP = Globals.Player4MaxHP;
                    Globals.Player4MP = Globals.Player4MaxMP;
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.PlayerTurn == 0) { this.PlayerBackpack.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 1) { this.Player1ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 2) { this.Player2ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 3) { this.Player3ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 4) { this.Player4ActList.Items.Remove(" Tent"); }

                    this.Player1ActList.Enabled = true;
                    this.Player2ActList.Enabled = true;
                    this.Player3ActList.Enabled = true;
                    this.Player4ActList.Enabled = true;
                    ResetPlayer1Position();
                    ResetPlayer2Position();
                    ResetPlayer3Position();
                    ResetPlayer4Position();


                }

                if (selsummon == 9)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_baham;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_baham.Width, global::ffgameRedux.Properties.Resources.sum_baham.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);



                    Thread.Sleep(100);
                    int animspeed = 29;
                    Image PreBG = this.Background.Image;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;
                    int lc = 0;
                    while (lc < 20)
                    {

                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo1;
                        this.Location = new Point(PreWinlocX - 5, PreWinlocY - 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo2;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo3;
                        this.Location = new Point(PreWinlocX + 5, PreWinlocY + 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo4;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc++;
                    }

                    this.Background.Image = PreBG;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = (Globals.Floor * 3
                        + Globals.Player1Attack + Globals.Player1Defense + Globals.Player1Speed + Globals.Player1HP //p3 max formore dmg
                        + Globals.Player2Attack + Globals.Player2Defense + Globals.Player2Speed + Globals.Player2HP
                        + Globals.Player3Attack + Globals.Player3Defense + Globals.Player3Speed + Globals.Player3MaxHP
                        + Globals.Player4Attack + Globals.Player4Defense + Globals.Player4Speed + Globals.Player4HP
                        );
                    this.Text = Convert.ToString(BaseDMG);
                    Thread.Sleep(1000);
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player3MP = Globals.Player3MP - 12;
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }
            }

            ResetPlayer3Position();

        }


        private void P4Summon()
        {

            this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_w;
            this.Player4.Location = new Point(this.Player4.Location.X - 32, this.Player4.Location.Y);

            if (Globals.Player4MP < 12)
            {
                this.Player4MPGauge.Text = "Not Enough MP!";
                this.Refresh();
                Thread.Sleep(1000);
                this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);

            }

            if (Globals.Player4MP >= 12)
            {

                int[] summontable = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                // 0 - 1 ifirt
                // 2 - 3 ramuh
                // 4 - 5 leviathan
                // 6 - 7 titan
                // 8 Phoenix
                // 9 Bahamut
                // 


                Random ran = new Random();
                int selsummon = ran.Next(0, summontable.Length);



                if (selsummon == 0 || selsummon == 1)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ifrit;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ifrit.Width, global::ffgameRedux.Properties.Resources.sum_ifrit.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.flamepillar1.Width, global::ffgameRedux.Properties.Resources.flamepillar1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X, 0);
                    this.SummonWeapon.Visible = true;
                    int Xborder = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;


                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }
                    while (Xborder > 0)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Thread.Sleep(50);
                        this.Refresh();
                        Xborder = Xborder - animspeed;
                    }
                    while (Xborder < 330)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar1;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.flamepillar2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        Xborder = Xborder + animspeed;
                        Thread.Sleep(50);
                        this.Refresh();

                    }


                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Attack + Globals.Player2Attack + Globals.Player3Attack + Globals.Player4Attack + Globals.EnemyAttack + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player4MP = Globals.Player4MP - 12;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 2 || selsummon == 3)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_ramuh;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_ramuh.Width, global::ffgameRedux.Properties.Resources.sum_ramuh.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.thun1.Width, global::ffgameRedux.Properties.Resources.thun1.Height);
                    this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 2, 0);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 30;
                    int animspeed2 = 140;
                    while (lc < 4)
                    {
                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width / 3, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(this.Enemy1.Location.X - 90, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        this.SummonWeapon.Location = new Point(Enemy1.Location.X + this.Enemy1.Width - 128, 0);

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun1;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun2;
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.thun3;
                        this.Refresh();
                        Thread.Sleep(animspeed2);

                        lc++;


                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1Speed + Globals.Player2Speed + Globals.Player3Speed + Globals.Player4Speed + 15 + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player4MP = Globals.Player4MP - 12;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }


                }

                if (selsummon == 4 || selsummon == 5)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_levi;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_levi.Width, global::ffgameRedux.Properties.Resources.sum_levi.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.wave.Width, global::ffgameRedux.Properties.Resources.wave.Height);
                    this.SummonWeapon.Location = new Point(this.Width, 0);
                    this.SummonWeapon.Visible = true;

                    int Xborder = this.Width;
                    Thread.Sleep(100);
                    int animspeed = 30;

                    while (Xborder > -97)
                    {
                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave2;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave3;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave4;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;

                        this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.wave5;
                        this.SummonWeapon.Location = new Point(Xborder, 0);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        Xborder = Xborder - animspeed;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;
                    BaseDMG = Globals.Player1HP + Globals.Player2HP + Globals.Player3HP + Globals.Player4HP + Globals.Floor;
                    BaseDMG = BaseDMG + BaseDMG / 2;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player4MP = Globals.Player4MP - 12;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }

                if (selsummon == 6 || selsummon == 7)
                {
                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_titan;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_titan.Width, global::ffgameRedux.Properties.Resources.sum_titan.Height);
                    this.Gameweapon.Location = new Point(420, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake1;
                    this.SummonWeapon.Size = new Size(global::ffgameRedux.Properties.Resources.quake1.Width, global::ffgameRedux.Properties.Resources.quake1.Height);
                    this.SummonWeapon.Location = new Point(280, 240);
                    this.SummonWeapon.Visible = true;
                    int lc = 0;
                    Thread.Sleep(100);
                    int animspeed = 12;
                    int WinlocX = this.Location.X;
                    int WinlocY = this.Location.Y;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;

                    while (lc < 5)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake2;

                    while (lc < 10)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake3;

                    while (lc < 15)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake4;

                    while (lc < 20)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }
                    this.SummonWeapon.Image = global::ffgameRedux.Properties.Resources.quake5;

                    while (lc < 25)
                    {
                        this.Location = new Point(WinlocX - 10, WinlocY - 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        this.Location = new Point(WinlocX + 10, WinlocY + 10);
                        Thread.Sleep(animspeed);
                        this.Refresh();
                        lc++;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = Globals.EnemyHP / 5;
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player4MP = Globals.Player4MP - 12;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                    this.Location = new Point(PreWinlocX, PreWinlocY);


                }

                if (selsummon == 8)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_phoe;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_phoe.Width, global::ffgameRedux.Properties.Resources.sum_phoe.Height);
                    this.Gameweapon.Location = new Point(800, 60);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);

                    int animspeed = 5;
                    int lc = 800;
                    while (lc > -20 - global::ffgameRedux.Properties.Resources.sum_phoe.Width)
                    {

                        this.Gameweapon.Location = new Point(lc, 60);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc = lc - 25;
                    }

                    this.SummonWeapon.Visible = false;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step

                    Thread.Sleep(1000);
                    Globals.Player1IsDead = false;
                    Globals.Player2IsDead = false;
                    Globals.Player3IsDead = false;
                    Globals.Player4IsDead = false;
                    Globals.Player1HP = Globals.Player1MaxHP;
                    Globals.Player1MP = Globals.Player1MaxMP;
                    this.Player1HPGauge.Text = (Globals.Player1Name + " HP: " + Convert.ToString(Globals.Player1HP) + "/ " + Convert.ToString(Globals.Player1MaxHP));
                    this.Player1MPGauge.Text = ("MP: " + Globals.Player1MP + " / " + Globals.Player1MaxMP);

                    Globals.Player2HP = Globals.Player2MaxHP;
                    Globals.Player2MP = Globals.Player2MaxMP;
                    this.Player2HPGauge.Text = (Globals.Player2Name + " HP: " + Convert.ToString(Globals.Player2HP) + "/ " + Convert.ToString(Globals.Player2MaxHP));
                    this.Player2MPGauge.Text = ("MP: " + Globals.Player2MP + " / " + Globals.Player2MaxMP);

                    Globals.Player3HP = Globals.Player3MaxHP;
                    Globals.Player3MP = Globals.Player3MaxMP;
                    this.Player3HPGauge.Text = (Globals.Player3Name + " HP: " + Convert.ToString(Globals.Player3HP) + "/ " + Convert.ToString(Globals.Player3MaxHP));
                    this.Player3MPGauge.Text = ("MP: " + Globals.Player3MP + " / " + Globals.Player3MaxMP);

                    Globals.Player4HP = Globals.Player4MaxHP;
                    Globals.Player4MP = Globals.Player4MaxMP;
                    this.Player4HPGauge.Text = (Globals.Player4Name + " HP: " + Convert.ToString(Globals.Player4HP) + "/ " + Convert.ToString(Globals.Player4MaxHP));
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.PlayerTurn == 0) { this.PlayerBackpack.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 1) { this.Player1ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 2) { this.Player2ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 3) { this.Player3ActList.Items.Remove(" Tent"); }
                    if (Globals.PlayerTurn == 4) { this.Player4ActList.Items.Remove(" Tent"); }

                    this.Player1ActList.Enabled = true;
                    this.Player2ActList.Enabled = true;
                    this.Player3ActList.Enabled = true;
                    this.Player4ActList.Enabled = true;
                    ResetPlayer1Position();
                    ResetPlayer2Position();
                    ResetPlayer3Position();
                    ResetPlayer4Position();


                }

                if (selsummon == 9)
                {

                    this.Gameweapon.Image = global::ffgameRedux.Properties.Resources.sum_baham;
                    this.Gameweapon.Size = new Size(global::ffgameRedux.Properties.Resources.sum_baham.Width, global::ffgameRedux.Properties.Resources.sum_baham.Height);
                    this.Gameweapon.Location = new Point(380, 120);
                    this.Gameweapon.Visible = true;
                    this.Refresh();
                    Thread.Sleep(400);



                    Thread.Sleep(100);
                    int animspeed = 29;
                    Image PreBG = this.Background.Image;
                    int PreWinlocX = this.Location.X;
                    int PreWinlocY = this.Location.Y;
                    int lc = 0;
                    while (lc < 20)
                    {

                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo1;
                        this.Location = new Point(PreWinlocX - 5, PreWinlocY - 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo2;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo3;
                        this.Location = new Point(PreWinlocX + 5, PreWinlocY + 5);
                        this.Refresh();
                        Thread.Sleep(animspeed);
                        this.Background.Image = global::ffgameRedux.Properties.Resources.meteo4;
                        this.Location = new Point(PreWinlocX, PreWinlocY);
                        this.Refresh();
                        Thread.Sleep(animspeed);

                        lc++;
                    }

                    this.Background.Image = PreBG;
                    this.Refresh();
                    Thread.Sleep(250);
                    this.Gameweapon.Visible = false;
                    //dmg step
                    int BaseDMG;

                    BaseDMG = (Globals.Floor * 3
                        + Globals.Player1Attack + Globals.Player1Defense + Globals.Player1Speed + Globals.Player1MaxHP //p1 max formore dmg
                        + Globals.Player2Attack + Globals.Player2Defense + Globals.Player2Speed + Globals.Player2HP
                        + Globals.Player3Attack + Globals.Player3Defense + Globals.Player3Speed + Globals.Player3HP
                        + Globals.Player4Attack + Globals.Player4Defense + Globals.Player4Speed + Globals.Player4HP
                        );
                    this.Text = Convert.ToString(BaseDMG);
                    Thread.Sleep(1000);
                    Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
                    this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width, Enemy1.Location.Y);
                    this.DMGLabel.Text = Convert.ToString(BaseDMG);
                    this.DMGLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(600);
                    this.DMGLabel.Visible = false;
                    this.Text = Convert.ToString(Globals.EnemyHP);
                    Globals.Player4MP = Globals.Player4MP - 12;
                    this.Player4MPGauge.Text = ("MP: " + Globals.Player4MP + " / " + Globals.Player4MaxMP);
                    if (Globals.EnemyHP <= 0)
                    {
                        this.Enemy1.Visible = false;
                        Globals.EnemyHP = 0;
                        this.Refresh();


                    }

                }
            }

            ResetPlayer4Position();

        }


        private void Player3JoinsTheParty() {

            string [] bruh = { "0", "1", "2" };
            this.Player3.Visible = true;
            Globals.PartySize = bruh;
            Globals.Player3IsDead = false;
            


            this.ActListBG.Controls.Add(Player3ActList);
            this.HPBackground.Controls.Add(Player3HPGauge);
            this.HPBackground.Controls.Add(Player3MPGauge);


        }

        private void Player4JoinsTheParty()
        {

            string[] bruh = { "0", "1", "2", "3"};
            this.Player4.Visible = true;
            Globals.PartySize = bruh;
            Globals.Player4IsDead = false;



            this.ActListBG.Controls.Add(Player4ActList);
            this.HPBackground.Controls.Add(Player4HPGauge);
            this.HPBackground.Controls.Add(Player4MPGauge);


        }


        private void P1Tools()
        {
            //also crit
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);
            int SawRank = rand.Next(0, Globals.BossTech.Length);

            // get into position
            this.Player1.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Height /2);

            //beyblade 
            int beyblade = 0;
            Gameweapon.Visible = true;
            int beytimer = 30;
            while ( beyblade < 5)
            {


                //down
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player1.Location.X + Player1.Width / 2, Player1.Location.Y + this.Player1.Height);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_d; 
                this.Refresh();
                Thread.Sleep(beytimer);

                //righ
                
                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player1.Location.X + Player1.Width, Player1.Location.Y + this.Player1.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_r;
                this.Refresh();
                Thread.Sleep(beytimer);

                //up
                this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player1.Location.X - Player1.Width / 2, Player1.Location.Y - 64);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_u;
                this.Refresh();
                Thread.Sleep(beytimer);

                //eft
                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player1.Location.X - 64, Player1.Location.Y + this.Player1.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_l;
                this.Refresh();
                Thread.Sleep(beytimer);

                beyblade++;
            }

            // DMG Step

            int BaseDMG = 0;
            if (SawRank == 0 || SawRank == 1 || SawRank == 2)
            {
                BaseDMG = Globals.Player1Attack * 2;
            }
            if (SawRank == 4 || SawRank == 5 )
            {
                BaseDMG = Globals.Player1Attack / 2;
            }
            BaseDMG = BaseDMG + Globals.Floor;
            if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG * 2; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            this.Text = Convert.ToString(Globals.EnemyHP);
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }


            if (Globals.Player1Speed > CritVal) { BaseDMG = BaseDMG / 2; }

            Gameweapon.Visible = false;
            ResetPlayer1Position();
            this.Refresh();
            Thread.Sleep(540);
        }

        private void P2Tools()
        {
            //also crit
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);
            int SawRank = rand.Next(0, Globals.BossTech.Length);

            // get into position
            this.Player2.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Height / 2);

            //beyblade 
            int beyblade = 0;
            Gameweapon.Visible = true;
            int beytimer = 30;
            while (beyblade < 5)
            {


                //down
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player2.Location.X + Player2.Width / 2, Player2.Location.Y + this.Player2.Height);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_d;
                this.Refresh();
                Thread.Sleep(beytimer);

                //righ

                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player2.Location.X + Player2.Width, Player2.Location.Y + this.Player2.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_r;
                this.Refresh();
                Thread.Sleep(beytimer);

                //up
                this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player2.Location.X - Player2.Width / 2, Player2.Location.Y - 64);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_u;
                this.Refresh();
                Thread.Sleep(beytimer);

                //eft
                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player2.Location.X - 64, Player2.Location.Y + this.Player2.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_l;
                this.Refresh();
                Thread.Sleep(beytimer);

                beyblade++;
            }

            // DMG Step

            int BaseDMG = 0;
            if (SawRank == 0 || SawRank == 1 || SawRank == 2)
            {
                BaseDMG = Globals.Player2Attack * 2;
            }
            if (SawRank == 4 || SawRank == 5)
            {
                BaseDMG = Globals.Player2Attack / 2;
            }
            BaseDMG = BaseDMG + Globals.Floor;
            if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG * 2; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            this.Text = Convert.ToString(Globals.EnemyHP);
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }


            if (Globals.Player2Speed > CritVal) { BaseDMG = BaseDMG / 2; }

            Gameweapon.Visible = false;
            ResetPlayer2Position();
            this.Refresh();
            Thread.Sleep(540);
        }
        private void P3Tools()
        {
            //also crit
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);
            int SawRank = rand.Next(0, Globals.BossTech.Length);

            // get into position
            this.Player3.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Height / 2);

            //beyblade 
            int beyblade = 0;
            Gameweapon.Visible = true;
            int beytimer = 30;
            while (beyblade < 5)
            {


                //down
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player3.Location.X + Player3.Width / 2, Player3.Location.Y + this.Player3.Height);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_d;
                this.Refresh();
                Thread.Sleep(beytimer);

                //righ

                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player3.Location.X + Player3.Width, Player3.Location.Y + this.Player3.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_r;
                this.Refresh();
                Thread.Sleep(beytimer);

                //up
                this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player3.Location.X - Player3.Width / 2, Player3.Location.Y - 64);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_u;
                this.Refresh();
                Thread.Sleep(beytimer);

                //eft
                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player3.Location.X - 64, Player3.Location.Y + this.Player3.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_l;
                this.Refresh();
                Thread.Sleep(beytimer);

                beyblade++;
            }

            // DMG Step

            int BaseDMG = 0;
            if (SawRank == 0 || SawRank == 1 || SawRank == 2)
            {
                BaseDMG = Globals.Player3Attack * 2;
            }
            if (SawRank == 4 || SawRank == 5)
            {
                BaseDMG = Globals.Player3Attack / 2;
            }
            BaseDMG = BaseDMG + Globals.Floor;
            if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG * 2; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            this.Text = Convert.ToString(Globals.EnemyHP);
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }


            if (Globals.Player3Speed > CritVal) { BaseDMG = BaseDMG / 2; }

            Gameweapon.Visible = false;
            ResetPlayer3Position();
            this.Refresh();
            Thread.Sleep(540);
        }
        private void P4Tools()
        {
            //also crit
            Random rand = new Random();
            int CritVal = rand.Next(0, Globals.CritArray.Length);
            int SawRank = rand.Next(0, Globals.BossTech.Length);

            // get into position
            this.Player4.Location = new Point(this.Enemy1.Location.X + this.Enemy1.Width + 32, this.Enemy1.Location.Y + this.Enemy1.Height / 2);

            //beyblade 
            int beyblade = 0;
            Gameweapon.Visible = true;
            int beytimer = 30;
            while (beyblade < 5)
            {


                //down
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_r2;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player4.Location.X + Player4.Width / 2, Player4.Location.Y + this.Player4.Height);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_d;
                this.Refresh();
                Thread.Sleep(beytimer);

                //righ

                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player4.Location.X + Player4.Width, Player4.Location.Y + this.Player4.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_r;
                this.Refresh();
                Thread.Sleep(beytimer);

                //up
                this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_r;
                Gameweapon.Size = new Size(32, 64);
                Gameweapon.Location = new Point(Player4.Location.X - Player4.Width / 2, Player4.Location.Y - 64);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_u;
                this.Refresh();
                Thread.Sleep(beytimer);

                //eft
                Gameweapon.Size = new Size(64, 32);
                Gameweapon.Location = new Point(Player4.Location.X - 64, Player4.Location.Y + this.Player4.Height - 20);
                Gameweapon.Image = global::ffgameRedux.Properties.Resources.Saw_l;
                this.Refresh();
                Thread.Sleep(beytimer);

                beyblade++;
            }

            // DMG Step

            int BaseDMG = 0;
            if (SawRank == 0 || SawRank == 1 || SawRank == 2)
            {
                BaseDMG = Globals.Player2Attack * 2;
            }
            if (SawRank == 4 || SawRank == 5)
            {
                BaseDMG = Globals.Player4Attack / 2;
            }
            BaseDMG = BaseDMG + Globals.Floor;
            if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG * 2; }

            Globals.EnemyHP = Globals.EnemyHP - BaseDMG;
            this.DMGLabel.Location = new Point(Enemy1.Location.X + Enemy1.Size.Width - 30, Enemy1.Location.Y - 30);
            this.DMGLabel.Text = Convert.ToString(BaseDMG);
            this.DMGLabel.Visible = true;
            this.Refresh();
            Thread.Sleep(600);
            this.DMGLabel.Visible = false;
            this.Text = Convert.ToString(Globals.EnemyHP);
            if (Globals.EnemyHP <= 0)
            {
                this.Enemy1.Visible = false;
                Globals.EnemyHP = 0;
                this.Refresh();
                // Load next floor

            }


            if (Globals.Player4Speed > CritVal) { BaseDMG = BaseDMG / 2; }

            Gameweapon.Visible = false;
            ResetPlayer4Position();
            this.Refresh();
            Thread.Sleep(540);
        }


        private void EndingSequence()
        {

            //reset player icons
            ResetPlayer1Position();
            ResetPlayer2Position();
            ResetPlayer3Position();
            ResetPlayer4Position();

            this.Enemy1.Visible = false;
            Globals.MusicPlayer.controls.stop();
            Globals.MusicPlayer.URL = "data/smwc.mp3";
            Globals.MusicPlayer.controls.play();

            this.Player1.Location = new Point(250, 220);
            this.Player2.Location = new Point(350, 220);
            this.Player3.Location = new Point(450, 220);
            this.Player4.Location = new Point(550, 220);

            this.Player1ActList.Enabled = false;
            this.Player2ActList.Enabled = false;
            this.Player3ActList.Enabled = false;
            this.Player4ActList.Enabled = false;

            this.MenuButton.Enabled = false;
            this.EngageButton.Enabled = false;
            this.PlayerBackpack.Enabled = false;

            Globals.DanceAnim.Interval = 1000;
            Globals.DanceAnim.Tick += AnimateCharacters;
            Globals.DanceAnim.Start();

            // party is now doing the dance


        }


        void AnimateCharacters(object sender, EventArgs e)
        {

            #region DanceAnimStolen

            int DanceCooldown = 300;
            if (Globals.Player1IsDead == false)
            {

                if (Globals.Player1Name == "Luneth")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player1Name == "Warrior")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player1Name == "Thief")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player1Name == "Cid")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player1Name == "Rydia")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player1Name == "Edgar")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player2IsDead == false)
            {

                if (Globals.Player2Name == "Luneth")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player2Name == "Warrior")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player2Name == "Thief")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player2Name == "Cid")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player2Name == "Rydia")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player2Name == "Edgar")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player3IsDead == false)
            {

                if (Globals.Player3Name == "Luneth")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player3Name == "Warrior")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player3Name == "Thief")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player3Name == "Cid")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player3Name == "Rydia")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player3Name == "Edgar")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            if (Globals.Player4IsDead == false)
            {

                if (Globals.Player4Name == "Luneth")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_w;
                }

                if (Globals.Player4Name == "Warrior")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_w;
                }

                if (Globals.Player4Name == "Thief")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_w;
                }

                if (Globals.Player4Name == "Cid")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_w;
                }
                if (Globals.Player4Name == "Rydia")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_w;
                }
                if (Globals.Player4Name == "Edgar")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_w;
                }
            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);

            this.Refresh();
            Thread.Sleep(DanceCooldown);
            if (Globals.Player1IsDead == false)
            {

                if (Globals.Player1Name == "Luneth")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.onion_s;
                }

                if (Globals.Player1Name == "Warrior")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.war_s;
                }

                if (Globals.Player1Name == "Thief")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.thief_s;
                }

                if (Globals.Player1Name == "Cid")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.cid_s;
                }
                if (Globals.Player1Name == "Rydia")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                }
                if (Globals.Player1Name == "Edgar")
                {
                    this.Player1.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                }
            }
            if (Globals.Player2IsDead == false)
            {

                if (Globals.Player2Name == "Luneth")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.onion_s;
                }

                if (Globals.Player2Name == "Warrior")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.war_s;
                }

                if (Globals.Player2Name == "Thief")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.thief_s;
                }

                if (Globals.Player2Name == "Cid")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.cid_s;
                }
                if (Globals.Player2Name == "Rydia")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                }
                if (Globals.Player2Name == "Edgar")
                {
                    this.Player2.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                }
            }
            if (Globals.Player3IsDead == false)
            {

                if (Globals.Player3Name == "Luneth")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.onion_s;
                }

                if (Globals.Player3Name == "Warrior")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.war_s;
                }

                if (Globals.Player3Name == "Thief")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.thief_s;
                }

                if (Globals.Player3Name == "Cid")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.cid_s;
                }
                if (Globals.Player3Name == "Rydia")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                }
                if (Globals.Player3Name == "Edgar")
                {
                    this.Player3.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                }
            }
            if (Globals.Player4IsDead == false)
            {

                if (Globals.Player4Name == "Luneth")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.onion_s;
                }

                if (Globals.Player4Name == "Warrior")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.war_s;
                }

                if (Globals.Player4Name == "Thief")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.thief_s;
                }

                if (Globals.Player4Name == "Cid")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.cid_s;
                }
                if (Globals.Player4Name == "Rydia")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.rydia_s;
                }
                if (Globals.Player4Name == "Edgar")
                {
                    this.Player4.Image = global::ffgameRedux.Properties.Resources.edgar_s;
                }
            }
            this.Refresh();
            Thread.Sleep(DanceCooldown);
            #endregion DanceAnimStolen

            //party doin the thing

            
            this.Player1HPGauge.Text = "Reload the game and go to the menu,";
            this.Player2HPGauge.Text = "and push PageUp and then the ESC key";
            this.Player3HPGauge.Text = "to trigger a secret Boss Fight!";
            this.Player4HPGauge.Text = "Programmed by Scatfone.";

            this.PartyRank.Text = "Party Rank: SS";
            this.PartyScore.Text = "Party Score: MAX";
            
            this.Player1MPGauge.Text = "";
            this.Player2MPGauge.Text = "";
            this.Player3MPGauge.Text = "";
            this.Player4MPGauge.Text = "YOU WIN!";

        }

        private PictureBox Player1;
        private Label Player1HPGauge;
        private Label Player2HPGauge;
        private Label Player3HPGauge;
        private Label Player4HPGauge;
        private Button EngageButton;
        private PictureBox Player2;
        private PictureBox Player3;
        private PictureBox Player4;
        private PictureBox Enemy1;
        private PictureBox Background;
        private PictureBox HPBackground;
        private ListBox Player1ActList;
        private ListBox Player2ActList;
        private ListBox Player3ActList;
        private ListBox Player4ActList;
        private ListBox PlayerBackpack;
        private Label Player1MPGauge;
        private Label Player2MPGauge;
        private Label PartyRank;
        private Label PartyScore;
        private Label Player3MPGauge;
        private Label Player4MPGauge;
        private PictureBox InfoBG;
        private PictureBox ActListBG;
        private Label DMGLabel;
        private PictureBox BatBG;
        private PictureBox SpellWeapon;
        private PictureBox Gameweapon;
        private PictureBox SummonWeapon;
        private Button MenuButton;
        private Form MenuWin;
        private Label StatGraph;
    }


}
