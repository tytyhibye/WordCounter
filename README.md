# _Word Counter_

## by Tyler Bates (2020)

## _Description_

This interactive console program will return the occurences of a single word in a string of words or phrase. First it accepts an input word from the user, the user is then prompted to input a string of words or phrase. The program then dynamically calculates and returns how frequently the input word is found in the string or phrase, regardless of punctuation or case sensitivity. Pretty great right?

## _Setup_

- Clone this projects repository into your local directory following <a href="https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/">these</a> instructions.<br>
- Install .NETCore using <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">this</a> link.<br>
- In your terminal, navigate to the "WordCounter" directory within the project folder.<br>
- From within this directory, enter the following into your terminal:<br>
```
$ dotnet run
```
<br>
The program will begin within your terminal. Enjoy!

## _Technology Used_

## <a href="https://en.wikipedia.org/wiki/C_Sharp_%28programming_language%29">C#</a>
## <a href="https://en.wikipedia.org/wiki/.NET_Core">.NET Core</a>
## <a href="https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework">MSTest</a>

## Specs

|Behavior|Input|Output|
|-----|-----|-----|
|Program will have user input a base word|"cat"|"cat"|
|Program will have user input a string of words to compare to base word|"the cat was at the cathedral"|repeat string|
|Program will compare word to string to determine how many occurences take place|"cat" --> "the cat was at the cathedral"|"'cat' appears 1 time."|
|Program will remove punctuation and capitalization from input string|"cat,cat.Cats!CAT?"|"cat cat cats cat"|


## _Legal_

#### MIT License

### Copyright (c) 2020 Tyler Bates @ Epicodus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
