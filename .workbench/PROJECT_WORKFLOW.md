# PROJECT_WORKFLOW.md

WORKFLOW_STATUS: aguardando_classificacao

WORKFLOW_COMPLEXITY: pendente
WORKFLOW_SPECIALIZATION: pendente
ACTIVE_WORKFLOW_PATH: pendente

PROJECT_TECHNOLOGIES:
- pendente_de_classificacao

DEFAULT_ENGINEERING_WORKFLOW:
C:\PROJETOS\AI_WORKBENCH\workflows\project-engineering\ENTRYPOINT.md

LOCAL_ENGINEERING_WORKFLOW:
.workbench/workflows/project-engineering/ENTRYPOINT.md

ENGINEERING_WORKFLOW_TEMPLATE:
C:\PROJETOS\AI_WORKBENCH\templates\project-engineering-workflow-template.md

TECHNOLOGY_ENGINEERING_TEMPLATES:

```text
C#:
C:\PROJETOS\AI_WORKBENCH\templates\project-engineering\csharp-engineering-template.md

Angular:
C:\PROJETOS\AI_WORKBENCH\templates\project-engineering\angular-engineering-template.md

Arduino:
C:\PROJETOS\AI_WORKBENCH\templates\project-engineering\arduino-engineering-template.md
```

ENGINEERING_TEMPLATE_RULE:
Quando o projeto possuir tecnologias registradas em PROJECT_TECHNOLOGIES, a IA deve:

```text
1. identificar as tecnologias aplicaveis;
2. localizar os templates de engenharia correspondentes;
3. ler os templates tecnologicos;
4. compor o workflow local de engenharia;
5. adaptar a engenharia a stack tecnologica real do projeto.
```

AI_AUTONOMY_LEVEL: pendente_de_definicao
AI_AUTONOMY_REASON: sera definido durante classificacao ou entrevista inicial
AI_AUTONOMY_SCOPE: bootstrap estrutural concluido; demais escopos pendentes
AI_AUTONOMY_LIMITS: nao implementar codigo de produto sem classificacao, engenharia e aprovacao aplicavel
HUMAN_APPROVAL_REQUIRED_FOR: decisoes arquiteturais, escopo funcional, tecnologias, workflow ativo e autonomia local

CURRENT_ENGINEERING_STATUS: nao_iniciada
CURRENT_DOCUMENTATION_STATUS: documentacao_minima_inicial_criada
CURRENT_IMPLEMENTATION_STATUS: nao_iniciada

NEXT_EXPECTED_STEP: executar_classificacao_do_projeto

CONTINUITY_RULE:
A IA nao deve encerrar o fluxo apenas recomendando a proxima etapa.

Quando nao houver bloqueio, a IA deve:

```text
1. ler .workbench/PROJECT_ENTRYPOINT.md;
2. ler .workbench/PROJECT_WORKFLOW.md;
3. ler .workbench/CURRENT_STAGE.md;
4. identificar NEXT_EXPECTED_STEP;
5. executar ou encaminhar imediatamente para o workflow ativo aplicavel;
6. atualizar CURRENT_STAGE.md ao final da acao executada.
```

WORKFLOW_ROUTING_RULE:
Quando a etapa atual exigir engenharia e arquitetura, a IA deve:

```text
1. verificar se existe:
   .workbench/workflows/project-engineering/ENTRYPOINT.md

2. se existir:
   usar o workflow local do projeto

3. se nao existir:
   usar:
   C:\PROJETOS\AI_WORKBENCH\templates\project-engineering-workflow-template.md

4. carregar templates tecnologicos aplicaveis

5. gerar o workflow local de engenharia

6. transferir o fluxo para o workflow local criado
```

LAST_GOVERNANCE_UPDATE: 2026-05-15
