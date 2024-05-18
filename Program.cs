﻿/*using Modelo;*/

/*              Questão 1
double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Adicao.Somar(N1, N2));
*/

/*              Questão 3
double N1 = Convert.ToDouble(Console.ReadLine());
double N2 = Convert.ToDouble(Console.ReadLine());
double N3 = Convert.ToDouble(Console.ReadLine());

Maximus.Max(N1, N2, N3);
*/

/*
int Menores = 0;
int Maiores = 0;

int[] notas = new int [20] {5,6,3,8,5,3,4,5,7,5,3,10,2,8,2,5,8,8,9,4};
    for(int i = 0; i < notas.Length; i++){
        Console.WriteLine(notas[i]);
        if(notas[i] >=6)
            Maiores++;

        if(notas[i] <6)
            Menores++;
    }

Console.WriteLine("Maiores: " + Maiores + "\nMenores: " + Menores);
*/

/*
MenuItem itemNivel1 = new MenuItem("Arquivo");

MenuItem itemNivel11 = new MenuItem("Salvar Como");
MenuItem itemNivel12 = new MenuItem("Exportar");
MenuItem itemNivel13 = new MenuItem("Imprimir");
MenuItem itemNivel14 = new MenuItem("Compartilhar");
MenuItem itemNivel15 = new MenuItem("Enviar email");

MenuItem itemNivel121 = new MenuItem("PDF");
MenuItem itemNivel122 = new MenuItem("Imagem");
MenuItem itemNivel123 = new MenuItem("Rascunho");

// Monta o nível 1

itemNivel1.itens.Add(itemNivel11);
itemNivel1.itens.Add(itemNivel12);
itemNivel1.itens.Add(itemNivel13);
itemNivel1.itens.Add(itemNivel14);
itemNivel1.itens.Add(itemNivel15);

// Insere os subitens
itemNivel12.itens.Add(itemNivel121);
itemNivel12.itens.Add(itemNivel122);
itemNivel12.itens.Add(itemNivel123);

void ImprimirMenuItem(MenuItem menuItem, int nivel){
    Console.WriteLine(menuItem.descricao.PadLeft(nivel));

    
}

ImprimirMenuItem(itemNivel1, 0);
*/

/*
using System.Collections.Generic;

Queue<string> pedidos = new Queue<string>();

int operacao = -1;
while(operacao != 4){
    Console.WriteLine("Seja bem vindo. Escolha sua operação");
    Console.WriteLine("1 - para listar");
    Console.WriteLine("2 - para cadastrar");
    Console.WriteLine("3 - para atender");
    Console.WriteLine("4 - sair");
    operacao = Convert.ToInt16(Console.ReadLine());

    if(operacao == 4) break;
    if(operacao == 1) Listar(pedidos);
    if(operacao == 2) Cadastrar(pedidos);
    if(operacao == 3) Atender(pedidos);
}

pedidos.Dequeue();

void Listar(Queue<string> fila){
    foreach(string e in fila)
        Console.WriteLine(e);

    Console.WriteLine("--------------");
}

void Cadastrar(Queue<string> fila){
    Console.WriteLine("Pôr nome do cliente");
    string cliente = Console.ReadLine() ?? "";
    fila.Enqueue(cliente);
}

void Atender (Queue<string> fila){
    string cliente = fila.Dequeue();
    Console.WriteLine("Cliente atendido: " + cliente);
}
*/

using System.Collections.Generic;

Queue<string> funcionarios = new Queue<string>();

int operacao = -1;
while(operacao != 3){
    Console.WriteLine("Seja bem vindo. Escolha sua operação");
    Console.WriteLine("1 - para listar");
    Console.WriteLine("2 - para cadastrar");
    Console.WriteLine("3 - sair");
    operacao = Convert.ToInt16(Console.ReadLine());

    if(operacao == 3) break;
    if(operacao == 1) Listar(funcionarios);
    if(operacao == 2) Cadastrar(funcionarios);
}

void Listar(Queue<string> fila){
    foreach(string e in fila)
        Console.WriteLine(e);

    Console.WriteLine("--------------");
}

void Cadastrar(Queue<string> fila){
    Console.WriteLine("Pôr nome do cliente");
    string cliente = Console.ReadLine() ?? "";
    fila.Enqueue(cliente);
}
