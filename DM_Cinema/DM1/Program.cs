// See https://aka.ms/new-console-template for more information

using System.Collections;
using DM1;

Console.WriteLine("Cinema");
Cinema c1 = new Cinema();
Film f1 =new Film(1982,"Science-Fiction",1," L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer)","Blade Runner");
Film f2 = new Film(1992, "Animation", 2,
    "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.",
    "Toy story");
Acteur ac1 = new Acteur(13061942, 1, "Ford", "Harrison");
Acteur ac2 = new Acteur(09071956, 2, "Hanks","Tom");

//Console.WriteLine(f1.ToString());
//Console.WriteLine(ac1.ToString());

c1.SetActeur(ac1);
c1.SetActeur(ac2);

c1.SetFilm(f1);
c1.SetFilm(f2);

f1.setActeurprincipal(ac1);
f2.setActeurprincipal(ac2);

c1.Getlistefilms();
c1.GetlisteActeur();

Console.WriteLine(f1.ToString());
Console.WriteLine("\n");
Console.WriteLine(f2.ToString());

