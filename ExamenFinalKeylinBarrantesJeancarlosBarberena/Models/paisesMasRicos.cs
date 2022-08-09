namespace ExamenFinalKeylinBarrantesJeancarlosBarberena.Models
{
    public class paisesMasRicos
    {
        public List<Paises> Paises { get; set; } 
        public static paisesMasRicos listaRicos=new paisesMasRicos();
        private paisesMasRicos()
        {
            Paises = new List<Paises>();
            AgregarPaises("Estados Unidos","Inglés", "300 veintinueve millones", "Joe Biden", "20 billones", 99,"América", "9000000 km²");
            AgregarPaises("China","Mandarín", "1 402 miles de millones", " Xi Jinping", "14,72 billones", 96, "Asia", "9,597 km²");
            AgregarPaises("Japón", "Japonés", " 83,24 millones", "Naruhito", "5,065 ", 90, "Asia", "377.975 km²");
            AgregarPaises("Alemania", "Alemán", "83,24 millones", "Frank -Walter Steinmeier", "3,806 billones", 99, "Europa", "357.588 km²");
            AgregarPaises("Reino Unido", "Inglés", "67,22 millones", "Boris Johnson", "2,708 billones", 99, "Europa", "243.610 km²");
            AgregarPaises("India", "Hindi", "1,38 miles de millones", "Draupadi Murmu", "2,623 billones", 74, "Asia", "3,287 millones km²");

        }
        public void AgregarPaises(string nombre, string idiom, string pbls, string presi, string pib, int alfab, string cont, string extension)
        {
            Paises ps = new Paises();
            ps.nombrePais = nombre;
            ps.idioma = idiom;
            ps.poblacion = pbls;
            ps.presidente = presi;
            ps.productoInternoBruto = pib;
            ps.alfabetizacion = alfab;
            ps.continente = cont;
            ps.extensionTerritorial = extension;
            ps.ID = 0;
            var l1 = Paises.OrderByDescending(x => x.ID).FirstOrDefault();
            ps.ID = l1?.ID + 1??0;
            Paises.Add(ps);
            
        }
    }
}
