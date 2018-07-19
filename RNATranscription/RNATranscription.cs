using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
			String str ="";
			for (int i = 0; i < nucleotide.Length; i++)
			{
				if (nucleotide[i].Equals('G'))
				{
					str += 'C';
				}
				else if (nucleotide[i].Equals('C'))
				{
					str += 'G';
				}
				else if (nucleotide[i].Equals('T'))
				{
					str += 'A';
				}
				else if (nucleotide[i].Equals('A'))
				{
					str += 'U';
				}
			}
			return str;
				
        }
    }
}
