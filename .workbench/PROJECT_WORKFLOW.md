# PROJECT_WORKFLOW.md

WORKFLOW_STATUS: classificacao_concluida

WORKFLOW_COMPLEXITY: simples
WORKFLOW_SPECIALIZATION: desktop_windows_forms

PROJECT_TECHNOLOGIES:
- C#
- .NET
- Windows Forms

PROJECT_APPLICATION_TYPE: Desktop
PROJECT_PLATFORMS:
- Windows

IMPLEMENTATION_AGENT: Codex

RECOMMENDED_SPECIALIZED_WORKFLOW:
C:\PROJETOS\AI_WORKBENCH\workflows\simple-projects\desktop\ENTRYPOINT.md

RECOMMENDED_SPECIALIZED_WORKFLOW_STATUS: inexistente_na_wb

ACTIVE_WORKFLOW_PATH: .workbench/workflows/project-engineering/ENTRYPOINT.md

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

AI_AUTONOMY_LEVEL: baixa
AI_AUTONOMY_REASON: decisao humana informada durante classificacao inicial
AI_AUTONOMY_SCOPE: a IA pode executar apenas etapas explicitamente aprovadas e tarefas estruturais previstas pela AI_WORKBENCH
AI_AUTONOMY_LIMITS: nao implementar codigo de produto, definir arquitetura, alterar escopo ou registrar regras funcionais sem aprovacao humana
HUMAN_APPROVAL_REQUIRED_FOR: decisoes arquiteturais, escopo funcional, tecnologias, workflow ativo, alteracoes de governanca e inicio de implementacao

CURRENT_ENGINEERING_STATUS: aguardando_entrevista_inicial
CURRENT_DOCUMENTATION_STATUS: classificacao_inicial_registrada
CURRENT_IMPLEMENTATION_STATUS: nao_iniciada

NEXT_EXPECTED_STEP: executar_entrevista_inicial_de_engenharia

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

LAST_GOVERNANCE_UPDATE: 2026-05-16
