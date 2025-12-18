using System;
using System.Collections.Generic;
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

            this.Load += Quanlydiem_Load;
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
            try
            {
                // Load Sinh Viên
                List<SinhVien> listSV = svBLL.GetListSV();
                cbSinhVien.DataSource = listSV;
                cbSinhVien.DisplayMember = "HoTen";
                cbSinhVien.ValueMember = "MaSV";

                // Load Môn Học
                List<MonHoc> listMH = mhBLL.GetList();
                cbMonHoc.DataSource = listMH;
                cbMonHoc.DisplayMember = "TenMon";
                cbMonHoc.ValueMember = "MaMon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            dgvKetQua.Rows.Clear();
            try
            {
                List<KetQua> list = kqBLL.GetList();
                foreach (var item in list)
                {
                    int index = dgvKetQua.Rows.Add();
                    dgvKetQua.Rows[index].Cells[0].Value = item.MaSV;
                    dgvKetQua.Rows[index].Cells[1].Value = item.MaMon;

                    // Hiển thị text nếu chưa có điểm
                    dgvKetQua.Rows[index].Cells[2].Value = (item.DiemSo == -1) ? "Chưa có điểm" : item.DiemSo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng điểm: " + ex.Message);
            }
        }

        private void BtnLuuDiem_Click(object sender, EventArgs e)
        {
            if (cbSinhVien.SelectedValue == null || cbMonHoc.SelectedValue == null) return;

            string maSV = cbSinhVien.SelectedValue.ToString();
            string maMon = cbMonHoc.SelectedValue.ToString();

            if (!float.TryParse(txtDiem.Text, out float diem))
            {
                MessageBox.Show("Vui lòng nhập điểm số hợp lệ!");
                return;
            }

            string ketQua = kqBLL.NhapDiem(maSV, maMon, diem);
            MessageBox.Show(ketQua);
            LoadDataGrid();
        }

        private void DgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];

                string maSV = row.Cells[0].Value?.ToString();
                string maMon = row.Cells[1].Value?.ToString();
                string diemStr = row.Cells[2].Value?.ToString();

                cbSinhVien.SelectedValue = maSV;
                cbMonHoc.SelectedValue = maMon;
                txtDiem.Text = (diemStr == "Chưa có điểm") ? "" : diemStr;
            }
        }
    }
}