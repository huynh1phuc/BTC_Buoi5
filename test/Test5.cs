using System;

public static class Test5
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 5 =====");

        if (!KiemTra(1, new int[] { 1, 2, 3 }, new int[] { 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })) return false;

        if (!KiemTra(2, new int[] { }, new int[] { }, new int[] { })) return false;

        if (!KiemTra(3, new int[] { 1, 2 }, new int[] { }, new int[] { 1, 2 })) return false;

        if (!KiemTra(4, new int[] { }, new int[] { 3, 4 }, new int[] { 3, 4 })) return false;

        if (!KiemTra(5, new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 1, 2, 3, 4 })) return false;

        if (!KiemTra(6, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })) return false;

        if (!KiemTra(7, new int[] { 3, 1, 3 }, new int[] { 2, 1, 4, 2 }, new int[] { 3, 1, 2, 4 })) return false;

        if (!KiemTra(8, new int[] { -1, 0 }, new int[] { 0, -2 }, new int[] { -1, 0, -2 })) return false;

        Console.WriteLine("[PASS] Bài 5");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(int soTest, int[] a, int[] b, int[] expected)
    {
        int[] actual = BaiTap.Hop(a, b);

        if (TestHelper.MangBangNhau(actual, expected))
        {
            Console.WriteLine("Test " + soTest + ": PASS");

            return true;
        }

        Console.WriteLine();
        Console.WriteLine("[FAIL] BÀI 5 - TEST " + soTest);

        Console.WriteLine("a = " + TestHelper.InMang(a));

        Console.WriteLine("b = " + TestHelper.InMang(b));

        Console.WriteLine("Expected = " + TestHelper.InMang(expected));

        Console.WriteLine("Actual   = " + TestHelper.InMang(actual));

        return false;
    }
}