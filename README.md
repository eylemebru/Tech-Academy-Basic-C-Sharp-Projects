# Package Shipping Calculator Application

This console application is a simple program that calculates shipping costs for the Package Express shipping company.

## 📝 Project Description

The program takes the package's weight and dimensions (width, height, length) from the user and calculates the shipping cost. The following rules apply during calculation:

- Package weight cannot exceed 50 units
- Total package size (width + height + length) cannot exceed 50 units
- Shipping cost is calculated using this formula: (width * height * length * weight) / 100

## ⚙️ How It Works?

1. User is asked for the package weight
2. If weight exceeds 50 units, the process is terminated
3. Package width, height, and length measurements are collected
4. Total size check is performed
5. Shipping cost is calculated and displayed for eligible packages

## 🎯 Purpose

This application is designed to check the package acceptance criteria of the shipping company and quickly calculate prices for eligible packages.

---
*This project was developed using C# programming language.*
