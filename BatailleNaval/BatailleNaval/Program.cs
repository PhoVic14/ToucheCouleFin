using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bataille_Navale
{
    class Program
    {
        static void MatriceJoueur(int[,] toucher)
        {
            int[,] tab = new int[10, 10];
            AfficherMatriceJoueur(tab);
            Console.WriteLine(tab);
        }

        static void AfficherMatriceJoueur(int[,] tab)
        {
            int NbrLigne = tab.GetLength(0);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(tab[i, j]);
                }
                Console.WriteLine();
            }
            AfficherMatriceJoueur(tab);
        }




        static void ModifierLaMatriceJoueur(ref int[,] tab, int nombre)
        {
            tab[1, 1] = nombre;
        }


        static void MatriceEnnemi(int[,] toucher)
        {
            int[,] tab = new int[10, 10];
            AfficherMatriceEnnemi(tab);
            Console.WriteLine(tab);
        }

        static void AfficherMatriceEnnemi(int[,] tab)
        {
            int NbrLigne = tab.GetLength(0);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(tab[i, j]);
                }
                Console.WriteLine();
            }
            AfficherMatriceEnnemi(tab);
        }


        static void ModifierLaMatriceEnnemi(ref int[,] tab, int nombre)
        {
            tab[1, 1] = nombre;
        }

         static void AfficherGrilleJoueur(string[,] tab)
        {
            string[] lettre = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; 

            Console.WriteLine(" --------------- Matrice Joueur---------------");

            Console.WriteLine("     1   2   3   4   5   6   7   8   9   10");


            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("   +---+---+---+---+---+---+---+---+---+---+");
                Console.Write(" {0} |", lettre[i]); 

                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    if (j == (tab.GetLength(0) - 1)) 
                    {
                        switch (tab[i, j])
                        {

                            case ("2"): 
                                Console.WriteLine(" 2 |");
                                break;

                            case ("3s"): 
                                Console.WriteLine(" 3s|");
                                break;

                            case ("3c"): 
                                Console.WriteLine(" 3c|");
                                break;

                            case ("4"): 
                                Console.WriteLine(" 4 |");
                                break;

                            case ("5"):
                                Console.WriteLine(" 5 |");
                                break;

                            case ("t"): 
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" *");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine(" |");

                                break;

                            case ("plouf"): 
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" X ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("|");
                                break;

                            default:
                                Console.WriteLine("   |");
                                break;

                        }

                    }

                    else
                    {
                        switch (tab[i, j])
                        {

                            case ("2"): 
                                Console.Write(" 2 |");
                                break;

                            case ("3s"): 
                                Console.Write(" 3s|");
                                break;

                            case ("3c"):
                                Console.Write(" 3c|");
                                break;

                            case ("4"): 
                                Console.Write(" 4 |");
                                break;

                            case ("5"): 
                                Console.Write(" 5 |");
                                break;

                            case ("t"): 
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" * ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("|");
                                break;

                            case ("plouf"): 
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" X ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("|");
                                break;

                            default:
                                Console.Write("   |");
                                break;

                        }

                    }
                }

            }
            Console.WriteLine("   +---+---+---+---+---+---+---+---+---+---+");

        }


         static void AfficherGrilleAdversaire(string[,] tab)
        {
            string[] lettre = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; 

            Console.WriteLine(" ------------ MATRICE ADVERSAIRE ------------- ");

            Console.WriteLine("     1   2   3   4   5   6   7   8   9   10");

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("   +---+---+---+---+---+---+---+---+---+---+");
                Console.Write(" {0} |", lettre[i]);

                for (int j = 0; j < tab.GetLength(0); j++)
                {
                    if (j == (tab.GetLength(0) - 1)) 
                    {
                        switch (tab[i, j])
                        {
                            case ("t"):
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" O "); 
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("|");
                                break;

                            case ("plouf"):
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" X "); 
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("|");
                                break;

                            default:
                                Console.WriteLine("   |");
                                break;

                        }

                    }

                    else
                    {
                        switch (tab[i, j])
                        {
                            case ("t"):
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" O ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("|");
                                break;

                            case ("plouf"):
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" X "); 
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("|");
                                break;

                            default:
                                Console.Write("   |"); 
                                break;

                        }
                    }
                }

            }
            Console.WriteLine("   +---+---+---+---+---+---+---+---+---+---+");

        }

         static bool PlacerBateau(Random random, string[,] tab, string[] bateau)
        {

            int choixLigne;
            int choixColonne;


            do
            {
                choixLigne = random.Next(0, tab.GetLength(0));
                choixColonne = random.Next(0, tab.GetLength(0));
            }

            while (tab[choixLigne, choixColonne] != " ");

            tab[choixLigne, choixColonne] = bateau[0];



            int direction = random.Next(0, 4); 


            if (direction == 0)
            {
                try 
                {
                    for (int k = 1; k < bateau.Length; k++) 
                    {
                        if (tab[choixLigne, (choixColonne - k)] == " ") 
                        {
                            tab[choixLigne, (choixColonne - k)] = bateau[k]; 

                            if (k == (bateau.Length - 1))
                            {
                                return true;
                            }

                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (IndexOutOfRangeException) 
                {
                    return false;
                }
            }

            else if (direction == 1)
            {
                try
                {
                    for (int k = 1; k < bateau.Length; k++)
                    {
                        if (tab[(choixLigne + k), choixColonne] == " ")
                        {
                            tab[(choixLigne + k), choixColonne] = bateau[k];

                            if (k == (bateau.Length - 1))
                            {
                                return true;
                            }
                        }

                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return false;
                }
            }


            else if (direction == 2)
            {
                try
                {
                    for (int k = 1; k < bateau.Length; k++)
                    {
                        if (tab[choixLigne, (choixColonne + k)] == " ")
                        {
                            tab[choixLigne, (choixColonne + k)] = bateau[k];

                            if (k == (bateau.Length - 1))
                            {
                                return true;
                            }
                        }

                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return false;
                }
            }

            else if (direction == 3)
            {
                try
                {
                    for (int k = 1; k < bateau.Length; k++)
                    {
                        if (tab[(choixLigne - k), choixColonne] == " ")
                        {
                            tab[(choixLigne - k), choixColonne] = bateau[k];

                            if (k == (bateau.Length - 1))
                            {
                                return true;
                            }
                        }

                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return false;
                }
            }

            return false;


        }

         static void PlacerBateauJoueur(Random random, string[,] grilleJoueur, string[] bateau5, string[] bateau4, string[] bateau3Croiseur, string[] bateau3Sousmarin, string[] bateau2)
        {

            bool bat5 = false;
            bool bat4 = false;
            bool bat3Croiseur = false;
            bool bat3Sousmarin = false;
            bool bat2 = false;


            while ((bat5 == false) || (bat4 == false) || (bat3Croiseur == false) || (bat3Sousmarin == false) || (bat2 == false))
            {


                for (int i = 0; i < grilleJoueur.GetLength(0); i++)
                {
                    for (int j = 0; j < grilleJoueur.GetLength(0); j++)
                    {
                        grilleJoueur[i, j] = " ";

                    }
                }

                bat5 = PlacerBateau(random, grilleJoueur, bateau5);

                bat4 = PlacerBateau(random, grilleJoueur, bateau4);

                bat3Croiseur = PlacerBateau(random, grilleJoueur, bateau3Croiseur);

                bat3Sousmarin = PlacerBateau(random, grilleJoueur, bateau3Sousmarin);

                bat2 = PlacerBateau(random, grilleJoueur, bateau2);

            }

            AfficherGrilleJoueur(grilleJoueur);
        }

         static void PlacerBateauAdversaire(Random random, string[,] grilleAdversaire, string[] bateau5, string[] bateau4, string[] bateau3Croiseur, string[] bateau3Sousmarin, string[] bateau2)
        {

            bool bat5 = false;
            bool bat4 = false;
            bool bat3Croiseur = false;
            bool bat3Sousmarin = false;
            bool bat2 = false;

            while ((bat5 == false) || (bat4 == false) || (bat3Croiseur == false) || (bat3Sousmarin == false) || (bat2 == false))
            {

                for (int i = 0; i < grilleAdversaire.GetLength(0); i++)
                {
                    for (int j = 0; j < grilleAdversaire.GetLength(0); j++)
                    {
                        grilleAdversaire[i, j] = " ";
                    }
                }

                bat5 = PlacerBateau(random, grilleAdversaire, bateau5);

                bat4 = PlacerBateau(random, grilleAdversaire, bateau4);

                bat3Croiseur = PlacerBateau(random, grilleAdversaire, bateau3Croiseur);

                bat3Sousmarin = PlacerBateau(random, grilleAdversaire, bateau3Sousmarin);

                bat2 = PlacerBateau(random, grilleAdversaire, bateau2);

            }
        }


         static int LigneCible(string casevisee)
        {

            int i; 

            switch (casevisee[0])
            {

                case ('A'):
                case ('a'):
                    i = 0;
                    return i;

                case ('B'):
                case ('b'):
                    i = 1;
                    return i;

                case ('C'):
                case ('c'):
                    i = 2;
                    return i;

                case ('D'):
                case ('d'):
                    i = 3;
                    return i;

                case ('E'):
                case ('e'):
                    i = 4;
                    return i;

                case ('F'):
                case ('f'):
                    i = 5;
                    return i;

                case ('G'):
                case ('g'):
                    i = 6;
                    return i;

                case ('H'):
                case ('h'):
                    i = 7;
                    return i;

                case ('I'):
                case ('i'):
                    i = 8;
                    return i;

                case ('J'):
                case ('j'):
                    i = 9;
                    return i;

                case ('S'):
                case ('s'):
                    return -2;

                default:
                    return -1;
            }
        }

         static int ColonneCible(string casevisee)
        {

            int j; 

            string numeroCase = casevisee.Substring(1); 

            switch (numeroCase)
            {
                case ("1"):
                    j = 0;
                    return j;

                case ("2"):
                    j = 1;
                    return j;

                case ("3"):
                    j = 2;
                    return j;

                case ("4"):
                    j = 3;
                    return j;

                case ("5"):
                    j = 4;
                    return j;

                case ("6"):
                    j = 5;
                    return j;

                case ("7"):
                    j = 6;
                    return j;

                case ("8"):
                    j = 7;
                    return j;

                case ("9"):
                    j = 8;
                    return j;

                case ("10"):
                    j = 9;
                    return j;


                default:
                    return -1; 
            }
        }


         static int ResultatMissileJoueur(string[,] tab, int i, int j, int[] compteurJoueur, ref int compteurNbBat)
        {
            

            switch (tab[i, j])
            {
                case ("2"):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bravo capitaine !");


                    tab[i, j] = "t";

                    compteurJoueur[5]--;

                    if (compteurJoueur[5] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Contre-torpilleur coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurNbBat - 1;
                    }
                    return compteurNbBat;

                case ("3c"):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bravo capitaine !");


                    tab[i, j] = "t";
                    compteurJoueur[3]--;
                    if (compteurJoueur[3] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Croiseur coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurNbBat - 1;
                    }
                    return compteurNbBat;

                case ("3s"):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bravo capitaine !");


                    tab[i, j] = "t";
                    compteurJoueur[4]--; 
                    if (compteurJoueur[4] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Sous-marin coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurNbBat - 1;
                    }
                    return compteurNbBat;

                case ("4"):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bravo capitaine !");


                    tab[i, j] = "t";

                    compteurJoueur[2]--; 

                    if (compteurJoueur[2] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cuirassé coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurNbBat - 1;
                    }
                    return compteurNbBat;

                case ("5"):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bravo capitaine !");


                    tab[i, j] = "t";
                    compteurJoueur[1]--; 
                    if (compteurJoueur[1] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Porte-avion coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurNbBat - 1;
                    }
                    return compteurNbBat;

                case ("t"): 

                    Console.WriteLine("Capitaine, vous avez perdu un coup, cette partie du bateau était déjà touchée !");

                    return compteurNbBat;

                case ("plouf"):

                    Console.WriteLine("Capitaine, vous avez perdu un coup, on avait déjà tiré ici !");

                    return compteurNbBat;

                default: 

                    Console.WriteLine("Dommage capitaine, c'est à côté !");

                    tab[i, j] = "plouf";
                    return compteurNbBat;
            }

        }

        static int ResultatMissileAdversaire(string[,] tab, int i, int j, int[] compteurAdversaire)
        {

            switch (tab[i, j])
            {

                case ("2"): 

                    Console.Write("Capitaine ! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Notre contre-torpilleur a été touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Soyez sans pitié !");


                    tab[i, j] = "t";


                    compteurAdversaire[5]--; 

                    if (compteurAdversaire[5] == 0) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Contre-torpilleur coulé capitaine !");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurAdversaire[0] - 1;
                    }
                    return compteurAdversaire[0]; 

                case ("3s"): 
                    tab[i, j] = "t";


                    Console.Write("Capitaine ! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Notre sous-marin a été touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Soyez sans pitié !");



                    compteurAdversaire[4]--;
                    if (compteurAdversaire[4] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Sous-marin coulé capitaine ! ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurAdversaire[0] - 1;
                    }
                    return compteurAdversaire[0];

                case ("3c"): 
                    tab[i, j] = "t";

                    Console.Write("Capitaine ! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Notre croiseur a été touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Soyez sans pitié !");



                    compteurAdversaire[3]--;
                    if (compteurAdversaire[3] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Croiseur coulé capitaine ! ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurAdversaire[0] - 1;
                    }
                    return compteurAdversaire[0];

                case ("4"): 
                    tab[i, j] = "t";

                    Console.Write("Capitaine ! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Notre cuirassé a été touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Soyez sans pitié !");


                    compteurAdversaire[2]--;
                    if (compteurAdversaire[2] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cuirassé coulé capitaine ! ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurAdversaire[0] - 1;
                    }
                    return compteurAdversaire[0];

                case ("5"):
                    tab[i, j] = "t";


                    Console.Write("Capitaine ! ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Notre porte-avion a été touché ! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Soyez sans pitié !");



                    compteurAdversaire[1]--;
                    if (compteurAdversaire[1] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Porte-avion coulé capitaine ! ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return compteurAdversaire[0] - 1;
                    }
                    return compteurAdversaire[0];

                default: 
                    tab[i, j] = "plouf";

                    Console.WriteLine("Capitaine ! L'adversaire a tiré dans l'eau ! Il faut en profiter !");

                    return compteurAdversaire[0];
            }

        }


       

        static int TourJoueur(int[] compteurJoueur, int[] compteurAdversaire, string[,] grilleJoueur, string[,] grilleAdversaire)
        {
            Console.WriteLine("------------ C'EST AU TOUR DU JOUEUR ---------------");

            int[] ligne = new int[compteurAdversaire[0]]; 
            int[] colonne = new int[compteurAdversaire[0]]; 


            Console.WriteLine("Capitaine, vous avez {0} coup(s), ne les ratez pas !Analysez bien la situation, voici la grille adverse ! ", compteurJoueur[0]);
            AfficherGrilleAdversaire(grilleAdversaire);

            Mode(compteurJoueur, compteurAdversaire, ligne, colonne, grilleJoueur, grilleAdversaire);



            int temp = compteurJoueur[0]; 

            for (int k = 0; k < compteurJoueur[0]; k++)
            {

                temp = ResultatMissileJoueur(grilleAdversaire, ligne[k], colonne[k], compteurJoueur, ref temp);
                

            }

            compteurJoueur[0] = temp; 

            return compteurJoueur[0];

        }

         static void Mode(int[] compteurJoueur, int[] compteurAdversaire, int[] ligne, int[] colonne, string[,] grilleJoueur, string[,] grilleAdversaire)
        {

            for (int m = 0; m < compteurJoueur[0]; m++)
            {
                string caseVisee; 
                int continuer = 1;

                Console.WriteLine("------------------------- TIR {0} -------------------- ", (m + 1));


                do
                {
                    Console.WriteLine("Capitaine, où voulez-vous tirer ?!"); 
                    caseVisee = Console.ReadLine();

                    if (LigneCible(caseVisee) == -2) 
                    {
                        Console.WriteLine("Voulez-vous poursuivre la partie ? 0 pour non, 1 pour oui. ");
                        continuer = Convert.ToInt32(Console.ReadLine());
                        break;

                    }

                    else if ((LigneCible(caseVisee) == -1) || (ColonneCible(caseVisee) == -1))
                    {
                        Console.WriteLine("Erreur de saisie, capitaine concentrez-vous !");
                    }

                }
                while ((LigneCible(caseVisee) == -1) || (ColonneCible(caseVisee) == -1));
                if (continuer == 0) 
                {
                    Environment.Exit(0); 

                }
                else
                {
                    ligne[m] = LigneCible(caseVisee);

                    colonne[m] = ColonneCible(caseVisee);

                }


            }
        }


         static void TourAdversaire(Random random, int[] compteurAdversaire, string[,] grilleJoueur)
        {
            Console.WriteLine("------------ C'EST AU TOUR DE l'IA ---------------");

            for (int m = 0; m < compteurAdversaire[0]; m++)
            {
                bool verif = false;

                do
                {
                    int ligneCibleInitiale = random.Next(0, 10);
                    int colonneCibleInitiale = random.Next(0, 10);

                    if (grilleJoueur[ligneCibleInitiale, colonneCibleInitiale] == "t") 
                    {
                        verif = false; 
                    }

                    else if (grilleJoueur[ligneCibleInitiale, colonneCibleInitiale] == "plouf") 
                    {
                        verif = false; 
                    }

                    else  
                    {

                        compteurAdversaire[0] = ResultatMissileAdversaire(grilleJoueur, ligneCibleInitiale, colonneCibleInitiale, compteurAdversaire);

                        verif = true; 

                    }
                }

                while (verif == false);

            }
            AfficherGrilleJoueur(grilleJoueur);



            Console.WriteLine("Capitaine, avez-vous eu le temps d'analyser l'état de votre flotte ? Si oui, appuyez sur entrée...");
            Console.ReadLine();
            Console.Clear(); 
        }



         static void Bataille(Random random, int[] compteurJoueur, int[] compteurAdversaire, string[,] grilleJoueur, string[,] grilleAdversaire)
        {

            while ((compteurAdversaire[0] != 0) && (compteurJoueur[0] != 0))
            {

                TourJoueur(compteurJoueur, compteurAdversaire, grilleJoueur, grilleAdversaire);

                if (compteurJoueur[0] == 0)
                {
                    break;
                }

                AfficherGrilleAdversaire(grilleAdversaire);

                Console.WriteLine("Capitaine, avez-vous eu le temps d'analyser vos cibles ? Si oui, appuyez sur entrée...");
                Console.ReadLine();
                Console.Clear();

                TourAdversaire(random, compteurAdversaire, grilleJoueur);

            }
        }



         static void GagnerPartie(int[] compteurJoueur, string[,] grilleAdversaire, int pays)
        {

            if (pays == 1)
            {
                if (compteurJoueur[0] == 0) 
                {
                    Console.WriteLine("CONGRATULATIONS Capitaine ! Vous avez gagné ! Vous êtes le meilleur ! ");

                }
                {
                    Console.WriteLine("Capitaine, toute la flotte a été détruite... Ils sont redoutables ! Ne vous laissez pas faire ! Retentez votre chance !");
                    AfficherGrilleJoueur(grilleAdversaire);

                }
            }
            else
            {
                if (compteurJoueur[0] == 0) 
                {
                    Console.WriteLine("Capitaine ! Vous avez gagné ! Vous êtes le meilleur ! ");

                }
                else 
                {
                    Console.WriteLine("Capitaine, toute la flotte a été détruite... Ils sont redoutables ! Ne vous laissez pas faire ! Retentez votre chance !");
                    AfficherGrilleJoueur(grilleAdversaire);

                }
            }





        }


         static void JouerPartie(Random random)
        {
            Console.ForegroundColor = ConsoleColor.Gray;



            string[] porteAvion = { "5", "5", "5", "5", "5" };
            string[] bateau4 = { "4", "4", "4", "4" };
            string[] bateau3Croiseur = { "3c", "3c", "3c" };
            string[] bateau3Sousmarin = { "3s", "3s", "3s" };
            string[] bateau2 = { "2", "2" };


            string[,] grilleJoueur = new string[10, 10];
            string[,] grilleAdversaire = new string[10, 10];


            int[] compteurAdversaire = new int[6]; 

            compteurAdversaire[0] = 5; 
            compteurAdversaire[1] = 5; 
            compteurAdversaire[2] = 4; 
            compteurAdversaire[3] = 3; 
            compteurAdversaire[4] = 3; 
            compteurAdversaire[5] = 2; 



            int[] compteurJoueur = new int[6];


            compteurJoueur[0] = 5; 
            compteurJoueur[1] = 5;
            compteurJoueur[2] = 4; 
            compteurJoueur[3] = 3; 
            compteurJoueur[4] = 3; 
            compteurJoueur[5] = 2;



            Console.WriteLine("Entrez 0 quand vous etes pret");
            int chargement = Convert.ToInt32(Console.ReadLine());

            int pays = 0; 

            if (chargement == 0) 
            {
                Console.Clear(); 

                

                Console.WriteLine("===========================================================================");
                Console.WriteLine("                         TOUCHER COULER                           ");
                Console.WriteLine("===========================================================================");


                  

                int satisfait = 0;

                while (satisfait == 0)
                {

                    
                    PlacerBateauJoueur(random, grilleJoueur, porteAvion, bateau4, bateau3Croiseur, bateau3Sousmarin, bateau2);

                    
                    Console.WriteLine("Etes-vous satisfait de cette configuration ? 0 si non, 1 si oui. ");
                    satisfait = Convert.ToInt32(Console.ReadLine());

                    Console.Clear(); 

                } 

                PlacerBateauAdversaire(random, grilleAdversaire, porteAvion, bateau4, bateau3Croiseur, bateau3Sousmarin, bateau2);

            }

            
            Bataille(random, compteurJoueur, compteurAdversaire, grilleJoueur, grilleAdversaire);




            GagnerPartie(compteurJoueur, grilleAdversaire, pays);
        }

        static void Main(string[] args)
        {

            Random random = new Random(); 

            string reponse;

            do
            {
                JouerPartie(random);

                Console.WriteLine("Voulez-vous rejouez ? 0 pour non, 1 pour oui");
                reponse = Console.ReadLine();

                if (reponse == "0") 
                {
                    Environment.Exit(0); 
                }
                else if (reponse == "1")
                {
                    Console.Clear(); 
                    JouerPartie(random);    

                }
            } while (reponse != "0" || reponse != "1");


            Console.ReadKey();
        }
    }
}