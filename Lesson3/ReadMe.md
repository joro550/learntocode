# Human counting

When we humans count we do it in what is known as "base 10" which means that we have 10 number 0-9:

Base 10:

0-1-2-3-4-5-6-7-8-9-10

When we "run out" of number we push a number to the left of the number to represent the next order of magnitude:

10 000| 1000|100|10| 1
--|--|--|--| --
0| 1 |1  |1 | 0

# Computer counting

Computers count in a binary or "base 2" system where they only have 2 numbers before having to "push a value to the left" which are 0 and 1:

Base 2 - Binary:

0-1


When we "run out" of number we push a number to the left of the number to represent the next order of magnitude just as before:

32 | 16| 8|4|2| 1
--|--|--|--|--| --
0 | 0| 1 |1  |1 | 0

1. 1
1. 10
1. 11
1. 100

# Programming

When we talk about computers and how they store information we talk about bits, "how many bits should we reserve for a certain data type":
```
int: 32 bits 

// -2,147,483,648 to 2,147,483,647
```

Because an integer can repesent both positive and negative numbers then the max value is half of what it would be if we would only have to represent either all positive or all negative numbers

```
uint: 32 bits

// 0 to 4,294,967,295
```

Here we can see that in action
```
long : 64 bits

// -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
```

A long reserves 64 bits of memory so the max values are much larger

```
ulong: 64 bits 

 // 0 to 18,446,744,073,709,551,615
 ```

Again showing that with a signed number we only have to represent positive numbers so the max value can be even larger here

```
 bits:

 // collection of 8 

 00000000
 - byte 


 // Collection of 4

 0000
 - nibble

 ```

- kilobyte - 1024 - byte 
- megabyte - 1024 - kilbyte
- giga - 1024 - kilo
- Tera - 1024 - giga
- peta - 1024 - tera

 # Hexadecimal

 We are trying to represent a nibble (four bits) as one character to do this we use regular numbers for values from 0-9 and then move to letters for the rest of the values leaving us with A-F, through this system we can represent a byte (two nibbles or 8 bites) with two characters:
```
1A = 11
```

We just add the value of the left character with the value of the right character to give us the full value of the byte
