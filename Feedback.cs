using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10229540_PROG7312_POE
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public string Body {  get; set; }
    }

    public class FeedbackTracker 
    { 
        public List<Feedback> feedbacks { get; set; }
    }
}
