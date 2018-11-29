﻿using System; using System.Collections; using System.Collections.Generic; using System.ComponentModel; using System.Configuration.Install; using System.Linq; using System.Threading.Tasks; using System.ServiceProcess;  namespace FirstWindowsService {     [RunInstaller(true)]     public partial class ProjectInstaller : System.Configuration.Install.Installer     {         public ProjectInstaller()         {             InitializeComponent();             serviceInstaller1.StartType = ServiceStartMode.Automatic;             serviceInstaller1.AfterInstall += serviceInstaller_AfterInstall;         }         private void serviceInstaller_AfterInstall(object sender, InstallEventArgs e)         {             var service = new ServiceController(serviceInstaller1.ServiceName);             if (service.Status != ServiceControllerStatus.Running)             {                 service.Start();             }         }     } } 