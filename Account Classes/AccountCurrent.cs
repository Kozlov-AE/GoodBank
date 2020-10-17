﻿using GoodBankNS.DTO;
using GoodBankNS.Interfaces_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBankNS.AccountClasses
{
	public class AccountCurrent : Account
	{
		public override AccountType AccType { get => AccountType.Current; }
		public override int Balance { get; set; }

		/// <summary>
		/// Создание счета на основе введенных данных
		/// </summary>
		/// <param name="acc">Данные для открытия счета</param>
		/// Напоминалка, что инициализируется в базовом классе
		/// ClientID	  = clientID;				--> из IAccountDTO acc
		/// ClientType	  = clientType;				--> из IAccountDTO acc
		/// ID			  = NextID();
		/// AccountNumber = $"{ID:000000000000}";	--> добавляется CUR
		/// Compounding	  = compounding;			--> из IAccountDTO acc
		/// CompoundAccID = compAccID;				--> из IAccountDTO acc
		/// Balance		  = 0;
		/// Interest	  = interest;				--> из IAccountDTO acc
		/// AccountStatus = AccountStatus.Opened;
		/// Opened		  = DateTime.Now;
		/// Topupable	  =							--> true
		/// WithdrawalAllowed	=					--> ture
		/// RecalcPeriod  =							--> No recalc period
		/// EndDate		  =							--> null 
		public AccountCurrent(IAccountDTO acc)
			: base(acc.ClientID, acc.ClientType, acc.Compounding, acc.CompoundAccID, acc.Interest,
				   true, true, RecalcPeriod.NoRecalc, null)
		{
			AccountNumber	= "CUR" + AccountNumber;
			Balance			= acc.CurrentAmount;
		}

		/// <summary>
		/// Констркуктор для искусственной генерации счета. 
		/// Включает в себя поле даты открытия счета
		/// </summary>
		/// <param name="acc"></param>
		/// <param name="opened"></param>
		public AccountCurrent(IAccountDTO acc, DateTime opened)
			: base(acc.ClientID, acc.ClientType, acc.Compounding, acc.CompoundAccID, acc.Interest,
				   opened,
				   true, true, RecalcPeriod.NoRecalc, null)
		{
			AccountNumber = "CUR" + AccountNumber;
			Balance = acc.CurrentAmount;
		}


	}
}
