<h1>DuplicateFileFinder</h1>
This is a program I've been writing in my spare time to try and identify duplicate files and folders between two different parent directories. This program is still being written, and is not ready to perform its actual purpose. The code for this program is written in C# using the Godot engine for easy cross platform deployment (I like using Godot to make GUI applications I can port to different operating systems so I don't have to recode much of anything.)

The objective of this program is 
-Pick two parent directories to index, and record what files and directories they contain
-Compare the found files and folders between each other, identifying any duplicates
-Display a list to the end user showcasing the duplicates found
-Show file and folder details when a user clicks on a duplicate file from the list
-Save the found duplicate files and folders as some sort of list
-Allow the user the ability to delete duplicate files and folders by identifying which ones are the original
