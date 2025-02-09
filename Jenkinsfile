pipeline {
    agent any
    environment {
        DOTNET_CLI_HOME = '.dotnet'
    }
    triggers {
        githubPush()  // Déclenchement via Webhook
    }
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/Gharbi1981/MyCompanyRepo'
            }
        }
        stage('Restore') {
            steps {
                script {
                    bat 'dotnet restore'
                }
            }
        }
        stage('Build') {
            steps {
                script {
                    bat 'dotnet build'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    bat 'dotnet test'
                }
            }
        }
        stage('Publish') {
            steps {
                script {
                    bat 'dotnet publish -c Release -o ./publish'
                }
            }
        }
        stage('Deploy') {
            steps {
                script {
                    echo 'Déploiement en cours...'
                }
            }
        }
    }
    post {
        always {
            echo 'Pipeline terminé.'
        }
    }
}
