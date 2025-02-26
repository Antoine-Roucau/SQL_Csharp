using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto;

namespace Projet_MDD
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Interface();
        }
        
        
        static void Interface()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Met la police en couleur Cyan
            Console.CursorVisible = false; // efface le curseur de l'écran
            Console.WriteLine("\n\n   ##   ##             ###             ##   ##");
            Console.WriteLine("   ##   ##              ##             ### ###");
            Console.WriteLine("   ##   ##    ####      ##      ####   #######    ####    ##  ##");
            Console.WriteLine("   ##   ##   ##  ##     ##     ##  ##  ## # ##       ##    ####");
            Console.WriteLine("   ##   ##   ######     ##     ##  ##  ##   ##    #####     ##");
            Console.WriteLine("    ## ##    ##         ##     ##  ##  ##   ##   ##  ##    ####");
            Console.WriteLine("     ###      #####    ####     ####   ##   ##    #####   ##  ##");
            Console.ReadKey();
            bool main = true; // instancie une variable pour signifier que le jeu tourne
            int flèche = 0; // instancie une variable flèche qui va aller de 0 à 3 pour pouvoir parcourir les menus
            bool enter = false; // instancie enter pour dire lorsque la touche entrer est appuier
            Console.Clear();
            Console.WriteLine("\nOption :\n"); // le menu est sur 5 ligne donc 4 qui peuvent être parcouru (Admin (root), Client (bozo), Rapport statistique et Quitter ) et commence sur Admin (root) donc écrit Admin (root) avec une flèche "<--"
            Console.WriteLine("Admin (root)         <--");
            Console.WriteLine("Client (bozo)           ");
            Console.WriteLine("Rapport statistique     ");
            Console.WriteLine("Quitter                 ");
            while (main)
            {
                ConsoleKeyInfo touche = Console.ReadKey(); // lis la touche qui est appuier
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow: // si la touche est flèche du haut, fait -1 à la variable flèche
                        flèche -= 1;
                        break;
                    case ConsoleKey.DownArrow: // si la touche est flèche du bas, fait +1 à la variable flèche
                        flèche += 1;
                        break;
                    case ConsoleKey.Enter: // si la touche est Entrer, met true à la variabel enter pour dire que l'utilisateur veux accéder à la ligne où la flèche "<--" est.
                        enter = true;
                        break;
                    default:
                        break;
                }
                Console.Clear(); // clear la console pour actualiser l'affichage
                Console.WriteLine("\nOption : \n");
                if (flèche > 3) // fait en sorte que la variable flèche de puisse pas dépasser 3
                {
                    flèche = 3;
                }
                else if (flèche < 0) // fait en sorte que la variable flèche de puisse pas être en dessous de 0
                {
                    flèche = 0;
                }
                if (flèche == 0)
                {
                    Console.WriteLine("Admin (root)         <--");
                    Console.WriteLine("Client (bozo)           ");
                    Console.WriteLine("Rapport statistique     ");
                    Console.WriteLine("Quitter                 ");
                }
                else if (flèche == 1)
                {
                    Console.WriteLine("Admin (root)            ");
                    Console.WriteLine("Client (bozo)        <--");
                    Console.WriteLine("Rapport statistique     ");
                    Console.WriteLine("Quitter                 ");
                }
                else if (flèche == 2)
                {
                    Console.WriteLine("Admin (root)            ");
                    Console.WriteLine("Client (bozo)           ");
                    Console.WriteLine("Rapport statistique  <--");
                    Console.WriteLine("Quitter                 ");

                }
                else if (flèche == 3)
                {
                    Console.WriteLine("Admin (root)            ");
                    Console.WriteLine("Client (bozo)           ");
                    Console.WriteLine("Rapport statistique     ");
                    Console.WriteLine("Quitter              <--");
                }
                if (enter == true && flèche == 0) // si la var flèche est égale à 0, et que la variable enter est true, lance le menu admin puis après, actualise l'affichage pour "retouner" au menu de base
                {
                    Console.Clear();
                    enter = false;
                    Admin();

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nOption : \n");
                    Console.WriteLine("Admin (root)         <--");
                    Console.WriteLine("Client (bozo)           ");
                    Console.WriteLine("Rapport statistique     ");
                    Console.WriteLine("Quitter                 ");
                }
                else if (enter == true && flèche == 1) // si la var flèche est égale à 1, et que la variable enter est true, lance le menu client puis après que menu soit quitté, actualise l'affichage pour "retouner" au menu de base
                {
                    Console.Clear();
                    enter = false;
                    Client();

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nOption : \n");
                    Console.WriteLine("Admin (root)            ");
                    Console.WriteLine("Client (bozo)        <--");
                    Console.WriteLine("Rapport statistique     ");
                    Console.WriteLine("Quitter                 ");
                }
                else if (enter == true && flèche == 2) // si la var flèche est égale à 2, et que la variable enter est true, lance le Rapport statistique puis après qu'il soit quitté, actualise l'affichage pour "retouner" au menu de base
                {
                    Console.Clear();
                    enter = false;
                    Rapport();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nOption : \n");
                    Console.WriteLine("Admin (root)            ");
                    Console.WriteLine("Client (bozo)           ");
                    Console.WriteLine("Rapport statistique  <--");
                    Console.WriteLine("Quitter                 ");
                }
                else if (enter == true && flèche == 3) // si la var flèche est égale à 3, et que la variable enter est true, l'utilisateur souhaite quitter l'application
                {
                    Console.Clear();
                    Console.WriteLine("\n A bientôt !"); // affiche un message d'au revoir
                    main = false; // instancie jeu comme false pour que la boucle se termine et donc que l'application s'arrête
                }
            }
        }
        static void Admin()
        {
            Console.CursorVisible = false;
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;PASSWORD=root;";
            bool admi = true;
            int flèche = 0;
            bool enter = false;
            Console.WriteLine("\nRoot :\n");
            Console.WriteLine("Fournisseurs  <--");
            Console.WriteLine("Employés         ");
            Console.WriteLine("Vélos            ");
            Console.WriteLine("Pièces           ");
            Console.WriteLine("Client           ");
            Console.WriteLine("Entreprises      ");
            Console.WriteLine("Souscription     ");
            Console.WriteLine("Commandes        ");
            Console.WriteLine("Stock            ");
            Console.WriteLine("Déconnexion      ");
            while (admi)
            {
                ConsoleKeyInfo touche = Console.ReadKey();
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow:
                        flèche -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        flèche += 1;
                        break;
                    case ConsoleKey.Enter:
                        enter = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("\nRoot :\n");
                if (flèche > 9)
                {
                    flèche = 9;
                }
                else if (flèche < 0)
                {
                    flèche = 0;
                }
                if (flèche == 0)
                {
                    Console.WriteLine("Fournisseurs  <--");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 1)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés      <--");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 2)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos         <--");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 3)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces        <--");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 4)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client        <--");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 5)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises   <--");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 6)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription  <--");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 7)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes     <--");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 8)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock         <--");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (flèche == 9)
                {
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion   <--");
                }
                if (enter == true && flèche == 0)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "fournisseur");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs  <--");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 1)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "employe");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés      <--");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 2)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "velo");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos         <--");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 3)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "piece");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces        <--");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 4)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "client");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client        <--");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 5)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "entreprises");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         "); ;
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises   <--");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 6)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "souscription");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription  <--");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 7)
                {
                    Console.Clear();
                    enter = false;
                    Gestion(connectionString, "commande");

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes     <--");
                    Console.WriteLine("Stock            ");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 8)
                {
                    Console.Clear();
                    enter = false;
                    Stock(connectionString);
                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nRoot :\n");
                    Console.WriteLine("Fournisseurs     ");
                    Console.WriteLine("Employés         ");
                    Console.WriteLine("Vélos            ");
                    Console.WriteLine("Pièces           ");
                    Console.WriteLine("Client           ");
                    Console.WriteLine("Entreprises      ");
                    Console.WriteLine("Souscription     ");
                    Console.WriteLine("Commandes        ");
                    Console.WriteLine("Stock         <--");
                    Console.WriteLine("Déconnexion      ");
                }
                else if (enter == true && flèche == 9)
                {
                    admi = false;
                }
            }
        }
        static void Client()
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=Bozo;PASSWORD=Antoine2103!;";
            bool clie = true;
            int flèche = 0;
            bool enter = false;
            Console.Clear();
            Console.WriteLine("\nBozo :\n");
            Console.WriteLine("Mes informations   <--");
            Console.WriteLine("Mes commandes         ");
            Console.WriteLine("Pièces de Vélo        ");
            Console.WriteLine("Vélos                 ");
            Console.WriteLine("Commander             ");
            Console.WriteLine("Déconnexion           ");
            while (clie)
            {
                ConsoleKeyInfo touche = Console.ReadKey();
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow:
                        flèche -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        flèche += 1;
                        break;
                    case ConsoleKey.Enter:
                        enter = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("\nBozo : \n");
                if (flèche > 5)
                {
                    flèche = 5;
                }
                else if (flèche < 0)
                {
                    flèche = 0;
                }
                if (flèche == 0)
                {
                    Console.WriteLine("Mes informations   <--");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (flèche == 1)
                {
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes      <--");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (flèche == 2)
                {
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo     <--");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (flèche == 3)
                {
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos              <--");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (flèche == 4)
                {
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander          <--");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (flèche == 5)
                {
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion        <--");
                }
                if (enter == true && flèche == 0)
                {
                    Console.Clear();
                    enter = false;
                    Console.WriteLine("\nMes informations :\n");
                    Console.WriteLine(CommandeClient("SELECT * FROM client WHERE idClient = 1", connectionString, "client"));
                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nBozo : \n");
                    Console.WriteLine("Mes informations   <--");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (enter == true && flèche == 1)
                {
                    Console.Clear();
                    enter = false;
                    Console.WriteLine("\nMes commandes :\n");
                    string command = @"SELECT Commande.*, AppartientCommande.*, piece.descriptionPiece AS nom_piece, velo.nomVelo AS nom_velo
                                       FROM Commande
                                       JOIN AppartientCommande ON Commande.idCommande = AppartientCommande.idCommande
                                       LEFT JOIN piece ON AppartientCommande.idPiece = Piece.idPiece
                                       LEFT JOIN velo ON AppartientCommande.idVelo = Velo.idVelo 
                                       WHERE Commande.idClient = 1;";
                    Console.WriteLine(MesCommandes(command, connectionString));
                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nBozo : \n");
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes      <--");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (enter == true && flèche == 2)
                {
                    Console.Clear();
                    enter = false;
                    Console.WriteLine(AfficheTable(connectionString, "piece"));
                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nBozo : \n");
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo     <--");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (enter == true && flèche == 3)
                {
                    Console.Clear();
                    enter = false;
                    Console.WriteLine(AfficheTable(connectionString, "velo"));
                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nBozo : \n");
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos              <--");
                    Console.WriteLine("Commander             ");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (enter == true && flèche == 4)
                {
                    Console.Clear();
                    enter = false;
                    Commandes();

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nBozo : \n");
                    Console.WriteLine("Mes informations      ");
                    Console.WriteLine("Mes commandes         ");
                    Console.WriteLine("Pièces de Vélo        ");
                    Console.WriteLine("Vélos                 ");
                    Console.WriteLine("Commander          <--");
                    Console.WriteLine("Déconnexion           ");
                }
                else if (enter == true && flèche == 5)
                {
                    Console.Clear();
                    clie = false;
                }
            }
        }
        static void Commandes()
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;PASSWORD=root;";
            bool fin = true;
            bool velo = true;
            int idCommande = Convert.ToInt16(SelectCommande("SELECT count(idcommande) FROM commande;", connectionString)) + 1;
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\nCommande : \n");
                if (velo) { Console.WriteLine("Voulez-vous un vélo : "); }
                else { Console.WriteLine("Voulez-vous un autre vélo : "); }
                Console.WriteLine("\n( oui ou non )");
                Console.WriteLine("\n( exit pour sortir )");
                if (velo) { Console.SetCursorPosition(22, Console.CursorTop - 5); }
                else { Console.SetCursorPosition(28, Console.CursorTop - 5); }
                Console.CursorVisible = true;
                string var = Console.ReadLine();
                Console.CursorVisible = false;
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                else if (var == "oui")
                {
                    int idVelo = 0;
                    int nb = 0;
                    int nbpiece = 0;
                    bool livraison = false;
                    while (true && fin)
                    {
                        Console.Clear();
                        Console.WriteLine("\nVélos :");
                        Console.WriteLine(AfficheTable(connectionString, "velo"));
                        Console.WriteLine("Lequel voulez-vous (idVelo) : ");
                        Console.WriteLine("\nCombien en voulez-vous :");
                        Console.WriteLine("\n( exit pour sortir )");
                        Console.SetCursorPosition(30, Console.CursorTop - 5);
                        Console.CursorVisible = true;
                        var = Console.ReadLine();
                        Console.CursorVisible = false;
                        if (var == "exit")
                        {
                            fin = false;
                            break;
                        }
                        else
                        {
                            try
                            {
                                idVelo = Convert.ToInt32(var);
                                if (idVelo <= Convert.ToInt16(SelectCommande("SELECT count(idVelo) FROM velo;", connectionString)) && idVelo > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    var = "";
                                    idVelo = 0;
                                }
                            }
                            catch
                            {
                                var = "";
                            }
                        }
                    }
                    while (true && fin)
                    {
                        Console.Clear();
                        Console.WriteLine("\nVélos :");
                        Console.WriteLine(AfficheTable(connectionString, "velo"));
                        Console.WriteLine("Lequel voulez-vous (idVelo) : " + idVelo);
                        Console.WriteLine("\nCombien en voulez-vous : ");
                        Console.WriteLine("\n( exit pour sortir )");
                        Console.SetCursorPosition(25, Console.CursorTop - 3);
                        Console.CursorVisible = true;
                        var = Console.ReadLine();
                        Console.CursorVisible = false;
                        if (var == "exit")
                        {
                            fin = false;
                            break;
                        }
                        else
                        {
                            try
                            {
                                nb = Convert.ToInt32(var);
                                if (nb > 0 && nb <= Convert.ToInt16(SelectCommande("SELECT quantiteVelo FROM velo WHERE idVelo = " + idVelo + ";", connectionString))) // test si il y a assez de velo
                                {
                                    break;
                                }
                                else if (nb > 0 && StockVelo(connectionString, idVelo, (nb - Convert.ToInt16(SelectCommande("SELECT quantiteVelo FROM velo Where idVelo = " + idVelo + ";", connectionString)))))
                                {
                                    nbpiece = nb - Convert.ToInt16(SelectCommande("SELECT quantiteVelo FROM velo WHERE idVelo = " + idVelo + ";", connectionString));
                                    nb -= nbpiece;
                                    break;
                                }
                                else
                                {
                                    nbpiece = nb - Convert.ToInt16(SelectCommande("SELECT quantiteVelo FROM velo WHERE idVelo = " + idVelo + ";", connectionString));
                                    nb -= nbpiece;
                                    livraison = true;
                                    Console.WriteLine("Le délai de livraison va être plus long dû à un manque de pièces.");
                                    timer(3);
                                    break;
                                }
                            }
                            catch
                            {
                                var = "";
                            }
                        }
                    }
                    fin = true;
                    if (velo)
                    {
                        velo = false;
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.Open();

                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO commande (idcommande,dateCommande, dateLivraison, adresseLivraison, idEmploye, idMagasin, idClient, idEntreprises) VALUES (" + idCommande + ",'2024-01-01 10:00:00','2024-01-02 10:00:00','" + SelectCommande("SELECT adresseClient from client where idClient = 1;", connectionString) + "',1,1,1,NULL);";
                        command.ExecuteNonQuery();
                        connection.Close();
                        velo = false;
                    }
                    AppartientCommandeVelo(connectionString, idVelo, nb, nbpiece, livraison, idCommande);
                }
                else if (var == "non")
                {
                    break;
                }
            }
        }
        static void FideloAdd(string connectionString, string idClient)
        {
            Console.Clear();
            string data = "";
            string exemple = "SELECT * FROM souscription LIMIT 1;";
            string colonneName = NomColumn(connectionString, "souscription");
            string[] colonneType = TypeColumn(connectionString, "souscription").Split(',');
            bool fin = true;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nAjouter : Souscription Fidelo\n");
                Console.WriteLine("Nom des colonnes : dateSouscription, idFidelio\n");
                Console.WriteLine("Insérer : ");
                Console.WriteLine("\n\n(mettre des ; pour séparer les éléments)");
                Console.WriteLine("(format pour la date : année-mois-jour)");
                Console.WriteLine("\nExemple : 2024-05-25;3");
                Console.WriteLine("\n(exit pour sortir)");
                Console.SetCursorPosition(10, Console.CursorTop - 9);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            if (fin)
            {
                string[] dataSplit = data.Split(';');
                string commande = "INSERT INTO souscription (dateSouscription, idClient, idFidelio) VALUES ('" + dataSplit[0] + " 00:00:00'," + idClient + "," + dataSplit[1] + ");";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static void AppartientCommandeVelo(string connectionString, int idVelo, int nb, int nbpiece, bool livraison, int idCommande)
        {
            if (nbpiece == 0)
            {
                int quan = Convert.ToInt16(SelectCommande("SELECT quantiteVelo FROM velo WHERE idVelo = " + idVelo + ";", connectionString));
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE velo SET quantiteVelo = " + (quan - nb) + " WHERE idVelo = " + idVelo + ";";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else if (livraison == false)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE velo SET quantiteVelo = 10 WHERE idVelo = " + idVelo + ";";
                command.ExecuteNonQuery();
                connection.Close();
                string[] idPieceAss = SelectCommande("select cadre,guidon,freins,selle,derailleurAvant,derailleurArriere,roueAvant,roueArriere,reflecteurs,pedalier,ordinateur,panier from assemblage where idassemblage = " + idVelo + ";", connectionString).Split(";");

                for (int i = 0; i < idPieceAss.Length; i++)
                {
                    if (idPieceAss[i] != "")
                    {
                        int quan = Convert.ToInt16(SelectCommande("SELECT quantitePiece FROM Piece WHERE idPiece = " + idPieceAss[i] + ";", connectionString));
                        MySqlConnection connection2 = new MySqlConnection(connectionString);
                        connection2.Open();

                        MySqlCommand command2 = connection2.CreateCommand();
                        command2.CommandText = "UPDATE piece SET quantitePiece = " + (quan - nbpiece) + " WHERE idPiece = " + idPieceAss[i] + ";";
                        command2.ExecuteNonQuery();
                        connection2.Close();
                    }
                }
            }
            else if (livraison)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE velo SET quantiteVelo = 10 WHERE idVelo = " + idVelo + ";";
                command.ExecuteNonQuery();
                connection.Close();
                string[] idPieceAss = SelectCommande("select cadre,guidon,freins,selle,derailleurAvant,derailleurArriere,roueAvant,roueArriere,reflecteurs,pedalier,ordinateur,panier from assemblage where idassemblage = " + idVelo + ";", connectionString).Split(";");

                for (int i = 0; i < idPieceAss.Length; i++)
                {
                    if (idPieceAss[i] != "")
                    {
                        int quan = Convert.ToInt16(SelectCommande("SELECT quantitePiece FROM Piece WHERE idPiece = " + idPieceAss[i] + ";", connectionString));
                        int res = quan - nbpiece;
                        if (res <= 0)
                        {
                            res = 10;
                        }
                        MySqlConnection connection3 = new MySqlConnection(connectionString);
                        connection3.Open();

                        MySqlCommand command3 = connection3.CreateCommand();
                        command3.CommandText = "UPDATE piece SET quantitePiece = " + res + " WHERE idPiece = " + idPieceAss[i] + ";";
                        command3.ExecuteNonQuery();
                        connection3.Close();
                    }
                }
            }
            MySqlConnection connection5 = new MySqlConnection(connectionString);
            connection5.Open();

            MySqlCommand command5 = connection5.CreateCommand();
            command5.CommandText = "INSERT INTO appartientCommande (idCommande, idVelo, idPiece, quantiteAppartientComande) VALUES (" + idCommande + "," + idVelo + ",NULL," + (nb + nbpiece) + ");";
            command5.ExecuteNonQuery();
            connection5.Close();

        }
        static bool StockVelo(string connectionString, int idVelo, int nb)
        {
            bool stock = true;
            string[] idPieceAss = SelectCommande("select cadre,guidon,freins,selle,derailleurAvant,derailleurArriere,roueAvant,roueArriere,reflecteurs,pedalier,ordinateur,panier from assemblage where idassemblage = " + idVelo + ";", connectionString).Split(";");
            for (int i = 0; i < idPieceAss.Length && stock; i++)
            {
                if (idPieceAss[i] != "")
                {
                    if (nb > Convert.ToInt16(SelectCommande("SELECT quantitePiece FROM piece Where idPiece = " + idPieceAss[i] + ";", connectionString)))
                    {
                        stock = false;
                    }
                }
            }
            return stock;
        }
        static string CommandeClient(string commande, string connectionString,string table)
        {
            string res = "";
            if (commande != "" && commande != null && connectionString != null && connectionString != "")
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;

                MySqlDataReader reader = command.ExecuteReader();
                string[] colonne = FormatColonne(NomColumn(connectionString, table), table).Split("\n");

                while (reader.Read())                           // parcours ligne par ligne
                {
                    string currentRowAsString = "";
                    for (int i = 1; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                    {
                        string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                        if (valueAsString != null)
                        {
                            if (colonne[i].Substring(0, 2) != "Id" && colonne[i].Substring(0, 2) != "Si") currentRowAsString += colonne[i - 1] + valueAsString + " \n";
                        }

                    }
                    res += currentRowAsString + colonne[colonne.Length - 2] + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
                }
                connection.Close();
            }
            return res;
        }
        static string MesCommandes(string command, string connectionString) 
        {
            
            string res = "";
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand commandSql = connection.CreateCommand();
            commandSql.CommandText = command;

            MySqlDataReader reader = commandSql.ExecuteReader();
            string[,] matrice = new string[reader.FieldCount, 7];
            int nb_tour = 0;
            while(reader.Read())                           // parcours ligne par ligne
            {
                
                int colonne = 0;
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();// recuperation de la valeur de chaque cellule sous forme d'une string
                    
                        if (valueAsString != null || valueAsString != "") 
                        {
                            if (i == 0 || i == 1 || i == 2 || i == 3 || i == 12 || i == 13 || i == 14) 
                            {
                                matrice[nb_tour, colonne] = valueAsString;
                                colonne++;
                            }
                        }
                    
                    
                }
                matrice[nb_tour, 6] = reader.GetValue(reader.FieldCount - 1).ToString();
                nb_tour++;
            }
            connection.Close();

            List<string> AlreadyWritten = new List<string>();
            for (int i  = 0; i < matrice.GetLength(0); i++) 
            {
                if (matrice[i,0] != null && matrice[i,0] != "") 
                { 
                    if (!res.Contains("\nCommande n°" + matrice[i, 0] + " :\n")) 
                    {
                        for (int j = 0; j < matrice.GetLength(1); j++)
                        {
                            if (j == 0)
                            {
                                res += "\nCommande n°" + matrice[i, j] + " :\n";
                            }
                            else if (j == 1)
                            {
                                res += "\tDate de la Commande : " + matrice[i, j] + "\n";
                            }
                            else if (j == 2)
                            {
                                res += "\tDate de la Livraison : " + matrice[i, j] + "\n";
                            }
                            else if (j == 3)
                            {
                                res += "\tAdresse de Livraison : " + matrice[i, j] + "\n";
                            }
                            else if (j == 4)
                            {
                                if (matrice[i, j + 1] != null && matrice[i, j + 1] != "")
                                {
                                    res += "\t\t- " + matrice[i, j] + " " + matrice[i, j + 1];
                                    j += 2;
                                }
                                else if (matrice[i, j + 2] != null && matrice[i, j + 2] != "")
                                {
                                    res += "\t\t- " + matrice[i, j] + " " + matrice[i, j + 2];
                                    j += 2;
                                }
                            }
                        }   
                    }
                    else 
                    {
                        if (matrice[i, 5] != null && matrice[i, 5] != "")
                        {
                            res += "\t\t- " + matrice[i, 4] + " " + matrice[i, 5];
                        }
                        else if (matrice[i, 6] != null && matrice[i, 6] != "")
                        {
                            res += "\t\t- " + matrice[i, 4] + " " + matrice[i, 6];
                        }
                    }
                }
                res += "\n";
            }
            return res;
        }
        static string FormatColonne(string coloneCompose, string nomTab)
        {
            string res = "";
            string[] colonne = coloneCompose.Split(",");
            if (colonne[0].Substring(0, 2) == "id" || colonne[0].Substring(0, 2) == "si")
            {
                for (int i = 1; i < colonne.Length; i++)
                {
                    if (colonne[i].Contains(nomTab.First().ToString().ToUpper() + String.Join("", nomTab.Skip(1))))
                    {
                        colonne[i] = colonne[i].Substring(0, colonne[i].Length - nomTab.Length);
                        colonne[i] = colonne[i].First().ToString().ToUpper() + String.Join("", colonne[i].Skip(1)) + " : ";
                    }
                    res += colonne[i] + "\n";
                }
            }
            return res;
        }
        static void Rapport()
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;PASSWORD=root;";
            bool rapport = true;
            int flèche = 0;
            bool enter = false;
            Console.Clear();
            Console.WriteLine("\nRapport Statistique et Requete Exotique :\n\n");
            Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                <--\n");
            Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
            Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
            Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
            Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
            Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
            Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
            Console.WriteLine("Déconnexion                                                                                                 \n");
            while (rapport)
            {
                ConsoleKeyInfo touche = Console.ReadKey();
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow:
                        flèche -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        flèche += 1;
                        break;
                    case ConsoleKey.Enter:
                        enter = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                if (flèche > 7)
                {
                    flèche = 7;
                }
                else if (flèche < 0)
                {
                    flèche = 0;
                }
                if (flèche == 0)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                <--\n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 1)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                       <--\n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 2)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                <--\n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 3)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros <--\n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 4)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                  <--\n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 5)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)          <--\n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 6)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                   <--\n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (flèche == 7)
                {
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                              <--\n");
                }
                if (enter == true && flèche == 0)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT employe.nomEmploye AS vendeur, magasin.idMagasin AS magasin,
                                            CASE
                                                WHEN appartientCommande.idVelo IS NOT NULL THEN velo.nomVelo
                                                WHEN appartientCommande.idPiece IS NOT NULL THEN piece.nomPiece
                                            END AS item,
                                            SUM(appartientCommande.quantiteAppartientComande) AS quantite_vendue
                                        FROM employe 
                                        JOIN commande ON employe.idEmploye = commande.idEmploye
                                        JOIN magasin ON commande.idMagasin = magasin.idMagasin
                                        JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                        LEFT JOIN velo ON appartientCommande.idVelo = velo.idVelo
                                        LEFT JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                        GROUP BY employe.nomEmploye, magasin.idMagasin, item;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                <--\n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");

                }
                else if (enter == true && flèche==1)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT fidelio.descriptionFidelio, client.nomClient, client.prenomClient
                                        FROM souscription
                                        JOIN client ON souscription.idClient = client.idClient
                                        JOIN fidelio ON souscription.idFidelio = fidelio.idFidelio;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                       <--\n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==2)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT fidelio.descriptionFidelio, client.nomClient, client.prenomClient, DATE_ADD(souscription.DATESouscription, INTERVAL fidelio.duree YEAR) AS DATE_expiration
                                        FROM souscription
                                        JOIN client ON souscription.idClient = client.idClient
                                        JOIN fidelio ON souscription.idFidelio = fidelio.idFidelio;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                <--\n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==3)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT client.nomClient, client.prenomClient, 
                                            SUM(appartientCommande.quantiteAppartientComande) AS quantite_totale_pieces
                                        FROM client
                                        JOIN commande ON client.idClient = commande.idClient
                                        JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                        JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                        GROUP BY client.idClient
                                        HAVING quantite_totale_pieces = (
                                            SELECT max(total_pieces)
                                            FROM (
                                                SELECT client.nomClient, client.prenomClient, 
                                                SUM(appartientCommande.quantiteAppartientComande) AS total_pieces
                                                FROM client
                                                JOIN commande ON client.idClient = commande.idClient
                                                JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                                JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                                GROUP BY client.idClient
                                                ) AS max_pieces 
                                        );";
                    string command2 = @"SELECT client.nomClient, client.prenomClient, 
                                            SUM(appartientCommande.quantiteAppartientComande * piece.prixPiece) AS chiffre_affaires_euros
                                        FROM client
                                        JOIN commande ON client.idClient = commande.idClient
                                        JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                        JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                        GROUP BY client.idClient
                                        HAVING chiffre_affaires_euros = (
                                            SELECT max(total_euros)
                                            FROM (
                                                SELECT SUM(appartientCommande.quantiteAppartientComande * piece.prixPiece) AS total_euros
                                                FROM client
                                                JOIN commande ON client.idClient = commande.idClient
                                                JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                                JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                                GROUP BY client.idClient
                                            ) AS max_euros
                                        );";

                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    AfficheReponse(connectionString,command2);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros <--\n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==4)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT AVG(total_prix) AS moyenne
                                        FROM (
                                            SELECT SUM(
                                                CASE 
                                                    WHEN appartientCommande.idVelo IS NOT NULL THEN velo.prixVelo
                                                    WHEN appartientCommande.idPiece IS NOT NULL THEN piece.prixPiece
                                                    ELSE 0
                                                END
                                            ) AS total_prix
                                            FROM commande
                                            JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                            LEFT JOIN velo ON appartientCommande.idVelo = velo.idVelo
                                            LEFT JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                            GROUP BY commande.idCommande
                                        ) AS montants_commandes
                                        UNION
                                        SELECT AVG(nombre_elements) AS moyenne
                                        FROM (
                                            SELECT COUNT(*) AS nombre_elements
                                            FROM appartientCommande
                                            GROUP BY idCommande
                                        ) AS elements_par_commande;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                  <--\n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==5)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT employe.nomEmploye, employe.prenomEmploye,
                                            AVG(retourClient.noteRetour) AS satisfaction_client_moyenne,
                                            SUM(
                                                CASE 
                                                    WHEN appartientCommande.idVelo IS NOT NULL THEN velo.prixVelo * appartientCommande.quantiteAppartientComande
                                                    WHEN appartientCommande.idPiece IS NOT NULL THEN piece.prixPiece * appartientCommande.quantiteAppartientComande
                                                    ELSE 0
                                                END
                                            ) AS chiffre_affaires,
                                            AVG(retourClient.noteRetour) * 25 + SUM(
                                                CASE 
                                                    WHEN appartientCommande.idVelo IS NOT NULL THEN velo.prixVelo * appartientCommande.quantiteAppartientComande
                                                    WHEN appartientCommande.idPiece IS NOT NULL THEN piece.prixPiece * appartientCommande.quantiteAppartientComande
                                                    ELSE 0
                                                END
                                            ) * 0.05 AS bonus
                                        FROM employe
                                        LEFT JOIN commande ON employe.idEmploye = commande.idEmploye
                                        LEFT JOIN retourClient ON commande.idClient = retourClient.idClient
                                        LEFT JOIN appartientCommande ON commande.idCommande = appartientCommande.idCommande
                                        LEFT JOIN velo ON appartientCommande.idVelo = velo.idVelo
                                        LEFT JOIN piece ON appartientCommande.idPiece = piece.idPiece
                                        GROUP BY employe.idEmploye;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)          <--\n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                      \n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==6)
                {
                    Console.Clear();
                    enter = false;
                    string command =    @"SELECT p1.nomPiece AS type_piece,p1.idPiece AS id_piece_1,p1.prixPiece AS prix_piece_1,p2.idPiece AS id_piece_2,p2.prixPiece AS prix_piece_2
                                        FROM piece p1
                                        JOIN piece p2 ON p1.idPiece < p2.idPiece
                                        WHERE p1.nomPiece = p2.nomPiece
                                        ORDER BY p1.nomPiece, p2.nomPiece;";
                    AfficheReponse(connectionString,command);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nRapport Statistique et Requete Exotique : \n\n");
                    Console.WriteLine("Quantité vendue de chaque item par magasin et par vendeur                                                   \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion                                                          \n");
                    Console.WriteLine("Liste des membres pour chaque programme d'adhésion avec date d'expiration                                   \n");
                    Console.WriteLine("Les meilleurs clients en fonction des quantités vendues en nombre de pièces vendues et le cumul en euros    \n");
                    Console.WriteLine("Moyenne des montants des commandes et moyenne du nombre d'articles par commande (union)                     \n");
                    Console.WriteLine("Calcul du bonus des emplois en fonction du retour client et du chiffre d'affaires (synchronisé)             \n");
                    Console.WriteLine("Comparaison 2 à 2 entre des pièces d'une même fonction (auto-jointure)                                   <--\n");
                    Console.WriteLine("Déconnexion                                                                                                 \n");
                }
                else if (enter == true && flèche==7)
                {
                    break;
                }

            }
        }
        static void AfficheReponse(string connectionString,string command)
        {
            string res = "";
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand commandSql = connection.CreateCommand();
            commandSql.CommandText = command;

            MySqlDataReader reader = commandSql.ExecuteReader();
            
            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);
            
        }  
        static void Gestion(string connectionString, string table)
        {
            bool gest = true;
            int flèche = 0;
            bool enter = false;
            Console.WriteLine("\nGestion : " + table + "\n");
            Console.WriteLine("Afficher   <--");
            Console.WriteLine("Ajouter       ");
            Console.WriteLine("Modifier      ");
            Console.WriteLine("Supprimer     ");
            Console.WriteLine("Retour        ");
            while (gest)
            {
                ConsoleKeyInfo touche = Console.ReadKey();
                switch (touche.Key)
                {
                    case ConsoleKey.UpArrow:
                        flèche -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        flèche += 1;
                        break;
                    case ConsoleKey.Enter:
                        enter = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("\nGestion : " + table + "\n");
                if (flèche > 4)
                {
                    flèche = 4;
                }
                else if (flèche < 0)
                {
                    flèche = 0;
                }
                if (flèche == 0)
                {
                    Console.WriteLine("Afficher   <--");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (flèche == 1)
                {
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter    <--");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (flèche == 2)
                {
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier   <--");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (flèche == 3)
                {
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer  <--");
                    Console.WriteLine("Retour        ");
                }
                else if (flèche == 4)
                {
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour     <--");
                }
                if (enter == true && flèche == 0)
                {
                    Console.Clear();
                    enter = false;

                    try
                    {
                        Console.WriteLine(AfficheTable(connectionString, table));
                    }
                    catch
                    {
                        Console.WriteLine("\nErreur, impossible d'afficher la table");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.WriteLine("\nGestion : " + table + "\n");
                    Console.WriteLine("Afficher   <--");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (enter == true && flèche == 1)
                {
                    Console.Clear();
                    enter = false;

                    try
                    {
                        Insert(connectionString, table);
                        Console.CursorVisible = false;
                    }
                    catch
                    {
                        Console.CursorVisible = false;
                        Console.Clear();
                        Console.WriteLine("\nErreur, impossible d'ajouter l'élément, vérifier que la clé primaire n'existe pas déjà");
                        timer(2);
                    }

                    Console.Clear();
                    Console.WriteLine("\nGestion : " + table + "\n");
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter    <--");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (enter == true && flèche == 2)
                {
                    Console.Clear();
                    enter = false;

                    try
                    {
                        Update(connectionString, table);
                        Console.CursorVisible = false;
                    }
                    catch
                    {
                        Console.CursorVisible = false;
                        Console.Clear();
                        Console.WriteLine("\nErreur, la modification de l'élément est impossible");
                        timer(2);
                    }

                    Console.Clear();
                    Console.WriteLine("\nGestion : " + table + "\n");
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier   <--");
                    Console.WriteLine("Supprimer     ");
                    Console.WriteLine("Retour        ");
                }
                else if (enter == true && flèche == 3)
                {
                    Console.Clear();
                    enter = false;

                    try
                    {
                        Delete(connectionString, table);
                        Console.CursorVisible = false;
                    }
                    catch
                    {
                        Console.CursorVisible = false;
                        Console.Clear();
                        Console.WriteLine("\nErreur, la suppression de l'élément est impossible");
                        timer(2);
                    }

                    Console.WriteLine("\nGestion : " + table + "\n");
                    Console.WriteLine("Afficher      ");
                    Console.WriteLine("Ajouter       ");
                    Console.WriteLine("Modifier      ");
                    Console.WriteLine("Supprimer  <--");
                    Console.WriteLine("Retour        ");
                }
                else if (enter == true && flèche == 4)
                {
                    gest = false;
                }
            }
        }
        static void Insert(string connectionString, string nom)
        {
            bool fin = true;
            string colonneName = NomColumn(connectionString, nom);
            string[] colonneType = TypeColumn(connectionString, nom).Split(',');
            string data = "";
            string exemple = "SELECT * FROM " + nom + " LIMIT 1;";
            Console.CursorVisible = true;
            bool date = false;

            for (int i = 0; i < colonneType.Length; i++)
            {
                if (colonneType[i] == "date")
                {
                    date = true;
                }
            }

            while (true)
            {
                int pos = 8;
                Console.Clear();
                Console.WriteLine("\nAjouter : " + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + "\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Insérer : ");
                Console.WriteLine("\n\n(mettre des ; pour séparer)");
                if (date) { Console.WriteLine("(format pour la date : année-mois-jour)"); pos++; }
                Console.Write("\nExemple : " + SelectCommande(exemple, connectionString));
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(10, Console.CursorTop - pos);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            if (fin)
            {
                string[] dataSplit = data.Split(';');
                data = "";
                for (int i = 0; i < colonneType.Length; i++)
                {
                    if (colonneType[i] != "int")
                    {
                        data += "'" + dataSplit[i] + "',";
                    }
                    else
                    {
                        data += dataSplit[i] + ",";
                    }
                }
                data = data.Remove(data.Length - 1);

                string commande = "INSERT INTO " + nom + "(" + colonneName + ") VALUES (" + data + ");";
                commande += ";";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;
                command.ExecuteNonQuery();
                connection.Close();
                if (nom == "client")
                {
                    FideloAdd(connectionString, dataSplit[0]);
                }
            }
        }
        static void Delete(string connectionString, string nom)
        {
            bool fin = true;
            string data1 = "";
            string data2 = "";
            string colonne1 = "";
            string colonne2 = "";
            int index1 = 0;
            int index2 = 0;
            string colonneName = NomColumn(connectionString, nom);
            string[] colonneType = TypeColumn(connectionString, nom).Split(",");
            Console.CursorVisible = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSupprimer : " + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + "\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Dans quel colonne voulez-vous supprimer : ");
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\nDans quel deuxième colonne voulez-vous supprimer : ");
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(42, Console.CursorTop - 11);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    colonne1 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\nSupprimer : " + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + "\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Dans quel colonne voulez-vous supprimer : " + colonne1);
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\nDans quel deuxième colonne voulez-vous supprimer : ");
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(14, Console.CursorTop - 9);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data1 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\nSupprimer : " + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + "\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Dans quel colonne voulez-vous supprimer : " + colonne1);
                Console.WriteLine("\nQuel donnée : " + data1);
                Console.WriteLine("\nDans quel deuxième colonne voulez-vous supprimer : ");
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(51, Console.CursorTop - 7);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    colonne2 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\nSupprimer : " + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + "\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Dans quel colonne voulez-vous supprimer : " + colonne1);
                Console.WriteLine("\nQuel donnée : " + data1);
                Console.WriteLine("\nDans quel deuxième colonne voulez-vous supprimer : " + colonne2);
                Console.WriteLine("\nQuel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(14, Console.CursorTop - 5);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data2 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            if (fin)
            {
                string[] colonneNametab = colonneName.Split(',');
                for (int i = 0; i < colonneNametab.Length; i++)
                {
                    if (colonne1 == colonneNametab[i])
                    {
                        index1 = i;
                    }
                    if (colonne2 == colonneNametab[i])
                    {
                        index2 = i;
                    }
                }
                if (colonneType[index1] != "int")
                {
                    data1 = "'" + data1 + "'";
                }
                if (colonneType[index2] != "int")
                {
                    data2 = "'" + data2 + "'";
                }

                string commande = "DELETE FROM " + nom + " WHERE " + colonne1 + " = " + data1;
                if (colonne2 != "null" && data2 != "null")
                {
                    commande += " AND " + colonne2 + " = " + data2;
                }
                commande += ";";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        static void Update(string connectionString, string nom)
        {
            bool fin = true;
            string data1 = "";
            string data2 = "";
            string data3 = "";
            string colonne1 = "";
            string colonne2 = "";
            string colonne3 = "";
            string colonneName = NomColumn(connectionString,nom);
            Console.CursorVisible = true;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : ");
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : ");
                Console.WriteLine("\nQue voulez vous modifier (colonne) :");
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) :");
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : ");
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(37, 5);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    colonne1 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : " + colonne1);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : ");
                Console.WriteLine("\nQue voulez vous modifier (colonne) : ");
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : ");
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : ");
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(52, 7);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data1 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : " + colonne1);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data1);
                Console.WriteLine("\nQue voulez vous modifier (colonne) : ");
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : ");
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : ");
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(37, 9);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    if (var == "") colonne2 = null;
                    else colonne2 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : " + colonne1);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data1);
                Console.WriteLine("\nQue voulez vous modifier (colonne) : " + colonne2);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : ");
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : ");
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(52, 11);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    if (var == "") data2 = null;
                    else data2 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : " + colonne1);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data1);
                Console.WriteLine("\nQue voulez vous modifier (colonne) : " + colonne2);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data2);
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : ");
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(41, 13);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    colonne3 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            while (true && fin)
            {
                Console.Clear();
                Console.WriteLine("\n" + nom.First().ToString().ToUpper() + String.Join("", nom.Skip(1)) + " : Update\n");
                Console.WriteLine("Nom des colonnes : " + colonneName + "\n");
                Console.WriteLine("Que voulez vous modifier (colonne) : " + colonne1);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data1);
                Console.WriteLine("\nQue voulez vous modifier (colonne) : " + colonne2);
                Console.WriteLine("\nQue voulez vous modifier (valeur de notre donnée) : " + data2);
                Console.WriteLine("\nDans quel colonne voulez-vous modifier : " + colonne3);
                Console.WriteLine("\nPour quel donnée : ");
                Console.WriteLine("\n(null pour ne rien mettre)\n");
                Console.WriteLine("(exit pour sortir)");
                Console.SetCursorPosition(19, 15);
                string var = Console.ReadLine();
                if (var == "exit")
                {
                    fin = false;
                    break;
                }
                try
                {
                    data3 = var;
                    break;
                }
                catch
                {
                    Console.Clear();
                }
            }
            if (fin)
            {
                string commande = "UPDATE " + nom + " SET " + colonne1 + " = " + data1;
                if (colonne2 != "null" && data2 != "null" && colonne3 != "null" && data3 != "null")
                {
                    commande += " AND " + colonne2 + " = " + data2 + " WHERE " + colonne3 + " = " + data3;
                }
                else if (colonne3 != "null" && data3 != "null")
                {
                    commande += " WHERE " + colonne3 + " = " + data3;
                }
                else
                    commande += ";";
                Console.WriteLine(commande);
                
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;
                command.ExecuteNonQuery();
                connection.Close();
                
            }

        }
        static void Stock(string connectionString)
        {
            string command1 = @"SELECT nomPiece, quantitePiece
                                FROM piece;";

            string command2 = @"SELECT nomVelo, quantiteVelo
                                FROM velo;";

            string command3 = @"SELECT fournisseur.nomFournisseur, 
                                       SUM(fournisseurCommande.quantitePiece) AS stock_pieces
                                FROM fournisseur
                                LEFT JOIN fournisseurCommande ON fournisseur.idFournisseur = fournisseurCommande.idFournisseur
                                GROUP BY fournisseur.idFournisseur, fournisseur.nomFournisseur;";

            string command4 = @"SELECT velo.grandeurVelo, 
                                    SUM(velo.quantiteVelo) AS stock_velos
                                FROM velo
                                GROUP BY velo.grandeurVelo;";

            string command5 = @"SELECT velo.ligneDeProduit, 
                                    SUM(velo.quantiteVelo) AS stock_velos
                                FROM velo
                                GROUP BY velo.ligneDeProduit;";
            
            string res = "";
            Console.WriteLine("Stock des pièces :\n");
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand commandSql = connection.CreateCommand();
            commandSql.CommandText = command1;

            MySqlDataReader reader = commandSql.ExecuteReader();

            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);

            res = "";
            Console.WriteLine("Stock des vélos :\n");
            connection = new MySqlConnection(connectionString);
            connection.Open();

            commandSql = connection.CreateCommand();
            commandSql.CommandText = command2;

            reader = commandSql.ExecuteReader();

            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);

            res = "";
            Console.WriteLine("Stock des pièces par fournisseur :\n");
            connection = new MySqlConnection(connectionString);
            connection.Open();

            commandSql = connection.CreateCommand();
            commandSql.CommandText = command3;

            reader = commandSql.ExecuteReader();

            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);

            res = "";
            Console.WriteLine("Stock des vélos par grandeur :\n");
            connection = new MySqlConnection(connectionString);
            connection.Open();

            commandSql = connection.CreateCommand();
            commandSql.CommandText = command4;

            reader = commandSql.ExecuteReader();

            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);

            res = "";
            Console.WriteLine("Stock des vélos par ligne de produit :\n");
            connection = new MySqlConnection(connectionString);
            connection.Open();

            commandSql = connection.CreateCommand();
            commandSql.CommandText = command5;

            reader = commandSql.ExecuteReader();

            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
            }
            connection.Close();
            Console.WriteLine(res);

        }
        static string NomColumn(string connectionString, string table)
        {
            string res = "";
            string cmd = "SHOW COLUMNS FROM " + table + " ;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = cmd;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())                           // parcours ligne par ligne
            {
                res += reader.GetValue(0).ToString() + ",";
            }
            res = res.Remove(res.Length - 1);
            connection.Close();
            return res;
        }
        static string TypeColumn(string connectionString, string table)
        {
            string res = "";
            string cmd = "SHOW COLUMNS FROM " + table + " ;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = cmd;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())                           // parcours ligne par ligne
            {
                res += reader.GetValue(1).ToString() + ",";
            }
            res = res.Remove(res.Length - 1);
            connection.Close();
            return res;
        }
        static string AfficheTable(string connectionString, string table)
        {
            string res = "\n" + table.First().ToString().ToUpper() + String.Join("", table.Skip(1)) + " :\n\n";
            string cmd = "SELECT * FROM " + table;
            int nb = 1;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = cmd;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                    currentRowAsString += valueAsString + " | ";
                }
                res += nb + ". " + currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n";
                nb++;
            }
            connection.Close();
            return res;
        }
        static string SelectCommande(string commande, string connectionString)
        {
            string res = "";
            if (commande != "" && commande != null && connectionString != null && connectionString != "")
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = commande;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())                           // parcours ligne par ligne
                {
                    string currentRowAsString = "";
                    for (int i = 0; i < reader.FieldCount - 1; i++)    // parcours cellule par cellule
                    {
                        string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string
                        currentRowAsString += valueAsString + ";";
                    }
                    res += currentRowAsString + reader.GetValue(reader.FieldCount - 1).ToString() + "\n\n";
                }
                connection.Close();
            }
            return res;
        }
        /// <summary>
        /// Fait un timer en seconde pour attendre
        /// </summary>
        /// <param name="seconde"> c'est le nombre de milliseconde qui vont être attendu</param>
        public static void timer(int seconde)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconde); // initialise une variable de temps en sec
            DateTime actuel = DateTime.Now; // initialise 2 variable de temps actuel dont une avec le temps à attendre en plus
            DateTime futur = DateTime.Now + time;
            while (actuel <= futur) // actualise le temps jusqu'a se que le temps actuel dépasse de temps d'attente voulu
            {
                actuel = DateTime.Now;
            }
        }
        /// <summary>
        /// Supprime tout se qu'il y a à droite du curseur dans l'affichage console
        /// </summary>
        public static void ClearCurrentLine()
        {
            int pos = Console.CursorLeft; // enregistre la position du curseur en x
            Console.Write(new string(' ', Console.WindowWidth - pos)); // remplace par des espace tout se qu'il y a entre le curseur et la fin de fenêtre
            Console.SetCursorPosition(pos, Console.CursorTop); // repositionne le curseur à sa position initiale
        }
    }
}
