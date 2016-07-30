using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayHoc
{

    class VectorSpaceModel
    {
        private static HashSet<string> distinctTerms;
        private static List<string> documentCollection;
        public static List<DocumentVector> ProcessDocumentCollection(DocumentCollection collection)
        {

            distinctTerms = new HashSet<string>();
            documentCollection = collection.DocumentList;
           
            foreach (string documentContent in collection.DocumentList)
            {
                foreach (string term in documentContent.Split(' '))
                {
                        distinctTerms.Add(term);
                }
            }
            
            List<DocumentVector> documentVectorSpace = new List<DocumentVector>();
            DocumentVector _documentVector;
            //--------------------------------------------------------- easier to watch :))
            float[] space;
            foreach (string document in documentCollection)
            {
                int count = 0;
                space = new float[distinctTerms.Count];
                foreach (string term in distinctTerms)
                {
                    space[count] = FindTFIDF(document, term);
                    count++;
                }
                _documentVector = new DocumentVector();
                _documentVector.Content = document;
                _documentVector.VectorSpace = space;
                documentVectorSpace.Add(_documentVector);

            }

            return documentVectorSpace;

        }
        #region Calculate TF-IDF

        
        private static float FindTFIDF(string document, string term)
        {
            float tf = FindTermFrequency(document, term);
            float idf = FindInverseDocumentFrequency(term);
            return tf * idf;
        }

        private static float FindTermFrequency(string document, string term)
        {
            int count = 0;
            foreach (string terms in document.ToUpper().Split(' '))
            {
                if (term.ToUpper() == terms)
                {
                    count++;
                }
            }

           
            return (float)((float)count / (float)(document.Split(' ').Count()));
        }


        private static float FindInverseDocumentFrequency(string term)
        {
           
            int count = 0;
            foreach (string document in documentCollection)
            {
                if (document.ToUpper().Split(' ').Contains(term.ToUpper()))
                {
                    count++;
                }

            }
            
            return (float)Math.Log((float)count/3);// avoid 

        }
        #endregion
    }
}
