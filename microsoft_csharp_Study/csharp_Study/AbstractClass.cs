﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Expression
{
    public abstract double Evaluate(Dictionary<string, object> vars);
}

public class Constant : Expression
{
    double _value;
    public Constant(double value)
    {
        _value = value;
    }
    public override double Evaluate(Dictionary<string, object> vars)
    {
        foreach (var var in vars.Keys)
        {
            Console.Write($"传入数据：{var}\n");
        }
        Console.WriteLine("传入数据的值为："+vars["numberOne"]);
        //Console.WriteLine(vars.TryGetValue("str",out _));
        Console.WriteLine("初始化数据："+_value);
        return _value;
    }
}
