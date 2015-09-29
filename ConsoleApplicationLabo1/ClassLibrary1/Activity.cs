using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Activity
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private bool isCompulsory;

        public bool IsCompulsory
        {
            get { return isCompulsory; }
            set { isCompulsory = value; }
        }

        public Activity(String title, bool compulsory)
        {
            if (String.IsNullOrEmpty(title))
                throw new ArgumentNullException(title);
            Title = title;
            IsCompulsory = isCompulsory;
        }

        public override string ToString()
        {
            return (IsCompulsory) ? Title + "(Obligatoire)" : Title;
        }
    }
}
