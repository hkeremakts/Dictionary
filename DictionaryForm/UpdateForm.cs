using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Results;
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
    public partial class UpdateForm : Form
    {
        int shownDefinition = 0;
        IWordService _wordService;
        Word _word;
        List<RichTextBox> _definitionTextBoxList = new List<RichTextBox>();
        public UpdateForm(Word word)
        {
            _wordService = InstanceFactory.GetInstance<IWordService>();
            InitializeComponent();
            _word = word;
            nameTextBox.Text=word.Name;
            translationTextBox.Text = word.Translation;
            _definitionTextBoxList.Add(definitionTextBox1);
            _definitionTextBoxList.Add(definitionTextBox2);
            _definitionTextBoxList.Add(definitionTextBox3);
            _definitionTextBoxList.Add(definitionTextBox4);
            _definitionTextBoxList.Add(definitionTextBox5);
            for (int i = 1; i < _definitionTextBoxList.Count; i++)
                _definitionTextBoxList[i].Hide();
            definitionsScroller.Maximum = _definitionTextBoxList.Count;
            var wordInfo = word.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                if (wordInfo[i].GetValue(word) == null)
                    break;
                _definitionTextBoxList[i].Text = wordInfo[i].GetValue(word).ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Word updatedWord = new Word()
            {
                Id=_word.Id,
                Name = _word.Name,
                Translation = translationTextBox.Text
            };
            var wordInfo= updatedWord.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                wordInfo[i].SetValue(updatedWord, _definitionTextBoxList[i].Text);
            }
            var result = _wordService.Update(updatedWord);
            if (!result.Success)
                MessageBox.Show(result.Message);
            else
                this.Close();
        }

        private void definitionsScroller_ValueChanged(object sender, EventArgs e)
        {
            //if (definitionsScroller.Value < 1)
            //    definitionsScroller.Value = 1;
            //else if (definitionsScroller.Value > _definitionTextBoxList.Count)
            //    definitionsScroller.Value = _definitionTextBoxList.Count;
            //for (int j = 1; j < _definitionTextBoxList.Count+1; j++)
            //{
            //    if (definitionsScroller.Value == j)
            //    {
            //        _definitionTextBoxList[j - 1].Show();
            //        if (i == j - 1)
            //            _definitionTextBoxList[j - 2].Hide();
            //        else if (i == j + 1)
            //            _definitionTextBoxList[j].Hide();
            //        i = j;
            //    }
            //}
            _definitionTextBoxList[shownDefinition].Hide();
            _definitionTextBoxList[(int)definitionsScroller.Value - 1].Show();
            shownDefinition=(int)definitionsScroller.Value-1;
        }
    }
}
