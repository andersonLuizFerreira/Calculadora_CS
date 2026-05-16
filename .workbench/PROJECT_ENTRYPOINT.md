# PROJECT_ENTRYPOINT.md

Este arquivo e o ponto de entrada operacional local do projeto Calculadora_CS.

## 1. Identidade do projeto

```text
PROJECT_NAME: Calculadora_CS
PROJECT_REMOTE_REPOSITORY: https://github.com/andersonLuizFerreira/Calculadora_CS.git
PROJECT_LOCAL_PATH: C:\PROJETOS\Calculadora_CS
PROJECT_MAIN_BRANCH: main
```

## 2. Referencia da Workbench

```text
WB_REPOSITORY: https://github.com/andersonLuizFerreira/AI_WORKBENCH.git
WB_LOCAL_PATH: C:\PROJETOS\AI_WORKBENCH
WB_GLOBAL_ENTRYPOINT: C:\PROJETOS\AI_WORKBENCH\ENTRYPOINT.md
WB_BOOTSTRAP_WORKFLOW: C:\PROJETOS\AI_WORKBENCH\workflows\project-bootstrap\ENTRYPOINT.md
WB_GOVERNANCE_SKILL: C:\PROJETOS\AI_WORKBENCH\skills\governance-rules\SKILL.md
```

## 3. Estado local do projeto

```text
PROJECT_STATUS: bootstrap_concluido
PROJECT_TYPE: novo_com_repositorio_criado
BOOTSTRAP_STATUS: concluido
```

## 4. Arquivos locais obrigatorios

```text
LOCAL_ENTRYPOINT: .workbench/PROJECT_ENTRYPOINT.md
LOCAL_WORKFLOW: .workbench/PROJECT_WORKFLOW.md
LOCAL_CURRENT_STAGE: .workbench/CURRENT_STAGE.md
```

## 5. Estrutura universal obrigatoria

```text
REQUIRED_DIRECTORIES:
- .workbench/
- docs/
- dumps/
- tests/
```

REGRA:
Essas pastas devem existir em todo projeto governado pela AI_WORKBENCH.

## 6. Estrutura minima obrigatoria de docs

```text
REQUIRED_DOCS_DIRECTORIES:
- docs/requirements/
- docs/architecture/
- docs/decisions/
- docs/validation/
```

RESPONSABILIDADES:

```text
docs/requirements/  -> requisitos, escopo e regras funcionais aprovadas
docs/architecture/  -> arquitetura, engenharia tecnica, modulos, contratos e diagramas
docs/decisions/     -> decisoes arquiteturais e registros ADR
docs/validation/    -> criterios de aceite, validacao e evidencias tecnicas
```

## 7. Workflow ativo

```text
ACTIVE_WORKFLOW: nao_definido
NEXT_CONTEXT: .workbench/PROJECT_WORKFLOW.md
```

## 8. Regra de prioridade local/global

```text
LOCAL_RULE_PRIORITY:
As regras locais deste projeto sao verdadeiras enquanto sua cobertura existir.
Quando a cobertura acabar, consultar a WB antes de decidir.
```

## 9. Proximo passo obrigatorio

Apos ler este arquivo, a IA deve:

```text
1. validar REQUIRED_DIRECTORIES;
2. criar pastas obrigatorias ausentes, se necessario;
3. validar REQUIRED_DOCS_DIRECTORIES;
4. criar pastas obrigatorias de docs ausentes, se necessario;
5. ler .workbench/PROJECT_WORKFLOW.md;
6. ler .workbench/CURRENT_STAGE.md.
```

Depois deve seguir o workflow ativo registrado no projeto local.
