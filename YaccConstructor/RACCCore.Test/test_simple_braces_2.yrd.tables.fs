//this tables was generated by RACC
//source grammar:..\Tests\RACC\claret\braces_2\test_simple_braces_2.yrd
//date:3/21/2011 14:36:06

#light "off"
module Yard.Generators.RACCGenerator.Tables_claret_2

open Yard.Generators.RACCGenerator

type symbol =
    | T_RBR
    | T_LBR
    | NT_start
    | NT_raccStart
let getTag smb =
    match smb with
    | T_RBR -> 4
    | T_LBR -> 2
    | NT_start -> 1
    | NT_raccStart -> 0
let getName tag =
    match tag with
    | 4 -> T_RBR
    | 2 -> T_LBR
    | 1 -> NT_start
    | 0 -> NT_raccStart
let private autumataDict = 
dict [|(0,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 1);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbS 0))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 0))|]
|];
   ToStateID   = 2;
}
|];
}
);(1,{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,(State 3));(4,DummyState);(5,DummyState)|];
   DStartState   = 1;
   DFinaleStates = Set.ofArray [|0;1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol 2);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TClsE 1));(FATrace (TSeqE 6))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TSeqS 5));(FATrace (TSmbS 2))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 0;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TClsE 1));(FATrace (TSeqE 6))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TSeqS 5));(FATrace (TSmbS 2))|]
|];
   ToStateID   = 4;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol 2);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 6));(FATrace (TClsS 1));(FATrace (TClsE 1));(FATrace (TSeqE 6))|]
;List.ofArray [|(FATrace (TSeqS 6));(FATrace (TClsS 1));(FATrace (TSeqS 5));(FATrace (TSmbS 2))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 6));(FATrace (TClsS 1));(FATrace (TClsE 1));(FATrace (TSeqE 6))|]
;List.ofArray [|(FATrace (TSeqS 6));(FATrace (TClsS 1));(FATrace (TSeqS 5));(FATrace (TSmbS 2))|]
|];
   ToStateID   = 5;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol 3);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 3;
   Symbol      = (DSymbol 4);
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSmbS 4))|]
|];
   ToStateID   = 0;
}
|];
}
)|]

let private gotoSet = 
    Set.ofArray [|((0, 0, 1), set [(0, 1)]);((0, 0, 2), set [(1, 2)]);((1, 0, 2), set [(1, 2)]);((1, 1, 2), set [(1, 2)]);((1, 2, 3), set [(1, 3)]);((1, 3, 4), set [(1, 0)])|]
    |> dict
let tables = { gotoSet = gotoSet; automataDict = autumataDict }

