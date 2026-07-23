# NegativeDecider

NuGet Version: https://www.nuget.org/packages/NegativeDecider/

License: MIT https://opensource.org/licenses/MIT

---

**"Is a number negative? Let's use a quadruple cosmic verification to be absolutely sure!"**

A .NET library for determining whether a nullable integer (`int?`) is negative.

## Installation

Via NuGet Package Manager:

```bash

dotnet add package NegativeDecider

```

## Quick Start

``` csharp

using NegativeDecider;

bool isNegative = NegativeChecker.IsNegative(-5);  // true
bool hyw = NegativeChecker.IsNegative(10);         // false
bool homo = NegativeChecker.IsNegative(null);      // false

```

## Implementation Notes

Internally, it uses a combination of string matching, regular expressions, culture-specific formatting, and bitwise operations for comprehensive evaluation.

## License

This project is licensed under the MIT License.

---

**“判断一个数是否为负数？让我们用四重宇宙级校验来确保万无一失！”**

一个用于判断可空整数（`int?`）是否为负数的 .NET 类库。

## 安装

通过 NuGet 包管理器安装：

```bash

dotnet add package NegativeDecider

```

## 快速开始

``` csharp

using NegativeDecider;

bool isNegative = NegativeChecker.IsNegative(-5);  // true
bool hyw = NegativeChecker.IsNegative(10);  // false
bool homo = NegativeChecker.IsNegative(null); // false

```

## 实现说明

内部使用了字符串匹配、正则表达式、区域文化信息和位运算等多种方式综合判断。

## 许可证

本项目采用 MIT 许可证。
