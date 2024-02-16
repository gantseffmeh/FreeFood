using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FreeFood_Project.Cards;

public class Box
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagesId { get; set; }
    public int Count { get; set; }
    public int Cost { get; set; }
}

