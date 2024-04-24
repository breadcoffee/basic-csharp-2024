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
    public partial class FrmBookRental : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)

        public FrmBookRental()
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
            // TODO : 아직 작성안함
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            // 입력 값 초기화
            TxtRetalIdx.Text = TxtMemberNames.Text  = string.Empty;
            TxtMemberIdx.Text = TxtBookIdx.Text = TxtBookNames.Text = string.Empty;
            DtpRentalDate.Value = DtpReturnDate.Value = DateTime.Now;

            TxtMemberNames.Focus(); // 순번은 자동증가하기 때문에 회원명에 포커스
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력검증(validation Check), 이름, 패스워드 등을 안넣으면 메세지
            if (string.IsNullOrEmpty(TxtMemberNames.Text))
            {
                MessageBox.Show("회원명을 선택하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtBookNames.Text))
            {
                MessageBox.Show("대출할 책을 선택하세요.");
                return;
            }

            // 반납일이 1800-01-01 이면 반납일을 null을 입력

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO rentaltbl
                                       ( memberIdx
                                       , bookIdx
                                       , rentalDate
                                       , returnDate)
                                 VALUES
                                       ( @memberIdx
                                       , @bookIdx
                                       , @rentalDate
                                       , @returnDate)";
                    }
                    else
                    {
                        query = @"UPDATE rentaltbl
                                     SET memberIdx = @memberIdx
                                       , bookIdx = @bookIdx
                                       , rentalDate = @rentalDate
                                       , returnDate = @returnDate
                                   WHERE rentalIdx = @rentalIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                    SqlParameter prmBookIdx = new SqlParameter("@bookIdx", TxtBookIdx.Text);
                    SqlParameter prmRentalDate = new SqlParameter("@rentalDate", DtpRentalDate.Value);
                    // Command에 Parameter를 연결해줘여함!
                    cmd.Parameters.Add(prmMemberIdx);
                    cmd.Parameters.Add(prmBookIdx);
                    cmd.Parameters.Add(prmRentalDate);
                    // 반납날짜 추가처리
                    var returnDate = "";
                    if (DtpReturnDate.Value <= DtpRentalDate.Value)
                    {
                        returnDate = "";
                    }
                    else
                    {
                        returnDate = DtpReturnDate.Value.ToString("yyyy-MM-dd");
                    }
                    SqlParameter prmReturnDate = new SqlParameter("@returnDate", returnDate);
                    cmd.Parameters.Add(prmReturnDate);

                    if (isNew != true)
                    {
                        SqlParameter prmRentalIdx = new SqlParameter("@rentalIdx", TxtRetalIdx.Text);
                        cmd.Parameters.Add(prmRentalIdx);
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

        private void RefreshData()
        {
            // 입력 값 초기화
            TxtRetalIdx.Text = TxtMemberNames.Text = string.Empty;
            TxtMemberIdx.Text = TxtBookIdx.Text = TxtBookNames.Text = string.Empty;
            DtpRentalDate.Value = DtpReturnDate.Value = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT r.rentalIdx
                                   , r.memberIdx
	                               , m.Names AS memNames
                                   , r.bookIdx
	                               , b.Names AS bookNames
                                   , r.rentalDate
                                   , r.returnDate
                                FROM rentaltbl AS r
                                JOIN membertbl AS m
                                  ON r.memberIdx = m.memberIdx
                                JOIN bookstbl AS b
                                  ON r.bookIdx = b.bookIdx"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "rentaltbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                DgvResult.Columns[0].HeaderText = "대출순번";
                DgvResult.Columns[1].HeaderText = "회원순번";
                DgvResult.Columns[2].HeaderText = "회원명";
                DgvResult.Columns[3].HeaderText = "책순번"; // 구분명(장르) 추가
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "대출일";
                DgvResult.Columns[6].HeaderText = "반납일";

                // 각 컬럼의 넓이, 컬럼 숨김 지정
                /*DgvResult.Columns[0].Width = 69;
                DgvResult.Columns[1].Visible = false; // 구분코드 숨김
                DgvResult.Columns[3].Visible = false; // 구분코드 숨김
                DgvResult.Columns[4].Width = 195;
                DgvResult.Columns[5].Width = 73;
                DgvResult.Columns[7].Width = 68;*/
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtRetalIdx.Text = selData.Cells[0].Value.ToString(); // 대출순번
                TxtMemberIdx.Text = selData.Cells[1].Value.ToString(); // 회원순번
                TxtMemberNames.Text = selData.Cells[2].Value.ToString();  // 회원명
                TxtBookIdx.Text = selData.Cells[3].Value.ToString(); // 책순번
                TxtBookNames.Text = selData.Cells[4].Value.ToString(); // 책이름
                DtpRentalDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString()); // 대출일, DateTime.Parse : 문자열을 DateTime으로 형변환
                DtpReturnDate.Value = string.IsNullOrEmpty(selData.Cells[6].Value.ToString()) ? 
                                        DateTime.Parse("1800-01-01") : // 1800-01-01은 반납안한 것
                                        DateTime.Parse(selData.Cells[6].Value.ToString()); 

                isNew = false; // UPDATE 가능하게
            }
        }

        // 회원검색버튼 
        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            PopMember popup = new PopMember();
            popup.StartPosition = FormStartPosition.CenterParent;
            if (popup.ShowDialog() == DialogResult.Yes)
            {
                TxtMemberIdx.Text = Helper.Common.SelMemberIdx;
                TxtMemberNames.Text = Helper.Common.SelMemberName;
            }
        }
        // 책검색버튼
        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            PopBook popup = new PopBook();
            popup.StartPosition = FormStartPosition.CenterParent;
            if (popup.ShowDialog() == DialogResult.Yes)
            {
                TxtBookIdx.Text = Helper.Common.SelBookIdx;
                TxtBookNames.Text = Helper.Common.SelBookName;
            }
        }
    }
}
