using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pUn = new Pupil("Flo", 6);
            Pupil pDeux = new Pupil("Laure", 6);
            Pupil pupilGrade1 = new Pupil("John", 6);
            Activity actUn = new Activity("peinture", false);
            Activity actDeux = new Activity("bricolage", false);
            Activity actTrois = new Activity("français", true);
            Activity actQuatre = new Activity("sport", true);
            Activity actCinq = new Activity("orientation", false);
            Activity coloriage = new Activity("coloriage", true);

            pUn.AddActivity(actUn);
            pUn.AddActivity(actTrois);
            pUn.AddActivity(actCinq);
            pupilGrade1.AddActivity(coloriage);

            pupilGrade1.AddEvaluation("coloriage");
            pUn.AddEvaluation(evaluation: (char)Parametre.Eval.TresBien, title: "peinture");
           
    
            System.Console.Write(pUn);
            System.Console.Write(pUn.getEvaluationFor("peinture"));
            System.Console.ReadKey();
              
            System.Console.Write(pDeux);
            System.Console.ReadKey();

            List<Pupil> lstPupil = new List<Pupil>()
            {
                new Pupil("Johnatan",7),
                new Pupil("Marie",7),
                new Pupil("Max",7,2),
                new Pupil("paul",6),
                new Pupil("nat",5),
            };


            var pupilGrade1Plus6 = lstPupil.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);
            //var pupilGrade1Plus6 = from pupil in lstPupil
                                  // where pupil.Age > 6 && pupil.Grade == 1
                                   //select pupil;

            if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                }
            }

            System.Console.ReadKey();
        }
    }
}
