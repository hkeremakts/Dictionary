using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryForm
{
    public partial class AddForm : Form
    {
        int i = 1;
        IWordService _wordService;
        public RichTextBox[] _definitionTextBoxArray = new RichTextBox[5];
        public AddForm(string name)
        {
            _wordService = InstanceFactory.GetInstance<IWordService>();
            InitializeComponent();
            nameTextBox.Text = name;
            _definitionTextBoxArray[0] = definitionTextBox1;
            _definitionTextBoxArray[1] = definitionTextBox2;
            _definitionTextBoxArray[2] = definitionTextBox3;
            _definitionTextBoxArray[3] = definitionTextBox4;
            _definitionTextBoxArray[4] = definitionTextBox5;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Word word = new Word()
            {
                Name = nameTextBox.Text,
                Translation = translationTextBox.Text
            };
            var wordInfo= word.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                wordInfo[i].SetValue(word, _definitionTextBoxArray[i].Text);
            }
            var result = _wordService.Add(word);
            if (!result.Success)
                MessageBox.Show(result.Message);
            else
                this.Close();
        }

        private void definitionsScroller_ValueChanged(object sender, EventArgs e)
        {
            if (definitionsScroller.Value < 1)
                definitionsScroller.Value = 1;
            else if (definitionsScroller.Value > _definitionTextBoxArray.Length)
                definitionsScroller.Value = _definitionTextBoxArray.Length;
            for (int j = 1; j < _definitionTextBoxArray.Length+1; j++)
            {
                if (definitionsScroller.Value == j)
                {
                    _definitionTextBoxArray[j - 1].Show();
                    if (i == j - 1)
                        _definitionTextBoxArray[j - 2].Hide();
                    else if (i == j + 1)
                        _definitionTextBoxArray[j].Hide();
                    i = j;
                }
            }
        }
    }
}
