using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemorizationAssistant.KeepOfWords
{
    /// <summary>
    /// Хранитель слов.
    /// Соддержит 
    /// </summary>
    [Serializable]
    public class KeeperOfWords
    {
        /// <summary>
        ///  Список иностранных слов и их переводов.
        /// </summary>
        public List<PairWords> pairsWords = new List<PairWords>();


        #region Поиск

        /// <summary>
        /// Проверить, имеется ли уже такая пара.
        /// </summary>
        /// <param name="pair">Пара для пароверки.</param>
        /// <returns>true, если имеется.</returns>
        private bool ContainsPair(PairWords pair)
        {
            for(int i=0;i< this.pairsWords.Count;i++)
            {
                if (this.pairsWords[i] == pair)
                    return true;
            }
            return false;
        }

        #endregion

        /// <summary>
        /// Добавить слово и его перевод к хранителю.
        /// </summary>
        /// <param name="englishWord">Иностранное слово.</param>
        /// <param name="russianWord">Его перевод.</param>
        public void Add(String englishWord, String russianWord)
        {
            PairWords newPairWords = new PairWords(englishWord, russianWord);
            if (!ContainsPair(newPairWords))
            {
                this.pairsWords.Add(newPairWords);
            }
        }

    }
}
