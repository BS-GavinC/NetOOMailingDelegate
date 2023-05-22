using NetOOMailingDelegate;

Mailling mailling = new Mailling();


User user = new User("aaa@aaa.com");
User user2 = new User("bbb@aaa.com");
User user3 = new User("ccc@aaa.com");
User user4 = new User("ddd@aaa.com");
User user5 = new User("eee@aaa.com");


mailling.SubToNews(user);
mailling.SubToNews(user3);
mailling.SubToNews(user4);

mailling.SubToPubs(user2);
mailling.SubToPubs(user3);
Console.WriteLine("Premier envoi");
mailling.SendNews("Derniere nouvelle ! Apres un entrainement effrainé, un ane est devenu un cheval.");

mailling.UnSubToNews(user3);
Console.WriteLine("Deuxieme envoi");
mailling.SendNews("Derniere nouvelle ! Apres un entrainement effrainé, un scarabee est devenu un chocapic.");

Console.WriteLine("La pub ? Beurk");
mailling.SendPubs("Super promo a l'achat de 2 boite de kellogs recevez 2 boites de kellogs");
