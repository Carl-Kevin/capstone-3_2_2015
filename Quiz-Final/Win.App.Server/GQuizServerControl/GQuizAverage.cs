﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Model;
using Microsoft.AspNet.SignalR;

namespace Win.App.Server.GQuizServerControl
{
    public partial class GQuizAverage : Form
    {
        public GQuizAverage()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void GQuizAverage_Load(object sender, EventArgs e)
        {
            SetupQuiz();
        }

        private IHubContext _hubContext;
        public IHubContext HubContext
        {
            get
            {
                if (_hubContext == null)
                {
                    _hubContext = GlobalHost.ConnectionManager.GetHubContext<QuizHub>();
                }

                return _hubContext;
            }
        }

        private QuestionManager _questionManager;
        public QuestionManager QuestionManager
        {
            get
            {
                if (_questionManager == null)
                {
                    _questionManager = new QuestionManager();
                }

                return _questionManager;
            }
        }

        private ScoreManager _scoreManager;
        public ScoreManager ScoreManager
        {
            get
            {
                if (_scoreManager == null)
                {
                    _scoreManager = new ScoreManager();
                }

                return _scoreManager;
            }
            set { _scoreManager = value; }
        }



        public void WriteToLog(string logMessage)
        {
            if (listView1.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToLog(logMessage)
                ));
                return;
            }
            listView1.Items.Add(logMessage);
        }


        public void UpdateAndReloadScore(string userName, int pointsAdded)
        {
            ScoreManager.UpdateScore(userName, pointsAdded);
            ContestantScoreDataGrid.DataSource = ScoreManager.GetGContestantScores();
        }

        private void SetupQuiz()
        {
            AverageDataGrid.DataSource = QuestionManager.GetGQuizByDifficulty(2);
            ContestantScoreDataGrid.DataSource = ScoreManager.GetGContestantScores();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;
            var selectedIndex = tabControl.SelectedIndex + 2;
            switch (selectedIndex)
            {
                case 1:
                    //EasyDataGrid.DataSource = QuestionManager.GetQuizL1ByDifficulty(selectedIndex);
                    break;
                case 2:
                    AverageDataGrid.DataSource = QuestionManager.GetGQuizByDifficulty(selectedIndex);
                    break;
                case 3:
                    //TODO: Bind the other difficulty level grid here
                    //DifficultDataGrid.DataSource = QuestionManager.GetQuizL1ByDifficulty(selectedIndex);
                    break;
            }

        }


        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null) return;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var quiz = grid.Rows[e.RowIndex].DataBoundItem as GQuiz;
                HubContext.Clients.All.DisplayQuestion(quiz);
            }

        }
    }
}
