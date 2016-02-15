using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10___Election
{
    class Lab10Election
    {
        static void Main(string[] args)
        {
        string[] candidates = new string[5] { "al", "ben", "carl", "derek", "eoin" };
        int[] votes= new int[5] {2, 4, 6, 8, 10};
            double[] percentage = new double[5];
            int totalVotes = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                totalVotes += votes[i];
            }
            //foreach (var vote in votes)
            //{
            //    totalVotes += vote;
            //}

            for (int i = 0; i < candidates.Length; i++)
            {
                int currentVotes = votes[i];
                //int votePercentage = (100 / (totalVotes / currentVotes));
                int votePercentage = (currentVotes * 100 / totalVotes);
                percentage[i] = votePercentage;
                Console.WriteLine("name: " + candidates[i] + "- votes: " + votes[i] + "- % of total votes: " + 100/(totalVotes/votes[i]));

            }
            int highestVotes = votes.Max();
            int highestVotesIndex = votes.ToList().IndexOf(highestVotes);
            Console.WriteLine("HV: " + highestVotes + ". HV I: " + highestVotesIndex);
            Console.WriteLine("winner: " + candidates[highestVotesIndex] + " with " + highestVotes + " votes.");

            foreach (var item in percentage)
            {
                Console.WriteLine(item);
            }
    }
    }
}


    
    //print name, votes, % of total votes they got
    //print winner