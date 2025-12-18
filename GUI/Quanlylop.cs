using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyThi_490.BLL;
using MyThi_490.Model;

namespace MyThi_490.GUI
{
    public partial class Quanlylop : Form
    {
        private LopBLL bll = new LopBLL();

        public Quanlylop()
        {
            InitializeComponent();

            this.Load += Quanlylop_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvLop.CellClick += DgvLop_CellClick;
        }

        private void Quanlylop_Load(object sender, EventArgs e)
        {
            cbKhoa.Items.Clear();
            cbKhoa.Items.AddRange(new string[] { "CNTT", "KT", "QTKD", "Ngôn Ngữ Anh" });
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;

            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dgvLop.Rows.Clear();
            try
            {
                List<Lop> list = bll.GetList();
                foreach (var item in list)
                {
                    dgvLop.Rows.Add(item.MaLop, item.TenLop, item.MaKhoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp!"); return;
            }
            MessageBox.Show(bll.ThemMoi(GetLopFromUI()));
            LoadDataGrid();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll.Sua(GetLopFromUI()));
            LoadDataGrid();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show("Xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Xoa(ma));
                LoadDataGrid();
                BtnLamMoi_Click(null, null);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
        }

        private void DgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells[0].Value?.ToString();
                txtTenLop.Text = row.Cells[1].Value?.ToString();
                cbKhoa.Text = row.Cells[2].Value?.ToString();
                txtMaLop.Enabled = false;
            }
        }

        private Lop GetLopFromUI() => new Lop
        {
            MaLop = txtMaLop.Text.Trim(),
            TenLop = txtTenLop.Text.Trim(),
            MaKhoa = cbKhoa.Text
        };

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}