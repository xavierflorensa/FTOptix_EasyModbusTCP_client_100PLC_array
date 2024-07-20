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
        arraySERVER1[0]=readHoldingRegisters[0];
        arraySERVER1[1]=readHoldingRegisters[1];
        arraySERVER1[2]=readHoldingRegisters[2];
        arraySERVER1[3]=readHoldingRegisters[3];
        arraySERVER1[4]=readHoldingRegisters[4];
        arraySERVER1[5]=readHoldingRegisters[5];
        arraySERVER1[6]=readHoldingRegisters[6];
        arraySERVER1[7]=readHoldingRegisters[7];
        arraySERVER1[8]=readHoldingRegisters[8];
        arraySERVER1[9]=readHoldingRegisters[9];
        SERVER1.SetValue(arraySERVER1);



        int[] readHoldingRegisters2 = myModbusClient2.ReadHoldingRegisters(0,10);

         var SERVER2 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER2");
             
        var arraySERVER2 = (Int32[])SERVER2.Value.Value;
        arraySERVER2[0]=readHoldingRegisters2[0];
        arraySERVER2[1]=readHoldingRegisters2[1];
        arraySERVER2[2]=readHoldingRegisters2[2];
        arraySERVER2[3]=readHoldingRegisters2[3];
        arraySERVER2[4]=readHoldingRegisters2[4];
        arraySERVER2[5]=readHoldingRegisters2[5];
        arraySERVER2[6]=readHoldingRegisters2[6];
        arraySERVER2[7]=readHoldingRegisters2[7];
        arraySERVER2[8]=readHoldingRegisters2[8];
        arraySERVER2[9]=readHoldingRegisters2[9];
        SERVER2.SetValue(arraySERVER2);

        int[] readHoldingRegisters3 = myModbusClient3.ReadHoldingRegisters(0,10);

        var SERVER3 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER3");
             
        var arraySERVER3 = (Int32[])SERVER3.Value.Value;
        arraySERVER3[0]=readHoldingRegisters3[0];
        arraySERVER3[1]=readHoldingRegisters3[1];
        arraySERVER3[2]=readHoldingRegisters3[2];
        arraySERVER3[3]=readHoldingRegisters3[3];
        arraySERVER3[4]=readHoldingRegisters3[4];
        arraySERVER3[5]=readHoldingRegisters3[5];
        arraySERVER3[6]=readHoldingRegisters3[6];
        arraySERVER3[7]=readHoldingRegisters3[7];
        arraySERVER3[8]=readHoldingRegisters3[8];
        arraySERVER3[9]=readHoldingRegisters3[9];
        SERVER3.SetValue(arraySERVER3);

       

        int[] readHoldingRegisters4 = myModbusClient4.ReadHoldingRegisters(0,10);

        var SERVER4 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER4");
             
        var arraySERVER4 = (Int32[])SERVER4.Value.Value;
        arraySERVER4[0]=readHoldingRegisters4[0];
        arraySERVER4[1]=readHoldingRegisters4[1];
        arraySERVER4[2]=readHoldingRegisters4[2];
        arraySERVER4[3]=readHoldingRegisters4[3];
        arraySERVER4[4]=readHoldingRegisters4[4];
        arraySERVER4[5]=readHoldingRegisters4[5];
        arraySERVER4[6]=readHoldingRegisters4[6];
        arraySERVER4[7]=readHoldingRegisters4[7];
        arraySERVER4[8]=readHoldingRegisters4[8];
        arraySERVER4[9]=readHoldingRegisters4[9];
        SERVER4.SetValue(arraySERVER4);

        int[] readHoldingRegisters5 = myModbusClient5.ReadHoldingRegisters(0,10);

        var SERVER5 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER5");
             
        var arraySERVER5 = (Int32[])SERVER5.Value.Value;
        arraySERVER5[0]=readHoldingRegisters5[0];
        arraySERVER5[1]=readHoldingRegisters5[1];
        arraySERVER5[2]=readHoldingRegisters5[2];
        arraySERVER5[3]=readHoldingRegisters5[3];
        arraySERVER5[4]=readHoldingRegisters5[4];
        arraySERVER5[5]=readHoldingRegisters5[5];
        arraySERVER5[6]=readHoldingRegisters5[6];
        arraySERVER5[7]=readHoldingRegisters5[7];
        arraySERVER5[8]=readHoldingRegisters5[8];
        arraySERVER5[9]=readHoldingRegisters5[9];
        SERVER5.SetValue(arraySERVER5);

        int[] readHoldingRegisters6 = myModbusClient6.ReadHoldingRegisters(0,10);

        var SERVER6 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER6");
             
        var arraySERVER6 = (Int32[])SERVER6.Value.Value;
        arraySERVER6[0]=readHoldingRegisters6[0];
        arraySERVER6[1]=readHoldingRegisters6[1];
        arraySERVER6[2]=readHoldingRegisters6[2];
        arraySERVER6[3]=readHoldingRegisters6[3];
        arraySERVER6[4]=readHoldingRegisters6[4];
        arraySERVER6[5]=readHoldingRegisters6[5];
        arraySERVER6[6]=readHoldingRegisters6[6];
        arraySERVER6[7]=readHoldingRegisters6[7];
        arraySERVER6[8]=readHoldingRegisters6[8];
        arraySERVER6[9]=readHoldingRegisters6[9];
        SERVER6.SetValue(arraySERVER6);

        int[] readHoldingRegisters7 = myModbusClient7.ReadHoldingRegisters(0,10);

         var SERVER7 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER7");
             
        var arraySERVER7 = (Int32[])SERVER7.Value.Value;
        arraySERVER7[0]=readHoldingRegisters7[0];
        arraySERVER7[1]=readHoldingRegisters7[1];
        arraySERVER7[2]=readHoldingRegisters7[2];
        arraySERVER7[3]=readHoldingRegisters7[3];
        arraySERVER7[4]=readHoldingRegisters7[4];
        arraySERVER7[5]=readHoldingRegisters7[5];
        arraySERVER7[6]=readHoldingRegisters7[6];
        arraySERVER7[7]=readHoldingRegisters7[7];
        arraySERVER7[8]=readHoldingRegisters7[8];
        arraySERVER7[9]=readHoldingRegisters7[9];
        SERVER7.SetValue(arraySERVER7);

        int[] readHoldingRegisters8 = myModbusClient8.ReadHoldingRegisters(0,10);

        var SERVER8 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER8");
             
        var arraySERVER8 = (Int32[])SERVER8.Value.Value;
        arraySERVER8[0]=readHoldingRegisters8[0];
        arraySERVER8[1]=readHoldingRegisters8[1];
        arraySERVER8[2]=readHoldingRegisters8[2];
        arraySERVER8[3]=readHoldingRegisters8[3];
        arraySERVER8[4]=readHoldingRegisters8[4];
        arraySERVER8[5]=readHoldingRegisters8[5];
        arraySERVER8[6]=readHoldingRegisters8[6];
        arraySERVER8[7]=readHoldingRegisters8[7];
        arraySERVER8[8]=readHoldingRegisters8[8];
        arraySERVER8[9]=readHoldingRegisters8[9];
        SERVER8.SetValue(arraySERVER8);


        int[] readHoldingRegisters9 = myModbusClient9.ReadHoldingRegisters(0,10);

        var SERVER9 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER9");
             
        var arraySERVER9 = (Int32[])SERVER9.Value.Value;
        arraySERVER9[0]=readHoldingRegisters9[0];
        arraySERVER9[1]=readHoldingRegisters9[1];
        arraySERVER9[2]=readHoldingRegisters9[2];
        arraySERVER9[3]=readHoldingRegisters9[3];
        arraySERVER9[4]=readHoldingRegisters9[4];
        arraySERVER9[5]=readHoldingRegisters9[5];
        arraySERVER9[6]=readHoldingRegisters9[6];
        arraySERVER9[7]=readHoldingRegisters9[7];
        arraySERVER9[8]=readHoldingRegisters9[8];
        arraySERVER9[9]=readHoldingRegisters9[9];
        SERVER9.SetValue(arraySERVER9);

        int[] readHoldingRegisters10 = myModbusClient10.ReadHoldingRegisters(0,10);
        var SERVER10 = Project.Current.GetVariable("CommDrivers/RAEtherNet_IPDriver1/RAEtherNet_IPStation1/Tags/Controller Tags/SERVER10");
             
        var arraySERVER10 = (Int32[])SERVER10.Value.Value;
        arraySERVER10[0]=readHoldingRegisters10[0];
        arraySERVER10[1]=readHoldingRegisters10[1];
        arraySERVER10[2]=readHoldingRegisters10[2];
        arraySERVER10[3]=readHoldingRegisters10[3];
        arraySERVER10[4]=readHoldingRegisters10[4];
        arraySERVER10[5]=readHoldingRegisters10[5];
        arraySERVER10[6]=readHoldingRegisters10[6];
        arraySERVER10[7]=readHoldingRegisters10[7];
        arraySERVER10[8]=readHoldingRegisters10[8];
        arraySERVER10[9]=readHoldingRegisters10[9];
        SERVER10.SetValue(arraySERVER10);
        
    }

 
}
