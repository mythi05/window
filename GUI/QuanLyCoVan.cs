using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model;

namespace MyThi_490.GUI
{
    public partial class Quanlycovan : Form
    {
        private CoVanBLL bll = new CoVanBLL();

        public Quanlycovan()
        {
            InitializeComponent();

            // Gán sự kiện
            this.Load += Quanlycovan_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvCoVan.CellClick += DgvCoVan_CellClick;
        }

        private void Quanlycovan_Load(object sender, EventArgs e)
        {
            cbKhoa.Items.Clear();
            cbKhoa.Items.AddRange(new string[] { "CNTT", "KT", "QTKD", "Du Lịch", "Ngôn Ngữ Anh" });
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;

            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvCoVan.Rows.Clear();
            try
            {
                List<CoVan> list = bll.GetList();
                foreach (var item in list)
                {
                    dgvCoVan.Rows.Add(item.MaCV, item.TenCV, item.Khoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã cố vấn!");
                return;
            }
            MessageBox.Show(bll.ThemMoi(GetCoVanFromUI()));
            LoadDataGrid();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll.Sua(GetCoVanFromUI()));
            LoadDataGrid();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaCV.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Xóa Cố vấn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Xoa(ma));
                LoadDataGrid();
                BtnLamMoi_Click(null, null);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;
            txtMaCV.Enabled = true;
            txtMaCV.Focus();
        }

        private void DgvCoVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCoVan.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells[0].Value?.ToString();
                txtTenCV.Text = row.Cells[1].Value?.ToString();
                cbKhoa.Text = row.Cells[2].Value?.ToString();

                txtMaCV.Enabled = false; // Khóa mã khi sửa
            }
        }

        private CoVan GetCoVanFromUI() => new CoVan
        {
            MaCV = txtMaCV.Text.Trim(),
            TenCV = txtTenCV.Text.Trim(),
            Khoa = cbKhoa.Text
        };
    }
}