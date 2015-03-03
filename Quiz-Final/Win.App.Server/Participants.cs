using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Server
{
    public partial class Participants : Form
    {
        public Participants()
        {
            InitializeComponent();
        }

        private void participantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);

        }

        private void Participants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.Participants' table. You can move, or remove it, as needed.
            this.participantsTableAdapter.Fill(this.quizBeeDataSet.Participants);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
