using System;
using NegativeDecider; // 引入你的神秘命名空间

namespace NegativeDecider.Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== 开始测试神秘负性裁决器 ===");
            
            // 测试用例 1: 明显的负数
            int? test1 = -5;
            Console.WriteLine($"输入: {test1}，是否为负数? {NegativeChecker.IsNegative(test1)}");
            
            // 测试用例 2: 正数
            int? test2 = 10;
            Console.WriteLine($"输入: {test2}，是否为负数? {NegativeChecker.IsNegative(test2)}");
            
            // 测试用例 3: 零（0 不是负数）
            int? test3 = 0;
            Console.WriteLine($"输入: {test3}，是否为负数? {NegativeChecker.IsNegative(test3)}");
            
            // 测试用例 4: 空值 (null)
            int? test4 = null;
            Console.WriteLine($"输入: {test4}，是否为负数? {NegativeChecker.IsNegative(test4)}");
            
            Console.WriteLine("=== 测试完毕 ===");
            
            // 防止控制台闪退，等待按键
            Console.ReadKey();
        }
    }
}