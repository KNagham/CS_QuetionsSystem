using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionsSystem.Model;

namespace QuestionsSystem.Controller
{
    public class DBHelper
    {
        public static void AddQuestion(Element element)
        {
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            context.Elements.Add(element);
            context.SaveChanges();
        }

        public static List<Element> ReadQuestions()
        {
            List<Element> list = new List<Element>();
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            list  = context.Elements.ToList();
            return list;
        }

        public static void UpdateRecord(Element temp)
        {
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            context.Entry(temp).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public static void DeleteQuestion(Element temp)
        {
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            context.Entry(temp).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public static Admin FindUser(string userName)
        {
            Admin user = new Admin();
            QuestionsSystemEntities context = new QuestionsSystemEntities();
            try
            {
                user = context.Admins.Where(x => x.user == userName).First();
            }
            catch
            {
                user = new Admin();
            }
            return user;
        }
    }
}
