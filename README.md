Ethekwini Municipal Services

        Current Version: 3.0
-----------------------------------------------------------------------------------------------------------------------------------------
HARDWARE REQUIREMENTS

    -1.8 GHz or faster processor. Quad-core or better recommended
    -2 GB of RAM; 8 GB of RAM recommended (2.5 GB minimum if running on a virtual machine)
    -Hard disk space: Minimum of 800MB up to 210 GB of available space, depending on features installed; typical installations require 20-50 GB of free space.
    -Hard disk speed: to improve performance, install Windows and Visual Studio on a solid state drive (SSD).
    -Video card that supports a minimum display resolution of 720p (1280 by 720); Visual Studio will work best at a resolution of WXGA (1366 by 768) or higher.
-----------------------------------------------------------------------------------------------------------------------------------------
INSTALLATION

         -To run this program, you would need to have installed Microsoft Visual Studio Community Edition 2019 v16.6.3 or later releases
         -After Visual Studio's installation is complete, open the project in:
         - Users > source >repos
         -Open the .sl file
         -After the project has loaded, click on start (The green play button)
         -This will run the .exe file

-----------------------------------------------------------------------------------------------------------------------------------------
PROGRAM DESCRIPTION

    This C# .NET Framework Windows Application is designed to allow citizens to engage with their local municipality by reporting issues and service requests efficiently. The application aims to enhance user interaction and improve communication between residents and municipal authorities, focusing on citizen participation in municipal services. The application is particularly tailored for the South African context, incorporating relevant user engagement strategies to foster civic involvement.

-----------------------------------------------------------------------------------------------------------------------------------------                     
How the Program works

  When the program starts, the user will encounter a menu with the following items:
     
    [1] Report Issue
    [2] Local Events and Announcements(To be Implemented)
    [3] Service Request Status(To be Implemented)
    [4] Feedback Portal
   The user will access a feature of the program by entering the number associated with each feature.
   
   **Report Issue**
   
  Enter Issue Location
        
      Issue Location: Enter the specific location where the issue was identified. This could be a physical location or a specific section within a facility.
  Select the Category

    Category Dropdown: Click on the dropdown menu under "Category" to select the type of issue. The example shows "Sanitation" as a preselected option. Choose the category that best describes the issue you are reporting.
  Describe the Issue

    Description Box: Click in the text box under "Type your issue here..." and provide a detailed description of the issue. Be as specific as possible, including what happened, when, and any other relevant details that might help in resolving the issue.
Upload Supporting Image file

    Click on the “BROWSE” button under "Upload File Here".
    A file dialog will open. Navigate to the location on your computer where the relevant file is saved.
    Select the file and click “Open” to attach it to your report. This could be a photo, a document, or another file type that supports your issue description.
Submit the Report

    Once all fields are filled, click the “SUBMIT REPORT” button to submit your report.
Step 7: Additional Option

    Return to Menu: If you need to navigate away without submitting the report, you can click the “RETURN TO MENU” button to go back to the main menu of the application.

**Feedback Portal**

Select Your Satisfaction Level

    Radio Buttons for Feedback: Look at the question "How do you feel about our system?" and choose the appropriate radio button to reflect your feelings about the system. The options are:
    [1]Horrible
    [2]Bad
    [3]Neutral
    [4]Good
    [5]Amazing
    Click the circle next to the description that best matches your sentiment.
Provide Detailed Feedback

    Feedback Text Box: Below the radio buttons, there is a large text box with the prompt "Please provide suggestions on how to improve our system?"
    Click inside this box and type your feedback or suggestions for improvement. Be as detailed as possible to help the developers understand your perspective and needs.
Submit Your Feedback

    Submit Button: Once you have selected your satisfaction level and entered your suggestions, click the “SUBMIT FEEDBACK” button at the bottom of the form..

Additional Option
    
    Return to Menu: If you wish to return to the main menu without submitting feedback, click the “RETURN TO MENU” button. This will take you back to the main navigation area of the application without submitting your inputs.
  
-----------------------------------------------------------------------------------------------------------------------------------------
Implementation Details
 
        The Binary Search Tree (BST) implementation centres around a root node that maintains references to its left and right child nodes. Each node within the structure contains an Issue object and adheres to the fundamental BST property: the left subtree contains nodes with IDs less than the parent node's ID, while the right subtree contains nodes with IDs greater than the parent node's ID.
        (GeeksForGeeks, 2022)into smaller BSTs at each level. It ensures that inorder traversal of the tree produces the keys in sorted order, making it a highly efficient structure for ordered data operations like search, insertion, and deletion (GeeksForGeeks, 2024).
