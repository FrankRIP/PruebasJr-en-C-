#region Invertir una cadena
/*
//1. Invertir una cadena

string text = "Juanito";
string textResult = "";

/*
 * 
 * Forma clasica

for (int i = text.Length-1; i<text.Length; i++)
{
    textResult += text[i];
}



//Con metodos del lenguaje

char[] chars = text.ToCharArray();
Array.Reverse(chars);
textResult = new string(chars);

Console.WriteLine(textResult);
*/
#endregion


#region Repetir caracter
/*

//2. Cuantas veces se repite un caracter
string text = "ggjfGJGJfJJHJJgjgffyfyGYYUUTFDDtgggtdrrssrdAA"; //esta es mi cadena de teto
char character = 'g'; //este es el caracter que vamos a tomar


/*
 * 
 //Modo tradicional
int n = 0; //creo una variable entera que valga cero para que de este tipo de el valor que pido
foreach(char c in text) //con foreach cuento la variable char con c en la variable texto
{
    if (c == character) //le digo que si c esta en la cadena de texto o sea que si la letra g esta en la cadena y que sea solo esa
        n++; //que se vaya sumando de uno en uno
}


int n = 0;
n = text.Where(c => c == character).Count();

Console.WriteLine($"se repite la letra {character} {n} veces"); 
*/
#endregion


#region Hamming
/*
//3. Distancia de Hamming

string text1 = "patitosw";
string text2 = "paratosa";

int distance = 0;

if (text1.Length != text2.Length)
    throw new Exception("Longitudes Distintas"); //Evaluo que la logitudes sean iguales si no arrojo el primero error

for (int i = 0; i < text1.Length; i++)  
{
    
    if (text1[i] != text2[i]) 
        distance++;
}

Console.WriteLine("Distancia es de: " + distance);
*/
#endregion


#region Palabras contadas

/*
//4. Contador de palabras

using System.Text.RegularExpressions; //importo este libreria por que se van a usar expresiones regulares

string text = "   un    texto       que    tiene palabras    "; //declaro mi varible string con
                                                                //espacios intencionales dentro de ella
int n = 0; //declaro una variable tipo entero que valga cero

text = Regex.Replace(text, @"\s+", " ").Trim(); //uso el clase Regex que viene de la libreria que
                                                //importe y con el metodo Replace le digo que 
                                                // remplace todos los lugares que tengan mas de un espacio
                                                //y esto se lo indico con los parametros " text, @"\s+", " " "
                                                //y con trim le digo que me elimine los espacion que estan al final
                                                //y al inicio de mi cadena de texto
var words = text.Split(' '); //declaro la variable words que con el metodo split cuento por elementos entre espacios
n = words.Length;//aqui le digo que me arroje la longitud de la cadena de texto ya con espacio borrados por los pasos 
                 //anteriores y luego ya le digo que me imprima el resultado mediante la consola

Console.WriteLine("Numero de palabras: " + n);
*/
#endregion

#region Numeros contados

using System.Text.RegularExpressions; //importo la libreria que voy a usar

string text = "an1298jp???da°22121230001masA"; //esta es la cadena de texto que voy a usar
string pattern = @"[0-9]"; //aqui declaro una variable con el patron de busqueda que quiero hacer
//en este caso @"[0-9]" o sea que buscare numeros de 0 al 9

//si quiero buscar letras puedo cambiar el patron 'patern' se la siguiente manera
//string pattern = @"[a-zA-Z}";

var regex = new Regex(pattern); // creo una variable donde regex recibe un patron el cual usara como guia para buscar
//los numeros o letras que le indique
int n = regex.Matches(text).Count;  //invoco la variable regex y con el Metodo Matches me hace el conteo de lo
//que le indique 

Console.WriteLine("Cantidad: " + n );
#endregion