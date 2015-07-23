﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageService.Formatting
{
    internal static class TokenRange
    {
        internal static readonly ImmutableArray<TokenType> AnyVisible =
            TokenRange.Fill(
                Enum.GetValues(typeof(TokenType)),
                new TokenType[] { TokenType.EndOfFile, TokenType.Unknown });

        internal static readonly ImmutableArray<TokenType> All =
            TokenRange.Fill(
                Enum.GetValues(typeof(TokenType)),
                new TokenType[] { });

        internal static readonly ImmutableArray<TokenType> BinaryOperators =
            ImmutableArray.Create
            (
                TokenType.AndBinop,
                TokenType.BitwiseAndOperator,
                TokenType.BitwiseLeftOperator,
                TokenType.BitwiseOrOperator,
                TokenType.BitwiseRightOperator,
                TokenType.EqualityOperator,
                TokenType.ExponentOperator,
                TokenType.FloorDivideOperator,
                TokenType.DivideOperator,
                TokenType.GreaterOrEqualOperator,
                TokenType.GreaterThanOperator,
                TokenType.LessOrEqualOperator,
                TokenType.LessThanOperator,
                TokenType.MinusOperator,
                TokenType.ModulusOperator,
                TokenType.MultiplyOperator,
                TokenType.NotEqualsOperator,
                TokenType.OrBinop,
                TokenType.PlusOperator,
                TokenType.StringConcatOperator,
                TokenType.TildeUnOp,
                TokenType.VarArgOperator
            );

        internal static readonly ImmutableArray<TokenType> Brackets = ImmutableArray.Create
        (
            TokenType.OpenBracket,
            TokenType.CloseBracket,
            TokenType.OpenCurlyBrace,
            TokenType.CloseCurlyBrace,
            TokenType.OpenParen,
            TokenType.CloseParen
        );

        internal static readonly ImmutableArray<TokenType> Value = ImmutableArray.Create(
            TokenType.Number,
            TokenType.String,
            TokenType.FalseKeyValue,
            TokenType.TrueKeyValue,
            TokenType.NilKeyValue,
            TokenType.Identifier,
            TokenType.FunctionKeyword
        );

        private static ImmutableArray<TokenType> Fill(Array values, TokenType[] exclude)
        {
            var tokenTypes = ImmutableArray.CreateBuilder<TokenType>(values.Length);

            foreach (TokenType tokenType in values)
            {
                if (exclude.Contains(tokenType))
                {
                    continue;
                }
                tokenTypes.Add(tokenType);
            }

            return tokenTypes.ToImmutable();
        }
    }
}
