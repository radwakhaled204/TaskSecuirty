Project: Simple Encryption

Description:
This C# program implements a basic encryption technique combining substitution and transposition ciphers. It reads plain text from a specified file, applies the ciphers, and writes the encrypted text to an output file.

How it works:

Substitution:

Reads the alphabet from an input file.
Reads the plain text from another input file, converting it to lowercase.
Encrypts the plain text by shifting each character three positions in the alphabet (Caesar cipher).
Writes the substituted text to the output file.
Transposition:

Splits the substituted text into two alternating strings (even and odd positions).
Combines the two strings to form the final cipher text.
Appends the transposed text to the output file.
Input files:

Alphabet.txt: Contains the alphabet in lowercase.
Message.txt: Contains the plain text to be encrypted.
Output file:

Output.txt: Contains the encrypted text, including both substitution and transposition results.
Limitations:

This is a simple implementation for educational purposes and should not be used for secure encryption.
The encryption algorithm is relatively weak and can be easily broken.
The code does not include any error handling or input validation.
Potential improvements:

Implement more robust encryption algorithms.
Add error handling and input validation.
Allow user input for encryption parameters.
Create a decryption function.






