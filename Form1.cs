using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DuBaoGiaDT
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private DataTable dt1;
        private DataTable dt2;
        List<DoiTuong> lst1;
        List<DoiTuong> lst2;
        List<DoiTuong> lstTong;
        Thread t1;
        Thread t2;
        double hang, ram, dai, cpu, loaiMH, rom;
        double maxRam, minRam, maxRom, minRom;
        double maxWidth, minWidth, maxScreen, minScreen;
        double maxPin, minPin, maxWeight, minWeigth, maxHeight, minHeight;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        private void txtKTMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtDLPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtKhoiLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void loadCboChip()
        {
            cboCPU.DataSource = DBConnect.loadChip();
            cboCPU.DisplayMember = "tenChip";
            cboCPU.ValueMember = "hieuNang";
        }
        public void loadHang()
        {
            cbohang.DataSource = DBConnect.loadHang();
            cbohang.DisplayMember = "tenHang";
            cbohang.ValueMember = "doTincay";
        }
        public void loadloaiMH()
        {
            cboLoaiMH.DataSource = DBConnect.loadLoaiMH();
            cboLoaiMH.DisplayMember = "tenLoaiMH";
            cboLoaiMH.ValueMember = "chatLuong";
        }
        public void loadData()
        {
            dt = DBConnect.loadSanPham();
            dt1 = DBConnect.Luong1();
            dt2 = DBConnect.Luong2();
            gridSP.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboRam.SelectedIndex = 0;
            cboRom.SelectedIndex = 0;
            loadCboChip();
            loadHang();
            loadloaiMH();
            loadData();
            maxRam = DBConnect.MaxRam();
            minRam = DBConnect.MinRam();
            maxRom = DBConnect.MaxRom();
            minRom = DBConnect.MinRom();
            maxWeight = DBConnect.MaxWeight();
            minWeigth = DBConnect.MinWeight();
            maxWidth = DBConnect.MaxWidth();
            minWidth = DBConnect.MinWidth();
            minScreen = DBConnect.MinScreen();
            maxScreen = DBConnect.MaxScreen();
            maxPin = DBConnect.MaxPin();
            minPin = DBConnect.MinPin();
            maxHeight = DBConnect.MaxHeight();
            minHeight = DBConnect.MinHeight();
        }
        public double chuanHoaRam(double ram)
        {
            double ram1 = (ram - minRam) / (maxRam - minRam) * (1 - 0);
            return ram1;
        }
        public double chuanHoaRom(double rom)
        {
            double rom1 = (rom - minRom) / (maxRom - minRom) * (1 - 0);
            return rom1;
        }
        public double chuanhoaWeight(double weight)
        {
            double weight1 = (weight - minWeigth) / (maxWeight - minWeigth) * (1 - 0);
            return weight1;
        }
        public double chuanhoaScreen(double screen)
        {
            double screen1 = (screen - minScreen) / (maxScreen - minScreen) * (1 - 0);
            return screen1;
        }
        public double chuanhoaPin(double pin)
        {
            double pin1 = (pin - minPin) / (maxPin - minPin) * (1 - 0);
            return pin1;
        }
        public double chuanhoaWidth(double width)
        {
            double width1 = (width - minWidth) / (maxWidth - minWidth) * (1 - 0);
            return width1;
        }
        public double chuanhoaHeight(double height)
        {
            double height1 = (height - minHeight) / (maxHeight - minHeight) * (1 - 0);
            return height1;
        }
        public void xuli()
        {
            double hang = double.Parse(cbohang.SelectedValue.ToString());
            double ram = chuanHoaRam(double.Parse(cboRam.Text));
            double rom = chuanHoaRom(double.Parse(cboRom.Text));
            double weight = chuanhoaWeight(double.Parse(txtKhoiLuong.Text));
            double manHinh = chuanhoaScreen(double.Parse(txtKTMH.Text));
            double pin = chuanhoaPin(double.Parse(txtDLPin.Text));
            double rong = chuanhoaWidth(double.Parse(txtRong.Text));
            double dai = chuanhoaHeight(double.Parse(txtDai.Text));
            double cpu = double.Parse(cboCPU.SelectedValue.ToString());
            double loaiMH = double.Parse(cboLoaiMH.SelectedValue.ToString());
            List<DoiTuong> lst = new List<DoiTuong>();
            foreach (DataRow row in dt.Rows)
            {
                double hang1 = (double)row["Hãng"];
                double ram1 = chuanHoaRam((double)row["Ram"]);
                double rom1 = chuanHoaRom((double)row["Rom"]);
                double weigth1 = chuanhoaWeight((double)row["Weight"]);
                double manHinh1 = chuanhoaScreen((double)row["Screen"]);
                double pin1 = chuanhoaPin((double)row["Pin"]);
                double rong1 = chuanhoaWidth((double)row["Width"]);
                double dai1 = chuanhoaHeight((double)row["Height"]);
                double cpu1 = (double)row["CPU"];
                double loaiMH1 = (double)row["Sceen_Quality"];
                double gia = (double)row["Price"];
                double kc = Math.Pow(hang - hang1, 2) + Math.Pow(ram - ram1, 2) + Math.Pow(rom - rom1, 2) + Math.Pow(weight - weigth1, 2) + Math.Pow(manHinh - manHinh1, 2) + Math.Pow(pin - pin1, 2) + Math.Pow(rong - rong1, 2)
                    + Math.Pow(dai - dai1, 2) + Math.Pow(cpu - cpu1, 2) + Math.Pow(loaiMH - loaiMH1, 2);
                double kc2 = Math.Sqrt(kc);
                DoiTuong doiTuong = new DoiTuong(kc2, gia);
                lst.Add(doiTuong);
            }
            var lstSort = lst.OrderBy(p => p.KhoangCach);
            var lstTakeK = lstSort.Take(2);
            var max = lstTakeK.Max(p => p.Gia);
            var sum = lstTakeK.Sum(p => p.Gia);
            double gia2 = sum / 2;
            txtKetQua.Text = string.Format("{0:0,0 VND}", gia2);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //xuli();
            if(txtKTMH.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào màn hình");
                return;
            }
            if (txtDLPin.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào pin");
                return;
            }
            if (txtDai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào chiều dài");
                return;
            }
            if (txtRong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào chiều rộng");
                return;
            }
            if (txtKhoiLuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào khối lượng");
                return;
            }
            hang = double.Parse(cbohang.SelectedValue.ToString());
            ram = chuanHoaRam(double.Parse(cboRam.Text));
            rom = chuanHoaRom(double.Parse(cboRom.Text));
            dai = chuanhoaHeight(double.Parse(txtDai.Text));
            cpu = double.Parse(cboCPU.SelectedValue.ToString());
            loaiMH = double.Parse(cboLoaiMH.SelectedValue.ToString());
            if(double.Parse(txtKTMH.Text) < minScreen)
            {
                MessageBox.Show("Bạn nhập giá trị màn hình lớn hơn "+minScreen.ToString());
                return;
            }
            if(double.Parse(txtKTMH.Text) > maxScreen)
            {
                MessageBox.Show("Bạn nhập giá trị màn hình nhỏ hơn " + maxScreen.ToString());
                return;
            }
            if(double.Parse(txtDLPin.Text) < minPin)
            {
                MessageBox.Show("Bạn nhập giá trị pin lớn hơn " + minPin.ToString());
                return;
            }
            if(double.Parse(txtDLPin.Text) > maxPin)
            {
                MessageBox.Show("Bạn nhập giá trị pin nhỏ hơn " + maxPin.ToString());
                return;
            }
            if(double.Parse(txtRong.Text) < minWidth)
            {
                MessageBox.Show("Bạn nhập giá trị chiều rộng lớn hơn " + minWidth.ToString());
                return;
            }
            if(double.Parse(txtRong.Text) > maxWidth)
            {
                MessageBox.Show("Bạn nhập giá trị chiều rộng lớn hơn " + maxWidth.ToString());
                return;
            }
            if(double.Parse(txtDai.Text) < minHeight)
            {
                MessageBox.Show("Bạn nhập giá trị chiều dài lớn hơn " + minHeight.ToString());
                return;
            }
            if (double.Parse(txtDai.Text) > maxHeight)
            {
                MessageBox.Show("Bạn nhập giá trị chiều dài bé hơn " + maxHeight.ToString());
                return;
            }
            if (double.Parse(txtKhoiLuong.Text) < minWeigth)
            {
                MessageBox.Show("Bạn nhập giá trị khối lượng lớn hơn " + minWeigth.ToString());
                return;
            }
            if (double.Parse(txtKhoiLuong.Text) > maxWeight)
            {
                MessageBox.Show("Bạn nhập giá trị khối lượng bé hơn " + maxWeight.ToString());
                return;
            }
            t1 = new Thread(new ThreadStart(xuli1));
            t2 = new Thread(new ThreadStart(xuli2));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            lstTong = new List<DoiTuong>();
            foreach(var a in lst1)
            {
                lstTong.Add(a);
            }
            foreach (var b in lst2)
            {
                lstTong.Add(b);
            }
            var lstSort = lstTong.OrderBy(p => p.KhoangCach);
            var lstTakeK = lstSort.Take(5);
            var max = lstTakeK.Max(p => p.Gia);
            var sum = lstTakeK.Sum(p => p.Gia);
            double gia2 = sum / 5;
            txtKetQua.Text = string.Format("{0:0,0 VND}", gia2);
        }
        public void xuli1()
        {
            double weight = chuanhoaWeight(double.Parse(txtKhoiLuong.Text));
            double manHinh = chuanhoaScreen(double.Parse(txtKTMH.Text));
            double pin = chuanhoaPin(double.Parse(txtDLPin.Text));
            double rong = chuanhoaWidth(double.Parse(txtRong.Text));
            double dai = chuanhoaHeight(double.Parse(txtDai.Text));
            
            lst1 = new List<DoiTuong>();
            foreach (DataRow row in dt1.Rows)
            {
                double hang1 = (double)row["Hãng"];
                double ram1 = chuanHoaRam((double)row["Ram"]);
                double rom1 = chuanHoaRom((double)row["Rom"]);
                double weigth1 = chuanhoaWeight((double)row["Weight"]);
                double manHinh1 = chuanhoaScreen((double)row["Screen"]);
                double pin1 = chuanhoaPin((double)row["Pin"]);
                double rong1 = chuanhoaWidth((double)row["Width"]);
                double dai1 = chuanhoaHeight((double)row["Height"]);
                double cpu1 = (double)row["CPU"];
                double loaiMH1 = (double)row["Sceen_Quality"];
                double gia = (double)row["Price"];
                double kc = Math.Pow(hang - hang1, 2) + Math.Pow(ram - ram1, 2) + Math.Pow(rom - rom1, 2) + Math.Pow(weight - weigth1, 2) + Math.Pow(manHinh - manHinh1, 2) + Math.Pow(pin - pin1, 2) + Math.Pow(rong - rong1, 2)
                    + Math.Pow(dai - dai1, 2) + Math.Pow(cpu - cpu1, 2) + Math.Pow(loaiMH - loaiMH1, 2);
                double kc2 = Math.Sqrt(kc);
                DoiTuong doiTuong = new DoiTuong(kc2, gia);
                lst1.Add(doiTuong);
            }
        }
        public void xuli2()
        {
            double weight = chuanhoaWeight(double.Parse(txtKhoiLuong.Text));
            double manHinh = chuanhoaScreen(double.Parse(txtKTMH.Text));
            double pin = chuanhoaPin(double.Parse(txtDLPin.Text));
            double rong = chuanhoaWidth(double.Parse(txtRong.Text));
            double dai = chuanhoaHeight(double.Parse(txtDai.Text));
            lst2 = new List<DoiTuong>();
            foreach (DataRow row in dt2.Rows)
            {
                double hang1 = (double)row["Hãng"];
                double ram1 = chuanHoaRam((double)row["Ram"]);
                double rom1 = chuanHoaRom((double)row["Rom"]);
                double weigth1 = chuanhoaWeight((double)row["Weight"]);
                double manHinh1 = chuanhoaScreen((double)row["Screen"]);
                double pin1 = chuanhoaPin((double)row["Pin"]);
                double rong1 = chuanhoaWidth((double)row["Width"]);
                double dai1 = chuanhoaHeight((double)row["Height"]);
                double cpu1 = (double)row["CPU"];
                double loaiMH1 = (double)row["Sceen_Quality"];
                double gia = (double)row["Price"];
                double kc = Math.Pow(hang - hang1, 2) + Math.Pow(ram - ram1, 2) + Math.Pow(rom - rom1, 2) + Math.Pow(weight - weigth1, 2) + Math.Pow(manHinh - manHinh1, 2) + Math.Pow(pin - pin1, 2) + Math.Pow(rong - rong1, 2)
                    + Math.Pow(dai - dai1, 2) + Math.Pow(cpu - cpu1, 2) + Math.Pow(loaiMH - loaiMH1, 2);
                double kc2 = Math.Sqrt(kc);
                DoiTuong doiTuong = new DoiTuong(kc2, gia);
                lst2.Add(doiTuong);
            }
        }
    }
}
