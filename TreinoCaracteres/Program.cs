﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
       
        if (salario >= 1900.0 && salario<= 2800.0)
        {
            Console.WriteLine("O ir é de 7.5% e pode reduzir o valor de R$ 142");
        }
        //ifs aqui
        if (salario >= 2800.01 && salario <= 3571.0)
        {
            Console.WriteLine("Seu IR é de 15% e pode deduzir R$ 636");
        }
        if (salario >= 3751.01 && salario >= 4664.00)
        {

            Console.WriteLine("O IR é de 22.5% e pode deduzir de R$636");
        }
    }
}