# ENTRYPOINT — Engenharia Local do Projeto Calculadora_CS

Este workflow local governa a etapa de engenharia do projeto Calculadora_CS.

## 1. Proposito

Transformar a ideia do produto em requisitos, arquitetura, decisoes e criterios de validacao suficientes para futura implementacao controlada.

## 2. Contextos obrigatorios

Antes de executar esta etapa, a IA deve ler:

```text
1. .workbench/PROJECT_ENTRYPOINT.md
2. .workbench/PROJECT_WORKFLOW.md
3. .workbench/CURRENT_STAGE.md
4. C:\PROJETOS\AI_WORKBENCH\skills\governance-rules\SKILL.md
5. C:\PROJETOS\AI_WORKBENCH\docs\workbench-layered-responsibilities.md
6. C:\PROJETOS\AI_WORKBENCH\templates\project-engineering\csharp-engineering-template.md
```

## 3. Classificacao registrada

```text
COMPLEXIDADE: simples
TIPO: Desktop
PLATAFORMA: Windows
TECNOLOGIAS:
- C#
- .NET
- Windows Forms
AUTONOMIA_LOCAL_DA_IA: baixa
```

## 4. Regras especificas para C# Windows Forms

A IA deve documentar em `docs/architecture/` antes da codificacao:

```text
- versao alvo do .NET;
- tipo de aplicacao C#;
- estrategia de separacao entre UI e regras de calculo;
- namespaces principais;
- contratos entre interface e logica de calculo;
- estrategia de build;
- estrategia de testes;
- dependencias externas, se existirem.
```

A IA deve evitar:

```text
- logica de negocio pesada dentro de Forms;
- acoplamento direto da UI com infraestrutura futura;
- classes utilitarias genericas sem responsabilidade clara;
- implementacao de codigo antes da aprovacao dos requisitos.
```

## 5. Entrevista inicial obrigatoria

A proxima etapa deve levantar apenas o necessario para engenharia inicial:

```text
1. operacoes matematicas desejadas;
2. comportamento esperado da interface;
3. versao alvo do .NET;
4. necessidade ou nao de historico de calculos;
5. criterios basicos de validacao;
6. limites explicitos do primeiro incremento.
```

## 6. Saidas esperadas

A etapa de engenharia deve atualizar ou criar documentos em:

```text
docs/requirements/
docs/architecture/
docs/decisions/
docs/validation/
```

## 7. Bloqueios

A IA deve parar e pedir confirmacao humana quando houver:

```text
- escolha de versao do .NET;
- decisao de arquitetura de camadas;
- inclusao de persistencia, historico ou integracao externa;
- mudanca de tipo de aplicacao;
- inicio de implementacao;
- alteracao da autonomia local.
```

## 8. Proximo passo

Conduzir entrevista inicial de engenharia e registrar as respostas aprovadas na documentacao do projeto.
