using System.Collections.Generic;
public static class Equipos
{
  public static List<string> ListaEquipos {get;private set;} =new List<string>() {"Boca", "Almagro", "Ferro", "San Lorenzo", "Atlanta", "River Plate", "Racing", "Defensa y Justicia", "Colon", "Huracan"};
   public static List<string> ListaMedias {get; private set;} = new List<string>() {"Mboca.jfif", "Malmagro.jpg", "Mferro.jpg", "Msan lorenzo.jpg", "MAtlanta.jpg", "MRiver.jpg", "Mracing.jpg", "Mdyf.webp", "Mcolon.png", "Mhuracan.webp"};
   public static List<string> ListaPantalones {get; private set;} = new List<string>() {"Sboca.webp", "Salmagro.webp", "Sferro.webp", "Ssan lorenzo.webp", "SAtlanta.jpg", "SRiver.webp", "Sracing.jfif", "Sdyf.jpg", "Scolon.webp", "Shuracan.webp"};
   public static List<string> ListaRemeras {get; private set;} = new List<string>() {"Cboca.webp", "Calmagro.jpg", "Cferro.jpg", "Csan lorenzo.jfif", "CAtlanta.jpg", "CRiver.webp", "Cracing.jpg", "Cdyf.jpg", "Ccolon.jfif", "Churacan.jfif"};
   public static Dictionary<string, Indumentaria> EquiposIndumentaria{get; private set;}= new Dictionary<string, Indumentaria>();
   public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
   {
    bool compra;
    if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado) == false)
    {
        EquiposIndumentaria.Add (EquipoSeleccionado, item);
        return compra = true;
    
    } 
    else return compra = false;
    
   }
}