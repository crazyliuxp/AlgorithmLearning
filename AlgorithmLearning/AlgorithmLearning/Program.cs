using System;
using AlgorithmLearning._214最短回文串;
using AlgorithmLearning._557反转字符串中的字符;
using AlgorithmLearning._657机器人能否返回原点;
using AlgorithmLearning.表示数字的字符串;
using Models;

namespace AlgorithmLearning {
    class Program {
        static void Main (string[] args) {

            // int[] arr = new int[] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

            // MaoPao maoPao = new MaoPao ();
            // var result= maoPao.MaoPaoPaiXu (arr);

            // Console.WriteLine (result.ToString ());

            // TreeNode root = new TreeNode (3, new TreeNode (9), new TreeNode (20, new TreeNode (15), new TreeNode (7)));
            // TreeNode root = new TreeNode (1, new TreeNode (2));
            // ErChaShuMinDepth depth = new ErChaShuMinDepth ();
            // int result = depth.MinDepth (root);
            // Console.WriteLine (result);

            //string s = "abaababaababaab";
            //Leetcode_RepeatedSubstringPattern repeatedSubstringPattern = new Leetcode_RepeatedSubstringPattern();
            //var result = repeatedSubstringPattern.RepeatedSubstringPattern(s);

            //JiQiRen jiQiRen = new JiQiRen();
            //var result = jiQiRen.JudgeCircle("UD");

            //ZuiDuanHWC zuiduan = new ZuiDuanHWC();

            //var result= zuiduan.ShortestPalindrome("abc");

            //FanZhuan fanZhuan = new FanZhuan();
            //var result= fanZhuan.ReverseWords("Let's take LeetCode contest");

            NumberStr numberStr = new NumberStr();
            var result = numberStr.IsNumber("078332e437");


            Console.WriteLine(result);
        }
    }
}