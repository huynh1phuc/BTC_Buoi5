using System;
using System.Collections.Generic;
#region Giao diện
while (true)
{
    Console.WriteLine("Chọn bài muốn thực hiện (1 - 10), gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát:");
    string choice = Console.ReadLine();
    switch(choice)
    {
        case "1": Bai1(); break;
        case "2": Bai2(); break;
        case "3": Bai3(); break;
        case "4": Bai4(); break;
        case "5": Bai5(); break;
        case "6": Bai6(); break;
        case "7": Bai7(); break;
        case "8": Bai8(); break;
        case "9": Bai9(); break;
        case "10": Bai10(); break;
        case "all":
            for(int i = 1; i <= 10; i++)
            {
                switch (i)
                {
                    case 1: Bai1(); break;
                    case 2: Bai2(); break;
                    case 3: Bai3(); break;
                    case 4: Bai4(); break;
                    case 5: Bai5();break;
                    case 6: Bai6(); break;
                    case 7: Bai7(); break;
                    case 8: Bai8(); break;
                    case 9: Bai9(); break;
                    case 10: Bai10(); break;
                }
                Console.WriteLine();
            }
            break;
        case "exit":
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 10 hoặc gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát.");
            break;
    }
}
#endregion

#region Hàm hỗ trợ

static int[] NhapMangInt()
{
    Console.Write(
        "Nhập các số nguyên, cách nhau bởi dấu cách: "
    );

    string input = Console.ReadLine();

    if (input == "")
    {
        return new int[0];
    }

    string[] chuoiSo = input.Split(
        ' ',
        StringSplitOptions.RemoveEmptyEntries
    );

    int[] nums = new int[chuoiSo.Length];

    for (int i = 0; i < chuoiSo.Length; i++)
    {
        nums[i] = int.Parse(chuoiSo[i]);
    }

    return nums;
}


static double[] NhapMangDouble()
{
    Console.Write("Nhập các điểm, cách nhau bởi dấu cách: ");
    string input = Console.ReadLine();

    if (input == "")
    {
        return new double[0];
    }

    string[] chuoiSo = input.Split(' ');
    double[] nums = new double[chuoiSo.Length];

    for (int i = 0; i < chuoiSo.Length; i++)
    {
        nums[i] = double.Parse(chuoiSo[i]);
    }

    return nums;
}


static void InMang(int[] nums)
{
    Console.Write("[");

    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i]);

        if (i < nums.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}

#endregion


#region Bài 1

static void Bai1()
{
    Console.WriteLine("Bài 1: Tổng các số thỏa điều kiện");
    Console.WriteLine("Tổng các số thỏa điều kiện");

    int[] nums = NhapMangInt();

    Console.Write("Nhập mốc: ");
    int moc = int.Parse(Console.ReadLine());

    long ketQua = TongLonHon(nums, moc);

    Console.WriteLine("Tổng các phần tử lớn hơn " + moc + " = " + ketQua);
}


static long TongLonHon(int[] nums, int moc)
{
    long tong = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > moc)
        {
            tong = tong + nums[i];
        }
    }

    return tong;
}

#endregion


#region Bài 2

static void Bai2()
{
    Console.WriteLine("Bài 2: Sắp xếp tăng và giảm");

    int[] nums = NhapMangInt();

    (int[] tang, int[] giam) ketQua =
        SapXepHaiChieu(nums);

    Console.Write("Mảng tăng dần: ");
    InMang(ketQua.tang);
    Console.WriteLine();

    Console.Write("Mảng giảm dần: ");
    InMang(ketQua.giam);
    Console.WriteLine();

    Console.Write("Mảng gốc: ");
    InMang(nums);
    Console.WriteLine();
}


static (int[] tang, int[] giam) SapXepHaiChieu(int[] nums)
{
    List<int> tang = new List<int>();
    List<int> giam = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        tang.Add(nums[i]);
        giam.Add(nums[i]);
    }

    tang.Sort();

    giam.Sort();
    giam.Reverse();

    return (tang.ToArray(), giam.ToArray());
}

#endregion


#region Bài 3

static void Bai3()
{
    Console.WriteLine("Bài 3: Loại phần tử trùng lặp");
    int[] nums = NhapMangInt();

    int[] ketQua = LoaiTrung(nums);

    Console.Write("Kết quả: ");
    InMang(ketQua);
    Console.WriteLine();
}


static int[] LoaiTrung(int[] nums)
{
    HashSet<int> daGap = new HashSet<int>();
    List<int> ketQua = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (!daGap.Contains(nums[i]))
        {
            daGap.Add(nums[i]);
            ketQua.Add(nums[i]);
        }
    }

    return ketQua.ToArray();
}

#endregion


#region Bài 4: sửa lại out put 1 tí

static void Bai4()
{
    Console.WriteLine("Bài 4: Đếm tần suất phần tử");

    int[] nums = NhapMangInt();

    Dictionary<int, int> ketQua = DemTanSuat(nums);

    Console.WriteLine("Kết quả:");

    foreach (
        KeyValuePair<int, int> item in ketQua
    )
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}


static Dictionary<int, int> DemTanSuat(int[] nums)
{
    Dictionary<int, int> dem = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (dem.ContainsKey(nums[i]))
        {
            dem[nums[i]] = dem[nums[i]] + 1;
        }
        else
        {
            dem.Add(nums[i], 1);
        }
    }

    return dem;
}

#endregion


#region Bài 5

static void Bai5()
{
    Console.WriteLine("Bài 5: Hợp hai danh sách");

    Console.WriteLine("Nhập mảng a:");
    int[] a = NhapMangInt();

    Console.WriteLine("Nhập mảng b:");
    int[] b = NhapMangInt();

    int[] ketQua = Hop(a, b);

    Console.Write("Kết quả: ");
    InMang(ketQua);
    Console.WriteLine();
}


