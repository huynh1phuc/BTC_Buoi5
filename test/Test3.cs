using System;

public static class Test3
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 3 =====");

        if (!KiemTra(
            1,
            new int[] { 1, 2, 2, 3, 3, 3, 1 },
            new int[] { 1, 2, 3 }))
            return false;

        if (!KiemTra(
            2,
            new int[] { },
            new int[] { }))
            return false;

        if (!KiemTra(
            3,
            new int[] { 5 },
            new int[] { 5 }))
            return false;

        if (!KiemTra(
            4,
            new int[] { 2, 2, 2, 2 },
            new int[] { 2 }))
            return false;

        if (!KiemTra(
            5,
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 2, 3, 4 }))
            return false;

        if (!KiemTra(
            6,
            new int[] { 3, 1, 3, 2, 1, 4 },
            new int[] { 3, 1, 2, 4 }))
            return false;

        if (!KiemTra(
            7,
            new int[] { -1, -1, 0, -2, 0 },
            new int[] { -1, 0, -2 }))
            return false;

        Console.WriteLine("[PASS] Bài 3");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(
        int soTest,
        int[] nums,
        int[] expected
    )
    {
        int[] actual =
            BaiTap.LoaiTrung(nums);

        if (
            TestHelper.MangBangNhau(
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
            "[FAIL] BÀI 3 - TEST " + soTest
        );

        Console.WriteLine(
            "Input    = "
            + TestHelper.InMang(nums)
        );

        Console.WriteLine(
            "Expected = "
            + TestHelper.InMang(expected)
        );

        Console.WriteLine(
            "Actual   = "
            + TestHelper.InMang(actual)
        );

        return false;
    }
}