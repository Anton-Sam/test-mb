using FigureLib.Core.Abstractions;
using FigureLib.Core.Models;

List<Figure> figures = new();

figures.Add(new Circle(2));
figures.Add(new Triangle(3, 4, 5));

figures.ForEach(f => Console.WriteLine(f.Square()));