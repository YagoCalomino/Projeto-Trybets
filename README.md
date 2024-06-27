# TryBets

Boas-vindas ao repositório do projeto `TryBets`

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu projeto você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Você irá migrar uma aplicação monolítica já funcional em diversos microsserviços separando as rotas de determinados interesses em uma aplicação separada. Além disso, você desenvolverá os Dockerfiles de seus microsserviços a fim de, no futuro, construir a imagem dos mesmos e ter containers separados para cada microsserviço e um compose da aplicação completa.

</details>
  
<details>
  <summary><strong>:memo: Habilidades a serem trabalhadas </strong></summary>

Neste projeto, verificamos se você é capaz de:

- Entender a arquitetura de microsserviços.
- Entender e interpretar um código fonte já implementado.
- Separar a responsabilidade de uma aplicação monolítica.
- Preparar imagens docker de aplicações web.

</details>


## Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/csharp-0x-csharp-projeto-trybets.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-0x-csharp-projeto-trybets`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`.
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`.
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto.
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-csharp-0x-csharp-projeto-trybets`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_.
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git.
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial.
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-csharp-0x-csharp-projeto-trybets`.

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-0x-csharp-projeto-trybets/pulls).
  - Clique no botão verde _"New pull request"_.
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**.
  - Coloque um título para a sua _Pull Request_.
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_.
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_.
  - **Não se preocupe em preencher mais nada por enquanto!**.
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-0x-csharp-projeto-trybets/pulls) e confira que o seu _Pull Request_ está criado.

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente.

  - Lembre-se sempre, após um (ou alguns) `commits`, de atualizar o repositório remoto.

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-034-csharp`.

  Caso tenha alguma dúvida, [aqui tem um video explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/` ou dos testes `src/TryBets.Test.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste expecífico, basta executar o comando `dotnet test --filter TestReq01` para o requisito 01 ou `dotnet test --filter TestReq10` para o requisito 10.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestReq01`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibem a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 

    > **🚨Importante:🚨**  Os testes de projeto costumam ser demorados devido ao teste do requisito 05. Execute com os testes por requisito para aumentar a performance.

</details>

## Requisitos do projeto

O projeto consiste no backend de um site de apostas. Você, neste projeto, deverá obter o software monolítico, que está pronto, e dividí-lo em microsserviços com determinadas especificidades. 

Para isso, você também terá acesso à documentação de cada microsserviço lhe explicando, quais rotas e funcionalidades devem ter em cada um deles. Mas antes disso, vamos entender o nosso software.

<a id='monolito'></a>

### Aplicação Monolítica

O software consiste em uma API responsável por lidar com determinados serviços em um site de apostas de jogos. O software possui 04 entidades (models) principais: `Users`, `Teams`, `Matches` e `Bets`.

A entidade `Users` é responsável por armazenar os dados de pessoas usuárias do site de apostas. A entidade `Teams` armazena os possíveis times que participarão de partidas. A entidade `Matches` armazena cada uma das partidas com informações de data e horário, time A e time B (times que disputarão a partida), valor apostado em cada um dos times, se a partida foi finalizada e qual o time vencedor. A entidade `Bets` por sua vez armazena informações das apostas realizadas com dados da pessoa usuária, a partida, o time apostado e o valor apostado.

Esta `API` tem responsabilidade apenas de realizar o fluxo inicial de cadastrar novas pessoas usuárias, permitir que as mesmas se autentiquem, fornecer informações de times e partidas, realizar as apostas e atualizar as `odds` que são dinâmicas baseadas no valor apostado em cada time. Este site de apostas possui as `odds` (razão de ganho em uma aposta) atualizadas dinamicamente e não possui fins lucrativos, ou seja, o valor das apostas são inteiramente devolvidos às pessoas usuárias que apostaram.

Fluxos relacionados ao cadastro e atualização de times e partidas, tal como o pagamento de apostas premiadas não são realizados por essa API. Portanto, essas rotas e funcionalidades não existem no monolito e não existirão nos microsserviços.

O relacionamento entre as tabelas é dado pelo diagrama abaixo:

![der](img/trybets-der.png)


Sobre a `API`, a mesma é funcional através da porta `5500`, funcionando de acordo com o diagrama abaixo. Todas as requisições são realizadas para a mesma porta e o software se conecta a um banco de dados `SQL Server`. O projeto possui um docker compose no arquivo `docker-compose.yml` que sobe um container do banco de dados que poderá ser utilizado para testar a aplicação monolítica e para construir a aplicação em microsserviços. Nenhuma alteração no banco de dados precisa ser realizada para a migração na arquitetura de microsserviços.

![arq-mono](img/arq-mono.png)

O banco de dados, caso utilizado no container, deverá subir com o comando:

```shell
docker-compose up -d --build
```

Para conectar ao seu sistema de gerenciamento de banco de dados, utilize as seguintes credenciais:

- `Server`: localhost
- `User`: sa
- `Password`: TryBets123456!
- `Trust server certificate`: true


 ⚠️ **Crie as migrations do seu banco de dados na aplicação monolítica e rode a aplicação ao menos uma vez para o seeder alimentar a tabela Teams e Matches**

Sobre as rotas da `API` monolítica, temos as seguintes funcionalidades:

<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-get.png' />    /team</h3>

Rota utilizada para obter a lista de times.

<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
    </tr>
    <tr>
        <td>(em branco)</td>
        <td>Não</td>
        <td>200</td>
        <td>
            <pre lang="json">
[
    {
        "teamId": 1,
        "teamName": "Sharks"
    }, /*...*/
]
            </pre>
        </td>
    </tr>

</table>


<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-get.png' />    /match/{finished}</h3>

Rota utilizada para obter a lista de partidas. Parâmetro {finished} varia entre `true` e `false` para listar partidas finalizadas ou não.


<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
    </tr>
    <tr>
        <td>(em branco)</td>
        <td>Não</td>
        <td>200</td>
        <td>
            <pre lang="json">
[
	{
		"matchId": 1,
		"matchDate": "2023-07-23T15:00:00",
		"matchTeamAId": 1,
		"matchTeamBId": 8,
		"teamAName": "Sharks",
		"teamBName": "Bulls",
		"matchTeamAOdds": "3,33",
		"matchTeamBOdds": "1,43",
		"matchFinished": true,
		"matchWinnerId": 1
	}, /*...*/
]
            </pre>
        </td>
    </tr>

</table>


<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-post.png' />    /user/signup</h3>

Rota utilizada para cadastrar uma nova pessoa usuária. Ao cadastrar com sucesso, retorna um token. Não permitido adicionar duas pessoas usuárias com o mesmo e-mail.


<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
        <th>Observações</th>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "Name": "Isabel Santos",
   "Email": "isabel.santos@trybets.com",
   "Password": "123456"
}
            </pre>
        </td>
        <td>Não</td>
        <td>201</td>
        <td>
            <pre lang="json">
{
   "token": "eyJhbG..."
}
            </pre>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "Name": "Isabel Santos",
   "Email": "isabel.santos@trybets.com",
   "Password": "123456"
}
            </pre>
        </td>
        <td>Não</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
   "message": "E-mail already used"
}
            </pre>
        </td>
        <td>Caso o e-mail da pessoa usuária já tenha sido cadastrado no banco de dados.</td>
    </tr>

</table>


<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-post.png' />    /user/login</h3>

Rota utilizada para realizar o login de uma pessoa usuária.


<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
        <th>Observações</th>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "Email": "isabel.santos@trybets.com",
   "Password": "123456"
}
            </pre>
        </td>
        <td>Não</td>
        <td>200</td>
        <td>
            <pre lang="json">
{
   "token": "eyJhbG..."
}
            </pre>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "Email": "isabel.santos@trybets.com",
   "Password": "1234567"
}
            </pre>
        </td>
        <td>Não</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
   "message": "Authentication failed"
}
            </pre>
        </td>
        <td>Caso a pessoa usuária não tenha os dados autenticados ou não informe algum dos parâmetros corretamente.</td>
    </tr>

</table>




<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-post.png' />    /bet</h3>

Rota utilizada para realizar uma nova aposta


<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
        <th>Observações</th>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 5,
   "TeamId":  2,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Sim</td>
        <td>201</td>
        <td>
            <pre lang="json">
{
   "betId": 1,
   "matchId": 5,
   "teamId": 2,
   "betValue": 550.65,
   "matchDate": "2024-03-15T14:00:00",
   "teamName": "Eagles",
   "email": "isabel.santos@trybets.com"
}
            </pre>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 5,
   "TeamId":  2,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Não</td>
        <td>401</td>
        <td>
        </td>
        <td>Caso o token não tenha sido informado ou esteja errado</td>
    </tr>
    <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 5,
   "TeamId":  6,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
    "message": "Team is not in this match"
}
            </pre>
        </td>
        <td>Caso o time não esteja na partida correta</td>
    </tr>
     <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 5,
   "TeamId":  60,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
    "message": "Team not founded"
}
            </pre>
        </td>
        <td>Caso o time não exista</td>
    </tr>
     <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 50,
   "TeamId":  6,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
    "message": "Match not founded"
}
            </pre>
        </td>
        <td>Caso a partida não exista</td>
    </tr>
     <tr>
        <td>
            <pre lang="json">
{
   "MatchId": 1,
   "TeamId":  6,
   "BetValue": 550.65
}
            </pre>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
            <pre lang="json">
{
    "message": "Match finished"
}
            </pre>
        </td>
        <td>Caso a partida já tenha sido finalizada</td>
    </tr>
</table>



<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-get.png' />    /bet/{BetId}</h3>

Rota utilizada para visualizar uma aposta criada. Uma aposta só pode ser visualizada pela pessoa que a criou.

<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
        <th>Observações</th>
    </tr>
    <tr>
        <td>
        </td>
        <td>Sim</td>
        <td>200</td>
        <td>
            <pre lang="json">
{
   "betId": 1,
   "matchId": 5,
   "teamId": 2,
   "betValue": 550.65,
   "matchDate": "2024-03-15T14:00:00",
   "teamName": "Eagles",
   "email": "isabel.santos@trybets.com"
}
            </pre>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
            (Indiferente)
        </td>
        <td>Caso a aposta não pertencer à pessoa usuária do token.</td>
    </tr>
    <tr>
        <td>
        </td>
        <td>Sim</td>
        <td>400</td>
        <td>
             <pre lang="json">
{
   "message": "Bet not founded"
}
            </pre>
        </td>
        <td>Caso a aposta não exista.</td>
    </tr>
    <tr>
        <td>
        </td>
        <td>Não</td>
        <td>401</td>
        <td>
        </td>
        <td>Caso não seja informado um token.</td>
    </tr>
</table>

<a id='microservices'></a>

### Microsserviços

O software monolítico deverá ter suas funcionalidades separadas em 04 microsserviços. 03 destes microsserviços implementarão as rotas do monolito e 01 microsserviço implementará uma funcionalidade existente em um destes 03 serviços anteriores. 

Todas as models e o contexto de banco de dados já foram replicados nos microsserviços pelo time que construíu o monolito. Você deverá apenas passar as funcionalidades que envolvem `Controllers`, `DTOs`, `Services` e `Repositories` do serviço monolítico para os microsserviços, respeitando seus objetivos.

As rotas, funcionalidades, fontes e portas de funcionamento de cada microsserviço estão descritas abaixo:

- `TryBets.Users`
    - `Funcionalidades:` Este microsserviço será responsável pelo cadastro e login de pessoas usuárias.
    - `Fonte:` /src/TryBets.Users
    - `Porta`: 5501
    - `Rotas`:
        - POST /user/signup
        - POST /user/login

- `TryBets.Matches`
    - `Funcionalidades:` Este microsserviço será responsável pela visualização de times e partidas.
    - `Fonte:` /src/TryBets.Matches
    - `Porta`: 5502
    - `Rotas`:
        - GET /team
        - GET /match/{finished}

- `TryBets.Bets`
    - `Funcionalidades:` Este microsserviço será responsável pelo cadastro e visualização de apostas
    - `Fonte:` /src/TryBets.Bets
    - `Porta`: 5503
    - `Rotas`:
        - POST /bet
        - GET /bet/{BetId}

- `TryBets.Odds`
    - `Funcionalidades:` Este microsserviço será responsável pela atualização das odds de cada partida. Este microsserviço é novo e não é acessível ao site. Ele será utilizado pelo microsserviço TryBets.Bets e será chamado por este toda vez que uma nova aposta for cadastrada.
    - `Fonte:` /src/TryBets.Odds
    - `Porta`: 5504
    - `Rotas`:
        - PATCH /odd/{matchId}/{TeamId}/{BetValue}

O modelo da arquitetura da aplicação é dada pelo diagrama abaixo:

![arq-micro](img/arq-micro.png)

O banco de dados dos microsserviços é o mesmo da aplicação monolítica. Portanto, nenhuma alteração precisará ser feita nas `models` de nenhum dos serviços.

O microsserviço `TryBets.Odds`, por possuir uma implementação nova, será uma rota de atualização, que, posteriormente abrigará parte da funcionalidade do cadastro de novas apostas, tirando a responsabilidade do microsserviço `TryBets.Bets`.

Está rota receberá em sua `URL`, o id de uma partida, o id de um time e o valor da aposta. Ele então, somará o valor apostado neste determinado time e partida ao valor previamente apostado e armazenará isso na tabela de `Matches`, na coluna `MatchTeamAValue` ou `MatchTeamBValue`. Esses atributos armazenam a soma dos valores já apostados em cada um dos times A ou B para determinada partida. Esse valor reflete nas odds dinâmicas para cada time em uma determinada partida. 

A decisão de atualizar o valor do Time A ou Time B se dá pelo time informado na `URL`. Se o time da `URL` for o time em `MatchTeamAId`, o valor atualizado será `MatchTeamAValue`. Se o time da `URL` for o time em `MatchTeamBId`, o valor atualizado será `MatchTeamBValue`.

Esta funcionalidade de atualizar o valor apostado na partida já está implementada na `BetRepository` da aplicação monolítica, no momento de adicionar uma nova aposta.

A rota para este microsserviço seguirá a seguinte documentação:

<h3 style="vertical-align:middle;display:inline-block;"><img src='img/icon-patch.png' />    /odds/{matchId}/{teamId}/{BetValue}</h3>

Rota utilizada para atualizar o valor apostado em um time e em uma partida. O retorno da requisição seguirá a model `Match` sem necessitar realizar nenhuma operação de tratamento de dados, já que este microsserviço só será acessado pelo microsserviço `TryBets.Bet`.

<table>
    <tr>
        <th>Request</th>
        <th>Token?</th>
        <th>Status</th>
        <th>Response</th>
        <th>Observações</th>
    </tr>
    <tr>
        <td>(em branco)</td>
        <td>Não</td>
        <td>200</td>
        <td>
            <pre lang="json">
{
	"matchId": 1,
	"matchDate": "2024-03-17T14:00:00",
	"matchTeamAId": 5,
	"matchTeamBId": 6,
	"matchTeamAValue": 300.00,
	"matchTeamBValue": 1501.50,
	"matchFinished": false,
	"matchWinnerId": null,
	"matchTeamA": null,
	"matchTeamB": null,
	"bets": null
}
            </pre>
        </td>
        <td></td>
    </tr>
     <tr>
        <td>(em branco)</td>
        <td>Não</td>
        <td>400</td>
        <td>
            (indiferente)
        </td>
        <td>Qualquer tipo de erro que impeça a atualização</td>
    </tr>

</table>





### 1. Implemente o microsserviço TryBets.Matches

<details>
  <summary>Mais Informações:</summary><br />

- Este microsserviço será responsável pela visualização de times e partidas.
- Este microsserviço funciona na porta `5502`.
- O código deste serviço deverá ser implementado em `/src/TryBets.Matches`.
- As rotas necessárias nesse microsserviço são:
    - `GET` /team
    - `GET` /match/{finished}

- Implemente as lógicas das controllers `TeamController` e `MatchController` que estão implementadas na aplicação monolítica.
- Implemente as lógicas dos DTOs `TeamDTO` e `MatchDTO` que estão implementadas na aplicação monolítica.
- Implemente as lógicas das repositories `MatchRepository` e `TeamRepository` que estão implementadas na aplicação monolítica.

Em caso de maiores dúvidas sobre os microsserviços, acesse a [Documentação dos microsserviços](#microservices).

Em caso de maiores dúvidas sobre o funcionamento do software, acesse a [Documentação da aplicação monolítica](#monolito)

**O que será testado:**

- Será testado que os endpoints relacionados a este serviço estão presentes nessa aplicação
- Será testado que os endpoints não relacionados a este serviço estão inoperantes nessa aplicação.


</details>

### 2. Implemente o microsserviço TryBets.Users

<details>
  <summary>Mais Informações:</summary><br />

- Este microsserviço será responsável pelo cadastro e login de pessoas usuárias.
- Este microsserviço funciona na porta `5501`.
- O código deste serviço deverá ser implementado em `/src/TryBets.Users`.
- As rotas necessárias nesse microsserviço são:
    - `POST` /user/signup
    - `POST` /user/login

- Implemente as lógicas da controller `UserController` que estão implementadas na aplicação monolítica.
- Implemente as lógicas do DTO `AuthDTO` que estão implementadas na aplicação monolítica.
- Implemente as lógicas da repository `UserRepository` que estão implementadas na aplicação monolítica.
- Implemente as lógicas da service `TokenManager` que estão implementadas na aplicação monolítica.

Em caso de maiores dúvidas sobre os microsserviços, acesse a [Documentação dos microsserviços](#microservices).

Em caso de maiores dúvidas sobre o funcionamento do software, acesse a [Documentação da aplicação monolítica](#monolito)

**O que será testado:**

- Será testado que os endpoints relacionados a este serviço estão presentes nessa aplicação
- Será testado que os endpoints não relacionados a este serviço estão inoperantes nessa aplicação.

</details>

### 3. Implemente o microsserviço TryBets.Bets

<details>
  <summary>Mais Informações:</summary><br />


- Este microsserviço será responsável pelo cadastro e visualização de apostas.
- Este microsserviço funciona na porta `5503`.
- O código deste serviço deverá ser implementado em `/src/TryBets.Bets`.
- As rotas desse microsserviço são protegidas pela política `Client`.
- Os tokens de acesso a este microsserviço possuem no payload o e-mail da pessoa usuária através da claim `ClaimTypes.Email`.
- As rotas necessárias nesse microsserviço são:
    - `POST` /bet
    - `GET` /bet/{BetId}

- Implemente as lógicas da controller `BetController` que estão implementadas na aplicação monolítica.
- Implemente as lógicas do DTO `BetDTO` que estão implementadas na aplicação monolítica.
- Implemente as lógicas da repository `BetRepository` que estão implementadas na aplicação monolítica.

Em caso de maiores dúvidas sobre os microsserviços, acesse a [Documentação dos microsserviços](#microservices).

Em caso de maiores dúvidas sobre o funcionamento do software, acesse a [Documentação da aplicação monolítica](#monolito)

**O que será testado:**

- Será testado que os endpoints relacionados a este serviço estão presentes nessa aplicação
- Será testado que os endpoints não relacionados a este serviço estão inoperantes nessa aplicação.

</details>

### 4. Implemente o microsserviço TryBets.Odds

<details>
  <summary>Mais Informações:</summary><br />
  

-  Este microsserviço será responsável pela atualização das odds de cada partida. Este microsserviço é novo e não é acessível ao site. Ele será utilizado pelo microsserviço `TryBets.Bets` e será chamado por este toda vez que uma nova aposta for cadastrada.
- Este microsserviço funciona na porta `5504`.
- O código deste serviço deverá ser implementado em `/src/TryBets.Odds`.
- A rota necessária nesse microsserviço é:
    - `PATCH` /odd/{matchId}/{TeamId}/{BetValue}

- Implemente as lógicas da controller `OddController`. Essa controller é nova.
- Implemente as lógicas da repository `OddRepository`. Essa repository é nova.

- Refatore o microsserviço `TryBets.Bets` para que o mesmo utilize o microsserviço `TryBets.Odds`:
    - Refatore para que a repository não atualize o valor da partida em `/src/TryBets.Bets/Repository/BetRepository.cs`.
    - Realize a lógica para que o endpoint `POST` /bet chame este endpoint. Crie a lógica em `/src/TryBets.Bets/Services/OddService.cs`.

Em caso de maiores dúvidas sobre os microsserviços, acesse a [Documentação dos microsserviços](#microservices).

Em caso de maiores dúvidas sobre o funcionamento do software, acesse a [Documentação da aplicação monolítica](#monolito)

 ⚠️ **Atenção** Ao criar a requisição do microsserviço `TryBets.Bets` para o microsserviço `TryBets.Odds`, o valor da aposta é enviado na `URL` da requisição como uma string. Ao converter essa string para decimal, diferentes configurações de linguagem de sistemas operacionais podem ocasionar uma conversão equivocada, seja na conversão ou na leitura do valor recebido pela controller. Para resolver essa questão, na repository `/src/TryBets.Odds/Repository/OddRepository.cs` realize os seguintes passos:

1. Converta o valor do valor para substituir qualquer `vírgula` por `ponto`.
    
    ```csharp
    string BetValueConverted = BetValue.Replace(',', '.');
    ```

2. Ao converter para decimal, utilize o `InvariantCulture` para realizar a conversão desconsiderando qualquer particularidade de país ou sistema operacional.

    ```csharp
    decimal BetValueDecimal = Decimal.Parse(BetValueConverted, CultureInfo.InvariantCulture);
    ```


**O que será testado:**

- Será testado que o endpoint relacionado a este serviço está presente nessa aplicação
- Será testado que os endpoints não relacionados a este serviço estão inoperantes nessa aplicação.

</details>


### 5. Desenvolva os Dockerfiles dos microsserviços

<details>
  <summary>Mais Informações:</summary><br />

- Desenvolva o Dockerfile de cada microsserviço capaz de criar um container da API
- Implemente no arquivo `Dockerfile` que está na fonte dos microsserviços `TryBets.Matches`, `TryBets.Users`, `TryBets.Bets` e `TryBets.Odds`

👀 **De olho na dica:** não se esqueça de utilizar o comando `EXPOSE {PORT}` para expor a porta de cada microsserviço.

👀 **De olho na dica:** os testes deste requisito são os mais demorados devido ao teste de cada container.

👀 **De olho na dica:** você pode testar todos os arquivos `Dockerfile` de uma vez subindo um docker compose com todos os microsserviços executando no diretório raiz do projeto, o seguinte comando :

```shell
docker compose -f "docker-compose.microservices.yml" up -d --build
```

</details>


<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/PsefzL2e)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>
