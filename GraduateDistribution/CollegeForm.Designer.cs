﻿namespace GraduateDistribution
{
    partial class CollegeForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxGraduateSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonGraduateDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonGraduateEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonGraduateAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewGraduate = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonGroupDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonGroupEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonGroupAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonSpecialtyDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonSpecialtyEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonSpecialtyAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewSpecialty = new System.Windows.Forms.DataGridView();
            this.metroTileRefresh = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraduate)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialty)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 364);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroTextBoxGraduateSearch);
            this.metroTabPage1.Controls.Add(this.metroButtonGraduateDelete);
            this.metroTabPage1.Controls.Add(this.metroButtonGraduateEdit);
            this.metroTabPage1.Controls.Add(this.metroButtonGraduateAdd);
            this.metroTabPage1.Controls.Add(this.dataGridViewGraduate);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 325);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Выпускники";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(376, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Поиск:";
            // 
            // metroTextBoxGraduateSearch
            // 
            this.metroTextBoxGraduateSearch.BackColor = System.Drawing.Color.White;
            this.metroTextBoxGraduateSearch.Location = new System.Drawing.Point(447, 3);
            this.metroTextBoxGraduateSearch.Name = "metroTextBoxGraduateSearch";
            this.metroTextBoxGraduateSearch.Size = new System.Drawing.Size(296, 23);
            this.metroTextBoxGraduateSearch.TabIndex = 10;
            this.metroTextBoxGraduateSearch.TextChanged += new System.EventHandler(this.metroTextBoxGraduateSearch_TextChanged);
            // 
            // metroButtonGraduateDelete
            // 
            this.metroButtonGraduateDelete.Location = new System.Drawing.Point(507, 289);
            this.metroButtonGraduateDelete.Name = "metroButtonGraduateDelete";
            this.metroButtonGraduateDelete.Size = new System.Drawing.Size(239, 33);
            this.metroButtonGraduateDelete.TabIndex = 9;
            this.metroButtonGraduateDelete.Text = "Удалить";
            this.metroButtonGraduateDelete.Click += new System.EventHandler(this.metroButtonGraduateDelete_Click);
            // 
            // metroButtonGraduateEdit
            // 
            this.metroButtonGraduateEdit.Location = new System.Drawing.Point(248, 289);
            this.metroButtonGraduateEdit.Name = "metroButtonGraduateEdit";
            this.metroButtonGraduateEdit.Size = new System.Drawing.Size(253, 33);
            this.metroButtonGraduateEdit.TabIndex = 8;
            this.metroButtonGraduateEdit.Text = "Редактировать";
            this.metroButtonGraduateEdit.Click += new System.EventHandler(this.metroButtonGraduateEdit_Click);
            // 
            // metroButtonGraduateAdd
            // 
            this.metroButtonGraduateAdd.Location = new System.Drawing.Point(3, 289);
            this.metroButtonGraduateAdd.Name = "metroButtonGraduateAdd";
            this.metroButtonGraduateAdd.Size = new System.Drawing.Size(239, 33);
            this.metroButtonGraduateAdd.TabIndex = 7;
            this.metroButtonGraduateAdd.Text = "Добавить";
            this.metroButtonGraduateAdd.Click += new System.EventHandler(this.metroButtonGraduateAdd_Click);
            // 
            // dataGridViewGraduate
            // 
            this.dataGridViewGraduate.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGraduate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraduate.GridColor = System.Drawing.Color.White;
            this.dataGridViewGraduate.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewGraduate.Name = "dataGridViewGraduate";
            this.dataGridViewGraduate.Size = new System.Drawing.Size(746, 254);
            this.dataGridViewGraduate.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonGroupDelete);
            this.metroTabPage2.Controls.Add(this.metroButtonGroupEdit);
            this.metroTabPage2.Controls.Add(this.metroButtonGroupAdd);
            this.metroTabPage2.Controls.Add(this.dataGridViewGroup);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 325);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Группы";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButtonGroupDelete
            // 
            this.metroButtonGroupDelete.Location = new System.Drawing.Point(507, 289);
            this.metroButtonGroupDelete.Name = "metroButtonGroupDelete";
            this.metroButtonGroupDelete.Size = new System.Drawing.Size(239, 33);
            this.metroButtonGroupDelete.TabIndex = 5;
            this.metroButtonGroupDelete.Text = "Удалить";
            this.metroButtonGroupDelete.Click += new System.EventHandler(this.metroButtonGroupDelete_Click);
            // 
            // metroButtonGroupEdit
            // 
            this.metroButtonGroupEdit.Location = new System.Drawing.Point(248, 289);
            this.metroButtonGroupEdit.Name = "metroButtonGroupEdit";
            this.metroButtonGroupEdit.Size = new System.Drawing.Size(253, 33);
            this.metroButtonGroupEdit.TabIndex = 4;
            this.metroButtonGroupEdit.Text = "Редактировать";
            this.metroButtonGroupEdit.Click += new System.EventHandler(this.metroButtonGroupEdit_Click);
            // 
            // metroButtonGroupAdd
            // 
            this.metroButtonGroupAdd.Location = new System.Drawing.Point(0, 289);
            this.metroButtonGroupAdd.Name = "metroButtonGroupAdd";
            this.metroButtonGroupAdd.Size = new System.Drawing.Size(242, 33);
            this.metroButtonGroupAdd.TabIndex = 3;
            this.metroButtonGroupAdd.Text = "Добавить";
            this.metroButtonGroupAdd.Click += new System.EventHandler(this.metroButtonGroupAdd_Click);
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.GridColor = System.Drawing.Color.White;
            this.dataGridViewGroup.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.Size = new System.Drawing.Size(746, 280);
            this.dataGridViewGroup.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButtonSpecialtyDelete);
            this.metroTabPage3.Controls.Add(this.metroButtonSpecialtyEdit);
            this.metroTabPage3.Controls.Add(this.metroButtonSpecialtyAdd);
            this.metroTabPage3.Controls.Add(this.dataGridViewSpecialty);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(746, 325);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Специальности";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroButtonSpecialtyDelete
            // 
            this.metroButtonSpecialtyDelete.Location = new System.Drawing.Point(504, 289);
            this.metroButtonSpecialtyDelete.Name = "metroButtonSpecialtyDelete";
            this.metroButtonSpecialtyDelete.Size = new System.Drawing.Size(239, 33);
            this.metroButtonSpecialtyDelete.TabIndex = 5;
            this.metroButtonSpecialtyDelete.Text = "Удалить";
            this.metroButtonSpecialtyDelete.Click += new System.EventHandler(this.metroButtonSpecialtyDelete_Click);
            // 
            // metroButtonSpecialtyEdit
            // 
            this.metroButtonSpecialtyEdit.Location = new System.Drawing.Point(248, 289);
            this.metroButtonSpecialtyEdit.Name = "metroButtonSpecialtyEdit";
            this.metroButtonSpecialtyEdit.Size = new System.Drawing.Size(250, 33);
            this.metroButtonSpecialtyEdit.TabIndex = 4;
            this.metroButtonSpecialtyEdit.Text = "Редактировать";
            this.metroButtonSpecialtyEdit.Click += new System.EventHandler(this.metroButtonSpecialtyEdit_Click);
            // 
            // metroButtonSpecialtyAdd
            // 
            this.metroButtonSpecialtyAdd.Location = new System.Drawing.Point(3, 289);
            this.metroButtonSpecialtyAdd.Name = "metroButtonSpecialtyAdd";
            this.metroButtonSpecialtyAdd.Size = new System.Drawing.Size(239, 33);
            this.metroButtonSpecialtyAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonSpecialtyAdd.TabIndex = 3;
            this.metroButtonSpecialtyAdd.Text = "Добавить";
            this.metroButtonSpecialtyAdd.Click += new System.EventHandler(this.metroButtonSpecialtyAdd_Click);
            // 
            // dataGridViewSpecialty
            // 
            this.dataGridViewSpecialty.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSpecialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecialty.GridColor = System.Drawing.Color.White;
            this.dataGridViewSpecialty.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSpecialty.Name = "dataGridViewSpecialty";
            this.dataGridViewSpecialty.Size = new System.Drawing.Size(740, 280);
            this.dataGridViewSpecialty.TabIndex = 2;
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(696, 34);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(81, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileRefresh.TabIndex = 1;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // CollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTileRefresh);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "CollegeForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Колледж";
            this.Load += new System.EventHandler(this.CollegeForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraduate)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButtonSpecialtyDelete;
        private MetroFramework.Controls.MetroButton metroButtonSpecialtyEdit;
        private MetroFramework.Controls.MetroButton metroButtonSpecialtyAdd;
        private System.Windows.Forms.DataGridView dataGridViewSpecialty;
        private MetroFramework.Controls.MetroButton metroButtonGroupDelete;
        private MetroFramework.Controls.MetroButton metroButtonGroupEdit;
        private MetroFramework.Controls.MetroButton metroButtonGroupAdd;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGraduateSearch;
        private MetroFramework.Controls.MetroButton metroButtonGraduateDelete;
        private MetroFramework.Controls.MetroButton metroButtonGraduateEdit;
        private MetroFramework.Controls.MetroButton metroButtonGraduateAdd;
        private System.Windows.Forms.DataGridView dataGridViewGraduate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTileRefresh;
    }
}