
using System;

using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;
using GUIstegMP3;


namespace steganography
{

	public sealed class MP3
	{

		
		private string MP3FileName;
		private byte[] contentBytes;
		private BitSet contentBits;
		private int ContentSize;
		private int ContentSize_bits;
		private int positionDebut_bits = 0;


		public MP3(string fileName)
		{

            if (File.Exists(fileName))
            {
                
                MP3FileName = fileName;
                contentBytes = FileToByteArray(fileName);
                ContentSize = contentBytes.Length;
                ContentSize_bits = ContentSize * 8;
                contentBits = this.parser();

                if (contentBytes[0] == 'I' && contentBytes[1] == 'D' && contentBytes[2] == '3')
                {

                    byte[] theSize = new byte[4];

                    theSize[0] = contentBytes[7];
                    theSize[1] = contentBytes[8];
                    theSize[2] = contentBytes[9];
                    theSize[3] = contentBytes[10];
                    BitSet theSize_bits_tmp = parser(theSize);//kthehet ne 32 bita
                    BitSet theSize_bits = new BitSet(32);
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 7; l++)
                        {
                            theSize_bits.Set((l + k * 7), theSize_bits_tmp.Get(l + k * 8));
                        }
                    }
                    for (int k = 28; k < 32; k++)
                    {
                        theSize_bits.Set(k, false);
                    }
                    Console.WriteLine("ID3TAG version 2 Found");

                    int theSize_int = 0;

                    for (int k = 0; k < 32; k++)
                    {
                        int pow = 1;
                        for (int l = 1; l <= k; l++)
                        {
                            pow *= 2;
                        }
                        if (theSize_bits.Get(k))
                        {
                            theSize_int += pow;
                        }
                    }

                    theSize_int += 10 * 8;
                    positionDebut_bits = theSize_int - 1;
                    positionDebut_bits = (int)(Math.Floor((positionDebut_bits + 4) / 8.0)) * 8;

                }
                else
                {
                    Console.WriteLine("ID3TAG version 2 not found!!!");
                }
            }
            else
            {
                Console.WriteLine("File Input Tidak Ada! .\n");
               
            }
		}
			
		

		
		public string FileName
		{
			get
			{
				return MP3FileName;
			}
		}

		public byte[] Content
		{
			get
			{
				return contentBytes;
			}
		}

		public int Taille
		{
			get
			{
				return contentBytes.Length;
			}
		}


        public string Reverse(string text)
        {
            StringBuilder reverse = new StringBuilder(text.Length);
            for(int i=text.Length-1;i>=0;i--)
            {
                reverse.Append(text[i]);
            }
            return reverse.ToString();
        }
		
		public void encode(byte[] arrMsgByte, int lsb)
		{
			int messageSize = arrMsgByte.Length * 8;
			string strMsgLength = Convert.ToString(messageSize);

			if (arrMsgByte.Length * 8 * lsb > ContentSize_bits)
			{
                
				throw new Exception("Ukuran Pesan Terlalu Besar : " + arrMsgByte.Length * 8 * lsb + " bits untuk " + ContentSize_bits + " bits tersedia");
			}

			int position_bits = positionDebut_bits;

			strMsgLength += '\n';
			BitSet arrMsg_bits = this.parser(arrMsgByte);


			byte[] header;
			try
			{
                
                header =Encoding.UTF8.GetBytes(Reverse(strMsgLength));
			}
			catch 
			{
                
                header = Encoding.Default.GetBytes(Reverse(strMsgLength));

            }

			

			BitSet header_bits = this.parser(header);

			for (int i = 0; i < header.Length * 8; i++)
			{
				if (header_bits.Get(i))
				{
					contentBits.Set(i * lsb + lsb - 1 + position_bits, true);
				}
				else
				{
					contentBits.Set(i * lsb + lsb - 1 + position_bits, false);
				}
			}

			for (int i = 0; i < arrMsgByte.Length * 8; i++)
			{
				int x = (i * lsb + lsb - 1 + position_bits) + header.Length * 8 * lsb;

				if (arrMsg_bits.Get(i) != contentBits.Get(x))
				{
					contentBits.Set(x, !contentBits.Get(x));
				}
			}

			contentBytes = toByteArray(contentBits);
		}

		
		private byte[] StreamtoByteArray(FileStream stream)
		{
			int offset = 0;
            int remaining = (int)stream.Length;
			byte[] data = new byte[remaining];
			while (remaining > 0)
			{
				int read = stream.Read(data, offset, remaining);
				if (read <= 0)
				{
					throw new IOException();
				}
				remaining -= read;
				offset += read;
			}
			return data;
		}

	
		private byte[] FileToByteArray(string path)
		{
			byte[] binary;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
				binary = StreamtoByteArray(fs);
			
			return binary;
		}

		
		public BitSet parser()
		{

            BitSet theMP3Bits = new BitSet(contentBytes.Length * 8);

            for (int i = 0; i < contentBytes.Length * 8; i++)
			{
				if ((contentBytes[contentBytes.Length - i / 8 - 1] & (1 << (i % 8))) > 0)
				{
                    theMP3Bits.Set(i);
                    
				}
			}
			return theMP3Bits;
		}


		public BitSet parser(byte[] lebytes)
		{

			BitSet theByteinBits = new BitSet(lebytes.Length * 8);

			for (int i = 0; i < lebytes.Length * 8; i++)
			{
				if ((lebytes[lebytes.Length - i / 8 - 1] & (1 << (i % 8))) > 0)
				{
					theByteinBits.Set(i);
				}
			}
			return theByteinBits;
		}

		// Method to convert a bitmap to a byte array
		public byte[] toByteArray(BitSet bits)
		{
			byte[] bytes = new byte[bits.Length / 8 + 1];
			for (int i = 0; i < bits.Size; i++)
			{
				if (bits.Get(i))
				{
					bytes[bytes.Length - i / 8 - 1] |= (byte)(1 << (i % 8));
				}
			}
			return bytes;
		}



		public void stega(Message m, int lsb)
		{
			byte[] messageByte = m.toBytes();
			this.encode(messageByte,lsb);
		}

		
		public void toMP3(string name)
		{
			byte[] theBytes = toByteArray(this.parser());
			using (FileStream fos = new FileStream(name,FileMode.Create, FileAccess.Write))
			{
				fos.Write(theBytes, 0, theBytes.Length);
				fos.Flush();
			}
		}



		
		public string decoder(int lsb)
		{
			BitSet theContent_bits = this.parser(contentBytes);
			BitSet theChar_bits = new BitSet(8);
			BitSet theMessage;
			string taille = "";
			byte[] theChar;
			//int position = positionDebut_bits / 8;
			int currentPosisition = positionDebut_bits + lsb - 1;
			do
			{
                theChar_bits.Clear(0,8);
				for (int i = 0; i < 8; i++)
				{
					if (theContent_bits.Get(currentPosisition))
					{
						theChar_bits.Set(i, true);
					}
					else
					{
						theChar_bits.Set(i, false);
					}
					currentPosisition += lsb;
				}
				theChar = toByteArray(theChar_bits);
				if ((char) theChar[0] != '\n')
				{
					taille += (char) theChar[0];
				}

			} while ((char) theChar[0] != '\n');

			int size_int = int.Parse(taille);
			theMessage = new BitSet(size_int);

			for (int j = 0; j < int.Parse(taille); j++) //shiko
			{
				if (theContent_bits.Get(currentPosisition))
				{
					theMessage.Set(j, true);
				}
				else
				{
					theMessage.Set(j, false);
				}
				currentPosisition += lsb;
			}

			byte[] theMessage_byte = toByteArray(theMessage);
            string result = System.Text.Encoding.UTF8.GetString(theMessage_byte);
            return result;

        }
    }
}