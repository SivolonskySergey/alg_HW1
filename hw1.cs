/**
 * Реализовать сортировку подсчетом
 * [1 2 3 3 2 3 4 2 1 1 2 3 4 4 2 3 1 4 2 3 4 2 1 2 3 4 2 1 3 4 2 1 2 3 4 4 2 3 3 2 4]
 * Подсчитываем, сколько раз встречается конкретный элемент
 * 1 -> 5 (количество единиц в массиве: число взято с потолка!)
 * 2 -> 7 (количество двоек в массиве)
 * 3 -> 3
 * 4 -> 4
 *        * Вставляем единицу 5 раз
 * Вставляем двойку 7 раз
 * Вставялем тройку 3 раза
 * Вставляем четверку 4 раза
 * */

public static class Solution
{
    public static int[] SortingByCounting(int[] nums)
    {
        SortedDictionary<int, int> tempDict = new SortedDictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (tempDict.ContainsKey(nums[i]))
            {
                tempDict[nums[i]]++;
            }
            else
            {
                tempDict.Add(nums[i], 1);
            }
        }

        int counter = 0;
        foreach (int i in tempDict.Keys)
        {
            int temp = counter;
            for (int j = counter; j < tempDict[i] + temp; j++)
            {
                nums[j] = i;
                counter++;
            }
        }
        return nums;
    }
}