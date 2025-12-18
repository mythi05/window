using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model;

namespace MyThi_490.GUI
{
    public partial class Quanlysinhvien : Form
    {
        private SinhVienBLL bll = new SinhVienBLL();

        public Quanlysinhvien()
        {
            InitializeComponent();

            // Đăng ký các sự kiện chưa có trong Designer
            this.Load += Quanlysinhvien_Load;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvSinhVien.CellClick += DgvSinhVien_CellClick;
        }

        private void Quanlysinhvien_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ban đầu cho ComboBox
            cbKhoa.Items.Clear();
            cbKhoa.Items.AddRange(new string[] { "CNTT", "Kế Toán", "Du Lịch", "Ngôn Ngữ Anh" });
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;

            cbLop.Items.Clear();
            cbLop.Items.AddRange(new string[] { "20DTH1", "20DTH2", "20KKT1", "20DL1" });
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;

            if (cbGioitinh.Items.Count > 0) cbGioitinh.SelectedIndex = 0;

            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            dgvSinhVien.Rows.Clear();
            List<SinhVien> listSV = bll.GetListSV();

            foreach (var sv in listSV)
            {
                int index = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[index].Cells[0].Value = sv.MaSV;
                dgvSinhVien.Rows[index].Cells[1].Value = sv.HoTen;
                dgvSinhVien.Rows[index].Cells[2].Value = sv.SDT;
                dgvSinhVien.Rows[index].Cells[3].Value = sv.GioiTinh;
                dgvSinhVien.Rows[index].Cells[4].Value = sv.Khoa;
                dgvSinhVien.Rows[index].Cells[5].Value = sv.NgaySinh.ToString("dd/MM/yyyy");
            }
        }

        // Sự kiện Thêm (khớp với btnThem.Click trong Designer)
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV!");
                return;
            }
            string ketQua = bll.ThemMoi(GetSinhVienFromUI());
            MessageBox.Show(ketQua);
            LoadDataToGrid();
        }

        // Sự kiện Sửa (khớp với btnSua.Click trong Designer)
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string ketQua = bll.Sua(GetSinhVienFromUI());
            MessageBox.Show(ketQua);
            LoadDataToGrid();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMSSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ketQua = bll.Xoa(maSV);
                MessageBox.Show(ketQua);
                LoadDataToGrid();
                BtnLamMoi_Click(null, null);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoten.Clear();
            if (cbGioitinh.Items.Count > 0) cbGioitinh.SelectedIndex = 0;
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
            txtMSSV.Enabled = true;
            txtMSSV.Focus();
        }

        private SinhVien GetSinhVienFromUI()
        {
            return new SinhVien
            {
                MaSV = txtMSSV.Text.Trim(),
                HoTen = txtHoten.Text.Trim(),
                GioiTinh = cbGioitinh.Text,
                Khoa = cbKhoa.Text,
                Lop = cbLop.Text,
                SDT = "",
                NgaySinh = DateTime.Now
            };
        }

        private void DgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtHoten.Text = row.Cells[1].Value?.ToString();
                cbGioitinh.Text = row.Cells[3].Value?.ToString();
                cbKhoa.Text = row.Cells[4].Value?.ToString();

                txtMSSV.Enabled = false; // Không cho sửa khóa chính
            }
        }

        // Các hàm trống để tránh lỗi Designer nếu bạn lỡ click vào
        private void panelTop_Paint(object sender, PaintEventArgs e) { }
    }
}