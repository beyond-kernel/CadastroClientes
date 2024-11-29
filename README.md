Guia de Orientação para Desenvolvedores
Padrões de Codificação:

Siga o padrão de nomenclatura PascalCase para classes e métodos.
Use injeção de dependência para serviços e repositórios.
Princípios de Design:

SOLID: Mantenha responsabilidade única para cada classe.
DRY: Evite duplicação de código com abstrações e reutilização.
Fluxo de Trabalho:

Implementar as interfaces no repositório para abstração do banco.
Usar DTOs para transferência de dados entre a API e o front.
Validação:

Validação de dados no front (HTML5 e Javascript).
Validação de dados no back com Data Annotations.


Arquitetura da Solução
Visão Geral: A arquitetura segue o padrão de aplicações modernas baseadas em serviços, composta por:

Front-End: Desenvolvido em ASP.NET MVC com Razor Views, Javascript e HTML.
Back-End: Uma API RESTful em .NET Core 6.0+.
Banco de Dados: SQL Server 2016+.
Armazenamento de Logotipo: As imagens serão armazenadas como blobs no banco de dados (campo tipo VARBINARY(MAX)).
Componentes Principais:

Front-End:
Interface para CRUD de clientes e logradouros.
Formulários com validação para garantir integridade de dados no front.
Back-End:
Endpoints RESTful para operações de clientes e logradouros.
Autenticação e autorização utilizando JWT (JSON Web Tokens).
Camada de serviços para lógica de negócios.
Repositório para abstração de acesso a dados usando Entity Framework para consultas e Stored Procedures para operações.
Banco de Dados:
Tabelas:
Clientes (com chave primária e-mail para evitar duplicidade).
Logradouros (relacionados ao cliente com ClienteId como chave estrangeira).
Procedures para criação, atualização e exclusão com alta performance.
Requisitos Atendidos:

CRUD Completo: Endpoints para todas as operações requeridas.
Desempenho: Uso de Stored Procedures para operações pesadas e otimização do banco.
Segurança: JWT para autenticação e autorização.
Decisões de Design
Desempenho:

As consultas serão feitas via ORM (Entity Framework) para maior agilidade no desenvolvimento.
Atualizações e exclusões usarão Stored Procedures, permitindo maior controle e desempenho.
Escalabilidade:

Arquitetura de API aberta ao mundo, com autenticação por tokens JWT, permite integração com outros sistemas.
Suporte a alta concorrência com SQL Server e cache para dados frequentemente acessados.Arquitetura da Solução
Visão Geral: A arquitetura segue o padrão de aplicações modernas baseadas em serviços, composta por:

Front-End: Desenvolvido em ASP.NET MVC com Razor Views, Javascript e HTML.
Back-End: Uma API RESTful em .NET Core 6.0+.
Banco de Dados: SQL Server 2016+.
Armazenamento de Logotipo: As imagens serão armazenadas como blobs no banco de dados (campo tipo VARBINARY(MAX)).
Componentes Principais:

Front-End:
Interface para CRUD de clientes e logradouros.
Formulários com validação para garantir integridade de dados no front.
Back-End:
Endpoints RESTful para operações de clientes e logradouros.
Autenticação e autorização utilizando JWT (JSON Web Tokens).
Camada de serviços para lógica de negócios.
Repositório para abstração de acesso a dados usando Entity Framework para consultas e Stored Procedures para operações.
Banco de Dados:
Tabelas:
Clientes (com chave primária e-mail para evitar duplicidade).
Logradouros (relacionados ao cliente com ClienteId como chave estrangeira).
Procedures para criação, atualização e exclusão com alta performance.
Requisitos Atendidos:

CRUD Completo: Endpoints para todas as operações requeridas.
Desempenho: Uso de Stored Procedures para operações pesadas e otimização do banco.
Segurança: JWT para autenticação e autorização.
Decisões de Design
Desempenho:

