using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionsSystem.Modell;

namespace QuestionsSystem.Controller
{
    public  class DBHelper
    {
        public static void AddQuestion(Element element)
        {
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            context.Elements.Add(element);
            context.SaveChanges();
        }
    }
}
