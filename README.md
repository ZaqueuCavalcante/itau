# Itaú

Processo Seletivo Itaú Unibanco – Fase 2 (Teste Técnico)

## Contexto

- Renda variável é uma modalidade de investimento em que os retornos não são fixos ou previsíveis, como ocorre na renda fixa.
- A principal característica desse tipo de investimento é a possibilidade de ganhos (ou perdas) conforme as oscilações do mercado.
- Ações, fundos imobiliários (FIIs) e ETFs são exemplos comuns.
- É sobre esse contexto que iremos fazer o teste técnico.

## Glossário

- **Ativo**
    - Qualquer item que tenha valor econômico e possa ser negociado.
    - No mercado financeiro, ativos são títulos que representam participação (como ações) ou direitos sobre algo (como cotas de fundos).
    - Ex: ITSA3, KDIF11.

- **Preço**
    - O preço de um ativo é determinado pela lei da oferta e demanda no mercado.
    - Se mais pessoas querem comprar do que vender, o preço sobe.
    - Se há mais vendedores que compradores, o preço cai.

- **Bolsa de Valores**
    - É o ambiente onde os ativos são negociados.
    - No Brasil, a principal é a B3 (Brasil, Bolsa, Balcão).

- **Volatilidade**
    - É a medida da variação de preços de um ativo.
    - Alta volatilidade significa que os preços mudam bastante em curtos períodos.

- **Dividendos/JSP**
    - Parte do lucro da empresa distribuído aos acionistas/cotistas.
    - Um atrativo para quem investe em ações/fiis com foco em renda.

- **Preço Médio**
    - Média dos preços das operações, subtraindo os dividendos.

- **P&L**
    - Profit (Lucro) & Loss (Prejuízo)
    - Lucro / Prejuízo do cliente
    - Valor pago vs preço atual do mercado.

- **Tipo Operação**
    - Compra e Venda

- **Corretagem**
    - Valor pago a Corretora Itaú por intermediar a operação com a Clearing (B3)

## O que é esperado no teste

Esse teste visa conhecer o potencial de cada um dos concorrentes em:

- Encontrar pistas
- Prestar atenção nas histórias de negócios e técnicas
- Estudos extras (negócio)
- Qualidade, lógica e programação bem-feita
- Evitar Over Engineering
- Testes automatizados
- Documentação
- Ser criativo nas soluções


## 1. Modelagem de Banco Relacional

Você está desenvolvendo um sistema para controle de investimentos. Modele as tabelas a seguir:

• Usuários  (Id, Nome, Email, %Corretagem)
• Ativos    (Id, Codigo, Nome)
• Operações (Id, UsuarioId, AtivoId, Quantidade, PrecoUnitario, TipoOperacao, Corretagem, DataHora)
• Cotação   (Id, AtivoId, PrecoUnitario, DataHora)
• Posição   (Id, IdUsuario, AtivoId, Quantidade, PrecoMedio, P&L)

Tarefas:

1. Apresente o script SQL de criação das tabelas (Utilize Abreviações e snake_case).
2. Justifique a escolha dos tipos de dados.


## 2. Índices e Performance

O sistema precisa consultar rapidamente todas as operações de um usuário em determinado ativo nos últimos 30 dias.

As cotações podem mudar em milésimos de segundos, e deve afetar em real time a Posição dos Clientes, o P&L e o Preço Médio.

Tarefas:

1. Proponha e justifique um ou mais índices para essa consulta.
2. Escreva o SQL da consulta otimizada.
3. Crie a estrutura para atualização da Posição, com base na cotação.


## 3. Aplicação

Crie uma aplicação em .Net/C# que acesse os dados de operações de um usuário e calcule:
- O total investido por ativo
- A posição por papel de um investidor
- A posição global de um cliente com lucro ou prejuízo
- O total de corretagem por cliente

Tarefa:

1. Crie a aplicação (sem dependências externas), utilizando boas práticas de separação de responsabilidade.
2. Utilize async/await com Entity Framework ou Dapper.


## 4. Lógica de Negócio - Preço Médio

Implemente um método que receba todas as compras de um ativo e calcule o preço médio ponderado de aquisição.

Tarefas:

1. Considere diferentes quantidades e preços para compor o cálculo.
2. O método deve tratar entradas inválidas.


## 5. Testes Unitários

Utilizando o método anterior, crie uma bateria de testes unitários com xUnit ou MSTest.

Tarefas:

1. Testes positivos com valores esperados.
2. Testes de erro (quantidade zero, listas vazias).
3. Estrutura clara e isolada.

## 6. Testes Mutantes

Explique o conceito de teste mutante e sua importância.

Tarefa:

1. Dê um exemplo de mutação aplicada ao método de preço médio que faria um teste falhar.




## 7. Integração entre Sistemas

Um microserviço externo envia cotações novas via Kafka.

Tarefas:

1. Adicione um Worker Service .NET para consumir essa fila e salvar as cotações.
2. Inclua estratégias de retry e idempotência.




## 8. Engenharia do Caos

Seu serviço de operações deve continuar funcionando mesmo que o serviço de cotações esteja indisponível.

Tarefa:

1. Aplicar circuit breaker, fallback e observabilidade nesse cenário.



## 9. Escalabilidade e Performance

Com o crescimento do sistema, o volume de operações subiu para 1 milhão/dia.

Tarefas:

1. Explique como aplicar auto-scaling horizontal no serviço.
2. Compare estratégias de balanceamento de carga (round-robin vs latência).



## 10. Documentação e APIs

Você precisa expor APIs REST:
• Permita informar um ativo e receber a última cotação.
• Consultar o preço médio por ativo para um usuário.
• Consultar a posição de um cliente.
• Ver o valor financeiro ganho pela corretora com as corretagens.
• Receber os Top 10 clientes com maiores posições, e os Top 10 clientes que mais pagaram corretagem.



## Dicas:

- Api para consulta de cotações: https://b3api.vercel.app/
- Saiba + sobre RV com o Itaú em: https://www.itaucorretora.com.br/educacional/educacional.aspx
- Site B3: https://www.b3.com.br/pt_br/produtos-e-servicos/negociacao/renda-variavel/


