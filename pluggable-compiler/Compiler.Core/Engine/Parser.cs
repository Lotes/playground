﻿using System.Collections.Generic;

namespace Compiler.Core.Engine
{
    public class Parser : IParser
    {
        public Parser()
        {

        }

        public IExpression ParseExpression(string input)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IStatement> ParseStatements(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}
