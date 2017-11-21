using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppVeyorTestWeb
{
    public class EntityService
    {
        public Entity GetEntity(int EntityID)
        {
            return new Entity() {EntityID=EntityID, Name="Entity Name("+EntityID+")" };
        }
    }
}