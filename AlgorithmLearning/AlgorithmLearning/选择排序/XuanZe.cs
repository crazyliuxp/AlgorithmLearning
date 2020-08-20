public class XuanZe {
    //选择排序就是重复“从待排序的数据中寻找最小值，将其与序列最左边的数字进行交换”这一操作的算法。
    //在序列中寻找最小值时使用的是线性查找。
    //复杂度O(n^2)
    public int[] XuanZePaiXu (int[] arr) {
        // int[] arr = new int[] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

        for (int i = 0; i < arr.Length - 1; i++) {
            int min = arr[i];
            int index = i;
            for (int j = i + 1; j < arr.Length; j++) {
                if (min > arr[j]) {
                    min = arr[j];
                    index = j;
                }
            }

            arr[index] = arr[i];
            arr[i] = min;
        }
        return arr;
    }
}