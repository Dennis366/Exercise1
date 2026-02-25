# Substring Word Comparison Program (C#)






This C# console application asks the user to enter two sentences.
The program checks whether both sentences contain at least one common word.
If they do, it informs the user that the substring exists in the string.
If not, it informs the user that no common word exists.

The user can choose to repeat the process by entering 'y' or exit by entering 'n'.
Input validation ensures that only 'y' or 'n' is accepted.



1. The program starts inside the Main method.
2. A do-while loop ensures the program runs at least once.
3. The user enters two sentences using Console.ReadLine().
4. Both sentences are converted to lowercase to ensure case-insensitive comparison.
5. The sentences are split into arrays of words using Split().
6. LINQ's Intersect() method is used to find common words.
7. The Any() method checks if at least one match exists.
8. The result is displayed to the user.
9. The program asks whether to continue (y/n) with input validation.


**example sentence**



Enter the first sentence: I love pizza

Enter the second sentence: Pizza is great

The substring exists in the string.

Do you want to continue? (y/n): y
