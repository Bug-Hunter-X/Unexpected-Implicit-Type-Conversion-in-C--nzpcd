# Unexpected Implicit Type Conversion in C#

This repository demonstrates a potential issue with implicit type conversions in C#. Implicit conversions can be convenient, but they can also lead to unexpected behavior if not handled carefully. The example code shows how implicit conversion between a custom class and an integer type can result in unexpected or confusing results.

## Bug Description
The code uses implicit type conversion operators to convert between a custom class `MyClass` and an integer. While this allows for flexibility, it also makes the code harder to follow and maintain. Unintended behavior could arise in more complex scenarios.

## Solution
The solution involves removing the implicit conversion operators and making the conversions explicit. This improves code clarity and reduces the risk of unexpected behavior.