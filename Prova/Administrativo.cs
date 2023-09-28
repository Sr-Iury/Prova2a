using System;

public class Administrativo : Funcionario
{
    public string funcao { get; set; }

    public Administrativo()
    {

    }
    public Administrativo(string funcao, string nome, int matricula, DateTime dataNascimento, string sexo, double salario)
    {
        this.funcao = funcao;
        this.nome = nome;
        this.matricula = matricula;
        this.cpf = cpf;
        this.salario = salario;
        this.dataNascimento = dataNascimento;
        this.sexo = sexo;
    }
    public double totalADM(double salario)
    {
        return this.salario + 250.0;
    }
    public double Valealimentacao(double salario)
    {
        return this.salario + ((17.0 / 100.0) * salario);
    }
    public double total(double salario)
    {
        return (this.salario + ((17.0 / 100.0) * salario)) + 250.0;
    }
}
