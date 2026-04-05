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
    public partial class UyeListeForm : Form
    {
        public UyeListeForm()
        {
            InitializeComponent();
        }

        // Form açıldığında veritabanındaki tüm üyeleri DataGridView'a yükler
        private void UyeListeForm_Load(object sender, EventArgs e)
        {
            // DatabaseHelper'dan üye listesini çekip tabloya bağlıyoruz
            // DataGridView kolonları otomatik olarak Uye sınıfının property'lerinden oluşur
            dgvUyeler.DataSource = DatabaseHelper.UyeleriGetir();
        }
    }
}