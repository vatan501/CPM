using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPM_Şebeke_Çizme_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //verileri el ile girmemek için uygulama yülenirken tabloya yazdırıyoruz
            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[0].Cells[0].Value = "A";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[1].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[0].Cells[7].Value = 7;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[1].Cells[0].Value = "B";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[1].Value = "A";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[1].Cells[7].Value = 1;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[2].Cells[0].Value = "C";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[1].Value = "B";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[2].Cells[7].Value = 1;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[3].Cells[0].Value = "D";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[1].Value = "B";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[2].Value = "C";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[3].Cells[7].Value = 5;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[4].Cells[0].Value = "E";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[1].Value = "C";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[4].Cells[7].Value = 5;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[5].Cells[0].Value = "F";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[1].Value = "E";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[5].Cells[7].Value = 14;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[6].Cells[0].Value = "G";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[1].Value = "E";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[6].Cells[7].Value = 1;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[7].Cells[0].Value = "H";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[1].Value = "E";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[7].Cells[7].Value = 2;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[8].Cells[0].Value = "I";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[1].Value = "H";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[8].Cells[7].Value = 1;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[9].Cells[0].Value = "J";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[1].Value = "D";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[2].Value = "F";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[3].Value = "G";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[4].Value = "H";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[5].Value = "I";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[9].Cells[7].Value = 30;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[10].Cells[0].Value = "K";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[1].Value = "J";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[10].Cells[7].Value = 14;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[11].Cells[0].Value = "L";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[1].Value = "J";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[11].Cells[7].Value = 5;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[12].Cells[0].Value = "M";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[1].Value = "J";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[2].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[3].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[12].Cells[7].Value = 5;

            dgw_Faaliyet_Tablosu.Rows.Add();
            dgw_Faaliyet_Tablosu.Rows[13].Cells[0].Value = "N";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[1].Value = "K";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[2].Value = "L";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[3].Value = "M";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[4].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[5].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[6].Value = "-";
            dgw_Faaliyet_Tablosu.Rows[13].Cells[7].Value = 5;
        }

        private void btn_Sebeke_Ciz_Click(object sender, EventArgs e)
        {
            //Burdaki metotları çağırma sırası çok önemli
            // ilk önce kendisinden sonraki faaliyetleri bulan gösterdigi_faaliyet() fonksiyonunu
            //ikinci olarak erken başlagıç ve erken bitişleri bulan fonksiyonu
            //son olarak geç başlangıç ve bitişleri bulan fonksiyonu çalıştırıyoruz....

            //CPM şebeke tablosuna faaliyetin göstereceği faaliyetleri yazdımak için metodumuzu çağırıyoruz
            gösterdigi_faaliyet();

            //CPM şebeke tablomuzada faaliyetlerin erken başlangıç ve sonlanma değerlerini hesaplamak için metodumuzu çağırıyoruz
            erken_baslangıc_sonlanma();

            //CPM Şebeke tablomuzda faaliyetlerin geç başlangıç ve sonlanma değerlerini hesaplamak için metodumuzu çağırıyoruz
            gec_baslangic_sonlanma();

            //Şebeke sayfasına gösterir
            tabControl1.SelectTab(1);
        }

        //CPM şebeke tablosu oluşturulduktan sonra kritik yol bulunabilir
        private void btn_kritik_yol_bul_Click(object sender, EventArgs e)
        {
            //döngü için satır sayısını alıyoruz
            int satir_sayisi = dgw_CPM_sebeke_tablosu.RowCount;
            int fark = 0;
            string kritik_yol = "";
            for (int i = 0; i < satir_sayisi-1; i++)
            {
                int eb = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i].Cells[2].Value);
                int gb= Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i].Cells[4].Value);
                fark = eb - gb;
                //fark 0 ise kritik yolun bir parçasıdır
                if (fark==0)
                {
                    kritik_yol = kritik_yol + "-->" + dgw_CPM_sebeke_tablosu.Rows[i].Cells[0].Value.ToString();
                }
            }
            MessageBox.Show(kritik_yol);
        }

        public void gösterdigi_faaliyet()
        {
            //satır sayısı kadar dön
            for (int i = 0; i < (dgw_Faaliyet_Tablosu.RowCount-1); i++)
            {

                string faaliyet_kodu = dgw_Faaliyet_Tablosu.Rows[i].Cells[0].Value.ToString();
                string faaliyetin_suresi = dgw_Faaliyet_Tablosu.Rows[i].Cells[7].Value.ToString();

                //MessageBox.Show(dgw_Faaliyet_Tablosu.Rows[i].Cells[0].Value.ToString());
                if (dgw_Faaliyet_Tablosu.Rows[i].Cells[1].Value.ToString()=="-")
                {
                    //Faaliyet kodunu cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 0, faaliyet_kodu);
                    //gideceği faaliyeti yazdık
                    CPM_tablosuna_yaz(i, 1, sonraki_faaliyeti_bul(faaliyet_kodu));

                    //erken başlangıç cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 2, "0");

                    //erken sonlanmayı cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 3, faaliyetin_suresi);

                    //geç başlangıcı cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 4, "0");

                    //geç sonlanmayı cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 5, faaliyetin_suresi);

                    //faaliyetin süresini cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 6, faaliyetin_suresi);
                }
                else
                {
                    //Faaliyet kodunu cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 0, faaliyet_kodu);
                    //gideceği faaliyeti yazdık
                    CPM_tablosuna_yaz(i, 1, sonraki_faaliyeti_bul(faaliyet_kodu));

                    //faaliyetin süresini cpm tablosuna yazdık
                    CPM_tablosuna_yaz(i, 6, faaliyetin_suresi);
                }
            }
        }

        public string sonraki_faaliyeti_bul(string faaliyet_kodu)
        {
            string sonraki_faaliyet_kodu = "";

            //burda öncelikli faaliyet sütunumuz 6 adet olduğu için her sütunda teker teker arayacağız
            for (int i = 1; i < 7; i++)
            {
                //öncelikli faaliyetlerin herbirini kontrol etmek için
                for (int k = 0; k < (dgw_Faaliyet_Tablosu.RowCount - 1); k++)
                {
                    //eğer gelen faaliyet ile öncelikli faaliyet eşit ise sonraki faaliyetimizdir
                    if (dgw_Faaliyet_Tablosu.Rows[k].Cells[i].Value.ToString() == faaliyet_kodu)
                    {
                        //burda - işareti sadece arada olsun diye if kullandık
                        if (sonraki_faaliyet_kodu=="")
                        {
                            sonraki_faaliyet_kodu = dgw_Faaliyet_Tablosu.Rows[k].Cells[0].Value.ToString();
                        }
                        else
                        {
                            sonraki_faaliyet_kodu = dgw_Faaliyet_Tablosu.Rows[k].Cells[0].Value.ToString() + "-" + sonraki_faaliyet_kodu;
                        }
                        
                    }
                }  
            }
            //son faaliyete bir şey yazamayacağı için boş kalacak ona ++SON++ yazsın
            if (sonraki_faaliyet_kodu=="")
            {
                return "++SON++";
            }
            //son faaliyet değilse
            else
            {
                //kendisinden sonra gelecek olan faaliyetin kodunu gönderiyoruz
                return sonraki_faaliyet_kodu;
            }
        }

        public void CPM_tablosuna_yaz(int satir, int sutun, string veri)
        {
            //fazladan satır eklemesin diye yazdım en fazla 15 sütun ekleyecek
            if (dgw_CPM_sebeke_tablosu.Rows.Count<15)
            {
                //satır ekle
                dgw_CPM_sebeke_tablosu.Rows.Add();
            }
            //tabloya gelen satır ve sütuna göre veriyi yazıyoruz
            dgw_CPM_sebeke_tablosu.Rows[satir].Cells[sutun].Value = veri;
        }

        public void erken_baslangıc_sonlanma()
        {
            //CPM şebeke tablosunda ilk satır hariç döngüye giriyoruz
            for (int i = 1; i < (dgw_CPM_sebeke_tablosu.RowCount - 1); i++)
            {
                //hangi kodun erken ve başlangıç ve sonlanmasını bulacağımızı alıyoruz
                string kod = dgw_CPM_sebeke_tablosu.Rows[i].Cells[0].Value.ToString();

                //CPM şebeke tablosunda son satır hariç döngüye giriyoruz
                for (int k = 0; k < (dgw_Faaliyet_Tablosu.RowCount - 2); k++)
                {
                    //gösterdiği faaliyet sütununda arama yapacağız bu nedenle faaliyeti split işlem yapıp kodu tek bırakmalıyızz
                    string gfaaliyet= dgw_CPM_sebeke_tablosu.Rows[k].Cells[1].Value.ToString();
                    string[] _split_faaliyet = gfaaliyet.Split('-');
                    //split sonucu kaç kodu çıktığını bilmediğimzi için tekrar kod sayısı kadar döngüye giriyoruz
                    for (int m = 0; m < _split_faaliyet.Count(); m++)
                    {
                        //kodumuz ile gösterdiği faaliyet eşleşti ise en büyük olan erken sonlanmayı 
                        //kodumuzun erken başlangıç değerine yazıyoruz
                        if (_split_faaliyet[m]==kod)
                        {
                            //MessageBox.Show(dgw_CPM_sebeke_tablosu.Rows[k].Cells[0].Value.ToString() + "-" + _split_faaliyet[m] + "-" + kod);
                            // gfaaliyetin erken sonlanmasını kodun erken başlagıncına yazabiliriz
                            int kod_eb = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i].Cells[2].Value);
                            int kod_es = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i].Cells[3].Value);
                            int kod_faalisure = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i].Cells[6].Value);

                            int gfaaliyet_es = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[3].Value);

                            if (gfaaliyet_es>kod_eb)
                            {
                                //Erken başlangıca gfaaliyetin erken sonlanmasını ata
                                kod_eb = gfaaliyet_es;
                                dgw_CPM_sebeke_tablosu.Rows[i].Cells[2].Value = kod_eb;
                                //erken sonlanmaya , eb+faaliyet süresi ni ata
                                kod_es = kod_eb + kod_faalisure;
                                dgw_CPM_sebeke_tablosu.Rows[i].Cells[3].Value = kod_es;
                            } 
                        }
                    } 
                }
            }
        }

        //erken_baslangıc_sonlanma çalıştırıldıktan sonra çalışıtırlması gerekiyor
        public void gec_baslangic_sonlanma()
        {
            //CPM şebeke tablosunun satır sayısını bir kaç defa kullanacağımız için değişkene atayalım
            int CPM_tablo_satir_sayisi = dgw_CPM_sebeke_tablosu.RowCount - 1;

            //CPM tablosunda sonuncu faaliyeti bulmak için döngüye gidiriyoruz
            for (int i = 0; i < CPM_tablo_satir_sayisi; i++)
            {
                //Gösterdiği faaliyet ++SON ise erken başlangıç ve sonlanmayı geç başlangıç sonlanmalara ata
                if (dgw_CPM_sebeke_tablosu.Rows[i].Cells[1].Value.ToString()=="++SON++")
                {
                    //geç başlagınç değerine erken başlangıcı ata
                    dgw_CPM_sebeke_tablosu.Rows[i].Cells[4].Value = dgw_CPM_sebeke_tablosu.Rows[i].Cells[2].Value;
                    //geç sonlanma değerinie erken sonlanmayı ata
                    dgw_CPM_sebeke_tablosu.Rows[i].Cells[5].Value = dgw_CPM_sebeke_tablosu.Rows[i].Cells[3].Value;
                }
            }

            //Verileri almaya son düğümden başlayacağımız için son düğümü değişkene atadık
            

            //SON düğümün geç başlagıç ve sonlanma değerlerini yazdık şimdi geriye doğru diğerlerini yazacağız
            for (int i = CPM_tablo_satir_sayisi-2; i >= 1; i--)
            {
                string son_dugum_kodu = dgw_CPM_sebeke_tablosu.Rows[i + 1].Cells[0].Value.ToString();

                //tersen itibaren gösterilen faaliyet kodlarında arama yaparak aradağımız düğümün kodunu bulup
                //geç başlangıç ve sonlanma değerlerini yazacağız
                for (int k = CPM_tablo_satir_sayisi-1; k >= 0; k--)
                {
                    //tek hücrede 1 den fazla kod yazdığımız için onları ayırıyoruz
                    string gfaaliyet = dgw_CPM_sebeke_tablosu.Rows[k].Cells[1].Value.ToString();
                    string[] _split_faaliyet = gfaaliyet.Split('-');


                    for (int m = 0; m < _split_faaliyet.Count(); m++)
                    {
                        //son dugum kodumuz ile gösterdiği faaliyet eşleşti ise en küçük olan geç başlangıçı 
                        //son dugumumuzun  geç sonlanma değerine yazıyoruz
                        if (_split_faaliyet[m] == son_dugum_kodu)
                        {

                            int son_dugum_gec_baslangic =Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[i+1].Cells[4].Value);
                            int gfaaliyet_sure = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[6].Value);

                            //önceki düğümün geç başlangıç değerini gfaaliyetin geç sonlanmasına atamasını yaptık
                            //dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value = son_dugum_gec_baslangic;
                            int gfaaliyet_gec_sonlanma = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value);
                            //şimdi gfaaliyetin geç başlangıcını hesaplayalım ve tabloya yazalım
                           // dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value = gfaaliyet_gec_sonlanma - gfaaliyet_sure;
                            int gfaaliyet_gec_baslangic = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value);


                            //aralarından en küçük olan geç başlangıcı alacağız
                            if (son_dugum_gec_baslangic < gfaaliyet_gec_sonlanma)
                            {
                                //önceki düğümün geç başlangıç değerini gfaaliyetin geç sonlanmasına atamasını yaptık
                                dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value = son_dugum_gec_baslangic;
                                gfaaliyet_gec_sonlanma = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value);
                                //şimdi gfaaliyetin geç başlangıcını hesaplayalım ve tabloya yazalım
                                dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value = gfaaliyet_gec_sonlanma - gfaaliyet_sure;
                                gfaaliyet_gec_baslangic = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value);
                            }
                            else if (gfaaliyet_gec_sonlanma==0)
                            {
                                //önceki düğümün geç başlangıç değerini gfaaliyetin geç sonlanmasına atamasını yaptık
                                dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value = son_dugum_gec_baslangic;
                                gfaaliyet_gec_sonlanma = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value);
                                //şimdi gfaaliyetin geç başlangıcını hesaplayalım ve tabloya yazalım
                                dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value = gfaaliyet_gec_sonlanma - gfaaliyet_sure;
                                gfaaliyet_gec_baslangic = Convert.ToInt32(dgw_CPM_sebeke_tablosu.Rows[k].Cells[4].Value);
                            } 

                        }
                        //test amaçlı yazıldı
                        if (son_dugum_kodu == "B")
                        {

                            MessageBox.Show(dgw_CPM_sebeke_tablosu.Rows[k].Cells[5].Value.ToString() + "-" + dgw_CPM_sebeke_tablosu.Rows[i+1].Cells[4].Value);
                        }

                    }
                }
            }   
        }

        
    }
}
