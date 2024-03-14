# Desafio da Target Sistemas

## Questão 1
> Observe o trecho de código abaixo:

```
int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);
```
**Resposta:** 91

<i>[Ilustrando a questão em C#](https://github.com/rdgthedev/teste-target-sistemas/blob/main/Soma/Program.cs)</i>


## Questão 2 
> Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

**Resposta:** para realizar esta questão fiz um algoritmo utilizando a linguagem C#, na qual é a que eu tenho mais familiaridade atualmente.

<i>[Sequência de Fibonacci em C#](https://github.com/rdgthedev/teste-target-sistemas/blob/main/Fibonacci/GenerateFibonacci.cs)</i>

## Questão 3
> Descubra a lógica e complete o próximo elemento:


a) 1, 3, 5, 7, <code>**9**</code>

b) 2, 4, 8, 16, 32, 64, <code>**128**</code>

c) 0, 1, 4, 9, 16, 25, 36, <code>**49**</code>

d) 4, 16, 36, 64, <code>**100**</code>

e) 1, 1, 2, 3, 5, 8, <code>**13**</code>

f) 2,10, 12, 16, 17, 18, 19, <code>**200**</code>


<i>[Ilustrando as sequências acima em C#](https://github.com/rdgthedev/teste-target-sistemas/tree/main/DescubraALogica)</i>

## Questão 4
> Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

> Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

```
Eu ligaria o interruptor 1 por 15 minutos, após isso eu desligaria, em seguida ligaria o interruptor 2 e faria a primeira ida:

Primeira ida: 
	- Caso a lâmpada esteja acesa corresponderá ao interruptor 2.
	- Caso a lâmpada esteja desligada e quente, corresponde ao interruptor 1, pois o mesmo ficou 15 minutos acionado.
	- Caso a lâmpada esteja desligada e fria, corresponde ao interruptor 3, pois ainda não foi acionado.


Na primeira ida confirmamos a qual lâmpada pertence um dos interruptores, para a segunda ida deixaremos um interruptor ligado e um desligado.

Segunda ida:
	- Caso a lâmpada esteja acesa ela corresponde ao interruptor que ficou ligado e a outra ao interruptor que ficou desligado.
	- Caso a lâmpada esteja pagada ela corresponde ao interruptor que ficou desligado e a outra ao interruptor que ficou ligado.
```


## Questão 5
> Escreva um programa que inverta os caracteres de um string.

> **IMPORTANTE:**

> a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

> b) Evite usar funções prontas, como, por exemplo, reverse;

**Resposta:** para efetuar utilizei o C# para desenvolver um algoritmo que inverte uma string. Para efetuar esse teste utilizei apenas a linguagem C# pura e negligenciei o uso de bibliotecas que possuem métodos que poderiam facilitar essa tarefa. 

<i>[Invertendo uma string em C#](https://github.com/rdgthedev/teste-target-sistemas/blob/main/StringReverse/Program.cs)</i>


## Passo a passo para rodar os algoritmos:

### IDEs:</strong>

> Visual Studio Code (Windows e Linux): https://code.visualstudio.com/

> Visual Studio Community (Windows): https://visualstudio.microsoft.com/pt-br/vs/community/

### Baixe o SDK do .NET e instale:
> Link para baixar o SDK: https://dotnet.microsoft.com/pt-br/download

### Para executar:
> Abra o terminal e acesse a pasta do algoritmo que deseja executar utilizando o comando <strong><code>cd</code></strong> e o nome da pasta na frente

> Com a pasta aberta no terminal utilize o comando <strong><code>dotnet run</code></strong>
