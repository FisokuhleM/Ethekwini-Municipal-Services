using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10229540_PROG7312_POE
{
    public class EventsRecommendation
    {
        //Variables
        private Dictionary<string, int> searchHistory = new Dictionary<string, int>();

        //Keep track of search history
        public void TrackSearch(string category)
        {
            if (searchHistory.ContainsKey(category))
            {
                searchHistory[category]++;
            }
            else
            {
                searchHistory[category] = 1;

            }
        }//Method ends

        public string RecommendCat()
        {
            int maxSearched = 0;
            string recommendCat = "";

            foreach (var search in searchHistory)
            {
                if (search.Value > maxSearched)
                {
                    maxSearched = search.Value;
                    recommendCat = search.Key;
                }//if ends
            }//foreach ends
            return recommendCat;
        }
    }
}
