Changes in Stockclass

- Made it include stocktype
- Made it inclue quantity
- Removed ID because the id it set by the database
- Changed quantity to integer because you cant have half of a stock
- Changed price to decimal so its compatible with the databases "currency" format

Notes

Show Stock Record only works with a hardcoded number
Edit stock record doesn't currently work

Added the ability to search stock using its name to determine its stock_no

Add record works flawlessly

I'll continue to work on this over the next few days.

There are 2 versions of the database, one in the PHPSolution folder and one in the debug/bin folder.
If the database is set to copy in the solution explorer the database will overwrite the one in dubug/bin,
making it appear as though you're having no effect on the database.

There are also updates to git I haven't seen yet and I haven't though of integrating yet.



If you have any issues with how i've done things please raise athem and i will consider them to the best of my ability.