﻿namespace Win.App.Server
{
    partial class AddQuizClincher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questionNumberLabel;
            System.Windows.Forms.Label questionsLabel;
            System.Windows.Forms.Label option1Label;
            System.Windows.Forms.Label option2Label;
            System.Windows.Forms.Label option3Label;
            System.Windows.Forms.Label option4Label;
            System.Windows.Forms.Label timeFrameLabel;
            System.Windows.Forms.Label answerKeyLabel;
            System.Windows.Forms.Label difficultyLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuizClincher));
            this.quizBeeDataSet = new Win.App.Server.QuizBeeDataSet();
            this.clincherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clincherTableAdapter = new Win.App.Server.QuizBeeDataSetTableAdapters.ClincherTableAdapter();
            this.tableAdapterManager = new Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager();
            this.clincherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clincherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.clincherDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberTextBox = new System.Windows.Forms.TextBox();
            this.questionsTextBox = new System.Windows.Forms.TextBox();
            this.option1TextBox = new System.Windows.Forms.TextBox();
            this.option2TextBox = new System.Windows.Forms.TextBox();
            this.option3TextBox = new System.Windows.Forms.TextBox();
            this.option4TextBox = new System.Windows.Forms.TextBox();
            this.timeFrameTextBox = new System.Windows.Forms.TextBox();
            this.answerKeyTextBox = new System.Windows.Forms.TextBox();
            this.difficultyLevelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            questionNumberLabel = new System.Windows.Forms.Label();
            questionsLabel = new System.Windows.Forms.Label();
            option1Label = new System.Windows.Forms.Label();
            option2Label = new System.Windows.Forms.Label();
            option3Label = new System.Windows.Forms.Label();
            option4Label = new System.Windows.Forms.Label();
            timeFrameLabel = new System.Windows.Forms.Label();
            answerKeyLabel = new System.Windows.Forms.Label();
            difficultyLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clincherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clincherBindingNavigator)).BeginInit();
            this.clincherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clincherDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            questionNumberLabel.Location = new System.Drawing.Point(6, 27);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new System.Drawing.Size(158, 18);
            questionNumberLabel.TabIndex = 2;
            questionNumberLabel.Text = "Question Number:";
            // 
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            questionsLabel.Location = new System.Drawing.Point(91, 59);
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new System.Drawing.Size(98, 18);
            questionsLabel.TabIndex = 4;
            questionsLabel.Text = "Questions:";
            // 
            // option1Label
            // 
            option1Label.AutoSize = true;
            option1Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option1Label.Location = new System.Drawing.Point(162, 193);
            option1Label.Name = "option1Label";
            option1Label.Size = new System.Drawing.Size(80, 18);
            option1Label.TabIndex = 6;
            option1Label.Text = "Option1:";
            // 
            // option2Label
            // 
            option2Label.AutoSize = true;
            option2Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option2Label.Location = new System.Drawing.Point(162, 225);
            option2Label.Name = "option2Label";
            option2Label.Size = new System.Drawing.Size(80, 18);
            option2Label.TabIndex = 8;
            option2Label.Text = "Option2:";
            // 
            // option3Label
            // 
            option3Label.AutoSize = true;
            option3Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option3Label.Location = new System.Drawing.Point(162, 257);
            option3Label.Name = "option3Label";
            option3Label.Size = new System.Drawing.Size(80, 18);
            option3Label.TabIndex = 10;
            option3Label.Text = "Option3:";
            // 
            // option4Label
            // 
            option4Label.AutoSize = true;
            option4Label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            option4Label.Location = new System.Drawing.Point(162, 289);
            option4Label.Name = "option4Label";
            option4Label.Size = new System.Drawing.Size(80, 18);
            option4Label.TabIndex = 12;
            option4Label.Text = "Option4:";
            // 
            // timeFrameLabel
            // 
            timeFrameLabel.AutoSize = true;
            timeFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeFrameLabel.Location = new System.Drawing.Point(37, 34);
            timeFrameLabel.Name = "timeFrameLabel";
            timeFrameLabel.Size = new System.Drawing.Size(97, 20);
            timeFrameLabel.TabIndex = 14;
            timeFrameLabel.Text = "Time Frame:";
            // 
            // answerKeyLabel
            // 
            answerKeyLabel.AutoSize = true;
            answerKeyLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            answerKeyLabel.Location = new System.Drawing.Point(162, 321);
            answerKeyLabel.Name = "answerKeyLabel";
            answerKeyLabel.Size = new System.Drawing.Size(110, 18);
            answerKeyLabel.TabIndex = 16;
            answerKeyLabel.Text = "Answer Key:";
            // 
            // difficultyLevelLabel
            // 
            difficultyLevelLabel.AutoSize = true;
            difficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            difficultyLevelLabel.Location = new System.Drawing.Point(47, 18);
            difficultyLevelLabel.Name = "difficultyLevelLabel";
            difficultyLevelLabel.Size = new System.Drawing.Size(114, 20);
            difficultyLevelLabel.TabIndex = 18;
            difficultyLevelLabel.Text = "Difficulty Level:";
            // 
            // quizBeeDataSet
            // 
            this.quizBeeDataSet.DataSetName = "QuizBeeDataSet";
            this.quizBeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clincherBindingSource
            // 
            this.clincherBindingSource.DataMember = "Clincher";
            this.clincherBindingSource.DataSource = this.quizBeeDataSet;
            // 
            // clincherTableAdapter
            // 
            this.clincherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClincherTableAdapter = this.clincherTableAdapter;
            this.tableAdapterManager.ContestantScoreTableAdapter = null;
            this.tableAdapterManager.GContestantScoreTableAdapter = null;
            this.tableAdapterManager.GParticipantsTableAdapter = null;
            this.tableAdapterManager.GQuizTableAdapter = null;
            this.tableAdapterManager.ParticipantsTableAdapter = null;
            this.tableAdapterManager.QuizL1TableAdapter = null;
            this.tableAdapterManager.QuizL2TableAdapter = null;
            this.tableAdapterManager.QuizL3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Win.App.Server.QuizBeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clincherBindingNavigator
            // 
            this.clincherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clincherBindingNavigator.AutoSize = false;
            this.clincherBindingNavigator.BindingSource = this.clincherBindingSource;
            this.clincherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clincherBindingNavigator.DeleteItem = null;
            this.clincherBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.clincherBindingNavigator.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.clincherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.clincherBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.toolStripSeparator3,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.toolStripSeparator4,
            this.bindingNavigatorMoveLastItem});
            this.clincherBindingNavigator.Location = new System.Drawing.Point(367, 13);
            this.clincherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clincherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clincherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clincherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clincherBindingNavigator.Name = "clincherBindingNavigator";
            this.clincherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clincherBindingNavigator.Size = new System.Drawing.Size(562, 52);
            this.clincherBindingNavigator.TabIndex = 0;
            this.clincherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AutoSize = false;
            this.bindingNavigatorAddNewItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.BackgroundImage")));
            this.bindingNavigatorAddNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.AutoSize = false;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 63);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // clincherBindingNavigatorSaveItem
            // 
            this.clincherBindingNavigatorSaveItem.AutoSize = false;
            this.clincherBindingNavigatorSaveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clincherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clincherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clincherBindingNavigatorSaveItem.Image")));
            this.clincherBindingNavigatorSaveItem.Name = "clincherBindingNavigatorSaveItem";
            this.clincherBindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 46);
            this.clincherBindingNavigatorSaveItem.Text = "Save Data";
            this.clincherBindingNavigatorSaveItem.Click += new System.EventHandler(this.clincherBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoSize = false;
            this.bindingNavigatorDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 33);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(55, 46);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // clincherDataGridView
            // 
            this.clincherDataGridView.AutoGenerateColumns = false;
            this.clincherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clincherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clincherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clincherDataGridView.DataSource = this.clincherBindingSource;
            this.clincherDataGridView.Location = new System.Drawing.Point(22, 457);
            this.clincherDataGridView.Name = "clincherDataGridView";
            this.clincherDataGridView.Size = new System.Drawing.Size(944, 278);
            this.clincherDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "QuestionNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Questions";
            this.dataGridViewTextBoxColumn2.HeaderText = "Questions";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Option1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Option1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Option2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Option2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Option3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Option3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Option4";
            this.dataGridViewTextBoxColumn6.HeaderText = "Option4";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TimeFrame";
            this.dataGridViewTextBoxColumn7.HeaderText = "TimeFrame";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AnswerKey";
            this.dataGridViewTextBoxColumn8.HeaderText = "AnswerKey";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DifficultyLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "DifficultyLevel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // questionNumberTextBox
            // 
            this.questionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "QuestionNumber", true));
            this.questionNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberTextBox.Location = new System.Drawing.Point(168, 24);
            this.questionNumberTextBox.Name = "questionNumberTextBox";
            this.questionNumberTextBox.Size = new System.Drawing.Size(47, 26);
            this.questionNumberTextBox.TabIndex = 3;
            // 
            // questionsTextBox
            // 
            this.questionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "Questions", true));
            this.questionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsTextBox.Location = new System.Drawing.Point(95, 82);
            this.questionsTextBox.Multiline = true;
            this.questionsTextBox.Name = "questionsTextBox";
            this.questionsTextBox.Size = new System.Drawing.Size(752, 102);
            this.questionsTextBox.TabIndex = 5;
            // 
            // option1TextBox
            // 
            this.option1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "Option1", true));
            this.option1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1TextBox.Location = new System.Drawing.Point(285, 190);
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(441, 26);
            this.option1TextBox.TabIndex = 7;
            // 
            // option2TextBox
            // 
            this.option2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "Option2", true));
            this.option2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2TextBox.Location = new System.Drawing.Point(285, 222);
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(441, 26);
            this.option2TextBox.TabIndex = 9;
            // 
            // option3TextBox
            // 
            this.option3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "Option3", true));
            this.option3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3TextBox.Location = new System.Drawing.Point(285, 254);
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(441, 26);
            this.option3TextBox.TabIndex = 11;
            // 
            // option4TextBox
            // 
            this.option4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "Option4", true));
            this.option4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4TextBox.Location = new System.Drawing.Point(285, 286);
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(441, 26);
            this.option4TextBox.TabIndex = 13;
            // 
            // timeFrameTextBox
            // 
            this.timeFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "TimeFrame", true));
            this.timeFrameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameTextBox.Location = new System.Drawing.Point(135, 31);
            this.timeFrameTextBox.Name = "timeFrameTextBox";
            this.timeFrameTextBox.Size = new System.Drawing.Size(112, 26);
            this.timeFrameTextBox.TabIndex = 15;
            // 
            // answerKeyTextBox
            // 
            this.answerKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "AnswerKey", true));
            this.answerKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerKeyTextBox.Location = new System.Drawing.Point(285, 318);
            this.answerKeyTextBox.Name = "answerKeyTextBox";
            this.answerKeyTextBox.Size = new System.Drawing.Size(441, 26);
            this.answerKeyTextBox.TabIndex = 17;
            // 
            // difficultyLevelTextBox
            // 
            this.difficultyLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clincherBindingSource, "DifficultyLevel", true));
            this.difficultyLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevelTextBox.Location = new System.Drawing.Point(64, 41);
            this.difficultyLevelTextBox.Name = "difficultyLevelTextBox";
            this.difficultyLevelTextBox.Size = new System.Drawing.Size(86, 26);
            this.difficultyLevelTextBox.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answerKeyTextBox);
            this.groupBox1.Controls.Add(questionNumberLabel);
            this.groupBox1.Controls.Add(answerKeyLabel);
            this.groupBox1.Controls.Add(this.questionNumberTextBox);
            this.groupBox1.Controls.Add(this.option4TextBox);
            this.groupBox1.Controls.Add(questionsLabel);
            this.groupBox1.Controls.Add(option4Label);
            this.groupBox1.Controls.Add(this.questionsTextBox);
            this.groupBox1.Controls.Add(this.option3TextBox);
            this.groupBox1.Controls.Add(option1Label);
            this.groupBox1.Controls.Add(option3Label);
            this.groupBox1.Controls.Add(this.option1TextBox);
            this.groupBox1.Controls.Add(this.option2TextBox);
            this.groupBox1.Controls.Add(option2Label);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 373);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Questions / Choices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(timeFrameLabel);
            this.groupBox2.Controls.Add(this.timeFrameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(999, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 371);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time / Difficulty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "(SECONDS)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.difficultyLevelTextBox);
            this.panel1.Controls.Add(difficultyLevelLabel);
            this.panel1.Location = new System.Drawing.Point(41, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 230);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 133);
            this.label2.TabIndex = 24;
            this.label2.Text = "Set the Difficulty using the number:\r\n\r\n           1 - Easy\r\n           2 - Avera" +
    "ge\r\n           3 - Difficult";
            // 
            // AddQuizClincher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clincherDataGridView);
            this.Controls.Add(this.clincherBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddQuizClincher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Clincher Round Questions";
            this.Load += new System.EventHandler(this.AddQuizClincher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clincherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clincherBindingNavigator)).EndInit();
            this.clincherBindingNavigator.ResumeLayout(false);
            this.clincherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clincherDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuizBeeDataSet quizBeeDataSet;
        private System.Windows.Forms.BindingSource clincherBindingSource;
        private QuizBeeDataSetTableAdapters.ClincherTableAdapter clincherTableAdapter;
        private QuizBeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clincherBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton clincherBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clincherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox questionNumberTextBox;
        private System.Windows.Forms.TextBox questionsTextBox;
        private System.Windows.Forms.TextBox option1TextBox;
        private System.Windows.Forms.TextBox option2TextBox;
        private System.Windows.Forms.TextBox option3TextBox;
        private System.Windows.Forms.TextBox option4TextBox;
        private System.Windows.Forms.TextBox timeFrameTextBox;
        private System.Windows.Forms.TextBox answerKeyTextBox;
        private System.Windows.Forms.TextBox difficultyLevelTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}