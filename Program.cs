object suan_tarih=DateTime.Now;
object tarih=DateTime.Now.Date;
object gün=DateTime.Now.Day;
object ay=DateTime.Now.Month;
object yil=DateTime.Now.Year;
object saat= DateTime.Now.Hour;

object haftagünü = DateTime.Now.DayOfWeek;
object kaçıncıyılgünü = DateTime.Now.DayOfYear;

object uzunyil= DateTime.Now.ToLongDateString;
object kısayil=DateTime.Now.ToShortDateString;

object uzunsaat=DateTime.Now.ToLongTimeString;
object kısasaat= DateTime.Now.ToShortTimeString;

object gunekle= DateTime.Now.AddDays(2);

object günsayi = DateTime.Now.ToString("dd");
object gün3harf = DateTime.Now.ToString("ddd");
object aysayi = DateTime.Now.ToString("MM");
object ay3harf = DateTime.Now.ToString("MMM");
object yıl2sayi = DateTime.Now.ToString("yy");
object yıl3sayi = DateTime.Now.ToString("yyyy");

Console.WriteLine(Math.Abs(-13)); //mutlak
Console.WriteLine(Math.Ceiling(22.2)); //23
Console.WriteLine(Math.Round(22.2)); //22
Console.WriteLine(Math.Round(22.7)); //23
Console.WriteLine(Math.Floor(22.2)); //22

Console.WriteLine(Math.Pow(3,4)); //3üzeri4
Console.WriteLine(Math.Sqrt(81)); //kök 81
Console.WriteLine(Math.Log(9)); //9un e tabanındaki karşılığı
Console.WriteLine(Math.Log10(9)); //9un 10 tabanındaki karşılığı
Console.WriteLine(Math.Exp(9)); // e üzeri 9

