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
        private string key = "34n5jk2b354jkhjk345";
        private RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
        public RSAParameters parameters = new RSAParameters();

        public EncriptadorRSA() : base("RSA")
        {
            provider.ImportParameters(parameters);
        }

        public override string Encriptar(string pCadena)
        {
            var cadenaEncriptada = provider.Encrypt(System.Text.Encoding.UTF8.GetBytes(pCadena), true);
            return System.Text.Encoding.UTF8.GetString(cadenaEncriptada);
        }

        public override string Desencriptar(string pCadena)
        {
            return System.Text.Encoding.UTF8.GetString(provider.Decrypt(System.Text.Encoding.UTF8.GetBytes(pCadena), true));
        }
    }
}
