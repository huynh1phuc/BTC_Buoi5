using System;

/*
    Liên kết project: dotnet add test\testcase.csproj reference BaiTapChinh_B5\BaiTapChinh_B5.csproj
    Chạy 1 bài dotnet run --project testcase -- 1
    Chạy hết: dotnet run --project testcase -- all
*/

string choice = args[0];

bool ketQua = true;

switch (choice)
{
    case "1":
        ketQua = Test1.Run();
        break;

    case "2":
        ketQua = Test2.Run();
        break;

    case "3":
        ketQua = Test3.Run();
        break;

    case "4":
        ketQua = Test4.Run();
        break;

    case "5":
        ketQua = Test5.Run();
        break;

    case "6":
        ketQua = Test6.Run();
        break;

    case "7":
        ketQua = Test7.Run();
        break;

    case "8":
        ketQua = Test8.Run();
        break;

    case "9":
        ketQua = Test9.Run();
        break;

    case "10":
        ketQua = Test10.Run();
        break;

    case "all":

        if (!Test1.Run()) return;
        if (!Test2.Run()) return;
        if (!Test3.Run()) return;
        if (!Test4.Run()) return;
        if (!Test5.Run()) return;
        if (!Test6.Run()) return;
        if (!Test7.Run()) return;
        if (!Test8.Run()) return;
        if (!Test9.Run()) return;
        if (!Test10.Run()) return;

        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine("       ALL TESTS PASSED");
        Console.WriteLine("==============================");

        return;

    default:
        Console.WriteLine("Không tìm thấy bài test.");
        return;
}

if (ketQua)
{
    Console.WriteLine();
    Console.WriteLine("TẤT CẢ TESTCASE CỦA BÀI ĐỀU PASS.");
}