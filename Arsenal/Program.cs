global using System.Text.Json;
using System.Text.Json.Serialization;    //hela världen använder json - all kommunikation (utom html, css) - serialiserare = göra om objekt till text och tvärtom

string textHat = File.ReadAllText("hats.json");

List<Hat> hats = JsonSerializer.Deserialize<List<Hat>>(textHat);

Console.WriteLine(hats[1].Name);

Console.ReadLine();






// Hat myFirstHat = new Hat()
// {
//     Name = "Fedora",
//     Swag = 10,
//     Armor = 3,
//     Color = "Black"
// };

// string jsonHat = JsonSerializer.Serialize(myFirstHat);
// Console.WriteLine(jsonHat);

// File.WriteAllText("fedora.json", jsonHat);