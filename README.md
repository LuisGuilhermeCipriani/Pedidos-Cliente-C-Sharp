# 🧾 Sistema de Pedidos de Cliente (C#)

Este projeto é uma aplicação de console desenvolvida em C# que simula o cadastro de um cliente e a criação de um pedido com múltiplos itens.

## 📌 Funcionalidades

* Cadastro de cliente:

  * Nome
  * Email
  * Data de nascimento
* Criação de pedido com:

  * Status do pedido
  * Data e hora automática
* Adição de múltiplos itens ao pedido:

  * Nome do produto
  * Preço
  * Quantidade
* Cálculo automático do total do pedido
* Exibição de resumo completo do pedido

---

## 🧱 Estrutura do Projeto

O projeto está organizado em namespaces e classes:

### 📁 `Entities`

* `Client`: representa o cliente
* `Product`: representa o produto
* `OrderItem`: representa um item do pedido
* `Order`: representa o pedido completo

### 📁 `Entities.Enums`

* `OrderStatus`: enumeração com os estados do pedido

---

## 🔄 Fluxo do Programa

1. O usuário insere os dados do cliente
2. Define o status do pedido
3. Informa quantos itens deseja adicionar
4. Para cada item:

   * Nome do produto
   * Preço
   * Quantidade
5. O sistema gera um resumo completo do pedido

---

## 🧮 Regras de Negócio

* O subtotal de cada item é calculado por:

  ```
  Subtotal = Quantidade * Preço
  ```
* O total do pedido é a soma dos subtotais dos itens
* A data do pedido é definida automaticamente com `DateTime.Now`

---

## 📋 Exemplo de Saída

```
ORDER SUMMARY:
Order moment: 30/03/2026 14:30:25
Order status: Processing
Client: Maria Silva, (15/04/1990) - maria@email.com
Order items:
Notebook, $1200.00, Quantity: 1, Subtotal: $1200.00
Mouse, $25.00, Quantity: 2, Subtotal: $50.00
Total price: $1250.00
```

---

## ⚙️ Tecnologias Utilizadas

* C#
* .NET (Console Application)
* Programação Orientada a Objetos (POO)

---

## 🚀 Como Executar

1. Clone o repositório:

   ```
   git clone https://github.com/LuisGuilhermeCipriani/Pedidos-Cliente-C-Sharp.git
   ```

2. Acesse a pasta do projeto:

   ```
   cd Pedidos-Cliente-C-Sharp
   ```

3. Compile e execute:

   ```
   dotnet run
   ```

---

## 📚 Conceitos Aplicados

* Encapsulamento
* Composição de objetos
* Enumerações
* Sobrescrita de métodos (`ToString`)
* Manipulação de datas
* Listas (`List<T>`)

---

## 👨‍💻 Autor

Luís Guilherme da Cunha Cipriani
https://github.com/LuisGuilhermeCipriani
