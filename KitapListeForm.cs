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
    public partial class KitapListeForm : Form
    {
        public KitapListeForm()
        {
            InitializeComponent();
        }

        // Form açıldığında veritabanındaki tüm kitapları DataGridView'a yükler
        private void KitapListeForm_Load(object sender, EventArgs e)
        {
            // DatabaseHelper'dan kitap listesini çekip tabloya bağlıyoruz
            // DataGridView kolonları otomatik olarak Kitap sınıfının property'lerinden oluşur
            dgvKitaplar.DataSource = DatabaseHelper.KitaplariGetir();
        }
    }
}