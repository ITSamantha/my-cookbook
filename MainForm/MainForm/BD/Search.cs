using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    internal static class Search
    {
        static List<string> list1;
        static List<string> list2;
        static List<pairEquals> listPair;
        struct pairEquals
        {
           public string s1;
            public string s2;
            public int index;
        }
        public static double indexEquals(object x1, object x2)
        {

            string str1, str2;
            if ((x1 is string) &&(x2 is string))
            {
                str1 = (string)x1;
                str2 = (string)x2;
            }
            else
            {
                return 0;
            }

           int size1 = str1.Count(c => !Char.IsWhiteSpace(c));
            int size2 = str2.Count(c => !Char.IsWhiteSpace(c));
            int minsize = Math.Min(size1, size2);
            double result1 = 0, result2 = 0;
            list1 = str1.Split(' ').ToList();
             list2 = str2.Split(' ').ToList();
            listPair = new List<pairEquals>();
            do
            {
                createPair();
            } while (!checkPair());

            foreach (pairEquals pair in listPair)
            {
                result1 += pair.index;
                result2 += pair.index;
            }
            result1 = result1 / minsize;
            result1 *= 100;
           // result1 = result1 / size1;
          //  result2 = result2 / size2;
           // result1 *= 100;
          //  result2 *= 100;
            //   return ((result1 + result2) / 2);
            return result1;
            }
          
        
        private static void createPair()
        {
            List<string> l1;
            List<string> l2;
            string maxStr1="" , tempStr1 = "", maxStr2 = "", tempStr2 = "" ;
            int maxIndex = 0, tempIndex = 0;
            bool reverse = false;
            if (list1.Count <= list2.Count)
            {
                l1 = list1;
                l2 = list2;
            }
            else
            {
                l2 = list1;
                l1 = list2;
                reverse = true;
            }
            foreach (string s1 in l1)
            {
                foreach(string s2 in l2)
                {
                    tempIndex = oneEquals(s1, s2);
                    tempStr1 = s1;
                    tempStr2 = s2;
                    if (tempIndex > maxIndex)
                    {
                        maxIndex = tempIndex;
                        maxStr1 = tempStr1;
                        maxStr2 = tempStr2;
                    }
                }
                pairEquals pair;
                if (reverse)
                {
                    pair.s2 = maxStr1;
                    pair.s1 = maxStr2;
                }
                else
                {
                    pair.s1 = maxStr1;
                    pair.s2 = maxStr2;
                }

                pair.index = maxIndex;
                listPair.Add(pair);
                tempIndex = 0;
                maxIndex = 0;
            }
        }

        private static bool checkPair()
        {
            bool result = true ;
            for (int i = 0; i< listPair.Count; i++)
            {
                for (int j = 0; j < listPair.Count; j++)
                {
                       if (i == j)
                    {
                        continue;
                    }
                    pairEquals p1, p2;
                    p1 = listPair.ElementAt(i);
                    p2 = listPair.ElementAt(j);
                    if (p1.s2.Equals(p2.s2))
                    {
                        result = false;
                        if (p1.index >= p2.index)
                        {
                            listPair.Remove(p2);
                            list1.Remove(p1.s1);
                            list2.Remove(p1.s2);

                        }
                        else
                        {
                            listPair.Remove(p1);
                            list1.Remove(p2.s1);
                            list2.Remove(p2.s2);
                        }
                        checkPair();
                    }
                }
               
            }
            return result;
        }
        private static int oneEquals(string str1, string str2)
        {
            int result = 0, temp = 0;
            str1 = str1.ToLowerInvariant();
            str2 = str2.ToLowerInvariant();

            
                string max = "", min = "";
                if (str1.Length >= str2.Length)
                {
                    max = str1;
                    min = str2;
                }
                else
                {
                    max = str2;
                    min = str1;
                }
                int i = 0, j = 0;
                while ((i < max.Length)&&(j < min.Length))
                {
                    char c1 = max.ElementAt(i), c2 = min.ElementAt(j);
                    if (c1 == c2)
                    {
                        i++;
                        j++;
                        temp++;
                    }
                    else
                    {
                        i++;
                        j = 0;
                        if (result <= temp)
                        {
                            result = temp;
                            temp = 0;
                        }
                    }

                }
                if (result <= temp)
                {
                    result = temp;
                    temp = 0;
                }
            
            
            return result;
        }
    }
   
}
