using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionsSystem.Model;
namespace QuestionsSystem.Controller
{
    public class DataController
    {
        public static List<Element> GetQuetsions(List<Element> questions, int count)
        {
            List<Element> list = new List<Element>();
            if (count > questions.Count)
            {
                return list;
            }
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Element q = questions[random.Next(questions.Count)];

                if (  !(list.Exists(e => e.id == q.id))  )
                {
                    list.Add(q);
                }
                else
                {
                    i--;
                }
            }

            return list;
        }
    }
}
