/*7.13 For each of the following sets of integers, write a single statement that will display a number
       at random from the set. Assume Random randomNumbers = new Random() has been defined and use
       the one-parameter version of method Random.Next.

    a) 2, 4, 6, 8, 10.
    b) 3, 5, 7, 9, 11.
    c) 6, 10, 14, 18, 22/

Answers:

    a) n = 2*randomNumbers.Next( 1, 5 );
    b) n = -1 + 2*randomNumbers.Next( 2, 7 );
    c) n = 2*(-1 + 2*randomNumbers.Next( 2, 7 ));

 */