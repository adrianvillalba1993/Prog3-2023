// See https://aka.ms/new-console-template for more information
using System;
using Trabajo_Practico_1;

namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
           /*Crear un nuevo diccionario de strings , con clave string. */

            Dictionary<string, string> openWith =
            new Dictionary<string, string>();

            /* Agrega algunos elementos al diccionario. No hay claves duplicadas pero 
            alguno de los valores si son duplicados*/
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            /*El metodo Add tira una excepción si la clave ya existe en el diccionario*/
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            /*La propiedad del item es otro nombre para el indexer(array virtual), asi que se puede omitir el nombre
             para acceder a los elementos*/
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            /*el indexer puede ser usado para cambiar el valor asociado a la clave*/
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            /* Si la llave no existe ,agregarlo al indexer hace que cree un nuevo par "clave-valor" */
            openWith["doc"] = "winword.exe";

            /*El indexer tira una excepción si la llave requerida no existe en el diccionario */
            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.",
                    openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }


            /*Cuando un programa frecuentemente nota que las claves no estan en el diccionario , 
            TryGetValue puede ser mas eficiente para recuperar valores*/
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            /* ContainsKey puede usarse para testear las claves antes de insertarlas*/
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}",
                    openWith["ht"]);
            }

            /*Cuando se usa foreach para enumerar los elementos del diccionario , 
            dichos elementos son recuperados como objetos "KeyValuePair" */
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }


            /*Para obtener solo los valores se usa la propiedad "Values" */
            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            /*Los elementos de ValueCollection son fuertemente tipadas con el tipo que fue 
            especificado en los valores del diccionario*/
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            /*Para solo obtener las llaves debe usarse la propiedad "Keys" */
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            /*Los elementos de KeyCollection son fuertemente tipadas con el tipo que fue 
            especificado en las claves del diccionario */
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            /*Usar el metodo "Remove" para eliminar un par de clase-valor*/
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }

            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }


        }

    }
}