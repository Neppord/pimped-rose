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

[Embellising]: Embellishing.md