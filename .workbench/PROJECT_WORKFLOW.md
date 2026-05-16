# PROJECT_WORKFLOW — Calculadora_CS

## 1. Workflow ativo

Tipo de projeto:

```text
Projeto simples de estudo
```

## 2. Plataforma

```text
Windows Forms (WinForms)
```

## 3. Runtime

```text
.NET Framework
```

## 4. Arquitetura aprovada

Arquitetura simples.

Objetivo:

- clareza para estudo;
- baixo acoplamento;
- evitar complexidade desnecessária.

## 5. Restrições arquiteturais

Não utilizar:

- DAL complexa;
- BLL complexa;
- Repository Pattern;
- MVVM;
- múltiplas camadas artificiais;
- persistência;
- banco de dados.

## 6. Diretrizes obrigatórias

- documentação antes de implementação;
- ETAPAS pequenas e validadas;
- sem expansão silenciosa de escopo;
- sem criação de funcionalidades não aprovadas;
- sem arquitetura excessiva.

## 7. Fluxo operacional

```text
Documentação
↓
Arquitetura
↓
Estrutura da solução
↓
UI base
↓
Motor de cálculo
↓
Integração
↓
Validação
↓
Consolidação
```

## 8. Regra de governança

Qualquer mudança estrutural relevante deve:

```text
1. ser documentada;
2. ser validada;
3. ser aprovada;
4. somente depois virar fonte de verdade.
```
