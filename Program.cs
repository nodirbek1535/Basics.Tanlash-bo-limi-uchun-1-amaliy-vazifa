using System;
//1-masala vaqt kalkulatori
// 1. Vaqt kalkulyatori:
// Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur yozing. Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak. Hisoblash uchun arifmetik amallardan foydalaning.
Console.WriteLine("iltimos daqiqani kiriting");
int daqiqa=int.Parse(Console.ReadLine());
int soat,minut;
soat=daqiqa/60;
minut=daqiqa%60;
Console.WriteLine($"{soat}:{minut}");
Console.WriteLine("1--dastur yakunlandi");
//2-masala yosh toifasini tanlash
//2. Yosh toifasini aniqlash:
//Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating: "bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh) va undan katta). Bu vazifa uchun if-else iboralaridan foydalaning. 
int yosh;
string str;
Console.WriteLine("yoshingizni kiriting:");
yosh=int.Parse(Console.ReadLine());
if(yosh>=0 && yosh<=12)
{
    str="bola";
}
else if(yosh>12 && yosh<20)
{
    str="o'smir";
}
else if(yosh>19 && yosh<60)
{
    str="kattalar";
}
else if(yosh>59)
{
    str="katta";
}
else
{
    str="yosh manfiy bolmaydi";
}
Console.WriteLine(str);
Console.WriteLine("2--dastur yakunlandi");
//3-masala 3. O'rtacha ballni hisoblash:
//3. O'rtacha ballni hisoblash:
//Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va ularning o'rtacha ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi: "A'lo" (o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha), "Qoniqarli" (o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam). Shartlarni tekshirish uchun ternary operatoridan foydalaning. 
Console.WriteLine("1-fanning ballini kiriting:");
double a1=double.Parse(Console.ReadLine());
Console.WriteLine("2-fanning ballini kiriting:");
double a2=double.Parse(Console.ReadLine());
Console.WriteLine("3-fanning ballini kiriting:");
double a3=double.Parse(Console.ReadLine());
double ortacha=(a1+a2+a3)/3.0;
string s;
s = (ortacha <= 100 && ortacha >= 80) ? "A'lo" :
    (ortacha < 80 && ortacha >= 60) ? "Yaxshi" :
    (ortacha < 60 && ortacha >= 40) ? "Qoniqarli" :
    "Qoniqarsiz";
    Console.WriteLine(s);
    Console.WriteLine("3--dastur yakunlandi");
    //4-dastur sonni topish
    //4. "Raqamni toping" o'yini:
//1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va keyin foydalanuvchidan bu raqamni taxmin qilishni so'raydi. Dastur sirli raqam foydalanuvchi kiritgan raqamdan katta yoki kichik ekanligi haqida maslahatlar berishi kerak. Ternary operatoridan va Random dan foydalaning
Random random=new Random();
int ran=random.Next(1,100);
int oyin=-1;
while(oyin!=ran)
{
Console.WriteLine("sonni topishga harakat qiling:");
oyin=int.Parse(Console.ReadLine());
if(oyin<ran)
{
    Console.WriteLine("siz oylagan son topishingiz kerak bolgan sondan kichik yuqoriroq son tanlang");
}
else if(oyin>ran)
{
      Console.WriteLine("siz oylagan son topishingiz kerak bolgan sondan katta kichikroq son tanlang");
}
}
Console.WriteLine("tabriklayman siz yutdingiz :)");

