# DevFreela - Plataforma de Freelance

## Descrição
O DevFreela é uma plataforma completa que conecta freelancers e clientes para a execução de projetos. O sistema permite que freelancers encontrem trabalhos compatíveis com suas habilidades e que clientes publiquem e gerenciem seus projetos.

> **Nota:** Este projeto é um estudo desenvolvido como parte de uma plataforma de estudos para praticar e aprimorar habilidades em desenvolvimento de software.

## Funcionalidades
- **Registro de Usuários:** Permite que freelancers e clientes se registrem na plataforma.
- **Publicação de Projetos:** Clientes podem criar, atualizar e gerenciar projetos.
- **Busca de Projetos:** Freelancers podem procurar por projetos disponíveis e se candidatar.
- **Comentários:** Clientes e freelancers podem adicionar comentários nos projetos.
- **Status de Projetos:** Gerenciamento dos estados dos projetos (criado, em andamento, concluído, cancelado).

## Tecnologias Utilizadas
- **Backend:**
  - .NET Core
  - Entity Framework Core
- **Banco de Dados:**
  - SQL Server
- **Documentação da API:**
  - Swagger
- **Gerenciamento de Dependências:**
  - Injeção de Dependências
- **Controle de Versão:**
  - Git/GitHub

## Estrutura do Projeto
O projeto está organizado em várias camadas para promover a separação de preocupações:

- **DevFreela.API:** Contém os controladores da API e configurações de inicialização.
- **DevFreela.Application:** Contém os serviços, interfaces e modelos de entrada e saída.
- **DevFreela.Core:** Contém as entidades principais e enums.
- **DevFreela.Infrastructure:** Contém a implementação do contexto do banco de dados e configurações das entidades.

## Configuração e Execução
### Pré-requisitos
- .NET Core SDK 8.0
- SQL Server

### Configuração
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/devfreela.git
   cd devfreela

2. Configure a string de conexão do banco de dados no arquivo appsettings.json:{
   ```bash
    {
    "ConnectionStrings":
     {
        "DevFreelaCs": "${CONNECTION_STRING}"
     }
    }
   

