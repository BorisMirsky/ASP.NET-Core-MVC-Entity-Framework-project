using System.Security.Cryptography;



namespace Versta.GenUniqueId
{
    public class UniqueId
    {
        public string GenerateUniqueID()
        {
            var randomNumber = new byte[32];
            string refreshToken = "";

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                refreshToken = Convert.ToBase64String(randomNumber);
            }
            return refreshToken;
        }
    }
}

            //private static readonly
            //public RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

//public string GenerateUniqueID(int length)
//{
//    int sufficientBufferSizeInBytes = (length * 6 + 7) / 8;
//    var buffer = new byte[sufficientBufferSizeInBytes];
//    random.GetBytes(buffer);
//    return Convert.ToBase64String(buffer).Substring(0, length);
//}
