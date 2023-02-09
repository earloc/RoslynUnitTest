See #1 when you want to know how to fix this!

# RoslynUnitTest
Repro sample of Roslyn behaving different when invoked through a CLI vs a UnitTest

# Steps to reproduce

## 1. Invoke the CLI
### expected
The program executes without exceptions
### actual
✔️ The program executes without exceptions


## 2. Invoke one of the unit-tests
### expected
The test passes
### actual
❌ The tests fails, a an exception is thrown due to errors in the compilation

# How to fix this?

See #1
