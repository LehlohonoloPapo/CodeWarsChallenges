using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSol
{
    public class User
    {
        public int rank;
        public int progress;
        public User()
        {
           rank = -8;

        }
        public void incProgress(int actRank)
        {

            //progress += actRank;
            if (rank == actRank)
            {
                progress += 3;
            }
             if (rank - 1 == actRank)
            {
                progress += 1;
            }
             if (rank <=actRank)
            {
                progress += 10 * (actRank - rank) * (actRank - rank);
            }
            //if(progress >= 100) 
            //{
            //    rank++;
            //    progress-=100;
            //}
            while(progress >= 100) {
                rank++;
                if (rank == 0)
                {
                    rank++;
                }
                progress -= 100;
            }
            if(rank>8 || rank< -8|| actRank==0)
            {
                throw new ArgumentException();
            }
         
        }
    }
}
