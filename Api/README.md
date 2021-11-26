<<<<<<< HEAD


# Template CICD .NetCore

Projeto criado para servir de guia para implementação de soluções .NetCore Web Api em um ciclo de entrega contínua. 


 ![Logo](https://miro.medium.com/max/800/1*jPpc7KUl1OgsjvdkY6DuQQ.png)



## Features

### Foram utilizadas as seguintes tecnologias:

- .NetCore versão 5;
- Docker
- Heroku
- GitHub Actions




## Instalação

1- Acesse o link https://github.com/eduardoao/templatecicd


```bash
  Conforme imagem abaixo. Clicar em: Use thies template  
```
    
## Screenshots

![App Screenshot](https://via.placeholder.com/468x300?text=App+Screenshot+Here)


2 - Na página seguinte entre com o nome do reposótio

3 - Clique em: Create repository from template

4 - Assim que o processo de criação for finalizado. O gitHub Action será executado, mas como ainda não temos as configurações do Heroku implementadas o CD irá falhar.

5 - Clonar a aplicação

6 - Entrar no site do Heroku. https://www.heroku.com/. Após realizar o login. Entre em https://dashboard.heroku.com/apps e clique em New/Create New app

7 - Em App name defina um nome para a aplicação. Para fins didáticos podemos colocar o mesmo nome do repositório criado no gitHub

8 - Abrir a aplicação NetCore via Visual Studio ou qualquer outra IDE de preferência

9 - Abrir a pasta onde está a aplicação. Em .github, abrir o arquivo dotnetCD.yml. Localize a chave heroku_app_name e adicione o nome que você inseriu em nome do app no Heroku. Em heroku_email coloque o endereço de e-mail cadastrado no Heroku

10 - Aplique as alterações para o github com os seguintes comandos:
- git add .
- git commit -m "dotnetCD updated" 
- git push

11 - Na página do repositório do gitHub. O Action irá ser executado.

12 - Vamos adicionar a chave da API do Heroku em variáveis do gitHub. 
- Entre em https://dashboard.heroku.com/account
- Localize API Key 
- Clique em Reveal
- Copie a chave
- Entre em Settings do seu repositório criado no gitHub
- Clique em Secrets e após em New repository secret
- Em Name, digite HEROKU_API_KEY
- Adicione a chave

13 - Agora entre no repositório do gitHub. Clique em Actions. Irá localizar um workflow, provavelmente com um ícone em vermelho, clique no workflow e na sequência em Re-run all jobs. 

  





12 - Após a execução da Action. Digite no browser: https://<nome do app criado no heroku>.herokuapp.com/


## Badges

[![.NET CD](https://github.com/eduardoao/testandotemplatecicd/actions/workflows/dotnetCD.yml/badge.svg)](https://github.com/eduardoao/testandotemplatecicd/actions/workflows/dotnetCD.yml)
=======
![GitHub Actions](https://img.shields.io/badge/githubactions-%232671E5.svg?style=for-the-badge&logo=githubactions&logoColor=white)
>>>>>>> a4302252555229cd9f800ceb5bf0006a769c5af1
