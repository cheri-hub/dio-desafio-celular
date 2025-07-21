# Desafio POO - Sistema de Celulares

Este projeto faz parte do desafio proposto na formação .NET da Digital Innovation One (DIO), com o objetivo de aplicar os conceitos de Programação Orientada a Objetos (POO) em C#.

## 💡 Descrição

Modelamos um sistema de celulares com uma classe base abstrata (`Smartphone`) e duas classes concretas (`Nokia` e `Iphone`) que implementam comportamentos específicos, promovendo reutilização de código e polimorfismo.

## 📁 Estrutura

- `Smartphone.cs`: Classe base abstrata com propriedades e métodos comuns.
- `Nokia.cs`: Classe concreta representando um celular da marca Nokia.
- `Iphone.cs`: Classe concreta representando um celular da marca Apple.
- `Program.cs`: Contém testes de instanciamento e execução dos métodos.

## 🚀 Como executar

Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

Clone este repositório ou baixe os arquivos:

```bash
git clone https://github.com/seu-usuario/seu-repo.git
cd dio-desafio-celular
```

Execute o projeto com:

```bash
dotnet build
dotnet run
```

Você verá a seguinte saída simulando chamadas e instalações de aplicativos em diferentes celulares:

```
Smartphone Nokia:
Ligando...
Instalando o aplicativo "WhatsApp" no Nokia...

Smartphone iPhone:
Recebendo ligação...
Instalando o aplicativo "Instagram" no iPhone...
```

## 🛠️ Tecnologias

- C#
- .NET 6 ou superior

## 🧠 Conceitos aplicados

- Abstração
- Herança
- Polimorfismo
- Encapsulamento

---

Desenvolvido como parte da formação .NET da DIO.