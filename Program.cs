using System;


namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first num"); 
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second num");
            int secondNum = int.Parse(Console.ReadLine());

            int num, testNum, sum = 0;

            Console.WriteLine("The perfect numbers between the range {0} and {1}", firstNum, secondNum);



            if (firstNum > secondNum) //لو اليوزر دخل رقمين بحيث الاول اكبر من الثاني هنبدلهم 
            {

                int swap = firstNum;
                firstNum = secondNum;
                secondNum = swap;
            }
            
            for (num = firstNum; num <= secondNum; num++)
            {
                sum = 0;   //مجموع عوامل الرقم اللي بنختبره
                testNum = 1;      //بدانا تختبر بدايهً من رقم1 لان الرقم المثالي ليس له علاقه بالقسمة علي نفسه و علي الصفر
                for (testNum = 1; testNum < num; testNum++)// العامل اللى هنقسم عليه مينفعش يكون اكبر من او يساوي الرقم اللي بنختبره
                {
                    if (num % testNum == 0) // نختبر قابليه القسمة علي العامل فان كان يقبل القسمة فهو احد عوامل الرقم 
                        sum += testNum; //sumنجمع الارقام اللر تحقق الشرط (واللى تعتبر عوامل الرقم) ونخزنها في ال 

                }
                if (sum == num) //نختبر هل مجموع العوامل يساوي الرقم او لا بحيث لو تحقق الشرط فهو رقم مثالي 
                {
                    Console.WriteLine(num);
                }

            }

        }
    }
}
