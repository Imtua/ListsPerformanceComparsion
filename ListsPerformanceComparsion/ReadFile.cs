using System.Text;

namespace ListsPerformanceComparsion
{
    internal class ReadFile
    {
        private const string FILE_PATH = @"C:\test\Text1.txt";
        
        public static void ToList()
        {
            string text = File.ReadAllText(FILE_PATH);
            StringBuilder sb = new StringBuilder();
            List<string> words = new List<string>();

            char[] signs = { ' ', ',', '.', '\t', '\n', '\r', ':', ';',
                '(', ')', '*', '–', '!', '?', '-', '<', '>', '»', '«',};

            for (int i = 0; i < text.Length; i++)
            {
                if (signs.Contains(text[i]))
                {
                    // Сделал проверку нашего слова на NULL, чтобы в случае если полный текст
                    // начинается с пробела или в тексте идет несколько раз пробел
                    // наш пустой StringBuilder не передавался в List
                    if (sb != null)
                    {
                        words.Add(sb.ToString());
                        sb.Clear();
                    }
                    continue;
                }
                sb.Append(text[i]);
            }
        }

        public static void ToLinkedList()
        {
            string text = File.ReadAllText(FILE_PATH);
            StringBuilder sb = new StringBuilder();

            LinkedList<string> words = new LinkedList<string>();

            char[] signs = { ' ', ',', '.', '\t', '\n', '\r', ':', ';',
                '(', ')', '*', '–', '!', '?', '-', '<', '>', '»', '«',};

            for (int i = 0; i < text.Length; i++)
            {
                if (signs.Contains(text[i]))
                {
                    if (sb != null)
                    {
                        words.AddLast(sb.ToString());
                        sb.Clear();
                    }
                    continue;
                }
                sb.Append(text[i]);
            }
        }
    }
}
