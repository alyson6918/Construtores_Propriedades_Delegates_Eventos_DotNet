using ExemploConstrutoresDotNet.models;

Operation op = new Operation(Calculator.sum);
op+=Calculator.sub;
op.Invoke(10, 10);
public delegate void Operation(int n1, int n2);