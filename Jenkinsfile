pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/crubio21/IntegracionContinua_Poli2024'
            }
        }
        stage('Build Front') {
            steps {
                script {
                    dir('front-end') {
                        sh 'docker build -t front:latest .'
                    }
                }
            }
        }
        stage('Build Back') {
            steps {
                script {
                    dir('back-end') {
                        sh 'docker build -t back:latest .'
                    }
                }
            }
        }
        stage('Deploy') {
            steps {
                script {
                    sh 'docker-compose up -d'
                }
            }
        }
    }

    post {
        always {
            cleanWs()
        }
    }
}
