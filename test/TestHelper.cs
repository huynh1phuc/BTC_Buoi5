using System;
using System.Collections.Generic;

public static class TestHelper
{
    public static bool MangBangNhau(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }


    public static bool CungTapGiaTri(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        HashSet<int> tapA = new HashSet<int>();
        HashSet<int> tapB = new HashSet<int>();

        for (int i = 0; i < a.Length; i++)
        {
            tapA.Add(a[i]);
        }

        for (int i = 0; i < b.Length; i++)
        {
            tapB.Add(b[i]);
        }

        if (tapA.Count != tapB.Count)
        {
            return false;
        }

        foreach (int x in tapA)
        {
            if (!tapB.Contains(x))
            {
                return false;
            }
        }

        return true;
    }


    public static bool DictionaryBangNhau(Dictionary<int, int> a, Dictionary<int, int> b)
    {
        if (a.Count != b.Count)
        {
            return false;
        }

        foreach (KeyValuePair<int, int> item in b)
        {
            if (!a.ContainsKey(item.Key))
            {
                return false;
            }

            if (a[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;
    }


    public static bool DictionaryBangNhau(Dictionary<string, int> a, Dictionary<string, int> b)
    {
        if (a.Count != b.Count)
        {
            return false;
        }

        foreach (KeyValuePair<string, int> item in b)
        {
            if (!a.ContainsKey(item.Key))
            {
                return false;
            }

            if (a[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;
    }


    public static string InMang(int[] nums)
    {
        string ketQua = "[";

        for (int i = 0; i < nums.Length; i++)
        {
            ketQua = ketQua + nums[i];

            if (i < nums.Length - 1)
            {
                ketQua = ketQua + ", ";
            }
        }

        return ketQua + "]";
    }
}