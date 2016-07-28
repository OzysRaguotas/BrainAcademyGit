using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<char, int[]> dic = new Dictionary<char, int[]>();
            dic.Add('A', new int[2] { 0, 1 });
            dic.Add('B', new int[4] { 1, 0, 0, 0 });
            dic.Add('C', new int[4] { 1, 0, 1, 0 });
            dic.Add('D', new int[3] { 1, 0, 0 });
            dic.Add('E', new int[1] { 0 });
            dic.Add('F', new int[4] { 0, 0, 1, 0 });
            dic.Add('G', new int[3] { 1, 1, 0 });
            dic.Add('H', new int[4] { 0, 0, 0, 0 });
            dic.Add('I', new int[2] { 0, 0 });
            dic.Add('J', new int[4] { 0, 1, 1, 1 });
            dic.Add('K', new int[3] { 1, 0, 1 });
            dic.Add('L', new int[4] { 0, 1, 0, 0 });
            dic.Add('M', new int[2] { 1, 1 });
            dic.Add('N', new int[2] { 1, 0 });
            dic.Add('O', new int[3] { 1, 1, 1 });
            dic.Add('P', new int[4] { 0, 1, 1, 0 });
            dic.Add('Q', new int[4] { 1, 1, 0, 1 });
            dic.Add('R', new int[3] { 0, 1, 0 });
            dic.Add('S', new int[3] { 0, 0, 0 });
            dic.Add('T', new int[1] { 1 });
            dic.Add('U', new int[3] { 0, 0, 1 });
            dic.Add('V', new int[4] { 0, 0, 1, 1 });
            dic.Add('W', new int[3] { 0, 1, 1 });
            dic.Add('X', new int[4] { 1, 0, 0, 1 });
            dic.Add('Y', new int[4] { 1, 0, 1, 1 });
            dic.Add('Z', new int[4] { 1, 1, 0, 0 });

            Console.WriteLine("Enter sentence");
            string sent = Console.ReadLine();
            sent = sent.ToUpper();
            int[] value;
            for (int i = 0; i < sent.Length; i++)
            {
                if (dic.TryGetValue(sent[i], out value))
                {
                    for (int j = 0; j < value.Length; j++)
                    {
                        if (value[j] == 0)
                        {
                            Console.Beep(2000, 200);
                        }
                        if (value[j] == 1)
                        {
                            Console.Beep(1000, 500);
                        }
                    }
                }
                else if (sent[i] == ' ')
                {
                    Console.Beep(30000, 1000);
                }
            }
            Console.ReadLine();
        }
    }
}