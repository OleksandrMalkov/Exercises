
/*4.6 What is a default constructor? How are an object’s instance variables initialized if a class has
      only a default constructor?

      C# requires a constructor for every object, so if you don`t specify constructor in body of class declaration, compiler provides a public default constructor. 
    The default constructor doesn`t modify values of instance variables, so it`s variables initialized by default (null for sting, false for bull and 0 to numeric data types).

4.7 Explain the purpose of an instance variable.

        When we are declaring a class, we specify attributes of this class. Class is only a template by which we declare(create) objects and attributes are characteristics that this object must have.
    Instance variables are value of attributes for particular object ( value of this characteristics of class for this particular object ).