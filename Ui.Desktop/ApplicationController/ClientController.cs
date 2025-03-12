using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Entities;
using Aplication;
using Ui.Desktop.ViewModel;

namespace Ui.Desktop.ApplicationController
{
    public class ClientController
    {
        public IEnumerable<ClientViewModel> GetClientsAll(string filter)
        {
            var clientList = new ClientService().GetClients(filter);
            //Mapeo de datos/se puede ahorrar utilizando mapeo de datos con framework
            List<ClientViewModel> viewModel = new List<ClientViewModel>();
            foreach(Client item in clientList)
            {
                viewModel.Add(new ClientViewModel { 
                ID = item.ID,
                Nombre = item.Nombre,
                Apellido = item.Apellido,
                Direccion = item.Direccion,
                Ciudad = item.Ciudad,
                Email = item.Email,
                Telefono = item.Telefono,
                Ocupacion = item.Ocupacion
                });
            }
            return viewModel;
        }
    }
}
