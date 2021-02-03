using System;
using System.Text;

namespace Unnecessarily_Complicated_Hello_World
{
    class Program
    {
        static void Main()
        {
            Bit t = new Bit { State = true };
            Bit f = new Bit { State = false };

            Nybble n0 = new Nybble() { Bits = new Bit[4] { f, f, f, f } };
            Nybble n1 = new Nybble() { Bits = new Bit[4] { f, f, f, t } };
            Nybble n2 = new Nybble() { Bits = new Bit[4] { f, f, t, f } };
            Nybble n3 = new Nybble() { Bits = new Bit[4] { f, f, t, t } };
            Nybble n4 = new Nybble() { Bits = new Bit[4] { f, t, f, f } };
            Nybble n5 = new Nybble() { Bits = new Bit[4] { f, t, f, t } };
            Nybble n6 = new Nybble() { Bits = new Bit[4] { f, t, t, f } };
            Nybble n7 = new Nybble() { Bits = new Bit[4] { f, t, t, t } };
            Nybble n8 = new Nybble() { Bits = new Bit[4] { t, f, f, f } };
            Nybble n9 = new Nybble() { Bits = new Bit[4] { t, f, f, t } };
            Nybble n10 = new Nybble() { Bits = new Bit[4] { t, f, t, f } };
            Nybble n11 = new Nybble() { Bits = new Bit[4] { t, f, t, t } };
            Nybble n12 = new Nybble() { Bits = new Bit[4] { t, t, f, f } };
            Nybble n13 = new Nybble() { Bits = new Bit[4] { t, t, f, t } };
            Nybble n14 = new Nybble() { Bits = new Bit[4] { t, t, t, f } };
            Nybble n15 = new Nybble() { Bits = new Bit[4] { t, t, t, t } };

            HByte b0 = new HByte() { Nybbles = new Nybble[2] { n0, n0 } };
            HByte b1 = new HByte() { Nybbles = new Nybble[2] { n0, n1 } };
            HByte b2 = new HByte() { Nybbles = new Nybble[2] { n0, n2 } };
            HByte b3 = new HByte() { Nybbles = new Nybble[2] { n0, n3 } };
            HByte b4 = new HByte() { Nybbles = new Nybble[2] { n0, n4 } };
            HByte b5 = new HByte() { Nybbles = new Nybble[2] { n0, n5 } };
            HByte b6 = new HByte() { Nybbles = new Nybble[2] { n0, n6 } };
            HByte b7 = new HByte() { Nybbles = new Nybble[2] { n0, n7 } };
            HByte b8 = new HByte() { Nybbles = new Nybble[2] { n0, n8 } };
            HByte b9 = new HByte() { Nybbles = new Nybble[2] { n0, n9 } };
            HByte b10 = new HByte() { Nybbles = new Nybble[2] { n0, n10 } };
            HByte b11 = new HByte() { Nybbles = new Nybble[2] { n0, n11 } };
            HByte b12 = new HByte() { Nybbles = new Nybble[2] { n0, n12 } };
            HByte b13 = new HByte() { Nybbles = new Nybble[2] { n0, n13 } };
            HByte b14 = new HByte() { Nybbles = new Nybble[2] { n0, n14 } };
            HByte b15 = new HByte() { Nybbles = new Nybble[2] { n0, n15 } };
            HByte b16 = new HByte() { Nybbles = new Nybble[2] { n1, n0 } };
            HByte b17 = new HByte() { Nybbles = new Nybble[2] { n1, n1 } };
            HByte b18 = new HByte() { Nybbles = new Nybble[2] { n1, n2 } };
            HByte b19 = new HByte() { Nybbles = new Nybble[2] { n1, n3 } };
            HByte b20 = new HByte() { Nybbles = new Nybble[2] { n1, n4 } };
            HByte b21 = new HByte() { Nybbles = new Nybble[2] { n1, n5 } };
            HByte b22 = new HByte() { Nybbles = new Nybble[2] { n1, n6 } };
            HByte b23 = new HByte() { Nybbles = new Nybble[2] { n1, n7 } };
            HByte b24 = new HByte() { Nybbles = new Nybble[2] { n1, n8 } };
            HByte b25 = new HByte() { Nybbles = new Nybble[2] { n1, n9 } };
            HByte b26 = new HByte() { Nybbles = new Nybble[2] { n1, n10 } };
            HByte b27 = new HByte() { Nybbles = new Nybble[2] { n1, n11 } };
            HByte b28 = new HByte() { Nybbles = new Nybble[2] { n1, n12 } };
            HByte b29 = new HByte() { Nybbles = new Nybble[2] { n1, n13 } };
            HByte b30 = new HByte() { Nybbles = new Nybble[2] { n1, n14 } };
            HByte b31 = new HByte() { Nybbles = new Nybble[2] { n1, n15 } };
            HByte b32 = new HByte() { Nybbles = new Nybble[2] { n2, n0 } };
            HByte b33 = new HByte() { Nybbles = new Nybble[2] { n2, n1 } };
            HByte b34 = new HByte() { Nybbles = new Nybble[2] { n2, n2 } };
            HByte b35 = new HByte() { Nybbles = new Nybble[2] { n2, n3 } };
            HByte b36 = new HByte() { Nybbles = new Nybble[2] { n2, n4 } };
            HByte b37 = new HByte() { Nybbles = new Nybble[2] { n2, n5 } };
            HByte b38 = new HByte() { Nybbles = new Nybble[2] { n2, n6 } };
            HByte b39 = new HByte() { Nybbles = new Nybble[2] { n2, n7 } };
            HByte b40 = new HByte() { Nybbles = new Nybble[2] { n2, n8 } };
            HByte b41 = new HByte() { Nybbles = new Nybble[2] { n2, n9 } };
            HByte b42 = new HByte() { Nybbles = new Nybble[2] { n2, n10 } };
            HByte b43 = new HByte() { Nybbles = new Nybble[2] { n2, n11 } };
            HByte b44 = new HByte() { Nybbles = new Nybble[2] { n2, n12 } };
            HByte b45 = new HByte() { Nybbles = new Nybble[2] { n2, n13 } };
            HByte b46 = new HByte() { Nybbles = new Nybble[2] { n2, n14 } };
            HByte b47 = new HByte() { Nybbles = new Nybble[2] { n2, n15 } };
            HByte b48 = new HByte() { Nybbles = new Nybble[2] { n3, n0 } };
            HByte b49 = new HByte() { Nybbles = new Nybble[2] { n3, n1 } };
            HByte b50 = new HByte() { Nybbles = new Nybble[2] { n3, n2 } };
            HByte b51 = new HByte() { Nybbles = new Nybble[2] { n3, n3 } };
            HByte b52 = new HByte() { Nybbles = new Nybble[2] { n3, n4 } };
            HByte b53 = new HByte() { Nybbles = new Nybble[2] { n3, n5 } };
            HByte b54 = new HByte() { Nybbles = new Nybble[2] { n3, n6 } };
            HByte b55 = new HByte() { Nybbles = new Nybble[2] { n3, n7 } };
            HByte b56 = new HByte() { Nybbles = new Nybble[2] { n3, n8 } };
            HByte b57 = new HByte() { Nybbles = new Nybble[2] { n3, n9 } };
            HByte b58 = new HByte() { Nybbles = new Nybble[2] { n3, n10 } };
            HByte b59 = new HByte() { Nybbles = new Nybble[2] { n3, n11 } };
            HByte b60 = new HByte() { Nybbles = new Nybble[2] { n3, n12 } };
            HByte b61 = new HByte() { Nybbles = new Nybble[2] { n3, n13 } };
            HByte b62 = new HByte() { Nybbles = new Nybble[2] { n3, n14 } };
            HByte b63 = new HByte() { Nybbles = new Nybble[2] { n3, n15 } };
            HByte b64 = new HByte() { Nybbles = new Nybble[2] { n4, n0 } };
            HByte b65 = new HByte() { Nybbles = new Nybble[2] { n4, n1 } };
            HByte b66 = new HByte() { Nybbles = new Nybble[2] { n4, n2 } };
            HByte b67 = new HByte() { Nybbles = new Nybble[2] { n4, n3 } };
            HByte b68 = new HByte() { Nybbles = new Nybble[2] { n4, n4 } };
            HByte b69 = new HByte() { Nybbles = new Nybble[2] { n4, n5 } };
            HByte b70 = new HByte() { Nybbles = new Nybble[2] { n4, n6 } };
            HByte b71 = new HByte() { Nybbles = new Nybble[2] { n4, n7 } };
            HByte b72 = new HByte() { Nybbles = new Nybble[2] { n4, n8 } };
            HByte b73 = new HByte() { Nybbles = new Nybble[2] { n4, n9 } };
            HByte b74 = new HByte() { Nybbles = new Nybble[2] { n4, n10 } };
            HByte b75 = new HByte() { Nybbles = new Nybble[2] { n4, n11 } };
            HByte b76 = new HByte() { Nybbles = new Nybble[2] { n4, n12 } };
            HByte b77 = new HByte() { Nybbles = new Nybble[2] { n4, n13 } };
            HByte b78 = new HByte() { Nybbles = new Nybble[2] { n4, n14 } };
            HByte b79 = new HByte() { Nybbles = new Nybble[2] { n4, n15 } };
            HByte b80 = new HByte() { Nybbles = new Nybble[2] { n5, n0 } };
            HByte b81 = new HByte() { Nybbles = new Nybble[2] { n5, n1 } };
            HByte b82 = new HByte() { Nybbles = new Nybble[2] { n5, n2 } };
            HByte b83 = new HByte() { Nybbles = new Nybble[2] { n5, n3 } };
            HByte b84 = new HByte() { Nybbles = new Nybble[2] { n5, n4 } };
            HByte b85 = new HByte() { Nybbles = new Nybble[2] { n5, n5 } };
            HByte b86 = new HByte() { Nybbles = new Nybble[2] { n5, n6 } };
            HByte b87 = new HByte() { Nybbles = new Nybble[2] { n5, n7 } };
            HByte b88 = new HByte() { Nybbles = new Nybble[2] { n5, n8 } };
            HByte b89 = new HByte() { Nybbles = new Nybble[2] { n5, n9 } };
            HByte b90 = new HByte() { Nybbles = new Nybble[2] { n5, n10 } };
            HByte b91 = new HByte() { Nybbles = new Nybble[2] { n5, n11 } };
            HByte b92 = new HByte() { Nybbles = new Nybble[2] { n5, n12 } };
            HByte b93 = new HByte() { Nybbles = new Nybble[2] { n5, n13 } };
            HByte b94 = new HByte() { Nybbles = new Nybble[2] { n5, n14 } };
            HByte b95 = new HByte() { Nybbles = new Nybble[2] { n5, n15 } };
            HByte b96 = new HByte() { Nybbles = new Nybble[2] { n6, n0 } };
            HByte b97 = new HByte() { Nybbles = new Nybble[2] { n6, n1 } };
            HByte b98 = new HByte() { Nybbles = new Nybble[2] { n6, n2 } };
            HByte b99 = new HByte() { Nybbles = new Nybble[2] { n6, n3 } };
            HByte b100 = new HByte() { Nybbles = new Nybble[2] { n6, n4 } };
            HByte b101 = new HByte() { Nybbles = new Nybble[2] { n6, n5 } };
            HByte b102 = new HByte() { Nybbles = new Nybble[2] { n6, n6 } };
            HByte b103 = new HByte() { Nybbles = new Nybble[2] { n6, n7 } };
            HByte b104 = new HByte() { Nybbles = new Nybble[2] { n6, n8 } };
            HByte b105 = new HByte() { Nybbles = new Nybble[2] { n6, n9 } };
            HByte b106 = new HByte() { Nybbles = new Nybble[2] { n6, n10 } };
            HByte b107 = new HByte() { Nybbles = new Nybble[2] { n6, n11 } };
            HByte b108 = new HByte() { Nybbles = new Nybble[2] { n6, n12 } };
            HByte b109 = new HByte() { Nybbles = new Nybble[2] { n6, n13 } };
            HByte b110 = new HByte() { Nybbles = new Nybble[2] { n6, n14 } };
            HByte b111 = new HByte() { Nybbles = new Nybble[2] { n6, n15 } };
            HByte b112 = new HByte() { Nybbles = new Nybble[2] { n7, n0 } };
            HByte b113 = new HByte() { Nybbles = new Nybble[2] { n7, n1 } };
            HByte b114 = new HByte() { Nybbles = new Nybble[2] { n7, n2 } };
            HByte b115 = new HByte() { Nybbles = new Nybble[2] { n7, n3 } };
            HByte b116 = new HByte() { Nybbles = new Nybble[2] { n7, n4 } };
            HByte b117 = new HByte() { Nybbles = new Nybble[2] { n7, n5 } };
            HByte b118 = new HByte() { Nybbles = new Nybble[2] { n7, n6 } };
            HByte b119 = new HByte() { Nybbles = new Nybble[2] { n7, n7 } };
            HByte b120 = new HByte() { Nybbles = new Nybble[2] { n7, n8 } };

            HChar c0 = new HChar() { Code = b0 };
            HChar c1 = new HChar() { Code = b1 };
            HChar c2 = new HChar() { Code = b2 };
            HChar c3 = new HChar() { Code = b3 };
            HChar c4 = new HChar() { Code = b4 };
            HChar c5 = new HChar() { Code = b5 };
            HChar c6 = new HChar() { Code = b6 };
            HChar c7 = new HChar() { Code = b7 };
            HChar c8 = new HChar() { Code = b8 };
            HChar c9 = new HChar() { Code = b9 };
            HChar c10 = new HChar() { Code = b10 };
            HChar c11 = new HChar() { Code = b11 };
            HChar c12 = new HChar() { Code = b12 };
            HChar c13 = new HChar() { Code = b13 };
            HChar c14 = new HChar() { Code = b14 };
            HChar c15 = new HChar() { Code = b15 };
            HChar c16 = new HChar() { Code = b16 };
            HChar c17 = new HChar() { Code = b17 };
            HChar c18 = new HChar() { Code = b18 };
            HChar c19 = new HChar() { Code = b19 };
            HChar c20 = new HChar() { Code = b20 };
            HChar c21 = new HChar() { Code = b21 };
            HChar c22 = new HChar() { Code = b22 };
            HChar c23 = new HChar() { Code = b23 };
            HChar c24 = new HChar() { Code = b24 };
            HChar c25 = new HChar() { Code = b25 };
            HChar c26 = new HChar() { Code = b26 };
            HChar c27 = new HChar() { Code = b27 };
            HChar c28 = new HChar() { Code = b28 };
            HChar c29 = new HChar() { Code = b29 };
            HChar c30 = new HChar() { Code = b30 };
            HChar c31 = new HChar() { Code = b31 };
            HChar c32 = new HChar() { Code = b32 };
            HChar c33 = new HChar() { Code = b33 };
            HChar c34 = new HChar() { Code = b34 };
            HChar c35 = new HChar() { Code = b35 };
            HChar c36 = new HChar() { Code = b36 };
            HChar c37 = new HChar() { Code = b37 };
            HChar c38 = new HChar() { Code = b38 };
            HChar c39 = new HChar() { Code = b39 };
            HChar c40 = new HChar() { Code = b40 };
            HChar c41 = new HChar() { Code = b41 };
            HChar c42 = new HChar() { Code = b42 };
            HChar c43 = new HChar() { Code = b43 };
            HChar c44 = new HChar() { Code = b44 };
            HChar c45 = new HChar() { Code = b45 };
            HChar c46 = new HChar() { Code = b46 };
            HChar c47 = new HChar() { Code = b47 };
            HChar c48 = new HChar() { Code = b48 };
            HChar c49 = new HChar() { Code = b49 };
            HChar c50 = new HChar() { Code = b50 };
            HChar c51 = new HChar() { Code = b51 };
            HChar c52 = new HChar() { Code = b52 };
            HChar c53 = new HChar() { Code = b53 };
            HChar c54 = new HChar() { Code = b54 };
            HChar c55 = new HChar() { Code = b55 };
            HChar c56 = new HChar() { Code = b56 };
            HChar c57 = new HChar() { Code = b57 };
            HChar c58 = new HChar() { Code = b58 };
            HChar c59 = new HChar() { Code = b59 };
            HChar c60 = new HChar() { Code = b60 };
            HChar c61 = new HChar() { Code = b61 };
            HChar c62 = new HChar() { Code = b62 };
            HChar c63 = new HChar() { Code = b63 };
            HChar c64 = new HChar() { Code = b64 };
            HChar c65 = new HChar() { Code = b65 };
            HChar c66 = new HChar() { Code = b66 };
            HChar c67 = new HChar() { Code = b67 };
            HChar c68 = new HChar() { Code = b68 };
            HChar c69 = new HChar() { Code = b69 };
            HChar c70 = new HChar() { Code = b70 };
            HChar c71 = new HChar() { Code = b71 };
            HChar c72 = new HChar() { Code = b72 };
            HChar c73 = new HChar() { Code = b73 };
            HChar c74 = new HChar() { Code = b74 };
            HChar c75 = new HChar() { Code = b75 };
            HChar c76 = new HChar() { Code = b76 };
            HChar c77 = new HChar() { Code = b77 };
            HChar c78 = new HChar() { Code = b78 };
            HChar c79 = new HChar() { Code = b79 };
            HChar c80 = new HChar() { Code = b80 };
            HChar c81 = new HChar() { Code = b81 };
            HChar c82 = new HChar() { Code = b82 };
            HChar c83 = new HChar() { Code = b83 };
            HChar c84 = new HChar() { Code = b84 };
            HChar c85 = new HChar() { Code = b85 };
            HChar c86 = new HChar() { Code = b86 };
            HChar c87 = new HChar() { Code = b87 };
            HChar c88 = new HChar() { Code = b88 };
            HChar c89 = new HChar() { Code = b89 };
            HChar c90 = new HChar() { Code = b90 };
            HChar c91 = new HChar() { Code = b91 };
            HChar c92 = new HChar() { Code = b92 };
            HChar c93 = new HChar() { Code = b93 };
            HChar c94 = new HChar() { Code = b94 };
            HChar c95 = new HChar() { Code = b95 };
            HChar c96 = new HChar() { Code = b96 };
            HChar c97 = new HChar() { Code = b97 };
            HChar c98 = new HChar() { Code = b98 };
            HChar c99 = new HChar() { Code = b99 };
            HChar c100 = new HChar() { Code = b100 };
            HChar c101 = new HChar() { Code = b101 };
            HChar c102 = new HChar() { Code = b102 };
            HChar c103 = new HChar() { Code = b103 };
            HChar c104 = new HChar() { Code = b104 };
            HChar c105 = new HChar() { Code = b105 };
            HChar c106 = new HChar() { Code = b106 };
            HChar c107 = new HChar() { Code = b107 };
            HChar c108 = new HChar() { Code = b108 };
            HChar c109 = new HChar() { Code = b109 };
            HChar c110 = new HChar() { Code = b110 };
            HChar c111 = new HChar() { Code = b111 };
            HChar c112 = new HChar() { Code = b112 };
            HChar c113 = new HChar() { Code = b113 };
            HChar c114 = new HChar() { Code = b114 };
            HChar c115 = new HChar() { Code = b115 };
            HChar c116 = new HChar() { Code = b116 };
            HChar c117 = new HChar() { Code = b117 };
            HChar c118 = new HChar() { Code = b118 };
            HChar c119 = new HChar() { Code = b119 };
            HChar c120 = new HChar() { Code = b120 };

            //72 101 108 108 111 32 87 111 114 108 100 
            Console.WriteLine(c72.ToChar() + "" + c101.ToChar() + c108.ToChar() + c108.ToChar() + c111.ToChar() + c32.ToChar() + c87.ToChar() + c111.ToChar() + c114.ToChar() + c108.ToChar() + c100.ToChar());
            Console.ReadLine();
        }

