# Requisitos da calculadora

## Escopo do primeiro incremento

Aplicacao desktop Windows Forms para Windows, implementada em C#/.NET.

## Operacoes obrigatorias

```text
- adicao
- subtracao
- multiplicacao
- divisao
- porcentagem
- raiz quadrada (sqr)
- memoria (M)
- memoria somar (M+)
- memoria subtrair (M-)
- limpar memoria (MC)
```

## Historico

A primeira versao deve exibir historico de 4 linhas abaixo da tela atual. O historico e visual durante a sessao e nao deve ser persistido em arquivo ou banco neste incremento.

## Memoria

```text
MR: recupera o valor da memoria para a tela atual.
M+: soma o valor da tela atual ao valor armazenado em memoria.
M-: subtrai o valor da tela atual do valor armazenado em memoria.
MC: limpa a memoria.
```

## Porcentagem

O botao `%` deve seguir comportamento padrao de calculadora Windows.

## Precisao numerica

Resultados devem considerar exibicao com ate 10 casas decimais.

## Decisoes confirmadas

```text
- alvo .NET: net9.0-windows;
- inicio de implementacao autorizado;
- historico limitado a 4 linhas visiveis abaixo da tela atual;
- memoria conforme MR, M+, M- e MC.
```
