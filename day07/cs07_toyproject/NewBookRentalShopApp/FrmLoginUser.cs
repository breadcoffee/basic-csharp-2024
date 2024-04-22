﻿using System;
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
    public partial class FrmLoginUser : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        private string connString = "Data Source=localhost;" +
                                    "Initial Catalog=BookRentalShop2024;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss;";

        public FrmLoginUser()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT userIdx
                                   , userid
                                   , [password]
                                   , lastLoginDateTime
                                FROM usertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "사용자순번";
                DgvResult.Columns[1].HeaderText = "사용자아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막로그인날짜";
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
            TxtUserIdx.ReadOnly = true;
            TxtUserId.Focus(); // 순번은 자동증가하기 때문에 아이디에 포커스
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5Hash = MD5.Create(); // MD5 암호화용 객체 생성
            // 입력검증(validation Check), 이름, 패스워드를 안넣으면 메세지
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("사용자아이디을 입력하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO usertbl
                                   ( userid
                                   , [password])
                             VALUES
                                   ( @userid
                                   , @password)";
                    }
                    else
                    {
                        query = @"UPDATE usertbl
                                 SET userid = @userid
                                   , [password] = @password
                               WHERE userIdx = @userIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isNew == false) // update시에는 userIdx 파라미터가 필요하다
                    {
                        SqlParameter prmUserIdx = new SqlParameter("@userIdx", TxtUserIdx.Text);
                        cmd.Parameters.Add(prmUserIdx);
                    }
                    SqlParameter prmUserId = new SqlParameter("@userid", TxtUserId.Text);
                    SqlParameter prmPassword = new SqlParameter("@password", GetMd5Hash(md5Hash, TxtPassword.Text)); // 암호화 끝
                    // Command에 Parameter를 연결해줘여함!
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmPassword);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창이 누구냐, FrmLoginUser
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

            TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지워줘야함
            RefreshData();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtUserIdx.Text)) // 사용자아이디 순번이 없으면
            {
                MetroMessageBox.Show(this, "삭제할 사용자를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                var query = @"DELETE FROM usertbl WHERE userIdx = @userIdx";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserIdx = new SqlParameter("@userIdx", TxtUserIdx.Text);
                cmd.Parameters.Add(prmUserIdx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TxtUserIdx.Text = TxtUserId.Text = TxtPassword.Text = string.Empty;
                RefreshData();
            }
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT userIdx
                                   , userid
                                   , [password]
                                   , lastLoginDateTime
                                FROM usertbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;
                DgvResult.Columns[0].HeaderText = "사용자순번";
                DgvResult.Columns[1].HeaderText = "사용자아이디";
                DgvResult.Columns[2].HeaderText = "패스워드";
                DgvResult.Columns[3].HeaderText = "마지막로그인날짜";
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtUserIdx.Text = selData.Cells[0].Value.ToString();
                TxtUserIdx.ReadOnly = true;
                TxtUserId.Text = selData.Cells[1].Value.ToString();
                TxtPassword.Text = selData.Cells[2].Value.ToString();

                isNew = false; // UPDATE
            }
        }

        // MD5 해시 알고리즘 암호화
        // 1234 --> 01011000 -> 110010100100110 -> x65xAEx11 처럼 변환
        string GetMd5Hash(MD5 md5Hash, string input)
        {
            // 입력문자열을 byte배열로 변환한 뒤 MD5 해시처리
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder(); // 문자열을 좀 더 쉽게 쓰게 만들어주는 클래스
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // 16진수 문자로 각 글자를 전부 변환
            }
            return builder.ToString();
        }
    }
}
