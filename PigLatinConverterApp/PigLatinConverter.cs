using System;
namespace PigLatinConverterApp
{
    /*****************************
     * PigLatinConverter
     * Version 0.1 - 7/6/17
     * Developer: Jeff Peterson
     * 
     * Takes a string input, then converts and returns a string with words
     * converted into Pig Latin (first letter of each word is moved to the end
     * of the word and "ay" added to the end of it).
     * ***************************/
    public class PigLatinConverter
    {
        // Private data members
        private string convertedMessage;
        private string[] words;
        private char[] delimiters = { ' ', '.', '-', '\t', ':', ',', '\'', '!', ';' };

        // Public constants

        // Default constructor
        public PigLatinConverter()
        {
        }

        // Properties
        public string ConvertedMessage
        {
            // This is a read-only property
            get {
                return convertedMessage;
            }
        }

        // Methods
        public string Convert(string message)
        {
            // Takes the input message and converts it to Pig Latin.

            // Lower the case of the entire message.
            message = message.ToLower();

            // Sets up the word array and fills it with the words of the message
            words = message.Split(delimiters);

            // For each word, move the first letter and add "ay" to it
            for (int i = 0; i < words.Length; i++)
            {
                // If the string is not empty, proceed
                if (words[i] != "")
                {
					// Copy the first character to a temp buffer.
					char tempChar = words[i][0];

					// Copy the remaining word into a temp string
					string buffer = words[i].TrimStart(tempChar);

					// Append the letter and "ay" to the word
					buffer += tempChar + "ay";

					// If this is the first word, capitalize the first letter.
					if (i == 0)
					{
						if (buffer.Length > 1)
						{
							buffer = char.ToUpper(buffer[0]) + buffer.Substring(1);
						}
						else
						{
							buffer.ToUpper();
						}
					}

					// Now place the converted word back into the array.
					words[i] = buffer;
				}
			}

            // All of the words have been converted. Rebuild the sentence!
            for (int i = 0; i < words.Length; i++)
            {
				convertedMessage += words[i];

                if (i != words.GetUpperBound(0) && words[i] != "")
                {
                    // This isn't the last word, so place a space in the message
                    convertedMessage += " ";
                }
            }
            return convertedMessage;
        }
    }
}
