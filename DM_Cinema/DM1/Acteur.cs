namespace DM1;

public class Acteur
{
    

    private int anneeNaissance;
    private int id;
    private string nom;
    private string prenom;
    
    public Acteur(){}
    
    public Acteur(int anneeNaissance, int id, string nom, string prenom)
    {
        this.anneeNaissance = anneeNaissance;
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
    }

   

    public int GetAnneeNaissance()
    {
        return this.anneeNaissance;
    }

    public int GetId()
    {
        return this.id;
    }

    public string GetNom()
    {
        return this.nom;
    }

    public string GetPrenom()
    {
        return this.prenom;
    }

    public override string ToString()
    {
        return $"nom : {nom}\n" +
               $"prenom : {prenom}\n" +
               $"annee de naissance : {anneeNaissance}";
    }
}