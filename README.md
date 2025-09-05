<a href="https://fontmeme.com/fonts/aaargh-font/"><img src="https://fontmeme.com/permalink/250905/0744498a2337363a7c715cfe2a6bc34e.png" alt="aaargh-font" border="0"></a>


## 📱 Sobre o Projeto

Este projeto tem como objetivo simular o funcionamento básico de um sistema de smartphone, permitindo ligar, receber chamadas e instalar APP. A estrutura principal é composta por três classes: `Smartphone`, `Nokia` e `iPhone`.
Foi solicitado que você faça uma abstração de um celular e disponibilize formas de diferentes marcas e modelos tendo seu próprio comportamento, possibilitando um maior uso de código e usando a orientação a objetos

### Estrutura das Classes

- **Smartphone**: Classe base que define funcionalidades comuns, como ligar, receber chamadas e instalar APP.
- **Nokia**: Herda de `Smartphone` e implementa comportamentos específicos para aparelhos Nokia, podendo ter métodos próprios ou variações na forma como executa operações.
- **iPhone**: Também herda de `Smartphone`, mas possui comportamentos distintos, refletindo características exclusivas dos dispositivos iPhone.

Cada classe demonstra conceitos de orientação a objetos, como herança e polimorfismo, permitindo que Nokia e iPhone se comportem de maneira diferente ao executar métodos como instalar APP. O projeto foca em encapsulamento e interação entre classes, simulando operações comuns de um smartphone com variações conforme o modelo.

## 📄 Proposta
Um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Você deve criar suas classes de acordo com o diagrama abaixo

![Diagrama](./Images/diagrama.png)

## 🔒 Regras e validações

- A classe Smartphone deve ser abstrata, não permitindo instanciar e operar apenas como modelo.
- A classe Nokia e Iphone devem ser classes filhas de Smartphone.
- O método de instalaçãoAplicativo deve ser escrito na classe Nokia e iPhone, pois ambos possuem maneiras diferentes de instalar um aplicativo.

## 🧱 Estrutura da Classe Smartphone

### 🔸 Atributos

- **numero** (`string`):  
  Numero Telefone.

- **modelo** (`string`):  
  Modelo do Aparelho.

- **imei** (`string`):  
  Numero de identificação unica.

- **memoria** (`int`):  
  Capacidade de armazenamento.  

---

### 🔹 Métodos

#### `Ligar()`

- **Função**: Fazer ligação.
- **Comportamento**: Exibe mensagem de ligando.

#### `ReceberLigação()`

- **Função**: Receber ligação.
- **Comportamento**: Exibe mensagem de Recebendo ligação.

#### `InstalarAplicativo()`

- **Função**: Instalar Aplicativo.
- **Entrada esperada**: Aplicatico (`string`), fornecida pelo usuário.
- **Comportamento**: Exibe a mensensagem de aplicatico sendo instalado - As Classes (`Iphone`) e (`Nokia`) herdam da classe (`Smartphone`) porem cada um tem o seu comportamento repeitando o que foi implementado em sua classe.

---

## 🔁 Fluxo de Funcionamento (Resumo)

- Instancia as classes chamando de acordo com o que precisa.
- O usuário escolhe uma das opções:
  - Se **liga**, 
  - Se **recebeLigação**, 
  - Se **InstalarApp**, o sistema exibe a mensagem de acordo com o comportamento de cada classe chamada.
- O programa se **"encerrar"**.

---




## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

