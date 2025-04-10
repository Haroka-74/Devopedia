# **C# Language**
- *C# is a statically typed, multi-threaded, modern programming language designed for building a wide range of applications, primarily running on the .NET ecosystem*
- *C# offers a variety of features, is free, open-source, and cross-platform (supporting Windows, Linux, and macOS), it supports multiple programming paradigms, including object-oriented, functional, imperative, and generic programming*
- *Developed by Microsoft in `2000`, C# is widely used for web applications (ASP.NET), desktop apps (WPF, WinForms), mobile development (Xamarin), game development (Unity), and cloud services (Azure)*

# **.NET**
- *.NET is a comprehensive, cross-platform software development platform that provides the tools, libraries, and runtime environment needed to build, deploy, and run modern applications across various operating systems and devices*
- *The .NET platform consists of two core components that work together to enable application execution and development*
    - ***Common Language Runtime (CLR)***
        - *Serves as the virtual machine and execution engine for .NET applications*
        - *Provides critical runtime services including*
            - *Just-In-Time (JIT) compilation that converts Intermediate Language (IL) code to native machine code*
            - *Automatic memory management through garbage collection*
            - *Exception handling and type safety enforcement*
            - *Thread management and synchronization*
    - ***Base Class Library (BCL) / Framework Class Library (FCL)***
        - *Offers an extensive, standardized collection of reusable classes, interfaces, and value types*
        - *Provides fundamental functionality for*
            - *File I/O operations and data streams*
            - *Collections and data structures*
            - *String manipulation and regular expressions*

# **Identifiers**
- *An identifier is a sequence of characters used to name variables, methods, classes, namespaces, and other programming elements in C#*
- *There are several rules to follow for best practices with identifiers*
    - *Identifiers are case-sensitive `(myVar ≠ MyVar)`, each identifier must be unique, and identifiers must start with letter or underscore*
    - *Reserved keywords can be used as identifiers by prefixing them with `@`*
        - *For more information, check the following link [Identifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords)*
    - *Identifiers should not contain two consecutive underscores, as these are reserved for compiler-generated names*
    - *Non-flag enumerations use `singular` nouns and flag enumerations use `plural` nouns*
    - *Identifiers can contain the following characters*
        - *Latin, greek, cyrillic, arabic, and chinese letters*
        - *Underscore and arabic tatweel*
        - *Acute accent `é`, diaeresis `ä`, cedilla `ç`, and tilde `ñ`*
        - *Arabic-indic digits, western digits, and devanagari digits*
    - *Interface names use `I` as a prefix, and private or internal field names sometimes use an underscore as a prefix*
    - *Pascal case is used for namespaces, classes, interfaces, structures, enumerations, properties, constants, methods, and public members*
    - *Camel case is used for method parameters, local variables, private fields, and internal fields*