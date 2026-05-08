# StatOne: Simple Statistical Functions for C#

**StatOne** is a lightweight, easy-to-use C# library for essential statistical analysis. It is designed for developers who need reliable numerical functions without the overhead of complex mathematical frameworks.



## 🎯 Key Features
* **Zero Dependencies:** Pure C# code that is easy to drop into any project.
* **Core Metrics:** Mean, Median, Mode, Variance, and Range.
* **Standard Deviation Focus:** Accurate calculation for both Sample and Population data.
* **Readable Code:** Written for clarity, making it a great learning tool for students and engineers alike.

---

## 📉 Understanding Standard Deviation
The standout feature of StatOne is its **Standard Deviation** implementation. It measures how spread out your numbers are.



### Mathematical Formulas Used:
* **Mean ($\mu$):** $\frac{\sum x_i}{n}$
* **Variance ($\sigma^2$):** $\frac{\sum (x_i - \mu)^2}{n}$
* **Standard Deviation ($\sigma$):** $\sqrt{\sigma^2}$

---

## 🛠 Installation
This is a standard C# Console/Library project.

1. Clone the repository: `git clone https://github.com/LandSharkFive/StatOne.git`
2. Open the solution in **Visual Studio 2022**.
3. Build the project to generate the DLL or run the included samples.

---

## 💡 Quick Start: Standard Deviation Example

The following example shows how to calculate the spread of a dataset using the `StatFunctions` class.

```csharp
using System;
using System.Collections.Generic;
using StatOne;

class Program
{
    static void Main()
    {
        // Simple dataset
        List<double> data = new List<double> { 10, 12, 23, 23, 16, 23, 21, 16 };

        // 1. Calculate Mean
        double mean = StatFunctions.CalculateMean(data);

        // 2. Calculate Standard Deviation
        double stdDev = StatFunctions.CalculateStandardDeviation(data);

        Console.WriteLine($"Mean: {mean}");
        Console.WriteLine($"Standard Deviation: {stdDev:F2}");
    }
}

