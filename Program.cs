using System;
using System.Collections.Generic;
using System.Linq;

namespace Pratica_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] fila = new Pessoa[10];
            int contador = 0;
            char programa = '1';
            do
            {
                Console.WriteLine("\nUm novo cliente apareceu!\nO que deseja fazer?\nListar a fila[1]\nInserir o cliente na fila[2]\nOrganizar a fila[3]\nAtender o primeiro cliente da fila[4]\n");
                char opt = char.Parse(Console.ReadLine().ToLower());
                if (opt == 'q')
                {
                    programa = '0';
                    break;
                }
                switch (opt)
                {
                    case '1':
                        if (contador == 0)
                        {
                            Console.WriteLine("A fila está vazia\n");
                        }
                        else
                        {

                            for (int i = 0; i < contador; i++)
                            {
                                if (fila[i] != null)
                                {
                                    Console.WriteLine($"\n{i + 1}º Nome: {fila[i].Nome} Idade: {fila[i].Idade}\nPossui prioridade? [{fila[i].Especial}]\n");

                                }
                            }
                        }
                        
                        break;

                    case '2':
                        if (contador < 10)
                        {
                            Pessoa novoCliente = new Pessoa();
                            novoCliente.cadastrar();
                            fila[contador] = novoCliente;
                            contador++;
                            Console.WriteLine("\nCadastro completo!\nO cliente foi adicionado na fila com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("O vetor atingiu o tamanho máximo.");
                        }
                        break;

                    case '3':
                        if (contador == 0)
                        {
                            Console.WriteLine("A fila está vazia.");
                        }
                        else
                        {
                            Console.WriteLine("\nComo você deseja organizar a fila?\nPor idade[1]\nPrioridade para condições especiais[2]");
                            char org = char.Parse(Console.ReadLine().ToLower());
                            if (org == 'q')
                            {
                                programa = '0';
                                break;
                            }
                            switch (org)
                            {
                                case '1':
                                    for (int i = 0; i < contador - 1; i++)
                                    {
                                        for (int j = i + 1; j < contador; j++)
                                        {
                                            if (fila[i] != null && fila[j] != null && fila[i].Idade < fila[j].Idade)
                                            {
                                                Pessoa temp = fila[i];
                                                fila[i] = fila[j];
                                                fila[j] = temp;
                                            }
                                        }
                                    }
                                    break;

                                case '2':
                                    for (int i = 0; i < contador - 1; i++)
                                    {
                                        for (int j = i + 1; j < contador; j++)
                                        {
                                            if (fila[i] != null && fila[j] != null && !fila[i].Especial && fila[j].Especial)
                                            {
                                                Pessoa temp = fila[i];
                                                fila[i] = fila[j];
                                                fila[j] = temp;
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida! Tente novamente.");
                                    continue;
                            }
                            Console.WriteLine("\nLista organizada com sucesso!\n");
                        }
                        break;

                    case '4':
                        if (contador > 0)
                        {
                                Pessoa atendido = fila[0];
                                for (int i = 0; i < fila.Length - 1; i++)
                                {
                                    fila[i] = fila[i + 1];
                                }
                                fila[contador] = null;
                                contador--;
                                Console.WriteLine("Cliente atendido: " + atendido.Nome);
                            }
                            else
                            {
                                Console.WriteLine("Não há clientes na fila para atender.");
                            }
                        
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        break;
                }
            } while (programa != '0');
            Console.WriteLine("Saindo do programa... (clique em qualquer tecla pra fechar a tela)");
            Console.ReadKey();
        }
    }
}