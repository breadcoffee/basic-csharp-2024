using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터 초기화
            InitInputData(); // 콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
        }

        private void InitInputData()
        {
            // 콤보박스 내용을 직접 입력
            var temp = new Dictionary<string, string>();
            temp.Add("A", "A");
            temp.Add("B", "B");
            temp.Add("C", "C");
            temp.Add("D", "D");

            CboLevels.DataSource = new BindingSource(temp, null);
            CboLevels.DisplayMember = "Value";
            CboLevels.ValueMember = "Key";
            CboLevels.SelectedIndex = -1;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            // 입력 값 초기화
            TxtMemberIdx.Text = TxtNames.Text = TxtAddr.Text = TxtMobile.Text =TxtEmail.Text  = string.Empty;
            CboLevels.SelectedValue = 0;

            TxtNames.Focus(); // 순번은 자동증가하기 때문에 저자에 포커스
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(validation Check), 이름, 패스워드를 안넣으면 메세지
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("회원명을 입력하세요.");
                return;
            }
            // 콤보박스는 SelectedIndex가 -1이 되면 안됨
            if (CboLevels.SelectedIndex < 0)
            {
                MessageBox.Show("등급 선택하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtAddr.Text))
            {
                MessageBox.Show("주소를 입력하세요.");
                return;
            }
            // 출판일은 기본으로 오늘 날짜가 들어감
            // ISBN은 Null이 들어가도 상관없음
            // 책가격은 기본으로 0이 들어감

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO [membertbl]
                                            ( [Names]
                                            , [Levels]
                                            , [Addr]
                                            , [Mobile]
                                            , [Email])
                                     VALUES
                                            ( @Names
                                            , @Levels
                                            , @Addr
                                            , @Mobile
                                            , @Email)";
                    }
                    else
                    {
                        query = @"UPDATE [membertbl]
                                     SET [Names] = @Names
                                       , [Levels] = @Levels
                                       , [Addr] = @Addr
                                       , [Mobile] = @Mobile
                                       , [Email] = @Email
                                   WHERE memberIdx = @memberIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    SqlParameter prmLevels = new SqlParameter("@Levels", CboLevels.SelectedValue);
                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtAddr.Text);
                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtMobile.Text);
                    SqlParameter prmEmail = new SqlParameter("@Email", TxtEmail.Text);
                    // Command에 Parameter를 연결해줘여함!
                    cmd.Parameters.Add(prmNames);
                    cmd.Parameters.Add(prmLevels);
                    cmd.Parameters.Add(prmAddr);
                    cmd.Parameters.Add(prmMobile);
                    cmd.Parameters.Add(prmEmail);

                    if (isNew != true)
                    {
                        SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                        cmd.Parameters.Add(prmMemberIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장실패!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshData();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtMemberIdx.Text)) // 구분코드가 없으면
            {
                MetroMessageBox.Show(this, "삭제할 사용자를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM membertbl WHERE memberIdx = @memberIdx";

                SqlCommand cmd = new SqlCommand(query, conn); 
                SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                cmd.Parameters.Add(prmMemberIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshData();
            }
        }

        private void RefreshData()
        {
            // 입력 값 초기화
            TxtMemberIdx.Text = TxtNames.Text = TxtAddr.Text = TxtMobile.Text = TxtEmail.Text = string.Empty;
            CboLevels.SelectedValue = 0;
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT [memberIdx]
                                   , [Names]
                                   , [Levels]
                                   , [Addr]
                                   , [Mobile]
                                   , [Email]
                                FROM [membertbl]"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "membertbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                
                // 컬럼이름 변경
                DgvResult.Columns[0].HeaderText = "회원순번";
                DgvResult.Columns[1].HeaderText = "회원명";
                DgvResult.Columns[2].HeaderText = "등급";
                DgvResult.Columns[3].HeaderText = "주소";
                DgvResult.Columns[4].HeaderText = "전화번호";
                DgvResult.Columns[5].HeaderText = "이메일";

                // 각 컬럼의 넓이 지정
                DgvResult.Columns[0].Width = 80;
                DgvResult.Columns[1].Width = 70;
                DgvResult.Columns[2].Width = 60;
                DgvResult.Columns[3].Width = 100;
                DgvResult.Columns[4].Width = 120;
                DgvResult.Columns[5].Width = 130;
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtMemberIdx.Text = selData.Cells[0].Value.ToString(); // 회원순번
                TxtNames.Text = selData.Cells[1].Value.ToString();  // 회원명
                CboLevels.SelectedValue = selData.Cells[2].Value; // 등급
                TxtAddr.Text = selData.Cells[3].Value.ToString(); // 주소
                TxtMobile.Text = selData.Cells[4].Value.ToString(); // 전화번호
                TxtEmail.Text = selData.Cells[5].Value.ToString(); // 이메일
                TxtMemberIdx.ReadOnly = true; // UPDATE시는 PK인 Division을 변경하면 안됨

                isNew = false; // UPDATE 가능하게
            }
        }
    }
}
