# GitHub Standards

> When pushing and commiting to GitHub I will be following these standards I set so that in the future once development has started, the GitHub is well organized for both future me and others viewing.

---

## Table of Contents
1. [Generic GitHub Standards](#generic-github-standards)
	1. [Commits](#commits)
	1. [Branch Structure](#branch-structure)
		1. [Indicators](#indicators)
		1. [When To Use a Branch](#when-to-use-a-branch)
1. [Workflow](#workflow)
	1. [New Features](#new-features)
	1. [Bug Fixing](#bug-fixing)


## Generic GitHub Standards

### <h3 style="color:#dad"> :memo: **Commits**
> [!NOTE]
> All commits will be lead by an emoji, following the [GitMoji](https://gitmoji.dev/) style.

1. All commits will have an accurate name to follow the changes made.
1. Commits will be kept to *single feature* additions, meaning that each commit should be one idea. *Like a sentence*.
1. Commits will follow what I call the 5 C's.
	1. **Clear:** Having the commit not intentially confusing.
	1. **Concise:** Having the commit message as small as possible.
	1. **Complete:** The commit message includes all items that were worked on. *Can overflow into the description to keep conciseness.*
	1. **Correct:** Having the commit message accurate to the changes made.
	1. **Consistent:** Having commit message structure the same between commits for ease of reading large swaths of commit names.

### <h3 style="color:#9bd"> :twisted_rightwards_arrows: Branch Structure

> [!IMPORTANT]
> All branches should be led by one of the indicators below to organize and explain where branches sit.

#### <h4 style="color:#dda"> :file_folder: Indicators
> [!NOTE]
> Indicators are ways to organize branches into "types" or folders.

- `feature/` -> This indicator should be used for when implementing a new feature or portion of the project. If the new portion requires code it should go here.
- `bugfix/` -> This indicator is specifically for fixing existing bugs found through testing. If the change is a modification of an existing feature it should go here.
- `design/` -> This indicator is for all artistic assets and sound effects that might be required for the project.
- `documentation/` -> This indicator is very specific for documenting the process and existing code. **If** documentation is forgotten while in the existing feature branch then a new branch should be made using this.

Example -> `feature/player-movement`

#### <h4 style="color:#ddd"> :grey_question: When To Use a Branch

Branches should be made for each unique idea. There might also be major branches that have sub-branches under them such as `feature/player` followed by the sub-branch `feature/player/player-movement` which is inherited from the first branch.

## Workflow

> [!NOTE]
> All work will be done on a branch separate to the development branch. This is to enforce good practices and ensure I do not push breaking code or need to revert 10 commits because a feature idea might be approached wrong.

### <h3 style="color:#ed9"> :sparkles: New Features

1. Break a feature in a number of ideas, "sentences"
1. Find leading ideas that require other ideas to work
1. Create those leading ideas into branches
1. Create sub-branches from the ideas
1. Work on changes and commit regularly
1. Push changes
1. If a feature is done, test it thouroughly
1. If it passes, open a pull request and merge into the parent branch

### <h3 style="color:#aea"> :bug: Bug Fixing

> [!IMPORTANT]
> Opening a bug report will use the *bug report* template on the GitHub Issues page.

If a bug is found on the **development** branch I will make an *Issue* of it on the GitHub for future me when I am ready to fix bugs.

I will also open the Issues to all that decides to recommend some new features or bugs.