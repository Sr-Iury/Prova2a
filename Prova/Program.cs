using System;
public class Program {
    static void Main(string[] args)
    {
        try
        {
            while(true)
            {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("0 - Funcionário");
            Console.WriteLine("1 - Médico");
            Console.WriteLine("2 - Administrativo");
            Console.WriteLine("3 - Funcionários com salario acima de 2000");
            Console.WriteLine("4 - Para fechar o programa");
            int opcao = int.Parse(Console.ReadLine());
            List<double> listGERAL = new List<double>();
            List<Funcionario> fun = new List<Funcionario>();
            List<Medico> mec = new List<Medico>();
            List<Administrativo> admin = new List<Administrativo>();
            switch (opcao)
            {
                case 0:
                    Funcionario f = new Medico();
                    Console.Write("Digite o nome do Funcionário: ");
                    f.nome = Console.ReadLine();
                    Console.Write("Digite a matricula do Funcionário: ");
                    f.matricula = int.Parse(Console.ReadLine());
                    Console.Write("Digite a data de nascimento do Funcionário: ");
                    f.dataNascimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Digite o sexo do Funcionário: ");
                    f.sexo = Console.ReadLine();
                    Console.Write("Digite o salário do Funcionário: ");
                    f.salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Salário total = " + f.salario);
                    fun.Add(f);
                    foreach(Funcionario func in fun)
                        {
                            if(func.salario > 2000.0)
                            {
                                Console.WriteLine("Os salários acima de 3000 são respectivamente " + func.nome + " possuindo " + func.salario);
                            }
                        }
                    break;
                case 1:
                    Medico m = new Medico();
                    Console.Write("Digite o nome do Funcionário: ");
                    m.nome = Console.ReadLine();
                    Console.Write("Digite a matricula do Funcionário: ");
                    m.matricula = int.Parse(Console.ReadLine());
                    Console.Write("Digite a data de nascimento do Funcionário: ");
                    m.dataNascimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Digite o sexo do Funcionário: ");
                    m.sexo = Console.ReadLine();
                    Console.Write("Digite o salário do Funcionário: ");
                    m.salario = double.Parse(Console.ReadLine());
                    Console.Write("Digite o CRM do médico: ");
                    m.crm = Console.ReadLine();
                    Console.Write("Digite o valor da hora extra do médico: ");
                    m.horaExtra = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a especialidade do médico: ");
                    m.especialidade = Console.ReadLine();
                    Console.WriteLine("Salário do médico com o benefício = " + m.Beneficio(m.salario));
                    mec.Add(m);
                        foreach (Medico medi in mec)
                        {
                            if (medi.Beneficio(m.salario) > 2000.0)
                            {
                                Console.WriteLine("Os salários acima de 3000 são respectivamente " + medi.nome + " possuindo " + medi.salario);
                            }
                        }
                        break;

                case 2:
                    Administrativo adm = new Administrativo();
                    Console.Write("Digite o nome do Funcionário: ");
                    adm.nome = Console.ReadLine();
                    Console.Write("Digite a matricula do Funcionário: ");
                    adm.matricula = int.Parse(Console.ReadLine());
                    Console.Write("Digite a data de nascimento do Funcionário: ");
                    adm.dataNascimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Digite o sexo do Funcionário: ");
                    adm.sexo = Console.ReadLine();
                    Console.Write("Digite o salário do Funcionário: ");
                    adm.salario = double.Parse(Console.ReadLine());
                    Console.Write("Digite a função do Funcionário: ");
                    adm.funcao = Console.ReadLine();
                    Console.WriteLine("Salário total do ADMINISTRADOR = " + adm.total(adm.salario));
                    admin.Add(adm);
                        foreach (Administrativo a in admin)
                        {
                            if (a.total(adm.salario) > 2000.0)
                            {
                                Console.WriteLine("Os salários acima de 3000 são respectivamente " + a.nome + " possuindo " + a.salario);
                            }
                        }
                        break;
            }
            if(opcao == 4)
            {
                    Console.WriteLine("Obrigado por usar o meu programa");
                    break;
            }
        }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro mencionado " + ex.Message);
        }
    }
}

