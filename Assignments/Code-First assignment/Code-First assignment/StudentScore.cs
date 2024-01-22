using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_assignment
{
    public class StudentScore
    {
        public int Id { get; set; }
        public float MathScore  { get; set; }
        public float HistoryScore { get; set; }
        public float EnglishScore { get; set; }
        public virtual Student Student { get; set; }

    }
}
