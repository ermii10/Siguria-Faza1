//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System.Collections;
using System.Text;
//
namespace steganography
{

	public class Message
	{

		 string content; // content of message

		// the constructor
		public Message(string leMessage)
		{
			content = leMessage;
		}

		// Methode de conversion du content en tableau de bytes (octets)
		public  byte[] toBytes()
		{
			byte[] byteTable;
			//try
			//{
                
               byteTable = Encoding.UTF8.GetBytes(content); // La methode magique qui fait tout
			//}
			//catch 
			//{
				//byteTable =Encoding.ASCII.GetBytes(content); // La methode magique qui fait tout
			//}
			return byteTable;
		}

		// Methode qui transforme le content du message en tableau de bits
		/// 
		/// <summary>
		/// @return
		/// </summary>
		public  BitArray parser()
		{
			byte[] MessageBytes = this.toBytes();
			BitArray MessageBits = new BitArray(MessageBytes.Length * 8);

			for (int i = 0; i < MessageBytes.Length * 8; i++)
			{
				if ((MessageBytes[MessageBytes.Length - i / 8 - 1] & (1 << (i % 8))) > 0)
				{
					MessageBits.Set(i, true);
				}
			}
			return MessageBits;
		}
        
	}

}