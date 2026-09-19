using System;

public static class Test10
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 10 =====");

        if (!KiemTra(
            1,
            new int[] { 1, 1, 1 },
            2,
            2))
            return false;

        if (!KiemTra(
            2,
            new int[] { 1, 2, 3 },
            3,
            2))
            return false;

        if (!KiemTra(
            3,
            new int[] { 1 },
            1,
            1))
            return false;

        if (!KiemTra(
            4,
            new int[] { 1 },
            0,
            0))
            return false;

        if (!KiemTra(
            5,
            new int[] { 0 },
            0,
            1))
            return false;

        if (!KiemTra(
            6,
            new int[] { 0, 0, 0 },
            0,
            6))
            return false;

        if (!KiemTra(
            7,
            new int[] { 1, -1, 0 },
            0,
            3))
            return false;

        if (!KiemTra(
            8,
            new int[] { -1, -1, 1 },
            0,
            1))
            return false;

        if (!KiemTra(
            9,
            new int[]
            {
                3, 4, 7, 2,
                -3, 1, 4, 2
            },
            7,
            4))
            return false;

        Console.WriteLine("[PASS] Bài 10");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(
        int soTest,
        int[] nums,
        int k,
        int expected
    )
    {
        int actual =
            BaiTap.SubarraySum(nums, k);

        if (actual == expected)
        {
            Console.WriteLine(
                "Test " + soTest + ": PASS"
            );

            return true;
        }

        Console.WriteLine();
        Console.WriteLine(
            "[FAIL] BÀI 10 - TEST " + soTest
        );

        Console.WriteLine(
            "nums = " + TestHelper.InMang(nums)
        );

        Console.WriteLine("k = " + k);

        Console.WriteLine(
            "Expected = " + expected
        );

        Console.WriteLine(
            "Actual   = " + actual
        );

        return false;
    }
}