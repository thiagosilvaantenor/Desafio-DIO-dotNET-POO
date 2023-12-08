# DIO - Trilha .NET - Desafio - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.
Desafio realizado utilizando a linguagem c#

<div align="center">
  
  ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)  ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
  
</div>

## Índice
1. [Titúlo](#dio---trilha-net---desafio---programação-orientada-a-objetos)
2. [Índice](#índice)
3. [Contexto](#contexto) 
4. [Proposta](#proposta)
5. [Regras e validações](#regras-e-validações)
6. [Solução](#solução)
7. [Resultado Final](#resultado-final)
8. [Autor](#autor)


## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Resultado Final
<div align="center">
  
**Status do desafio:**
<br>✅**Finalizado**✅<br>
A tabela abaixo mostra quais foram as alterações feitas em cada classe, caso queira ver o código, basta clicar no nome da classe que deseja ver.
<br><br>


| Classe | Mudanças |
| ------ | -------- |
| [Smarphone](https://github.com/thiagosilvaantenor/Desafio-DIO-dotNET-POO/blob/main/Models/Smartphone.cs)  | Implementado as propriedas que faltavam, todas com o modificador de acesso ``protected`` para que sejam alteradas apenas pelas classes que herdaram;<br>No construtor foi passado os parametros para instanciar a classe. | 
| [Nokia](https://github.com/thiagosilvaantenor/Desafio-DIO-dotNET-POO/blob/main/Models/Nokia.cs) | Realizado a herança dela com a classe ``Smartphone`` ;<br>No metodo ``Instalar Aplitcativo`` foi realizado o overrride para atender ao objetivo da classe|
| [Iphone](https://github.com/thiagosilvaantenor/Desafio-DIO-dotNET-POO/blob/main/Models/Iphone.cs) | Realizado a herança dela com a classe ``Smartphone`` ;<br>No metodo ``Instalar Aplitcativo`` foi realizado o overrride para atender ao objetivo da classe|
| [Program](https://github.com/thiagosilvaantenor/Desafio-DIO-dotNET-POO/blob/main/Program.cs) | Foi criado instancias da classe ``Nokia`` e da classe ``Iphone``, para então realizar os testes chamando os metodos dessas classes;<br>O resultado é mostrado no terminal, como na imagem abaixo:<br>![image](https://github.com/thiagosilvaantenor/Desafio-DIO-dotNET-POO/assets/99970279/73284eb0-e94c-47cd-be11-c13d31ca5e79) |
 
</div>

## Autor
<div align="center">
<a href="https://www.linkedin.com/in/thiago-antenor/">
<img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/99970279?v=4" width="100px;" alt="foto do autor"/>
 <br />
 <sub><b>Thiago Silva Antenor</b></sub></a> <a href="https://www.linkedin.com/in/thiago-antenor/" title="Linkedin"> 🧑🏾‍💻</a>


Feito por Thiago Silva Antenor 👨🏾‍💻 Entre em contato!

[![Linkedin Badge](https://img.shields.io/badge/-Thiago-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/thiago-antenor/)](https://www.linkedin.com/in/thiago-antenor/) 
[![Gmail Badge](https://img.shields.io/badge/-thiagoantenor31@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:thiagoantenor31.com)](mailto:thiagoantenor31.com)
</div>
