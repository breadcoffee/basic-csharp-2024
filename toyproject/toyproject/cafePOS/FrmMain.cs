using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Policy;


namespace cafePOS
{
    public partial class FrmMain : Form
    {
        public static int curSalesIdx = 0;
        // 정적으로 만드는 공통 연결문자열
        public static string ConnString = "Data Source=localhost;" +
                                    "Initial Catalog=Caffe;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss;";
        ORDER ord = new ORDER();
        int cash = 0; // 총 금액
        private bool isNew = false;
        string insertName;
        int insertCount;
        int insertPrice;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region "주문버튼"
        private void BtnAmericanoHot_Click(object sender, EventArgs e)
        { // 아메리카노 HOT 버튼
            int count = LsvOrder.Items.Count; // 리스트뷰에 총 개수 추가
            if (ord.AmericanoHotCount >= 2)
            { // 리스트뷰에 해당하는 항목이 이미 있을 시
                for (int i = 0; i < count; i++)
                {
                    // 리스트뷰에 해당텍스트가 있으면
                    if (LsvOrder.Items[i].SubItems[0].Text == BtnAmericanoHot.Text)
                    { 
                        // 리스트 뷰에서 항목 선택
                        LsvOrder.Items[i].Focused = true;
                        LsvOrder.Items[i].Selected = true;

                        // 선택된 항목 업데이트
                        //LsvOrder.FocusedItem.SubItems[0].Text = BtnAmericanoHot.Text;
                        LsvOrder.FocusedItem.SubItems[1].Text = Convert.ToString(ord.AmericanoHotCount);
                        LsvOrder.FocusedItem.SubItems[2].Text = Convert.ToString(ord.AmericanoHotSum());

                        ord.AmericanoHotCount++; // 횟수 증가
                        LsvOrder.Items[i].Selected = false;
                    }
                }
            }
            else // 리스트뷰에 처음 추가될 시
            {
                var menu = new string[] { this.BtnAmericanoHot.Text, Convert.ToString(ord.AmericanoHotCount), Convert.ToString(ord.AmericanoHotSum()) };
                var item = new ListViewItem(menu);
                this.LsvOrder.Items.Add(item);
                LsvOrder.Focus();
                ord.AmericanoHotCount++;
            }
            TxtCount.Text = Convert.ToString(ord.SumCount());
            TxtTotal.Text = Convert.ToString(ord.SumCash());
        }
        private void BtnAmericanoIce_Click(object sender, EventArgs e)
        { // 아메리카노 HOT 버튼
            int count = LsvOrder.Items.Count; // 리스트뷰에 총 개수 추가
            if (ord.AmericanoIceCount >= 2)
            { // 리스트뷰에 해당하는 항목이 이미 있을 시
                for (int i = 0; i < count; i++)
                {
                    if (LsvOrder.Items[i].SubItems[0].Text == BtnAmericanoIce.Text)
                    { // 리스트뷰에 해당텍스트가 있으면
                        // 리스트 뷰에서 항목 선택
                        LsvOrder.Items[i].Focused = true;
                        LsvOrder.Items[i].Selected = true;

                        // 선택된 항목 업데이트
                        //LsvOrder.FocusedItem.SubItems[0].Text = BtnAmericanoHot.Text;
                        LsvOrder.FocusedItem.SubItems[1].Text = Convert.ToString(ord.AmericanoIceCount);
                        LsvOrder.FocusedItem.SubItems[2].Text = Convert.ToString(ord.AmericanoIceSum());

                        ord.AmericanoIceCount++; // 횟수 증가
                        LsvOrder.Items[i].Selected = false;
                    }
                }
            }
            else // 리스트뷰에 처음 추가될 시
            {
                var menu = new string[] { this.BtnAmericanoIce.Text, Convert.ToString(ord.AmericanoIceCount), Convert.ToString(ord.AmericanoIceSum()) };
                var item = new ListViewItem(menu);
                this.LsvOrder.Items.Add(item);
                LsvOrder.Focus();
                ord.AmericanoIceCount++;
            }
            TxtCount.Text = Convert.ToString(ord.SumCount());
            TxtTotal.Text = Convert.ToString(ord.SumCash());
        }
        #endregion

