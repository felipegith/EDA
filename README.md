Este projeto foi desenvolvido utilizando .NET e segue os princípios de Clean Architecture, CQRS (Command Query Responsibility Segregation) e Event Driven Architecture. O principal objetivo deste projeto é demonstrar a implementação de uma arquitetura orientada a eventos, com um exemplo prático de evento de integração utilizando RabbitMQ e Masstransit.

A aplicação foi estruturada para promover a separação de responsabilidades e facilitar a manutenção e escalabilidade do código. A arquitetura limpa (Clean Architecture) garante que os componentes da aplicação sejam independentes e facilmente testáveis, enquanto o CQRS permite uma gestão eficiente das operações de leitura e escrita, segregando-as em diferentes modelos.

Na implementação da arquitetura orientada a eventos, o RabbitMQ é utilizado como broker de mensagens para gerenciar a comunicação entre os diferentes componentes da aplicação. O Masstransit, por sua vez, facilita o gerenciamento das mensagens e a integração com o RabbitMQ, proporcionando uma solução robusta e escalável para a comunicação assíncrona.

Este projeto serve como um guia prático para desenvolvedores que desejam entender e implementar uma arquitetura orientada a eventos em aplicações .NET, destacando as melhores práticas e fornecendo um exemplo concreto de evento de integração