Efficiency Contributions

                Insertion operations maintain an average case complexity of O(log n), where new issues are inserted based on their ID values. The recursive AddToIssuesTree method ensures proper placement within the structure while maintaining a balanced structure for efficient access. Similarly, search operations also achieve O(log n) average case complexity, with the FindIssue method implementing efficient binary search techniques. This approach is particularly effective for large datasets as it reduces the search space by half at each step of the process (GeeksForGeeks, 2024).
                Insertion operations in a Binary Search Tree (BST) maintain an average case time complexity of O(log⁡n)O(\log n)O(logn), assuming a balanced tree structure. This efficiency stems from the BST property, which systematically reduces the search space for determining the correct placement of new nodes. When inserting a new issue, the AddToIssuesTree method follows these principles:
                1.	Binary Decision Path:
                During insertion, the algorithm checks the new issue's ID to the current node's ID. Depending on whether the new ID is smaller or larger, the algorithm moves to the left or right subtree. This binary decision cuts the search space in half at each level, which contributes to logarithmic efficiency in the average scenario. (GeeksForGeeks, 2024)
                2.	Localized Changes:
                Insertions only change the tree structure at one branch, leaving the rest of the tree unchanged. This localised operation minimises interruption while preserving the BST's efficiency for future searches and insertions (GeeksForGeeks, 2022).
                3.	Efficient Memory Utilization:
                Unlike array-based solutions, which may necessitate expensive resizing and shifting operations, a BST dynamically allocates memory only for the nodes being inserted. This characteristic makes it ideal for systems dealing with huge, dynamic datasets where scalability is critical (GeeksForGeeks, 2022).
                4.	Scalability with Large Datasets:
                For large datasets, the logarithmic insertion process significantly outperforms linear alternatives like unsorted lists or arrays. The structured approach reduces computational overhead, making BSTs ideal for programs where frequent insertions are coupled with real-time search requirements (GeeksforGeeks, 2024).
        
        2. List Data Structure
        
Implementation
         
        Efficiency Contributions
        Dynamic sizing is a key feature that automatically handles varying numbers of service requests. This eliminates the need for manual memory management and provides efficiency for iterations and LINQ operations. Additionally, the GetIssuesFromTree functionality performs in-order traversal, which maintains the sorted order of issues by ID. This traversal process has an O(n) time complexity for full traversal of the data structure. 
        3. Issue Class Structure
        Implementation
         
        Efficiency Contributions
        Property encapsulation is implemented through auto-implemented properties that provide clean access to data. The system achieves efficient memory usage through proper data typing, while also facilitating easy serialization and deserialization of objects (GeeksForGeeks, 2022).
        4. Filtering Mechanisms
        Implementation
         Efficiency Contributions
        1.	LINQ integration enables efficient filtering through specialized LINQ methods. Through lazy evaluation, the system prevents unnecessary iterations, while simultaneously maintaining code that is both readable and maintainable.
        2.	Binary Search Implementation
          The system implements efficient O(log n) search functionality for priority-based queries, specifically optimized for sorted data sets. This approach significantly reduces search time compared to traditional linear search methods (Bazmi, 2024).

------------------------------------------------------------------------------------------------------------------------------------------
FREQUENTLY ASKED QUESTIONS

1) Should I encounter an error, what should I do?

        -Contact the programmer at: ST10229540@vcconnect.edu.za for support
2) Will I lose all my data if I close the program?
       
       -At the moment, yes it would be possible to lose all recorded data should the .exe file close

3) How many image files can be uploaded at a time?

        -Only one image file per report can be submitted.
-----------------------------------------------------------------------------------------------------------------------------------------
CONTACT THE DEVELOPER: Fisokuhle Mkhize
        
        Email: ST10229540@vcconnect.edu.za
        Contact no: 012 345 6789
-----------------------------------------------------------------------------------------------------------------------------------------
PLUGINS & FRAMEWORKS USED
                
         xml version:1.0 
         encoding:utf-8
         supportedRuntime version: 4.0 
         .NETFramework Version: 4.7.2
-----------------------------------------------------------------------------------------------------------------------------------------
Code Attributions

-Book used:
               
               -Andrew Troelsen, P. J., 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. s.l.:Apress Publishing.
----------------------------------------------------------------------------------------------------------------------------------------
Changes made from part 1 and part 2

Migrated from using Dictionaries to using BST
----------------------------------------------------------------------------------------------------------------------------------------
Link to repository

        -https://github.com/VCWVL/prog7312-part-1-FisokuhleM.git
