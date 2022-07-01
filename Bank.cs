﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        private string name { get; set; }

        private List<Client> clientsList = new List<Client>();

        private List<Loan> loansList;



        public Bank(string name)
        {
            this.name = name;
        }


        public static Client CreateClient(string name)
        {
            Client newClient = new Client(name);

            return newClient;
            
        }

        public void AddNewClient(Client client)
        {
            this.clientsList.Add(client);

            Console.WriteLine("hai aggiunto {0} tra i clienti", client.Name);
        }

        public void PrintClientList()
        {
            foreach (var client in this.clientsList)
            {
                Console.WriteLine(client.Name);
            }
        }

        public Client FindClient(string clientName)
        {

            Client result = null;

            foreach (var client in this.clientsList)
            {
                if (client.Name == clientName)
                {
                    result = client;
                    break;

                } else
                {
                    Console.WriteLine("cliente non trovato");
                }              
            }
            return result;
        }

        public void PrintClientInfo(Client client)
        {
            if (this.FindClient == null)
            {
                Console.WriteLine("nessun cliente");
            }

            Console.WriteLine("Nome cliente: " + client.Name);

        }

    }
}
