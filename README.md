# DesignPatternsComposite
This is a demo for the Composite Design Parttern using C# to allocate a resouce to a tree structure.

As described by Gof:
"Compose objects into tree structure to represent part-whole hierarchies.Composite lets client treat individual objects and compositions of objects uniformly".
Composite design pattern treats each node in two ways-Composite or leaf.Composite means it can have other objects below it.leaf means it has no objects below it.

This demo deals with the allocation of a set of gold coins to various participants who can act as individuals or who are part of a group, which can be part of another group.  There is a difference in assigning resource to a group and then to the individuals which compose of this group. This is particularly relevant if the particitants have an arbitraty initial set of gold coins.  This was not taken into consideration by the original author : PluralSight Course - Design Pattern Library 2015

The program has been properly refactored and implemented in the CompositeRefactoredDemo2 project.  
