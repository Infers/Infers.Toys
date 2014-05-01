﻿#if FSHARP_NON_INTERACTIVE
namespace Infers
#endif

open System

/// A type that has the `InferenceRules` attribute is assumed to contain
/// inference rule methods that are used by the inference engine.
type InferenceRules () = inherit Attribute ()

/// A type that has the `RecursionRules` attribute is assumed to contain a
/// number of special methods (see `RecFun` type for an example) that the
/// inference engine uses to tie cycles.
type RecursionRules () = inherit Attribute ()

// BTW, higher-kinded polymorphism would be really nice here.  It would allow
// giving an actual interface/type for recursion rules.  Alas, there is no such
// thing in F# so we will use the reflection loophole.
