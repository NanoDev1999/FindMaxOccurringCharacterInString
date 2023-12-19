
using System;
using System.Collections.Generic;




class Program
{

    /*
     * Complete the 'FindMaxOccurringCharacter' function below.
     *
     * The function is expected to return a CHARACTER.
     * The function accepts STRING input as parameter.
     */

    public static char FindMaxOccurringCharacter(string input)
    {

        Dictionary<char, int> characterToCountDictionary = new Dictionary<char, int>();
        
        for(int i = 0; i < input.Length; i++){
            
            // my first approach would be to use all the characters on a keyboard
            // the problem with that is that it's not going to handle emojis so doing something like
            // setting the index of all characters into an array
            // then setting the count of each into that array
            // like int[] characterCountArray = new int[1000]
            // the issue is that this takes care of 1000 symbols, but there could be more
            // I think there are even more than that.
            
            // second approach:
            // we need to use a dictionary
            // use the key value pair to keep a count of how many times it occurs.
            
            char characterToCheck = input[i];
            
            if(characterToCountDictionary.ContainsKey(characterToCheck)){
                characterToCountDictionary[characterToCheck]++; // increase it by 1 if it's already in the dictionary.
            }
            else{
                characterToCountDictionary.Add(characterToCheck, 1);    // initially adds it with count of 1
            }
            
        }
        
        
        char maximumOccuringCharacter = ' ';
        int countOfMaximumOccuringCharacter = 0;
        
        foreach (KeyValuePair<char, int> kvpCharacterToCountDictionary in characterToCountDictionary){
            if(kvpCharacterToCountDictionary.Value > countOfMaximumOccuringCharacter){
                maximumOccuringCharacter = kvpCharacterToCountDictionary.Key;
                countOfMaximumOccuringCharacter = kvpCharacterToCountDictionary.Value;
            }
        }
        
        // had to rewrite it to a for each here, it works on my machine?????
        // oh it's because of a semicolon haha, but there you go, I prefer for loops rather than for each,
        // to better grasp and understand the object you are manipulating.
        
        // for(int i = 0; i < characterToCountDictionary.Count; i++){
        //     KeyValuePair<char, int> kvpCharacterToCountDictionary = characterToCountDictionary.ElementAt(i);
        //     if(kvpCharacterToCountDictionary.Value > countOfMaximumOccuringCharacter){
        //         maximumOccuringCharacter = kvpCharacterToCountDictionary.Key;
        //         countOfMaximumOccuringCharacter = kvpCharacterToCountDictionary.Value;
        //     }
        // }
        
        return maximumOccuringCharacter;

    }


}















