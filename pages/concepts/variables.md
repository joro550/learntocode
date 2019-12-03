---
layout: page
title: About me
---

Definition:
A data item that may take on more than one value during the runtime of a program.

Variables are everywhere in programs, so what do they do? Variables are there to store information whilst executing a program. I like to think of variables as a box you put something inside of the box and then you label it, let me give an example.

```
let x = 5;
```

Okay if you are following my recommended reading this is the first piece of code that you are seeing, don't be afraid be excited! Here we are creating a new variable the `let` keyword (popular in languages such as javascript) is just to tell the language that we are creating a variable. The word `let` is mathematical in nature, but don't worry we're only going to be doing a small amount of maths here.

Back to the analogy - we have created a box and slapped a label on it the label has the Name `x` written on it, now we can reference that box (we'll talk about scoping much later - let's pretend it doesn't exist for now). Unless we change the contents of that box it will remain the same (the value of 5).

Here is another piece of code - don't worry

```
print(x)
```

This sample is not from any specific language but it gives you a bit of exposure theropy to functions/methods which we will talk about much later. Here we are passing `x` into `print` - now that `print` has that variables in it's grasp it can do certain things with it, let's pretend we are writting a console application and `print` simply prints out the value of `x`, in this example it would print out the value of `x`, which as we learned was 5. If we stick with the box analogy we pass the box to `print`, `print` opens the box takes out the value, sticks it onto the interface in the most appropriate format.

# What can variables do?
Variables are a simple construct that are present in every programming language, they can do a whole host of things, you can add, subtract, compare, multiply. Mostly they are used to transfer state. Now you don't have to understand what that means right now but if we think about our program as assembly line, each person in the line has their own role to play in our program we can pass the box from person to person and they can look into the box, change the contents of the box. 

Here's an example, I want a vowel extractor, in English we have the vowels a,e,i,o,u, my name Mark only has one vowel in it - the A. So let's talk about the assembly line.

Person 1: Asks the user what their name is -> Mark
Person 2: Looks at that name and takes out the vowels 
Person 3: Displays the new de-voweled name on to the screen

Or we could say (using variables)

Person 1: Store the users name in a variable -> `let name = "Mark"`
Person 2: Extracts the vowels from the name -> 
```
for each letter in name
    if letter is 'a' or letter is 'e' or letter == 'i' or letter id 'o' or letter id 'u'
        remove letter from name

```
Person 3: retrieves the name (from the box) and displays it -> `print(name)`

In this example I've used some concepts that we will go over later (loops, conditionals) but I have shown them in a language we developers like to call pseudo code, this is supposed to show or tell you what the code is doing without pining down a specific language, without the constraint of keywords or special chracters, so that people can understand it without having to understand the language in which it was written because for intents and purposes it is written in plain english, a little verbose I will grant you but that has a reasoning which you will probably see later.

# Where will I use variables

