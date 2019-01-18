# The Pimped Rose

In this kata you are learning ways to extend a system while changing the existing
code as little as posible. The technique we will focus on is called Embellish and
we will use the pattern Functor and Applicative from Functional Programing and
Category Theory. We will not use Monads, even tough that is also something that
is part of the Embellish technique

# The code

The codebase have multiple source files with code you are not alowed to change.
You may create as many source files you like, but dont replace functionality 
that already exists. You are allowed to change the main.py file and write tests
for it if you like.

# Embellishing

## Why

When you need to add functionality to diferent types of data that also need to be
perpetual, carrying beyond the original value. Then embellishing a type with
new functionality could be a good way to introduce new functionality and
abstractions.

## How

### Functors as containers

In the simplified model of Functors we will use they act as a container, a
container with extra information.


Excusing the verbose type annotation in python you get this:

``` python
from __future__ import annotations
from typing import TypeVar, Generic

F = TypeVar('F')
T = TypeVar('T')
FunctorType = TypeVar('FunctorType', bound='Functor')

class Functor:
    """
    >>> functor.map(str)
    '42'
    """
    def map(self: FunctorType[F], f: Callable[[F], T]) -> FunctorType[T]:
        pass
```

A container that can take any Callable that takes one argument of the containd
type and then returns a new value. This letts the Functor preserve structure and
lets you reuse code that don't know about your Functor.

### Applicatives more power

Applicative is used when you not only have Embellished values but Embellished
Callables. Which most often you have because you whant to use functions that
takes more then one argument. it may also make code look nicer since it
naturally move the called value to the left of its arguments, in
Object Oriented Code in Functional its to the left in both cases.
 
``` python
from __future__ import annotations
from typing import TypeVar, Generic

F = TypeVar('F')
T = TypeVar('T')
AppType = TypeVar('AppType', bound='Applicative')

class Applicative:
    """
    >>> applicative.ap("Hello").ap("World")
    """
    def ap(self: AppType[Callable[[F],T]], from: AppType[F]) -> AppType[T]:
        pass
```

In the code above T might it self be a Callable and therefore we may chain
calls to ap to apply arguments to the result.

Bonus points to write a more pythonic version using `*` on the from argument to
chain calls on none-curried functions.

# Welcome to The pimped rose

We have hierd you to add a extention to oure system, pimp it a bit.

The update method was sold to the goblin in the cornser and he has also
implemented the new reporing system s you are not allowed to change those 
parts of the system