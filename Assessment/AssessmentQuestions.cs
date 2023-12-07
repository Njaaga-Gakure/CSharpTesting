

namespace Assessment
{
    public class AssessmentQuestions
    {
        public int ReverseInteger(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) {
                throw new ArgumentNullException("Value cannot be null");
            }
            bool isValidNumber = int.TryParse(number, out int result);
            if (isValidNumber)
            { 
                char[] numberTocharArray = number.ToCharArray();
                Array.Reverse(numberTocharArray);
                var charArrayToString = new string(numberTocharArray);
                if (number.Contains('-'))
                {
                    return int.Parse($"-{charArrayToString.TrimStart('0').TrimEnd('-')}");
                }
                return int.Parse($"{charArrayToString.TrimStart('0')}");
            }
            throw new FormatException($"{number} is not a valid integer");
        }

        public string CapitalizeString(string text)
        {

            string[] textList = text.Split(" ");


            for (int i = 0; i < textList.Length; i++)
            {
                string tempString = "";
                tempString += char.ToUpper(textList[i][0]) + textList[i].Substring(1);
                textList[i] = tempString;
            }
            return string.Join(" ", textList);
        }

        public bool CheckIfPalindrome(string text)
        {
            bool isPalindrome = true;
            int j = text.Count() - 1;

            for (int i = 0; i < j; i++, j--)
            {
                if (char.ToLower(text[i]) != char.ToLower(text[j]))
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }

        public int CountVowels(string text)
        {
            int vowelCount = 0;
            foreach (var character in text.ToLower())
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        public char MostApperingCharacter(string text)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (var character in text.ToLower())
            {
                if (characterCount.ContainsKey(character))
                {
                    characterCount[character]++;
                    continue;
                }
                characterCount[character] = 1;
            }
            return characterCount.Aggregate((x, y) => x.Value >= y.Value ? x : y).Key;
        }

        public int[][] CreateChunkedArray(int[] array, int chunkSize)
        {
            int chunkCount = (int) Math.Ceiling((decimal) array.Length / chunkSize);
            int[][] matrix = new int[chunkCount][];
            int k = 0;
            for (int i = 0; i < chunkCount; i++) {
                int chunkLength = Math.Min(chunkSize, array.Length - k);
                matrix[i] = new int[chunkLength];
                for (int j = 0; j < chunkLength; j++, k++) {
                    matrix[i][j] = array[k];
                }
            
            }
            return matrix;
        }
    }
}
