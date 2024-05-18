using Modelo;
using Data;

Funcionario funcionario = new Funcionario("Weslley", "Diretor geral");

Funcionario f1 = new Funcionario("bekaa", "Diretor financeiro");
Funcionario f2 = new Funcionario("Jerferson", "Gerente financeiro");
Funcionario f3 = new Funcionario("Pedro", "Auxiliar financeiro 1");
Funcionario f4 = new Funcionario("José", "Analista financeiro");


Funcionario f5 = new Funcionario("Jonh", "Diretor de Vendas");
Funcionario f6 = new Funcionario("Renan", "Vendedor");
Funcionario f7 = new Funcionario("Darlan", "Vendedor");

List<No> arvore = new List<No>();

No NoPresidente = new No();

No NoDiretorFinanceiro = new No();
No NoGerenteFinanceiro = new No();
No NoAuxiliarFinanceiro = new No();
No NoAnalistaFinanceiro = new No();

No NoDiretorVenda = new No();
No NoVendedor1 = new No();
No NoVendedor2 = new No();

NoDiretorFinanceiro.valor = f1;
NoGerenteFinanceiro.valor = f2;
NoAuxiliarFinanceiro.valor = f3;
NoAnalistaFinanceiro.valor = f4;

NoDiretorFinanceiro.Add(NoDiretorFinanceiro);
NoGerenteFinanceiro.Add(NoAnalistaFinanceiro);
NoGerenteFinanceiro.Add(NoAuxiliarFinanceiro);

NoDiretorVenda.valor = f5;
NoVendedor1.valor = f6;
NoVendedor2.valor = f7;

NoPresidente.valor = funcionario;
NoPresidente.Add(NoDiretorFinanceiro);
NoPresidente.Add(NoDiretorVenda);


