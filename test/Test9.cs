using System;

public static class Test9
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 9 =====");

        if (!KiemTra(
            1,
            new int[] { 1, 2, 3, 1 },
            true))
            return false;

        if (!KiemTra(
            2,
            new int[] { 1, 2, 3, 4 },
            false))
            return false;

        if (!KiemTra(
            3,
            new int[] { 1 },
            false))
            return false;

        if (!KiemTra(
            4,
            new int[] { 5, 5 },
            true))
            return false;

        if (!KiemTra(
            5,
            new int[] { 1, 1, 1, 1 },
            true))
            return false;

        if (!KiemTra(
            6,
            new int[] { -1, 0, 2, -1 },
            true))
            return false;

        if (!KiemTra(
            7,
            new int[]
            {
                int.MinValue,
                0,
                int.MaxValue
            },
            false))
            return false;

        if (!KiemTra(
            8,
            new int[]
            {
                1, 2, 3, 4, 5,
                6, 7, 8, 9, 1
            },
            true))
            return false;

        Console.WriteLine("[PASS] Bài 9");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(
        int soTest,
        int[] nums,
        bool expected
    )
    {
        bool actual =
            BaiTap.ContainsDuplicate(nums);

        if (actual == expected)
        {
            Console.WriteLine(
                "Test " + soTest + ": PASS"
            );

            return true;
        }

        Console.WriteLine();
        Console.WriteLine(
            "[FAIL] BÀI 9 - TEST " + soTest
        );

        Console.WriteLine(
            "nums = " + TestHelper.InMang(nums)
        );

        Console.WriteLine(
            "Expected = " + expected
        );

        Console.WriteLine(
            "Actual   = " + actual
        );

        return false;
    }
}