using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pupil : Person
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        private List<Activity> lstActivities;

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        private char[] tabEval;

        public char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public Pupil(String name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age)
            : this(name, age, 1)
        { }

        public void AddActivity(Activity a)
        {
            var taille = LstActivities.Count();
            if (taille < Parametre.nbActivityMax)
                LstActivities.Add(a);
            else
                System.Console.Write("Seuil maximal d'activité atteind");
        }

        public override string ToString()
        {

            string ch = base.ToString() + ((LstActivities.Count() != 0) ? "a choisi les activitées suivantes : " : "n'a pas encore choisi d'activités");
            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += LstActivities.ElementAt(i) + " ";
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = (char)Parametre.Eval.Satisfaisant)
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity activity in LstActivities)
                {
                    if (activity.Title.Equals(title)) break;
                    i++;
                }

                TabEval[i] = evaluation;
            }
        }

        public char getEvaluationFor(string t)
        {
            int i = 0;
            if (t != null)
                foreach (var activity in LstActivities)
                {
                    
                    if (activity.Title.Equals(t))
                        return TabEval[i];
                    i++;
                }
            throw new KeyNotFoundException();
        }

    }
}
