# EDI Unpacking Macro for Notepad++
Add to shortcuts.xml in the user's AppData folder
 * In Explorer: %AppData% + Enter.
 * Find Notepad++ folder
 * Find shortcuts.xml file
 * IF "Macros" node exists, add the contents of the "Macro" subnode.
 * IF "MACROS" does not exist, copy the entire node to this location:
 
<NotepadPlus>
	<InternalCommands />
	<Macros>
	...
	</Macros>
	<UserDefinedCommands>
		...
	</UserDefinedCommands>
</NotepadPlus>

# About Me
**Sandro Pereira** | [DevScope](http://www.devscope.net/) | MVP & MCTS BizTalk Server 2010 | [https://blog.sandro-pereira.com/](https://blog.sandro-pereira.com/) | [@sandro_asp](https://twitter.com/sandro_asp)