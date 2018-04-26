using System;
using System.Collections.Generic;
using BusinessLogic;
using Core;

namespace NobiService
{
    public class AgentService : IAgentService
    {
        private AgentController controller;
        public AgentService()
        {
            controller = new AgentController();
        }
        public IEnumerable<Agent> All()
        {
            return controller.All();
        }

        public void Create(Agent entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            controller.Delete(id);
        }

        public Agent Read(int id)
        {
            return controller.Read(id);
        }

        public void Update(Agent entity)
        {
            controller.Update(entity);
        }
    }
}
