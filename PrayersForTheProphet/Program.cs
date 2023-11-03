using System;

namespace PrayersForTheProphet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // لدعم النص باللغة العربية

            Console.ForegroundColor = ConsoleColor.Green; // تعيين لون النص الأخضر

            string textToPrint = "إِنَّ اللَّهَ وَمَلَائِكَتَهُ يُصَلُّونَ عَلَى النَّبِيِّ ۚ يَا أَيُّهَا الَّذِينَ آمَنُوا صَلُّوا عَلَيْهِ وَسَلِّمُوا تَسْلِيمًا";

            string[] words = textToPrint.Split(' '); // تقسيم النص إلى كلمات

            foreach (string word in words)
            {
                Console.WriteLine(word);
                Console.ReadKey(); // انتظار الضغط على مفتاح قبل طباعة الكلمة التالية
            }

            // العودة إلى لون النص الافتراضي
            Console.ResetColor();
        }
    }
}
