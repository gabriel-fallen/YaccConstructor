//this tables was generated by GNESCC
//source grammar:../../../Tests/GNESCC/test_cls/test_cls.yrd
//date:8/5/2011 19:10:21

module Yard.Generators.GNESCCGenerator.Tables_cls

open Yard.Generators.GNESCCGenerator
open Yard.Generators.GNESCCGenerator.CommonTypes

type symbol =
    | T_MULT
    | NT_s
    | NT_gnesccStart
let getTag smb =
    match smb with
    | T_MULT -> 5
    | NT_s -> 4
    | NT_gnesccStart -> 2
let getName tag =
    match tag with
    | 5 -> T_MULT
    | 4 -> NT_s
    | 2 -> NT_gnesccStart
    | _ -> failwith "getName: bad tag."
let prodToNTerm = 
  [| 1; 0 |];
let symbolIdx = 
  [| 1; 2; 1; 3; 0; 0 |];
let startKernelIdxs =  [0]
let isStart =
  [| [| true; true |];
     [| false; false |];
     [| false; false |]; |]
let gotoTable =
  [| [| Some 1; None |];
     [| None; None |];
     [| None; None |]; |]
let actionTable = 
  [| [| [Shift 2]; [Error]; [Reduce 1] |];
     [| [Error]; [Error]; [Accept] |];
     [| [Shift 2]; [Error]; [Reduce 1] |]; |]
let tables = 
  {StartIdx=startKernelIdxs
   SymbolIdx=symbolIdx
   GotoTable=gotoTable
   ActionTable=actionTable
   IsStart=isStart
   ProdToNTerm=prodToNTerm}
