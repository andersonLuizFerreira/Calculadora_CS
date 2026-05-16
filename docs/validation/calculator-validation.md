# Validacao inicial da calculadora

## Criterios funcionais

```text
- deve calcular adicao corretamente;
- deve calcular subtracao corretamente;
- deve calcular multiplicacao corretamente;
- deve calcular divisao corretamente;
- deve impedir ou sinalizar divisao por zero;
- deve calcular porcentagem conforme comportamento padrao de calculadora Windows;
- deve calcular raiz quadrada de valores validos;
- deve impedir ou sinalizar raiz quadrada de numero negativo;
- deve executar M, M+, M- e MC conforme comportamento aprovado;
- deve registrar os 4 calculos mais recentes no historico visual;
- deve exibir resultados com ate 10 casas decimais.
```

## Criterios tecnicos

```text
- build do projeto deve concluir sem erros;
- regras de calculo nao devem ficar acopladas exclusivamente ao Form;
- testes ou validacao manual devem cobrir as operacoes principais;
- comportamento de erro deve ser verificavel pela interface.
```

## Validacoes confirmadas para o primeiro incremento

```text
- target framework: net9.0-windows;
- memoria: MR, M+, M-, MC;
- historico: 4 linhas visuais durante a sessao;
- persistencia de historico: fora do escopo.
```

## Evidencia de validacao

Validado em 2026-05-16:

```text
dotnet test Calculadora_CS.sln
Resultado: 6 testes aprovados, 0 falhas

dotnet build Calculadora_CS.sln --no-restore
Resultado: build concluido com 0 erros e 0 avisos
```
