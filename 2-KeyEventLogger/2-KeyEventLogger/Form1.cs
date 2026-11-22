namespace _2_KeyEventLogger
{
    public partial class Form1 : Form
    {

        bool kayitAktif = false;
        int kayitSayisi = 0;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kayitAktif = true;
            lblDurum.Text = "Durum: Kayıt aktif";
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            kayitAktif = false;
            lblDurum.Text = "Durum: Kayıt durdu";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!kayitAktif) return;

            string tus = e.KeyCode.ToString();

            string zaman = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            string kayit = zaman + " - " + tus + " tuşuna basıldı";
            
            lstKayitlar.Items.Add(kayit);

            kayitSayisi++;

            lblSayac.Text = "Toplam kayıt: " + kayitSayisi;
        }
    }
}
