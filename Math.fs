module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter count result =
    // printfn "%d" result
    if result = 1UL then count
    elif result % 2UL = 0UL then iter (count+1) (result/2UL)
    else iter (count+1) (3UL*result+1UL)
  iter 0 (uint64 n)