        #region "계산기 버튼"
        private void BtnBell1_Click(object sender, EventArgs e)// 계산기 1번 버튼
        {
            if (cash == 0)
            {
                cash = 1;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 1;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell2_Click(object sender, EventArgs e)// 계산기 2번 버튼
        {
            if (cash == 0)
            {
                cash = 2;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 2;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell3_Click(object sender, EventArgs e)// 계산기 3번 버튼
        {
            if (cash == 0)
            {
                cash = 3;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 3;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell4_Click(object sender, EventArgs e) // 계산기 4번 버튼
        {
            if (cash == 0)
            {
                cash = 4;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 4;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell5_Click(object sender, EventArgs e)// 계산기 5번 버튼
        {
            if (cash == 0)
            {
                cash = 5;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 5;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell6_Click(object sender, EventArgs e)// 계산기 6번 버튼
        {
            if (cash == 0)
            {
                cash = 6;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 6;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell7_Click(object sender, EventArgs e)// 계산기 7번 버튼
        {
            if (cash == 0)
            {
                cash = 7;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 7;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell8_Click(object sender, EventArgs e)// 계산기 8번 버튼
        {
            if (cash == 0)
            {
                cash = 8;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 8;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell9_Click(object sender, EventArgs e)// 계산기 9번 버튼
        {
            if (cash == 0)
            {
                cash = 9;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            else
            {
                cash *= 10;
                cash += 9;
                TxtRecivePrice.Text = Convert.ToString(cash);
            }
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell0_Click(object sender, EventArgs e)// 계산기 0번 버튼
        {
            cash *= 10;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell00_Click(object sender, EventArgs e)// 계산기 00번 버튼
        {
            cash *= 100;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBellCE_Click(object sender, EventArgs e)// 계산기 CE 버튼
        {
            cash = 0;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        #endregion

        #region "결제버튼"
        // 현금결제
        private void BtnCash_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // 리스트뷰 항목수 반환
            if (count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtRecivePrice.Text == "0")
                {
                    TxtRecivePrice.Text = TxtPrice.Text;
                }
                DialogResult dlr = MessageBox.Show("현금결제 하시겠습니까?", "현금 결제", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    int num = LsvOrder.Items.Count; // 리스트뷰에 총 개수 추가
                    // insert menu 쿼리
                    InsertsalePrice();
                    for (int i = 0; i < num; i++)
                    {
                        insertName = LsvOrder.Items[i].SubItems[0].ToString();
                        insertCount = Convert.ToInt32(LsvOrder.Items[i].SubItems[1].Text);
                        insertPrice = Convert.ToInt32(LsvOrder.Items[i].SubItems[2].Text);
                        Insertmenu(insertName, insertCount, insertPrice);
                    }
                    // 입력 값 초기화
                    LsvOrder.Items.Clear();
                    cash = 0;
                    TxtChangePrice.Text = TxtCount.Text = TxtPrice.Text = TxtRecivePrice.Text = TxtTotal.Text = "0";
                    ord.AmericanoHotCount = ord.AmericanoIceCount = ord.LatteHotCount = ord.LatteIceCount = ord.EspressoCount = ord.CappuccinoHotCount = ord.VanilaLatteHotCount = ord.VanilaLatteIceCount = ord.MochaHotCount = ord.MochaIceCount = ord.EinspannerHotCount = ord.EinspannerIceCount = 1;
                    ord.americanoHotSum = ord.americanoIceSum = ord.latteHotSum = ord.latteIceSum = ord.espressoSum = ord.cappuccinoHotSum = ord.vanilaLatteHotSum = ord.vanilaLatteIceSum = ord.mochaHotSum = ord.mochaIceSum = ord.einspannerHotSum = ord.einspannerIceSum = 0;
                }
            }
        }

        // 카드결제
        private void BtnCard_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // 리스트뷰 항목수 반환
            if (count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtRecivePrice.Text == "0")
                {
                    TxtRecivePrice.Text = TxtPrice.Text;
                }
                DialogResult dlr = MessageBox.Show("카드결제 하시겠습니까?", "카드 결제", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    InsertsalePrice();
                    // 입력 값 초기화
                    LsvOrder.Items.Clear();
                    cash = 0;
                    TxtChangePrice.Text = TxtCount.Text = TxtPrice.Text = TxtRecivePrice.Text = TxtTotal.Text = "0";
                    ord.AmericanoHotCount = ord.AmericanoIceCount = ord.LatteHotCount = ord.LatteIceCount = ord.EspressoCount = ord.CappuccinoHotCount = ord.VanilaLatteHotCount = ord.VanilaLatteIceCount = ord.MochaHotCount = ord.MochaIceCount = ord.EinspannerHotCount = ord.EinspannerIceCount = 1;
                    ord.americanoHotSum = ord.americanoIceSum = ord.latteHotSum = ord.latteIceSum = ord.espressoSum = ord.cappuccinoHotSum = ord.vanilaLatteHotSum = ord.vanilaLatteIceSum = ord.mochaHotSum = ord.mochaIceSum = ord.einspannerHotSum = ord.einspannerIceSum = 0;
                }
            }
        }

        // 전체삭제
        private void BtnAllCancle_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // 리스트뷰 항목수 반환
            if (count == 0)
            {
                MessageBox.Show("취소할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LsvOrder.Items.Clear();
                cash = 0;
                TxtChangePrice.Text = TxtCount.Text = TxtPrice.Text = TxtRecivePrice.Text = TxtTotal.Text = "0";
                ord.AmericanoHotCount = ord.AmericanoIceCount = ord.LatteHotCount = ord.LatteIceCount = ord.EspressoCount = ord.CappuccinoHotCount = ord.VanilaLatteHotCount = ord.VanilaLatteIceCount = ord.MochaHotCount = ord.MochaIceCount = ord.EinspannerHotCount = ord.EinspannerIceCount = 1;
                ord.americanoHotSum = ord.americanoIceSum = ord.latteHotSum = ord.latteIceSum = ord.espressoSum = ord.cappuccinoHotSum = ord.vanilaLatteHotSum = ord.vanilaLatteIceSum = ord.mochaHotSum = ord.mochaIceSum = ord.einspannerHotSum = ord.einspannerIceSum = 0;
            }
        }

        // 선택삭제
        private void BtnSeleteCancle_Click(object sender, EventArgs e)
        {

            int count = LsvOrder.Items.Count; // 리스트뷰 항목수 반환
            if (count == 0)
            {
                MessageBox.Show("취소할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (LsvOrder.FocusedItem.SubItems[0].Text == BtnAmericanoHot.Text) { ord.AmericanoHotCount = 1; ord.americanoHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnAmericanoIce.Text) { ord.AmericanoIceCount = 1; ord.americanoIceSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnEspresso.Text) { ord.EspressoCount = 1; ord.espressoSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnLatteHot.Text) { ord.LatteHotCount = 1; ord.latteHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnLatteIce.Text) { ord.LatteIceCount = 1; ord.latteIceSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnCappuccinoHot.Text) { ord.CappuccinoHotCount = 1; ord.cappuccinoHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnVanilaLatteHot.Text) { ord.VanilaLatteHotCount = 1; ord.vanilaLatteHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnVanilaLatteIce.Text) { ord.VanilaLatteIceCount = 1; ord.vanilaLatteIceSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnMochaHot.Text) { ord.MochaHotCount = 1; ord.mochaHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnMochaIce.Text) { ord.MochaHotCount = 1; ord.mochaIceSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnEinspannerHot.Text) { ord.EinspannerHotCount = 1; ord.einspannerHotSum = 0; }
                else if (LsvOrder.FocusedItem.SubItems[0].Text == BtnEinspannerIce.Text) { ord.EinspannerIceCount = 1; ord.einspannerIceSum = 0; }

                TxtCount.Text = Convert.ToString(ord.SumCount());
                TxtTotal.Text = Convert.ToString(ord.SumCash());
                LsvOrder.Items.Remove(LsvOrder.FocusedItem); // 컨트롤 부분을 제거하는거.
            }
        }

        // 메뉴에 오늘 날짜 출력
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("yyyy-MM-dd(ddd)");
        }
        // salePrice Insert sql query문
        private void InsertsalePrice()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (true) // INSERT이면
                    {
                        query = @"INSERT INTO [salesPrice]
                                               ( [TotalSales]
                                               , [Date])
                                         VALUES
                                               ( @TotalSales
                                               , @Date)";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmTotalSales = new SqlParameter("@TotalSales", ord.sumCash);
                    SqlParameter prmDate = new SqlParameter("@Date", DateTime.Now);
                    // Command에 Parameter를 연결해줘여함!
                    cmd.Parameters.Add(prmTotalSales);
                    cmd.Parameters.Add(prmDate);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창
                        MessageBox.Show(this, "결제성공!", "결제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("결제실패!", "결제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    query = "SELECT IDENT_CURRENT('salesPrice')";
                    cmd = new SqlCommand(query, conn);
                    curSalesIdx = Convert.ToInt32(cmd.ExecuteScalar());

                    //MessageBox.Show(curSalesIdx.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // menu Insert sql query문
        private void Insertmenu(string name, int count, int price)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (true) // INSERT이면
                    {
                        query = @"INSERT INTO [menu]
                                       ( [SalesIdx]
                                       , [Name]
                                       , [Count]
                                       , [Price])
                                 VALUES
                                       ( @SalesIdx
                                       , @Name
                                       , @Count
                                       , @Price)";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // TODO : SalesIdx 외래키 문제 해결해야함
                    SqlParameter prmSalesIdx = new SqlParameter("@SalesIdx", Convert.ToInt32(curSalesIdx.ToString()));
                    SqlParameter prmName = new SqlParameter("@Name", name);
                    SqlParameter prmCount = new SqlParameter("@Count", count);
                    SqlParameter prmPrice = new SqlParameter("@Price", price);
                    // Command에 Parameter를 연결해줘여함!
                    cmd.Parameters.Add(prmSalesIdx);
                    cmd.Parameters.Add(prmName);
                    cmd.Parameters.Add(prmCount);
                    cmd.Parameters.Add(prmPrice);


                    /*
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        // this 메시지박스의 부모창
                        MessageBox.Show(this, "결제성공!", "결제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("결제실패!", "결제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // TODO : 주문내용, 매출확인 화면 만들기
    }
}
