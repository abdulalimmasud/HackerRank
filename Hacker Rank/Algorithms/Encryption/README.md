###Solution###

s = if man was meant to stay on the ground god would have given us roots
After removing spaces, the string is 56 characters long. Root(56) is between 7 and 8, so it is written in the form of a grid with 7 rows and 8 columns.

ifmanwas  
meanttos          
tayonthe  
groundgo  
dwouldha  
vegivenu  
sroots
Ensure that 

If multiple grids satisfy the above conditions, choose the one with the minimum area, i.e. . rows * columns
The encoded message is obtained by displaying the characters of each column, with a space between column texts. The encoded message for the grid above is:

imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau

Create a function to encode a message.

##Function Description##

Complete the encryption function in the editor below.

encryption has the following parameter(s):

string s: a string to encrypt
##Returns##

string: the encrypted string
Input Format

One line of text, the string s