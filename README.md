# The Pimped Rose

In this kata you are learning ways to extend a system while changing the existing
code as little as possible. The technique we will focus on is called Embellish and
we will use the pattern Functor and Applicative from Functional Programing and
Category Theory. We will not use Monads, even tough that is also something that
is part of the Embellish technique

# The code

The codebase have multiple source files with code you are not allowed to change.
You may create as many source files you like, but don't replace functionality 
that already exists. You are allowed to change the main.py file and write tests
for it if you like.

# Welcome to The pimped rose

We have hired you to add a extension to our system, pimp it a bit.

The update method was sold to the goblin in the corner and he has also
implemented the new reporting system so you are not allowed to change those 
parts of the system.

The system is hold together with a event driven Enterprise Service Bus which is
very dynamic, and the event payloads type is generic and may be changed.

What we want is that the report file name should include what date the data was
taken from the database. There is no grantees that one report will finnish
before the next database request will start, so you can't solve the issue just by
adding a local member to the event handler instance.

# Embellishing

## Why

When you need to add functionality to different types of data that also need to be
perpetual, carrying beyond the original value. Then embellishing a type with
new functionality could be a good way to introduce new functionality and new
abstractions.

## How

### Functors as containers

We will use a simplified model of Functors where they act as a container, a
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

A container that can take any Callable that takes one argument of the contained
type and then returns a new value. This lets the Functor preserve structure and
lets you reuse code that don't know about your Functor.

### Applicatives, more power

Applicative is used when you not only have Embellished values but Embellished
Callables. Which most often you have because you want to use functions that
takes more then one argument. It may also make code look nicer since it
naturally move the called value to the left of its arguments.
 
``` python
from __future__ import annotations
from typing import TypeVar, Generic

F = TypeVar('F')
T = TypeVar('T')
AppType = TypeVar('AppType', bound='Applicative')

class Applicative:
    """
    >>> applicative.ap("Hello").ap("World")
    'Hello World'
    """
    def ap(self: AppType[Callable[[F],T]], from: AppType[F]) -> AppType[T]:
        pass
```

In the code above T might it self be a Callable and therefore we may chain
calls to ap to apply arguments to the result.

Bonus points to write a more pythonic version using `*` on the from argument to
chain calls on none-curried functions.
