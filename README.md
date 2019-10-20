# Setup project (FIRST THING TO DO)

### Clone project

1. Go to whichever directory that you want to clone this project
2. Right click and open git bash
3. Enter the following line: `git clone https://github.com/ernchenghoo/CSharp.git`

### Download mysql connector and add to visual studio project reference
1. Go to https://dev.mysql.com/downloads/connector/net/6.10.html and download the ".NET & Mono" operating system version
2. Extract the download files to whichever location
3. In visual studio, right click "references" tag and click "Add Reference..."
4. Go to browse tab, and browse for the downloaded folder and enter the following path ./v4.5.2, add "MySql.Data.dll" as reference


# GitHub general commands

### Pushing changes to remote branch

1. Stage changes: `git add .`
2. Commit staged changes `git commit -m "commit message"`
3. Push commits to remote branch `git push origin "your branch name"`

### Create a new branch

`git checkout -b <branchName>`

### Delete a branch 

`git branch -d <branchName>`

## Check for unstaged local changes

`git status`
