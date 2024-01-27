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

Sur la page de connexion, entrez **root** comme nom d'utilisateur sans mot de passe et connectez vous :
![[phpmyadmin_login.png]]
Une fois connectée, cliquez sur **modifier le mot de passe** :
![[phpmyadmin_changepasswordbutton.png]]
Puis dans **Saisir** et **Saisir à nouveau**, entrez le mot de passe `fuy8TLB8FaAQf@_Twu7*Tg3Z@jJ_opUyomn.cwP7`, puis **Exécuter** :
![[phpmyadmin_changepasswordpage 1.png]]
Un fois le mot de passe modifié, créer une **nouvelle base de données** (1.), en la nommant ppe3 (2.), puis en cliquant sur **créer**(3.) :
![[img/phpmyadmin_createDatabase.png]]
Une fois créée, il faut importer les tables et données nécessaire au fonctionnement de l'application.
Pour ce faire, il faut sélectionner la BDD **ppe3**(1.), cliquer sur l'onglet **Importer**(2.), puis sélectionner **Parcourir...**(3.) :
![[img/phpmyadmin_importButton.png]]
En suite sélectionnez le fichier `ppe3.sql` présent dans la racine du projet précédemment téléchargé, et cliquer sur ouvrir :
![[img/phpmyadmin_importFile.png]]
Enfin, descendez en bas de la page et cliquez sur **Importer**:
![[img/phpmyadmin_confirmimportbutton.png]]

La Base de données est dorénavant prête à être utilisée par l'application.
## Structure de la base de donnée
### MCD
![[Pasted image 20240125211843.png]]
## L'application
### Page de connexion
![[Pasted image 20240127115542.png]]
La page de connexion permet d'accéder à l'application destiné aux médecins, accessible en sélectionnant **Utilisateur**.  
Les identifiant mis a disposition pour tester l'application coté médecine sont :
	Username : jean.dupont
	Password : motdepasse123

Ceux cotés Administrateurs sont :
	Username : serv_admin
	Password : motdepasse123

Pour présenter les fonction et méthode utilisé lors de la connexion, je vais seulement montrer celles utilisé pour les médecins car celles utilisées pour les administrateurs sont équivalentes.

La connexion fonctionne de cette manière :
```c#
// connexion sur la base utilisateur
if (comboBox1.Text == "Utilisateur")
{
    string login = usernameTextBox.Text;
    string password = passwordTextBox.Text;
    MedecinDataAccess dataAccess = new MedecinDataAccess();
    // Requete vérifiant la si l'identifiant et le mot de passe de l'utilisateur est correcte 
    Medecin result = dataAccess.ConnectMedecinFromDB(login, password);
    // Si la requete ne retourne rien, alors l'utilisateur est informé que l'identifiant ou le mot de est incorrecte
    if (result.Login == "")
    {
        MessageBox.Show("Identifiant ou mot de passe incorrect");
    }
    // Si l'utilisateur se connecte pour la première fois, il devra modifier son mot de passe 
    else if (dataAccess.VerifyFirstConnection(login) == "Success")
    {
        NewMedecinPassword newPassword = new(login, this);
        newPassword.Show();
        this.Hide();

    }
    // Si tout est correcte, l'utilisateur sera connecté
    else if (dataAccess.VerifyFirstConnection(login) == "Error" && result.Login == login)
    {
        Index index = new(result, this);
        index.Show();
        this.Hide();
    }
    // Prévient de toutes erreurs inconnus
    else
    {
        MessageBox.Show("Une erreur est survenue");
    }
}
```
Pour vérifier la validité des connexions, j'utilise un fonction vérifiant si l'utilisateur existe et si le mot de passe est correcte :
```c#
// Vérifie la validité des identifiant fournie sur la page de connexion
public Medecin ConnectMedecinFromDB(string login, string pass)
{
    using (MySqlConnection conn = new MySqlConnection(connectionString))
    {
        conn.Open();
        // Requete visant à vérifier si l'utilisateur existe et récupère son mot de passe Hashé
        string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";
        // Requete visant à importer les information nécessaire à la création d'un objet Medecin
        string query2 = "SELECT nom_med, prenom_med, naissance_med, login_med FROM medecin WHERE login_med = @login";

        using (MySqlCommand command1 = new MySqlCommand(query1, conn))
        {
            command1.Parameters.AddWithValue("@login", login);
            string result = Convert.ToString(command1.ExecuteScalar());
            // Vérifie si le retour n'est pas null ou vide puis vérifie la validité du mot de passe en utilisant Bcrypt afin
            if (result != null && result != "" && BCrypt.Net.BCrypt.EnhancedVerify(pass, result) == true)
            {
                using (MySqlCommand command2 = new MySqlCommand(query2, conn))
                {
                    command2.Parameters.AddWithValue("@login", login);
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                    DataTable dt = new DataTable();
                    dt.Columns.Add("nom_med", typeof(string));
                    dt.Columns.Add("prenom_med", typeof(string));
                    dt.Columns.Add("naissance_med", typeof(DateTime));
                    dt.Columns.Add("login_med", typeof(string));
                    adapter2.Fill(dt);
                    conn.Close();
                    // Créer un tableau d'objet Medecin qui contiendra forcement qu'un seul élément car la données login_med est forcement Unique
                    List<Medecin> medecins = new();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string nom = row["nom_med"].ToString();
                            string prenom = row["prenom_med"].ToString();
                            DateTime dateTime = (DateTime)row["naissance_med"];
                            string log = row["login_med"].ToString();

                            Medecin med = new(nom, prenom, dateTime, log);

                            medecins.Add(med);
                        }
                        // Retourne le premiere élément du tableau d'objet medecins
                        return medecins[0];
                    }
                    // Retourne un objet medecin contenant des valeurs vide pour signalé que l'utilisateur n'existe pas ou que le mot de passe n'est pas valide
                    else
                    {
                        Medecin med = new("", "", DateTime.UtcNow, "");
                        return med;
                    }
                }
            }
            else
            {
                Medecin med = new("", "", DateTime.UtcNow, "");
                return med;
            }
        }
    }
}
```

