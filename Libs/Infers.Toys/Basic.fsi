// Copyright (C) by Vesa Karvonen

namespace Infers.Toys

[<AutoOpen>]
module Basic =
  open Infers

  /// Equality: `Eq<'x, 'y>` is derivable when `'x` unifies with `'y`.
  type Eq<'x, 'y>

  /// Ternary equality: `Eq<'x, 'y, 'z>` is equivalent to `And<Eq<'x, 'y>, Eq<'y,
  /// 'z>>`.
  type Eq<'x, 'y, 'z>

  /// Basic rules for logic programming: equality (`Eq<...>`) and disjunction
  /// (`Choice<...>`).
  type Basic =
    inherit Rules
    new: unit -> Basic

    static member Eq'2: unit -> Eq<'x, 'x>
    static member Eq'3: unit -> Eq<'x, 'x, 'x>

    static member Choice1Of2: 'x1 -> Choice<'x1, 'x2>
    static member Choice2Of2: 'x2 -> Choice<'x1, 'x2>

    static member Choice1Of3: 'x1 -> Choice<'x1, 'x2, 'x3>
    static member Choice2Of3: 'x2 -> Choice<'x1, 'x2, 'x3>
    static member Choice3Of3: 'x3 -> Choice<'x1, 'x2, 'x3>
