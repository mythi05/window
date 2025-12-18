using MyThi_490.BLL;

using MyThi_490.Model.Thitracnghiem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyThi_490.GUI
{
    public partial class FrmLamBai : Form
    {
        private List<CauHoi> ds;
        private int index = 0;
        private ThiBLL bll = new ThiBLL();

        public FrmLamBai(ThiSinh ts)
        {
            InitializeComponent();

            // Hiển thị thông tin thí sinh lên header
            lblThongTin.Text = $"Mã SV: {ts.Ma} | Họ tên: {ts.Ten} | Ngày sinh: {ts.NgaySinh:dd/MM/yyyy}";

            // Tải danh sách câu hỏi
            ds = bll.LayDanhSachCauHoi();

            // Đăng ký sự kiện
            btnTiepTuc.Click += btnTiep_Click;
            btnQuayLai.Click += btnQuayLai_Click;
            btnNopBai.Click += btnNopBai_Click_1;

            LoadCauHoi();
        }

        void LoadCauHoi()
        {
            if (ds == null || ds.Count == 0) return;

            var c = ds[index];
            lblSTT.Text = $"Câu {index + 1}:";
            lblNoiDungCauHoi.Text = c.NoiDung;
            rdoA.Text = "A. " + c.A;
            rdoB.Text = "B. " + c.B;
            rdoC.Text = "C. " + c.C;
            rdoD.Text = "D. " + c.D;

            // Xóa lựa chọn cũ
            rdoA.Checked = rdoB.Checked = rdoC.Checked = rdoD.Checked = false;

            // Nếu câu này đã từng chọn đáp án, thì hiện lại đáp án đó
            if (c.DaChon == "A") rdoA.Checked = true;
            else if (c.DaChon == "B") rdoB.Checked = true;
            else if (c.DaChon == "C") rdoC.Checked = true;
            else if (c.DaChon == "D") rdoD.Checked = true;

            // Vô hiệu hóa nút quay lại nếu ở câu đầu tiên
            btnQuayLai.Enabled = (index > 0);
            btnTiepTuc.Text = (index == ds.Count - 1) ? "Câu cuối" : "Tiếp tục >>";
        }

        private void LuuDapAn()
        {
            if (rdoA.Checked) ds[index].DaChon = "A";
            else if (rdoB.Checked) ds[index].DaChon = "B";
            else if (rdoC.Checked) ds[index].DaChon = "C";
            else if (rdoD.Checked) ds[index].DaChon = "D";
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            if (index < ds.Count - 1)
            {
                index++;
                LoadCauHoi();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            if (index > 0)
            {
                index--;
                LoadCauHoi();
            }
        }

   

        private void btnNopBai_Click_1(object sender, EventArgs e)
        {
            LuuDapAn(); // Lưu đáp án câu hiện tại trước khi nộp

            if (MessageBox.Show("Bạn có chắc chắn muốn nộp bài?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KetQua kq = bll.ChamDiem(ds);
                FrmKetQua frm = new FrmKetQua(kq);
                frm.Show();
                this.Close(); // Đóng form làm bài
            }
        }
    }
}