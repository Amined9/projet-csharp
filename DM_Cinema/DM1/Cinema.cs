namespace DM1;

public class Cinema
{
    private string cine;
    private List<Acteur> lesacteurs ;
    private List<Film> lesfilms ;

    public Cinema()
    {
        this.lesacteurs = new List<Acteur>();
        this.lesfilms = new List<Film>();
    }

    public Acteur GetActeur(int id)
    {
        Acteur ac = new Acteur();

        foreach (var acteur in lesacteurs)
        {
            if (acteur.GetId() == id)
            {
                ac = acteur;
            }
        }

        return ac;
    }

    public Film GetFilm(int id)
    {
        Film f = new Film();

        foreach (var film in lesfilms)
        {
            if (film.GetidFilm() == id)
            {
                f = film;
            }
        }

        return f;
    }

    public void GetlisteActeur()
    {
        Console.WriteLine("Liste des acteurs :\n");
        foreach (var acteur in lesacteurs)
        {
            Console.WriteLine("Acteur : "+ acteur.GetNom());
        }
    }

    public void Getlistefilms()
    {
        Console.WriteLine("Liste des films :\n");
        foreach (var film in lesfilms)
        {
            Console.WriteLine("Film : "+ film.GetTitre());
        }
    }

    public int NbActeur()
    {
        return lesacteurs.Count();
    }

    public int NbFilms()
    {
        return lesfilms.Count();
    }

    public Film SetFilm(Film f)
    {
        lesfilms.Add(f);
        return null;
    }

    public void SetNewFilm(int annee, string genre, int idFilm, string resume, string titre)
    {
        Film f = new Film(annee,genre,idFilm,resume,titre);
        lesfilms.Add(f);
    }

    public Acteur SetActeur(Acteur a)
    {
        lesacteurs.Add(a);
        return null;
    }

    public void SetNewActeur(int anneeNaissance, int id, string nom, string prenom)
    {
        Acteur a = new Acteur(anneeNaissance,id,nom,prenom);
        lesacteurs.Add(a);
    }
    
}