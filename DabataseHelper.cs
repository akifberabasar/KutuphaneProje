using Microsoft.Data.SqlClient;

namespace KutuphaneProje
{
    internal class DatabaseHelper
    {
        // Veritabanı bağlantı bilgileri — sunucu adı, veritabanı adı ve güvenlik ayarları
        private static string connectionString = "Server=BAŞAR\\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // --- KİTAP İŞLEMLERİ ---
        // yardım alındı
        // Verilen ISBN numarasına sahip kitap veritabanında var mı kontrol eder
        // Varsa true, yoksa false döner
        public static bool KitapVarMi(int isbn)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // COUNT(*) ile eşleşen kayıt sayısını sorguluyoruz
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kitaplar WHERE ISBN = @ISBN", con);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                // 0'dan büyükse kitap zaten kayıtlı demektir
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Yeni bir kitabı veritabanına ekler
        public static void KitapEkle(Kitap kitap)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Kitap bilgilerini Kitaplar tablosuna ekliyoruz
                // @ işaretli parametreler SQL injection saldırılarına karşı koruma sağlar
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Kitaplar (ISBN, Ad, Yazar, Durum) VALUES (@ISBN, @Ad, @Yazar, @Durum)", con);
                cmd.Parameters.AddWithValue("@ISBN", kitap.ISBN);
                cmd.Parameters.AddWithValue("@Ad", kitap.Ad);
                cmd.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                cmd.Parameters.AddWithValue("@Durum", kitap.Durum);
                cmd.ExecuteNonQuery();
            }
        }

        // Veritabanındaki tüm kitapları liste olarak döner
        public static List<Kitap> KitaplariGetir()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kitaplar", con);
                SqlDataReader reader = cmd.ExecuteReader();
                // Her satırı okuyup Kitap nesnesine dönüştürüyoruz
                // yardım alındı
                while (reader.Read())
                {
                    kitaplar.Add(new Kitap
                    {
                        ISBN = (int)reader["ISBN"],
                        Ad = reader["Ad"].ToString(),
                        Yazar = reader["Yazar"].ToString(),
                        Durum = (bool)reader["Durum"]
                    });
                }
            }
            return kitaplar;
        }

       

        // Verilen üye numarasına sahip üye veritabanında var mı kontrol eder
        // Varsa true, yoksa false döner
        public static bool UyeVarMi(int uyeNo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Uyeler WHERE UyeNo = @UyeNo", con);
                cmd.Parameters.AddWithValue("@UyeNo", uyeNo);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Yeni bir üyeyi veritabanına ekler
        public static void UyeEkle(Uye uye)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Uyeler (UyeNo, Ad) VALUES (@UyeNo, @Ad)", con);
                cmd.Parameters.AddWithValue("@UyeNo", uye.UyeNo);
                cmd.Parameters.AddWithValue("@Ad", uye.Ad);
                cmd.ExecuteNonQuery();
            }
        }

        // Veritabanındaki tüm üyeleri liste olarak döner
        // yardım alındı
        public static List<Uye> UyeleriGetir()
        {
            List<Uye> uyeler = new List<Uye>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Uyeler", con);
                SqlDataReader reader = cmd.ExecuteReader();
                // Her satırı okuyup Uye nesnesine dönüştürüyoruz
                while (reader.Read())
                {
                    uyeler.Add(new Uye
                    {
                        UyeNo = (int)reader["UyeNo"],
                        Ad = reader["Ad"].ToString()
                    });
                }
            }
            return uyeler;
        }

       
        //yardım alındı
        // Seçilen kitabı seçilen üyeye ödünç verir
        // 1. Oduncler tablosuna kayıt ekler, teslim tarihi 15 gün sonrası olarak ayarlanır
        // 2. Kitabın durumunu 0 (ödünçte) olarak günceller
        public static void OduncVer(int uyeNo, int isbn)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Ödünç kaydını Oduncler tablosuna ekliyoruz
                //düzeltme yapıldı
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Oduncler (UyeNo, ISBN, Tarih) VALUES (@UyeNo, @ISBN, @Tarih)", con);
                cmd.Parameters.AddWithValue("@UyeNo", uyeNo);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.AddDays(15));
                cmd.ExecuteNonQuery();

                // Kitabın durumunu güncelliyoruz: 0 = ödünçte, 1 = rafta
                SqlCommand durumCmd = new SqlCommand(
                    "UPDATE Kitaplar SET Durum = 0 WHERE ISBN = @ISBN", con);
                durumCmd.Parameters.AddWithValue("@ISBN", isbn);
                durumCmd.ExecuteNonQuery();
            }
        }
    }
}