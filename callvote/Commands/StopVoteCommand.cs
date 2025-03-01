﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using RemoteAdmin;
using UnityEngine;


namespace callvote.Commands
{
	[CommandHandler(typeof(ClientCommandHandler))]
	class StopVoteCommand : ICommand
	{
		public string Command => "stopvote";

		public string[] Aliases => null;

		public string Description => "";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			response = "";
			Player player = Player.Get(((CommandSender)sender).SenderId);
			if (sender is PlayerCommandSender)
			{
				var plr = sender as PlayerCommandSender;
				response = VoteHandlers.VoteHandler.StopVote();
			}
			return false;
		}
	}
}
