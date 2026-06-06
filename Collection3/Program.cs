namespace Collection3
{
//    Реализуйте алгоритм, который проверяет,
//правильно ли расставлены скобки(, }, [,], (, )) 
//в строке. Например: строка { ()[()]}
//вернетtrue, а {(})—false`.
    internal class Program
    {
        public class BracketValidator
        {
            public static bool IsValid(string input)
            {
                var stack = new Stack<char>();

                // Словарь для быстрого сопоставления закрывающихся скобок с открывающимися
                var bracketMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

                foreach (char c in input)
                {
                    // Если это открывающаяся скобка - кладем в стек
                    if (bracketMap.ContainsValue(c))
                    {
                        stack.Push(c);
                    }
                    // Если это закрывающаяся скобка
                    else if (bracketMap.ContainsKey(c))
                    {
                        // Проверяем, не пуст ли стек и совпадает ли верхний элемент
                        if (stack.Count == 0 || stack.Pop() != bracketMap[c])
                        {
                            return false;
                        }
                    }
                }

                // Если стек пуст, все скобки закрыты правильно
                return stack.Count == 0;
            }

            public static void Main()
            {
                string test1 = "{(a+b)[()]()}";
                string test2 = "{(})";

                Console.WriteLine($"{test1} -> {IsValid(test1)}"); // Выведет: True
                Console.WriteLine($"{test2} -> {IsValid(test2)}"); // Выведет: False
            }
        }
    }
}
