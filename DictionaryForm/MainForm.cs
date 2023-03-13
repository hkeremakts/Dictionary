using Business.Abstract;
using Business.Concrete;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
using System.Xml.Linq;

namespace DictionaryForm
{
    public partial class MainForm : Form
    {
        IWordService _wordService;
        string[] _definitions=new string[5];
        public MainForm(IWordService wordService)
        {
            _wordService = wordService;
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(new WordManager(new EfWordDal()),searchTextBox.Text);
            form.Show();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string name = searchTextBox.Text;
            var result = _wordService.GetWordByName(name);
            nameDalTextBox.Text = result.Data.Name;
            translationDalTextBox.Text = result.Data.Translation;
            var wordInfo = result.Data.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                if (wordInfo[i].GetValue(result.Data) == null)
                    break;
                _definitions[i] = wordInfo[i].GetValue(result.Data).ToString();
            }
            definitionDalTextBox.Text = _definitions[(int)wordScroller.Value-1];
        }

        private void wordScroller_ValueChanged(object sender, EventArgs e)
        {
                if (wordScroller.Value < 1)
                    wordScroller.Value = 1;
                else if (wordScroller.Value > _definitions.Length)
                    wordScroller.Value = _definitions.Length - 1;
                else if (_definitions[(int)wordScroller.Value-1] == null&&wordScroller.Value!=1)
                    wordScroller.Value = wordScroller.Value - 1;
                else if (wordScroller.Value == 1) { }                  
                else
                    definitionDalTextBox.Text = _definitions[(int)wordScroller.Value - 1];
        }
        //public void ChangeDefinitionDalLabelTexts()
        //{
        //    definitionDalTextBox.Text = _definitions[(int)wordScroller.Value];


        //    //string name = searchTextBox.Text;
        //    //var result = _wordService.GetWordByName(name);
        //    //string[] definitions = new string[5];
        //    //if (result.Success && definitions.Length >= i)
        //    //{
        //    //    definitionDalTextBox.Text = definitions[i - 1];
        //    //}
        //    //else if (!result.Success)
        //    //    MessageBox.Show(result.Message);
        //    //else
        //    //    i--;
        //}

        private void definitionDalLabel_TextChanged(object sender, EventArgs e)
        {
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var word = _wordService.GetWordByName(searchTextBox.Text);
            UpdateForm form = new UpdateForm(new WordManager(new EfWordDal()), word.Data);
            form.Show();
        }
    }
}