static int[] Hop(int[] a, int[] b)
{
    HashSet<int> daGap = new HashSet<int>();
    List<int> ketQua = new List<int>();

    for (int i = 0; i < a.Length; i++)
    {
        if (!daGap.Contains(a[i]))
        {
            daGap.Add(a[i]);
            ketQua.Add(a[i]);
        }
    }

    for (int i = 0; i < b.Length; i++)
    {
        if (!daGap.Contains(b[i]))
        {
            daGap.Add(b[i]);
            ketQua.Add(b[i]);
        }
    }

    return ketQua.ToArray();
}

#endregion


#region Bài 6

static void Bai6()
{
    Console.WriteLine("Bài 6: Giao hai danh sách");

    Console.WriteLine("Nhập mảng a:");
    int[] a = NhapMangInt();

    Console.WriteLine("Nhập mảng b:");
    int[] b = NhapMangInt();

    int[] ketQua = Giao(a, b);

    Console.Write("Kết quả: ");
    InMang(ketQua);
    Console.WriteLine();
}


static int[] Giao(int[] a, int[] b)
{
    HashSet<int> tapB = new HashSet<int>();
    HashSet<int> daThem = new HashSet<int>();
    List<int> ketQua = new List<int>();

    for (int i = 0; i < b.Length; i++)
    {
        tapB.Add(b[i]);
    }

    for (int i = 0; i < a.Length; i++)
    {
        if (tapB.Contains(a[i]) && !daThem.Contains(a[i]))
        {
            ketQua.Add(a[i]);
            daThem.Add(a[i]);
        }
    }

    return ketQua.ToArray();
}

#endregion


#region Bài 7

static void Bai7()
{
    Console.WriteLine("Bài 7: Phần tử lớn thứ hai");

    int[] nums = NhapMangInt();

    int ketQua = LonThuHai(nums);

    if (ketQua == int.MinValue)
    {
        Console.WriteLine("Không tồn tại giá trị lớn thứ hai.");

        Console.WriteLine("Kết quả = int.MinValue");
    }
    else
    {
        Console.WriteLine("Kết quả = " + ketQua);
    }
}


static int LonThuHai(int[] nums)
{
    HashSet<int> tapHop = new HashSet<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        tapHop.Add(nums[i]);
    }

    if (tapHop.Count < 2)
    {
        return int.MinValue;
    }

    int lonNhat = int.MinValue;
    int lonThuHai = int.MinValue;

    foreach (int x in tapHop)
    {
        if (x > lonNhat)
        {
            lonThuHai = lonNhat;
            lonNhat = x;
        }
        else if (x > lonThuHai)
        {
            lonThuHai = x;
        }
    }

    return lonThuHai;
}

#endregion


#region Bài 8

static void Bai8()
{
    Console.WriteLine("========== BÀI 8 ==========");
    Console.WriteLine("Thống kê xếp loại");

    double[] diem = NhapMangDouble();

    Dictionary<string, int> ketQua = ThongKeXepLoai(diem);

    Console.WriteLine("Kết quả:");

    foreach (KeyValuePair<string, int> item in ketQua)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}


static Dictionary<string, int> ThongKeXepLoai(double[] diem)
{
    Dictionary<string, int> ketQua = new Dictionary<string, int>();

    ketQua.Add("Giỏi", 0);
    ketQua.Add("Khá", 0);
    ketQua.Add("Trung bình", 0);
    ketQua.Add("Yếu", 0);

    for (int i = 0; i < diem.Length; i++)
    {
        if (diem[i] >= 8)
        {
            ketQua["Giỏi"] = ketQua["Giỏi"] + 1;
        }
        else if (diem[i] >= 6.5)
        {
            ketQua["Khá"] = ketQua["Khá"] + 1;
        }
        else if (diem[i] >= 5)
        {
            ketQua["Trung bình"] = ketQua["Trung bình"] + 1;
        }
        else
        {
            ketQua["Yếu"] = ketQua["Yếu"] + 1;
        }
    }

    return ketQua;
}

#endregion


#region Bài 9

static void Bai9()
{
    Console.WriteLine("Bài 9: Contains Duplicate");

    int[] nums = NhapMangInt();

    bool ketQua =
        ContainsDuplicate(nums);

    Console.WriteLine("Kết quả = " + ketQua);
}


static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (set.Add(nums[i]) == false)
        {
            return true;
        }
    }

    return false;
}

#endregion


#region Bài 10

static void Bai10()
{
    Console.WriteLine("Bài 10: Subarray Sum Equals K");

    int[] nums = NhapMangInt();

    Console.Write("Nhập k: ");
    int k = int.Parse(Console.ReadLine());

    int ketQua =
        SubarraySum(nums, k);

    Console.WriteLine(
        "Số mảng con có tổng bằng "
        + k
        + " = "
        + ketQua
    );
}


static int SubarraySum(int[] nums, int k)
{
    Dictionary<int, int> dem = new Dictionary<int, int>();

    int tong = 0;
    int ketQua = 0;

    dem.Add(0, 1);

    for (int i = 0; i < nums.Length; i++)
    {
        tong = tong + nums[i];

        int canTim = tong - k;

        if (dem.ContainsKey(canTim))
        {
            ketQua = ketQua + dem[canTim];
        }

        if (dem.ContainsKey(tong))
        {
            dem[tong] = dem[tong] + 1;
        }
        else
        {
            dem.Add(tong, 1);
        }
    }

    return ketQua;
}

#endregion