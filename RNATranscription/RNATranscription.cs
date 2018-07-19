using System;
using System.Collections.Generic;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, char> conversionToRNA = new Dictionary<char, char>();
            conversionToRNA.Add('G', 'C');
            conversionToRNA.Add('C', 'G');
            conversionToRNA.Add('T', 'A');
            conversionToRNA.Add('A', 'U');
            StringBuilder convertedRNA = new StringBuilder();
            for(int i=0;i<nucleotide.Length;i++)
            {
                convertedRNA.Append(conversionToRNA[nucleotide[i]]);
            }
            return convertedRNA.ToString();

        }
    }
}
