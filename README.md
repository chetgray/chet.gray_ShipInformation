# ShipInformation

Requirements from #211868
> Use what we've learned about Abstract Classes to create a Console App
> that gives information on ships.
> - You'll want to have an abstract Ship base class.
>   - It should have a method called Move(). 
>     - This method should write to the Console that "The ship has started
>       to move."
>   - It should have a method called Stop().
>     - This method should write to the Console that "The ship has stopped."
>   - It should have a BlowHorn() method. This will be completely abstract,
>     as the implementation will be provided by each derived class.
> - You should have a class called CruiseShip that derives from Ship.
>   - When you blow the horn on the Cruise Ship, it should write
>     "WAAAAAAAAOOOOOOO!" the Console.
>   - When the Cruise Ship moves, it should first write "Starting all 112
>     engines" to the Console, then it should write the standard verbiage
>     from the base class.
>   - When the Cruise Ship stops, it should first write, "Stopping all
>     112 engines" to the Console, then it should write the standard
>     verbiage from the base class.
> - You should have a class called SailBoat that derives from Ship.
>   - When you blow the horn on the Cruise Ship, it should write "Toot!"
>     to the Console.
>   - When the Sail Boat moves, it should first write "Raising sails" to
>     the Console, then it should write the standard verbiage from the
>     base class.
>   - When the Sail Boat stops, it should first write, "Lowering sails"
>     to the Console, then it should write the standard verbiage from the
>     base class.
> - You should have a class called SkiBoat that derives from Ship.
>   - When you blow the horn on the Ski Boat, it should write "Beep!" to
>     the Console.
>   - When the Ski Boat moves, it should first write "Starting onboard
>     motor" to the Console, then it should write the standard verbiage
>     from the base class.
>   - When the Ski Boat stops, it should first write, "Stopping onboard
>     motor" to the Console, then it should write the standard verbiage
>     from the base class.
> - When the application starts, ask the user what type of ship they are
>   running. Their choices should be numbered 1, 2, and 3, for each ship
>   type.
> - When the user chooses their ship type, ask them "What is your command,
>   Captain?"
> - If the user enters "Move", run that ship's Move().
> - If the user enters "Stop", run that ship's Stop().
> - If the user enters "Blow Horn" or "Horn", run that ship's BlowHorn().
> - (The case the user enters the info. in shouldn't matter).
> - After running the method, again ask, "What is your command, Captain?"
> - If the user enters "Change Ship" or "Change" (in any case), ask them
>   what ship type they want again.
> - Keep going until the user enters "End" (in any case).