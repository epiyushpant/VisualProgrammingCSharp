using System;
using System.Collections;

namespace Chapter3_4
{
    internal class CollectionNonGeneric
    {
        //ArrayList is non-generic collection that can hold items of any data type
        //It is found in System.Collections namespace
        //It is dynamic in size
        //It stores items as objects
        //It is less type-safe and less performant compared to generic collections
        public static void DemoArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.AddRange(new object[] { 4, "Five", 6.0 });

            arrayList.Remove("Two");
            Console.WriteLine("After modifications:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        //A Hashtable is a non-generic collection that stores key/value pairs that are
        //arranged based on the hashcode of each key.
        public static void DemoHashtable()
        {
            Hashtable myTable = new Hashtable();

            // add items to hashtable
            myTable.Add("Name", "Ginny");
            myTable.Add("RollNumber", 12);
            myTable.Add("Address", "Miami");

            // print value of the element whose key is "RollNumber"
            Console.WriteLine(myTable["RollNumber"]);

            // iterate through the hashtable and print all key-value pairs
            foreach (DictionaryEntry entry in myTable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

        }

        //A Dictionary is a collection of key/value pairs that are organized based on the key.
        public static void DemoDictionary() {
            // create a dictionary 
            Dictionary<int, string> country = new Dictionary<int, string>();

            // add items to dictionary
            country.Add(5, "Brazil");
            country.Add(3, "China");
            country.Add(4, "Usa");

            // print value having key is 3        
            Console.WriteLine("Value having key 3: " + country[3]);

            //iterate through the dictionary and print all key-value pairs

            foreach (KeyValuePair<int, string> kvp in country)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            //change element having key 4
            country[4] = "United States of America";

            //remove element having key 5
            country.Remove(5);

            Console.WriteLine("After modification:");
            foreach (KeyValuePair<int, string> kvp in country)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

        }
    }
}
        
