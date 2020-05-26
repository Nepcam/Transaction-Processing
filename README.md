# Transaction-Processing

A file containing info of some of the unique weapons in the game.

The transaction file contains the following information:
Weapon Name (string)
Weapon Type (string)
Damage (int)
Weapon Speed (double)

To tell if one weapon is better than another you need to know the Damage Per Second (DPS) the weapon does, since weapons have a
different attack speed. DPS is calculated by taking the damage value and dividing it by the attack speed.

Writing an application that will allow the gamer to load the file and display the weapon info and DPS of every weapon in the
input file. When the user chooses to open a weapon file, they are required to choose the file using the open file dialog window. It will then read
in the 4 values about a particular weapon and then display the 4 values to the console window on one line neatly padded along
with the DPS of the weapon. This is repeated until the end of the file.

Once the file has been processed, display a message to the user and also say how many weapons were processed.