        public static string FixString(string s, int length)
        {
            return s.Length < length ? FixString("0" + s, length) : s;
        }

    }

    class HChar
    {
        private HByte code;

        public HChar()
        {
            code = new HByte();
        }

        public HByte Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public char ToChar()
        {
            return (char)Convert.ToUInt32(code + "", 2);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }

    struct Bit
    {
        private bool state;

        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public override string ToString()
        {
            return state ? "1" : "0";
        }
    }

    class Nybble
    {
        private Bit[] bits;

        public Nybble()
        {
            bits = new Bit[4];
        }

        public Bit[] Bits
        {
            get
            {
                return bits;
            }
            set
            {
                bits = value;
            }
        }

        public static Nybble Parse(string s)
        {
            s = Program.FixString(s, 4);

            Nybble n = new Nybble();

            for (int i = 0; i < 4; i++)
            {
                n.bits[i].State = s[i] == '1';
            }

            return n;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Bit b in bits)
            {
                sb.Append(b + "");
            }

            return sb + "";
        }
    }

    class HByte
    {
        private Nybble[] nybbles;

        public HByte()
        {
            nybbles = new Nybble[2];
        }

        public Nybble[] Nybbles
        {
            get
            {
                return nybbles;
            }
            set
            {
                nybbles = value;
            }
        }

        public static HByte SetAsByte(byte b)
        {
            var hb = new HByte();
            hb.Nybbles[0] = Nybble.Parse(Convert.ToString((byte)(b << 4) >> 4, 2));
            hb.Nybbles[1] = Nybble.Parse(Convert.ToString((b >> 4), 2));
            return hb;
        }

        public static HByte Parse(string s)
        {
            s = Program.FixString(s, 8);
            var hb = new HByte();
            for (int i = 0; i < 2; i++)
                hb.Nybbles[i] = Nybble.Parse(s.Substring(i * 4, 4));
            return hb;
        }

        public override string ToString()
        {
            return nybbles[0] + "" + nybbles[1];
        }
    }
}
