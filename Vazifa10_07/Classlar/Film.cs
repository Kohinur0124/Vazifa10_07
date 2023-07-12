using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa10_07.Classlar
{
    public class Film
    {
        public int film_id;
        public string title;
        public string description;
        public DateTime release_year;
        public int language_id;
        public int rental_duration;
        public float rental_rate;
        public int length;
        public float replacement_cost;
        public string rating;
        public DateTime last_update;
        public List<string> special_features;
        public Dictionary<string, int> fulltext;

        public override string ToString()
        {
            return $"{film_id} | {title} | {description} | {release_year} | {language_id} | {rental_duration} | {rental_rate} | {length} | " +
                $"{replacement_cost} | {rating} | {last_update} | {special_features} | {fulltext}";

        }


    }
}
