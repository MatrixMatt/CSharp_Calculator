# challenge-calculator
calculator that only supports an Add operation given a single formatted string
# Requirements
-  Support a maximum of 2 numbers using a comma delimiter
 - examples: 20 will return 20; 1,5000 will return 5001
  - invalid/missing numbers should be converted to 0 e.g. "" will return 0; 5,tytyt will return 5
- Support an unlimited number of numbers e.g. 1,2,3,4,5,6,7,8,9,10,11,12 will return 78
- Support a newline character as an alternative delimiter e.g. 1\n2,3 will return 6
- Deny negative numbers. An exception should be thrown that includes all of the negative numbers provided
- Ignore any number greater than 1000 e.g. 2,1001,6 will return 8
- Support 1 custom single character length delimiter
 - use the format: //{delimiter}\n{numbers} e.g. //;\n2;5 will return 7
 - all previous formats should also be supported
- Support 1 custom delimiter of any length
 - use the format: //[{delimiter}]\n{numbers} e.g. //[***]\n11***22***33 will return 66
- all previous formats should also be supported
- Support multiple delimiters of any length
- use the format: //[{delimiter1}][{delimiter2}]...\n{numbers} e.g. //[*][!!][r9r]\n11r9r22*33!!44 will return 110
- all previous formats should also be supported
