using System;
public class Medico : Funcionario
{

    public string crm { get; set; }
    public double horaExtra { get; set; }
    public string especialidade { get; set; }
    public Medico()
    {

    }
    public Medico(string funcao, string nome, int matricula, DateTime dataNascimento, string sexo, double salario, string crm, double horaExtra, string especialidade)
    {
        this.crm = crm;
        this.horaExtra = horaExtra;
        this.especialidade = especialidade;
        this.nome = nome;
        this.matricula = matricula;
        this.cpf = cpf;
        this.salario = salario;
        this.dataNascimento = dataNascimento;
        this.sexo = sexo;
    }

    public double Beneficio(double salario)
    {
        double saldo = salario + ((22.0 / 100) * salario);
        return saldo;
    }
}
