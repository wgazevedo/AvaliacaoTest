# DevPleno2020
Exercícios de Contratação do Desenvolvedor Pleno - Março/2020

<h2> Exercício #1 - C# </h1>
- Crie um aplicativo que leia o arquivo ‘input.csv’ providenciado. <br>
- Calcule a média aritmética de idade por estado.<br>
- Monte um JSON com os resultados de acordo com o exemplo<br>
- Envie o JSON criado via POST para o endpoint: https://zeit-endpoint.brmaeji.now.sh/api/avg<br>

Por exemplo:

conteúdo do arquivo exemplo:

<pre>
Pedro, 15, Rio de Janeiro
Joana, 33, Rio de Janeiro
Alair, 24, Atibaia
Tobias, 35, Atibaia
Marina, 44, Campinas
</pre>

Médias:

<pre>
Rio de Janeiro, 24
Atibaia, 29,5
Campinas, 44
</pre>

JSON:

<pre>
{
 "medias":
      [
   	{
 	    "cidade" : "Rio de Janeiro",
 	    "idade" : 24
 		
 	},
 	{
                "cidade" : "Atibaia",
 	    "idade" : 29.5
 	},
 	{
                "cidade" : "Campinas",
 	    "idade" : 44
 	}
      ]
}
</pre>
<b>IMPORTANTE: </b><br>
<br>
a) Dados manuais digitados por usuários podem ter erro de digitação. Considere que “São Paulo” é igual a “Sao Paulo”.<br>
b) O sistema de destino trabalha com um máximo de duas casas decimais. Se o valor for, por exemplo, 30.333333… , envie o valor arredondado de 30.33 .<br>

<br>
Crie um repositório numa conta pessoal do github e compartilhe-a com o entrevistador.<br>


<h2> Exercício #2 - NodeJS / Angular </h1>

Faça um pequeno serviço contendo duas partes:<br>
<br>
BackEnd em NodeJS<br>
FrontEnd em Angular (versão à sua escolha)<br>
<br>
O FrontEnd deverá:<br>
<br>
- Conter uma form com um input, um label e um botão<br>
- O texto deverá ser “Qual o nome do principal produto da Sysplan?”<br>
- O botão “enviar” deve fazer um POST autenticado (basica) para o endpoint providenciado e exibir a resposta em tela<br>
<br>

O BackEnd deverá:<br>

1a) Servir interface web composta de um index.html e um arquivo .js com a aplicação em Angular.<br>
1b) Gravar em um arquivo “tentativas.log”, local, o timestamp em formato “YYYY-MM-DD hh:mm:ss - TENTATIVA - RESULTADO” de cada tentativa de adivinhação. Ex.:<br>

<pre>
2020-03-20 14:35:22 - Sucrilhos - false
2020-03-20 14:38:34 - Guaraná - false
2020-03-20 14:41:55 - Bolacha Maizena - true
</pre>
<br>
endpoint: https://zeit-endpoint.brmaeji.now.sh/api/auth<br>
credenciais: candidato / entrevista<br>
<br>
Formato da msg JSON:<br>
<pre>
{
   "nome" : "Paulo",
   "mensagem" : "Bolacha Maizena"
}
</pre>


Crie um repositório numa conta pessoal do github e compartilhe-a com o entrevistador.<br>

<h1> Exercício #3 - HTML, jQuery, javascript</h1>

Faça o download do código localizado nesse repositório na pasta "exercicio3". <br>

Faça o build do projeto e execute a dll criada via prompt de comando, usando o CLI do dotnet:<br>

dotnet MinhaDll.dll<br>

acesse pelo seu browser o endereço http://localhost:5000<br>

A página exibida contém uma lista dinâmica contendo 5 de nomes de filmes. Remova o item 3 e envie. Você verá no log de execução da sua DLL que somente os itens 1 e 2 foram enviados.<br>
<br>
- Corrija o programa de forma todos os 4 elementos restantes sejam enviados<br>
- Ao editar o nome de qualquer filme, você perceberá que o seu campo será iluminado com uma cor verde.. Se você adicionar um elemento novo nessa lista usando o botão “Novo”, esse novo item não tem o efeito de iluminação esperado. Corrija esse novo problema.<br>
<br>
Ao ter o código corrigido, crie um repositório numa conta sua do github e compartilhe-a com o entrevistador.<br>

<h1> Exercício #4 - .Net Core, Vue.js</h1>
Usando ASP.NET Core crie uma api que deverá consumir 2 tabelas:<br>
Autores: Id, Nome<br>
Livros: Id, Autor, Qtde. Estoque<br>
Implementar Crud para ambas as tabelas.<br>
O banco deverá ser um postgresql e utilizar NHibernate para acessá-lo.<br>
<br>
O front-end deverá ser em vue.js, ele derá ter:<br>
As telas de cadastro de autor e livros.<br>
Na tela inicial os livros e sua quantidade em estoque. <br>
Implementar recurso para "comprar" 1 livro, que irá diminuir 1 de seu estoque.<br>
Caso um usuário altere a quantidade em estoque de um livro, essa informação deve ser atualizada automaticamente na tela de todos os usuários.
