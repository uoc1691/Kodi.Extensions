# Kodi.Extensions
This small library includes extension methods that are useful in day to day programming. This includes extension methods for collections and Linq.

##IEnumerable extension methods
###Shuffle()
It's a common requirement to shuffle a list of objects. This generic method allows you to shuffle a list using the Durstenfeld's modern implementaton of [Fisher–Yates shuffle](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle).

e.g.
**list.Shuffle();**

##IQueryable extension methods
###OrderBy(string fieldName)
To make your code more dynamic there are instances where you would want to specify the name of the property as a string where you want the order by to happen. This extension method lets you pass in the property name as a string. If the property can not be found it will throw an ArgumentException.

###OrderByDescending(string fieldName)
Same as OrderBy extension, this method allows the property name to be passed as a string.

