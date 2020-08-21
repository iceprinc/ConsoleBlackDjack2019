using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4c_
{
    class Card
    {
        public int[,] mast_card = new int[4, 9];
        public void Fill_standrat()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 0)//0-червей
                    {
                        mast_card[i, j] = j;
                    }
                    if (i == 1)//1-бубей
                    {
                        mast_card[i, j] = j;
                    }
                    if (i == 2)//2-крестей
                    {
                        mast_card[i, j] = j;
                    }
                    if (i == 3)//3-пик
                    {
                        mast_card[i, j] = j;
                    }
                }
            }
        }
    }
    class Player
    {
        public string name;
        public int[,] cards_player = new int[4, 9];
        public int power;
        public int money;
        public bool doobleA = false;
    }
    class Program
    {
        static int cards_in_coloda = 36;
        static int[,] used_cards = new int[4, 9];
        static public int[,] TakeCard(int[,] card)
        {
            Card newcoloda = new Card();
            newcoloda.Fill_standrat();
            Random r = new Random();
            int mast;
            int carta;
            int conecColodi = 0;
            TakeRandom:
            mast = r.Next(0, 4);
            carta = r.Next(0, 9);
            if (conecColodi != 36)
            {
                if (used_cards[mast, carta] == -1)
                {
                    card[mast, carta] = newcoloda.mast_card[mast, carta];
                    used_cards[mast, carta] = newcoloda.mast_card[mast, carta];
                    cards_in_coloda--;
                    goto Exit;
                }
                else
                {
                    conecColodi++;
                    goto TakeRandom;
                }
            }
            else
            {
                Console.WriteLine("Ошибка. В колоде закончились карты.\nНажмите любую клавишу. . .");
                Console.ReadLine();
            }
            Exit:;
            return card;
        }
        static public void ShowPlayersCardsNow(int[,] player)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Console.Write("Черви: ");
                }
                if (i == 1)
                {
                    Console.Write("Буби: ");
                }
                if (i == 2)
                {
                    Console.Write("Крести: ");
                }
                if (i == 3)
                {
                    Console.Write("Пики: ");
                }
                for (int j = 0; j < 9; j++)
                {
                    if (player[i, j] != -1)
                    {
                        if (i == 0)//0-червей
                        {
                            if (j == 0)//6
                                Console.Write("[6 Червей] ");
                            if (j == 1)//7
                                Console.Write("[7 Червей] ");
                            if (j == 2)//8
                                Console.Write("[8 Червей] ");
                            if (j == 3)//9
                                Console.Write("[9 Червей] ");
                            if (j == 4)//10
                                Console.Write("[10 Червей] ");
                            if (j == 5)//J
                                Console.Write("[J Червей] ");
                            if (j == 6)//Q
                                Console.Write("[Q Червей] ");
                            if (j == 7)//K
                                Console.Write("[K Червей] ");
                            if (j == 8)//A
                                Console.Write("[A Червей] ");
                        }
                        if (i == 1)//1-Бубей
                        {
                            if (j == 0)//6
                                Console.Write("[6 Бубей] ");
                            if (j == 1)//7
                                Console.Write("[7 Бубей] ");
                            if (j == 2)//8
                                Console.Write("[8 Бубей] ");
                            if (j == 3)//9
                                Console.Write("[9 Бубей] ");
                            if (j == 4)//10
                                Console.Write("[10 Бубей] ");
                            if (j == 5)//J
                                Console.Write("[J Бубей] ");
                            if (j == 6)//Q
                                Console.Write("[Q Бубей] ");
                            if (j == 7)//K
                                Console.Write("[K Бубей] ");
                            if (j == 8)//A
                                Console.Write("[A Бубей] ");
                        }
                        if (i == 2)//2-Крестей
                        {
                            if (j == 0)//6
                                Console.Write("[6 Крестей] ");
                            if (j == 1)//7
                                Console.Write("[7 Крестей] ");
                            if (j == 2)//8
                                Console.Write("[8 Крестей] ");
                            if (j == 3)//9
                                Console.Write("[9 Крестей] ");
                            if (j == 4)//10
                                Console.Write("[10 Крестей] ");
                            if (j == 5)//J
                                Console.Write("[J Крестей] ");
                            if (j == 6)//Q
                                Console.Write("[Q Крестей] ");
                            if (j == 7)//K
                                Console.Write("[K Крестей] ");
                            if (j == 8)//A
                                Console.Write("[A Крестей] ");
                        }
                        if (i == 3)//3-Пик
                        {
                            if (j == 0)//6
                                Console.Write("[6 Пик] ");
                            if (j == 1)//7
                                Console.Write("[7 Пик] ");
                            if (j == 2)//8
                                Console.Write("[8 Пик] ");
                            if (j == 3)//9
                                Console.Write("[9 Пик] ");
                            if (j == 4)//10
                                Console.Write("[10 Пик] ");
                            if (j == 5)//J
                                Console.Write("[J Пик] ");
                            if (j == 6)//Q
                                Console.Write("[Q Пик] ");
                            if (j == 7)//K
                                Console.Write("[K Пик] ");
                            if (j == 8)//A
                                Console.Write("[A Пик] ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static public void FillNewColoda(int[,] player)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    player[i, j] = -1;
                }
            }
        }
        static public Player CalculatePower(Player player)
        {
            int cardstandart = 0;
            int cardA = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (player.cards_player[i, j] != -1)
                    {
                        if (j == 0)//6
                        {
                            player.power += 6;
                            cardstandart++;
                        }
                        if (j == 1)//7
                        {
                            player.power += 7;
                            cardstandart++;
                        }
                        if (j == 2)//8
                        {
                            player.power += 8;
                            cardstandart++;
                        }
                        if (j == 3)//9
                        {
                            player.power += 9;
                            cardstandart++;
                        }
                        if (j == 4)//10
                        {
                            player.power += 10;
                            cardstandart++;
                        }
                        if (j == 5)//J валет - 10 очков
                        {
                            player.power += 2;
                            cardstandart++;
                        }
                        if (j == 6)//Q 10 очков
                        {
                            player.power += 3;
                            cardstandart++;
                        }
                        if (j == 7)//K 10 очков
                        {
                            player.power += 4;
                            cardstandart++;
                        }
                    }
                }
            for (int i = 0; i < 4; i++)
            {
                if (player.cards_player[i, 8] != -1)//A 1 или 11 очков
                {
                    cardA++;
                    if (player.power + 11 <= 21)
                        player.power += 11;
                    else
                        player.power += 1;
                }
            }
            if (cardstandart == 0)
            {
                if (cardA == 2)
                {
                    player.doobleA = true;
                }
            }
            return player;
        }
        static public Player NewGame(Player player1)
        {
            cards_in_coloda = 36;
            bool split = false;
            FillNewColoda(used_cards);
            error:
            Console.Clear();
            Console.WriteLine($"Диллер: 'Желаю удачи, {player1.name}, введите вашу ставку: '");
            int stavka;
            stavka = Convert.ToInt32(Console.ReadLine());
            if (stavka < 1)
            {
                Console.Clear();
                Console.WriteLine("Диллер: 'Минимальная ставка [1 $]'\nНажмите 'Enter'. . .");
                Console.ReadLine();
                goto error;
            }
            if (stavka > player1.money)
            {
                Console.Clear();
                Console.WriteLine($"Диллер: 'У вас нет столько денег'\n(Подсказка у вас на счету {player1.money} $)\nНажмите 'Enter'. . .");
                Console.ReadLine();
                goto error;
            }
            else
            {
                Console.Clear();
                player1.money -= stavka;
                Console.WriteLine($"Диллер: 'Ваша ставка [{stavka} $] - принята!'\nНажмите любую клавишу что бы начать игру. . .");
                Console.ReadLine();
            }
            player1.cards_player = new int[4, 9];
            FillNewColoda(player1.cards_player);
            TakeCard(player1.cards_player);
            TakeCard(player1.cards_player);
            Player dealer = new Player();
            dealer.cards_player = new int[4, 9];
            FillNewColoda(dealer.cards_player);
            TakeCard(dealer.cards_player);
            Player player2 = new Player();//2-я рука (split)
            player2.cards_player = new int[4, 9];
            FillNewColoda(player2.cards_player);
            player2.name = player1.name + " #split";
            Choose:
            Console.Clear();
            Console.WriteLine($"Ставка: [{stavka} $]\nВ колоде карт: {cards_in_coloda}");
            Console.WriteLine("Вы видите только первую карту диллера: ");
            ShowPlayersCardsNow(dealer.cards_player);
            Console.WriteLine($"Карты игрока [{player1.name}]: ");
            ShowPlayersCardsNow(player1.cards_player);
            if (split == false)//ПЕРЕБОР
            {
                player1 = CalculatePower(player1);
                if (player1.power > 21)
                {
                    Console.WriteLine($"Диллер: 'перебор.Вы проиграли свою ставку.' - [{stavka} $]\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                }
                if(player1.power==21)
                {
                    player1.money += Convert.ToInt32(stavka * 2.5);
                    Console.WriteLine($"Дилер: 'Блек-Джек! вы выиграли + [{Convert.ToInt32(stavka * 2.5)} $]'\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                }
                if(player1.doobleA==true)
                {
                    player1.money += Convert.ToInt32(stavka * 3);
                    Console.WriteLine($"Дилер: 'Пара тузов! вы выиграли + [{Convert.ToInt32(stavka * 3)} $]'\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                }
            }
            if (split == true)
            {
                player2 = CalculatePower(player2);
                Console.WriteLine($"Карты игрока [{player2.name}]: ");
                ShowPlayersCardsNow(player2.cards_player);
                if (player2.power > 21)//ПЕРЕБОР В СПЛИТЕ
                {
                    Console.WriteLine($"Диллер: 'перебор.Вы проиграли свою ставку.' - [{stavka} $]Нажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                }
                if (player2.doobleA == true)
                {
                    player1.money += Convert.ToInt32(stavka * 3);
                    Console.WriteLine($"Дилер: 'Пара тузов в #split! вы выиграли + [{Convert.ToInt32(stavka * 3)} $]'\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                }
            }
            Console.WriteLine("1 – Взять карту.\n2 – Достаточно.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (split == false)
                        TakeCard(player1.cards_player);
                    else
                        TakeCard(player2.cards_player);
                    goto Choose;
                case "2":
                    if (split == false)
                    {
                        Console.WriteLine($"Ставка: [{stavka} $]\nСплит - удвоить ставку\nХотите использовать сплит?\nДа - Введите 'Да'\nНет - Нажмите 'Enter'");
                        string choice2 = Console.ReadLine();
                        switch (choice2)
                        {
                            case "Да":
                                split = true;
                                player1.money -= stavka;
                                stavka += stavka;
                                Console.WriteLine($"Ставка удвоена!\nСтавка: [{stavka} $]");
                                goto Choose;
                            default:
                                split = false;
                                goto exitfromsplit;
                        }
                    }
                    exitfromsplit:;
                    TakeCard(dealer.cards_player);
                    dealer = CalculatePower(dealer);
                    Console.Clear();
                    Console.WriteLine("Диллер взял ещё 1 карту.");
                    Console.WriteLine($"В колоде карт: {cards_in_coloda}");
                    Console.WriteLine("Карты диллера: ");
                    ShowPlayersCardsNow(dealer.cards_player);
                    Console.WriteLine($"Карты игрока [{player1.name}]: ");
                    ShowPlayersCardsNow(player1.cards_player);
                    if (split == true)
                    {
                        Console.WriteLine($"Карты игрока [{player2.name}]: ");
                        ShowPlayersCardsNow(player2.cards_player);
                    }
                    Console.WriteLine("\n\nИтог игры: ");
                    if (split == false)
                    {
                        if (player1.power > dealer.power)
                        {
                            player1.money += stavka*2;
                            Console.WriteLine($"Выигрыш по очкам! + [{stavka*2} $]");
                        }
                        else
                            Console.WriteLine($"Проигрыш по очкам. - [{stavka*2} $]");
                    }
                    if(split==true)
                    {
                        int win = 0;
                        if (player1.power > dealer.power)
                        {
                            win++;
                        }
                        if (player2.power > dealer.power)
                        {
                            win++;
                        }
                        if(win==0)
                        {
                            Console.WriteLine($"Split(x2): Проигрыш по очкам два раза. - [{stavka} $]");
                        }
                        if(win ==1)
                        {
                            player1.money += stavka/2;
                            Console.WriteLine($"Split(x2): Проигрыш и выигрыш по очкам. Возврат половины ставки. + [{stavka/2} $]");
                        }
                        if(win==2)
                        {
                            player1.money +=stavka*2;
                            Console.WriteLine($"Split(x2): Выигрыш по очкам два раза. + [{stavka * 2} $]");
                        }
                    }
                    Console.WriteLine("Для выхода в меню нажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                default:
                    Console.Clear();
                    Console.WriteLine("Ошибка!\nВводить нужно число от 1 до 3 !\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto Choose;
            }
            exit:;
            return player1;
        }
        static void Main(string[] args)//при ничьей выигрывает казино
        {
            Console.WriteLine("\tKAZINO\n!!! BLACK DJACK !!!");
            Player startplayer = new Player();
            Console.WriteLine("\nРегистрация:\nКак вас зовут?");
            startplayer.name = Console.ReadLine();
            startplayer.money = 100;
            Console.WriteLine($"Диллер: 'Здравствуйте, {startplayer.name}! Вам выдано [{startplayer.money} $]'\nНажмите 'Enter'. . .");
            Console.ReadLine();
            choose:;
            Console.Clear();
            if(startplayer.money<1)
            {
                Console.WriteLine($"Игрок: [{startplayer.name}]\nДеньги: [{startplayer.money} $]\n\nДиллер: 'У вас закончилиь деньги!'\nНажмите 'Enter'. . .");
                Console.ReadLine();
                goto exit;
            }
            Console.WriteLine($"Игрок: [{startplayer.name}]\nДеньги: [{startplayer.money} $]\n\nДиллер: 'Хотите сыграть в Black Djack ?'\n1 - Да\n2 - Выход");
            string choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    startplayer=NewGame(startplayer);
                    goto choose;
                case "2":
                    Console.WriteLine("Выход.\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto exit;
                    default:
                    Console.Clear();
                    Console.WriteLine("Ошибка!\nВводить нужно число 1 или 2 !\nНажмите 'Enter'. . .");
                    Console.ReadLine();
                    goto choose;
            }
            exit:;
        }
    }
}