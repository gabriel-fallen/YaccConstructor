//this file was generated by RACC
//source grammar:..\Tests\RACC\claret\braces_2\test_simple_braces_2.yrd
//date:3/21/2011 14:36:06

module RACC.Actions_claret_2

open Yard.Generators.RACCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let start0 expr = 
    let inner  = 
        match expr with
        | RESeq [x0] -> 
            let (cntList) =
                let yardElemAction expr = 
                    match expr with
                    | REClosure(lst) -> 
                        let yardClsAction expr = 
                            match expr with
                            | RESeq [_; racc_x0; _] -> 

                                let (racc_x0) =
                                    let yardElemAction expr = 
                                        match expr with
                                        | RELeaf start -> (start :?> _ ) 
                                        | x -> getUnmatched x "RELeaf"

                                    yardElemAction(racc_x0)

                                (racc_x0 )
                            | x -> getUnmatched x "RESeq"

                        List.map yardClsAction lst 
                    | x -> getUnmatched x "REClosure"

                yardElemAction(x0)
            ( cntList.Length + List.sum cntList )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(1,start0)|]

