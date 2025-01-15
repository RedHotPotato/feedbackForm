using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FormFeedBack
{
    public class Feedback
    {
        public string name;
        public string comment;
        public int rating;
        public Feedback(string name, string comment, int rating) {
            this.name = name;
            this.comment = comment;
            this.rating = rating;
        }
        public string GetName() {
            return this.name;
        }
        public string GetComment() {
            return this.comment;
        }
        public int GetRating() {
            return this.rating;
        }
        public override string ToString()
        {
            return $"{this.name}|{this.comment}|{this.rating}"; // Например, използваме символ '|' за разделяне
        }

        //public static Feedback FromString(string str)
        //{
        //    var parts = str.Split('|');
        //    if (parts.Length == 3)
        //    {
        //        return new Feedback
        //        {
        //            Name = parts[0],
        //            Comment = parts[1],
        //            Rating = int.Parse(parts[2])
        //        };
        //    }
        //    return null;
        //}
    }
}
