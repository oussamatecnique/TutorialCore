using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCore.Models.Ressources
{
    public class MakeRessource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelRessource> Models { get; set; }
        public MakeRessource()
        {
            Models = new Collection<ModelRessource>();
        }
    }
}
