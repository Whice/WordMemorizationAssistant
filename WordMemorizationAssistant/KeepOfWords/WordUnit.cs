using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemorizationAssistant.KeepOfWords
{
    [Serializable]
    /// <summary>
    /// Единица - слово. Образует пару: слово и его перевод. Т.к. у каждого слова может быть несколько переводов, то указывает на все переводы. 
    /// </summary>
    public class WordUnit
    {
        /// <summary>
        /// Слдово.
        /// </summary>
        public String word;
        /// <summary>
        /// Список переводов слова.
        /// </summary>
        public List<WordUnit> translates;

        public WordUnit(String word, WordUnit translate = null)
        {
            this.word = word;
            this.translates = new List<WordUnit>();
            if(translate!=null)
            {
                this.translates.Add(translate);
            }
        }

        public override bool Equals(object obj)
        {
            if(obj is WordUnit wordUnit)
            {
                return this.word == wordUnit.word;
            }
            return false;
        }
        public static bool operator ==(WordUnit l, WordUnit r)
        {
            return l.Equals(r);
        }
        public static bool operator !=(WordUnit l, WordUnit r)
        {
            return !l.Equals(r);
        }

    }
}
