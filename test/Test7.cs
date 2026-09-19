using System;

public static class Test7
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 7 =====");

        if (!KiemTra(1, new int[] { 20, 97, 81, 97, 63 },81)) return false;
 
        if (!KiemTra(2, new int[] { },int.MinValue)) return false;
 
        if (!KiemTra(3, new int[] { 5 },int.MinValue)) return false;
 
        if (!KiemTra(4, new int[] { 5, 5, 5 },int.MinValue)) return false;
 
        if (!KiemTra(5, new int[] { 1, 2 },1)) return false;
 
        if (!KiemTra(6, new int[] { -10, -3, -5 },-5)) return false;
 
        if (!KiemTra(7, new int[] { 100, 50, 100, 20 },50)) return false;
 
        if (!KiemTra(8, new int[] { int.MinValue, 0 },int.MinValue)) return false;

        Console.WriteLine("[PASS] Bài 7");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(int soTest, int[] nums, int expected)
    {
        int actual = BaiTap.LonThuHai(nums);

        if (actual == expected)
        {
            Console.WriteLine("Test " + soTest + ": PASS");

            return true;
        }

        Console.WriteLine();
        Console.WriteLine("[FAIL] BÀI 7 - TEST " + soTest);
        Console.WriteLine("nums = " + TestHelper.InMang(nums));
        Console.WriteLine("Expected = " + expected);
        Console.WriteLine("Actual   = " + actual);

        return false;
    }
}