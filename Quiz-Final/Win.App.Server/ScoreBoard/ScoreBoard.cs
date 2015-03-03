using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Server.ScoreBoard
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void contestantScoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contestantScoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);

        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.ContestantScore' table. You can move, or remove it, as needed.
            this.contestantScoreTableAdapter.Fill(this.quizBeeDataSet.ContestantScore);

        }
    }
}
