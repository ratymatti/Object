// See https://aka.ms/new-console-template for more information
// OOP Concepts in C# — Self-Documenting Console Project
using OOPExplained.Concepts;

Console.WriteLine("=== OOP Concepts in C# ===");
Console.WriteLine();

// Classes and Objects
Console.WriteLine("=== CLASSES AND OBJECTS ===");
ClassAndObjectDemo classDemo = new ClassAndObjectDemo();
classDemo.Explain();
Console.WriteLine();

// Constructor
Console.WriteLine("=== CONSTRUCTORS ===");
ConstructorDemo constructorDemo = new ConstructorDemo();
constructorDemo.Explain();
Console.WriteLine();

// Inheritance
Console.WriteLine("=== INHERITANCE ===");
InheritanceDemo inheritanceDemo = new InheritanceDemo();
inheritanceDemo.Explain();
Console.WriteLine();

// Interface
Console.WriteLine("=== INTERFACES ===");
TaskRunner taskRunner = new TaskRunner();
taskRunner.Explain();
Console.WriteLine();

// Abstract Class
Console.WriteLine("=== ABSTRACT CLASSES ===");
PdfDocument pdfDocument = new PdfDocument();
pdfDocument.Explain();
Console.WriteLine();

// Visibility
Console.WriteLine("=== VISIBILITY & ACCESS MODIFIERS ===");
VisibilityDemo visibilityDemo = new VisibilityDemo();
visibilityDemo.Explain();
Console.WriteLine();

// Static
Console.WriteLine("=== STATIC MEMBERS ===");
StaticDemo staticDemo = new StaticDemo("Pääohjelman olio");
staticDemo.Explain();
Console.WriteLine();

// Overloading
Console.WriteLine("=== METHOD OVERLOADING ===");
OverloadingDemo overloadingDemo = new OverloadingDemo();
overloadingDemo.Explain();
Console.WriteLine();

// Overriding 
Console.WriteLine("=== METHOD OVERRIDING ===");
OverrideDemo overrideDemo = new OverrideDemo();
overrideDemo.Explain();
Console.WriteLine();

// Binding
Console.WriteLine("=== BINDING (EARLY AND LATE) ===");
BindingDemo bindingDemo = new BindingDemo();
bindingDemo.Explain();
Console.WriteLine();

Console.WriteLine("=== Demonstration Complete ===");
