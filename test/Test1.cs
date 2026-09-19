using System;

public static class Test1
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 1 =====");

        if (!KiemTra(1, new int[] { 20, 81, 97, 63, 72, 11 }, 50, 313)) return false;

        if (!KiemTra(2, new int[] { }, 50, 0)) return false;

        if (!KiemTra(3, new int[] { 51 }, 50, 51)) return false;

        if (!KiemTra(4, new int[] { 50 }, 50, 0)) return false;

        if (!KiemTra(5, new int[] { 60, 70, 80 }, 50, 210)) return false;

        if (!KiemTra(6, new int[] { 10, 20, 30, 50 }, 50, 0)) return false;

        if (!KiemTra(7, new int[] { -10, -4, -3 }, -5, -7)) return false;

        if (!KiemTra(8, new int[] { 2147483647, 2147483647 }, 0, 4294967294)) return false;

        Console.WriteLine("[PASS] Bài 1");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(int soTest, int[] nums, int moc, long expected)
    {
        long actual = BaiTap.TongLonHon(nums, moc);

        if (actual == expected)
        {
            Console.WriteLine("Test " + soTest + ": PASS");
            return true;
        }

        Console.WriteLine();
        Console.WriteLine("[FAIL] BÀI 1 - TEST " + soTest);

        Console.WriteLine("nums = " + TestHelper.InMang(nums));

        Console.WriteLine("moc = " + moc);
        Console.WriteLine("Expected = " + expected);
        Console.WriteLine("Actual   = " + actual);

        return false;
    }
}