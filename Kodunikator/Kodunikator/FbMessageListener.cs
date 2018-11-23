using fbchat_sharp.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodunikator
{
	interface FbMessageListener
	{
		void messageArrived(FB_Message msg);
	}
}
