using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNATranscriptionModule
{
	public static class RnaTranscription
	{
		public static string ToRna(string nucleotide)
		{
			Dictionary<char, char> rnaDictionary = new Dictionary<char, char>() {
			{'G','C'},
			{'C','G'},
			{'T','A'},
			{'A','U'}

			};

			StringBuilder rna = new StringBuilder();
			foreach (char c in nucleotide)
			{
				rna.Append(rnaDictionary[c]);
			}
			return rna.ToString();
		}
	}
}
