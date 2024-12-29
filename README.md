# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall when working with mutable variables in F#.  The `swap` function, designed to exchange the values of two mutable variables, unexpectedly modifies the original variables due to pass-by-reference semantics.

The `bug.fs` file contains the buggy code, while `bugSolution.fs` provides a corrected version.

## How to reproduce the bug:
1. Compile and run `bug.fs`.
2. Observe that the output is not the expected result. 

## Understanding the Issue:
Unlike many languages, F# mutable variables are passed by reference, meaning functions operate directly on the memory locations of variables. Therefore, changes within the function directly affect the original variables.  This differs from the typical pass-by-value behavior.

## Solution:
The `bugSolution.fs` file shows how to use tuples to correctly swap values without modifying the original variables, implementing pass-by-value semantics.