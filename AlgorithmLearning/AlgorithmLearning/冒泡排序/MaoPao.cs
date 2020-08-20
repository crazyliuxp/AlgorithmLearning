public class MaoPao {
    //冒泡排序就是重复“从序列右边开始比较相邻两个数字的大小，再根据结果交换两个数字的位置”这一操作方法。
    //在这个过程中，数字会像泡泡一样，慢慢的从右往左“浮”到序列的顶端，所以这个算法才被成为“冒泡排序”。
    //复杂度O(n^2)

    public int[] MaoPaoPaiXu (int[] arr) {
        //int[] arr = new int[] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

        for (int i = arr.Length - 1; i >= 0; i--) {
            for (int j = i - 1; j >= 0; j--) {
                int left = arr[j];
                int right = arr[i];
                if (left > right) {
                    int num = left;
                    arr[j] = right;
                    arr[i] = num;
                }
            }
        }

        return arr;
    }
}