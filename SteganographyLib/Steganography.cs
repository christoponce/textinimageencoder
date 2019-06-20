using System;
using System.Text;
using System.Drawing;

namespace SteganographyLib
{
    public class Steganography
    {
        /// <summary>
        /// Encodes a string message into a Bitmap image if the message's size is small enough.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="maxTextKB"></param>
        /// <param name="carrierImage"></param>
        /// <returns>Returns a Bitmap variable containing the encoded message or null.</returns>
        public static Bitmap Encode(string message, double maxTextKB, Bitmap carrierImage)
        {
            double messageLength = Encoding.ASCII.GetByteCount(message);
            
            if(maxTextKB < (messageLength / 1024))
            {
                return null;
            }
            else
            {
                for (int i = 0; i < carrierImage.Width; i++)
                {
                    for (int j = 0; j < carrierImage.Height; j++)
                    {
                        Color pixel = carrierImage.GetPixel(i, j);

                        if (i < 1 && j < message.Length)
                        {
                            char c = Convert.ToChar(message.Substring(j, 1));

                            int value = Convert.ToInt32(c);

                            carrierImage.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                        }

                        if (i == carrierImage.Width - 1 && j == carrierImage.Height - 1)
                        {
                            carrierImage.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, message.Length));
                        }
                    }
                }

                return carrierImage;
            }
        }

        /// <summary>
        /// Decodes a message from an encoded Bitmap Image.
        /// </summary>
        /// <param name="carrierImage"></param>
        /// <returns>Returns a string that contains a message decoded from an encoded Bitmap image.</returns>
        public static string Decode(Bitmap carrierImage)
        {
            string message = string.Empty;
            Color lastPixel = carrierImage.GetPixel(carrierImage.Width - 1, carrierImage.Height - 1);
            int messageLength = lastPixel.B;

            for (int i = 0; i < carrierImage.Width; i++)
            {
                for (int j = 0; j < carrierImage.Height; j++)
                {
                    Color pixel = carrierImage.GetPixel(i, j);

                    if (i < 1 && j < messageLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string character = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + character;
                    }
                }
            }

            return message;
        }
    }
}