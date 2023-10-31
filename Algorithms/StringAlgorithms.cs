using System.Text;
using System;
using System.Dynamic;

namespace Algorithms {
class StringAlgorithms {
    private static int getWordsLen(string [] words) {
        int len = 0;
        for (int i=0; i<words.Length; i++) {
            len += words[i].Length;
        }
        len = len + words.Length - 1;
        return len;
    }
    public static string ReverseWords(string s) {
        s = s.Trim();
        string [] words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        int resultLen = s.Length-(s.Length - getWordsLen(words));
        string result = string.Create(resultLen, words, (newStr, words) =>
        {
            int k=0, i = 0, j = 0;
            for(i=words.Length-1; i >= 0; i--){
                for(j=0;j<words[i].Length;j++){
                    newStr[k] = words[i][j];
                    k++;
                }
                if(k<resultLen)
                    newStr[k] = ' ';
                    k++;
            }
        });
        return result.TrimEnd();
    }
    public static string ReverseString(string s) {
        int len = s.Length;
        string result = string.Create(len, s, (Span<char> strContent, string charArray) => {
            int middle = charArray.Length/2;
            for(int i=0; i<middle; i++) {
                strContent[i] = charArray[len-1+i];
            }
        });
        return result;
    }
}
}

