# Voltage divider calculator

Tool for calculating the voltage divider and selecting resistor values from the E24 series

![screen](https://raw.githubusercontent.com/c-not-around/u-div/7fbe55ff91024f2ecbfdc0aa3369e1b888bd8281/screen.png)

## Usage

* Calculation of one of the four (`R1`, `R2`, `Uin`, `Uout`) parameters of the voltage divider based on the values of the other three.
  Three known parameters of the voltage divider are specified in the corresponding input fields, the parameter that needs to be calculated is marked with a switch next to the corresponding field, by pressing the "Calculate" button the marked parameter will be calculated and displayed in the corresponding field.
* Find all resistance values of resistors (`R1` and `R2`) from the E24 series.
  The input and output voltages of the divider are specified in the corresponding input fields. The switch next to the input field in this mode indicates a non-fixed voltage value. For example:
    - Simple divider - the input voltage is fixed, and the output will be determined by the ratio of the resistances that make it up;
    - Divider in the feedback circuit of the converter (DC-DC, pulse power supply) - the output voltage of the divider will be maintained equal to the reference voltage of the PWM controller, and the input voltage of the divider (converter output) will be determined by the ratio of the resistances that make it up.
  
  Pressing the "Find All" button will find all pairs of resistances (from the E24 series, taking into account the selected range limits for each of them) that satisfy the ratio of the input voltage of the divider to the output with a relative error (for a non-fixed parameter) of no more than 5%.
  
  Each pair of resistances found is entered into a table with the following values:
  | Column      | Description                                                                     |
  |-------------|---------------------------------------------------------------------------------|
  | `R1`        | resistance of the upper arm of the divider                                      |
  | `R2`        | resistance of the lower arm of the divider                                      |
  | `Uin`       | input voltage                                                                   |
  | `Uout`      | output voltage                                                                  |
  | `ΔUout`     | absolute error of output* voltage                                               |
  | `δUout`     | relative error of output* voltage                                               |
  | `Idiv`      | own current of the divider `Uin`/(`R1`+`R2`)                                    |
  | `Iout(max)` | maximum output current of the divider (output short-circuit current) `Uin`/`R1` |
  
  Note: If the output voltage is fixed, the absolute and relative errors of the input voltage will be displayed in the corresponding columns of the table.
  
  By default the table is sorted in ascending order of relative error `δUout` / `δUin`.