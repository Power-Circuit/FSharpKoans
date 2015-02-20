﻿namespace FSharpKoans
open NUnit.Framework

(* This section isn't covered in the notes.
But it's pretty useful, so go through it :). *)

module MushroomKingdom = 
   type Power = 
      | None
      | Mushroom
      | Star
      | FireFlower
   
   type Character = 
      { Name : string
        Occupation : string
        Power : Power }
   
   let Mario = 
      { Name = "Mario"
        Occupation = "Plumber"
        Power = None }
   
   let powerUp character = { character with Power = Mushroom }

//---------------------------------------------------------------
// About Modules
//
// Modules are used to group functions, values, and types. 
// They're similar to .NET namespaces, but they have slightly 
// different semantics as you'll see below.
//---------------------------------------------------------------
module Modules = 
   [<Test>]
   let ``Modules can contain values and types`` () = 
      MushroomKingdom.Mario.Name |> should equal __
      MushroomKingdom.Mario.Occupation |> should equal __
      MushroomKingdom.Mario |> should be ofType<FILL_ME_IN>
   
   [<Test>]
   let ``Modules can contain functions`` () = 
      let superMario = MushroomKingdom.powerUp MushroomKingdom.Mario
      superMario.Power |> should equal __

// HEY!  You!  Yes, you.  Hi there :).
// Make sure your eyes don't skip over the next line of code, OK?
// It's an important line!
open MushroomKingdom // <-- IMPORTANT LINE!

module ``Opened modules`` = 
   [<Test>]
   let ``Opened modules bring their contents into scope``() =
      // Notice tham I'm *not* saying MushroomKingdom.whatever below.
      Mario.Name |> should equal __
      Mario.Occupation |> should equal __
      Mario.Power |> should equal __