As consultas serão feitas via ORM (Entity Framework) para maior agilidade no desenvolvimento.
Atualizações e exclusões usarão Stored Procedures, permitindo maior controle e desempenho.
Escalabilidade:

Arquitetura de API aberta ao mundo, com autenticação por tokens JWT, permite integração com outros sistemas.
Suporte a alta concorrência com SQL Server e cache para dados frequentemente acessados.Arquitetura da Solução
Visão Geral: A arquitetura segue o padrão de aplicações modernas baseadas em serviços, composta por:

Front-End: Desenvolvido em ASP.NET MVC com Razor Views, Javascript e HTML.
Back-End: Uma API RESTful em .NET Core 6.0+.
Banco de Dados: SQL Server 2016+.
Armazenamento de Logotipo: As imagens serão armazenadas como blobs no banco de dados (campo tipo VARBINARY(MAX)).
Componentes Principais:

Front-End:
Interface para CRUD de clientes e logradouros.
Formulários com validação para garantir integridade de dados no front.
Back-End:
Endpoints RESTful para operações de clientes e logradouros.
Autenticação e autorização utilizando JWT (JSON Web Tokens).
Camada de serviços para lógica de negócios.
Repositório para abstração de acesso a dados usando Entity Framework para consultas e Stored Procedures para operações.
Banco de Dados:
Tabelas:
Clientes (com chave primária e-mail para evitar duplicidade).
Logradouros (relacionados ao cliente com ClienteId como chave estrangeira).
Procedures para criação, atualização e exclusão com alta performance.
Requisitos Atendidos:

CRUD Completo: Endpoints para todas as operações requeridas.
Desempenho: Uso de Stored Procedures para operações pesadas e otimização do banco.
Segurança: JWT para autenticação e autorização.
Decisões de Design
Desempenho:

As consultas serão feitas via ORM (Entity Framework) para maior agilidade no desenvolvimento.
Atualizações e exclusões usarão Stored Procedures, permitindo maior controle e desempenho.
Escalabilidade:

Arquitetura de API aberta ao mundo, com autenticação por tokens JWT, permite integração com outros sistemas.
Suporte a alta concorrência com SQL Server e cache para dados frequentemente acessados.Arquitetura da Solução
Visão Geral: A arquitetura segue o padrão de aplicações modernas baseadas em serviços, composta por:

Front-End: Desenvolvido em ASP.NET MVC com Razor Views, Javascript e HTML.
Back-End: Uma API RESTful em .NET Core 6.0+.
Banco de Dados: SQL Server 2016+.
Armazenamento de Logotipo: As imagens serão armazenadas como blobs no banco de dados (campo tipo VARBINARY(MAX)).
Componentes Principais:

Front-End:
Interface para CRUD de clientes e logradouros.
Formulários com validação para garantir integridade de dados no front.
Back-End:
Endpoints RESTful para operações de clientes e logradouros.
Autenticação e autorização utilizando JWT (JSON Web Tokens).
Camada de serviços para lógica de negócios.
Repositório para abstração de acesso a dados usando Entity Framework para consultas e Stored Procedures para operações.
Banco de Dados:
Tabelas:
Clientes (com chave primária e-mail para evitar duplicidade).
Logradouros (relacionados ao cliente com ClienteId como chave estrangeira).
Procedures para criação, atualização e exclusão com alta performance.
Requisitos Atendidos:

CRUD Completo: Endpoints para todas as operações requeridas.
Desempenho: Uso de Stored Procedures para operações pesadas e otimização do banco.
Segurança: JWT para autenticação e autorização.
Decisões de Design
Desempenho:

As consultas serão feitas via ORM (Entity Framework) para maior agilidade no desenvolvimento.
Atualizações e exclusões usarão Stored Procedures, permitindo maior controle e desempenho.
Escalabilidade:

Arquitetura de API aberta ao mundo, com autenticação por tokens JWT, permite integração com outros sistemas.
Suporte a alta concorrência com SQL Server e cache para dados frequentemente acessados.
