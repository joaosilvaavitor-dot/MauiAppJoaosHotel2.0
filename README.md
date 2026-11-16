# 🏨 Joao´s Hotel

Um aplicativo para calcular o valor de uma hospedagem em hotel.

Você escolhe quantas pessoas vão, qual quarto prefere e em quais dias quer ficar. O app faz a conta e mostra o valor total.

Este projeto foi feito como atividade do curso Técnico em Desenvolvimento de Sistemas.

## ✨ O que o app faz

- Dá as boas-vindas ao hóspede em uma tela inicial
- Permite escolher a quantidade de adultos e de crianças
- Mostra uma lista de quartos para escolher
- Permite marcar o dia de entrada e o dia de saída
- Calcula o valor total da estadia automaticamente
- Mostra um resumo da reserva
- Mostra as promoções do hotel
- Tem uma tela **Sobre** com informações de quem criou o app

## 📱 Telas

1. **Boas-vindas:** a primeira tela, com o nome do hotel e os botões para reservar, ver promoções e conhecer o app.
2. **Reserva:** onde você monta a sua reserva.
3. **Resumo:** mostra os dados escolhidos e o valor total.
4. **Promoções:** lista de ofertas do hotel.
5. **Sobre:** mostra o nome do desenvolvedor e o ano de criação.

<img width="555" height="709" alt="Captura de tela 2026-11-16 003915" src="https://github.com/user-attachments/assets/51e8a25e-aec9-4f33-8dee-94970e03b5c4" />
<img width="550" height="710" alt="Captura de tela 2026-11-16 003931" src="https://github.com/user-attachments/assets/c05ffc3d-6ac6-486d-ab72-e873c2c97968" />
<img width="543" height="664" alt="Captura de tela 2026-11-16 003953" src="https://github.com/user-attachments/assets/b9eb0c84-bcab-4f77-9ea0-a357e2da60e7" />
<img width="557" height="577" alt="Captura de tela 2026-11-16 004019" src="https://github.com/user-attachments/assets/a57090d9-7921-4fa8-a1ca-212f92bdd104" />


## 🛠️ Tecnologias usadas

| Tecnologia | Para que foi usada |
|------------|--------------------|
| **.NET MAUI** | Criar o aplicativo para Windows e Android com um único código |
| **C#** | Programar as regras do app, como o cálculo do valor |
| **XAML** | Montar o visual das telas (botões, textos, cores) |
| **Visual Studio** | Programa usado para criar e testar o app |
| **Git e GitHub** | Guardar o projeto e compartilhar com o professor |

Componentes de tela usados: `Stepper` (quantidade de pessoas), `Picker` (lista de quartos), `DatePicker` (escolha de datas), `CollectionView` (lista de promoções) e `BindingContext` (envio dos dados de uma tela para a outra).

## 🧮 Como o valor é calculado

O app soma o preço de cada pessoa por dia e multiplica pelo número de dias.

| Quarto | Adulto (por dia) | Criança (por dia) |
|--------|------------------|-------------------|
| Suíte Super Luxo | R$ 110,00 | R$ 55,00 |
| Suíte Luxo | R$ 80,00 | R$ 40,00 |
| Suíte Single | R$ 50,00 | R$ 25,00 |
| Suíte Crise | R$ 25,00 | R$ 12,50 |

## ▶️ Como abrir o app

1. Baixe o projeto do GitHub.
2. Abra o arquivo `MauiAppHotel.sln` no Visual Studio.
3. Escolha onde quer testar: no computador (Windows) ou no emulador de celular Android.
4. Aperte **F5** e espere o app abrir.

## 👨‍💻 Autor

**João**
Desenvolvimento de Sistemas, 2026
