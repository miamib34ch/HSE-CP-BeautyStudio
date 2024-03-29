﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class Procedure : Form
    {

        string idVisiting;
        Visiting visiting;

        public Procedure(string idVisiting, Visiting visiting)
        {
            InitializeComponent();
            this.процедуры_клиентаTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_клиента);
            this.процедуры_в_посещенииTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_в_посещении);
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet.Пигменты);
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet.Процедура);
            процедуры_клиентаBindingSource.AddNew();
            процедуры_в_посещенииBindingSource.AddNew();
            this.idVisiting = idVisiting;
            this.visiting = visiting;
        }

        private void Procedure_Load(object sender, EventArgs e)
        {
            id_посещенияTextBox.Text = idVisiting;
            id_процедуры_клиентаTextBox.Text = textBox1.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox2.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                процедуры_клиентаBindingSource.EndEdit();
                процедуры_клиентаTableAdapter.Update(this.beautyStudioDataSet.Процедуры_клиента);
                процедуры_в_посещенииBindingSource.EndEdit();
                процедуры_в_посещенииTableAdapter.Update(this.beautyStudioDataSet.Процедуры_в_посещении);
                Close();
            }
            else
            {
                MessageBox.Show("Выберите процедуру и пигмент!");
                comboBox2.SelectedIndex = 0;
                comboBox2.SelectedItem = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Procedure_FormClosing(object sender, FormClosingEventArgs e)
        {
            visiting.Enabled = true;
        }
    }
}
