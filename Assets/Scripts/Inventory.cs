using System.Collections.Generic;
using UnityEngine;

public static class Inventory
{
    /// <summary>
    /// Klasa Inventory jest statyczną klasą, która przechowuje listę przedmiotów dostępnych w grze. Lista ta jest publiczna i statyczna, co oznacza, że można do niej uzyskać dostęp z dowolnego miejsca w kodzie bez konieczności tworzenia instancji klasy Inventory. Przechowywane przedmioty są reprezentowane przez obiekty klasy przedmiot, które zawierają różne właściwości, takie jak nazwa, ikona, obrażenia, opis, cena i typ przedmiotu.
    /// </summary>
    public static List<przedmiot> przechowywanePrzedmioty = new List<przedmiot>();
}
