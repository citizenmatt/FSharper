module Module

let castAs<'T when 'T : null> (o:obj) = 
  match o with
  | :? 'T as res -> res
  | _ -> null