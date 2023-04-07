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
        List<string> _definitions=new List<string>();
        public MainForm()
        {
            _wordService = InstanceFactory.GetInstance<IWordService>();
            InitializeComponent();
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
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            _definitions.Clear();
            nameDalTextBox.Text = result.Data.Name;
            translationDalTextBox.Text = result.Data.Translation;
            var wordInfo = result.Data.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < wordInfo.Length; i++)
            {
                var data = wordInfo[i].GetValue(result.Data);
                if (data==null)
                    break;
                _definitions.Add(data.ToString());
            }
            wordScroller.Maximum = _definitions.Count();
            definitionDalTextBox.Text = _definitions[(int)wordScroller.Value-1];
        }
        private void wordScroller_ValueChanged(object sender, EventArgs e)
        {
            definitionDalTextBox.Text= _definitions[(int)wordScroller.Value - 1];
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            var result = _wordService.GetWordByName(searchTextBox.Text);
            if (!result.Success)
                MessageBox.Show(result.Message);
            else
            {
                UpdateForm form = new UpdateForm(result.Data);
                form.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = _wordService.GetWordByName(searchTextBox.Text);
            if (!result.Success)
                MessageBox.Show(result.Message);
            else
            {
                var deleteResult = _wordService.Delete(result.Data);
                MessageBox.Show(deleteResult.Message);
            }
        }
    }
}
