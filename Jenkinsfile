def project_name = 'airpollution'
def project_path = '/var/lib/docker/volumes/jenkins-data/_data/workspace/' + project_name + '_' + env.BRANCH_NAME

def proj = 'AirPollution'
def dockerfilepath = 'AirPollution'
def shortpath = '/app'
def project_workspace = '/app'
def docker_name = 'airpollution-'+proj.toLowerCase()+':v0.${BUILD_NUMBER}'
def dependencies = []

def hostport = 5050
def dockervolume = 'airpollution'

pipeline {
    agent any 
    stages {	
        stage('Restore Dependecies') {
            steps {
                script {
                    sh 'docker container run --rm -i -v ' + project_path + ':' + shortpath + ' -w ' + project_workspace + ' microsoft/dotnet dotnet restore --source http://83.238.160.91:5998/ --source https://api.nuget.org/v3/index.json'
                }
            }
        }
        stage ('Build for Error') {
            steps {
                script {
                    sh 'rm -rf app'
                    sh 'docker container run --rm -i -v ' + project_path + ':' + shortpath + ' -w ' + project_workspace + ' microsoft/dotnet dotnet build --source http://83.238.160.91:5998/ --source https://api.nuget.org/v3/index.json'
                }
            }
        }

        stage ('Publish') {
            steps {
                script {
                    sh 'docker container run --rm -i -v ' + project_path + ':' + shortpath + ' -w ' + project_workspace + ' microsoft/dotnet dotnet publish -c Release -o out --source http://83.238.160.91:5998/ --source https://api.nuget.org/v3/index.json'
                }
             }
        }
    
        stage ('Build Docker Image') {
            steps {
                script {
                    dir(dockerfilepath) {
                        sh 'docker build . -t ' + docker_name
                    }
                    
                    sh 'docker tag ' + docker_name + ' localhost:5999/' + docker_name
                    sh 'docker push localhost:5999/' + docker_name
                }
            }
        }
    
        stage ('Deploy Container') {
            steps {
                script {
                    sh 'docker stop ' + proj + ' || true && docker rm ' + proj + ' || true'
                    sh 'docker run -d --name ' + proj + ' -p ' + hostport + ':80 localhost:5999/' + docker_name
                }
            }
        }
    }
}
