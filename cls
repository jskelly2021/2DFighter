[33mcommit 37dd25103f8458389717422ef21c741481c248d6[m[33m ([m[1;36mHEAD -> [m[1;32mGameManager[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jul 2 13:57:32 2024 -0500

    Cleaned up code by having the GameManager class act as a store of all services

[33mcommit b60b93f731b82af6e5a1265c23ee61dc6edcb8d7[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jul 2 13:43:30 2024 -0500

    LevelManager successfully loads and unloads scenes when asked

[33mcommit 9924b2fbfa6a2b7c0869e7754874008d00553aaf[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu Jun 27 16:18:07 2024 -0500

    Created a prefab of the managers

[33mcommit 4fa4952ef088b7a6f5f3de319060e3f169b2eaea[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu Jun 27 15:56:30 2024 -0500

    The game manager class exists as a singleton. Other objects can interact with it to gain access to the managers

[33mcommit 80c055c14ab486b3ffdbf2e06a989e11ac67024b[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu Jun 27 13:46:23 2024 -0500

    Created a manager scene that is always loaded. It loads and unloads scenes additively when needed

[33mcommit 1bff75c8dc7fa5d3c8902945791f294de5e2c72e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 26 17:05:09 2024 -0500

    Created a GameManager script and a preload scene to initialize the managers

[33mcommit 318f24716607c1c6f724e00f09300828f718a3c6[m[33m ([m[1;32mUI[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 25 14:39:12 2024 -0500

    Organized Scripts directory and editor hierarchy

[33mcommit 118312595316062934ae1fdc645ac97b3eaac913[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 25 13:17:22 2024 -0500

    Created an options menu that may open and close, but with no functionality

[33mcommit b40bcec3004175c0d8b78215bcfccf2731e91f24[m[33m ([m[1;31morigin/main[m[33m, [m[1;31morigin/UI[m[33m, [m[1;32mmain[m[33m)[m
Merge: 96a0ca3 8c84be3
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Tue Jun 25 11:18:46 2024 -0500

    Merge pull request #10 from jskelly2021/eventSystem
    
    Event system

[33mcommit 8c84be3da37e1de3f758ca39134e558409f0e18e[m[33m ([m[1;31morigin/eventSystem[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 25 11:15:47 2024 -0500

    All systems work with new Event system

[33mcommit 6f196d018363030daf9ee7b8913c94d1500abfbd[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 24 16:35:02 2024 -0500

    Double jump works properly for controller

[33mcommit 7af42a59ac71686332654bf9370cf2ff7e6f1fb7[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 24 16:24:13 2024 -0500

    Character now has the ability to double or triple jump

[33mcommit e63b3b0f205f0000b930d1b6cc16be3122fd823c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 24 11:10:17 2024 -0500

    After jumping, character return to idle state when hitting the ground

[33mcommit 3ed808f5b007e330f7537b0f612e3042e9ade392[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 24 10:45:56 2024 -0500

    Character now moves correctly when input is given

[33mcommit 392a1fe60595cf1f8e85f5c653d763eac35cc1c0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 23 15:14:43 2024 -0500

    Combat components now work with the new event system

[33mcommit 2c956934cec6ba91fe8e0ff89f78869b649d6b2f[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 23 15:08:36 2024 -0500

    Fixed animation components so they work with the new system

[33mcommit 39fe01bf9a7400018281ba85b26fc292a448afbd[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 23 15:00:57 2024 -0500

    Fixed all character States so they comply with the new event system

[33mcommit a58671540c2c04fe603808da2f1a3d362658cd68[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 23 14:09:25 2024 -0500

    Changed characterInfo back to CharacterBase

[33mcommit 15f66d14d96abfcc97325526c9406f35ae179c56[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 15:14:46 2024 -0500

    RunState now conforms to new systems

[33mcommit 7f6819c02b424b3ea906a0c12f07ebe2b4d015f6[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 15:06:28 2024 -0500

    Renamed characterStats to characterInfo to stand apart from characterStates

[33mcommit 5dde0f4ebf78e5c8be09b8881ff93d77344cb427[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 15:03:18 2024 -0500

    IdleState now conforms to the new event and state system

[33mcommit 0b81ba8cba56489ccd101fc2ee3c92eed7e68e56[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 14:53:03 2024 -0500

    CharacterStates now have a reference to the characterState machine

[33mcommit b8110213c5516290c4cf2e677493552194e67ef1[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 14:51:36 2024 -0500

    The character state machine now keeps track of the current state and enables/disables the states when necessary

[33mcommit e3669878573fec9c71e79ade27dcfc927c718597[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 14:33:27 2024 -0500

    Renamed files to be more descriptive

[33mcommit 516c699c763e3df67a551f3fb96d5b1dcbd98dfd[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 14:27:33 2024 -0500

    The base characterState subscribes its methods to the move events from the controllers. CharacterStats provides a centralized place to hold character info.

[33mcommit a614ba914a724ffe36ebac841ac23f824ca94179[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 13:40:19 2024 -0500

    characterStats simply holds stats for the character

[33mcommit 3099baba92ec4ab1d36c2a8c9ccef75c7fea3dfc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 13:37:38 2024 -0500

    Removed characterBase and added characterStats to hold stats for the character

[33mcommit 94d5b8ecf527518b899719b1098f3b1e89b00cf5[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 13:22:50 2024 -0500

    Renamed Input Directory to contollers

[33mcommit d88f7577b7f912dff80443058a8691b62d6ad84f[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 13:21:06 2024 -0500

    CharacterController Invokes the events. Any derived controller class handles logic for when to invoke the event

[33mcommit 1cad7ab2886193088c08c5668fa0589b8e171fc9[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 22 12:56:13 2024 -0500

    The base character controller class invokes events sothat the character state machine can subscribe to the events

[33mcommit f0b5c784a7f3a5444d46609646722126edd7df0f[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 21 22:09:13 2024 -0500

    Created a character controller base class for controller classes to inherit from

[33mcommit aca1ad97b64099ea3e8497a06e828d321f612023[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:59:28 2024 -0500

    Character can double jump, but happens too soon after firtst jump.

[33mcommit fd65d0c0eefacf1f1fa883ffb62598c5e054649a[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:40:21 2024 -0500

    Fixed bug where player would still be knocked back while blocking

[33mcommit ff1dc1819bbfc4f869a5441996b8a8dbfdc92f0d[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:37:46 2024 -0500

    Added blocking animation to heroknight. Blocking doesn't damage player

[33mcommit fa4102e0ffa1ca2ab28e6819bee305742da82c88[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:32:14 2024 -0500

    Character can now switch to blocking characterState

[33mcommit 01bcffa4038f0d4f6d96f5c7198a8bdf974c53c2[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:31:10 2024 -0500

    Filled out logic for the blocking characterState

[33mcommit 85d9ea3100fa2838f794dc3a83d166fdbde2be90[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:18:21 2024 -0500

    Cleaned up PlayerController methods

[33mcommit 065ed7bd9d1d20febcb439b452ccbbec1c3cbf2f[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:12:09 2024 -0500

    Added input binding for blocking

[33mcommit e85edfad4dce2118e0f6ae08283acb4f2aa9b35b[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 16:06:50 2024 -0500

    Added a blocking character state. When blocking. The character doesn't take damage

[33mcommit 42d9f3f61d98364c12b30f4b20b7bb6e91223d7b[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 15:54:13 2024 -0500

    When the TakeDamage function is called, it sets the character state to hurt

[33mcommit 9af25fcf21448221e2a828870a336e27c7e034d0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 15:51:10 2024 -0500

    Attack component now directly calls TakeDamage and KnockBack functions in the HealthComponent

[33mcommit e41c34ce3a81802dec8c01b89b1bdaef6e09feda[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 15:09:43 2024 -0500

    Function to knock player back can now take a knockback direction vector

[33mcommit ef1c6043ec9c0c1f89ceea0ab4b3485432740ffa[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 14:57:23 2024 -0500

    Added a force that knocks characters back when hit

[33mcommit 6c57a3338f8653835fd22840b49aec3d692e12ac[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 14:46:24 2024 -0500

    Fixed bug where attacking once causes opponent to tak e damage multiple times

[33mcommit 3b93c512fdf66fd9e0f38c6b9425dd9fc9d4e556[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 13:08:28 2024 -0500

    When hurt animation is done, player goes back to idle state

[33mcommit 4c73970499b2fb97711bc13416d05793b3340169[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 12:51:17 2024 -0500

    Added an animation event to heroknight hurt animation that sets the character state back to idle

[33mcommit f05461812f9ca78f742a6e2407940fc29d18f3b8[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 12:48:38 2024 -0500

    Removed stun timer when character is hurt

[33mcommit 96a0ca328560e34a546979f6f83afe14b2d7f2b3[m
Merge: bef2127 565f46d
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Wed Jun 12 00:18:15 2024 -0500

    Merge pull request #9 from jskelly2021/inputSystem
    
    Input system

[33mcommit 565f46db9db328d3b31cdb68f5b2234c836cb114[m[33m ([m[1;31morigin/inputSystem[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 00:14:37 2024 -0500

    The new Unity Input system is now fully integrated with the project

[33mcommit 3ec8db781673b23bd048bdb2f2a36815a6d3a33e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 12 00:12:25 2024 -0500

    Local multiplayer is functional!

[33mcommit b1075d1c5aac3db3d538ccc646be45a961906459[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 23:53:31 2024 -0500

    The input system supports controller

[33mcommit c36c8cb5d2291a84e77206988f8b7bcb52b41c5d[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 23:36:27 2024 -0500

    New input system is working

[33mcommit f6253f49732ce4a5630af86df5757aa3534264af[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 23:32:16 2024 -0500

    Added logic for handling player inputs

[33mcommit 770433de6026adedbdd1708214781daccacdd4aa[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 23:12:56 2024 -0500

    Removed old input system. Started writing new input system

[33mcommit ac955f202fd1bc5cea3e37891f0eff2bf68cc6bd[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 20:38:49 2024 -0500

    Added new InputSystem package and created a player controls profile.

[33mcommit f7c661ac09ac8d6338fef3e7f7f91e67070b55ed[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 18:00:02 2024 -0500

    Made the main camera's view slightly larger

[33mcommit d52ba6aac7fdb7ab3707a1ea70170ffe76c9ad74[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 11 17:55:07 2024 -0500

    Added updated idle, jump, run, and attack animations to Kazuha.

[33mcommit 5e366cfa73f11a66c6b1f3f2d0f16cf6eb7dcebf[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 23:27:37 2024 -0500

    Created a character prefab for Kazuha

[33mcommit bef212776e53d6363df2c1b3399f5dd9ca8aabd7[m
Merge: 3d43144 4c558df
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Sun Jun 9 19:26:09 2024 -0500

    Merge pull request #8 from jskelly2021/menu
    
    Menu

[33mcommit 4c558df25e895ca5d4946b6884c0d439cd08996f[m[33m ([m[1;31morigin/menu[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 19:24:08 2024 -0500

    Very basic main menu is functional

[33mcommit 593d782d29edfa342cf211d08787f31a05aff4b3[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 18:21:05 2024 -0500

    Renamed the main scene to level

[33mcommit 3d431446e2f902d84fa19bb1b024ee51b1d49e82[m
Merge: 34a959a ff262ee
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Sun Jun 9 17:43:21 2024 -0500

    Merge pull request #7 from jskelly2021/multipleAttacks
    
    Multiple attacks

[33mcommit ff262ee76e9a0c2664744f211cb24333dbc75331[m[33m ([m[1;31morigin/multipleAttacks[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 17:40:47 2024 -0500

    System for added multiple attacks is complete

[33mcommit 2f7fe2162470b5fd16789a18fbb70862f9505e19[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 16:47:53 2024 -0500

    Attacking forwards, backwards, and nuetral give different attakcks

[33mcommit e167b5d3227a226096a12678438e700dc71b0bbc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 16:12:07 2024 -0500

    Added animation triggers for the attack states

[33mcommit dfaf725938398b09dce777ff1932c78fdb598315[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 15:54:00 2024 -0500

    Setting up attacks so that the correct attack is performed for the given characterState

[33mcommit 34a959ab61ac58a4e5bb62368486d56f138cdc3f[m
Merge: 3f24758 c799e09
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Sun Jun 9 13:19:43 2024 -0500

    Merge pull request #6 from jskelly2021/optimize
    
    Optimize

[33mcommit c799e09687f7bc264c56868986cc9fbca87f6048[m[33m ([m[1;31morigin/optimize[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 13:16:14 2024 -0500

    Added a wireFrame gizmo around the attack point of the player

[33mcommit 126d921e5c1889fed5da7b7a5098decd6bcc9c86[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 13:02:40 2024 -0500

    Fixed compile erros renaming the character State enun caused

[33mcommit b651608ca6471ed0a25541036ecd0329cc0341ad[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:55:07 2024 -0500

    Changed naming of charactersate enum

[33mcommit 6c6be5e4a55276c07660afc16ad6691d0671a6d5[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:54:05 2024 -0500

    Moved characterState enum to its own file

[33mcommit 786a32859feb153757b980896a02b383135c103a[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:50:59 2024 -0500

    Changed names of properties in CharacterBase and changed functions in character states to be protected

[33mcommit c33f23d37d102255aaba1660789da37d8755a7c0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:16:36 2024 -0500

    Changed names of classes in scripts

[33mcommit 172ed8792a9ea1652b13f92d9fb9d70a9e313549[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:12:15 2024 -0500

    Renamed characterstate files to be more accurate

[33mcommit df2ca73fcde1dd3cc63afcc5cd55a4b827e033d3[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 12:03:49 2024 -0500

    Attacking enemy now looks for characterBase component in the parent

[33mcommit 10d2f1099e7db410ab34d7010b0cbcd0a39c38cb[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 00:57:14 2024 -0500

    Switched CharacterBase to use property accessors

[33mcommit 546b63c2ae11e90d310fab344ddfd704604eab57[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 00:27:30 2024 -0500

    Changed accessers in animation scripts

[33mcommit a827b1dccd9cfd58dcef691ebd880e6da62735c5[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 9 00:14:28 2024 -0500

    Simplified IsGrounded Function

[33mcommit b8afeab50d5b87c75ebbfd3b810812104ed94daa[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 23:12:50 2024 -0500

    Optimized input scripts by moving update function to parent and changing accessors to private

[33mcommit c5bd7b7c604ebe52c24474e2c3e7e61919b0a2d5[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 23:09:08 2024 -0500

    Switched getters and setters to using expression bodied members

[33mcommit 062f1163ab8963471b94bfe94b62e6ace34f9700[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 23:01:33 2024 -0500

    Gave the enemy a new sprite

[33mcommit a6d35431be747060e74afc49526c83e2127d5f86[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 19:56:03 2024 -0500

    Game is functional with movement, animmations, and basic combat system.

[33mcommit 3f24758b327aa52679d5e7aeeb1ce8419e2aea90[m
Merge: 3f081d7 17765c2
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Sat Jun 8 19:51:38 2024 -0500

    Merge pull request #5 from jskelly2021/attacks
    
    Attacks

[33mcommit 17765c28abc82dcba292802c838f219e570bfae2[m[33m ([m[1;31morigin/attacks[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 19:50:15 2024 -0500

    Basic combat system is functional

[33mcommit 8d2cf07bc5b5bc388415f0ac3537d4e86b1909a2[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 19:43:44 2024 -0500

    Hitting an enemy damages it

[33mcommit 345992c5841bc8739a433f79073baf3f3efedf0e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 19:31:38 2024 -0500

    Created the character state for an attack. Moved the sprite to the player object

[33mcommit 4795b1de324e21a18b882c7d3881c6aa00fb8fc4[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 19:13:44 2024 -0500

    Input for attack is now checked. An attack move state is created

[33mcommit 9668928850daebba93c6885f25055284135e547e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 18:59:50 2024 -0500

    Created an attack function

[33mcommit ed9ed7cc3dbbda217903a18adac75126f696b480[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 16:43:28 2024 -0500

    Fixed bug where character state is set back to idle after dying

[33mcommit 6701e02235e3f5a172fad6d5f202f3ecf0eb2c67[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 8 16:32:48 2024 -0500

    Added a left and right wall to the scene

[33mcommit 48c6fafec23a23744101c48fd20b00f94002f6dc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 14:00:59 2024 -0500

    Created an enemy with animation and health, but no input

[33mcommit 7aacc8a784351a73ca1fbb75ecb8bc3a4fda1419[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 13:56:51 2024 -0500

    Added health component to player and fixed Animator

[33mcommit 54e96b33b73624605bedc596ab5afecad6474241[m
Merge: c53e88b eb20520
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Fri Jun 7 13:36:37 2024 -0500

    Merge pull request #4 from jskelly2021/hurt
    
    Hurt

[33mcommit eb205201f880e052e0babb91b7c6ab502eb1cf85[m[33m ([m[1;31morigin/hurt[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 12:40:11 2024 -0500

    Created a health component which, when attached, gives the player health and changes their state to dead when health reaches 0

[33mcommit 0b8f54cd9db4b4b0691ab0f8249dce4b571adf0e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 12:04:52 2024 -0500

    When dead, if player jumps, the character will move to jumping state. Only for testing purposes

[33mcommit acd8784c3b953e0be044a3bfb4c91aa63cd3a539[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 11:59:38 2024 -0500

    Moved the characterStates' fixedUpdate to the parent class

[33mcommit 6475c5f6d2c924854724cb15740462a7d88d258c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 11:53:56 2024 -0500

    Added dead character state

[33mcommit 9de32c9b934f4c5475fcd0d875365964105a5279[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 11:47:35 2024 -0500

    Implemented logic for the player getting hurt

[33mcommit e73f6413bb51259cbd59eb89b1183f33c23a0b30[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 10:55:11 2024 -0500

    Added a hurt characterState

[33mcommit 06ffba8fb398589c56c05036aee7f5f59c255386[m
Merge: c53e88b 24802b4
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Fri Jun 7 01:55:05 2024 -0500

    Merge pull request #3 from jskelly2021/refactor
    
    Refactor

[33mcommit 24802b461b33ce4798ef024b0979bbe9f96ebf83[m[33m ([m[1;31morigin/refactor[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 01:31:21 2024 -0500

    Refactoring is complete

[33mcommit c8a284b74f06ef878eef5eff834a129e504cbd2a[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 01:27:11 2024 -0500

    Moved scripts into respective directories

[33mcommit 87d8549b7ded7d5c49b2e515f92cbcce9a048eab[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri Jun 7 01:06:24 2024 -0500

    characteStates now update themselves, getting the current state from the character base. Game works as before

[33mcommit 50ef13b6dab6667937b6559867ec5e7ba3a505d0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu Jun 6 13:51:58 2024 -0500

    Moved data variables from characterSates to the characterBase class

[33mcommit 7645c70592558541e80483a79ba701ed3c840047[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 22:57:35 2024 -0500

    Added crouch characterState to the player

[33mcommit c9c1424c8b6ecac12ac3677e3001c13ee694d918[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 22:49:31 2024 -0500

    Moved the Update function for Character States into the parent class

[33mcommit b303b78a66730d4e23637026595712de1b69dc94[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 22:32:46 2024 -0500

    Player states can be added by writing them in MoveComponent

[33mcommit 832f252e31110f8911da80f4bd030a1b37ba807c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 19:46:06 2024 -0500

    Added run state to player

[33mcommit 3979aa1ba5db6579d87858ba777b1739581ad322[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 19:41:37 2024 -0500

    Move Component can disable and enable the move states

[33mcommit 00044f3be525b986510ed0433f0823760aa4e5e7[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 19:27:53 2024 -0500

    Adding all characterStates to MoveComponent

[33mcommit 26e18d65d0c0567481f19a2014866d1b6d92f5c7[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 19:14:57 2024 -0500

    MoveComponent adds the current movement state to the player object

[33mcommit 59844161473ab89c20745ef8b401d8e17d383320[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 18:19:53 2024 -0500

    Before moving baseState class from MoveComponent

[33mcommit 63375fd96d17eac50542acdfe0c98a7866cfbeed[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 17:43:32 2024 -0500

    Moved movement scripts into movement director

[33mcommit 8a16528cdaa027da1359bf5886fb5c1d8dd94c76[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 17:37:08 2024 -0500

    Getting movement states at runtime

[33mcommit 59562085ac91ea4871d52fe46562d01bff68efc2[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 15:11:55 2024 -0500

    Created a movement state for when player is jumping

[33mcommit c524479da6479fbc27f57f3363ea303bab7f30e6[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 15:05:06 2024 -0500

    IdleStateMoveAction gives character correct movement fort idle state

[33mcommit ae2ede0c3cc8c1ceec6ceaf46d829660a522695c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 14:39:51 2024 -0500

    Added empty functions to parent moveComponent class so they may be overrriden by children

[33mcommit cb49d128854085f56cb3178ce0899265c2d63dda[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 14:24:28 2024 -0500

    Before implementing StateMachine

[33mcommit 98124daae2e605c8ad89e434abf676669d0d4e68[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 13:06:32 2024 -0500

    Fixed jumping bug by switching to GetKey instead of GetKeyDown

[33mcommit 6935302e218ad2188ba09a145cb28d95183596e7[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 12:54:06 2024 -0500

    Character can move in game

[33mcommit d2ec0ac7ad0e78ebe7af1ba745ed36e7868627fa[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 12:52:05 2024 -0500

    Attaching new scripts to player in Unity

[33mcommit d4b46987e8e84b234f0967e16d85c198976683e0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 12:49:14 2024 -0500

    Removing old input and movement code

[33mcommit 8897f970846e15b958d6f2004413477e79247331[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed Jun 5 01:33:55 2024 -0500

    Setting up CharacterBase to communicate between its components

[33mcommit f25ebc947559351cf61d0f9fad6b07b1cc5a7ac1[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 4 13:12:46 2024 -0500

    Moved movement physics logic from Characterbase to PlayerMovement

[33mcommit 2fc232c70f89719fb3416f8a36dd4a96dd728d91[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 4 12:45:19 2024 -0500

    Set up animation class to handle anims based on character State

[33mcommit 03ce3659dc426e9772e15b4bfeb25be6791dcc84[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 4 12:09:09 2024 -0500

    Commiting before separating movement logic from CharacterBase

[33mcommit 6b716943228031adeca1ef273f8a9ead3ee7342e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 4 12:01:06 2024 -0500

    Setting up classes to work with state machine

[33mcommit 831241078e5926d5c423db2a3f5ea2c14789c538[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue Jun 4 11:48:01 2024 -0500

    Created enum characterState for use in state machine

[33mcommit 0e4b3641e27509e4ed06a64e2fd2bc329d29afd8[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 3 23:17:12 2024 -0500

    Set up PlayerMovement to be further decoupled

[33mcommit 0bec2bb2491e9bf716c8852a42f9b677381991f6[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 3 22:55:20 2024 -0500

    Added basic movement input to PlayerInput

[33mcommit 088fd22419d9f0910276564dacdccb75d055f2bf[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 3 22:37:17 2024 -0500

    Setting up files to use inheritance

[33mcommit 6cb30852675389fc15dcaef5a048415bb3f50af2[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Mon Jun 3 18:36:53 2024 -0500

    Modified CharacterBase to call check if sprite is grounded in Update

[33mcommit 44e6bc9a6e42dd4ecdfe50b8657a6e0cf87d54cc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 17:36:13 2024 -0500

    Updated animation triggers. Finished refactoring input for movement

[33mcommit 94cc9fd2020ca4725cfef17d688a31b449094391[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 17:23:55 2024 -0500

    Refactored playerMovement into CharacterBase and InputMovement

[33mcommit 36718f77d51e82d924536e1240f652bf00d00f26[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 16:03:28 2024 -0500

    Moved scripts into Scripts Directory

[33mcommit 2424683d690164fadcbb1bc60bd3ff32c32a988c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 13:17:36 2024 -0500

    Added hurt and dead animations to player

[33mcommit fa0ec63e20576e1ed4bd80dd6df4dd8fbcc963b0[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 13:03:22 2024 -0500

    Completed the basic logic for taking damage and dying

[33mcommit c53e88bc402883432e48a6319d5bcc5852b95697[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sun Jun 2 01:05:27 2024 -0500

    Attack animations now trigger for player

[33mcommit 5121d3729f3efbbc1643dd2f4f9fe36cb8657956[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 1 15:27:56 2024 -0500

    Wrote logic for animation que in playerAttack.cs

[33mcommit 863dfe77e3216919595ab715e4f0dc9681d4c049[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 1 15:15:02 2024 -0500

    Created 3 attack animations for player

[33mcommit 3f081d7f92a3a7aaae8f37c0e9ab689d48d7739b[m
Merge: 119d1fd cdf15e3
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Sat Jun 1 14:50:57 2024 -0500

    Merge pull request #2 from jskelly2021/movement
    
    Movement

[33mcommit cdf15e37d761c817c15d2fb189401e5d1d4cee46[m[33m ([m[1;31morigin/movement[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Sat Jun 1 14:47:49 2024 -0500

    Added crouching to player object

[33mcommit e418061f24952fc406d8e56698a969d1f2733668[m
Merge: a7f2b90 f56f8b3
Author: Jacob Kelly <113411220+jskelly2021@users.noreply.github.com>
Date:   Fri May 31 18:03:41 2024 -0500

    Merge pull request #1 from jskelly2021/movementAnimations
    
    Movement animations

[33mcommit f56f8b3de495c94d29b51c4e531eeecd9ee94afc[m[33m ([m[1;31morigin/movementAnimations[m[33m)[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 17:58:06 2024 -0500

    Added a jumping animation to the player

[33mcommit c06c5f880029188ad734fdc4488e927e1044271c[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 17:21:06 2024 -0500

    Added idle and running animation to player

[33mcommit 3431b8a33df06d1fd42598458c746699884dfab8[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 16:44:22 2024 -0500

    Created Player_Idle animation

[33mcommit d32f11a366a23d11b4736cf088258c2e14ef7b4e[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 11:48:36 2024 -0500

    Player object appropriately flips scale when moving left or right

[33mcommit e11600e37605ecc1e80a567c77dff6fa0941aa67[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 10:51:07 2024 -0500

    Applied a sprite to the player object

[33mcommit 31ef5e4fd6213bd4f1731acb245c0dc64f4afcdc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Fri May 31 00:48:28 2024 -0500

    Added place holder assets for player character

[33mcommit 3389cbad1cf3335d68dab06b57dde38f0990a73b[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu May 30 17:04:27 2024 -0500

    Updated camera and scene scale

[33mcommit c00fba41cdc9cc3c534ab52242eeb58c8a42e3a5[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu May 30 16:56:01 2024 -0500

    Added Jump capability using a LayerMask for the ground

[33mcommit bdadc4e2ce1b28a89a9e1906ccbd79f2475103fa[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Thu May 30 16:11:13 2024 -0500

    Removed vertical movement and added to player object

[33mcommit a7f2b90ed298ed3b2fbc77d473f28ddc6664cbc1[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed May 29 23:22:05 2024 -0500

    Updated gravity and sensitivity to create snappier movement

[33mcommit de4b4564f3c4a84e2f9dd11b9dcb57d1347a7adc[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed May 29 16:30:49 2024 -0500

    Added basic horizontal and vertical movement

[33mcommit b02cec5de6f8b76483e8ece53bc1da999c2e3c05[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Wed May 29 15:49:43 2024 -0500

    Created player and ground object with colliders

[33mcommit 119d1fd6dd8e17a5d52aea8fadf661738bab9cac[m
Author: Jacob Kelly <jskelly2021@gmail.com>
Date:   Tue May 28 20:29:45 2024 -0500

    Initial commit
