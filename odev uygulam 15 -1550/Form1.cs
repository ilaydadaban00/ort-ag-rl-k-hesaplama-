using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_uygulam_15__1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fizikpuan = Convert.ToInt32(txtFizikPuan.Text);
            int kiimyapuan = Convert.ToInt32(txtKimyaPuan.Text);
            int biyolojipuan = Convert.ToInt32(txtBiyolojiPuan.Text);
            int ingilizcepuan = Convert.ToInt32(txtİngilizcePuan.Text);
            int MatematikPuan = Convert.ToInt32(txtMatematikPuan.Text);
            int edebiyatpuan = Convert.ToInt32(txtEdebiyatPuan.Text);
            int dinpuan = Convert.ToInt32(txtDinPuan.Text);
            int felsefepuan =Convert.ToInt32(txtFelsefePuan.Text);
            int tarihpuan = Convert.ToInt32(txtTarihPuan.Text);
            int robotikpuan = Convert.ToInt32(txtRobotikPuan.Text);
            int ntppuan = Convert.ToInt32(txtNtpPuan.Text);
            int cografyapuan = Convert.ToInt32(txtCografyaPuan.Text);
            int bedenpuan = Convert.ToInt32(txtBedenPuan.Text);



            int fiziksaat = Convert.ToInt32(txtFizikSaat.Text);
            int kimyasaat = Convert.ToInt32(txtKimyaSaat.Text);
            int biyolojisaat = Convert.ToInt32(txtBiyolojiSaat.Text);
            int ingilizcesaat = Convert.ToInt32(txtİngilizceSaat.Text);
            int Matematiksaat = Convert.ToInt32(txtMatematikSaat.Text);
            int edebiyatsaat = Convert.ToInt32(txtEdebiyatSaat.Text);
            int dinsaat = Convert.ToInt32(txtDinSaat.Text);
            int felsefesaat = Convert.ToInt32(txtFelsefeSaat.Text);
            int robotiksaat = Convert.ToInt32(txtRobotikSaat.Text);
            int ntpsaat = Convert.ToInt32(txtNtpSaat.Text);
            int cografyasaat = Convert.ToInt32(txtCografyaSaat.Text);
            int bedensaat = Convert.ToInt32(txtBedenSaat.Text);
            int tarihsaat = Convert.ToInt32(txtTarihSaat.Text);


            double fizikagirlik = fizikpuan * fiziksaat;
            double kimyaagirlik = kiimyapuan * kimyasaat;
            double biyolojiagirlik = biyolojipuan * biyolojisaat;
            double ingilizceagirlik = ingilizcepuan * ingilizcesaat;
            double matematikagirlik = MatematikPuan * Matematiksaat;
            double edebiyatagirlik = edebiyatpuan * edebiyatsaat;
            double dinagirlik = dinpuan * dinsaat;
            double felsefeagirlik = felsefepuan * felsefesaat;
            double robotikagirlik = robotiksaat * robotikpuan;
            double ntpsagirlik = ntpsaat * ntppuan;
            double cografyaagirlik = cografyapuan * cografyasaat;
            double bedenagirlik = bedenpuan * bedensaat;
            double tarihagirlik = tarihpuan * tarihsaat;



            lblfizikAgirlik.Text = ("fizik ağırlık programınz:" + fizikagirlik.ToString());
            lblkimyaAgirlik.Text = ("kimya ağırlık puanınız:" + kimyaagirlik.ToString());
            lblbiyolojiAgirlik.Text = ("biyoloji  ağırlık puanınız:" + biyolojiagirlik.ToString());
            lblingilizceAgirlik.Text = ("ingilizce ağırlık :" +ingilizceagirlik.ToString());
            lblmatematikAgirlik.Text = ("matematik ağırlık puanınız:" + matematikagirlik.ToString());
            lbledebiyatAgirlik.Text = ("edebiyat ağırlık puanınız:" + edebiyatagirlik.ToString());
            lbldinAgirlik.Text = ("din ağırlık puanınız:" + dinagirlik.ToString());
            lblfelsefeAgirlik.Text = ("felsefe ağırlık puanınız:" + felsefeagirlik.ToString());
            lblrobotikAgirlik.Text = ("robotik ağırlık puanınız:" + robotikagirlik.ToString());
            lblntpAgirlik.Text = ("ntp ağırlık puanınız:" + ntpsagirlik.ToString());
            lblcografyaAgirlik.Text = ("cografya ağırlık puanınız:" + cografyaagirlik.ToString());
            lblbedenAgirlik.Text = ("beden ağırlık puanınız:" + bedenagirlik.ToString());
            lbltarihAgirlik.Text = ("tarih ağırlık puanınız:" + tarihagirlik.ToString());


            double devamsizlik = Convert.ToDouble(txtDevamsizlik.Text);
            







            int tumdersSaat = fiziksaat + kimyasaat + biyolojisaat + ingilizcesaat + Matematiksaat + edebiyatsaat + dinsaat + felsefesaat + robotiksaat + ntpsaat + cografyasaat + bedensaat + tarihsaat;
            double tumdersagirlik = fizikagirlik + kimyaagirlik + biyolojiagirlik + ingilizceagirlik + matematikagirlik + edebiyatagirlik + dinagirlik + felsefeagirlik + robotikagirlik + ntpsagirlik + cografyaagirlik + bedenagirlik + tarihagirlik;


            double ortalama = tumdersagirlik / tumdersSaat;
            lblOrtalama.Text=("ortalamanız:"+ortalama.ToString());


            if(ortalama < 50)
            {
                MessageBox.Show("malesef sınıfta kaldınız");
                lblZayif.ForeColor = Color.Red;
            
            }
            else if (ortalama > 70 && ortalama < 85)
            {
                MessageBox.Show("tebrikler teşekkür belgesi almaya hak kazandınız...");
                lblZayif.ForeColor = Color.Green;
            }
            else if (ortalama > 85 && ortalama <= 100)
            {
                MessageBox.Show("nasıl aldın bu zorluklara karsı takddir belgesini tebrikler... ");
                lblZayif.ForeColor = Color.Green;
            }
            if (ntppuan < 50)
            {
                MessageBox.Show("malesef ntp dersinden kaldıgınız için sınıf tekrarı");
                lblZayif.ForeColor = Color.Red;
            }
            else if (ortalama > 70 && ortalama < 85)
            {
                MessageBox.Show("tebrikler teşekkür belgesi almaya hak kazandınız...");
                lblZayif.ForeColor = Color.Green;
            }
            else if (ortalama > 85 && ortalama <= 100)
            {
                MessageBox.Show("nasıl aldın bu zorluklara karsı takddir belgesini tebrikler... ");
                lblZayif.ForeColor = Color.Green;
            }
            if (edebiyatpuan < 50)
            {
                MessageBox.Show("malesef edebiyat dersinden kaldıgınız için sınıf tekrarı");
                lblZayif.ForeColor = Color.Red;
            }
            else if (ortalama > 70 && ortalama < 85)
            {
                MessageBox.Show("tebrikler teşekkür belgesi almaya hak kazandınız...");
                lblZayif.ForeColor = Color.Green;
            }
            else if (ortalama > 85 && ortalama <= 100)
            {
                MessageBox.Show("nasıl aldın bu zorluklara karsı takddir belgesini tebrikler... ");
                lblZayif.ForeColor = Color.Green;
            }
            if (devamsizlik > 10)
            {
                MessageBox.Show("malesef devmasızlıgınız 10 günü aştıgı için sınıfta kaldınız");
                lblZayif.ForeColor = Color.Red;
            }
            else if (ortalama > 70 && ortalama < 85)
            {
                MessageBox.Show("tebrikler teşekkür belgesi almaya hak kazandınız...");
                lblZayif.ForeColor = Color.Green;
            }
            else if (ortalama > 85 && ortalama <= 100)
            {
                MessageBox.Show("nasıl aldın bu zorluklara karsı takddir belgesini tebrikler... ");
                lblZayif.ForeColor = Color.Green;
            }
            else if (ortalama > 50 || ntppuan > 50 || edebiyatpuan > 50 || devamsizlik < 10)
            {
                MessageBox.Show("tebrikler geçtiniz ortalamanız :" + ortalama.ToString());
                lblZayif.ForeColor = Color.Green;
            }
                     
           if (devamsizlik > 5)
            {
                MessageBox.Show("malesef belge alamazsın çunku devamsızlıgın 5 günden fazla");
                lblZayif.ForeColor = Color.Red;
            }

     
            if (devamsizlik == 0)
            {
                MessageBox.Show("tebrikler devamsızlık hiç yapmamışsınız yok");
            }
            int zayif;
            if (fizikpuan < 50)
            {
               

            }

            lblZayif.ForeColor = Color.Red;

        }

        private void lblmatematikAgirlik_Click(object sender, EventArgs e)
        {

        }
    }
}
