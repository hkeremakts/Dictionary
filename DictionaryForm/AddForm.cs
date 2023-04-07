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
        int shownDefinition = 1;
        IWordService _wordService;
        List<RichTextBox> _definitionTextBoxList = new List<RichTextBox>();
        public AddForm(string name)
        {
            _wordService = InstanceFactory.GetInstance<IWordService>();
            InitializeComponent();
            nameTextBox.Text = name;
            _definitionTextBoxList.Add(definitionTextBox1);
            _definitionTextBoxList.Add(definitionTextBox2);
            _definitionTextBoxList.Add(definitionTextBox3);
            _definitionTextBoxList.Add(definitionTextBox4);
            _definitionTextBoxList.Add(definitionTextBox5);
            for (int i = 1; i < _definitionTextBoxList.Count; i++)
                _definitionTextBoxList[i].Hide();
            definitionsScroller.Maximum = _definitionTextBoxList.Count;
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
                wordInfo[i].SetValue(word, _definitionTextBoxList[i].Text);
            }
            var result = _wordService.Add(word);
            if (!result.Success)
                MessageBox.Show(result.Message);
            else
                this.Close();
        }

        private void definitionsScroller_ValueChanged(object sender, EventArgs e)
        {
            _definitionTextBoxList[shownDefinition].Hide();
            _definitionTextBoxList[(int)definitionsScroller.Value - 1].Show();
            shownDefinition = (int)definitionsScroller.Value - 1;
        }
    }
}
