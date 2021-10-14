
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int n = 0;
        if (nums1 != null && nums1.Length > 0)
        {
            n = nums1.Length;
        }
        if (nums2 != null && nums2.Length > 0)
        {
            n += nums2.Length;
        }

        int[] arr = new int[n];
        int i = 0;
        if (nums1 != null && nums1.Length > 0)
        {
            nums1.CopyTo(arr, i);
            i = nums1.Length;
        }
        if (nums2 != null && nums2.Length > 0)
        {
            nums2.CopyTo(arr, i);
        }

        if(arr.Length == 0)
        {
            return 0.0000;
        }
        var data = arr.OrderBy(x=> x).ToArray();
        
        if(data.Length == 1)
        {
            return data[0];
        }

        if(data.Length % 2 == 1)
        {
            i = (data.Length / 2);
            return data[i];
        }
        else
        {
            i = (data.Length / 2);
            double sum = data[i - 1] + data[i];
            return sum / 2;
        }
    }