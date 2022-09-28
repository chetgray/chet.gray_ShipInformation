# ShipInformation

Requirements from #211868
> Use what we've learned about Abstract Classes to create a Console App
> that gives information on ships.
> - [x] You'll want to have an abstract Ship base class.
>   - [x] It should have a method called Move(). 
>     - [x] This method should write to the Console that "The ship has started
>       to move."
>   - [x] It should have a method called Stop().
>     - [x] This method should write to the Console that "The ship has stopped."
>   - [x] It should have a BlowHorn() method. This will be completely abstract,
>     as the implementation will be provided by each derived class.
> - [x] You should have a class called CruiseShip that derives from Ship.
>   - [x] When you blow the horn on the Cruise Ship, it should write
>     "WAAAAAAAAOOOOOOO!" the Console.
>   - [x] When the Cruise Ship moves, it should first write "Starting all 112
>     engines" to the Console, then it should write the standard verbiage
>     from the base class.
>   - [x] When the Cruise Ship stops, it should first write, "Stopping all
>     112 engines" to the Console, then it should write the standard
>     verbiage from the base class.
> - [x] You should have a class called SailBoat that derives from Ship.
>   - [x] When you blow the horn on the Cruise Ship, it should write "Toot!"
>     to the Console.
>   - [x] When the Sail Boat moves, it should first write "Raising sails" to
>     the Console, then it should write the standard verbiage from the
>     base class.
>   - [x] When the Sail Boat stops, it should first write, "Lowering sails"
>     to the Console, then it should write the standard verbiage from the
>     base class.
> - [x] You should have a class called SkiBoat that derives from Ship.
>   - [x] When you blow the horn on the Ski Boat, it should write "Beep!" to
>     the Console.
>   - [x] When the Ski Boat moves, it should first write "Starting onboard
>     motor" to the Console, then it should write the standard verbiage
>     from the base class.
>   - [x] When the Ski Boat stops, it should first write, "Stopping onboard
>     motor" to the Console, then it should write the standard verbiage
>     from the base class.
> - [x] When the application starts, ask the user what type of ship they are
>   running. Their choices should be numbered 1, 2, and 3, for each ship
>   type.
> - [x] When the user chooses their ship type, ask them "What is your command,
>   Captain?"
> - [x] If the user enters "Move", run that ship's Move().
> - [x] If the user enters "Stop", run that ship's Stop().
> - [x] If the user enters "Blow Horn" or "Horn", run that ship's BlowHorn().
> - [x] (The case the user enters the info. in shouldn't matter).
> - [x] After running the method, again ask, "What is your command, Captain?"
> - [x] If the user enters "Change Ship" or "Change" (in any case), ask them
>   what ship type they want again.
> - [x] Keep going until the user enters "End" (in any case).
