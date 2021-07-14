/*21.3(Collections Terminology) Define each of the following terms:
    a) ICollection
    b) Array
    c) IList
    d) load factor
    e) Hashtable collision
    f) space / time trade-off in hashing
    g) Hashtable
21.4(ArrayList Methods) Explain briefly the operation of each of the following methods of class ArrayList :
    a) Add
    b) Insert
    c) Remove
    d) Clear
    e) RemoveAt
    f) Contains
    g) IndexOf
    h) Count
    i) Capacity
21.8 (Enumerator Members) Explain briefly the operation of each of the following enumeratorrelated methods:
    a) GetEnumerator
    b) Current
    c) MoveNext
21.9 (HashTable Methods and Properties) Explain briefly the operation of each of the following methods and properties of class Hashtable:
    a) Add
    b) Keys
    c) Values
    d) ContainsKey


Answers:
    21.3:
    a) ICollection - interface that represents a set of common properties and methods for all generic collections (for example, CopyTo, Add, Remove, Contains methods, Count property) 
    b) Array - root class for all arrays in C#. This class defines a number of properties and methods that we can use when working with arrays. 
    c) IList - derived interface from ICollection. Provides functionality for creating sequential lists.
    d) load factor -  the ratio of the number of objects stored in the hash table to the total number of cells of the hash table. The higher the ratio, the more likely the occurrence of collisions.
    e) Hashtable collision - it`s some sort of glitch in Hashtable class(when two different keys hash into the same element in the array)
    f) space / time trade-off in hashing - it`s compromise between space of memory we use for app and the app performance.
    g) Hashtable - it`s class which implements the data hashing mechanism. Requires using System.Collections
    21.4:
    a) Add -  appends element to the ArrayList.
    b) Insert - inserts element at the specified position.
    с) Remove - removes the first occurrence of a specified object from the ArrayList.
    d) Clear - deletes all elements from the ArrayList.
    e) RemoveAt - removes the element at the specified index.
    f) Contains - determines if an ArrayList contains a specified object.
    g) IndexOf - returns the index of the first occurrence of a specified object or -1 if the object is not found.
    h) Count - returns the current number of elements in the ArrayList.
    i) Capacity - returns the number of elements available for storage.
    21.8:
    a) GetEnumenator - returns an enumerator that can iterate over the collection.
    b) Current - obtains the current element of the enumerator.
    c) MoveNext - returns true if there’s at least one more element in the collection. Otherwise, the method returns false.
    21.9:
    a) Add - appends a key/value pair into the Hashtable.
    b) Keys - read-only property needed to get an ICollection that contains all the keys stored in Hashtable.
    c) Values - read-only property needed to get an ICollection that contains all the values stored in Hashtable.
    d) ContainsKey - determines whether the specified key is in the Hashtable.
*/
