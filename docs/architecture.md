# Arquitetura — Calculadora_CS

## 1. Visão geral

O projeto Calculadora_CS é uma calculadora simples para estudo de desenvolvimento desktop com Windows Forms utilizando .NET Framework.

O foco principal é:

- simplicidade;
- clareza estrutural;
- aprendizado;
- baixo acoplamento;
- evolução progressiva por ETAPAS.

## 2. Objetivo

Construir uma calculadora básica com:

- visor numérico;
- operações matemáticas fundamentais;
- exibição de até 10 casas decimais.

## 3. Plataforma

```text
Windows Forms (WinForms)
```

## 4. Runtime

```text
.NET Framework
```

## 5. Arquitetura proposta

Arquitetura simples.

Estrutura prevista:

```text
UI
↓
Controle de entrada
↓
Cálculo simples
↓
Atualização do visor
```

Sem múltiplas camadas artificiais.

## 6. Componentes previstos

### Form principal

Responsável pela interface principal da calculadora.

### Visor

Área responsável por exibir:

- números digitados;
- resultados;
- mensagens simples de erro.

### Botões numéricos

Entrada dos dígitos.

### Botões de operações

Operações previstas inicialmente:

- soma;
- subtração;
- multiplicação;
- divisão;
- limpar.

### Controle de entrada

Responsável por:

- controlar estados da operação;
- validar entrada;
- evitar inconsistências simples.

### Serviço simples de cálculo

Poderá existir futuramente para separar:

- UI;
- lógica matemática.

A necessidade será validada posteriormente.

## 7. Precisão do visor

O visor deve suportar visualização de até:

```text
10 casas decimais
```

## 8. Decisões adiadas

Ficam explicitamente adiadas:

- calculadora científica;
- histórico;
- memória;
- parser avançado;
- expressões compostas;
- persistência;
- banco de dados;
- temas visuais avançados;
- plugins;
- internacionalização.
