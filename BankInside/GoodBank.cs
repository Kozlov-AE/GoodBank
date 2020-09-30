﻿using GoodBank.AccountClasses;
using GoodBank.Client_Classes;
using GoodBank.ClientClasses;
using GoodBank.Interfaces_Actions;
using GoodBank.Interfaces_Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoodBank.Transaction_Class;

namespace GoodBank.BankInside
{
	public partial class GoodBank : IGoodBank
	{
		private List<Client>		clients;
		private List<Account>		accounts;
		private List<Transaction>	log;
		public GoodBank()
		{
			clients  = new List<Client>();
			accounts = new List<Account>();
			log		 = new List<Transaction>();
		}

		/// <summary>
		/// Находит клиента с указанным ID
		/// </summary>
		/// <param name="id">ID клиента</param>
		/// <returns></returns>
		public IClient GetClientByID(uint id)
		{
			return clients.Find(c => c.ID == id);
		}

	}
}
