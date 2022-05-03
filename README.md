# CalculatorFunctions

This project compiles dll file to use in [Modular Calculator](https://github.com/PeterisEcis/ModularCalculator). It has 4 functions: Add, Subtract, Multiply and Divide.
This repository contains 3 branches with different compiled dll files to use.

Branch [NoFunctions](https://github.com/PeterisEcis/CalculatorFunctions/tree/NoFunctions/CalculatorFunctions/bin/Debug) return null for all functions.

Branch [master](https://github.com/PeterisEcis/CalculatorFunctions/tree/master/CalculatorFunctions/bin/Debug) returns normal results for all functions but does not check if divided by 0, so it can throw an error.

Branch [AdvancedDivide](https://github.com/PeterisEcis/CalculatorFunctions/tree/AdvancedDivide/CalculatorFunctions/bin/Debug) returns null instead of error if divided by 0
