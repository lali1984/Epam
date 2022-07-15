## Task description

Implement a [IsValid](StringVerification/IsbnVerifier.cs#L13) method that verifies if the string representation of number is a valid `ISBN-10` identification number of book. The valid `ISBN-10` format is the string that consists of 4 groups of symbols of length `1, 3, 5, 1`, respectively, which are separated by a hyphen (hyphen can be missing in any part)  
 
> #-###-#####-*, 

where `#` is digit from `0` to `9`, and `*`(check character) is digit from `0` to `9` or symbol `X`. In the case the check character is an `X`, this represents the value `10`. These may be communicated with or without hyphens, and can be checked for their validity by the following check sum: `checkSum` $`= x_1 · 10 + x_2 · 9 + x_3 · 8 + x_4 · 7 + x_5 · 6 + x_6 · 5 + x_7 · 4 + x_8 · 3 + x_9 · 2 + x_{10} · 1`$, where "$`x_1x_2x_3x_4x_5x_6x_7x_8x_9x_{10}`$"- identification number of book. If the `checkSum % 11` is `0`, then it is a valid `ISBN-10`, otherwise it is invalid.

For example, ISBN-10 
- `3-598-21508-8` is valid;
- `3-598-21508-9` is not valid;
- `3-598-21507-X` is a valid.