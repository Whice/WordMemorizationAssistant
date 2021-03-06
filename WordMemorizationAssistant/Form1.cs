using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordMemorizationAssistant
{
    public partial class FormWordMemorizationAssistant : Form
    {

        private List<KeyValuePair<String, String>> listOfWordAndTheirTranslate = new List<KeyValuePair<String, String>>();

        public FormWordMemorizationAssistant()
        {
            InitializeComponent();

            //Локализация
            {
                this.labelWordForTranslate.Text = "Слово для перевода";
                this.labelUserAnswer.Text = "Ваш ответ:";
                this.labelRightAnswer.Text = "Правильный ответ";
                this.buttonCheckNexWord.Text = "Проверить ответ";
                this.tabPageLearnWords.Text = "Обучение словам";


                this.labelInputEnglishWord.Text = "Ввести английское слово";
                this.labelInputTranslateWord.Text = "Ввести перевод слова";
                this.buttonAddWord.Text = "Добавить слово";
                this.tabPageAddWords.Text = "Добавление слов";

            }
        }

        #region Обучение словам

        private void buttonCheckNexWord_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Добавление новых слов

        private void buttonAddWord_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
