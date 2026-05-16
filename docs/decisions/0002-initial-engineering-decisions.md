# ADR 0002 — Engenharia inicial da calculadora

## Status

Aprovada em 2026-05-16.

## Decisoes registradas

```text
- A calculadora deve possuir as quatro operacoes basicas.
- A calculadora deve possuir porcentagem.
- A calculadora deve possuir raiz quadrada (sqr).
- A calculadora deve possuir funcoes de memoria M, M+, M- e MC.
- A calculadora deve possuir historico visual de 4 linhas abaixo da tela atual.
- A calculadora deve exibir resultados com ate 10 casas decimais.
- O alvo de implementacao inicial deve ser `net9.0-windows`.
- O inicio da implementacao inicial esta autorizado.
```

## Ambiente verificado

```text
DOTNET_SDKS:
- 9.0.313
- 9.0.314

DOTNET_ACTIVE_VERSION: 9.0.314
```

## Memoria

```text
MR: recupera o valor da memoria para o display.
M+: soma o valor atual do display a memoria.
M-: subtrai o valor atual do display da memoria.
MC: limpa a memoria.
```

## Consequencia

A implementacao inicial pode criar a solution, o projeto Windows Forms e testes da logica de calculo, respeitando a separacao minima entre UI e core.
