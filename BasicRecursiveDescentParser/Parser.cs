using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRecursiveDescentParser
{

    //<S> -> <A> <C>
    //<A> -> 'a' 'b'
    //<C> -> 'c'<C>
    //<C> -> 'd'
    public class Parser
    {
        private string m_Input;
        private int m_Current;

        public Parser(string input)
        {
            m_Input = input;
            m_Current = 0;
        }

        public void Parse()
        {
            S();
        }

        private void S()
        {
            A();
            C();
        }

        private void A()
        {
            Consume("a");
            Consume("b");
        }

        private void C()
        {
            if (m_Input[m_Current].ToString() == "c")
            {
                Consume("c");
                C();
            }
            else if (m_Input[m_Current].ToString() == "d")
            {
                Consume("d");
            }
            else
            {
                throw new InvalidOperationException("Cannot parse");
            }
        }

        private void Consume(string letter)
        {
            if(letter == m_Input[m_Current].ToString())
            {
                Advance();
            }
            else
            {
                throw new InvalidOperationException("Cannot parse");
            }
        }

        private void Advance()
        {
            m_Current += 1;
        }
    }
}
