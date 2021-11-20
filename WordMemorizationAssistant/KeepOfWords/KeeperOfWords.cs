using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemorizationAssistant.KeepOfWords
{
    [Serializable]
    public class KeeperOfWords
    {
        public List<WordUnit> englishWords = new List<WordUnit>();
        public List<WordUnit> russianWords = new List<WordUnit>();


        #region Поиск

       /// <summary>
       /// Ищет единицу слова в списке.
       /// </summary>
       /// <param name="unit"></param>
       /// <param name="list"></param>
       /// <returns>Номер единицы слова, если находит. -1, если не находит.</returns>
        private static int FindInList(WordUnit unit, List<WordUnit> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                if (list[i] == unit)
                    return i;
            }
            return -1;
        }

        #endregion

        /// <summary>
        /// Добавить слово и его перевод к хранителю.
        /// </summary>
        /// <param name="englishWord">Иностранное слово.</param>
        /// <param name="russianWord">Его перевод.</param>
        public void Add(WordUnit englishWord, WordUnit russianWord)
        {
            //Просмотр наличия таких слов в списках
            //
            if(this.englishWords.Contains(englishWord))
            {
                int numberWordInList = FindInList(englishWord, this.englishWords);
                englishWord = this.englishWords[numberWordInList];
            }
            else
            {
                this.englishWords.Add(englishWord);
            }

            if(this.russianWords.Contains(russianWord))
            {
                int numberWordInList = FindInList(russianWord, this.russianWords);
                russianWord = this.russianWords[numberWordInList];
            }
            else
            {
                this.russianWords.Add(russianWord);
            }

            //Просмотр наличия переводов у асмих слов друг друга
            if(!englishWord.translates.Contains(russianWord))
            {
                englishWord.translates.Add(russianWord);
            }
            if(!russianWord.translates.Contains(englishWord))
            {
                russianWord.translates.Add(englishWord);
            }
        }

    }
}
