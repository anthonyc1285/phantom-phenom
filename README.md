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
- Now I need to take each Item in the check list and return the actual config

