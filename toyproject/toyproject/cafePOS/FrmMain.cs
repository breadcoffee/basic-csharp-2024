using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Policy;


namespace cafePOS
{
    public partial class FrmMain : Form
    {
        public static int curSalesIdx = 0;
        // �������� ����� ���� ���Ṯ�ڿ�
        public static string ConnString = "Data Source=localhost;" +
                                    "Initial Catalog=Caffe;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss;";
        ORDER ord = new ORDER();
        int cash = 0; // �� �ݾ�
        private bool isNew = false;
        string insertName;
        int insertCount;
        int insertPrice;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region "�ֹ���ư"
        private void BtnAmericanoHot_Click(object sender, EventArgs e)
        { // �Ƹ޸�ī�� HOT ��ư
            int count = LsvOrder.Items.Count; // ����Ʈ�信 �� ���� �߰�
            if (ord.AmericanoHotCount >= 2)
            { // ����Ʈ�信 �ش��ϴ� �׸��� �̹� ���� ��
                for (int i = 0; i < count; i++)
                {
                    // ����Ʈ�信 �ش��ؽ�Ʈ�� ������
                    if (LsvOrder.Items[i].SubItems[0].Text == BtnAmericanoHot.Text)
                    { 
                        // ����Ʈ �信�� �׸� ����
                        LsvOrder.Items[i].Focused = true;
                        LsvOrder.Items[i].Selected = true;

                        // ���õ� �׸� ������Ʈ
                        //LsvOrder.FocusedItem.SubItems[0].Text = BtnAmericanoHot.Text;
                        LsvOrder.FocusedItem.SubItems[1].Text = Convert.ToString(ord.AmericanoHotCount);
                        LsvOrder.FocusedItem.SubItems[2].Text = Convert.ToString(ord.AmericanoHotSum());

                        ord.AmericanoHotCount++; // Ƚ�� ����
                        LsvOrder.Items[i].Selected = false;
                    }
                }
            }
            else // ����Ʈ�信 ó�� �߰��� ��
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
        { // �Ƹ޸�ī�� HOT ��ư
            int count = LsvOrder.Items.Count; // ����Ʈ�信 �� ���� �߰�
            if (ord.AmericanoIceCount >= 2)
            { // ����Ʈ�信 �ش��ϴ� �׸��� �̹� ���� ��
                for (int i = 0; i < count; i++)
                {
                    if (LsvOrder.Items[i].SubItems[0].Text == BtnAmericanoIce.Text)
                    { // ����Ʈ�信 �ش��ؽ�Ʈ�� ������
                        // ����Ʈ �信�� �׸� ����
                        LsvOrder.Items[i].Focused = true;
                        LsvOrder.Items[i].Selected = true;

                        // ���õ� �׸� ������Ʈ
                        //LsvOrder.FocusedItem.SubItems[0].Text = BtnAmericanoHot.Text;
                        LsvOrder.FocusedItem.SubItems[1].Text = Convert.ToString(ord.AmericanoIceCount);
                        LsvOrder.FocusedItem.SubItems[2].Text = Convert.ToString(ord.AmericanoIceSum());

                        ord.AmericanoIceCount++; // Ƚ�� ����
                        LsvOrder.Items[i].Selected = false;
                    }
                }
            }
            else // ����Ʈ�信 ó�� �߰��� ��
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

        #region "���� ��ư"
        private void BtnBell1_Click(object sender, EventArgs e)// ���� 1�� ��ư
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
        private void BtnBell2_Click(object sender, EventArgs e)// ���� 2�� ��ư
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
        private void BtnBell3_Click(object sender, EventArgs e)// ���� 3�� ��ư
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
        private void BtnBell4_Click(object sender, EventArgs e) // ���� 4�� ��ư
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
        private void BtnBell5_Click(object sender, EventArgs e)// ���� 5�� ��ư
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
        private void BtnBell6_Click(object sender, EventArgs e)// ���� 6�� ��ư
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
        private void BtnBell7_Click(object sender, EventArgs e)// ���� 7�� ��ư
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
        private void BtnBell8_Click(object sender, EventArgs e)// ���� 8�� ��ư
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
        private void BtnBell9_Click(object sender, EventArgs e)// ���� 9�� ��ư
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
        private void BtnBell0_Click(object sender, EventArgs e)// ���� 0�� ��ư
        {
            cash *= 10;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBell00_Click(object sender, EventArgs e)// ���� 00�� ��ư
        {
            cash *= 100;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        private void BtnBellCE_Click(object sender, EventArgs e)// ���� CE ��ư
        {
            cash = 0;
            TxtRecivePrice.Text = Convert.ToString(cash);
            TxtChangePrice.Text = Convert.ToString(cash - ord.SumCash());
        }
        #endregion

        #region "������ư"
        // ���ݰ���
        private void BtnCash_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // ����Ʈ�� �׸�� ��ȯ
            if (count == 0)
            {
                MessageBox.Show("������ �޴��� �����ϴ�!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtRecivePrice.Text == "0")
                {
                    TxtRecivePrice.Text = TxtPrice.Text;
                }
                DialogResult dlr = MessageBox.Show("���ݰ��� �Ͻðڽ��ϱ�?", "���� ����", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    int num = LsvOrder.Items.Count; // ����Ʈ�信 �� ���� �߰�
                    // insert menu ����
                    InsertsalePrice();
                    for (int i = 0; i < num; i++)
                    {
                        insertName = LsvOrder.Items[i].SubItems[0].ToString();
                        insertCount = Convert.ToInt32(LsvOrder.Items[i].SubItems[1].Text);
                        insertPrice = Convert.ToInt32(LsvOrder.Items[i].SubItems[2].Text);
                        Insertmenu(insertName, insertCount, insertPrice);
                    }
                    // �Է� �� �ʱ�ȭ
                    LsvOrder.Items.Clear();
                    cash = 0;
                    TxtChangePrice.Text = TxtCount.Text = TxtPrice.Text = TxtRecivePrice.Text = TxtTotal.Text = "0";
                    ord.AmericanoHotCount = ord.AmericanoIceCount = ord.LatteHotCount = ord.LatteIceCount = ord.EspressoCount = ord.CappuccinoHotCount = ord.VanilaLatteHotCount = ord.VanilaLatteIceCount = ord.MochaHotCount = ord.MochaIceCount = ord.EinspannerHotCount = ord.EinspannerIceCount = 1;
                    ord.americanoHotSum = ord.americanoIceSum = ord.latteHotSum = ord.latteIceSum = ord.espressoSum = ord.cappuccinoHotSum = ord.vanilaLatteHotSum = ord.vanilaLatteIceSum = ord.mochaHotSum = ord.mochaIceSum = ord.einspannerHotSum = ord.einspannerIceSum = 0;
                }
            }
        }

        // ī�����
        private void BtnCard_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // ����Ʈ�� �׸�� ��ȯ
            if (count == 0)
            {
                MessageBox.Show("������ �޴��� �����ϴ�!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtRecivePrice.Text == "0")
                {
                    TxtRecivePrice.Text = TxtPrice.Text;
                }
                DialogResult dlr = MessageBox.Show("ī����� �Ͻðڽ��ϱ�?", "ī�� ����", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    InsertsalePrice();
                    // �Է� �� �ʱ�ȭ
                    LsvOrder.Items.Clear();
                    cash = 0;
                    TxtChangePrice.Text = TxtCount.Text = TxtPrice.Text = TxtRecivePrice.Text = TxtTotal.Text = "0";
                    ord.AmericanoHotCount = ord.AmericanoIceCount = ord.LatteHotCount = ord.LatteIceCount = ord.EspressoCount = ord.CappuccinoHotCount = ord.VanilaLatteHotCount = ord.VanilaLatteIceCount = ord.MochaHotCount = ord.MochaIceCount = ord.EinspannerHotCount = ord.EinspannerIceCount = 1;
                    ord.americanoHotSum = ord.americanoIceSum = ord.latteHotSum = ord.latteIceSum = ord.espressoSum = ord.cappuccinoHotSum = ord.vanilaLatteHotSum = ord.vanilaLatteIceSum = ord.mochaHotSum = ord.mochaIceSum = ord.einspannerHotSum = ord.einspannerIceSum = 0;
                }
            }
        }

        // ��ü����
        private void BtnAllCancle_Click(object sender, EventArgs e)
        {
            int count = LsvOrder.Items.Count; // ����Ʈ�� �׸�� ��ȯ
            if (count == 0)
            {
                MessageBox.Show("����� �޴��� �����ϴ�!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // ���û���
        private void BtnSeleteCancle_Click(object sender, EventArgs e)
        {

            int count = LsvOrder.Items.Count; // ����Ʈ�� �׸�� ��ȯ
            if (count == 0)
            {
                MessageBox.Show("����� �޴��� �����ϴ�!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LsvOrder.Items.Remove(LsvOrder.FocusedItem); // ��Ʈ�� �κ��� �����ϴ°�.
            }
        }

        // �޴��� ���� ��¥ ���
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("yyyy-MM-dd(ddd)");
        }
        // salePrice Insert sql query��
        private void InsertsalePrice()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (true) // INSERT�̸�
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
                    // Command�� Parameter�� �������࿩��!
                    cmd.Parameters.Add(prmTotalSales);
                    cmd.Parameters.Add(prmDate);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this �޽����ڽ��� �θ�â
                        MessageBox.Show(this, "��������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("��������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    query = "SELECT IDENT_CURRENT('salesPrice')";
                    cmd = new SqlCommand(query, conn);
                    curSalesIdx = Convert.ToInt32(cmd.ExecuteScalar());

                    //MessageBox.Show(curSalesIdx.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"���� : {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // menu Insert sql query��
        private void Insertmenu(string name, int count, int price)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (true) // INSERT�̸�
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

                    // TODO : SalesIdx �ܷ�Ű ���� �ذ��ؾ���
                    SqlParameter prmSalesIdx = new SqlParameter("@SalesIdx", Convert.ToInt32(curSalesIdx.ToString()));
                    SqlParameter prmName = new SqlParameter("@Name", name);
                    SqlParameter prmCount = new SqlParameter("@Count", count);
                    SqlParameter prmPrice = new SqlParameter("@Price", price);
                    // Command�� Parameter�� �������࿩��!
                    cmd.Parameters.Add(prmSalesIdx);
                    cmd.Parameters.Add(prmName);
                    cmd.Parameters.Add(prmCount);
                    cmd.Parameters.Add(prmPrice);


                    /*
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        // this �޽����ڽ��� �θ�â
                        MessageBox.Show(this, "��������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("��������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"���� : {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // TODO : �ֹ�����, ����Ȯ�� ȭ�� �����
    }
}
