//using System;
//using System.Text;
//using System.Security.Cryptography;
//using System.IO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Ej5
{

	public class EncriptadorRSA : Encriptador
	{
        private RSACryptoServiceProvider provider;
		public RSAParameters parameters;
		private string privateKey;
		public string publicKey;

        public EncriptadorRSA() : base("RSA")
        {
			provider = new RSACryptoServiceProvider(1112);
			this.privateKey = provider.ToXmlString(true);
			this.publicKey = provider.ToXmlString(false);
        }

        public override string Encriptar(string pCadena)
        {
			provider = new RSACryptoServiceProvider();
			provider.FromXmlString(publicKey);

			// Proceso la cadena
			var cadena = System.Text.Encoding.UTF8.GetBytes(pCadena);
			var cadenaCifrada = provider.Encrypt(cadena, false);

			return Convert.ToBase64String(cadenaCifrada);
        }

        public override string Desencriptar(string pCadena)
        {
			provider = new RSACryptoServiceProvider();
			provider.FromXmlString(privateKey);

			var cadenaCifrada = Convert.FromBase64String(pCadena);
			var cadenaDesencriptada = provider.Decrypt(cadenaCifrada, false);
			return System.Text.Encoding.UTF8.GetString(cadenaDesencriptada);
        }
    }
}
