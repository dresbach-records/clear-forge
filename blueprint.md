# Blueprint: Clearforge Licensing System

## 1. Visão Geral do Projeto

Clearforge é um sistema de backend robusto projetado para gerenciamento de licenciamento de software e usuários. Construído com .NET 9 e seguindo os princípios da Clean Architecture, o sistema oferece uma base sólida e escalável para controle de acesso a produtos de software.

- **Tecnologias Principais:** C#, .NET 9, ASP.NET Core, Entity Framework Core, SQLite.
- **Arquitetura:** Clean Architecture, separando Domínio, Aplicação, Infraestrutura e Apresentação (API).
- **Funcionalidades Base:** Gerenciamento de Usuários, Licenças, Dispositivos, Assinaturas, Logs de Auditoria e Relatórios.

## 2. Esboço do Projeto (Estado Atual)

Esta seção documenta o projeto como ele está agora, incluindo todos os recursos e decisões de design implementadas.

### 2.1. Arquitetura e Estrutura

O projeto está organizado nas seguintes camadas:

- `Clearforge.Core`: Projeto base para funcionalidades compartilhadas.
- `Clearforge.Domain`: Contém as entidades de negócio principais, que são o coração da aplicação.
- `Clearforge.Application`: Orquestra a lógica de negócio, mas não contém estado de negócio.
- `Clearforge.Infrastructure`: Lida com preocupações externas, principalmente o acesso a dados com EF Core e SQLite.
- `Clearforge.Api`: O ponto de entrada da aplicação, uma API web ASP.NET Core que expõe os recursos do sistema.
- `Clearforge.Licensing`: Um projeto de biblioteca de classes para lógicas de licenciamento.

### 2.2. Modelo de Dados (Entidades)

O banco de dados é gerenciado pelo EF Core (Code-First) com as seguintes entidades:

- **User**: Representa um usuário do sistema (`Id`, `Name`, `Email`, `Username`, `PasswordHash`, `Role`).
- **License**: Representa uma licença de software vinculada a um usuário (`Id`, `Key`, `Plan`, `Expiration`, `IsActive`).
- **Device**: Um dispositivo registrado por um usuário.
- **Subscription**: Assinaturas de serviço (possivelmente para pagamentos recorrentes).
- **AuditLog**: Registros de eventos importantes no sistema para fins de auditoria.
- **Report**: Representa relatórios gerados pelo sistema.

### 2.3. Funcionalidades Implementadas (Backend)

- **Configuração do Banco de Dados:** O `ClearforgeDbContext` está configurado para usar SQLite como provedor de banco de dados.
- **Migração Inicial:** Uma migração do EF Core (`InitialCreate`) foi criada e aplicada, estabelecendo o esquema do banco de dados para todas as entidades mencionadas.
- **Injeção de Dependência:** O `DbContext` está registrado no contêiner de injeção de dependência da API.

### 2.4. Estilo e Design

- Atualmente, não há interface de usuário (UI) ou frontend implementado. O foco até agora tem sido exclusivamente na estruturação e correção do backend.

## 3. Tarefa Atual: Correção de Compilação e Inicialização do Banco de Dados

Esta seção descreve o plano e as etapas executadas para a solicitação mais recente.

### 3.1. Objetivo

Resolver uma série de erros de compilação que impediam o projeto de ser construído e, em seguida, inicializar o banco de dados com o esquema definido.

### 3.2. Plano de Execução e Passos Concluídos

1.  **Análise dos Erros de Build:** Os erros indicavam a falta de referências a tipos do Entity Framework Core (`DbContext`, `DbSet`, `Migration`) e a existência de um arquivo `Program.cs` duplicado.
2.  **Resolução do Conflito de `Program.cs`:** O arquivo `Program.cs` extra na pasta raiz foi identificado como a causa de um erro de "declarações de nível superior" e foi deletado.
3.  **Adição das Diretivas `using`:** Foram adicionadas as diretivas `using Microsoft.EntityFrameworkCore;` e outras correlatas nos arquivos do projeto `Clearforge.Infrastructure` que apresentavam erros.
4.  **Verificação dos Pacotes NuGet:** Confirmei que o projeto `Clearforge.Infrastructure` já fazia referência aos pacotes `Microsoft.EntityFrameworkCore.Design` e `Microsoft.EntityFrameworkCore.Sqlite`.
5.  **Adição de Pacotes Adicionais:** Para seguir as melhores práticas, adicionei explicitamente os pacotes `Microsoft.EntityFrameworkCore` and `Microsoft.EntityFrameworkCore.Tools` ao projeto `Clearforge.Infrastructure`, garantindo que a versão (`9.0.0-preview.5.24306.3`) estivesse alinhada com o .NET 9 do projeto.
6.  **Restauração e Rebuild da Solução:** Executei `dotnet restore` e `dotnet build` para confirmar que todos os problemas de compilação foram resolvidos com sucesso.
7.  **Aplicação das Migrações:** Executei `dotnet ef database update` para criar o banco de dados SQLite e aplicar o esquema da migração `InitialCreate`.

### 3.3. Resultado

O backend do projeto Clearforge está agora em um estado funcional, compilável e com o banco de dados devidamente inicializado. O sistema está pronto para o desenvolvimento de novas funcionalidades.
