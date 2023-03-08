int[] arr1 = { 1, 2, 3, 4 };
int[] arr2 = { 5, 6, 7, 8 };
int[] sum = new int[arr1.Length];

for (int i = 0; i < arr1.Length; i++)
{
    sum[i] = arr1[i] + arr2[i];
}
