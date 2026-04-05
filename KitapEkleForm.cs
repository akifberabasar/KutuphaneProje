using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }

        // Kaydet butonuna tıklanınca çalışır
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            // Tüm alanların dolu olup olmadığını kontrol ediyoruz
            if (txtISBN.Text == "" || txtAd.Text == "" || txtYazar.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            // ISBN'nin sayı olup olmadığını kontrol ediyoruz
            if (!int.TryParse(txtISBN.Text, out int isbn))
            {
                MessageBox.Show("ISBN sadece sayı olmalıdır.", "Uyarı");
                return;
            }

            // Aynı ISBN'ye sahip kitap zaten kayıtlıysa ekleme yapılmaz
            if (DatabaseHelper.KitapVarMi(isbn))
            {
                MessageBox.Show("Bu ISBN zaten kayıtlı.", "Uyarı");
                return;
            }

            // Formdan alınan bilgilerle yeni bir Kitap nesnesi oluşturuyoruz
            // Durum = true: kitap rafta mevcut demektir
            Kitap kitap = new Kitap
            {
                ISBN = isbn,
                Ad = txtAd.Text,
                Yazar = txtYazar.Text,
                Durum = true
            };

            // Kitabı veritabanına kaydediyoruz
            DatabaseHelper.KitapEkle(kitap);
            MessageBox.Show("Kitap başarıyla eklendi.", "Bilgi");
            this.Close();
        }

        // İptal butonuna tıklanınca formu kapatır, kayıt yapılmaz
        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}