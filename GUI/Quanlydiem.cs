using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model;

namespace MyThi_490.GUI
{
    public partial class Quanlydiem : Form
    {
        private KetQuaBLL kqBLL = new KetQuaBLL();
        private SinhVienBLL svBLL = new SinhVienBLL();
        private MonHocBLL mhBLL = new MonHocBLL();

        public Quanlydiem()
        {
            InitializeComponent();
            Load += Quanlydiem_Load;
            btnLuuDiem.Click += BtnLuuDiem_Click;
            dgvKetQua.CellClick += DgvKetQua_CellClick;
        }

        private void Quanlydiem_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGrid();
        }

        private void LoadComboBox()
        {
            cbSinhVien.DataSource = svBLL.GetListSV();
            cbSinhVien.DisplayMember = "HoTen";
            cbSinhVien.ValueMember = "MaSV";

            cbMonHoc.DataSource = mhBLL.GetList();
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
        }

        private void LoadDataGrid()
        {
            dgvKetQua.Rows.Clear();

            List<KetQua> listKQ = kqBLL.GetList();
            List<SinhVien> listSV = svBLL.GetListSV();

            foreach (var kq in listKQ)
            {
                int i = dgvKetQua.Rows.Add();

                dgvKetQua.Rows[i].Cells[0].Value = kq.MaSV;

                var sv = listSV.FirstOrDefault(x => x.MaSV == kq.MaSV);
                dgvKetQua.Rows[i].Cells[1].Value = sv != null ? sv.HoTen : "Không rõ";

                dgvKetQua.Rows[i].Cells[2].Value = kq.MaMon;
                dgvKetQua.Rows[i].Cells[3].Value =
                    kq.DiemSo == -1 ? "Chưa có điểm" : kq.DiemSo.ToString();
            }
        }

        private void BtnLuuDiem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtDiem.Text, out float diem))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ");
                return;
            }

            string maSV = cbSinhVien.SelectedValue.ToString();
            string maMon = cbMonHoc.SelectedValue.ToString();

            MessageBox.Show(kqBLL.NhapDiem(maSV, maMon, diem));
            LoadDataGrid();
        }

        private void DgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];

            cbSinhVien.SelectedValue = row.Cells[0].Value.ToString();
            cbMonHoc.SelectedValue = row.Cells[2].Value.ToString();
            txtDiem.Text = row.Cells[3].Value.ToString() == "Chưa có điểm"
                ? ""
                : row.Cells[3].Value.ToString();
        }
    }
}
