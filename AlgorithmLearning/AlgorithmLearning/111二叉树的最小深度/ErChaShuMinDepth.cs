using System;
using Models;

public class ErChaShuMinDepth {

    //找出左树和右树的最小值
    public int MinDepth (TreeNode root) {
        if (root == null) return 0;

        if (root.left == null && root.right != null) {
            return MinDepth (root.right) + 1;
        }

        if (root.left != null && root.right == null) {
            return MinDepth (root.left) + 1;
        }

        return Math.Min (MinDepth (root.left), MinDepth (root.right)) + 1;

    }

}