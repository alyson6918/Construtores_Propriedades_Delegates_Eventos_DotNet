using ExemploConstrutoresDotNet.models;

Log l = Log.GetInstance();
l.PropLog = "Teste de instancia";

Log l1 = Log.GetInstance();
System.Console.WriteLine(l1.PropLog);