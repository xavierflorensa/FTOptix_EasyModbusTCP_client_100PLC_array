#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using EasyModbus;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
     PeriodicTask myTask1;
    

    ModbusClient myModbusClient1;
    ModbusClient myModbusClient2;
    ModbusClient myModbusClient3;
    ModbusClient myModbusClient4;
    ModbusClient myModbusClient5;
    ModbusClient myModbusClient6;
    ModbusClient myModbusClient7;
    ModbusClient myModbusClient8;
    ModbusClient myModbusClient9;
    ModbusClient myModbusClient10;


    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        myModbusClient1 = new ModbusClient("127.0.0.1",502);
        myModbusClient1.Connect();
        myModbusClient2 = new ModbusClient("127.0.0.1",503);
        myModbusClient2.Connect();
        myModbusClient3 = new ModbusClient("127.0.0.1",504);
        myModbusClient3.Connect();
        myModbusClient4 = new ModbusClient("127.0.0.1",505);
        myModbusClient4.Connect();
        myModbusClient5 = new ModbusClient("127.0.0.1",506);
        myModbusClient5.Connect();
        myModbusClient6 = new ModbusClient("127.0.0.1",507);
        myModbusClient6.Connect();
        myModbusClient7 = new ModbusClient("127.0.0.1",508);
        myModbusClient7.Connect();
        myModbusClient8 = new ModbusClient("127.0.0.1",509);
        myModbusClient8.Connect();
        myModbusClient9 = new ModbusClient("127.0.0.1",510);
        myModbusClient9.Connect();
        myModbusClient10 = new ModbusClient("127.0.0.1",511);
        myModbusClient10.Connect();
        
        myTask1 = new PeriodicTask(MB_Lectura_Server1_Task, 100, LogicObject);
        myTask1.Start();
        
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        myTask1.Dispose();
        
    }
    private void MB_Lectura_Server1_Task()
    {
        int[] readHoldingRegisters = myModbusClient1.ReadHoldingRegisters(0,10);

        var SERVER1 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER1");
             
        var arraySERVER1 = (Int32[])SERVER1.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER1[i]=readHoldingRegisters[i];
        }
        SERVER1.SetValue(arraySERVER1);



        int[] readHoldingRegisters2 = myModbusClient2.ReadHoldingRegisters(0,10);

         var SERVER2 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER2");
             
        var arraySERVER2 = (Int32[])SERVER2.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER2[i]=readHoldingRegisters2[i];
        }
        SERVER2.SetValue(arraySERVER2);

        int[] readHoldingRegisters3 = myModbusClient3.ReadHoldingRegisters(0,10);

        var SERVER3 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER3");
             
        var arraySERVER3 = (Int32[])SERVER3.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER3[i]=readHoldingRegisters3[i];
        }
        SERVER3.SetValue(arraySERVER3);

       

        int[] readHoldingRegisters4 = myModbusClient4.ReadHoldingRegisters(0,10);

        var SERVER4 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER4");
             
        var arraySERVER4 = (Int32[])SERVER4.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER4[i]=readHoldingRegisters4[i];
        }
        SERVER4.SetValue(arraySERVER4);

        int[] readHoldingRegisters5 = myModbusClient5.ReadHoldingRegisters(0,10);

        var SERVER5 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER5");
             
        var arraySERVER5 = (Int32[])SERVER5.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER5[i]=readHoldingRegisters5[i];
        }
        SERVER5.SetValue(arraySERVER5);

        int[] readHoldingRegisters6 = myModbusClient6.ReadHoldingRegisters(0,10);

        var SERVER6 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER6");
             
        var arraySERVER6 = (Int32[])SERVER6.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER6[i]=readHoldingRegisters6[i];
        }
        SERVER6.SetValue(arraySERVER6);

        int[] readHoldingRegisters7 = myModbusClient7.ReadHoldingRegisters(0,10);

         var SERVER7 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER7");
             
        var arraySERVER7 = (Int32[])SERVER7.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER7[i]=readHoldingRegisters7[i];
        }
        SERVER7.SetValue(arraySERVER7);

        int[] readHoldingRegisters8 = myModbusClient8.ReadHoldingRegisters(0,10);

        var SERVER8 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER8");
             
        var arraySERVER8 = (Int32[])SERVER8.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER8[i]=readHoldingRegisters8[i];
        }
        SERVER8.SetValue(arraySERVER8);


        int[] readHoldingRegisters9 = myModbusClient9.ReadHoldingRegisters(0,10);

        var SERVER9 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER9");
             
        var arraySERVER9 = (Int32[])SERVER9.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER9[i]=readHoldingRegisters9[i];
        }
        SERVER9.SetValue(arraySERVER9);

        int[] readHoldingRegisters10 = myModbusClient10.ReadHoldingRegisters(0,10);
        var SERVER10 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER10");
             
        var arraySERVER10 = (Int32[])SERVER10.Value.Value;
        for (int i = 0; i < 10; i++) 
        {
            arraySERVER10[i]=readHoldingRegisters10[i];
        }
        SERVER10.SetValue(arraySERVER10);
        
    }

 
}

