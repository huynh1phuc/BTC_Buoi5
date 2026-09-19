using System;

public static class Test2
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 2 =====");

        if (!KiemTra(
            1,
            new int[] { 3, 1, 4, 1, 5 },
            new int[] { 1, 1, 3, 4, 5 },
            new int[] { 5, 4, 3, 1, 1 }))
            return false;

        if (!KiemTra(
            2,
            new int[] { },
            new int[] { },
            new int[] { }))
            return false;

        if (!KiemTra(
            3,
            new int[] { 5 },
            new int[] { 5 },
            new int[] { 5 }))
            return false;

        if (!KiemTra(
            4,
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 4, 3, 2, 1 }))
            return false;

        if (!KiemTra(
            5,
            new int[] { 4, 3, 2, 1 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 4, 3, 2, 1 }))
            return false;

        if (!KiemTra(
            6,
            new int[] { -1, 5, 0, -3, 5 },
            new int[] { -3, -1, 0, 5, 5 },
            new int[] { 5, 5, 0, -1, -3 }))
            return false;

        if (!KiemTra(
            7,
            new int[] { 2, 2, 2 },
            new int[] { 2, 2, 2 },
            new int[] { 2, 2, 2 }))
            return false;

        Console.WriteLine("[PASS] Bài 2");
        Console.WriteLine();

        return true;
    }


    static bool KiemTra(
        int soTest,
        int[] nums,
        int[] expectedTang,
        int[] expectedGiam
    )
    {
        int[] mangGoc =
            new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            mangGoc[i] = nums[i];
        }

        (int[] tang, int[] giam) actual =
            BaiTap.SapXepHaiChieu(nums);

        bool dungTang =
            TestHelper.MangBangNhau(
                actual.tang,
                expectedTang
            );

        bool dungGiam =
            TestHelper.MangBangNhau(
                actual.giam,
                expectedGiam
            );

        bool mangGocKhongDoi =
            TestHelper.MangBangNhau(
                nums,
                mangGoc
            );

        if (
            dungTang
            && dungGiam
            && mangGocKhongDoi
        )
        {
            Console.WriteLine(
                "Test " + soTest + ": PASS"
            );

            return true;
        }

        Console.WriteLine();
        Console.WriteLine(
            "[FAIL] BÀI 2 - TEST " + soTest
        );

        Console.WriteLine(
            "Input = " + TestHelper.InMang(mangGoc)
        );

        Console.WriteLine(
            "Expected tăng = "
            + TestHelper.InMang(expectedTang)
        );

        Console.WriteLine(
            "Actual tăng   = "
            + TestHelper.InMang(actual.tang)
        );

        Console.WriteLine(
            "Expected giảm = "
            + TestHelper.InMang(expectedGiam)
        );

        Console.WriteLine(
            "Actual giảm   = "
            + TestHelper.InMang(actual.giam)
        );

        if (!mangGocKhongDoi)
        {
            Console.WriteLine(
                "Mảng gốc đã bị thay đổi."
            );
        }

        return false;
    }
}