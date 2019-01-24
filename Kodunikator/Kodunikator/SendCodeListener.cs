using fbchat_sharp.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodunikator
{
	public interface SendCodeListener
	{
		void sendCode(string title, string code = null);
	}
}
