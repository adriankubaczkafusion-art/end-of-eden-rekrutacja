using UnityEngine;

[CreateAssetMenu(fileName = "przedmiot", menuName = "Scriptable Objects/przedmiot")]
public class przedmiot : ScriptableObject
{
    /// <summary>
    /// Klasa przedmiot reprezentuje pojedynczy przedmiot w grze. Zawiera różne właściwości, takie jak nazwa, ikona, obrażenia, opis, cena, typ przedmiotu oraz informacje o tym, czy można go używać jedną lub dwiema rękami. W metodzie Start() są tworzone przykładowe przedmioty i dodawane do listy przechowywanych przedmiotów w klasie Inventory.
    /// </summary>
    public string nazwa;
    public Sprite ikona; 
    public int obrazenia;
    public string opis;
    public bool stackable = true;
    public int cena;
    public string typPrzedmiotu;
    public bool oneHand = false;
    public bool twoHand = false;
    void Start()
    {
      //GeneratePrzedmiotWlocznia();
      //GeneratePrzedmiotMiecz();
      //GeneratePrzedmiotDrewno();
      //GeneratePrzedmiotStalowyGrot();
    }
    /// <summary>
    /// Metoda GeneratePrzedmiot tworzy nowy przedmiot o nazwie "Włócznia", przypisuje mu ikonę, obrażenia, opis, cenę i informację o tym, czy można go stackować. Następnie dodaje ten przedmiot do listy przechowywanych przedmiotów w klasie Inventory.
    /// </summary>
    void GeneratePrzedmiotWlocznia()
    {
        przedmiot wlocznia = new przedmiot();
        wlocznia.nazwa = "Włócznia";
        wlocznia.ikona = Resources.Load<Sprite>("wlocznia");
        wlocznia.obrazenia = 30;
        wlocznia.opis = "Włócznia to broń biała, która składa się z długiego trzonu zakończonego ostrzem. Jest używana do zadawania obrażeń przeciwnikom na dystansie.";
        wlocznia.cena = 75;
        wlocznia.stackable = false;
        wlocznia.typPrzedmiotu = "broń";
        wlocznia.oneHand = false;
        wlocznia.twoHand = true;

        Inventory.przechowywanePrzedmioty.Add(wlocznia);
    }
    /// <summary>
    /// Metoda GeneratePrzedmiotMiecz tworzy nowy przedmiot o nazwie "Miecz", przypisuje mu ikonę, obrażenia, opis, cenę i informację o tym, czy można go stackować. Następnie dodaje ten przedmiot do listy przechowywanych przedmiotów w klasie Inventory.
    /// </summary>
    void GeneratePrzedmiotMiecz()
    {
        przedmiot miecz = new przedmiot();
        miecz.nazwa = "Miecz";
        miecz.ikona = Resources.Load<Sprite>("miecz");
        miecz.obrazenia = 25;
        miecz.opis = "Miecz to broń biała, która składa się z ostrza i rękojeści. Jest używana do zadawania obrażeń przeciwnikom na bliskim dystansie.";
        miecz.cena = 100;
        miecz.stackable = false;
        miecz.typPrzedmiotu = "broń";
        miecz.oneHand = true;
        miecz.twoHand = false;

        Inventory.przechowywanePrzedmioty.Add(miecz);
    }
    /// <summary>
    /// Metoda GeneratePrzedmiotDrewno tworzy nowy przedmiot o nazwie "Drewno", przypisuje mu ikonę, obrażenia, opis, cenę i informację o tym, czy można go stackować. Następnie dodaje ten przedmiot do listy przechowywanych przedmiotów w klasie Inventory.
    /// </summary>
    void GeneratePrzedmiotDrewno()
    {
        przedmiot drewno = new przedmiot();
        drewno.nazwa = "Drewno";
        drewno.ikona = Resources.Load<Sprite>("drewno");
        drewno.obrazenia = 0;
        drewno.opis = "Drewno to surowiec, który można wykorzystać do budowy różnych przedmiotów.";
        drewno.cena = 10;
        drewno.stackable = true;
        drewno.typPrzedmiotu = "materiały";
        drewno.oneHand = false;
        drewno.twoHand = false;

        Inventory.przechowywanePrzedmioty.Add(drewno);
    }
    /// <summary>
    /// Metoda GeneratePrzedmiotStalowyGrot tworzy nowy przedmiot o nazwie "Stalowy Grot", przypisuje mu ikonę, obrażenia, opis, cenę i informację o tym, czy można go stackować. Następnie dodaje ten przedmiot do listy przechowywanych przedmiotów w klasie Inventory.
    /// </summary>
    void GeneratePrzedmiotStalowyGrot()
    {
        przedmiot stalowyGrot = new przedmiot();
        stalowyGrot.nazwa = "Stalowy Grot";
        stalowyGrot.ikona = Resources.Load<Sprite>("stalowyGrot");
        stalowyGrot.obrazenia = 10;
        stalowyGrot.opis = "Grot to część broni, która jest umieszczana na końcu trzonu, aby zwiększyć obrażenia zadawane przeciwnikom.";
        stalowyGrot.cena = 20;
        stalowyGrot.stackable = true;
        stalowyGrot.typPrzedmiotu = "materiały";
        stalowyGrot.oneHand = false;
        stalowyGrot.twoHand = false;

        Inventory.przechowywanePrzedmioty.Add(stalowyGrot);
    }

}
