public class RailFenceCipher
{
    private readonly int _rails;
    public RailFenceCipher(int rails)
    {
        _rails = rails;
    }

    public string Encode(string input)
    {
        var messageToCipher = input.Replace(" ", "");
        var fence = new char[_rails, messageToCipher.Length];
        var rail = 0;
        var direction = 1;

        for(int i = 0; i < messageToCipher.Length; i++)
        {
            var letter = messageToCipher[i];
            fence[rail, i] = letter; 

            if(_rails == 1)
            {
                continue;
            }

            if (direction == 1)
            {
                rail += 1;
            }
            else
            {
                rail -= 1;
            }

            if (rail == _rails-1 || rail == 0)
            {
                direction *= -1;
            }


        }

        string cipheredMessage = "";
        for(int j = 0; j < _rails; j++)
        {
            for(int i = 0; i < messageToCipher.Length; i++)
            {
                if (fence[j,i] != '\0')
                {
                    cipheredMessage = string.Concat(cipheredMessage, fence[j, i]);
                }
            }
        }

        return cipheredMessage;


    }

    public string Decode(string input)
    {
        var cipheredMessage = input.Replace(" ", "");
        var fence = new char[_rails, cipheredMessage.Length];
        var rail = 0;
        var direction = 1;



            for(int i = 0; i < cipheredMessage.Length; i++)
            {

                fence[rail, i] = cipheredMessage[i];

                if (direction == 1)
                {
                    rail++;
                }
                else
                {
                    rail--;
                }

                if (rail == _rails - 1 || rail == 0)
                {
                    direction *= -1;
                }

            }




        var decodedMessage = "";
        for (int i = 0; i < cipheredMessage.Length; i++)
        {
            var letter = cipheredMessage[i];
            fence[rail, i] = letter;

            if (_rails == 1)
            {
                continue;
            }

            if (direction == 1)
            {
                rail += 1;
            }
            else
            {
                rail -= 1;
            }

            if (rail == _rails - 1 || rail == 0)
            {
                direction *= -1;
            }


        }

        return decodedMessage;
    }
}