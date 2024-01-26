## Mise en place
### Prérequis
#### .NET Core
En premier temp il faut installer **.NET 7.0** en allant sur le site de Microsoft : 
	[https://dotnet.microsoft.com/en-us/download/dotnet/7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)  
ou directement en cliquant [ici](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.405-windows-x64-installer)
#### Visual C++
En suite, installez **VC++** depuis le lien suivant :
	[https://learn.microsoft.com/fr-fr/cpp/windows/latest-supported-vc-redist?view=msvc-170](https://learn.microsoft.com/fr-fr/cpp/windows/latest-supported-vc-redist?view=msvc-170)
Il faut installer les versions :
- Visual Studio 2015, 2017, 2019 et 2022 **x64**
- Visual Studio 2013 **x64**
- Visual Studio 2013 **x86**
- Visual Studio 2012 **x64**
- Visual Studio 2012 **x86**
- Visual Studio 2010 **x64**
- Visual Studio 2010 **x86**
#### Visual Studio
Visual Studio est l'IDE utilisé pour visualiser le code et les vue du projet.
Il est installable depuis cette page : 
[https://visualstudio.microsoft.com/fr/](https://visualstudio.microsoft.com/fr/)

Il bien installer la version **Community 2022** 
![[Capture d’écran 2024-01-26 130000.jpg]]

Un fois installé, **Visual Studio Installer** vas ce lancer et vous proposer de choisir une "charges de travail", sélectionnez **Développement .NET Desktop** et cliquez sur installer ou modifier en bas a droite :
![[Capture d’écran 2024-01-26 130532.jpg]]

#### WAMP
WAMP est une application permettant de simplement mettre en place une base de données.
Pour l'installation, dirigé vous directement sur le [site officiel de WAMP](https://www.wampserver.com/en/download-wampserver-64bits/), et dans la section Downloads, sélectionner **WAMPSERVER 64 BITS (X64)** et télécharger le sans vous inscrire en cliquant sur **you can download it directly** :
![[Capture d’écran 2024-01-26 133244.jpg]]

Si une erreur ce produit lors de l'installation, c'est surement que l'installation de **Visual C++** n'a pas été faite correctement.

### Installation de l'application
#### Téléchargement du Projet depuis GitHub
Pour le téléchargement, dirigez vous sur la page [GitHub du projet](https://github.com/DavidGailleton/medic-manager-CScharp-PPE3), déroulez l'icone *Code* et cliquez sur *Download ZIP* :
![[Capture d’écran 2024-01-26 131639.jpg]]
Une fois le téléchargement terminé, dirigez vous vers le répertoire **Téléchargements** puis extrayez le projet :
![[Capture d’écran 2024-01-26 132126.jpg]]
![[Capture d’écran 2024-01-26 132256.jpg]]
Une fois extrait, vous devriez retrouver les fichiers du projet de cette manière :
![[Pasted image 20240126132606.png]]

#### Mise en place de Wamp
Si l'installation de wamp c'est bien déroulé, vous devriez pouvoirs le lancer depuis la barre de recherche de Windows : 
![[Pasted image 20240126132730.png]]

Une fois lancé, il devrait être accessible depuis le lien suivant :
http://localhost/phpmyadmin

Sur la page de connexion, 


## Structure de la base de donnée
### MCD
![[Pasted image 20240125211843.png]]
## L'application
### Login
