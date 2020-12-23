using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF2ScoreCalculator
{
    public struct ClearTimeSetting
    {
        public ClearTimeSetting(int minT, int maxT, int maxS, int minS)
        {
            minTime = minT;
            maxTime = maxT;
            maxScore = maxS;
            minScore = minS;
        }
        public int minTime;
        public int maxTime;
        public int maxScore;
        public int minScore;
    }

    public partial class Form1 : Form
    {
        static ClearTimeSetting[] settings = new ClearTimeSetting[4]
        {
            new ClearTimeSetting(120, 900, 1200, 50),  //Easy
            new ClearTimeSetting(120, 900, 2000, 150), //Normal
            new ClearTimeSetting(120, 900, 3000, 300), //Hard
            new ClearTimeSetting(180, 900, 4500, 600), //Very Hard
        };

        public Form1()
        {
            InitializeComponent();
            difficulty.SelectedIndex = 0;
        }

        private void seconds_ValueChanged(object sender, EventArgs e)
        {
            result.Text = "Result: " + CalculateScore();
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            minTimeText.Text = "Minimum Time: " + settings[difficulty.SelectedIndex].minTime;
            maxTimeText.Text = "Maximum Time: " + settings[difficulty.SelectedIndex].maxTime;
            minScoreText.Text = "Minimum Score: " + settings[difficulty.SelectedIndex].minScore;
            maxScoreText.Text = "Maximum Score: " + settings[difficulty.SelectedIndex].maxScore;

            result.Text = "Result: " + CalculateScore();
        }

        int CalculateScore()
        {
            return CalculateScore(difficulty.SelectedIndex, (int)seconds.Value);
        }

        int CalculateScore(int difficulty, int time)
        {
            ClearTimeSetting s = settings[difficulty];

            //Console.WriteLine("Calculating...");

            int div = (s.maxTime - s.minTime) / 10 + 1;

            if (time >= s.maxTime)
            {
                //Console.WriteLine("Time is greater than maximum time.");
                unrounded.Text = "Exact Calculation: " + s.minScore.ToString();
                return s.minScore;
            }

            int inc = s.minTime - 10;
            for (int i = 0; i < div; i++)
            {
                inc += 10;
                if (time < inc)
                {
                    float score = s.maxScore - (((float)(s.maxScore - s.minScore) / (float)div) * i);
                    unrounded.Text = "Exact Calculation: " + score.ToString();
                    //Console.WriteLine($"Iterations: {i}/{diff}\nCompared Value: {inc}\nFloat score: {score}\nFloored score: {Math.Ceiling(score)}\nCasted score: {(int)score}");
                    return (int)Math.Ceiling(score);
                }
            }

            unrounded.Text = "Exact Calculation: " + s.maxScore.ToString();
            return s.maxScore;
        }
    }
}
