using Lucene.Net.Search;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace EduSearch_Information_System
{
    public class NewSimilarity : DefaultSimilarity
    {

        /// <summary>Implemented as <c>sqrt(freq)</c>. </summary>
        public override float Tf(float freq)
        {
            //return (float)System.Math.Sqrt(freq);
            return 1;
        }

    }

}