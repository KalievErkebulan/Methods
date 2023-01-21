// 1 Method
// void Method1()
// {
//     Console.WriteLine("Автор Калиев Е.");
// }
// Method1();



// 2 Method

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg:"Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
    
//     while(i < count)
//     {   
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Текст",4);
// // Method21(msg:"Текст", count:4);
// Method21(count: 4, msg:"новый текст");



// 3 Method
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// 4 Method
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}