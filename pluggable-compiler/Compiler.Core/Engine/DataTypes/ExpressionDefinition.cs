﻿using Compiler.Core.Expression;
using System;

namespace Compiler.Core.Engine
{
    public class ExpressionDefinition: ILexicalDefinition<IExpression>
    {
        public ExpressionDefinition(IGrammar<IExpression> grammar, int priority)
        {
            PartialGrammar = grammar;
            Priority = priority;
        }

        public IGrammar<IExpression> PartialGrammar { get; }
        public int Priority { get; }
    }
}