//this file was generated by RACC
//source grammar:..\Tests\RACC\test_arithm_glr\test_arithm_glr.yrd
//date:3/21/2011 14:35:59

module RACC.Actions_Aritm_glr

open Yard.Generators.RACCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith

let value x = (x:>Lexeme<string>).value

let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [x0] -> 
            let (res) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf e -> (e :?> _ ) 
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(x0)
            (res)
        | x -> getUnmatched x "RESeq"
    box (inner)
let e1 expr = 
    let inner  = 
        match expr with
        | REAlt(Some(x), None) -> 
            let yardLAltAction expr = 
                match expr with
                | RESeq [x0] -> 
                    let (n) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf tNUMBER -> tNUMBER :?> 'a
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(x0)
                    (value n |> int)
                | x -> getUnmatched x "RESeq"

            yardLAltAction x 
        | REAlt(None, Some(x)) -> 
            let yardRAltAction expr = 
                match expr with
                | RESeq [x0; x1; x2] -> 
                    let (l) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf e -> (e :?> _ ) 
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(x0)
                    let (op) =
                        let yardElemAction expr = 
                            match expr with
                            | REAlt(Some(x), None) -> 
                                let yardLAltAction expr = 
                                    match expr with
                                    | RESeq [racc_x0] -> 
                                        let (racc_x0) =
                                            let yardElemAction expr = 
                                                match expr with
                                                | RELeaf tPLUS -> tPLUS :?> 'a
                                                | x -> getUnmatched x "RELeaf"

                                            yardElemAction(racc_x0)
                                        ( (+) )
                                    | x -> getUnmatched x "RESeq"

                                yardLAltAction x 
                            | REAlt(None, Some(x)) -> 
                                let yardRAltAction expr = 
                                    match expr with
                                    | REAlt(Some(x), None) -> 
                                        let yardLAltAction expr = 
                                            match expr with
                                            | RESeq [racc_x0] -> 
                                                let (racc_x0) =
                                                    let yardElemAction expr = 
                                                        match expr with
                                                        | RELeaf tMULT -> tMULT :?> 'a
                                                        | x -> getUnmatched x "RELeaf"

                                                    yardElemAction(racc_x0)
                                                ( ( * ) )
                                            | x -> getUnmatched x "RESeq"

                                        yardLAltAction x 
                                    | REAlt(None, Some(x)) -> 
                                        let yardRAltAction expr = 
                                            match expr with
                                            | RESeq [racc_x0] -> 
                                                let (racc_x0) =
                                                    let yardElemAction expr = 
                                                        match expr with
                                                        | RELeaf tMINUS -> tMINUS :?> 'a
                                                        | x -> getUnmatched x "RELeaf"

                                                    yardElemAction(racc_x0)
                                                ( (-) )
                                            | x -> getUnmatched x "RESeq"

                                        yardRAltAction x 
                                    | x -> getUnmatched x "REAlt"

                                yardRAltAction x 
                            | x -> getUnmatched x "REAlt"

                        yardElemAction(x1)
                    let (r) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf e -> (e :?> _ ) 
                            | x -> getUnmatched x "RELeaf"

                        yardElemAction(x2)
                    (op l r)
                | x -> getUnmatched x "RESeq"

            yardRAltAction x 
        | x -> getUnmatched x "REAlt"
    box (inner)

let ruleToAction = dict [|(2,e1); (1,s0)|]

