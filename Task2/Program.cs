using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan ligula nulla, sed iaculis leo hendrerit vitae. Praesent viverra, quam vel finibus aliquet, tortor sapien sollicitudin augue, vitae rhoncus nisl dui ut elit. Maecenas dignissim erat at mi aliquet porta. Pellentesque luctus metus nec est cursus porta eget at leo. Pellentesque fringilla neque erat, vitae commodo nibh vulputate sed. Mauris maximus erat non justo ultrices condimentum. Duis sed scelerisque nisl. Aenean id velit lobortis, fringilla ipsum in, tempus libero. Nulla ut magna venenatis, iaculis diam a, sodales erat. Fusce scelerisque ut dui non dictum. Curabitur malesuada imperdiet nunc id consequat.";

            //Message.GetShorterWordsThan(lorem, 4);

            //Console.WriteLine(Message.DeleteWhatEndsOn(lorem, 't'));

            Console.WriteLine(Message.FindLongestWord(lorem));

            Console.WriteLine(Message.LongestWords(lorem));

            string[] analysisArray = new string[] { "lorem", "ipsum", "fail" };

            Dictionary<string, int> analysisResult = Message.Analyse(lorem, analysisArray);
            foreach (var pair in analysisResult)
            {
                Console.WriteLine($"Слово {pair.Key} встречается {pair.Value} раз");
            }

            Console.ReadKey();
        }
    }
}
