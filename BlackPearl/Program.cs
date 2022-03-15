using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackPearl;

int totalNecklaceCount = 1000;
var r = new Random();
var db = new BlackPearl.BlackPearl();

db.PearlLists.RemoveRange(db.PearlLists);
db.Pearls.RemoveRange(db.Pearls);

for (int i = 0; i < totalNecklaceCount; i++)
{
    var necklace = PearlList.Factory.CreateRandomList(r.Next(10, 50));
    db.PearlLists.Add(necklace);
    db.Pearls.AddRange(necklace._pearllist);
}

db.SaveChanges();


// Hitta dyraste
//var mostExpensive = dbNecklaces.OrderByDescending(price => price.totalPrice).First();

//Console.WriteLine($"Dyraste: {mostExpensive.totalPrice} SEK.");