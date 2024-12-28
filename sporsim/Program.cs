using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

int secim;
Random random = new Random(); //Aletlerin dolu olup olmaması için
int enerji = 100; // Enerji sistemi için 


while (true)
{

    Console.Clear();
    Console.WriteLine("-----------Spor Salonuna Hoşgeldin!-----------");
    Console.WriteLine("Bugün nasıl bir antreman yapmak istersin?");
    Console.WriteLine("Büyük kas grupları 15, küçük kas grupları 5 enerji harcar. ");
    Console.WriteLine("1- İtiş");
    Console.WriteLine("2- Çekiş");
    Console.WriteLine("3- Bacak");
    Console.WriteLine("4- Kardiyo");
    Console.WriteLine("!Uyarı!: Kardiyoyu idman sonunda yapman en mantıklısı olacaktır. Geriye kalan bütün enerjini orada harcayacaksın!");
    secim = Convert.ToInt32(Console.ReadLine());
    // Ana menü

    

        if (secim == 1)
        {

            while (true) // While döngüsü sayesinde her hareket bitişinden sonra  ana menü yerine seçilen menünye dönülür.
            {

                Console.Clear();

                Console.WriteLine("Bu hareketler sayesinde ideal bir göğüse,geniş omuzlara ve büyük bir kola sahip olabilirsin!");
                Console.WriteLine("Şimdi hareketini seç ve idmana başla!");
                Console.WriteLine("Tavsiyem düz bench/dumbell press ile başlayıp diğer göğüs varyasyonlarına gitmendir!");
                Console.WriteLine($"****Enerjin****: {enerji}");// Enerji göstergesi


                Console.WriteLine("----Göğüs----");
                Console.WriteLine("1-Bench press");
                Console.WriteLine("2-İncline bench press");
                Console.WriteLine("3-Chest fly");
                Console.WriteLine("4-Dumbell Press");
                Console.WriteLine("5-İncline dumbell press");
                Console.WriteLine("----Omuz----");
                Console.WriteLine("6-Lateral raise");
                Console.WriteLine("7-Overhead press");
                Console.WriteLine("----Arka Kol(triceps)----");
                Console.WriteLine("8-Triceps pushdown");
                Console.WriteLine("9-Dips");
                Console.WriteLine("10-Ana menüye dön");


                int itsec = 0;                      // menü seçim işlemleri
                itsec = Convert.ToInt32(Console.ReadLine()); // İtsec 1'deki bütün işlemler/açıklamalar geriye kalan hareketler içinde geçerlidir.
                if (itsec == 10)
                {
                    Console.WriteLine("Ana menüye dönülüyor");
                    Thread.Sleep(1000);
                    break;
                }
                if (itsec == 1)
                {

                    int benchkont = random.Next(0, 2); //0 boş 2 dolu. Hareketin dolu olup olmadığını belirler
                    if (benchkont == 1)
                    {
                        Console.WriteLine("Dolu! Başka hareket yap!");
                        Thread.Sleep(1500); // bekleme süresi.

                    }
                    else
                    {
                        Console.Clear(); // Yapılan seçimden sonra konsolu temizler.
                        Console.WriteLine("Bench press yapılıyor!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Bench press yaptın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15; // Bu hareket için eksilen enerji
                        Console.WriteLine("15 enerji kaybettin!");
                    }


                }
                if (itsec == 2)
                {
                    int inckont = random.Next(0, 2);//0 boş 2 dolu
                    if (inckont == 2)
                    {
                        Console.WriteLine("Dolu! Başka hareket yap!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("İncline Yapılıyor! İyi gidiyorsun!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla İncline'ı tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }

                }

                if (itsec == 3)
                {
                    int flykont = random.Next(0, 2);//0 bos 2 dolu
                    if (flykont == 2)
                    {
                        Console.WriteLine("Dolu! Başka hareket yap!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fly yapılıyor! Kollarını doğru şekilde aç ve yavaşça hissederek hareketi tamamla!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Fly'ı tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }



                }
                if (itsec == 4)
                {
                    int dumbkont = random.Next(0, 2);//0 bos 2 dolu
                    if (dumbkont == 2)
                    {
                        Console.WriteLine("Dolu! Başka hareket yap!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Dumbell press yapılıyor! Serbest ağırlık kullanıyorsun. Dengeye önem vererek ağırlıkları kaldır!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Dumbell Press yaptın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }



                }
                if (itsec == 5)
                {
                    int dumbinckont = random.Next(0, 2);
                    if (dumbinckont == 2)
                    {
                        Console.WriteLine("Dolu! Başka harekete!!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("İncline Dumbell Press yapılıyor! Serbest ağırlık kullanıyorsun. Dengeye önem vererek hareketini tamamla!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla İnc Dumbell Press'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }


                    if (itsec == 6)
                    {
                        int latkont = random.Next(0, 2);
                        if (latkont == 2)
                        {
                            Console.WriteLine("Dolu! Başka harekete!");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Lateral Raise yapılıyor! Kollarını düz tutarak açabildiğin kadar yanlara aç!!");
                            Thread.Sleep(1000);
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.WriteLine("Başarıyla Lateral Raise'i tamamladın! Başka hareketlere!");
                            Thread.Sleep(1500);
                            enerji -= 5;
                            Console.WriteLine("5 enerji kaybettin");
                        }
                    }
                }
                if (itsec == 6)
                {
                    int latkont = random.Next(0, 2);
                    if (latkont == 2)
                    {
                        Console.WriteLine("Dolu! Dumbell gelene kadar bekle.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lateral raise yapılıyor! Tüm spor alemindeki tartışmasız en iyi omuz hareketini yapıyorsun! Omuzların bowling topuna dönmeye başladı bile!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Lateral Raise yaptın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 10;
                        Console.WriteLine("10 enerji kaybettin!");
                    }
                }
                if (itsec == 7)
                {
                    int ovrkont = random.Next(0, 2);
                    if (ovrkont == 2)
                    {
                        Console.WriteLine("Dolu! Başka harekete!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Overhead Press yapılıyor! Serbest ağırlık kullanıyorsun. Omuzuna dikkat ederek kaldır!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Overhead Press'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 5;
                        Console.WriteLine("5 enerji kaybettin!");

                    }
                }
                if (itsec == 8)
                {
                    int trikont = random.Next(0, 2);
                    if (trikont == 2)
                    {
                        Console.WriteLine("Dolu! Başka harekete!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Triceps pushdown yapılıyor! Kollarını indirdiğinde 1 saniye beklet! Set sonunda kollarının yandığını hissedeceksin!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Triceps pushdown'u tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 5;
                        Console.WriteLine("5 enerji kaybettin!");
                    }
                }
                if (itsec == 9)
                {
                    int dipkont = random.Next(0, 2);
                    if (dipkont == 2)
                    {
                        Console.WriteLine("Dolu! Başka harekete!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Dips yapılıyor! Kendi ağırlığını kullanarak bu hareketi yapıyorsun! Çok iyi bir arka kol hareketi olmasına rağmen göğüsede çok iyi vurur!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Dips'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 5;
                        Console.WriteLine("5 enerji kaybettin!");
                    }
                }



            }
        }// İtiş hareketleri 
        if (secim == 2)
        {

            while (true)
            {


                Console.Clear();
                Console.WriteLine("Bu hareketler sayesinde geniş ve büyük bir sırt ve şişkin bir biceps'e sahip olabilirsin!");
                Console.WriteLine("Şimdi hareketini seç ve idmanına başla");
                Console.WriteLine("Büyük kas gruplarından başlaman idmanın için daha yararlı olur!");
                Console.WriteLine($"****Enerjin****: {enerji}");

                Console.WriteLine("----Sırt----");
                Console.WriteLine("1-Barfiks");
                Console.WriteLine("2-Barbell row");
                Console.WriteLine("3-Lat pulldown");
                Console.WriteLine("----Ön kol(biceps)----");
                Console.WriteLine("4-Chin up");
                Console.WriteLine("5-Barbell curl");
                Console.WriteLine("6-Hammer curl");
                Console.WriteLine("7-Ana menü");

                int ceksec = 0;
                ceksec = Convert.ToInt32(Console.ReadLine());
                if (ceksec == 7)
                {
                    Console.WriteLine("Ana menüye dönülüyor");
                    Thread.Sleep(1000);
                    break;
                }
                if (ceksec == 1)
                {
                    int barkont = random.Next(0, 2);
                    if (barkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Barfiks çekiliyor! İlk başta çok zor bir hareket olmasına rağmen alışınca en fazla verim alabileceğin bir sırt hareketi yapıyorsun!!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla barfiks çektin! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");

                    }
                }
                if (ceksec == 2)
                {
                    int rowkont = random.Next(0, 2);
                    if (rowkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete!");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Barbell row yaplıyor! PT'ne göre 3 temel hareketten birisini yapıyorsun. Row'suz ne büyür ne de güçlenirsin! Beline dikkat ederek pozisyonunu koruyarak tamamla! ");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Barbell row yapıldı! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }
                }
                if (ceksec == 3)
                {
                    int latkont = random.Next(0, 2);
                    if (latkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lat pulldown yapılıyor! Barfiksin ağırlıkla yapılan hali. Ağırlığı kendine çekerken birazcık geriye eğil, daha fazla verim alacaksın!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Lat pulldown'u tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }
                }
                if (ceksec == 4)
                {
                    int chinkont = random.Next(0, 2);
                    if (chinkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Chin up çekiliyor! Sırt hareketi olmasına rağmen mükemmel bir şekilde biceps'ini güçlendirir ,ayrıca normal barfikse alışmanı sağlar !!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Chin up çektin! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 10;
                        Console.WriteLine("10 enerji kaybettin!");
                    }
                }
                if (ceksec == 5)
                {
                    int curl1kont = random.Next(0, 2);
                    if (curl1kont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Barbell curl yapılıyor! Standart biceps geliştirme hareketi. Set sonlarına doğru yavaşça yapmaya özen göster!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Barbell curl'ü tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 5;
                        Console.WriteLine("5 enerji kaybettin!");
                    }
                }
                if (ceksec == 6)
                {
                    int curl2kont = random.Next(0, 2);
                    if (curl2kont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hammer Curl yapılıyor! Bu hareket biceps'inin içindeki iç kol dediğimiz yere vurur ve genel olarak kolunu şekillendirir!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Hammer curl'ü tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 5;
                        Console.WriteLine("5 enerji kaybettin!");
                    }
                }
            }

        }// Çekiş    "
        if (secim == 3)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bu hareketler sayesinde güçlü ve çevik bacakara sahip olabilirsin");
                Console.WriteLine("Şimdi hareketini seç ve idmana başla!");
                Console.WriteLine($"****Enerjin****: {enerji}");

                Console.WriteLine("----Üst Bacak----");
                Console.WriteLine("1-Squad");
                Console.WriteLine("2-Leg press");
                Console.WriteLine("----Alt/Arka Bacak----");
                Console.WriteLine("3-Lying leg curl");
                Console.WriteLine("4-Romanian deadlift");
                Console.WriteLine("5-Calf raises");
                Console.WriteLine("6-Ana menü");

                int legsec = 0;
                legsec = Convert.ToInt32(Console.ReadLine());
                if (legsec == 6)
                {
                    Console.WriteLine("Ana menüye dönülüyor");
                    Thread.Sleep(1000);
                    break;
                }
                if (legsec == 1)
                {
                    int sqtkont = random.Next(0, 2);
                    if (sqtkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Squat yapılıyor! Vücudundaki en büyük kas grubunu çalıştırıyorsun. Beline dikkat ederek en aşağı in ve yüksel.");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Squat'ı tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }
                }
                if (legsec == 2)
                {
                    int legprs = random.Next(0, 2);
                    if (legprs == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Leg press yapılıyor! Squatın serbest ağırlıklı olmayan ve daha fazla ağırlık kaldırabileceğin hareketi desek yeridir. Ama sen yine de çok abartma");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Leg press'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }
                }
                if (legsec == 3)
                {
                    int lykont = random.Next(0, 2);
                    if (lykont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lying leg press yapılyor! Arka bacağını çalıştırıyorsun. İyi gidiyorsun");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Lying leg press'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");

                    }
                }
                if (legsec == 4)
                {
                    int romkont = random.Next(0, 2);
                    if (romkont == 0)
                    {
                        Console.WriteLine("Dolu! Başka harekete.");
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Romanian deadlift yapılıyor! Deadlift'in başka bir varyantını yapıyorsun. Beline dikkat et. Ayrıca ayağının altına bir plaka koyarak daha da iyi verim alabilirsin!");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine("Başarıyla Romanian deadlift'i tamamladın! Başka hareketlere!");
                        Thread.Sleep(1500);
                        enerji -= 15;
                        Console.WriteLine("15 enerji kaybettin!");
                    }
                }
                if (legsec == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Calf raises yapılıyor! Kendi veya serbest ağırlıkla calf çalışıyorsun. Oldukça kolay bir hareket, değil mi :)");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.WriteLine("Başarıyla Calf raises yaptın! Başka hareketlere!");
                    Thread.Sleep(1500);
                    enerji -= 10;
                    Console.WriteLine("10 enerji kaybettin!");

                }
            }
        }// Bacak    "
        if (secim == 4)
         {
        while (true)
        {
            Console.Clear(); // Kardiyo kısmı, diğerlerinden farklıdır. Yapılan her hareket enerjiyi tamamen bitirir.
            Console.WriteLine("Kardiyo her idman sonrası kişinin hedefine göre yapılmalıdır. Kilo verdirmenin yanı sıra kalp sağlığı ve benzeri konularda da çok fazla faydası vardır.");
            Console.WriteLine("Şimdi hareketini seç ve idmanına başla!");
            Console.WriteLine($"****Enerjin****: {enerji}");

            Console.WriteLine("----Kardiyo----");
            Console.WriteLine("1-Koşu bandı");
            Console.WriteLine("2-İp atlama");
            Console.WriteLine("3-Merdiven çıkma");
            Console.WriteLine("4-Bisiklet");
            Console.WriteLine("5-Ana menü");
            Console.WriteLine("Her hareket kalan enerjini sonuna kadar bitirir. Gerçek kardiyo dediğin budur!");
            int cardsec = 0;
            cardsec = Convert.ToInt32(Console.ReadLine());

            if (cardsec == 5)
            {
                Console.WriteLine("Ana menüye dönülüyor");
                Thread.Sleep(1000);
                break;
            }
            if (cardsec == 1)
            {
                Console.Clear();
                Console.WriteLine("Koşuluyor!!!");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("Başarıyla bacakların tutmayana koştun! ");
                Thread.Sleep(1500);
                enerji -= enerji; // kalan enerjinin tamamını siler
                Console.WriteLine("Tüm enerjini kaybettin!!");
                Console.WriteLine("Ellerine ve ayaklarına sağlık! İyi günler diliyorum. Dinlenmeyi asla unutma!!!");
                Thread.Sleep(5000);
                break; //  İdman bittiği için ana menüye döndürür. Geri kalan kardiyo hareketlerinin hepsinde geçerlidir.
            }
            if (cardsec == 2)
            {
                Console.Clear();
                Console.WriteLine("İp atlanıyor! Harika bir kardiyo hareketi olmasına rağmen aynı zamanda el ayak koordinasyonunu da geliştirir!");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("Başarıyla tüm vücudun ağrıyana kadar ip atladın!! ");
                Thread.Sleep(1500);
                enerji -= enerji;
                Console.WriteLine("Tüm enerjini kaybettin!!");
                Console.WriteLine("Ellerine ve ayaklarına sağlık! İyi günler diliyorum. Dinlenmeyi asla unutma!!!");
                Thread.Sleep(5000);
                break;
            }
            if (cardsec == 3)
            {
                Console.Clear();
                Console.WriteLine("Merdiven çıkılıyor! Bu hareket müthiş bir kardiyo idmanının yanı sıra patlayıcılık ve bacak kuvveti de kazandırır!");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("Başarıyla Merdiven çıktın! Bacaklarına dikkat et ;)))   ");
                Thread.Sleep(1500);
                enerji -= enerji;
                Console.WriteLine("Tüm enerjini kaybettin!!");
                Console.WriteLine("Ellerine ve ayaklarına sağlık! İyi günler diliyorum. Dinlenmeyi asla unutma!!!");
                Thread.Sleep(5000);
                break;
            }
            if (cardsec == 4)
            {
                Console.Clear();
                Console.WriteLine("Bisiklet sürülüyor! İdeal bir kardiyo olmasına rağmen diğerlerine göre daha az yorulursun. Dışarıda da sürmeni tavisye ederim!");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("Başarıyla tüm enerjin bitene kadar bisiklet sürdün! ");
                Thread.Sleep(1500);
                enerji -= enerji;
                Console.WriteLine("Tüm enerjini kaybettin!!");
                Console.WriteLine("Ellerine ve ayaklarına sağlık! İyi günler diliyorum. Dinlenmeyi asla unutma!!!");
                Thread.Sleep(5000);
                break;
            }


        }
         }// Kardiyo  "


}








