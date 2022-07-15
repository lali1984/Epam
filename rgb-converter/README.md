Implement a [GetHexRepresentation](RgbConverter/Rgb.cs#L14) method, that returns hexadecimal representation source RGB decimal values. Valid decimal values for RGB are `0 - 255`. Any values that fall out of that range must be rounded to the closest valid value. _Your answer should always be 6 characters long, the shorthand with 3 will not work here._    
The following are examples of expected output values:
            
        (255, 255, 255) => "FFFFFF" 
        (255, 255, 300) => "FFFFFF"
        (0,0,0) => "000000"
        (148, 0, 211) => "9400D3"