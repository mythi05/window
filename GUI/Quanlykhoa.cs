using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model; // Đảm bảo bạn có Model Khoa

namespace MyThi_490.GUI
{
    public partial class Quanlykhoa : Form
    {
        private KhoaBLL bll = new KhoaBLL();

        public Quanlykhoa()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += Quanlykhoa_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvKhoa.CellClick += DgvKhoa_CellClick;
        }

        private void Quanlykhoa_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            dgvKhoa.Rows.Clear();
            try
            {
                // Giả định GetList trả về List<Khoa>
                var list = bll.GetList();
                foreach (var item in list)
                {
                    dgvKhoa.Rows.Add(item.MaKhoa, item.TenKhoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            bll.ThemMoi(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim());
            MessageBox.Show("Thêm mới thành công!");
            HienThiDuLieu();
            BtnLamMoi_Click(null, null);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text)) return;

            bll.Sua(txtMaKhoa.Text.Trim(), txtTenKhoa.Text.Trim());
            MessageBox.Show("Cập nhật thành công!");
            HienThiDuLieu();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn khoa để xóa!");
                return;
            }

            if (MessageBox.Show("Xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bll.Xoa(ma);
                HienThiDuLieu();
                BtnLamMoi_Click(null, null);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Focus();
        }

        private void DgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells[0].Value?.ToString();
                txtTenKhoa.Text = row.Cells[1].Value?.ToString();

                txtMaKhoa.Enabled = false; // Khóa khóa chính khi sửa
            }
        }
    }
}