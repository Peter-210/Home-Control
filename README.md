# b1-homecontro                              HELLO WORLD :)
CPS613 B1 HomeControl

## Important Links
- [LucidChart](https://lucid.app/lucidspark/4b8fc4b1-abc0-4abf-9769-1b0978ebfc84/edit?invitationId=inv_74ba2d42-f8d9-4874-9b93-52069cd42214)
- [Google Jamboard](https://jamboard.google.com/d/1cF7XYjnwp3ZPJO0rZxdQZ7a4nFg_WPN9QUciQLE0zNA/edit?usp=sharing)
- [Google Drive](https://drive.google.com/drive/folders/1UiYetPUWcP1XS6t3Ko_AtyucTNA3yGL4?usp=share_link)

## Setup to Extract Latest Copy of <Main> branch
This first time, once-only operation is needed to setup your directory to be github-ready on your local machine. Once you are inside the directory you want to copy these repo files over into, copy and paste each command below in this sequential order in your terminal:
| Command  | Explanation  | 
|---|---|
| `git init`  | Initializes the git setup within your current directory in the command terminal  |  
| `git remote add origin https://github.com/t10le/b1-homecontrol.git`  |  Adds this specific repo to your git setup you did previously within your current directory |  
|  `git remote` | Shows a list of remote branches that you added recently. Make sure you see 'origin'  |
|`git branch`| Shows a list of local branches on your current directory in command terminal |
|`git pull origin main`| Fetches/Downloads/Copies all the files within the remote branch you specified, in this case, 'origin' |

## The 5 commands you will use 90% of the time in the workforce.
**Note: Always Pull the latest copy of main into your branch BEFORE you start work. Otherwise, you will have a merge conflict.** 
<br>When you're done modifying or adding new files/code, and are ready to submit to our main finalized version of the project, copy and paste each command below in this sequential order in your terminal:
| Command  | Explanation  | 
|---|---|
|`git pull origin main`| Fetches/Downloads/Copies all the files within the remote branch you specified, in this case, 'origin'. We do this to make sure we always have the latest copy before pushing in our changes to avoid merge conflicts |
| `git add .`  | Add ALL modified files/lines of code to the git clipboard  | 
|`git status`| Shows a list of modified files; check to make sure nothing redundant is being added|
|`git commit -m 'i added a button.'`| Confirms your git clipboard of modified files with a status log message |
|`git push`| Paste/Push your confirmed modified files into the remote repo and branch|
