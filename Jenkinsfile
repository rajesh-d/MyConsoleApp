pipeline {
    agent any

    stages {
        stage('build') {
            steps {
                echo 'build started..'
            }
        }
        
        stage('test') {
            steps {
                echo 'testing started..'
            }
        }
        
         stage('deploy') {
            steps {
                echo 'deployment started..'
            }
        }
    }
    
    post {
        success {
            echo 'build completed..'
        }
    }
}
