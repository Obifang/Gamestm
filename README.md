# Gamestm
Project for PHP inc. - Group GamesTM

18/04/2017

Database now supports sales, for more info look at "SQL Data.sql"

I also moved the tables at the bottom and added controllers to them, they are controlled by the controllers beneath them, they each have independant refresh buttons.

Search Sale has been implemented in a basic manner, in future stock names will be displayed aswell

ADD SALE DOES NOT WORK

EDIT SALE DOES NOT WORK

STILL NEED VALIDATION EVERYWHERE



17/04/2017

Need validation everywhere

Edit stock record works mostly flawlessly, its easy to break if the wrong data is entered

Added the ability to search stock using its name to determine its stock_no

Add record works flawlessly

Added a button to refesh the database at the bottom of the mainpage

Show Stock Record works flawlessly

The graph at the bottom will be removed for the final version, for now it assists with debugging

There are 2 versions of the database, one in the PHPSolution folder and one in the debug/bin folder.
If the database is set to copy in the solution explorer the database will overwrite the one in dubug/bin,
making it appear as though you're having no effect on the database.

There are also updates to git I haven't seen yet and I haven't though of integrating yet.

If you have any issues with how i've done things please raise athem and i will consider them to the best of my ability.

Changes in Stockclass

- Made it include stocktype
- Made it inclue quantity
- Removed ID because the id it set by the database
- Changed quantity to integer because you cant have half of a stock
- Changed price to decimal so its compatible with the databases "currency" format
