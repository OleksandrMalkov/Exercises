/*5.13(Choosing Repetition Statements) What type of repetition would be appropriate for calculating the sum of the first 100 positive integers?
      What type of repetition would be appropriate for calculating the sum of an arbitrary number of positive integers? Briefly describe how each of these
      tasks could be performed.

Answer: 
   
    For this task we should use counter-controlled repetition (because we know number of repetitions). 
    If we don`t know number of repetitions we should use sentinel-controlled repetition.
    
    In counter-controlled repetition we:
        initialize variables ( number by 0, sum by 1)
        While number is less than or equall to 100
            add number to sum
            add 1 to number
        Display value of sum
    
    In sentinel-controlled repetition we:
        initialize variables ( number by 0, sum by 1)
        While user input sentinel value
            add number to sum
            add 1 to number
        Display value of sum  */
        