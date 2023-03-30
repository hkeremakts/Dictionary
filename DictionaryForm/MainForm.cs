using Business.Abstract;
using Business.Concrete;
using Business.Constant;
using Business.DependencyResolvers.Autofac;
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
        public MainForm()
        {
            _wordService = InstanceFactory.GetInstance<IWordService>();
            InitializeComponent();
            wordScroller.Maximum=_definitions.Length;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(searchTextBox.Text);
            form.Show();
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
            bool flag = false;
            foreach (var item in _definitions)
            {
                if (item!=null)
                    flag = true;
            }
            if (!flag)
                wordScroller.Value = 1;
            else if (_definitions[(int)wordScroller.Value-1].Length<1)
                wordScroller.Value--;
            else
                definitionDalTextBox.Text = _definitions[(int)wordScroller.Value - 1];
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            var word = _wordService.GetWordByName(searchTextBox.Text);
            UpdateForm form = new UpdateForm(word.Data);
            form.Show();
        }
    }
}
