﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int _time, int _numberOfQuestions)
        {
            Time = _time;
            NumberOfQuestions = _numberOfQuestions;
        }

        public abstract void ShowExam();

        public abstract void CreateListOfQuestions();
    }
}
