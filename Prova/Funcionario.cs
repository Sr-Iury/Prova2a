using System;

public class Funcionario
{
    public string nome { get; set; }
    public int cpf { get; set; }
    public int matricula { get; set; }
    public DateTime dataNascimento { get; set; }
    public string sexo { get; set; }
    public double salario { get; set; }

    public Funcionario()
    {

    }
    public Funcionario(string nome, int matricula, DateTime dataNascimento, string sexo, double salario)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.dataNascimento = dataNascimento;
        this.sexo = sexo;
        this.salario = salario;
    }

}
