using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayHoc
{
    internal class SimilarityMatrics
    {
       
        #region Cosine Similarity
        public static float FindCosineSimilarity(float[] vecA, float[] vecB)
        {
            var dotProduct = DotProduct(vecA, vecB);
            var magnitudeOfA = Magnitude(vecA);
            var magnitudeOfB = Magnitude(vecB);
            float result = dotProduct/(magnitudeOfA*magnitudeOfB);
            if (float.IsNaN(result))
                return 0;
            else
                return (float) result;
        }

        #endregion

        public static float DotProduct(float[] vecA, float[] vecB)
        {

            float dotProduct = 0;
            for (var i = 0; i < vecA.Length; i++)
            {
                dotProduct += (vecA[i]*vecB[i]);
            }

            return dotProduct;
        }

        
        public static float Magnitude(float[] vector)
        {
            return (float) Math.Sqrt(DotProduct(vector, vector));
        }
    }
}
