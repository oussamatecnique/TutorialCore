using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCore.Models;
using TutorialCore.Models.Ressources;

namespace TutorialCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeRessource>();
            CreateMap<Model, ModelRessource>();

        }

    }
}
