﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities.enums;

namespace Sociatis.Models.Congress.Votings
{
    public class ViewChangeContractJobMarketFeeViewModel : ViewVotingBaseViewModel
    {
        public double NewJobFee { get; set; }
        public string CurrencySymbol { get; set; }

        public ViewChangeContractJobMarketFeeViewModel(Entities.CongressVoting voting, bool isPlayerCongressman, bool canVote)
        :base(voting, isPlayerCongressman, canVote)
        {
            NewJobFee = double.Parse(voting.Argument1);
            CurrencySymbol = voting.Country.Currency.Symbol;
        }
    }
}