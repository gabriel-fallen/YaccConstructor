﻿//  Driver.fs contains entry point of MS-SQL parser.
//
//  Copyright 2012 Semen Grigorev <rsdpisuy@gmail.com>
//
//  This file is part of YaccConctructor.
//
//  YaccConstructor is free software:you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

module YC.ReSharper.AbstractAnalysis.Languages.TSQL

open Yard.Examples.MSParser
open LexerHelper
open System
open System.IO
open Yard.Generators.RNGLR.AST
open YC.AbstractAnalysis.CommonInterfaces
open YC.ReSharper.AbstractAnalysis.Plugin.Core
open YC.EL.ReSharper.Common
open Mono.Addins
open ReSharperExtension
open JetBrains.Application

let tokenize lexerInputGraph =
    let eof = Yard.Examples.MSParser.RNGLR_EOF("",[||])
    Lexer._fslex_tables.Tokenize(Lexer.fslex_actions_tokens, lexerInputGraph, eof)

let parser = new Yard.Generators.RNGLR.AbstractParser.Parser<_>()

let getTokenName = tokenToNumber >> numToString

let parse = fun parserInputGraph -> parser.Parse buildAstAbstract parserInputGraph

let args = 
    {
        tokenToRange = fun _ -> [||],[||]
        zeroPosition = [||]
        clearAST = false
        filterEpsilons = true
    }

let printAstToDot ast name = defaultAstToDot ast name

let xmlPath = xmlPath
let tokenToTreeNode = tokenToTreeNode
let translate ast errors = translate args ast errors

[<assembly:Addin>]
[<assembly:AddinDependency ("YC.ReSharper.AbstractAnalysis.Plugin.Core", "1.0")>]
do()

[<ShellComponent>]
[<Extension>]
type TSQLInjectedLanguageModule () =
    let processor = new Processor<Token,br,range,node>(tokenize, parse, translate, tokenToNumber, numToString, tokenData, tokenToTreeNode, "TSQL", calculatePos, getRange)

    interface IInjectedLanguageModule<br,range,node> with
        member this.Name = "TSQL"
        member this.Process graphs = processor.Process graphs
        member this.LexingFinished = processor.LexingFinished
        member this.ParsingFinished = processor.ParsingFinished
        member this.XmlPath = xmlPath
        member this.GetNextTree i = processor.GetNextTree i
        member this.GetForestWithToken rng = processor.GetForestWithToken rng

    interface IReSharperLanguage