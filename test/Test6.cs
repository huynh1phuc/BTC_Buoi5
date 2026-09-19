using System;

public static class Test6
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 6 =====");

        if (!KiemTra(1, new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 3, 4 })) return false;

        if (!KiemTra(2, new int[] { }, new int[] { }, new int[] { })) return false;

        if (!KiemTra(3, new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { })) return false;

        if (!KiemTra(4, new int[] { 1, 1, 2, 2, 3 }, new int[] { 1, 2 }, new int[] { 1, 2 })) return false;

        if (!KiemTra(5, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })) return false;

        if (!KiemTra(6, new int[] { -1, 0, 2 }, new int[] { -1, 3, 0 }, new int[] { -1, 0 })) return false;

        if (!KiemTra(7, new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })) return false;

        Console.WriteLine("[PASS] Bài 6");
        Console.WriteLine();

        return true;
    }

    static bool KiemTra(int soTest, int[] a, int[] b, int[] expected)
    {
        int[] actual = BaiTap.Giao(a, b);

        if (TestHelper.CungTapGiaTri(actual, expected))
        {
            Console.WriteLine("Test " + soTest + ": PASS");

            return true;
        }

        Console.WriteLine();
        Console.WriteLine("[FAIL] BÀI 6 - TEST " + soTest);

        Console.WriteLine("a = " + TestHelper.InMang(a));

        Console.WriteLine("b = " + TestHelper.InMang(b));

        Console.WriteLine("Expected values = " + TestHelper.InMang(expected));

        Console.WriteLine("Actual = " + TestHelper.InMang(actual));

        return false;
    }
}