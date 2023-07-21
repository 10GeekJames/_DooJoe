pipeline {
  agent any
  tools { nodejs 'NODEJS' }
  stages {
    stage('Build Common') {
      steps {
        bat "dotnet publish ${workspace}\\src\\___TMRA.Kernel\\src\\TMRA.Kernel.csproj -c Release  /clp:ErrorsOnly"
        bat "dotnet publish ${workspace}\\src\\++TMRA.Identity\\TMRA.Identity\\src\\TMRA.Identity.STS.Identity\\TMRA.Identity.STS.Identity.csproj -c Release  /clp:ErrorsOnly"
      }
    }
    stage('Build Core Modules') {
        parallel {
          stage('Financial') {
            steps {
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\___TMRA.FinancialAccounts.Core\\src\\TMRA.FinancialAccounts.Core.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\__TMRA.FinancialAccounts.Infrastructure\\src\\TMRA.FinancialAccounts.Infrastructure.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\_TMRA.FinancialAccounts.Api.Common\\src\\TMRA.FinancialAccounts.Api.Common.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\_TMRA.FinancialAccounts.ModuleClientService\\src\\TMRA.FinancialAccounts.ModuleClientService.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\_TMRA.FinancialAccounts.ModuleClientServiceLoader\\src\\TMRA.FinancialAccounts.ModuleClientServiceLoader.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\TMRA.FinancialAccounts.BlazorModule\\src\\TMRA.FinancialAccounts.BlazorModule.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\TMRA.FinancialAccounts.BlazorModuleAdmin\\src\\TMRA.FinancialAccounts.BlazorModuleAdmin.csproj -c Release  /clp:ErrorsOnly"
            }
          }
          
          stage('KnownAccounts') {
            steps {
              sleep 20
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\___TMRA.KnownAccounts.Core\\src\\TMRA.KnownAccounts.Core.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\__TMRA.KnownAccounts.Infrastructure\\src\\TMRA.KnownAccounts.Infrastructure.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\_TMRA.KnownAccounts.Api.Common\\src\\TMRA.KnownAccounts.Api.Common.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\_TMRA.KnownAccounts.ModuleClientService\\src\\TMRA.KnownAccounts.ModuleClientService.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\_TMRA.KnownAccounts.ModuleClientServiceLoader\\src\\TMRA.KnownAccounts.ModuleClientServiceLoader.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\TMRA.KnownAccounts.BlazorModule\\src\\TMRA.KnownAccounts.BlazorModule.csproj -c Release  /clp:ErrorsOnly"
              bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\TMRA.KnownAccounts.BlazorModuleAdmin\\src\\TMRA.KnownAccounts.BlazorModuleAdmin.csproj -c Release  /clp:ErrorsOnly"
            }
          }
        }
    }

    stage('Build Lazy Modules') {
      parallel {
        stage('GameBrains') {
          steps {
            sleep 10
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\___TMRA.GameBrains.Core\\src\\TMRA.GameBrains.Core.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\__TMRA.GameBrains.Infrastructure\\src\\TMRA.GameBrains.Infrastructure.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\_TMRA.GameBrains.Api.Common\\src\\TMRA.GameBrains.Api.Common.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\_TMRA.GameBrains.ModuleClientService\\src\\TMRA.GameBrains.ModuleClientService.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\_TMRA.GameBrains.ModuleClientServiceLoader\\src\\TMRA.GameBrains.ModuleClientServiceLoader.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\TMRA.GameBrains.BlazorModule\\src\\TMRA.GameBrains.BlazorModule.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.GameBrains\\TMRA.GameBrains.BlazorModuleAdmin\\src\\TMRA.GameBrains.BlazorModuleAdmin.csproj -c Release  /clp:ErrorsOnly"
          }
        }  
        stage('UIKit') {
          steps {
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.UIKit\\TMRA.UIKit.BlazorModule\\src\\TMRA.UIKit.BlazorModule.csproj -c Release  /clp:ErrorsOnly"
            bat "dotnet publish ${workspace}\\src\\__TMRA.Lazy\\TMRA.UIKit\\TMRA.UIKit.BlazorModuleAdmin\\src\\TMRA.UIKit.BlazorModuleAdmin.csproj -c Release  /clp:ErrorsOnly"
          }
        }
      }
    }
    stage('Build Blazor Client') {
      steps {
        bat "dotnet publish ${workspace}\\src\\___TMRA.UI.BlazorClient.Common\\src\\TMRA.UI.BlazorClient.Common.csproj -c Release  /clp:ErrorsOnly"
        bat "dotnet publish ${workspace}\\src\\TMRA.UI.BlazorClient\\src\\TMRA.UI.BlazorClient.csproj -c Release  /clp:ErrorsOnly"
      }
    }
    stage('Building Core APIs') {
      steps {
        bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.FinancialAccounts\\+TMRA.FinancialAccounts.Api\\src\\TMRA.FinancialAccounts.Api.csproj -c Release  /clp:ErrorsOnly"
        bat "dotnet publish ${workspace}\\src\\__TMRA.Core\\TMRA.KnownAccounts\\+TMRA.KnownAccounts.Api\\src\\TMRA.KnownAccounts.Api.csproj -c Release  /clp:ErrorsOnly"
      }
    }
    stage('Building Lazy APIs') {
      steps {
        bat "dotnet publish ${workspace}.\\src\\__TMRA.Lazy\\TMRA.GameBrains\\+TMRA.GameBrains.Api\\src\\TMRA.GameBrains.Api.csproj -c Release  /clp:ErrorsOnly"        
      }
    }
    stage('Docker Build Base') {
      steps {
        bat 'docker-compose down --remove-orphans'
        bat 'docker-compose build tmra-shared-base'
        //bat 'docker-compose build tmra-shared-blazor-base'
      }
    }
    stage('Docker Build App') {
      steps {
        bat 'docker-compose build'
      }
    }
    stage('Docker Run') {
      steps {
        bat 'docker-compose up -d'
      }
    }
  }
}
