FSharper is an implementation of F# for ReSharper. It targets ReSharper 6.

## Requirements

What you need is:

* VS2010
* ReSharper 6 SDK (soon to be released)
* ReSharper 6 for testing

## Challenges

* F# is not fast enough in order to parse/lex F#. Sorry but it's true. Alternatives such as C++/CLI are being considered.
* Managed languages might not be the best idea to deal with F# in terms of performance. This concerns mainly issues regarding type inferencing.
* F# has an impedance mismatch with ReSharper. R# is basically all-OOP whereas F# isn't good at this, which results in all sorts of weirdness, such as returning `Unchecked.defaultof<>` values.
  We still need to connect the two at some point, 

## Opportunities

* F# is by itself pretty good once you get object models in place. For example, pattern matching is very relevant while analyzing code.
* F# project files always appear in order, which offers a potential performance advantage in terms of multithreaded parsing.
* It might be possible to take lexing and parsing off the CPU, letting it do some other R#-related work instead.