# Arquitetura inicial da calculadora

## Tipo de aplicacao

```text
APPLICATION_TYPE: Desktop
UI: Windows Forms
LANGUAGE: C#
RUNTIME_AVAILABLE_ON_SYSTEM: .NET SDK 9.0.314
TARGET_FRAMEWORK: net9.0-windows
```

## Separacao de responsabilidades

A aplicacao deve manter separacao minima entre interface e regras de calculo.

```text
UI Windows Forms
Responsavel por entrada do usuario, exibicao de valores e interacao com historico.

Calculator Core
Responsavel por operacoes matematicas, memoria, arredondamento/exibicao e validacoes numericas.

History
Responsavel por armazenar as 4 linhas mais recentes exibidas ao usuario durante a sessao.
```

## Namespaces iniciais propostos

```text
CalculadoraCS
CalculadoraCS.Core
CalculadoraCS.History
CalculadoraCS.UI
```

## Regras tecnicas

```text
- nao colocar logica de calculo pesada diretamente no Form;
- centralizar operacoes em classe de servico ou motor de calculo;
- tratar divisao por zero;
- tratar raiz quadrada de numero negativo;
- aplicar exibicao com ate 10 casas decimais;
- manter historico desacoplado da UI quando possivel.
- implementar memoria com MR, M+, M- e MC no core.
```

## Build

Usar SDK .NET disponivel no sistema. Foi detectado:

```text
9.0.313
9.0.314
```

O alvo confirmado para implementacao inicial e `net9.0-windows`.
