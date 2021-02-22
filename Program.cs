using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Quantos funcionarios serão registrados? ");
            int fun = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= fun; i++)
            {
                Console.WriteLine("Funcionario #"+i+ " : ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Entre com o ID do funcionario que terá um aumento: ");
            int idaumento = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == idaumento);

            if (emp != null )
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("ID digitado não existe!");
                
            }

            Console.WriteLine();
            Console.WriteLine("Lista dos Funcionarios: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            
            

        }
    }
}
