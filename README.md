<h1>Resumo</h1>   

  

   

  

<p>Um sistema de um pequeno empreendedor de comida italiana que precisa diminuir custos e agilizar o processo de venda. Neste sistema o usuário pode selecionar o prato que deseja e sua quantidade. A partir disso será gerado um valor total e o usuário escolhera o método de pagamento. Depois inserirá seu nome e uma comanda será gerada com as informações da compra. </p>   

  

   

  

<h1>Tecnologias utilizadas</h1>   

  

   

  

<p>Projeto orientado a objetos onde foi utilizado a linguagem C# e a IDE Visual Studio Community</p>   

  

   

  

<h1>Instruções de funcionamento</h1>   

  

   

  

<h2>Passo 1</h2>   

  

   

  

<p>O usuário escolhe um dos pratos que deseja e depois a quantidade. O sistema perguntara se ele quer mais alguma coisa, caso sua resposta seja sim poderá escolher novamente o prato e a quantidade, caso não o sistema segue para o próximo passo</p>   

  

   

  

<h2>Passo 2</h2>   

  

   

  

<p>O valor total dos produtos será gerado e o usuário escolhera agora seu método de pagamento que pode ser em dinheiro, débito, crédito ou pix. Caso seja selecionado dinheiro ele precisa inserir um valor e caso este valor não seja suficiente aparecerá uma mensagem avisando o usuário para pôr outro valor que se for suficiente o sistema mostrara o troco caso haja algum. Caso selecionado crédito o usuário informará quantas vezes o valor será dividido e o sistema mostrara as parcelas. Caso seja pix ou débito o sistema segue para o próximo passo. Mas antes de seguir para ele o sistema perguntara se o usuário confirma ou não o método de pagamento, caso sua resposta seja não ele poderá selecionar um novo, caso sim o usuário segue para o próximo passo</p>   

  

   

  

<h2>Passo 3</h2>   

  

   

  

<p>Agora o usuário colocara seu nome e a comanda do pedido será gerada com as informações do pedido</p>   

  

   

  

<h1>Estrutura do código</h1>   

  

   

  

<h2>public class Cardapio</h2>   

  

   

  

<p>Nesta classe haverá informações sobre os pratos</p>   

  

   

  

<h3>Atributos da classe Cardapio</h3>   

  

   

  

<p>-public string nome_prato: Este atributo guardara o nome do prato </p>   

  

   

  

<p>-public string descricao_prato: Este atributo guardara o que o prato possui</p>   

  

   

  

<p>-public int preco_prato: Este atributo guardara o preço por unidade do prato</p>   

  

   

  

<h2>Métodos da classe Cardapio</h2>   

  

   

  

<h3>-public void monstrar_cardapio: Neste método será mostrado o cardápio com o nome do prato, sua descrição e seu preço</h3>   

  

   

  

<h2>public class Pedido</h2>   

  

   

  

<p>Nesta classe serão guardadas as informações do pedido</p>   

  

   

  

<h3>Atributos da classe pedido</h3>   

  

   

  

<p>-public string nome_cliente: Atributo que guardara o nome do cliente</p>   

  

   

  

<p>-public string codigo_pedido: Atributo que guardara o código do pedido gerado aletoriamente</p>   

  

   

  

<p>-public int qtdep,qtder,qtdem: Atributos que guardarão a quantidade de cada prato</p>   

  

   

  

<p>-public int total: Atributo que guardara o total da compra</p>   

  

   

  

<P>-public string metododepag: Atributo que guarda o método de pagamento</P>   

  

   

  

<h3>Métodos da classe Pedido</h3>   

  

   

  

<p>-public void fazer_pedido: Método em que o usuário selecionara o prato e sua quantidade para ser gerado o valor total</p>   

  

   

  

<p>-public void fazer_pagamento: Método que o usuário informará seu método de pagamento</p>   

  

   

  

<P>-public void gerar_comanda: Método em que o sistema gerara uma comanda com as informações do pedido</P>   

  

   

  

<h1>Requisitos funcionais</h1>  

  

<h2>RF-01: Cardápio disponível</h2>  

  

<p>O usuário deve ser capaz de ver o cardápio quando ele quiser durante a seleção dos pratos</p>  

  

<h2>RF-02: Seletor de pratos</h2>  

  

<p>O usuário deve ser capaz de selecionar quantos pratos ele quiser e a quantidade de cada prato</p>  

  

<h2>RF-03: Valor total visível</h2>  

  

<p> O usuário deve ser capaz de ver o valor total da sua compra</p>  

  

<h2>RF-04: Seletor de método de pagamento</h2>  

  

<p>O usuário deve ser capaz de selecionar o método de pagamento que é mais conveniente para ele. Alguns métodos de pagamento terão suas particularidades e o usuário poderá selecionar outro caso precise</p>  

  

<h2>RF-05: Gerador de comanda</h2>  

  

<p>O sistema deve gerar uma comanda com as informações da compra e o nome do cliente</p>  

  

<h1>Requisitos não funcionais</h1>  

  

<h2>RNF-01</h2>  

  

<p>Disponibilidade: O sistema deve estar disponível para o usuário a qualquer momento durante o período de atendimento</p>  

  

<h2>Transparência: O Sistema deve fornecer as informações corretas sobre a compra do usuário</h2> 

  

   

 
