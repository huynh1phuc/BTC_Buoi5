using System;
using System.Collections.Generic;

public static class Test8
{
    public static bool Run()
    {
        Console.WriteLine("===== BÀI 8 =====");

        if (!KiemTra(1, new double[] { 9, 7, 5, 4, 8.5, 6 }, TaoExpected(2, 1, 2, 1))) return false;

        if (!KiemTra(2, new double[] { }, TaoExpected(0, 0, 0, 0))) return false;

        if (!KiemTra(3, new double[] { 8, 6.5, 5, 4.99 }, TaoExpected(1, 1, 1, 1))) return false;

        if (!KiemTra(4, new double[] {10, 8, 7.99, 6.5, 6.49, 5, 4.99, 0}, TaoExpected(2, 2, 2, 2))) return false;

        if (!KiemTra(5, new double[] {8, 9, 10}, TaoExpected(3, 0, 0, 0))) return false;

        if (!KiemTra(6, new double[] {6.5, 7, 7.9}, TaoExpected(0, 3, 0, 0))) return false;

        if (!KiemTra(7, new double[] {5, 5.5, 6.49}, TaoExpected(0, 0, 3, 0))) return false;

        if (!KiemTra(8, new double[] {0, 1, 4.99}, TaoExpected(0, 0, 0, 3))) return false;

        Console.WriteLine("[PASS] Bài 8");
        Console.WriteLine();

        return true;
    }


    static Dictionary<string, int> TaoExpected(int gioi, int kha, int trungBinh, int yeu)
    {
        Dictionary<string, int> expected = new Dictionary<string, int>();

        expected.Add("Giỏi", gioi);
        expected.Add("Khá", kha);
        expected.Add("Trung bình", trungBinh);
        expected.Add("Yếu", yeu);

        return expected;
    }


    static bool KiemTra(int soTest, double[] diem, Dictionary<string, int> expected)
    {
        Dictionary<string, int> actual = BaiTap.ThongKeXepLoai(diem);

        if (TestHelper.DictionaryBangNhau(actual, expected))
        {
            Console.WriteLine("Test " + soTest + ": PASS");

            return true;
        }

        Console.WriteLine();
        Console.WriteLine("[FAIL] BÀI 8 - TEST " + soTest);

        Console.WriteLine("Xếp loại không đúng Expected.");

        return false;
    }
}