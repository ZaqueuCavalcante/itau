# TODOS

## GET /trades?assetId=151&start=ABC&end=DEF

O sistema precisa consultar rapidamente todas as operações de um usuário em determinado ativo nos últimos 30 dias.

As cotações podem mudar em milésimos de segundos, e deve afetar em real time a Posição dos Clientes, o P&L e o Preço Médio.

Tarefas:

1. Proponha e justifique um ou mais índices para essa consulta.
2. Escreva o SQL da consulta otimizada.
3. Crie a estrutura para atualização da Posição, com base na cotação.
