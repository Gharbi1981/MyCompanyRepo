pipeline {
    agent any
    environment {
        DOTNET_CLI_HOME = '.dotnet'
    }
    stages {
        stage('Checkout') {
            steps {
                checkout scm  // Clone le dépôt
            }
        }
        stage('Restore') {
            steps {
                script {
                    // Restaure les dépendances .NET
                    bat 'dotnet restore'
                }
            }
        }
        stage('Build') {
            steps {
                script {
                    // Compile le projet .NET
                    bat 'dotnet build'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    // Exécute les tests unitaires
                    bat 'dotnet test'
                }
            }
        }
        stage('Publish') {
            steps {
                script {
                    // Publie le projet .NET (prépare pour le déploiement)
                    bat 'dotnet publish -c Release -o ./publish'
                }
            }
        }
        stage('Deploy') {
            steps {
                script {
                    // Déployer l'application (ajoute des étapes de déploiement selon tes besoins)
                    echo 'Déploiement...'
                }
            }
        }
    }
    post {
        always {
            // Actions à exécuter après toutes les étapes, par exemple : nettoyage
            echo 'Fin du pipeline.'
        }
    }
}
