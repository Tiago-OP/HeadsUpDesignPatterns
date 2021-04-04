# SymUduck

The **Strategy Pattern** defines a family of algorithms,
encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from
clients that use it.

**Design Principle:**
	Favor composition over inheritance


Family of algorithms - types of behaviours
Behaviour encapsulated inside the abstract class
Those behaviours are set by the consumer, allowing flexibility. 


This give us flexibility to change the behaviour dynamically, to add new behaviours without breaking old ones.

*Still what happens when a duck does not contain certain behaviour?*