﻿module Main.Program

open Yard.Core
open Yard.Core.IL

//TODO: move it to ConvertionManager
let ApplyConvertion (ilTree:Definition.t<Source.t,Source.t>) (conv:IConvertion) = 
    {   new Definition.t<Source.t,Source.t>
        with info = ilTree.info
        and  head = ilTree.head
        and  grammar = conv.ConvertList ilTree.grammar
        and  foot = ilTree.foot
    }

let () =    
    let feName = ref "YardFrontend"
    let generatorName = ref "_RACCGenerator"

    let commandLineSpecs =
        ["-f", ArgType.String (fun s -> feName := s), "Frontend name"
//         "-c", ArgType.String (fun s -> 
         "-g", ArgType.String (fun s -> generatorName := s), "Generator name"
         ] |> List.map (fun (shortcut, argtype, description) -> ArgInfo(shortcut, argtype, description))
    let commandLineArgs = System.Environment.GetCommandLineArgs()
    ArgParser.Parse commandLineSpecs

    let grammarFilePath = @"..\..\..\..\Tests\test002.yrd"


    // Load frontends assemblies dlls - get them from file, current folder or command line
    let assembly = System.Reflection.Assembly.Load(!feName)
    let inst = assembly.CreateInstance("Yard.Frontends." + !feName+"." + !feName)
    FrontendsManager.Register(inst :?> IFrontend);

    // Load generator assemblies dlls - get them from file, current folder or command line
    let assembly = System.Reflection.Assembly.Load(!generatorName)
    let inst = assembly.CreateInstance("Yard.Generators." + !generatorName+"." + !generatorName)
    GeneratorsManager.Register(inst :?> IGenerator);

    
    // Parse grammar
    let ilTree = (FrontendsManager.Frontend !feName).ParseGrammar grammarFilePath
   // let ilTree = (FrontendsManager.Frontend feName).ParseGrammar grammarFilePath

    // Apply convertions
    let ilTreeExpandedMeta = ApplyConvertion ilTree (new Yard.Core.Convertions.ExpandMeta.ExpandMeta())

    // Generate something
    let gen = GeneratorsManager.Generator(!generatorName)
    let s = gen.Generate (ilTree) // дерево передается без конвертации для FParsecGenerator

    //Run tests
  //  let tester = Yard.Generators.RecursiveAscent.RACCTester((*s :?> _*))
  //  let s = tester.RunTest 
    printf "file Name \n %A \n" <| System.IO.Path.ChangeExtension(ilTree.info.fileName,".fs")

