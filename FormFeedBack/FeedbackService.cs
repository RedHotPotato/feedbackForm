using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFeedBack
{
    public class FeedbackService
    {
        public List<Feedback> feedback;
        public FeedbackService() { 
            feedback = new List<Feedback>();
        }
        public void Add(Feedback feedback) {
            this.feedback.Add(feedback);
        }
        public void Remove(Feedback feedback) {
            this.feedback.Remove(feedback);
        }
        public List<Feedback> GetFeedback() {
            return feedback.ToList();
        }

    }
}
