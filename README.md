# 🪤 Jogo da Forca

> Jogo da forca em C# com foco em seleção aleatória de palavras, validação de entrada e controle de estado do jogo.

---

## 📋 Sobre o Projeto

O **Jogo da Forca** é uma aplicação console desenvolvida em C# que recria o clássico jogo de adivinhação de palavras. O jogador tenta descobrir a palavra oculta letra a letra, tendo um número limitado de tentativas antes de perder. O projeto explora conceitos de seleção aleatória, validação de entradas do usuário e gerenciamento de estado ao longo de uma partida.

---

## ✨ Funcionalidades

- Seleção aleatória de palavras a cada partida
- Exibição da palavra oculta com lacunas (`_ _ _ _ _`)
- Registro e validação das letras já tentadas
- Controle do número de erros e vidas restantes
- Desenho progressivo da forca no console
- Detecção de vitória ao completar a palavra
- Detecção de derrota ao esgotar as tentativas

---

## 🗂️ Estrutura do Projeto

```
jogo-da-forca-adp/
├── jogo-da-forca-adp.ConsoleApp/   # Projeto principal (console)
├── .vscode/                        # Configurações do VS Code
├── jogo-da-forca-adp.slnx          # Arquivo de solução .NET
└── .gitignore
```

---

## 🚀 Como Executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/pedrohenriquedsdev/jogo-da-forca-adp.git
   cd jogo-da-forca-adp
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project jogo-da-forca-adp.ConsoleApp
   ```

---

## 🎮 Como Funciona

1. O jogo sorteia uma palavra aleatória do banco de palavras
2. A palavra é exibida como lacunas: `_ _ _ _ _`
3. O jogador digita uma letra por vez
4. Se a letra estiver na palavra, as posições correspondentes são reveladas
5. Se a letra não estiver, um erro é contabilizado e a forca avança
6. O jogo termina com **vitória** ao revelar todas as letras, ou com **derrota** ao atingir o limite de erros

**Exemplo de partida:**

```
  _____
 |     |
 |     O
 |    /|\
 |    / \
_|_

Palavra: _ R _ _ _ _ M _ _
Letras tentadas: A, E, R, T

Digite uma letra: O
✅ Acertou! A letra 'O' está na palavra.

Palavra: _ R O _ _ _ M _ _
```

---

## 🛠️ Tecnologias Utilizadas

- **C#** — linguagem principal
- **.NET** — plataforma de execução
- **Console App** — interface de entrada e saída
- **`Random`** — seleção aleatória de palavras

---

## 💡 Conceitos Abordados

- Seleção aleatória com `Random`
- Validação e tratamento de entrada do usuário
- Controle de estado do jogo (vidas, letras tentadas, progresso)
- Manipulação de `strings` e `arrays` de caracteres
- Estruturas condicionais e de repetição
- Programação orientada a objetos em C#

---

## 🌿 Branches

| Branch | Descrição               |
|--------|-------------------------|
| `v1`   | Versão inicial do jogo  |

---

## 👤 Autor

**Pedro Henrique**

[![GitHub](https://img.shields.io/badge/GitHub-pedrohenriquedsdev-181717?style=flat&logo=github)](https://github.com/pedrohenriquedsdev)

---

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.
