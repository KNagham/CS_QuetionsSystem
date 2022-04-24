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
        public static List<elemet> GetQuetsions(List<elemet> questions, int count)
        {
            List<elemet> list = new List<elemet>();
            if (count > questions.Count)
            {
                return list;
            }
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                elemet q = questions[random.Next(questions.Count)];

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
