namespace DictionaryApp
{
    partial class FormHangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangman));
            this.PanelLetters = new System.Windows.Forms.Panel();
            this.ButtonZ = new System.Windows.Forms.Button();
            this.ButtonY = new System.Windows.Forms.Button();
            this.ButtonX = new System.Windows.Forms.Button();
            this.ButtonW = new System.Windows.Forms.Button();
            this.ButtonV = new System.Windows.Forms.Button();
            this.ButtonU = new System.Windows.Forms.Button();
            this.ButtonT = new System.Windows.Forms.Button();
            this.ButtonS = new System.Windows.Forms.Button();
            this.ButtonR = new System.Windows.Forms.Button();
            this.ButtonQ = new System.Windows.Forms.Button();
            this.ButtonP = new System.Windows.Forms.Button();
            this.ButtonO = new System.Windows.Forms.Button();
            this.ButtonN = new System.Windows.Forms.Button();
            this.ButtonM = new System.Windows.Forms.Button();
            this.ButtonL = new System.Windows.Forms.Button();
            this.ButtonK = new System.Windows.Forms.Button();
            this.ButtonJ = new System.Windows.Forms.Button();
            this.ButtonI = new System.Windows.Forms.Button();
            this.ButtonH = new System.Windows.Forms.Button();
            this.ButtonG = new System.Windows.Forms.Button();
            this.ButtonF = new System.Windows.Forms.Button();
            this.ButtonE = new System.Windows.Forms.Button();
            this.ButtonD = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonA = new System.Windows.Forms.Button();
            this.PictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.PictureBoxHint = new System.Windows.Forms.PictureBox();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.LabelGuess = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.LabelReady = new System.Windows.Forms.Label();
            this.TimerReady = new System.Windows.Forms.Timer(this.components);
            this.LabelRules = new System.Windows.Forms.Label();
            this.PanelRules = new System.Windows.Forms.Panel();
            this.CheckBoxShowRules = new System.Windows.Forms.CheckBox();
            this.ButtonOKRules = new System.Windows.Forms.Button();
            this.ButtonCont = new System.Windows.Forms.Button();
            this.LabelMeaning = new System.Windows.Forms.Label();
            this.LabelRound = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.PanelLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHangman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHint)).BeginInit();
            this.PanelRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLetters
            // 
            this.PanelLetters.Controls.Add(this.ButtonZ);
            this.PanelLetters.Controls.Add(this.ButtonY);
            this.PanelLetters.Controls.Add(this.ButtonX);
            this.PanelLetters.Controls.Add(this.ButtonW);
            this.PanelLetters.Controls.Add(this.ButtonV);
            this.PanelLetters.Controls.Add(this.ButtonU);
            this.PanelLetters.Controls.Add(this.ButtonT);
            this.PanelLetters.Controls.Add(this.ButtonS);
            this.PanelLetters.Controls.Add(this.ButtonR);
            this.PanelLetters.Controls.Add(this.ButtonQ);
            this.PanelLetters.Controls.Add(this.ButtonP);
            this.PanelLetters.Controls.Add(this.ButtonO);
            this.PanelLetters.Controls.Add(this.ButtonN);
            this.PanelLetters.Controls.Add(this.ButtonM);
            this.PanelLetters.Controls.Add(this.ButtonL);
            this.PanelLetters.Controls.Add(this.ButtonK);
            this.PanelLetters.Controls.Add(this.ButtonJ);
            this.PanelLetters.Controls.Add(this.ButtonI);
            this.PanelLetters.Controls.Add(this.ButtonH);
            this.PanelLetters.Controls.Add(this.ButtonG);
            this.PanelLetters.Controls.Add(this.ButtonF);
            this.PanelLetters.Controls.Add(this.ButtonE);
            this.PanelLetters.Controls.Add(this.ButtonD);
            this.PanelLetters.Controls.Add(this.ButtonB);
            this.PanelLetters.Controls.Add(this.ButtonC);
            this.PanelLetters.Controls.Add(this.ButtonA);
            this.PanelLetters.Location = new System.Drawing.Point(0, 656);
            this.PanelLetters.Name = "PanelLetters";
            this.PanelLetters.Size = new System.Drawing.Size(782, 306);
            this.PanelLetters.TabIndex = 2;
            this.PanelLetters.Visible = false;
            // 
            // ButtonZ
            // 
            this.ButtonZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonZ.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZ.Location = new System.Drawing.Point(677, 215);
            this.ButtonZ.Name = "ButtonZ";
            this.ButtonZ.Size = new System.Drawing.Size(60, 60);
            this.ButtonZ.TabIndex = 25;
            this.ButtonZ.TabStop = false;
            this.ButtonZ.Text = "Z";
            this.ButtonZ.UseVisualStyleBackColor = true;
            this.ButtonZ.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonY
            // 
            this.ButtonY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonY.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonY.Location = new System.Drawing.Point(586, 215);
            this.ButtonY.Name = "ButtonY";
            this.ButtonY.Size = new System.Drawing.Size(60, 60);
            this.ButtonY.TabIndex = 24;
            this.ButtonY.TabStop = false;
            this.ButtonY.Text = "Y";
            this.ButtonY.UseVisualStyleBackColor = true;
            this.ButtonY.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonX
            // 
            this.ButtonX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonX.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX.Location = new System.Drawing.Point(496, 215);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(60, 60);
            this.ButtonX.TabIndex = 23;
            this.ButtonX.TabStop = false;
            this.ButtonX.Text = "X";
            this.ButtonX.UseVisualStyleBackColor = true;
            this.ButtonX.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonW
            // 
            this.ButtonW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonW.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonW.Location = new System.Drawing.Point(406, 215);
            this.ButtonW.Name = "ButtonW";
            this.ButtonW.Size = new System.Drawing.Size(60, 60);
            this.ButtonW.TabIndex = 22;
            this.ButtonW.TabStop = false;
            this.ButtonW.Text = "W";
            this.ButtonW.UseVisualStyleBackColor = true;
            this.ButtonW.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonV
            // 
            this.ButtonV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonV.Location = new System.Drawing.Point(316, 215);
            this.ButtonV.Name = "ButtonV";
            this.ButtonV.Size = new System.Drawing.Size(60, 60);
            this.ButtonV.TabIndex = 21;
            this.ButtonV.TabStop = false;
            this.ButtonV.Text = "V";
            this.ButtonV.UseVisualStyleBackColor = true;
            this.ButtonV.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonU
            // 
            this.ButtonU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonU.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonU.Location = new System.Drawing.Point(225, 215);
            this.ButtonU.Name = "ButtonU";
            this.ButtonU.Size = new System.Drawing.Size(60, 60);
            this.ButtonU.TabIndex = 20;
            this.ButtonU.TabStop = false;
            this.ButtonU.Text = "U";
            this.ButtonU.UseVisualStyleBackColor = true;
            this.ButtonU.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonT
            // 
            this.ButtonT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonT.Location = new System.Drawing.Point(135, 215);
            this.ButtonT.Name = "ButtonT";
            this.ButtonT.Size = new System.Drawing.Size(60, 60);
            this.ButtonT.TabIndex = 19;
            this.ButtonT.TabStop = false;
            this.ButtonT.Text = "T";
            this.ButtonT.UseVisualStyleBackColor = true;
            this.ButtonT.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonS
            // 
            this.ButtonS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonS.Location = new System.Drawing.Point(46, 215);
            this.ButtonS.Name = "ButtonS";
            this.ButtonS.Size = new System.Drawing.Size(60, 60);
            this.ButtonS.TabIndex = 18;
            this.ButtonS.TabStop = false;
            this.ButtonS.Text = "S";
            this.ButtonS.UseVisualStyleBackColor = true;
            this.ButtonS.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonR
            // 
            this.ButtonR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonR.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonR.Location = new System.Drawing.Point(722, 124);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(60, 60);
            this.ButtonR.TabIndex = 17;
            this.ButtonR.TabStop = false;
            this.ButtonR.Text = "R";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonQ
            // 
            this.ButtonQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonQ.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQ.Location = new System.Drawing.Point(631, 124);
            this.ButtonQ.Name = "ButtonQ";
            this.ButtonQ.Size = new System.Drawing.Size(60, 60);
            this.ButtonQ.TabIndex = 16;
            this.ButtonQ.TabStop = false;
            this.ButtonQ.Text = "Q";
            this.ButtonQ.UseVisualStyleBackColor = true;
            this.ButtonQ.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonP
            // 
            this.ButtonP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonP.Location = new System.Drawing.Point(541, 124);
            this.ButtonP.Name = "ButtonP";
            this.ButtonP.Size = new System.Drawing.Size(60, 60);
            this.ButtonP.TabIndex = 15;
            this.ButtonP.TabStop = false;
            this.ButtonP.Text = "P";
            this.ButtonP.UseVisualStyleBackColor = true;
            this.ButtonP.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonO
            // 
            this.ButtonO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonO.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonO.Location = new System.Drawing.Point(451, 124);
            this.ButtonO.Name = "ButtonO";
            this.ButtonO.Size = new System.Drawing.Size(60, 60);
            this.ButtonO.TabIndex = 14;
            this.ButtonO.TabStop = false;
            this.ButtonO.Text = "O";
            this.ButtonO.UseVisualStyleBackColor = true;
            this.ButtonO.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonN
            // 
            this.ButtonN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonN.Location = new System.Drawing.Point(361, 124);
            this.ButtonN.Name = "ButtonN";
            this.ButtonN.Size = new System.Drawing.Size(60, 60);
            this.ButtonN.TabIndex = 13;
            this.ButtonN.TabStop = false;
            this.ButtonN.Text = "N";
            this.ButtonN.UseVisualStyleBackColor = true;
            this.ButtonN.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonM
            // 
            this.ButtonM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonM.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonM.Location = new System.Drawing.Point(270, 124);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(60, 60);
            this.ButtonM.TabIndex = 12;
            this.ButtonM.TabStop = false;
            this.ButtonM.Text = "M";
            this.ButtonM.UseVisualStyleBackColor = true;
            this.ButtonM.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonL
            // 
            this.ButtonL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonL.Location = new System.Drawing.Point(180, 124);
            this.ButtonL.Name = "ButtonL";
            this.ButtonL.Size = new System.Drawing.Size(60, 60);
            this.ButtonL.TabIndex = 11;
            this.ButtonL.TabStop = false;
            this.ButtonL.Text = "L";
            this.ButtonL.UseVisualStyleBackColor = true;
            this.ButtonL.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonK
            // 
            this.ButtonK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonK.Location = new System.Drawing.Point(91, 124);
            this.ButtonK.Name = "ButtonK";
            this.ButtonK.Size = new System.Drawing.Size(60, 60);
            this.ButtonK.TabIndex = 10;
            this.ButtonK.TabStop = false;
            this.ButtonK.Text = "K";
            this.ButtonK.UseVisualStyleBackColor = true;
            this.ButtonK.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonJ
            // 
            this.ButtonJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonJ.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonJ.Location = new System.Drawing.Point(0, 124);
            this.ButtonJ.Name = "ButtonJ";
            this.ButtonJ.Size = new System.Drawing.Size(60, 60);
            this.ButtonJ.TabIndex = 9;
            this.ButtonJ.TabStop = false;
            this.ButtonJ.Text = "J";
            this.ButtonJ.UseVisualStyleBackColor = true;
            this.ButtonJ.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonI
            // 
            this.ButtonI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonI.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonI.Location = new System.Drawing.Point(722, 33);
            this.ButtonI.Name = "ButtonI";
            this.ButtonI.Size = new System.Drawing.Size(60, 60);
            this.ButtonI.TabIndex = 8;
            this.ButtonI.TabStop = false;
            this.ButtonI.Text = "I";
            this.ButtonI.UseVisualStyleBackColor = true;
            this.ButtonI.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonH
            // 
            this.ButtonH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonH.Location = new System.Drawing.Point(631, 33);
            this.ButtonH.Name = "ButtonH";
            this.ButtonH.Size = new System.Drawing.Size(60, 60);
            this.ButtonH.TabIndex = 7;
            this.ButtonH.TabStop = false;
            this.ButtonH.Text = "H";
            this.ButtonH.UseVisualStyleBackColor = true;
            this.ButtonH.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonG
            // 
            this.ButtonG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonG.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonG.Location = new System.Drawing.Point(541, 33);
            this.ButtonG.Name = "ButtonG";
            this.ButtonG.Size = new System.Drawing.Size(60, 60);
            this.ButtonG.TabIndex = 6;
            this.ButtonG.TabStop = false;
            this.ButtonG.Text = "G";
            this.ButtonG.UseVisualStyleBackColor = true;
            this.ButtonG.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonF
            // 
            this.ButtonF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonF.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonF.Location = new System.Drawing.Point(451, 33);
            this.ButtonF.Name = "ButtonF";
            this.ButtonF.Size = new System.Drawing.Size(60, 60);
            this.ButtonF.TabIndex = 5;
            this.ButtonF.TabStop = false;
            this.ButtonF.Text = "F";
            this.ButtonF.UseVisualStyleBackColor = true;
            this.ButtonF.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonE
            // 
            this.ButtonE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonE.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonE.Location = new System.Drawing.Point(361, 33);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(60, 60);
            this.ButtonE.TabIndex = 4;
            this.ButtonE.TabStop = false;
            this.ButtonE.Text = "E";
            this.ButtonE.UseVisualStyleBackColor = true;
            this.ButtonE.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonD
            // 
            this.ButtonD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonD.Location = new System.Drawing.Point(270, 33);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(60, 60);
            this.ButtonD.TabIndex = 3;
            this.ButtonD.TabStop = false;
            this.ButtonD.Text = "D";
            this.ButtonD.UseVisualStyleBackColor = true;
            this.ButtonD.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonB
            // 
            this.ButtonB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonB.Location = new System.Drawing.Point(91, 33);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(60, 60);
            this.ButtonB.TabIndex = 2;
            this.ButtonB.TabStop = false;
            this.ButtonB.Text = "B";
            this.ButtonB.UseVisualStyleBackColor = true;
            this.ButtonB.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonC
            // 
            this.ButtonC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC.Location = new System.Drawing.Point(180, 33);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(60, 60);
            this.ButtonC.TabIndex = 1;
            this.ButtonC.TabStop = false;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // ButtonA
            // 
            this.ButtonA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonA.Location = new System.Drawing.Point(0, 33);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(60, 60);
            this.ButtonA.TabIndex = 0;
            this.ButtonA.TabStop = false;
            this.ButtonA.Text = "A";
            this.ButtonA.UseVisualStyleBackColor = true;
            this.ButtonA.Click += new System.EventHandler(this.ButtonLettersClick);
            // 
            // PictureBoxHangman
            // 
            this.PictureBoxHangman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxHangman.BackgroundImage = global::DictionaryApp.Properties.Resources.hangman0;
            this.PictureBoxHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxHangman.Location = new System.Drawing.Point(281, 204);
            this.PictureBoxHangman.Name = "PictureBoxHangman";
            this.PictureBoxHangman.Size = new System.Drawing.Size(301, 353);
            this.PictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHangman.TabIndex = 3;
            this.PictureBoxHangman.TabStop = false;
            this.PictureBoxHangman.Visible = false;
            // 
            // PictureBoxHint
            // 
            this.PictureBoxHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxHint.Location = new System.Drawing.Point(665, 163);
            this.PictureBoxHint.Name = "PictureBoxHint";
            this.PictureBoxHint.Size = new System.Drawing.Size(671, 376);
            this.PictureBoxHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHint.TabIndex = 0;
            this.PictureBoxHint.TabStop = false;
            this.PictureBoxHint.Visible = false;
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonQuit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.Location = new System.Drawing.Point(39, 989);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(113, 39);
            this.ButtonQuit.TabIndex = 4;
            this.ButtonQuit.TabStop = false;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Visible = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // LabelGuess
            // 
            this.LabelGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuess.Location = new System.Drawing.Point(0, 599);
            this.LabelGuess.Name = "LabelGuess";
            this.LabelGuess.Size = new System.Drawing.Size(1922, 55);
            this.LabelGuess.TabIndex = 5;
            this.LabelGuess.Text = "_ _ _ _ _ _ _ _";
            this.LabelGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGuess.Visible = false;
            // 
            // TimeLimit
            // 
            this.TimeLimit.Interval = 1000;
            this.TimeLimit.Tick += new System.EventHandler(this.TimeLimit_Tick);
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeLeft.ForeColor = System.Drawing.Color.Black;
            this.LabelTimeLeft.Location = new System.Drawing.Point(1721, 99);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(143, 27);
            this.LabelTimeLeft.TabIndex = 6;
            this.LabelTimeLeft.Text = "Time left: 60s";
            this.LabelTimeLeft.Visible = false;
            // 
            // LabelReady
            // 
            this.LabelReady.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReady.Location = new System.Drawing.Point(1752, 204);
            this.LabelReady.Name = "LabelReady";
            this.LabelReady.Size = new System.Drawing.Size(90, 111);
            this.LabelReady.TabIndex = 8;
            this.LabelReady.Text = "3";
            this.LabelReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelReady.Visible = false;
            // 
            // TimerReady
            // 
            this.TimerReady.Interval = 1000;
            this.TimerReady.Tick += new System.EventHandler(this.TimerReady_Tick);
            // 
            // LabelRules
            // 
            this.LabelRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRules.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRules.Location = new System.Drawing.Point(3, 0);
            this.LabelRules.Name = "LabelRules";
            this.LabelRules.Size = new System.Drawing.Size(942, 289);
            this.LabelRules.TabIndex = 9;
            this.LabelRules.Text = resources.GetString("LabelRules.Text");
            this.LabelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRules
            // 
            this.PanelRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelRules.Controls.Add(this.CheckBoxShowRules);
            this.PanelRules.Controls.Add(this.ButtonOKRules);
            this.PanelRules.Controls.Add(this.LabelRules);
            this.PanelRules.Location = new System.Drawing.Point(788, 666);
            this.PanelRules.Name = "PanelRules";
            this.PanelRules.Size = new System.Drawing.Size(948, 383);
            this.PanelRules.TabIndex = 10;
            this.PanelRules.Visible = false;
            // 
            // CheckBoxShowRules
            // 
            this.CheckBoxShowRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBoxShowRules.AutoSize = true;
            this.CheckBoxShowRules.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowRules.Location = new System.Drawing.Point(266, 323);
            this.CheckBoxShowRules.Name = "CheckBoxShowRules";
            this.CheckBoxShowRules.Size = new System.Drawing.Size(174, 22);
            this.CheckBoxShowRules.TabIndex = 11;
            this.CheckBoxShowRules.Text = "Don\'t show this again";
            this.CheckBoxShowRules.UseVisualStyleBackColor = true;
            // 
            // ButtonOKRules
            // 
            this.ButtonOKRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOKRules.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOKRules.Location = new System.Drawing.Point(537, 315);
            this.ButtonOKRules.Name = "ButtonOKRules";
            this.ButtonOKRules.Size = new System.Drawing.Size(125, 36);
            this.ButtonOKRules.TabIndex = 10;
            this.ButtonOKRules.Text = "OK";
            this.ButtonOKRules.UseVisualStyleBackColor = true;
            this.ButtonOKRules.Click += new System.EventHandler(this.ButtonOKRules_Click);
            // 
            // ButtonCont
            // 
            this.ButtonCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCont.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCont.Location = new System.Drawing.Point(1739, 989);
            this.ButtonCont.Name = "ButtonCont";
            this.ButtonCont.Size = new System.Drawing.Size(138, 39);
            this.ButtonCont.TabIndex = 4;
            this.ButtonCont.TabStop = false;
            this.ButtonCont.Text = "Continue";
            this.ButtonCont.UseVisualStyleBackColor = true;
            this.ButtonCont.Visible = false;
            this.ButtonCont.Click += new System.EventHandler(this.ButtonCont_Click);
            // 
            // LabelMeaning
            // 
            this.LabelMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMeaning.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeaning.Location = new System.Drawing.Point(475, 25);
            this.LabelMeaning.Name = "LabelMeaning";
            this.LabelMeaning.Size = new System.Drawing.Size(1051, 135);
            this.LabelMeaning.TabIndex = 11;
            this.LabelMeaning.Text = "meaning";
            this.LabelMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMeaning.Visible = false;
            // 
            // LabelRound
            // 
            this.LabelRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRound.AutoSize = true;
            this.LabelRound.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRound.Location = new System.Drawing.Point(1721, 25);
            this.LabelRound.Name = "LabelRound";
            this.LabelRound.Size = new System.Drawing.Size(100, 27);
            this.LabelRound.TabIndex = 12;
            this.LabelRound.Text = "Round: 1";
            this.LabelRound.Visible = false;
            // 
            // LabelScore
            // 
            this.LabelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ForeColor = System.Drawing.Color.Black;
            this.LabelScore.Location = new System.Drawing.Point(1721, 62);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(90, 27);
            this.LabelScore.TabIndex = 6;
            this.LabelScore.Text = "Score: 0";
            this.LabelScore.Visible = false;
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResult.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(1342, 396);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(782, 46);
            this.LabelResult.TabIndex = 13;
            this.LabelResult.Text = "result";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelResult.Visible = false;
            // 
            // FormHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelRound);
            this.Controls.Add(this.LabelMeaning);
            this.Controls.Add(this.PanelLetters);
            this.Controls.Add(this.PanelRules);
            this.Controls.Add(this.LabelReady);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelTimeLeft);
            this.Controls.Add(this.LabelGuess);
            this.Controls.Add(this.ButtonCont);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.PictureBoxHangman);
            this.Controls.Add(this.PictureBoxHint);
            this.Name = "FormHangman";
            this.Text = "MyDictionary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHangman_FormClosed);
            this.Load += new System.EventHandler(this.FormHangman_Load);
            this.PanelLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHangman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHint)).EndInit();
            this.PanelRules.ResumeLayout(false);
            this.PanelRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxHint;
        private System.Windows.Forms.Panel PanelLetters;
        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.Button ButtonQ;
        private System.Windows.Forms.Button ButtonP;
        private System.Windows.Forms.Button ButtonO;
        private System.Windows.Forms.Button ButtonN;
        private System.Windows.Forms.Button ButtonM;
        private System.Windows.Forms.Button ButtonL;
        private System.Windows.Forms.Button ButtonK;
        private System.Windows.Forms.Button ButtonJ;
        private System.Windows.Forms.Button ButtonI;
        private System.Windows.Forms.Button ButtonH;
        private System.Windows.Forms.Button ButtonG;
        private System.Windows.Forms.Button ButtonF;
        private System.Windows.Forms.Button ButtonE;
        private System.Windows.Forms.Button ButtonD;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonZ;
        private System.Windows.Forms.Button ButtonY;
        private System.Windows.Forms.Button ButtonX;
        private System.Windows.Forms.Button ButtonW;
        private System.Windows.Forms.Button ButtonV;
        private System.Windows.Forms.Button ButtonU;
        private System.Windows.Forms.Button ButtonT;
        private System.Windows.Forms.Button ButtonS;
        private System.Windows.Forms.PictureBox PictureBoxHangman;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Label LabelGuess;
        private System.Windows.Forms.Timer TimeLimit;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Label LabelReady;
        private System.Windows.Forms.Timer TimerReady;
        private System.Windows.Forms.Label LabelRules;
        private System.Windows.Forms.Panel PanelRules;
        private System.Windows.Forms.CheckBox CheckBoxShowRules;
        private System.Windows.Forms.Button ButtonOKRules;
        private System.Windows.Forms.Button ButtonCont;
        private System.Windows.Forms.Label LabelMeaning;
        private System.Windows.Forms.Label LabelRound;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelResult;
    }
}