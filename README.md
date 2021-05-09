# projeto_uploadfiles

Referências utilizadas para o desenvolvimento da aplicação:

https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio

http://www.macoratti.net/18/11/aspn_upload1.htm

https://docs.microsoft.com/pt-br/aspnet/core/blazor/file-uploads?view=aspnetcore-5.0#file-streams

https://www.learmoreseekmore.com/2020/10/blazor-webassembly-fileupload.html


Tecnologias utilizadas:

Visual Estudio Code versão: 1.56.

DotNet versão: 3.1.408.

RunTime: Microsoft.AspNetCore.App 3.1.14.

Linguagem de programação: C#.

O projeto foi desenvolvido seguindo o padrão MVC(Model, View, Controller), foi dividido em 3 partes:
a primeira parte se refere a Views que é responsável pela parte da visulização da nossa aplicação, ou seja, está relacionada páginas html.

A segunda parte está relacionada com o Model, simplificando, seria aonde vão ficar as nossas classes, quase sempre são utilizadas para realizar a persistência
no banco de dados.

A terceira parte é o Controller, possuem a responsabilidade de gerenciar as requisiçoes feitas pelos usuários e pela resposta
do servidor.

O dotnet já nos oferece uma configurção inicial, nele contém todos os recursos necessário para
iniciarmos aplicação, inclusive, já vem com bootstrap.

O comando: dotnet new mvc -o "Nome da pasta onde sera criado o projeto asp.net core mvc" Inicia o nosso projeto
para abrir o projeto no visual estudio basta usa o seguinte comando: code -r "Nome da nossa pasta".




