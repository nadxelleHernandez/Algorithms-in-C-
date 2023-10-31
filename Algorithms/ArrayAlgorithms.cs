using System.Collections;

namespace Algorithms {
    class ArrayAlgorithms {
        public static int[] petriPropagation(int []petri) {
            if(petri == null || petri.Length==0) {
                Console.WriteLine("ERROR: Petri array provided was empty or null");
                return null;
            }

            Stack <int> biggest = new Stack<int>();
            int last = petri.Length -1;
            biggest.Push(petri[last]);
            petri[last] = -1;
            for(int i=last-1; i>=0; i--) {
                int top = biggest.Peek();
                biggest.Push(petri[i]);
                if(petri[i] < top) {
                    petri[i] = top;
                } else {
                    while(biggest.Count>0 && petri[i] >= biggest.Peek()) {
                        biggest.Pop();
                    }
                    if (biggest.Count == 0) {
                        biggest.Push(petri[i]);
                        petri[i] = -1;
                    } else {
                        top = biggest.Peek();
                        biggest.Push(petri[i]);
                        petri[i] =top;
                    }
                }
            }

            return petri;
        }
    }
}