using System;

namespace RNATranscriptionModule
{
	public static class RnaTranscription
	{
		public static string ToRna(string nucleotide)
		{
			String rna = "";
			for (int i = 0; i < nucleotide.Length; i++)
			{
				if (nucleotide[i].Equals('G'))
				{
					rna += 'C';
				}
				else if (nucleotide[i].Equals('C'))
				{
					rna += 'G';
				}
				else if (nucleotide[i].Equals('T'))
				{
					rna += 'A';
				}
				else if (nucleotide[i].Equals('A'))
				{
					rna += 'U';
				}
			}
			return rna;

		}
	}
}
