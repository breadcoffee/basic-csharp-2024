namespace cafePOS
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label6 = new Label();
            labelTime = new Label();
            BtnSeleteCancle = new Button();
            BtnAllCancle = new Button();
            BtnCard = new Button();
            BtnCash = new Button();
            label5 = new Label();
            TxtChangePrice = new TextBox();
            BtnBell7 = new Button();
            BtnBell9 = new Button();
            BtnBell8 = new Button();
            BtnBell4 = new Button();
            BtnBell6 = new Button();
            BtnBell5 = new Button();
            BtnBell1 = new Button();
            BtnBell3 = new Button();
            BtnBell2 = new Button();
            TxtCount = new TextBox();
            TxtTotal = new TextBox();
            TxtPrice = new TextBox();
            TxtRecivePrice = new TextBox();
            BtnBell0 = new Button();
            BtnBellCE = new Button();
            BtnBell00 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TbcMenu = new TabControl();
            tabPage1 = new TabPage();
            BtnEinspannerIce = new Button();
            BtnMochaIce = new Button();
            BtnMochaHot = new Button();
            BtnEinspannerHot = new Button();
            BtnVanilaLatteIce = new Button();
            BtnVanilaLatteHot = new Button();
            BtnCappuccinoHot = new Button();
            BtnLatteIce = new Button();
            BtnLatteHot = new Button();
            BtnEspresso = new Button();
            BtnAmericanoIce = new Button();
            BtnAmericanoHot = new Button();
            tabPage2 = new TabPage();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            LsvOrder = new ListView();
            ClhTitle = new ColumnHeader();
            ClhCount = new ColumnHeader();
            ClhPrice = new ColumnHeader();
            ClhEtc = new ColumnHeader();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            TbcMenu.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelTime);
            groupBox1.Controls.Add(BtnSeleteCancle);
            groupBox1.Controls.Add(BtnAllCancle);
            groupBox1.Controls.Add(BtnCard);
            groupBox1.Controls.Add(BtnCash);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtChangePrice);
            groupBox1.Controls.Add(BtnBell7);
            groupBox1.Controls.Add(BtnBell9);
            groupBox1.Controls.Add(BtnBell8);
            groupBox1.Controls.Add(BtnBell4);
            groupBox1.Controls.Add(BtnBell6);
            groupBox1.Controls.Add(BtnBell5);
            groupBox1.Controls.Add(BtnBell1);
            groupBox1.Controls.Add(BtnBell3);
            groupBox1.Controls.Add(BtnBell2);
            groupBox1.Controls.Add(TxtCount);
            groupBox1.Controls.Add(TxtTotal);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(TxtRecivePrice);
            groupBox1.Controls.Add(BtnBell0);
            groupBox1.Controls.Add(BtnBellCE);
            groupBox1.Controls.Add(BtnBell00);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TbcMenu);
            groupBox1.Controls.Add(LsvOrder);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "주문관리";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 19);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 29;
            label6.Text = "영업일 :";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(555, 19);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(31, 15);
            labelTime.TabIndex = 28;
            labelTime.Text = "날짜";
            // 
            // BtnSeleteCancle
            // 
            BtnSeleteCancle.Location = new Point(520, 356);
            BtnSeleteCancle.Name = "BtnSeleteCancle";
            BtnSeleteCancle.Size = new Size(82, 83);
            BtnSeleteCancle.TabIndex = 27;
            BtnSeleteCancle.Text = "선택취소";
            BtnSeleteCancle.UseVisualStyleBackColor = true;
            BtnSeleteCancle.Click += BtnSeleteCancle_Click;
            // 
            // BtnAllCancle
            // 
            BtnAllCancle.Location = new Point(608, 356);
            BtnAllCancle.Name = "BtnAllCancle";
            BtnAllCancle.Size = new Size(82, 83);
            BtnAllCancle.TabIndex = 26;
            BtnAllCancle.Text = "전체취소";
            BtnAllCancle.UseVisualStyleBackColor = true;
            BtnAllCancle.Click += BtnAllCancle_Click;
            // 
            // BtnCard
            // 
            BtnCard.Location = new Point(432, 355);
            BtnCard.Name = "BtnCard";
            BtnCard.Size = new Size(82, 83);
            BtnCard.TabIndex = 25;
            BtnCard.Text = "카드결제";
            BtnCard.UseVisualStyleBackColor = true;
            BtnCard.Click += BtnCard_Click;
            // 
            // BtnCash
            // 
            BtnCash.Location = new Point(344, 355);
            BtnCash.Name = "BtnCash";
            BtnCash.Size = new Size(82, 83);
            BtnCash.TabIndex = 24;
            BtnCash.Text = "현금결제";
            BtnCash.UseVisualStyleBackColor = true;
            BtnCash.Click += BtnCash_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 418);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 23;
            label5.Text = "거스름돈";
            // 
            // TxtChangePrice
            // 
            TxtChangePrice.Location = new Point(88, 415);
            TxtChangePrice.Name = "TxtChangePrice";
            TxtChangePrice.ReadOnly = true;
            TxtChangePrice.Size = new Size(105, 23);
            TxtChangePrice.TabIndex = 22;
            // 
            // BtnBell7
            // 
            BtnBell7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell7.Location = new Point(220, 295);
            BtnBell7.Name = "BtnBell7";
            BtnBell7.Size = new Size(32, 32);
            BtnBell7.TabIndex = 21;
            BtnBell7.Text = "7";
            BtnBell7.UseVisualStyleBackColor = true;
            BtnBell7.Click += BtnBell7_Click;
            // 
            // BtnBell9
            // 
            BtnBell9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell9.Location = new Point(296, 295);
            BtnBell9.Name = "BtnBell9";
            BtnBell9.Size = new Size(32, 32);
            BtnBell9.TabIndex = 20;
            BtnBell9.Text = "9";
            BtnBell9.UseVisualStyleBackColor = true;
            BtnBell9.Click += BtnBell9_Click;
            // 
            // BtnBell8
            // 
            BtnBell8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell8.Location = new Point(258, 295);
            BtnBell8.Name = "BtnBell8";
            BtnBell8.Size = new Size(32, 32);
            BtnBell8.TabIndex = 19;
            BtnBell8.Text = "8";
            BtnBell8.UseVisualStyleBackColor = true;
            BtnBell8.Click += BtnBell8_Click;
            // 
            // BtnBell4
            // 
            BtnBell4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell4.Location = new Point(220, 333);
            BtnBell4.Name = "BtnBell4";
            BtnBell4.Size = new Size(32, 32);
            BtnBell4.TabIndex = 18;
            BtnBell4.Text = "4";
            BtnBell4.UseVisualStyleBackColor = true;
            BtnBell4.Click += BtnBell4_Click;
            // 
            // BtnBell6
            // 
            BtnBell6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell6.Location = new Point(296, 333);
            BtnBell6.Name = "BtnBell6";
            BtnBell6.Size = new Size(32, 32);
            BtnBell6.TabIndex = 17;
            BtnBell6.Text = "6";
            BtnBell6.UseVisualStyleBackColor = true;
            BtnBell6.Click += BtnBell6_Click;
            // 
            // BtnBell5
            // 
            BtnBell5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell5.Location = new Point(258, 333);
            BtnBell5.Name = "BtnBell5";
            BtnBell5.Size = new Size(32, 32);
            BtnBell5.TabIndex = 16;
            BtnBell5.Text = "5";
            BtnBell5.UseVisualStyleBackColor = true;
            BtnBell5.Click += BtnBell5_Click;
            // 
            // BtnBell1
            // 
            BtnBell1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell1.Location = new Point(220, 371);
            BtnBell1.Name = "BtnBell1";
            BtnBell1.Size = new Size(32, 32);
            BtnBell1.TabIndex = 15;
            BtnBell1.Text = "1";
            BtnBell1.UseVisualStyleBackColor = true;
            BtnBell1.Click += BtnBell1_Click;
            // 
            // BtnBell3
            // 
            BtnBell3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell3.Location = new Point(296, 371);
            BtnBell3.Name = "BtnBell3";
            BtnBell3.Size = new Size(32, 32);
            BtnBell3.TabIndex = 14;
            BtnBell3.Text = "3";
            BtnBell3.UseVisualStyleBackColor = true;
            BtnBell3.Click += BtnBell3_Click;
            // 
            // BtnBell2
            // 
            BtnBell2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell2.Location = new Point(258, 371);
            BtnBell2.Name = "BtnBell2";
            BtnBell2.Size = new Size(32, 32);
            BtnBell2.TabIndex = 13;
            BtnBell2.Text = "2";
            BtnBell2.UseVisualStyleBackColor = true;
            BtnBell2.Click += BtnBell2_Click;
            // 
            // TxtCount
            // 
            TxtCount.Location = new Point(87, 299);
            TxtCount.Name = "TxtCount";
            TxtCount.ReadOnly = true;
            TxtCount.Size = new Size(106, 23);
            TxtCount.TabIndex = 12;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(87, 328);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(105, 23);
            TxtTotal.TabIndex = 11;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(88, 357);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.ReadOnly = true;
            TxtPrice.Size = new Size(105, 23);
            TxtPrice.TabIndex = 10;
            // 
            // TxtRecivePrice
            // 
            TxtRecivePrice.Location = new Point(88, 386);
            TxtRecivePrice.Name = "TxtRecivePrice";
            TxtRecivePrice.ReadOnly = true;
            TxtRecivePrice.Size = new Size(105, 23);
            TxtRecivePrice.TabIndex = 9;
            // 
            // BtnBell0
            // 
            BtnBell0.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell0.Location = new Point(220, 409);
            BtnBell0.Name = "BtnBell0";
            BtnBell0.Size = new Size(32, 32);
            BtnBell0.TabIndex = 8;
            BtnBell0.Text = "0";
            BtnBell0.UseVisualStyleBackColor = true;
            BtnBell0.Click += BtnBell0_Click;
            // 
            // BtnBellCE
            // 
            BtnBellCE.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBellCE.Location = new Point(296, 409);
            BtnBellCE.Name = "BtnBellCE";
            BtnBellCE.Size = new Size(32, 32);
            BtnBellCE.TabIndex = 7;
            BtnBellCE.Text = "CE";
            BtnBellCE.UseVisualStyleBackColor = true;
            BtnBellCE.Click += BtnBellCE_Click;
            // 
            // BtnBell00
            // 
            BtnBell00.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnBell00.Location = new Point(258, 409);
            BtnBell00.Name = "BtnBell00";
            BtnBell00.Size = new Size(32, 32);
            BtnBell00.TabIndex = 6;
            BtnBell00.Text = "00";
            BtnBell00.UseVisualStyleBackColor = true;
            BtnBell00.Click += BtnBell00_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 389);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "받은 금액";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 360);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "받을 금액";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 331);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "총 금액";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 302);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "합계 수량";
            // 
            // TbcMenu
            // 
            TbcMenu.Controls.Add(tabPage1);
            TbcMenu.Controls.Add(tabPage2);
            TbcMenu.Location = new Point(334, 22);
            TbcMenu.Name = "TbcMenu";
            TbcMenu.SelectedIndex = 0;
            TbcMenu.Size = new Size(356, 332);
            TbcMenu.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnEinspannerIce);
            tabPage1.Controls.Add(BtnMochaIce);
            tabPage1.Controls.Add(BtnMochaHot);
            tabPage1.Controls.Add(BtnEinspannerHot);
            tabPage1.Controls.Add(BtnVanilaLatteIce);
            tabPage1.Controls.Add(BtnVanilaLatteHot);
            tabPage1.Controls.Add(BtnCappuccinoHot);
            tabPage1.Controls.Add(BtnLatteIce);
            tabPage1.Controls.Add(BtnLatteHot);
            tabPage1.Controls.Add(BtnEspresso);
            tabPage1.Controls.Add(BtnAmericanoIce);
            tabPage1.Controls.Add(BtnAmericanoHot);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(348, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "COFFEE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEinspannerIce
            // 
            BtnEinspannerIce.Location = new Point(247, 244);
            BtnEinspannerIce.Name = "BtnEinspannerIce";
            BtnEinspannerIce.Size = new Size(97, 54);
            BtnEinspannerIce.TabIndex = 11;
            BtnEinspannerIce.Text = "아인슈페너(ICE)";
            BtnEinspannerIce.UseVisualStyleBackColor = true;
            // 
            // BtnMochaIce
            // 
            BtnMochaIce.Location = new Point(126, 244);
            BtnMochaIce.Name = "BtnMochaIce";
            BtnMochaIce.Size = new Size(97, 54);
            BtnMochaIce.TabIndex = 10;
            BtnMochaIce.Text = "카페모카   (ICE)";
            BtnMochaIce.UseVisualStyleBackColor = true;
            // 
            // BtnMochaHot
            // 
            BtnMochaHot.Location = new Point(5, 244);
            BtnMochaHot.Name = "BtnMochaHot";
            BtnMochaHot.Size = new Size(97, 54);
            BtnMochaHot.TabIndex = 9;
            BtnMochaHot.Text = "카페모카  (HOT)";
            BtnMochaHot.UseVisualStyleBackColor = true;
            // 
            // BtnEinspannerHot
            // 
            BtnEinspannerHot.Location = new Point(248, 165);
            BtnEinspannerHot.Name = "BtnEinspannerHot";
            BtnEinspannerHot.Size = new Size(97, 54);
            BtnEinspannerHot.TabIndex = 8;
            BtnEinspannerHot.Text = "아인슈페너(HOT)";
            BtnEinspannerHot.UseVisualStyleBackColor = true;
            // 
            // BtnVanilaLatteIce
            // 
            BtnVanilaLatteIce.Location = new Point(127, 165);
            BtnVanilaLatteIce.Name = "BtnVanilaLatteIce";
            BtnVanilaLatteIce.Size = new Size(97, 54);
            BtnVanilaLatteIce.TabIndex = 7;
            BtnVanilaLatteIce.Text = "바닐라라떼(ICE)";
            BtnVanilaLatteIce.UseVisualStyleBackColor = true;
            // 
            // BtnVanilaLatteHot
            // 
            BtnVanilaLatteHot.Location = new Point(6, 165);
            BtnVanilaLatteHot.Name = "BtnVanilaLatteHot";
            BtnVanilaLatteHot.Size = new Size(97, 54);
            BtnVanilaLatteHot.TabIndex = 6;
            BtnVanilaLatteHot.Text = "바닐라라떼(HOT)";
            BtnVanilaLatteHot.UseVisualStyleBackColor = true;
            // 
            // BtnCappuccinoHot
            // 
            BtnCappuccinoHot.Location = new Point(247, 84);
            BtnCappuccinoHot.Name = "BtnCappuccinoHot";
            BtnCappuccinoHot.Size = new Size(97, 54);
            BtnCappuccinoHot.TabIndex = 5;
            BtnCappuccinoHot.Text = "카푸치노  (HOT)";
            BtnCappuccinoHot.UseVisualStyleBackColor = true;
            // 
            // BtnLatteIce
            // 
            BtnLatteIce.Location = new Point(126, 84);
            BtnLatteIce.Name = "BtnLatteIce";
            BtnLatteIce.Size = new Size(97, 54);
            BtnLatteIce.TabIndex = 4;
            BtnLatteIce.Text = "카페라떼   (ICE)";
            BtnLatteIce.UseVisualStyleBackColor = true;
            // 
            // BtnLatteHot
            // 
            BtnLatteHot.Location = new Point(5, 84);
            BtnLatteHot.Name = "BtnLatteHot";
            BtnLatteHot.Size = new Size(97, 54);
            BtnLatteHot.TabIndex = 3;
            BtnLatteHot.Text = "카페라떼  (HOT)";
            BtnLatteHot.UseVisualStyleBackColor = true;
            // 
            // BtnEspresso
            // 
            BtnEspresso.Location = new Point(248, 6);
            BtnEspresso.Name = "BtnEspresso";
            BtnEspresso.Size = new Size(97, 54);
            BtnEspresso.TabIndex = 2;
            BtnEspresso.Text = "에스프레소(HOT)";
            BtnEspresso.UseVisualStyleBackColor = true;
            // 
            // BtnAmericanoIce
            // 
            BtnAmericanoIce.Location = new Point(127, 6);
            BtnAmericanoIce.Name = "BtnAmericanoIce";
            BtnAmericanoIce.Size = new Size(97, 54);
            BtnAmericanoIce.TabIndex = 1;
            BtnAmericanoIce.Text = "아메리카노(ICE)";
            BtnAmericanoIce.UseVisualStyleBackColor = true;
            BtnAmericanoIce.Click += BtnAmericanoIce_Click;
            // 
            // BtnAmericanoHot
            // 
            BtnAmericanoHot.Location = new Point(6, 6);
            BtnAmericanoHot.Name = "BtnAmericanoHot";
            BtnAmericanoHot.Size = new Size(97, 54);
            BtnAmericanoHot.TabIndex = 0;
            BtnAmericanoHot.Text = "아메리카노(HOT)";
            BtnAmericanoHot.UseVisualStyleBackColor = true;
            BtnAmericanoHot.Click += BtnAmericanoHot_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button17);
            tabPage2.Controls.Add(button18);
            tabPage2.Controls.Add(button19);
            tabPage2.Controls.Add(button20);
            tabPage2.Controls.Add(button21);
            tabPage2.Controls.Add(button22);
            tabPage2.Controls.Add(button23);
            tabPage2.Controls.Add(button24);
            tabPage2.Controls.Add(button25);
            tabPage2.Controls.Add(button26);
            tabPage2.Controls.Add(button27);
            tabPage2.Controls.Add(button28);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(348, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "BEVERAGE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(246, 244);
            button17.Name = "button17";
            button17.Size = new Size(97, 54);
            button17.TabIndex = 23;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(125, 244);
            button18.Name = "button18";
            button18.Size = new Size(97, 54);
            button18.TabIndex = 22;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(4, 244);
            button19.Name = "button19";
            button19.Size = new Size(97, 54);
            button19.TabIndex = 21;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(247, 165);
            button20.Name = "button20";
            button20.Size = new Size(97, 54);
            button20.TabIndex = 20;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(126, 165);
            button21.Name = "button21";
            button21.Size = new Size(97, 54);
            button21.TabIndex = 19;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(5, 165);
            button22.Name = "button22";
            button22.Size = new Size(97, 54);
            button22.TabIndex = 18;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Location = new Point(246, 84);
            button23.Name = "button23";
            button23.Size = new Size(97, 54);
            button23.TabIndex = 17;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Location = new Point(125, 84);
            button24.Name = "button24";
            button24.Size = new Size(97, 54);
            button24.TabIndex = 16;
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Location = new Point(4, 84);
            button25.Name = "button25";
            button25.Size = new Size(97, 54);
            button25.TabIndex = 15;
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Location = new Point(247, 6);
            button26.Name = "button26";
            button26.Size = new Size(97, 54);
            button26.TabIndex = 14;
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Location = new Point(126, 6);
            button27.Name = "button27";
            button27.Size = new Size(97, 54);
            button27.TabIndex = 13;
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Location = new Point(5, 6);
            button28.Name = "button28";
            button28.Size = new Size(97, 54);
            button28.TabIndex = 12;
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = true;
            // 
            // LsvOrder
            // 
            LsvOrder.Columns.AddRange(new ColumnHeader[] { ClhTitle, ClhCount, ClhPrice, ClhEtc });
            LsvOrder.GridLines = true;
            LsvOrder.Location = new Point(6, 22);
            LsvOrder.Name = "LsvOrder";
            LsvOrder.Size = new Size(322, 267);
            LsvOrder.TabIndex = 0;
            LsvOrder.UseCompatibleStateImageBehavior = false;
            LsvOrder.View = View.Details;
            // 
            // ClhTitle
            // 
            ClhTitle.Text = "메뉴";
            ClhTitle.Width = 150;
            // 
            // ClhCount
            // 
            ClhCount.Text = "수량";
            // 
            // ClhPrice
            // 
            ClhPrice.Text = "금액";
            // 
            // ClhEtc
            // 
            ClhEtc.Text = "비고";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 469);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "주문화면";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TbcMenu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl TbcMenu;
        private TabPage tabPage1;
        private Button BtnEspresso;
        private Button BtnAmericanoIce;
        private Button BtnAmericanoHot;
        private TabPage tabPage2;
        private ListView LsvOrder;
        private Button BtnEinspannerIce;
        private Button BtnMochaIce;
        private Button BtnMochaHot;
        private Button BtnEinspannerHot;
        private Button BtnVanilaLatteIce;
        private Button BtnVanilaLatteHot;
        private Button BtnCappuccinoHot;
        private Button BtnLatteIce;
        private Button BtnLatteHot;
        private ColumnHeader ClhTitle;
        private ColumnHeader ClhCount;
        private ColumnHeader ClhPrice;
        private ColumnHeader ClhEtc;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button BtnBell7;
        private Button BtnBell9;
        private Button BtnBell8;
        private Button BtnBell4;
        private Button BtnBell6;
        private Button BtnBell5;
        private Button BtnBell1;
        private Button BtnBell3;
        private Button BtnBell2;
        private TextBox TxtCount;
        private TextBox TxtTotal;
        private TextBox TxtPrice;
        private TextBox TxtRecivePrice;
        private Button BtnBell0;
        private Button BtnBellCE;
        private Button BtnBell00;
        private Label label5;
        private TextBox TxtChangePrice;
        private Button BtnSeleteCancle;
        private Button BtnAllCancle;
        private Button BtnCard;
        private Button BtnCash;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private System.Windows.Forms.Timer timer;
        private Label labelTime;
        private Label label6;
    }
}
