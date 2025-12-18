using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model;

namespace MyThi_490.GUI
{
    public partial class Quanlymonhoc : Form
    {
        private MonHocBLL bll = new MonHocBLL();

        public Quanlymonhoc()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += Quanlymonhoc_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvMonHoc.CellClick += DgvMonHoc_CellClick;
        }

        private void Quanlymonhoc_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvMonHoc.Rows.Clear();
            try
            {
                List<MonHoc> list = bll.GetList();
                foreach (var item in list)
                {
                    dgvMonHoc.Rows.Add(item.MaMon, item.TenMon, item.SoTinChi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn!"); return;
            }
            MessageBox.Show(bll.ThemMoi(GetMonHocFromUI()));
            LoadDataGrid();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll.Sua(GetMonHocFromUI()));
            LoadDataGrid();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMon.Text)) return;
            if (MessageBox.Show("Xóa môn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Xoa(txtMaMon.Text));
                LoadDataGrid();
                BtnLamMoi_Click(null, null);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            numSoTinChi.Value = 1;
            txtMaMon.Enabled = true;
            txtMaMon.Focus();
        }

        private void DgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                txtMaMon.Text = row.Cells[0].Value?.ToString();
                txtTenMon.Text = row.Cells[1].Value?.ToString();
                if (int.TryParse(row.Cells[2].Value?.ToString(), out int tc)) numSoTinChi.Value = tc;
                txtMaMon.Enabled = false;
            }
        }

        private MonHoc GetMonHocFromUI() => new MonHoc
        {
            MaMon = txtMaMon.Text.Trim(),
            TenMon = txtTenMon.Text.Trim(),
            SoTinChi = (int)numSoTinChi.Value
        };

        private void panelTop_Paint(object sender, PaintEventArgs e) { }
    }
}