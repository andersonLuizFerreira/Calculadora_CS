# ADR 0002 — Engenharia inicial da calculadora

## Status

Proposta em 2026-05-16. Pendente de confirmacao para inicio da implementacao.

## Decisoes registradas

```text
- A calculadora deve possuir as quatro operacoes basicas.
- A calculadora deve possuir porcentagem.
- A calculadora deve possuir raiz quadrada (sqr).
- A calculadora deve possuir funcoes de memoria M, M+, M- e MC.
- A calculadora deve possuir historico de calculos.
- A calculadora deve exibir resultados com ate 10 casas decimais.
```

## Ambiente verificado

```text
DOTNET_SDKS:
- 9.0.313
- 9.0.314

DOTNET_ACTIVE_VERSION: 9.0.314
```

## Decisao pendente

Usar `net9.0-windows` como alvo do projeto Windows Forms inicial.

## Consequencia

Enquanto o alvo .NET e o inicio da implementacao nao forem confirmados, a IA deve manter o projeto em etapa de engenharia/documentacao e nao criar codigo de produto.
