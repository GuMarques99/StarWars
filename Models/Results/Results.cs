using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Web_StarWars.Models.Entities;

namespace Web_StarWars.Models
{
  public class Results<T> : Entity where T : Entity
  {
    public string previous { get; set; }

    public string next { get; set; }

    public string previousPageNo { get; set; }

    public string nextPageNo { get; set; }

    public Int64 count { get; set; }

    public List<T> results { get; set; }
  }
}
