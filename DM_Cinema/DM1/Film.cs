namespace DM1;

public class Film
{
    

    private int annee;
    private string genre;
    private int idFilm;
    private string resume;
    private string titre;
    private Acteur acteurprincipal;
     
    public Film(){}
    public Film(int annee, string genre, int idFilm, string resume, string titre)
    {
        this.annee = annee;
        this.genre = genre;
        this.idFilm = idFilm;
        this.resume = resume;
        this.titre = titre;
        acteurprincipal = new Acteur();
    }
    public int GetAnnee()
    {
        return this.annee;
    }
    public string GetGenre()
    {
        return this.genre;
    }
    public int GetidFilm()
    {
        return this.idFilm;
    }
    public string GetResume()
    {
        return this.resume;
    }
    public string GetTitre()
    {
        return this.titre;
    }
    public void setActeurprincipal(Acteur acteur)
    {
        acteurprincipal = acteur;
    }
    public override string ToString()
    {
        return $"titre : {this.titre}\n" +
               $"annee : {this.annee}\n" +
               $"genre : {this.genre}\n" +
               $"resume : {this.resume}\n" +
               $"acteur : {acteurprincipal.GetPrenom()} {acteurprincipal.GetNom()}";
    }
    public string GetActeurPrincipal()
    {
        return acteurprincipal.GetNom();
    }
}