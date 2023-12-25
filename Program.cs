using Models;


Curso curso = new Curso();

bool continuar = false;

Console.Clear();

do
{
    Console.WriteLine("1 - Adicionar Pessoa");
    Console.WriteLine("2 - Remover Pessoa");
    Console.WriteLine("3 - Listar Alunos");
    Console.WriteLine("Digite qualquer outra coisa para sair");

    int escolha;
    string resultado = Console.ReadLine();

    Console.Clear();

    if (int.TryParse(resultado, out escolha))
    {
        switch (escolha)
        {
            case 1:

                Pessoa pessoa = new Pessoa();

                bool cValidacao = false;
                int codigo1;

                do
                {
                    Console.Write("Código (numérico): ");

                    if (int.TryParse(Console.ReadLine(), out codigo1))
                    {
                        cValidacao = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("O codigo deve ser numérico!");
                    }
                } while (!cValidacao);

                pessoa.Codigo = codigo1;

                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();





                bool idadeValidacao = false;
                int idade;

                do
                {
                    Console.Write("Idade: ");

                    if (int.TryParse(Console.ReadLine(), out idade))
                    {
                        if (idade > 0)
                        {
                            idadeValidacao = true;
                        }
                        else
                        {
                            idadeValidacao = false;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Digite uma idade válida!");
                    }
                } while (!idadeValidacao);

                pessoa.Idade = idade;

                curso.MatricularAluno(pessoa);
                break;
            case 2:
                int codigo;
                bool codigoValido = false;

                do
                {
                    Console.Write("Digite o código do aluno que será removido: ");

                    if (int.TryParse(Console.ReadLine(), out codigo))
                    {
                        codigoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Digite um número válido!");
                    }
                } while (!codigoValido);

                curso.RemoverAluno(codigo);
                break;
            case 3:
                curso.ListarAlunos();
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
    }

    Console.WriteLine("Continuar?");

    if (Console.ReadLine() == "sim")
    {
        continuar = true;
    }
    else
    {
        continuar = false;
    }

    Console.Clear();
} while (continuar);