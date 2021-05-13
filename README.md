# phantom-phenom
BulkFileConfigGenerator Notes
Prior to April 2021
- Decided to use a Windows Form for various reasons:
    - This tool will require manual entry by the user, so it might be easier to have a lot of Text fields. 
    -  fields can be turned "on and off" with a multiple choice selection
    - I want the end result to spit out something to a text field so it can be copied and pasted into the Bulk File Config
- Began with a checkedList for the bulk files the user can select. User can select multiple files
- Next I added Text fields to enter the Remote Directory and Local Directory manually. This will be reproduced for each file selected in the checkedList
- btnClick_Click: Submit button to return the results of the checkbox entry and text fields

Issues after this first iternation
- Selecting multiple items in the checkList only returns the last item selected. I need it to reproduce for each file selected
- The btnClick_Click result is returned on the same line. I'll need to format it to match the Bulk File Config box in Nexus

April 23, 2021
- Researched how to return multiple items in the checkList
- Thinking I need a case/switch that sets the file ID based on the file selected and plugs in the file name
- Going to start small and just have the selections returned

April 27, 2021
- Attempted to create a foreach in the btnClick_Click for the checkList. Only returned the last item checked again
- Was able to identify all Checked items using Items and GetItemChecked methods combined with a for loop.
- Successfully returned the results of the for loop to the btnClick_Click result
- Now I need to take each Item in the check list and return the actual config for that specific ID

April 30, 2021
 - Continued to add file IDs to btnClick_Click
 - Figured I should also move this work to a method. Named it getBulkFileIDs
 - Realized the for loop doesn't write out each item when selected. Added a while loop and created a StringBuilder to continue to add new strings based on the IDs checked
 - There is likely a way to simplify this so I don't have to write out so much fo the bulk file item string. Need to research

May 7, 2021
- Finished adding remaining Bulk File Items to getBulkFileIDs()
- Simplified getBulkFileIDs() by adding arguments that takes the number of checked items and two strings for the remote and local file names
- Simplifying the method will help me add a class for this later on
- I still think there is an easier way to print out each ID. I likely need one "standard" string and then toss in the variable information to it - then loop back and add another string with the relevant information. 

May 13, 2021
- checkedList automatically lists items alphabetically. I want them in a specific order. Will need to research
- Tried to simplify the string but I ran into issues setting variables using an if statement within a for loop. At the moment the output is what I want it to be so this can be put on hold for now
- Formatting the txtoutput. Set Multiline and WordWrap to true. For all objects, I adjusted the boundaries and location on the form for all objects
- Changes are small so I won't push to main branch yet
- 
