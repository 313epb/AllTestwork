using System;

public sealed class BitArray
{
    private Byte[] m_byteArray;
    private Int32 m_numBits;

    public BitArray(Int32 numBits)
    {
        if (numBits <= 0)
            throw new ArgumentOutOfRangeException("numBits must be > 0");
        m_numBits = numBits;
        m_byteArray = new Byte[(numBits + 7) / 8];
    }
    public Boolean this[Int32 bitPos]
    {
        get
        {
            if ((bitPos < 0) || (bitPos >= m_numBits))
                throw new ArgumentOutOfRangeException("bitPos");
            // Вернуть состояние индексируемого бита
            return (m_byteArray[bitPos / 8] & (1 << (bitPos % 8))) != 0;
        }
        set
        {
            if ((bitPos < 0) || (bitPos >= m_numBits))
                throw new ArgumentOutOfRangeException(
                    "bitPos", bitPos.ToString());
            if (value)
            {
                m_byteArray[bitPos / 8] = (Byte)
                    (m_byteArray[bitPos / 8] | (1 << (bitPos % 8)));
            }
            else
            {
                m_byteArray[bitPos / 8] = (Byte)
                    (m_byteArray[bitPos / 8] & ~(1 << (bitPos % 8)));
            }
        }
    }

    public override string ToString()
    {
        string res = string.Empty;

        foreach (byte b in m_byteArray)
        {
            res += b + " ";
        }

        return res;
    }
}