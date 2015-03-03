using System.Collections.Generic;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class QuestionManager
    {

        private QuizBeeEntities _context;
        private QuizBeeEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new QuizBeeEntities(); 
                }

                return _context;
            }
            set { _context = value; }
        }


        /// <summary>
        /// Gets the quizes by difficulty.
        /// </summary>
        /// <param name="difficultyLevel">The difficulty level.</param>
        /// <returns></returns>
        public List<QuizL1> GetQuizL1ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL1.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<QuizL2> GetQuizL2ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL2.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<QuizL3> GetQuizL3ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL3.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<Clincher> GetQClincherByDifficulty(int difficultyLevel)
        {
            return Context.Clinchers.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<GQuiz> GetGQuizByDifficulty(int difficultyLevel)
        {
            return Context.GQuizs.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }
    }
}