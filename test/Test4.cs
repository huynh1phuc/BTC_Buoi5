using System;
using System.Collections.Generic;

public static class Test4
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 4 =====");

        if (!KiemTra(
            1,
            new int[] { 20, 15, 20, 33, 15, 20 },
            new Dictionary<int, int>
            {
                { 20, 3 },
                { 15, 2 },
                { 33, 1 }
            }))
            return false;

        if (!KiemTra(
            2,
            new int[] { },
            new Dictionary<int, int>()))
            return false;

        if (!KiemTra(
            3,
            new int[] { 5 },
            new Dictionary<int, int>
            {
                { 5, 1 }
            }))
            return false;

        if (!KiemTra(
            4,
            new int[] { 2, 2, 2, 2 },
            new Dictionary<int, int>
            {
                { 2, 4 }
            }))
            return false;

        if (!KiemTra(
            5,
            new int[] { 1, 2, 3, 4 },
            new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 1 },
                { 3, 1 },
                { 4, 1 }
            }))
            return false;

        if (!KiemTra(
            6,
            new int[] { -1, 0, -1, 0, -2 },
            new Dictionary<int, int>
            {
                { -1, 2 },
                { 0, 2 },
                { -2, 1 }
            }))
            return false;

        Console.WriteLine("[PASS] Bài 4");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(
        int soTest,
        int[] nums,
        Dictionary<int, int> expected
    )
    {
        Dictionary<int, int> actual =
            BaiTap.DemTanSuat(nums);

        if (
            TestHelper.DictionaryBangNhau(
                actual,
                expected
            )
        )
        {
            Console.WriteLine(
                "Test " + soTest + ": PASS"
            );

            return true;
        }

        Console.WriteLine();
        Console.WriteLine(
            "[FAIL] BÀI 4 - TEST " + soTest
        );

        Console.WriteLine(
            "Input = " + TestHelper.InMang(nums)
        );

        Console.WriteLine(
            "Dictionary không đúng Expected."
        );

        return false;
    }
}