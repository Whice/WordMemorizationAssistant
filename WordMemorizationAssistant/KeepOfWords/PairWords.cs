using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemorizationAssistant.KeepOfWords
{
    /// <summary>
    /// Пара слов для учебы.
    /// </summary>
    [Serializable]
    public class PairWords
    {
        /// <summary>
        /// Инстранное слово.
        /// </summary>
        public String englishWord;
        /// <summary>
        /// Перевод.
        /// </summary>
        public String russianWord;
        /// <summary>
        /// Процент выученности.
        /// </summary>
        public int learningPercentage;

        /// <summary>
        /// Создать пару.
        /// </summary>
        /// <param name="englishWord">Инстранное слово.</param>
        /// <param name="russianWord">Перевод.</param>
        public PairWords(String englishWord, String russianWord)
        {
            this.englishWord = englishWord;
            this.russianWord = russianWord;

            learningPercentage = 0;
        }

        /// <summary>
        /// Сравнивает значения иностранного слова и его перевода.
        /// </summary>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is PairWords pair)
            {
                if(pair.englishWord==this.englishWord||
                    pair.russianWord==this.russianWord)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Сравнивает значения иностранного слова и его перевода.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool operator ==(PairWords l, PairWords r)
        {
            return l.Equals(r);
        }
        /// <summary>
        /// Сравнивает значения иностранного слова и его перевода.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool operator !=(PairWords l, PairWords r)
        {
            return !l.Equals(r);
        }

        /// <summary>
        /// Сравнивает процент выученности пар.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool operator <(PairWords l, PairWords r)
        {
            return l.learningPercentage < r.learningPercentage;
        }
        /// <summary>
        /// Сравнивает процент выученности пар.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool operator >(PairWords l, PairWords r)
        {
            return l.learningPercentage > r.learningPercentage;
        }

    }
}
