using System;

namespace AlgorithmLearning {
    class Program {
        static void Main (string[] args) {

            int[] arr = new int[] { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

            MaoPao maoPao = new MaoPao ();
            var result= maoPao.MaoPaoPaiXu (arr);

            Console.WriteLine (result.ToString ());
        }
    }
}