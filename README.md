# GeoStrike

**Em desenvolvimento**

GeoStrike é um jogo de estratégia militar e gerenciamento em tempo real (MMORTS) com persistência de dados. O jogador progride sua base, toma decisões táticas e evolui estruturas ao longo do tempo.

Projeto pessoal de portfólio, com foco em arquitetura de software e boas práticas de backend.

---

## Sobre o projeto

O sistema modela progressão de base, economia e evolução de construções. O backend expõe uma API REST; o frontend é uma SPA em Blazor WebAssembly que consome contratos compartilhados com a API.

A organização do código segue **Clean Architecture**, **DDD** e casos de uso agrupados por funcionalidade (Screaming Architecture).

## Stack

| Camada | Tecnologia |
|--------|------------|
| Runtime | .NET 10 |
| API | ASP.NET Core Web API |
| Persistência | Entity Framework Core + SQL Server |
| Frontend | Blazor WebAssembly |
| Validação | FluentValidation |
| Testes | xUnit, Shouldly |
| CI | GitHub Actions |

### Projetos da solution

| Projeto | Responsabilidade |
|---------|------------------|
| `GeoStrike.Domain` | Entidades, enums e contratos de repositório |
| `GeoStrike.Application` | Casos de uso, validadores e regras de negócio |
| `GeoStrike.Infrastructure` | EF Core, repositórios e migrations |
| `GeoStrike.API` | Endpoints HTTP, filtros e pipeline da API |
| `GeoStrike.Blazor` | Interface web (WebAssembly) |
| `GeoStrike.Communication` | DTOs compartilhados entre API e frontend |
| `GeoStrike.Exception` | Exceções de negócio e mensagens localizadas |

## Estrutura do repositório

```
GeoStrike/
├── src/
│   ├── Backend/          # API, Application, Domain, Infrastructure
│   ├── Frontend/         # Blazor WebAssembly
│   └── Shared/           # Communication, Exception
├── tests/
└── .github/workflows/    # CI (build + testes)
```

## Como executar

**Pré-requisitos:** [.NET 10 SDK](https://dotnet.microsoft.com/download) e SQL Server (local ou remoto).

O repositório **não versiona credenciais**. O `appsettings.json` contém apenas placeholders; configure a connection string real localmente via User Secrets antes de subir a API.

```bash
dotnet restore

dotnet user-secrets set "ConnectionStrings:DefaultConnection" "SUA_CONNECTION_STRING_AQUI" \
  --project src/Backend/GeoStrike.API

dotnet run --project src/Backend/GeoStrike.API
dotnet run --project src/Frontend/GeoStrike.Blazor
```

Portas padrão em desenvolvimento: API em `https://localhost:7200`, Blazor em `https://localhost:7286`.

As migrations do banco são aplicadas automaticamente na inicialização da API.

Alternativa: variável de ambiente `ConnectionStrings__DefaultConnection`.

## Testes

```bash
dotnet test
```

O pipeline de CI (`.github/workflows/ci.yml`) executa restore, build e testes em push e pull request para as branches `main` e `develop`.

---

## English summary

**GeoStrike** is a persistent-data MMORTS (military strategy and base management) **currently in development**. It is a personal portfolio project built with **.NET 10**, following Clean Architecture and DDD, with an ASP.NET Core API, EF Core + SQL Server, and a Blazor WebAssembly frontend.

**Credentials are not stored in this repository.** Use .NET User Secrets locally to configure the database connection string before running the API. Run `dotnet restore`, set the connection string via `dotnet user-secrets`, then start the API and Blazor projects. Tests: `dotnet test`.
