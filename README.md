#Consultoria Opah - Financial Flow


### Descrição da Solução
Esta solução visa atender a necessidade de um comerciante em controlar seu fluxo de caixa diário, gerenciando lançamentos (débitos e créditos e pix) e gerando relatórios de saldo diário, mensal e anual consolidado.

### Estrutura do Projeto
A solução está estruturada em quatro camadas principais e o CORE (onde utilizar classes que são reutilizaveis)

### Estrutura do Projeto
A solução possui um service broker consumer RabbitMQ. Pois o lançamentos é enviar para uma fila de processamento, evitando a parca de dados em caso de falha sistemica. 

### Domain: 
 Contém as entidades, agregados, valores de objetos, serviços de domínio e interfaces de repositórios.

### Application: 
Contém os serviços de aplicação, DTOs (Data Transfer Objects) e interfaces de serviços de aplicação.

### Infrastructure:
Contém as implementações de repositórios, contexto de banco de dados e serviços de infraestrutura.

### API:
Contém os controladores e configurações da API.
Requisitos de Negócio
Serviço que faça o controle de lançamentos
Serviço do consolidado diário

### Docker
A aplicação está pronta para rodar em container Docker, possui Dockerfile e Docker Compose.

### IMPORTANTE:
  - É preciso utilizar update-database para rodar as atualizações de banco de dados o banco de dados (utilização de migrations do EF)
 
