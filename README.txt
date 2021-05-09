Made by alexng353

rcloneapp, iteration 3

You need rclone (https://rclone.org) and winfsp (http://www.secfs.net/winfsp/) to use this app

EDIT THE PROGRAM BEFORE BUILDING SMH

Note: This entire app was made because I was too lazy to type in a command. Simple problem, overly complex solution. This is how we roll.

If you want to use this app or make changes, go clone the repo and make edits to "Gobals.cs"

The variables you want to change are the same as the configs you want to mount

If the remotes you want to mount are "dog", "cat", "fish", your file would look like:

public static string[] configs = { "dog", "cat", "fish" };

var configs = new Dictionary<int, ConfigNames>()
			{
				{ 111, new ConfigNames { Config="dog", Letter="Z" } },
				{ 112, new ConfigNames { Config="cat", Letter="X" } },
				{ 113, new ConfigNames { Config="fish", Letter="R" } },
			};