Pour vérifier si c'est la première connexion de l'utilisateur j'utilise une données booléen présente dans les tables `medecin` et `admin` nommé respectivement `first_connection_med` et `first_connection_adm`.
La fonction utilisé est celle ci :
```c#
// vérifie si c'est la première connexion de l'utilisateur
public string VerifyFirstConnection(string login)
{
    using (MySqlConnection conn = new(connectionString))
    {
        conn.Open();
        // selectionne la valeur booleen contenu dans la column first_connection_med de la table medecin selon l'idientifiant fournie
        string query = "SELECT first_connection_med FROM medecin WHERE login_med = @login";
        using (MySqlCommand command = new MySqlCommand(query, conn))
        {
            command.Parameters.AddWithValue("@login", login);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            // Si le résultat est 0, la fonction confirme que ce n'est pas la première connexion de l'utilisateur
            if (result == 0)
            {
                return "Error";
            }
            // Sinon, la fonction coonfirme que c'est sa première connexion
            else
            {
                return "Success";
            }
        }
    }
}
```

#### Changement de mot de passe
Dans le cas où l'utilisateur se connecte pour la première fois, il lui sera demandé de modifier son mot de passe afin qu'aucun administrateur ne puisse connaitre son mot de passe après sa première connexion.

La page s'agence comme ceci :
![[Pasted image 20240127174750.png]]

Le code fonctionne comme ceci :
```c#
 private void button1_Click(object sender, EventArgs e)
 {
     MedecinDataAccess dataAccess = new MedecinDataAccess();
     // Vérifie si le mot de passe original est correcte
     string result = dataAccess.VerifyPassword(this.login, original_maskedTextBox.Text.ToString());

     if (result == "Success")
     {
         // Verifie si le nouveau mot de passe est la confirmation du nouveau mot de passe sont les mêmes
         if (new_maskedTextBox.Text == confirmeNew_maskedTextBox.Text)
         {
             // Vérifie si la longueur du mot de passe est supérieur à 8 caractères
             if (new_maskedTextBox.TextLength > 8)
             {
                 // Modifie le mot de passe de l'utilisateur
                 string result2 = dataAccess.UpdateMedecinPasswordInDB(login, new_maskedTextBox.Text);
                 if (result2 == "Success")
                 {
                     MessageBox.Show("Nouveau mot de passe établie");
                     this.Close();
                 }
                 else
                 {
                     MessageBox.Show("Une erreur inconnu c'est produite");
                 }
             }
             else
             {
                 MessageBox.Show("Le mot de passe doit contenir minimum 8 caractères");
             }
         }
         else
         {
             MessageBox.Show("Le mot de passe original ou la confirmation du nouveau mot de passe n'est pas valide");
         }
     }
     else
     {
         MessageBox.Show("Mot de passe original incorrect");
     }
 }
```
Elle appelle la fonction `VerifyPassword` pour vérifier si le mot de passe original est correcte : 
```C#
// Verifie si le mot de passe est correcte
public string VerifyPassword(string login, string password)
{
    using (MySqlConnection conn = new MySqlConnection(connectionString))
    {
        conn.Open();
        // Selectionne le mot de passe Hashé contenue dans la Table medecin
        string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";

        using (MySqlCommand command1 = new MySqlCommand(query1, conn))
        {
            command1.Parameters.AddWithValue("@login", login);
            // Execute la requete
            string result = Convert.ToString(command1.ExecuteScalar());
            // Vérifie si le mot de passe n'est pas null, puis s'il est correcte
            if (result != null && BCrypt.Net.BCrypt.EnhancedVerify(password, result) == true)
            {
                return "Success";
            }
            else
            {
                
                return "Error";
            }
        }
    }
}
```
Si toutes les conditions sont correcte, alors le mot de passe va être mis à jour via la fonction `UpdateMedecinPasswordInDB` :

### Base Utilisateur
