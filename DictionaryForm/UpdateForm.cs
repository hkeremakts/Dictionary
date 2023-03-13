using Business.Abstract;
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
        int i = 1;
        IWordService _wordService;
        Word _word;
        public RichTextBox[] _definitionTextBoxArray = new RichTextBox[5];
        public UpdateForm(IWordService wordService,Word word)
        {
            _wordService = wordService;
            InitializeComponent();
            _word = word;
            nameTextBox.Text=word.Name;
            translationTextBox.Text = word.Translation;
            _definitionTextBoxArray[0] = definitionTextBox1;
            _definitionTextBoxArray[1] = definitionTextBox2;
            _definitionTextBoxArray[2] = definitionTextBox3;
            _definitionTextBoxArray[3] = definitionTextBox4;
            _definitionTextBoxArray[4] = definitionTextBox5;
            var wordInfo = word.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                if (wordInfo[i].GetValue(word) == null)
                    break;
                _definitionTextBoxArray[i].Text = wordInfo[i].GetValue(word).ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Word updatedWord = new Word()
            {
                Name = nameTextBox.Text,
                Translation = translationTextBox.Text
            };
            var wordInfo= updatedWord.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                wordInfo[i].SetValue(updatedWord, _definitionTextBoxArray[i].Text);
            }
            var result = _wordService.Update(_word,updatedWord);
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
