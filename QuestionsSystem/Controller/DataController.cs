using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionsSystem.Modell;
using QuestionsSystem.View;



namespace QuestionsSystem.Controller
{
    public class DataController
    {
        /*public static List<Element> GetQuestions(List<Element> monkey)
        {
            List<Element> x = new List<Element>();
            x.Add(monkey.ElementAt(0));
            x.Add(monkey.ElementAt(1));
            x.Add(monkey.ElementAt(2));
            return x;
        }*/

        public static List<Element> GetQuestions(List<Element> monkey, int count)
        {
            Random rnd=new Random();
            List<Element> x = new List<Element>();
            if(count > monkey.Count)
            {
                return x;
            }
            //x.GetRange(0, monkey.Count);
            for(int i = 0; i <= count; i++)
            {
                Element q = monkey[rnd.Next(monkey.Count)];
                if(! monkey.Exists(e =>e.id==q.id))
                {
                    x.Add(q);
                }
                else
                {
                    i--;
                }
            }
            
            return x;
        }
       /* public static Element GetQuestionAt(List<Element> question, int x)
        {
            
            Element q = new Element();
            q = question.ElementAt(x);
            return q ;

        }*/
    }
}
