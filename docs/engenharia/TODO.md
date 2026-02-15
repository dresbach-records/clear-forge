TODO – ENGENHARIA

CLEARFORGE
Tech Ops Engineering
Dresbach Group – Canada

🎯 OBJETIVO

Converter todas as telas projetadas (HTML + PNG) em implementação real .NET (WinUI 3 ou WPF), seguindo arquitetura limpa, separação por planos e controle de licenciamento.

🔹 1. ORGANIZAÇÃO INICIAL

 Validar estrutura completa da pasta /engenharia

 Confirmar nomeação padronizada das pastas

 Mapear cada pasta → View correspondente

 Criar tabela de mapeamento Tela → Plano

 Definir padrão único de nomenclatura de Views

🔹 2. INSTALADOR (Installation Wizard)

Pastas:
clearforge_installation_wizard_1 a 5

Conversão

 Criar InstallerShellView

 Criar Step1View

 Criar Step2View

 Criar Step3View

 Criar Step4View

 Criar Step5View

 Implementar barra de progresso real

 Integrar lógica de instalação

 Criar ViewModel para controle de estado

 Implementar validação de permissões administrativas

 Criar fluxo de finalização

🔹 3. LOGIN

Pasta:
clearforge_login_portal

 Criar LoginView

 Criar LoginViewModel

 Integrar com API de autenticação

 Implementar validação de token JWT

 Criar tratamento de erro

 Criar persistência segura de sessão

🔹 4. ONBOARDING

Pasta:
clearforge_onboarding_welcome

 Criar OnboardingView

 Implementar escolha de modo

 Salvar preferências iniciais

 Conectar com Engine para análise inicial

🔹 5. DASHBOARD BASE

Pastas:
clearforge_main_dashboard_1 a 9

Estrutura

 Criar BaseDashboardView

 Criar DashboardShell

 Implementar Sidebar

 Implementar Health Score Card

 Implementar Storage Card

 Implementar Startup Card

 Implementar Privacy Card

 Criar sistema de navegação interna

 Conectar com Engine real

 Implementar logs de atividade

🔹 6. DASHBOARD PRO

Pastas:
clearforge_pro_dashboard_locked_1 a 6

Estrutura

 Criar ProDashboardView

 Implementar sistema de feature lock

 Criar Upgrade Modal

 Implementar painel de notificações

 Integrar agendamento de limpeza

 Implementar gráficos avançados

 Criar sistema de permissões por plano

🔹 7. DASHBOARD ADVANCED

Pastas:
clearforge_main_dashboard_10 a 12

Estrutura

 Criar AdvancedDashboardView

 Implementar visual enterprise

 Criar módulo de relatórios completos

 Implementar auditoria local

 Integrar múltiplos dispositivos (estrutura futura)

 Criar seção administrativa

🔹 8. CONFIGURAÇÕES & NOTIFICAÇÕES

Pastas:
clearforge_notification_settings_1 a 15

Implementação

 Criar SettingsShellView

 Criar NotificationCenterView

 Implementar toggles dinâmicos

 Criar sistema de persistência de configurações

 Implementar agendamento automático

 Criar modo avançado

 Implementar reset de preferências

 Criar sistema de eventos internos

🔹 9. HELP & SUPPORT

Pasta:
clearforge_help_&_support

 Criar HelpView

 Integrar FAQ local

 Implementar link para suporte

 Criar sistema de logs exportáveis

🔹 10. CONTROLE DE PLANOS

 Implementar FeatureFlagService

 Criar PlanEnum (Base, Pro, Advanced)

 Criar middleware interno de validação

 Implementar bloqueio visual automático

 Criar fallback para licença inválida

 Implementar revalidação periódica

🔹 11. PADRÃO MVVM

Para todas as telas:

 Criar View

 Criar ViewModel

 Criar Service Layer

 Criar Interface para Engine

 Implementar Injeção de Dependência

🔹 12. INTEGRAÇÃO COM ENGINE

 Conectar Smart Clean ao Core

 Implementar retorno de métricas reais

 Criar Health Score real

 Implementar execução assíncrona

 Criar sistema de cancelamento de scan

 Implementar logs detalhados

🔹 13. SEGURANÇA

 Criptografar dados locais

 Implementar validação de integridade

 Criar verificação de licença offline

 Implementar hash de executável

 Preparar para Code Signing

🔹 14. TESTES

 Teste de fluxo de instalação

 Teste de login

 Teste de troca de plano

 Teste de bloqueio Pro

 Teste de bloqueio Advanced

 Teste de desempenho da Engine

 Teste de upgrade

🔹 15. ORGANIZAÇÃO FINAL

 Remover dependência direta do HTML

 Documentar mapeamento tela → classe

 Criar diagrama de navegação

 Criar documentação técnica interna

 Revisão final de arquitetura

🔥 PRIORIDADE REAL

1️⃣ Login + Licença
2️⃣ Dashboard Base
3️⃣ Engine funcional
4️⃣ Feature Lock Pro
5️⃣ Advanced Dashboard
6️⃣ Configurações

📌 STATUS ATUAL

✔ Telas projetadas
✔ Estrutura organizada
✔ Planos definidos