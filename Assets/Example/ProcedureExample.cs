﻿using GameFramework;
using GameFramework.Procedure;
using Msg;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameFrameworkExample
{
    public class ProcedureExample : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            string welcomeMessage = string.Format("Hello! This is an empty project based on Game Framework {0}.", Version.GameFrameworkVersion);
            Log.Info(welcomeMessage);
            Log.Warning(welcomeMessage);
            Log.Error(welcomeMessage);

            Login login = new Login();
            login.Account = "tester";
            login.Passward = "123456";
            int size = login.CalculateSize();
            Log.Info("proto size = " + size);
        }
    }
}
