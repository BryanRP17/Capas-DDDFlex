﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface IClientRepository
    {
        //Comportamiento que va tener 
        int Add(Client client);
        int edit(Client client);
        int remove(Client client);
        IEnumerable<Client> GetClients(string filter);
        //...+
    }
}
